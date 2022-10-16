using System;

namespace HangMan {
    public class Session {
        public WordLibrary Library {get;}
        public Session(List<string> dict) {
            this.Library = new WordLibrary(dict);
        }
    }
}