// Solution

int[][] boxBlur(int[][] image) {
    int len = image.Length - 1;
    int lenRow = image[0].Length - 1;
    int[][] grid = new int[len - 1][];
    
    for(int i = 1; i < len; i++) {
        int[] row = new int[lenRow - 1];
        for(int j = 1; j < lenRow; j++) {
            int count = 0;
            for(int k = -1; k < 2; k++) {
                for(int l = -1; l < 2; l++) {
                    count += image[i + k][j + l];
                }
            }
            row[j - 1] = ~~(count / 9);
        }
        grid[i - 1] = row;
    }
    
    return grid;
}
