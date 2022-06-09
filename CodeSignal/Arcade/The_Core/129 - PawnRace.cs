// Solution

string solution(string white, string black, char toMove) {
    if(white[0] - black[0] == 0 && white[1] < black[1]) return "draw";
    if(Math.Abs(white[0] - black[0]) == 1 && white[1] < black[1]) {
        // If they are in potential striking distance
        
        int whiteLetter = white[1] - '0';
        int whiteNum    = white[0] - 'a';
        int blackLetter = black[1] - '0';
        int blackNum    = black[0] - 'a';
        
        int[][] winPosition = new int[][] {
            new int[] { 2, 5 },
            new int[] { 2, 6 },
            new int[] { 3, 6 },
            new int[] { 4, 7 }
        };
        if(toMove == 'w') {
            foreach(int[] pos in winPosition) if(whiteLetter == pos[0] && blackLetter == pos[1]) return "white";
            if (whiteLetter + 1 == blackLetter) return "white";
            return "black";
        } else {
            foreach(int[] pos in winPosition) if(whiteLetter == 9 - pos[1] && blackLetter == 9 - pos[0]) return "black";
            if(whiteLetter + 1 == blackLetter) return "black";
            return "white";
        }
    } else { // If they are out of reach for direct contact
        int whiteTurnsLeftForWin = 8 - (white[1] - '0');
        int blackTurnsLeftForWin = (black[1] - '0') - 1;
        
        string second;
        if(toMove == 'w') {
            whiteTurnsLeftForWin--;
            second = "black";
        } else {
            blackTurnsLeftForWin--;
            second = "white";
        }
        
        whiteTurnsLeftForWin += (white[1] == '2' ? -1 : 0);
        blackTurnsLeftForWin += (black[1] == '7' ? -1 : 0);
        
        if(whiteTurnsLeftForWin == blackTurnsLeftForWin) {
            return second;
        } else if(whiteTurnsLeftForWin < blackTurnsLeftForWin) {
            return "white";
        } else return "black";
    }
}
