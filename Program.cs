using System;

namespace HangMan {
    public class App {
        static void Main(string[] args) {
            Game t = new Game("Louis De Spiegelaere", 10);
            t.Play();
        }
    }
}