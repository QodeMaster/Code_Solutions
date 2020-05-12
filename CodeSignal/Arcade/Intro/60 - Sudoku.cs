// Sudoku

bool sudoku(int[][] grid) {
    int[] digit = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
    int len = grid.Length;

    for(int i = 1; i < len; i += 3) {
        
        for(int j = 1; j < len; j += 3) {
            int sum = 0;
            for(int k = -1; k < 2; k++) {
                for(int l = -1; l < 2; l++) {
                    sum += grid[i + k][j + l];
                }
            }
            if(sum != 45) return false;
        }
    }

    for(int i = 0; i < len; i++) {
        List<int> uniRow = new List<int>();
        List<int> uniCol = new List<int>();
        for(int j = 0; j < len; j++) {
            uniRow.Add(grid[i][j]);
            uniCol.Add(grid[j][i]);
        }

        if(uniRow.Count() != new HashSet<int>(uniRow).Count) return false;
        if(uniCol.Count() != new HashSet<int>(uniCol).Count) return false;
    }

    return true;
}
