/*
  This solution involves rotating each of the outer segment of the rays of the star.
  The algorithm works it way inward until it reaches the center.
  One can also use stacks to achieve the same goal however they are not used in this algorithm. 
*/

// Solution

int[][] starRotation(int[][] matrix, int width, int[] center, int t) {
    t %= 8;
    if(t == 0) return matrix;
    
    void swap(int[][] arr, int i1, int i2, int j1, int j2) {
        int temp = arr[i1][i2];
        arr[i1][i2] = arr[j1][j2];
        arr[j1][j2] = temp;
    }
    
    int[][] sqr = new int[width][];
    int len = width - 1;
    int r = len / 2;
    
    for(int i = center[0] - r; i <= center[0] + r; i++) {
        int[] row = new int[width];
        for(int j = center[1] - r; j <= center[1] + r; j++) {
            row[r - center[1] + j] = matrix[i][j];
        }
        sqr[r - center[0] + i] = row;
    }
    
    if(t == 4) {
        int[] ram = new int[r];  
        for(int i = 0; i < r; i++) {
            swap(sqr, i, i, len - i, len - i);
            swap(sqr, i, len - i, len - i, i);
            swap(sqr, i, r, len - i, r);
            swap(sqr, r, len - i, r, i);
        }
    } else {
        int holderElem = 0;
        void traverse(int steps, int i, int j, int padding, int stepElem, int direction) {
            int vr = 1;
            int vd = 0;
            
            while(0 < steps) {
                switch(direction) {
                    case 0:
                        vr = 1;
                        vd = 0;
                        direction = (len < j + 2 + padding ? 1 : 0);
                        break;
                    case 1:
                        vr = 0;
                        vd = 1;
                        direction = (len < i + 2 + padding ? 2 : 1);
                        break;
                    case 2:
                        vr = -1;
                        vd = 0;
                        direction = (j - 2 < padding ? 3 : 2);
                        break;
                    case 3:
                        vr = 0;
                        vd = -1;
                        direction = (i - 2 < padding ? 0 : 3);
                        break;
                    default:
                        Console.WriteLine("ERROR!!!");
                        break;
                }
                i += vd; 
                j += vr;
                
                steps--;
            }
            holderElem = sqr[i][j];
            sqr[i][j] = stepElem;
        }
        
        for(int i = 0; i < r; i++) {
            int location = 0;
            for(int j = 0; j < 8; j++) {
                switch(location) {
                    case 0:
                        traverse(t * (r - i),         i,         i, i, sqr[i][i], 0);
                        break;
                    case 1:
                        traverse(t * (r - i),         i,     1 * r, i, holderElem, 0);
                        break;
                    case 2:
                        traverse(t * (r - i),         i, 2 * r - i, i, holderElem, 1);
                        break;
                    case 3:
                        traverse(t * (r - i),     1 * r, 2 * r - i, i, holderElem, 1);
                        break;
                    case 4:
                        traverse(t * (r - i), 2 * r - i, 2 * r - i, i, holderElem, 2);
                        break;
                    case 5:
                        traverse(t * (r - i), 2 * r - i,     1 * r, i, holderElem, 2);
                        break;
                    case 6:
                        traverse(t * (r - i), 2 * r - i,         i, i, holderElem, 3);
                        break;
                    case 7:
                        traverse(t * (r - i),     1 * r,         i, i, holderElem, 3);
                        break;
                    default:
                        Console.WriteLine("ERRONOUS!!!");
                        break;
                        
                }
                location = (location + t) % 8;
            }    
        }
    }
    
    for(int i = center[0] - r; i <= center[0] + r; i++) {
        for(int j = center[1] - r; j <= center[1] + r; j++) {
            matrix[i][j] = sqr[r - center[0] + i][r - center[1] + j];
        }
    }

    return matrix;
}
