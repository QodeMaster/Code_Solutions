// Solution

int[][] reverseOnDiagonals(int[][] matrix) {
    int len = matrix.Length - 1;
    int iteraionSteps = matrix.Length / 2;
    
    for(int i = 0; i < iteraionSteps; i++) {
        // Swap upper left element with lower right
        int temp = matrix[i][i];
        matrix[i][i] = matrix[len - i][len - i];
        matrix[len - i][len - i] = temp;
        
        // Swap lower right element with upper left
        temp = matrix[len - i][i];
        matrix[len - i][i] = matrix[i][len - i];
        matrix[i][len - i] = temp;
    }
    
    return matrix;
}
