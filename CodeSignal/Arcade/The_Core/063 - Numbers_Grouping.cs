// Basic Solution

int numbersGrouping(int[] a) {
    int[] num = new int[a.Length];
    
    for(int i = 0; i < a.Length; i++) {
        a[i] = (a[i] - 1) / 10000;
    }
    
    return a.Distinct().Count() + a.Length;
}

/*--------------------------------------------------------*/
/*--------------------------------------------------------*/

// One-liner

int numbersGrouping(int[] a) => a.Select(x => --x / 10000).Distinct().Count() + a.Length;
