// Solution

string[][] volleyballPositions(string[][] formation, int k) {
    k %= 6;
    if(k == 0) return formation;
    
    int[] pos = new int[] { 01, 10, 30, 21, 32, 12}; // First digit is y cord second is x cord
    string[] players = new string[] { 
        formation[0][1], formation[1][0], formation[3][0], 
        formation[2][1], formation[3][2], formation[1][2] 
    };

    for(int i = 6 - k; i < 12 - k; i++) {
        formation[pos[k - 6 + i] / 10][pos[k - 6 + i] % 10] = players[i % 6];
    }
    
    return formation;
}
