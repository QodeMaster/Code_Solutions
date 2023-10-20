/* Solution using only static arrays */
/* Time  complexity: O(n) */
/* Space complexity: O(1) */

int[][] solution(int[][] a) {
    for(int i = 0; i < a.Length / 2; i++) {
        // Rotating each layer iteratively
        a = layerRotator(a, i, i, a.Length - 1 - i * 2);
    }
    return a;
}

int[][] layerRotator(int[][] a, int iStart, int jStart, int width) {
    for(int i = 0; i < width; i++) {
        int befSwapped = a[iStart + i][jStart + width];
        int aftSwapped;
        
        a[iStart + i][jStart + width] = a[iStart][jStart + i];
        
        aftSwapped = a[iStart + width][jStart + width - i];
        a[iStart + width][jStart + width - i] = befSwapped;
        
        befSwapped = a[iStart + width - i][jStart];
        a[iStart + width - i][jStart] = aftSwapped;
        
        aftSwapped = a[iStart][jStart + i];
        a[iStart][jStart + i] = befSwapped;
    }
    
    return a;
}
