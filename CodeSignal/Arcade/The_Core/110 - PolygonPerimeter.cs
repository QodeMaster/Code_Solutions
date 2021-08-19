// Solution

int polygonPerimeter(bool[][] matrix) {
    int blackCellCount = 0;
    int connections = 0;
    
    for(int i = 0; i < matrix.Length; i++) {
        for(int j = 0; j < matrix[i].Length; j++) {
            if(matrix[i][j]) {
                blackCellCount++;
                if(0 < i && matrix[i - 1][j]) connections++;
                if(0 < j && matrix[i][j - 1]) connections++;
                if(i + 1 < matrix.Length && matrix[i + 1][j]) connections++;
                if(j + 1 < matrix[i].Length && matrix[i][j + 1]) connections++; 
            }
        }
    }
    
    return blackCellCount * 4 - connections;
}
