using System;

namespace HangMan {
    public class Character {
        public char Value {get; private set;}
        public bool Visible {get; private set;}
        public Character(char c) {
            if (!Character.IsAccepted(c))
                throw new Exception("HangMan.Character : Attempt to instanciate a HangMan.Character with avoided character");
            this.Value = c;
            this.Visible = (Character.HasToHide(c)) ? false : true;
        }
        public static bool IsAccepted(char c) {
            return Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c) || /*Char.IsPunctuation(c)* ||*/ c == '-';
        }
        public static bool HasToHide(char c) {
            return Char.IsLetterOrDigit(c);
        }
        public bool MakeVisible() {
            if (this.Visible) return false;
            this.Visible = true;
            return true;
        }
        public bool CompareChar(char c) {
            return Char.ToLower(this.Value) == Char.ToLower(c);
        }
        public override string ToString() {
            return (this.Visible) ? this.Value.ToString() : "_";
        }
    }
}