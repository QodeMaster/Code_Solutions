// Basic Solution 

int[] concatenateArrays(int[] a, int[] b) {
    int[] arr = new int[a.Length + b.Length];
    
    for(int i = 0; i < arr.Length; i++) {
        if(i < a.Length) arr[i] = a[i];
        else arr[i] = b[i - a.Length];
    }
    
    return arr;
}

/*-------------------------------------------------*/
/*-------------------------------------------------*/

// One-liner

int[] concatenateArrays(int[] a, int[] b) => a.Concat(b).ToArray();
