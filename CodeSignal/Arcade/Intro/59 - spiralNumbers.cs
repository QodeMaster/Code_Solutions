// Solution

int[][] spiralNumbers(int n) {
    int[][] mat = new int[n][];
    for(int l = 0; l < n; l++) {
        int[] row = new int[n];
        mat[l] = row;
    }
    int direction = 0;

    int i = 0;
    int j = 0;
    for(int num = 1; num <= n * n; num++) {
        switch(direction) {
            case 0:
                if(j + 1 < n) {
                    if(mat[i][j + 1] == 0) {
                        mat[i][j] = num;
                        j++;
                    } else {
                        direction = 1;
                        mat[i][j] = num;
                        i++;
                    }
                } else {
                    mat[i][j] = num;
                    direction = 1;
                    i++;
                }
            break;
            case 1:
                if(i + 1 < n) {
                    if(mat[i + 1][j] == 0) {
                        mat[i][j] = num;
                    i++;
                    } else {
                        direction = 2;
                        mat[i][j] = num;
                        j--;
                    }
                } else {
                    mat[i][j] = num;
                    direction = 2;
                    j--;
                }
            break;
            case 2:
                if(j > 0) {
                    if(mat[i][j - 1] == 0) {
                        mat[i][j] = num;
                        j--;
                    } else {
                        direction = 3;
                        mat[i][j] = num;
                        i--;
                    }
                } else {
                    mat[i][j] = num;
                    direction = 3;
                    i--;
                }
            break;
            case 3:
                if(i > 0) {
                    if(mat[i - 1][j] == 0) {
                        mat[i][j] = num; 
                        i--;
                    } else {
                        mat[i][j] = num;
                        direction = 0;
                        j++;
                    }
                } else {
                    mat[i][j] = num;
                    direction = 0;
                    j++;
                }
            break;
            default:
                Console.WriteLine(num);
                break;
        }
    }

    return mat;
}
