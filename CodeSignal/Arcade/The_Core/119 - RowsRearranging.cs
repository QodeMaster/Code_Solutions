// Solution

bool solution(int[][] matrix) {
    // Sort all collumn values by switching the row for each column
    for(int i = 0; i < matrix[0].Length; i++) {
        // Bubble sort the columns
        for(int j = 1; j < matrix.Length; j++) {
            for(int k = 0; k < matrix.Length - j; k++) {
                if(matrix[k + 1][i] < matrix[k][i]) {
                    int[] holder = matrix[k];
                    matrix[k] = matrix[k + 1];
                    matrix[k + 1] = holder;
                }
            }
        }
    }
    
    // Check if all columns are strictly increasing
    for(int i = 0; i < matrix[0].Length; i++) {
        for(int j = 0; j < matrix.Length - 1; j++) {
            // Check if it's stricly increasing
            if(matrix[j + 1][i] <= matrix[j][i]) {
                return false;
            }
        }
    }
    
    // Return true, since is strictly increasing
    return true;
}
