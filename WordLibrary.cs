namespace HangMan {
    public class WordLibrary {
        public List<string> Words {get;}
        public WordLibrary(List<string> words) {
            Words = new List<string>(words);
        }
        public string GetRandomWord(bool remove) {
            if (this.Words.Count < 1)
                return null;
            Random rnd = new Random();
            string ret;
            int index = rnd.Next(0, this.Words.Count);
            ret = this.Words[index];
            if (remove) this.Words.RemoveAt(index);
            return ret;
        }
    }
}