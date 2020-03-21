// Solution

int[] sortByHeight(int[] a) {
    int[] b = new int[a.Length];
    List<int> order = new List<int>();
    
    for(int i = 0; i < a.Length; i++) {
        if(a[i] == -1) b[i] = -1;
        else order.Add(a[i]);
    }
    int[] s = order.ToArray();
    Array.Sort(s);
    
    int index = 0;
    for(int i = 0; i < b.Length; i++) {
        if(b[i] == -1) continue;
        b[i] = s[index++];
    }
    
    
    return b;
}
