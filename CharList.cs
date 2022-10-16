namespace HangMan {
    public class CharList {
        public List<char> List {get; private set;}
        public CharList() {
            this.List = new List<char>();
        }
        public bool Add(char c) {
            if (!Character.IsAccepted(c))
                return false;
            if (this.List.Contains(Char.ToLower(c)))
                return false;
            this.List.Add(Char.ToLower(c));
            return true;
        }
        public override string ToString() {
            string ret = "";
            int size = this.List.Count;
            for (int i = 0; i < size; i++) {
                ret += this.List[i] + ((i == size - 1) ? "" : "|");
            }
            return ret;
        }
    }
}