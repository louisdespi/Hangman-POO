using System;

namespace HangMan {
    public class App {
        static void Main(string[] args) {
            Game t = new Game("Louis De Spiegelaere", 10);
            if (t.Play())
                Console.WriteLine("C'est gagne !");
            else
                Console.WriteLine("C'est perdu !");
        }
    }
}