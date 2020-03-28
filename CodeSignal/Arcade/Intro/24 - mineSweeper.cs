// Solution

int[][] minesweeper(bool[][] matrix) {
    int len = matrix.Length;
    int iLen = matrix[0].Length;
    int[][] newMat = new int[len][];
    
    for(int i = 0; i < len; i++) {
        int[] row = new int[iLen];
        
        for(int j = 0; j < iLen; j++) {
            int sum = 0;
            
            for(int k = -1; k < 2; k++) {
                if(i + k < 0 || i + k >= len) continue;
                for(int l = -1; l < 2; l++) {
                    if(j + l < 0 || j + l >= iLen) continue;
                    if(k == 0 && l == 0) continue;
                    if(matrix[i + k][j + l]) sum++;
                }
            }
            
            row[j] = sum;
        }
        
        newMat[i] = row;
    }
    
    
    return newMat;

}
