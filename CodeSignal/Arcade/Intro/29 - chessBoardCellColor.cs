// Solution

bool chessBoardCellColor(string cell1, string cell2) {
    bool[][] chess = new bool[8][];
    bool[] even = new bool[] {false, true, false, true, false, true, false, true};
    bool[] odd = new bool[] {true, false, true, false, true, false, true, false};

    for(int i = 0; i < chess.Length; i++) {
        if((i & 1) == 0) chess[i] = even;
        else chess[i] = odd;
    }

    return chess[(int)cell1[0] - 65][(int)cell1[1] - 49] == chess[(int)cell2[0] - 65][(int)cell2[1] - 49];
}
