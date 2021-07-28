// Solution

bool sudoku(int[][] grid) {
    
    int[] digits = new int[9];
    for(int i = 1; i < 9; i+=3) {
        for(int j = 1; j < 9; j+=3) {
            for(int k = -1; k < 2; k++) {
                for(int l = -1; l < 2; l++) {
                    digits[grid[i + k][j + l] - 1]++;
                }
            }
            if(!digits.All(x => x == 1)) return false;
            digits = new int[9];
        }
    }
    
    int[] auxiliary = new int[9];
    for(int i = 0; i < 9; i++) {
        for(int j = 0; j < 9; j++) {
            digits[grid[i][j] - 1]++;
            auxiliary[grid[j][i] - 1]++;
        }
        if(!digits.All(x => x == 1) || !auxiliary.All(x => x == 1)) return false;
        digits = new int[9];
        auxiliary = new int[9];
    }
    
    return true;
}
