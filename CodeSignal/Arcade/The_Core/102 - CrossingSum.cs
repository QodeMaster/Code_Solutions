// Basic Solution

int crossingSum(int[][] matrix, int a, int b) {
    int sum = 0;
    
    for(int i = 0; i < matrix.Length; i++) {
        sum += matrix[i][b];
    }
    
    return sum + matrix[a].Sum() - matrix[a][b];
}

/*------------------------------------------------*/
/*------------------------------------------------*/

// One-liner

int crossingSum(int[][] matrix, int a, int b) => matrix.Select(x => x[b]).Sum() + matrix[a].Sum() - matrix[a][b];
