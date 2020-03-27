// Solution

int[][] boxBlur(int[][] image) {
    int len = image.Length - 2;
    int iLen = image[0].Length - 2;
    int[][] pic = new int[len][];
    
    for(int i = 1; i <= len; i++) {
        int[] row = new int[iLen];
        
        for(int j = 1; j <= iLen; j++) {
            int sum = 0;
            
            for(int k = -1; k < 2; k++) for(int l = -1; l < 2; l++) sum += image[i + k][j + l];
            row[j - 1] = ~~(sum / 9);
        }
        
        pic[i - 1] = row;
    }
    
    
    return pic;
}
