// Solution

int[] solution(string king, string amazon) {
    int[] kingPos   = new int[] { king[0]   - 'a', king[1] - '1' };
    int[] amazPos   = new int[] { amazon[0] - 'a', amazon[1] - '1' };
    int[] returnArr = new int[4];
    
    char[][] board = new char[8][];
    
    for(int i = 0; i < 8; i++) {
        board[i] = new char[] { '0', '0', '0', '0', '0', '0', '0', '0' };
    }
    
    board[kingPos[1]][kingPos[0]] = 'K';
    board[amazPos[1]][amazPos[0]] = 'A';
    bool amazonStandsAlone = determineIfAmazonStandsAlone(amazPos[1], amazPos[0], board);
    
    // Up
    int j = 1;
    while(0 <= amazPos[1] - j && board[amazPos[1] - j][amazPos[0]] != 'K') {
        board[amazPos[1] - j][amazPos[0]] = '+'; 
        j++;
    }
    // Down
    j = 1;
    while(amazPos[1] + j < 8  && board[amazPos[1] + j][amazPos[0]] != 'K') {
        board[amazPos[1] + j][amazPos[0]] = '+'; 
        j++;
    }
    // Left 
    j = 1;
    while(0 <= amazPos[0] - j && board[amazPos[1]][amazPos[0] - j] != 'K') {
        board[amazPos[1]][amazPos[0] - j] = '+'; 
        j++;
    }
    // Right 
    j = 1;
    while(amazPos[0] + j < 8  && board[amazPos[1]][amazPos[0] + j] != 'K') {
        board[amazPos[1]][amazPos[0] + j] = '+'; 
        j++;
    }
    
    // Up-left
    j = 1;
    while(0 <= amazPos[1] - j && 0 <= amazPos[0] - j && board[amazPos[1] - j][amazPos[0] - j] != 'K') {
        board[amazPos[1] - j][amazPos[0] - j] = '+'; 
        j++;
    }
    // Up-right
    j = 1;
    while(0 <= amazPos[1] - j && amazPos[0] + j < 8  && board[amazPos[1] - j][amazPos[0] + j] != 'K') {
        board[amazPos[1] - j][amazPos[0] + j] = '+'; 
        j++;
    }
    // Down-Left 
    j = 1;
    while(amazPos[1] + j < 8  && 0 <= amazPos[0] - j && board[amazPos[1] + j][amazPos[0] - j] != 'K') {
        board[amazPos[1] + j][amazPos[0] - j] = '+'; 
        j++;
    }
    // Down-Right 
    j = 1;
    while(amazPos[1] + j < 8  && amazPos[0] + j < 8  && board[amazPos[1] + j][amazPos[0] + j] != 'K') {
        board[amazPos[1] + j][amazPos[0] + j] = '+'; 
        j++;
    }
    
    for(int i = -2; i < 3; i++) {
        if(0 <= amazPos[1] + i && amazPos[1] + i < 8) {
            for(int k = -2; k < 3; k++) {
                if(0 <= amazPos[0] + k && amazPos[0] + k < 8) {
                    board[amazPos[1] + i][amazPos[0] + k] = (board[amazPos[1] + i][amazPos[0] + k] == '0' ? '+' : board[amazPos[1] + i][amazPos[0] + k]); 
                }
            }
        }
        
    }
    
    // Clear Space Around King
    // Up-left
    if(0 <= kingPos[1] - 1 && 0 <= kingPos[0] - 1 && board[kingPos[1] - 1][kingPos[0] - 1] != 'A') board[kingPos[1] - 1][kingPos[0] - 1] = ' ';
    // Up
    if(0 <= kingPos[1] - 1 && board[kingPos[1] - 1][kingPos[0]] != 'A') board[kingPos[1] - 1][kingPos[0]] = ' ';
    // Up-right
    if(0 <= kingPos[1] - 1 && kingPos[0] + 1 < 8  && board[kingPos[1] - 1][kingPos[0] + 1] != 'A') board[kingPos[1] - 1][kingPos[0] + 1] = ' ';
    
    // Left
    if(0 <= kingPos[0] - 1 && board[kingPos[1]][kingPos[0] - 1] != 'A') board[kingPos[1]][kingPos[0] - 1] = ' ';
    // Right
    if(kingPos[0] + 1 < 8  && board[kingPos[1]][kingPos[0] + 1] != 'A') board[kingPos[1]][kingPos[0] + 1] = ' ';
    
    // Down-left
    if(kingPos[1] + 1 < 8 && 0 <= kingPos[0] - 1 && board[kingPos[1] + 1][kingPos[0] - 1] != 'A') board[kingPos[1] + 1][kingPos[0] - 1] = ' ';
    // Down
    if(kingPos[1] + 1 < 8 && board[kingPos[1] + 1][kingPos[0]] != 'A') board[kingPos[1] + 1][kingPos[0]] = ' ';
    // Down-right
    if(kingPos[1] + 1 < 8 && kingPos[0] + 1 < 8  && board[kingPos[1] + 1][kingPos[0] + 1] != 'A') board[kingPos[1] + 1][kingPos[0] + 1] = ' ';
    
    // Begin Heuristic
    for(int i = 0; i < 8; i++) {
        j = 0;
        for(; j < 8; j++) {
            if(board[i][j] == '0') {
                returnArr[func(i, j, board)]++;
            } else if(board[i][j] == '+') {
                returnArr[func1(i, j, board, amazonStandsAlone)]++;
            }
        }
    }
    
    // Return Array
    return returnArr;
}

int func(int i, int j, char[][] board) {
    for(int l = -1; l < 2; l++) {
        if(0 <= i + l && i + l < 8) {
            for(int k = -1; k < 2; k++) {
                if(0 <= j + k && j + k < 8) {
                    if(l != 0 || k != 0) {
                        if(board[i + l][j + k] == '0') return 3;
                    }
                }
            }
        }
    }
    return 2;
}
int func1(int i, int j, char[][] board, bool amazonStandsAlone) {
    for(int l = -1; l < 2; l++) {
        if(0 <= i + l && i + l < 8) {
            for(int k = -1; k < 2; k++) {
                if(0 <= j + k && j + k < 8) {
                    if(l != 0 || k != 0) {
                        if(board[i + l][j + k] == '0'
                        || (board[i + l][j + k] == 'A' && amazonStandsAlone)) return 1;
                        
                    }
                }
            }
        }
    }
    return 0;
}

bool determineIfAmazonStandsAlone(int i, int j, char[][] board) {
    for(int l = -1; l < 2; l++) {
        if(0 <= i + l && i + l < 8) {
            for(int k = -1; k < 2; k++) {
                if(0 <= j + k && j + k < 8) {
                    if(l != 0 || k != 0) {
                        if(board[i + l][j + k] == 'K') return false;
                    }
                }
            }
        }
    }
    return true;
}
