// Solution

int cyclicString(string s) {
    if(s.Distinct().Count() == 1) return 1;
    List<string> sub = new List<string>();
    int min = 0;
    
    for(int i = 0; i < s.Length; i++) {
        string str = "";
        for(int j = i; j < s.Length; j++) {
            str += s[j];
            if(j != s.Length - 1) sub.Add(str);
        }
        sub.Add(str);
    }
    
    string[] arr = sub.Where(x => s.All(x.Contains)).ToArray();
    
    for(int i = 0; i < arr.Length; i++) {
        int len = arr[i].Length;
        string rep = arr[i] = String.Concat(Enumerable.Repeat(arr[i], 5));
        
        for(int j = 0; j < rep.Length - s.Length; j++) {
            if(rep[j] == s[0]) {
                if(s == rep.Substring(j, s.Length)) min = ((min == 0 || len < min) ? len : min);
            }
        }
    }
    
    return min;
}
