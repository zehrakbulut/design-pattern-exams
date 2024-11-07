using System;
using System.Collections.Generic;

namespace design_pattern_exams
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Oyun karakteri oluşturuluyor
            GameCharacter character = new GameCharacter("Player1", 100, "Start");

            // Caretaker (bakıcı) nesnesi oluşturuluyor
            GameCaretaker caretaker = new GameCaretaker();

            caretaker.SaveState(character.SaveState());

            // Karakterin durumu değiştiriliyor
            character.Health = 80;
            character.Position = "Battlefield";

            caretaker.SaveState(character.SaveState());

            // Durum geri alınıyor
            character.RestoreState(caretaker.GetLastState());
            Console.WriteLine($"Character Health: {character.Health}, Position: {character.Position}");

            // En eski duruma geri dönülüyor
            character.RestoreState(caretaker.GetLastState());
            Console.WriteLine($"Character Health: {character.Health}, Position: {character.Position}");

            Console.ReadLine();
        }

        public class GameCharacter
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public string Position { get; set; }

            public GameCharacter(string name, int health, string position)
            {
                Name = name;
                Health = health;
                Position = position;
            }

            // Memento oluşturma
            public Memento SaveState()
            {
                return new Memento(Health, Position);
            }

            // Memento ile durumu geri yükleme
            public void RestoreState(Memento memento)
            {
                this.Health = memento.Health;
                this.Position = memento.Position;
            }
        }

        public class Memento
        {
            // İç durumu tutar
            public int Health { get; private set; }
            public string Position { get; private set; }

            public Memento(int health, string position)
            {
                Health = health;
                Position = position;
            }
        }

        public class GameCaretaker
        {
            private Stack<Memento> _history = new Stack<Memento>();

            // Durumu kaydetme
            public void SaveState(Memento memento)
            {
                _history.Push(memento);
            }

            // En son kaydedilen durumu alma
            public Memento GetLastState()
            {
                return _history.Count > 0 ? _history.Pop() : null;
            }
        }


    }
}
