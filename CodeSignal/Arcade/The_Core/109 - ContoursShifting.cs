// Solution

int[][] contoursShifting(int[][] matrix) {
    int holder;
    int nextHolder;
    int wid = matrix[0].Length;
    int hei = matrix.Length;
    int limit = Math.Min(hei, wid) / 2;
    bool IsBackwards = false;
    bool isVertLeft = (wid < hei && wid % 2 == 1);
    bool isHorzLeft = (hei < wid && hei % 2 == 1);
    
    for(int i = 0; i < limit; i++) {
        traverse(2 * (wid + hei - 2 - (4 * i)), i, i, i, (IsBackwards ? 1 : 0));
        IsBackwards = !IsBackwards;
    }
    
    void traverse(int steps, int i, int j, int padding, int direction) {
        nextHolder = matrix[i][j];
        int vr = 1;
        int vd = 0;
        while(0 < steps) {
            holder = nextHolder;
            switch(direction) {
                case 0:
                    vr = 1;
                    vd = 0;
                    direction = (IsBackwards ? (wid < j + 3 + padding ? 3 : 0) : (wid < j + 3 + padding ? 1 : 0));
                    break;
                case 1:
                    vr = 0;
                    vd = 1;
                    direction = (IsBackwards ? (hei < i + 3 + padding ? 0 : 1) : (hei < i + 3 + padding ? 2 : 1));
                    break;
                case 2:
                    vr = -1;
                    vd = 0;
                    direction = (IsBackwards ? (j - 2 < padding ? 1 : 2) : (j - 2 < padding ? 3 : 2));
                    break;
                case 3:
                    vr = 0;
                    vd = -1;
                    direction = (IsBackwards ? (i - 2 < padding ? 2 : 3) : (i - 2 < padding ? 0 : 3));
                    break;
                default:
                    Console.WriteLine("ERROR!!!");
                    break;
            }
            i += vd; 
            j += vr;
            nextHolder = matrix[i][j];
            matrix[i][j] = holder;
            
            steps--;
        }
    }
    
    int prev;
    if(isVertLeft) {
        if(IsBackwards) {
            int mem = matrix[hei - limit - 1][limit];
            for(int i = hei - limit - 1; limit <= i; i--) {
                prev = mem;
                mem = matrix[i][limit];
                matrix[i][limit] = prev;
            }
            matrix[hei - limit - 1][limit] = mem;
        } else {
            int mem = matrix[limit][limit];
            for(int i = limit + 1; i < hei - limit; i++) {
                prev = mem;
                mem  = matrix[i][limit];
                matrix[i][limit] = prev;
            }   
            matrix[limit][limit] = mem;
        }
    } else if(isHorzLeft) {
        if(IsBackwards) {
            int mem = matrix[limit][wid - limit - 1];
            for(int i = wid - limit - 1; limit <= i; i--) {
                prev = mem;
                mem = matrix[limit][i];
                matrix[limit][i] = prev;
            }
            matrix[limit][wid - limit - 1] = mem;
        } else {
            int mem = matrix[limit][limit];
            for(int i = limit + 1; i < wid - limit; i++) {
                prev = mem;
                mem  = matrix[limit][i];
                matrix[limit][i] = prev;
            }
            matrix[limit][limit] = mem;
        }
    }
    
    return matrix;
}
