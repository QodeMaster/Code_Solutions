// Solution 

int[] alternatingSums(int[] a) {
    int[] b = new int[] {0, 0};
    
    for(int i = 0; i < a.Length; i++) {
        if((i & 1) == 0) b[0] += a[i];
        else b[1] += a[i];
    }
    
    return b;
}
