// Basic Solution

int arrayPacking(int[] a) {
    int k = 0;
    int total = 0;

    foreach(int i in a) {
        total += i << (8 * k);
        k++;
    }


    return total;
}

/*---------------------------------------------*/
/*---------------------------------------------*/

// Compact Solution

int arrayPacking(int[] a) {
    int k = 0;
    int total = 0;
    foreach(int i in a) total += i << (8 * k++);
    return total;
}

/*----------------------------------------------*/
/*----------------------------------------------*/

// One-liner

int arrayPacking(int[] a) => a.Reverse().Aggregate((sigBit, total) => (sigBit << 8) + total);
