bool solution(char[][] grid) {
    for(int i = 0; i < grid.Length; i++) {
        int[] row = new int[9];
        int[] col = new int[9]; 
        for(int j = 0; j < 9; j++) {
            if(grid[i][j] != '.') {
                row[grid[i][j] - '1']++;
                if(row[grid[i][j] - '1'] == 2) return false;
            }
            if(grid[j][i] != '.') {
                col[grid[j][i] - '1']++;
                if(col[grid[j][i] - '1'] == 2) return false;
            }
            
        }
    }
    
    for(int i = 1; i < 9; i+=3) {
        for(int j = 1; j < 9; j+=3) {
            int[] alreadyCounted = new int[9];
            for(int k = -1; k < 2; k++) {
                for(int l = -1; l < 2; l++) {
                    if(grid[i + k][j + l] == '.') continue;
                    alreadyCounted[grid[i + k][j + l] - '1']++;
                    if(alreadyCounted[grid[i + k][j + l] - '1'] == 2) return false;
                }
            }
        }
    }
    
    return true;
}
