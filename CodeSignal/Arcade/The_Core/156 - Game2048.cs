// Solution

int[][] solution(int[][] grid, string path) {
    
    foreach(char c in path) {
        if('D' < c && c < 'U') moveHorizontaly(c == 'R');
        else moveVerticaly(c == 'D');
    } 
    
    void moveHorizontaly(bool moveRight) {
        for(int i = 0; i < grid.Length; i++) {
            int j = moveRight ? grid[0].Length - 1 : 0;
            List<int> alreadyMerged = new List<int>();
            for(; (moveRight ? 0 <= j : j < grid[0].Length); j += (moveRight ? -1 : 1)) {
                if(grid[i][j] != 0) {
                    bool stay = true;
                    int dk    = moveRight ? 1 : -1;
                    for(int k = 0; 
                    (moveRight ? (k + j < grid[0].Length - 1) : 1 <= j - k) && stay; k++) {
                        int dkk = dk * (k + 1); 
                        if(grid[i][j + dkk] == 0) {
                            grid[i][j + dkk] = grid[i][j + dk * k];
                            grid[i][j + dk * k] = 0;
                        } else if(grid[i][j + dkk] == grid[i][j + dk * k] 
                        && !alreadyMerged.Contains(i * 10 + j + dkk)) {
                            alreadyMerged.Add(i * 10 + j + dkk);
                            grid[i][j + dkk] *= 2;
                            grid[i][j + dk * k] = 0;
                            k++;
                        } else  stay = false; 
                    }    
                }
            }
        }
    }
    
    void moveVerticaly(bool moveDown) {
        for(int j = 0; j < grid[0].Length; j++) {
            int i = moveDown ? grid.Length - 1 : 0;
            List<int> alreadyMerged = new List<int>();
            for(; (moveDown ? 0 <= i : i < grid.Length); i += (moveDown ? -1 : 1)) {
                if(grid[i][j] != 0) {
                    bool stay = true;
                    int dk    = moveDown ? 1 : -1;
                    for(int k = 0; 
                    (moveDown ? (k + i < grid.Length - 1) : 1 <= i - k) && stay; k++) {
                        int dkk = dk * (k + 1); 
                        if(grid[i + dkk][j] == 0) {
                            grid[i + dkk][j] = grid[i + dk * k][j];
                            grid[i + dk * k][j] = 0;
                        } else if(grid[i + dkk][j] == grid[i + dk * k][j] 
                        && !alreadyMerged.Contains(i * 10 + j + dkk)) {
                            alreadyMerged.Add(i * 10 + j + dkk);
                            grid[i + dkk][j] *= 2;
                            grid[i + dk * k][j] = 0;
                            k++;
                        } else  stay = false; 
                    }
                }
            } 
        }
    }
    
    
    return grid;
}
