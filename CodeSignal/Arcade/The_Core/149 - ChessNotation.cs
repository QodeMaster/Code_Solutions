// Solution

string solution(string notation) {
    string[] b = notation.Split('/');
    
    char[][] board = new char[8][];
    
    for(int p = 0; p < b.Length; p++) {
        char[] str = new char[8];
        int k = 0;
        for(int i = 0; i < b[p].Length; i++) {
            if(0 <= b[p][i] - '0' && b[p][i] - '0' < 9) for(int j = 0; j < b[p][i] - '0'; j++) str[k++] = ' ';
            else str[k++] = b[p][i];
        }
        
        board[p] = str;
    }
    string newNotation = "";
    for(int i = 0; i < board[0].Length; i++) {
        for(int j = board.Length - 1; 0 <= j; j--) {
            int emptyCounter = 0;
            while(j != -1 && board[j][i] == ' ') {
                emptyCounter++;
                j--;
            }
            if(emptyCounter != 0) {
                newNotation += emptyCounter.ToString();
                if(j == -1) continue;
            }
            newNotation += board[j][i];
        }
        if(i != board[0].Length - 1) newNotation += '/';
    }
    
    return newNotation;
}
