// Solution

int[] switchLights(int[] a) {
    
    for(int i = 0; i < a.Length; i++) {
        if(a[i] == 1) {
            a[i] = 0;
            for(int j = 0; j < i; j++) {
                a[j] = (a[j] + 1) % 2;
            }
        }
    }
    
    return a;
}
