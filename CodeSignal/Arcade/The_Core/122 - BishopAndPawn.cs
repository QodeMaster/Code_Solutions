// Basic Solution

bool solution(string bishop, string pawn) {
    bool[][] board = new bool[8][];
    
    for(int i = 0; i < 8; i++)  board[i] = new bool[] { false, false, false, false, false, false, false, false };
    
    board[pawn[1] - '1'][pawn[0] - 'a'] = true;
    
    int bishopCordX = bishop[0] - 'a';
    int bishopCordY = bishop[1] - '1';
    
    // Checking first diagonal
    for(int i = 1; bishopCordX + i < 8 && bishopCordY + i < 8; i++) {
        if(board[bishopCordY + i][bishopCordX + i]) return true;
    } 
    
    // Checking second diagonal
    for(int i = 1; bishopCordX + i < 8 && 0 <= bishopCordY - i; i++) {
        if(board[bishopCordY - i][bishopCordX + i]) return true;
    }
    
    // Checking third diagonal
    for(int i = 1; 0 <= bishopCordX - i && bishopCordY + i < 8; i++) {
        if(board[bishopCordY + i][bishopCordX - i]) return true;
    }
    
    // Checking fourth diagonal
    for(int i = 1; 0 <= bishopCordX - i && 0 <= bishopCordY - i; i++) {
        if(board[bishopCordY - i][bishopCordX - i]) return true;
    }
    
    // False because the pawn cannot be reached by the bishop in one move
    return false;
}

/*---------------------------------------------------------------------------------------*/
/*---------------------------------------------------------------------------------------*/

// Clever one-liner solution with the math library

bool solution(string bishop, string pawn) => Math.Abs(bishop[0] - pawn[0]) == Math.Abs(bishop[1] - pawn[1]);
