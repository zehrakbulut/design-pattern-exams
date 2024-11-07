using System;
using System.Collections.Generic;

namespace design_pattern_exams
{
    public class Program
    {
        static void Main(string[] args)
        {
            MediaPlayerContext mediaPlayer = new MediaPlayerContext();

            mediaPlayer.Play();   // Başlangıç: Çalma moduna geç
            mediaPlayer.Pause();  // Duraklat
            mediaPlayer.Play();   // Devam et
            mediaPlayer.Stop();   // Durdur
            mediaPlayer.Pause();  // Hatalı kullanım, çünkü durdurulmuş durumda

            Console.ReadLine();
        }

        public class MediaPlayerContext
        {
            private IMediaPlayerState _state;

            public MediaPlayerContext()
            {
                _state = new StoppedState();  // Başlangıç durumu
            }

            public void SetState(IMediaPlayerState state)
            {
                _state = state;
            }

            public void Play()
            {
                _state.Play(this);
            }

            public void Pause()
            {
                _state.Pause(this);
            }

            public void Stop()
            {
                _state.Stop(this);
            }
        }

        public interface IMediaPlayerState
        {
            void Play(MediaPlayerContext context);
            void Pause(MediaPlayerContext context);
            void Stop(MediaPlayerContext context);
        }


        public class PlayingState : IMediaPlayerState
        {
            public void Play(MediaPlayerContext context)
            {
                Console.WriteLine("Already playing.");
            }

            public void Pause(MediaPlayerContext context)
            {
                Console.WriteLine("Pausing the media player.");
                context.SetState(new PausedState());
            }

            public void Stop(MediaPlayerContext context)
            {
                Console.WriteLine("Stopping the media player.");
                context.SetState(new StoppedState());
            }
        }


        public class PausedState : IMediaPlayerState
        {
            public void Play(MediaPlayerContext context)
            {
                Console.WriteLine("Resuming the media player.");
                context.SetState(new PlayingState());
            }

            public void Pause(MediaPlayerContext context)
            {
                Console.WriteLine("Already paused.");
            }

            public void Stop(MediaPlayerContext context)
            {
                Console.WriteLine("Stopping the media player from pause.");
                context.SetState(new StoppedState());
            }
        }

        public class StoppedState : IMediaPlayerState
        {
            public void Play(MediaPlayerContext context)
            {
                Console.WriteLine("Starting the media player.");
                context.SetState(new PlayingState());
            }

            public void Pause(MediaPlayerContext context)
            {
                Console.WriteLine("Cannot pause. The media player is stopped.");
            }

            public void Stop(MediaPlayerContext context)
            {
                Console.WriteLine("Already stopped.");
            }
        }
    }
}
