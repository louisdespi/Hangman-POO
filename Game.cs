using System;

namespace HangMan {
    public class Game {
        public HideableWord Word {get;}
        public CharList TriedCharacters {get;}
        public uint Health {get; private set;}
        public Game(string word, uint health) {
            this.Word = new HideableWord(word);
            this.TriedCharacters = new CharList();
            this.Health = health;
        }
        public bool Play() {
            while (Word.NHiddenCharacters > 0) {
                if (this.Health < 1) {
                    Console.Clear();
                    return false;
                }
                char input = '\0';
                do {
                    Console.Clear();
                    Console.WriteLine(this);
                    Console.WriteLine("Veuillez entrer un caractere :");
                    input = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                } while (!IsCharAvailableToPlayer(input));
                if (!Word.CharsMakeVisible(input) && !Word.ValueAsString.ToLower().Contains(Char.ToLower(input))) { // Si la lettre entree n'a pas provoque de changement et que la lettre n'est pas contenue dans le mot
                    this.Health--;
                    TriedCharacters.Add(input);
                }
            }
            Console.Clear();
            return true;
        }
        public bool IsCharAvailableToPlayer(char c) {
            return Character.IsAccepted(c) && Character.HasToHide(c) && !TriedCharacters.List.Contains(c);
        }
        public override string ToString() {
            return String.Format("Mot cache : [{0}]\nVie restante : {1}\nCharacteres essayes : {2}", this.Word, this.Health, this.TriedCharacters);
        }
    }
}