bool beautifulText(string inputString, int l, int r) {
    List<string> str = new List<string>();
    char[] arr = inputString.ToCharArray();
    bool doesExist = false;
    for(int i = l; i <= r + 1; i++) {
        char[] chr = arr.ToArray();
        bool access = true; 
        for(int j = 1; j <= chr.Length; j++) {
            if(j % i == 0) {
                if(chr[j - 1] != ' ') {
                    chr[j - 1] = '*';
                    access = false;
                    break;
                } else {
                    chr[j - 1] = '!';
                }
            }
        }
        if(access) str.Add(String.Join("", chr));
    }
    if(str.Count() == 1) Console.WriteLine(str[0]);
    
    foreach(string s in str) {
        string[] a = s.Split('!');
        if(a.Where(x => a[0].Length == x.Length).Count() == a.Length && (l <= a[0].Length && a[0].Length <= r)) doesExist = true;
    }
    
    return doesExist;
}
