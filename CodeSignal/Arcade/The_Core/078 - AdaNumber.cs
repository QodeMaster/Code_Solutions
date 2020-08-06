// Solution

bool adaNumber(string line) {
    string num = string.Join("", line.Split('_'));
    string[] elem = num.Split('#');
    char[] c = new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
    
    if(elem[0] == "") return false;
    if(!num.Contains('#')) return !(new Regex(@"[^\d]").IsMatch(elem[0]));
    if(num.Count(f => f == '#') == 2) {
        if(elem[0] == "" || elem[1] == "") return false;
        int bas = int.Parse(elem[0]);
        if(bas < 2 || 16 < bas) return false;
        elem[1] = elem[1].ToUpper();
        if(!(new Regex(@"[^A-F\d]").IsMatch(elem[1]))) {
            char[] range = c.Take(bas).ToArray();
            foreach(char ch in elem[1]) if(Array.IndexOf(range, ch) == -1) return false;
            return true;
        }
    }
    
    return false;
}
