// Solution

int[] solution(int[] a) {
    List<int> list = new List<int>();
    
    // Collect every non-tree
    foreach(int height in a) if(height != -1) list.Add(height);
    
    // Sort all heights in ascending order
    list.Sort();
    
    // Replace people in a with list to get sorted array
    int idx = 0;
    for(int i = 0; i < a.Length; i++) {
        if(a[i] != -1) {
            a[i] = list[idx]; 
            idx++;
        }
    }
    
    return a;
}
