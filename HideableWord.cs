using System;

namespace HangMan {
    public class HideableWord {
        public Character[] Value {get; private set;}
        public string ValueAsString {get;}
        public HideableWord(string word) {
            this.ValueAsString = word;
            this.Value = new Character[this.ValueAsString.Length];
            try {
                for (int i = 0; i < word.Length; i++) {
                    this.Value[i] = new Character(word[i]);
                }
            } catch (Exception e) {
                throw new Exception(e.Message);
            }
        }
        public bool CharsMakeVisible(char c) {
            bool wordModified = false;
            foreach (Character character in this.Value) {
                if (character.CompareChar(c)) {
                    if (character.MakeVisible())
                        wordModified = true;
                }
            }
            return wordModified;
        }
        public uint NHiddenCharacters {
            get {
                uint i = 0;
                foreach (Character c in this.Value) {
                    if (!c.Visible) i++;
                }
                return i;
            }
        }
        public uint NShownCharacters {
            get {
                uint i = 0;
                foreach (Character c in this.Value) {
                    if (c.Visible) i++;
                }
                return i;
            }
        }
        public override string ToString() {
            string ret = "";
            foreach (Character c in this.Value) {
                ret += c;
            }
            return ret;
        }
    }
}