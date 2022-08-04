// Solution
// Inspired by codey2 

int solution(char[][][] pieces) {
    int res        = 0;
    char[][] board = Enumerable.Range(0, 20)
        .Select(i => new string('.', 10)
        .ToCharArray())
        .ToArray();


    for (int j = 0; j < pieces.Length; j++) {
        char[][] p   = pieces[j];
        int[] choice = FindTheBestChoice(board, p);
        for (int i = 1; i <= choice[1]; i++) p = RotatePiece(p);
        FixThePiece(ref board, p, choice[3], choice[2]);
        List<int> filled = GetFullLines(board);
        
        foreach (int i in filled) {
            ClearTheFilledLine(ref board, i);
            res++;
        }
    }

    return res;
}

char[][] RotatePiece(char[][] p) {
    return Enumerable.Range(0, p[0].Length).
        Select(i => Enumerable.Range(0, p.Length).
        Select(j => p[j][i]).Reverse().ToArray()).ToArray();
}

int ThrowPiece(char[][] board, char[][] piece, int col) {
    int pi       = piece.Length, pj = piece[0].Length, row = 0;;
    bool isFixed = true;
    
    if (board[0].Length < pj + col) return -1;
    
    while (isFixed) {
        isFixed = true;
        
        for (int i = 0; i < pi; i++) {
            for (int j = 0; j < pj; j++) {
                if (board[row + i][col + j] == '#' && piece[i][j] == '#') {
                    isFixed = false;
                    break;
                }
            }
        }
        row += (isFixed ? 1 : 0);
        if (row == board.Length - pi + 1) break;
    }
    row--;

    return row;
}

List<int> GetFullLines(char[][] board) {
    List<int> res = new List<int>(0);
    for (int i = 0; i < board.Length; i++) if (!board[i].Contains('.'))  res.Add(i);

    return res;
}

void ClearTheFilledLine(ref char[][] board, int i) {
    var res = board.ToList();
    
    res.RemoveAt(i);
    res.Insert(0, new string('.', 10).ToArray());
    board = res.ToArray();
}

void FixThePiece(ref char[][] board, char[][] piece, int row, int col) {
    int pi = piece.Length, pj = piece[0].Length;
    
    for (int i = 0; i < pi; i++) {
        for (int j = 0; j < pj; j++) {
            board[row + i][col + j] = piece[i][j] == '#' ? '#' : board[row + i][col + j];
        }
    }
}

int[] FindTheBestChoice(char[][] board, char[][] piece) {
    List<int[]> choices = new List<int[]>(0);
    char[][] p = piece.Select(x => x.Select(y => y).ToArray()).ToArray();

    for (int r = 0; r < 4; r++) {
        if (0 < r) p = RotatePiece(p);
        
        for (int col = 0; col <= board[0].Length - p[0].Length; col++) {
            int row = ThrowPiece(board, p, col);
            int blocks = Enumerable.Range(row, p.Length)
                        .Select(i => board[i].Where(y => y == '#')
                        .Count())
                        .Sum();
            choices.Add(new int[] { blocks, r, col, row });
        }
    }

    return choices.OrderByDescending(x => x[0])
            .ThenBy(x => x[1])
            .ThenBy(x => x[2])
            .FirstOrDefault();
}
