// Solution

int matrixElementsSum(int[][] matrix) {
    int totCost = 0;
    string haunt = "";
    
    for(int i = 0; i < matrix.Length; i++) {
        
        
        for(int j = 0; j < matrix[i].Length; j++) {
            if(matrix[i][j] == 0) {
                haunt += $"{j}";
                continue;
            }
            if(haunt.Contains($"{j}")) continue;
            totCost += matrix[i][j];
        }
    }
    
    return totCost;
}
