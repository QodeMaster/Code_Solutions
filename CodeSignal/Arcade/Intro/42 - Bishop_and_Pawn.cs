// Solution

bool bishopAndPawn(string bishop, string pawn) {
    int letter = (int)bishop[0];
    int dig = bishop[1] - '0';
    string Combiner(int let, int digit) => $"{(char)let}{digit}";

    for(int i = 1; i <= 7; i++) {
        if(Combiner(letter + i, dig + i) == pawn) return true;
        if(Combiner(letter - i, dig - i) == pawn) return true;
        if(Combiner(letter - i, dig + i) == pawn) return true;
        if(Combiner(letter + i, dig - i) == pawn) return true;
    }


    return false;
}
