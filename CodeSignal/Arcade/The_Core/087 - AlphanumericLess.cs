// Solution

bool alphanumericLess(string s1, string s2) {
    List<string> s11 = fillList(s1);
    List<string> s22 = fillList(s2);
    int len = Math.Min(s11.Count(), s22.Count());
    int leadZero = -2;
    
    for(int i = 0; i < len; i++) {
        if(s11[i] != s22[i]) {
            bool a = long.TryParse(s11[i], out long ai);
            bool b = long.TryParse(s22[i], out long bi);
            
            string[] comp = new string[] { s22[i], s11[i] };
            comp = comp.OrderBy(x => x).ToArray();
            
            if((a && b) && (ai == bi)) {
                if(leadZero == -2) leadZero = i;
                continue;
            }
            if(a && b) return ai < bi;
            
            return s11[i] == comp[0];
        }
    }
    
    if(leadZero != -2) return isSmaller(s11[leadZero], s22[leadZero]);
    
    return s1.Length < s2.Length;
}

List<string> fillList(string s) {
    List<string> list = new List<string>();
    
    string temp = "";
    for(int i = 0; i < s.Length; i++) {
        if(!char.IsDigit(s[i])) {
            if(temp != "") list.Add(temp);
            list.Add($"{s[i]}");
            temp = "";
        } else {
            temp += s[i];    
        }
        if(i == s.Length - 1 && temp != "") list.Add(temp);
    }
    
    return list;
}

static bool isSmaller(string str1, string str2) {
    int count = 0;
    foreach(char c in str1) {
        if(c != '0') break;
        count++;
    }
    foreach(char c in str2) {
        if(c != '0') break;
        count--;
    }
    
    return 0 < count;
}
