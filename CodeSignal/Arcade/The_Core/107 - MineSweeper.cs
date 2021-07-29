// Solution

int[][] minesweeper(bool[][] matrix) {
    int len = matrix.Length;
    int lenRow = matrix[0].Length;
    int[][] grid = new int[len][];
    
    for(int i = 0; i < len; i++) {
        int[] row = new int[lenRow];
        for(int j = 0; j < lenRow; j++) {
            int count = 0;
            for(int k = -1; k < 2; k++) {
                if(-1 < i + k && i + k < len) {
                    for(int l = -1; l < 2; l++) {
                        if(-1 < j + l && j + l < lenRow && !(k == 0 && l == 0)) {
                            count += (matrix[i + k][j + l] ? 1 : 0);
                        }
                    }
                }
            }
            row[j] = count;
        }
        grid[i] = row;
    }
    
    return grid;
}
