// Solution

int chessKnight(string cell) {
    int letter = (int)cell[0];
    int num = cell[1] - '0';
    int count = 0;

    bool IsValid(int c, int i) {
        if(!(97 <= c && c < 105)) return false;
        if(!(0 < i && i < 9)) return false;

        return true;
    }

    if(IsValid(letter - 2, num - 1)) count++;
    if(IsValid(letter - 2, num + 1)) count++;
    if(IsValid(letter - 1, num - 2)) count++;
    if(IsValid(letter - 1, num + 2)) count++;

    if(IsValid(letter + 1, num - 2)) count++;
    if(IsValid(letter + 1, num + 2)) count++;
    if(IsValid(letter + 2, num - 1)) count++;
    if(IsValid(letter + 2, num + 1)) count++;

    return count;
}
