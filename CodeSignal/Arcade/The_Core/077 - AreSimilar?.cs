// Basic Solution

bool areSimilar(int[] a, int[] b) {
    int count = 0;
    int[] atwo = new int[2];
    int[] btwo = new int[2];
    int index = 0;
    
    for(int i = 0; i < a.Length; i++) {
        if(a[i] != b[i]) {
            count++;
            if(count == 3) return false;
            atwo[index] = a[i];
            btwo[index++] = b[i];
        }
    }
    
    Array.Reverse(atwo);
    
    for(int i = 0; i < atwo.Length; i++) if(atwo[i] != btwo[i]) return false;
    
    return true;
}

/*--------------------------------------------------------------------------------*/
/*--------------------------------------------------------------------------------*/

// Shorter Solution

bool areSimilar(int[] a, int[] b) {
    List<int> list = a.ToList();
    int strike = 0;
    
    for(int i = 0; i < a.Length; i++) {
        if(a[i] != b[i]) strike++;
        if(list.Contains(b[i])) list.Remove(b[i]);
    }
    
    return ((list.Count() == 0) && (strike == 0 || strike == 2));
}
