// Basic Solution

int[] extractMatrixColumn(int[][] matrix, int column) {
    int[] cln = new int[matrix.Length];
    for(int i = 0; i < matrix.Length; i++) {
        cln[i] = matrix[i][column];
    }
    
    return cln;
}

/*----------------------------------------------------*/
/*----------------------------------------------------*/

// One-liner

int[] extractMatrixColumn(int[][] matrix, int column) => matrix.Select(x => x[column]).ToArray();
