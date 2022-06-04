// Brute Force Solution

int solution(int n, int m) {
    List<int[]> potentialAttacks = new List<int[]>();
    int totCount = 0;
    
    // Iterate through the coord system for horse
    for(int i = 0; i < n; i++) {
        for(int j = 0; j < m; j++) {
            if(0 <= i - 1 && 0 <= j - 2) potentialAttacks.Add(new int[] { i, j, i - 1, j - 2});
            if(0 <= i - 2 && 0 <= j - 1) potentialAttacks.Add(new int[] { i, j, i - 2, j - 1});
            if(i + 1 < n && 0 <= j - 2) potentialAttacks.Add(new int[] { i, j, i + 1, j - 2});
            if(i + 2 < n && 0 <= j - 1) potentialAttacks.Add(new int[] { i, j, i + 2, j - 1});
            if(0 <= i - 1 && j + 2 < m) potentialAttacks.Add(new int[] { i, j, i - 1, j + 2});
            if(0 <= i - 2 && j + 1 < m) potentialAttacks.Add(new int[] { i, j, i - 2, j + 1});
            if(i + 1 < n && j + 2 < m) potentialAttacks.Add(new int[] { i, j, i + 1, j + 2});
            if(i + 2 < n && j + 1 < m) potentialAttacks.Add(new int[] { i, j, i + 2, j + 1});
        }
    }
    
    //  Check if horse attacking a rook will lead to a triangle
    foreach(int[] arr in potentialAttacks) {
        int i = 1;
        while(0 <= arr[2] - i) totCount += (canBishopStrike(arr[0], arr[1], arr[2] - i++, arr[3]) ? 1 : 0); // Upp
        i = 1;
        while(arr[3] + i < m) totCount += (canBishopStrike(arr[0], arr[1], arr[2], arr[3] + i++) ? 1 : 0); // Right
        i = 1;
        while(0 <= arr[3] - i) totCount += (canBishopStrike(arr[0], arr[1], arr[2], arr[3] - i++) ? 1 : 0); // Left
        i = 1;
        while(arr[2] + i < n) totCount += (canBishopStrike(arr[0], arr[1], arr[2] + i++, arr[3]) ? 1 : 0); // Down
    }
    
    //  Check if horse attacking a bishop will lead to a triangle
    foreach(int[] arr in potentialAttacks) {
        int i = 1;
        while(0 <= arr[2] - i && 0 <= arr[3] - i) totCount += (canRookStrike(arr[0], arr[1], arr[2] - i, arr[3] - i++) ? 1 : 0); // Upp-left
        i = 1;
        while(arr[2] + i < n  && 0 <= arr[3] - i) totCount += (canRookStrike(arr[0], arr[1], arr[2] + i, arr[3] - i++) ? 1 : 0); // Down-left
        i = 1;
        while(0 <= arr[2] - i && arr[3] + i < m) totCount += (canRookStrike(arr[0], arr[1], arr[2] - i, arr[3] + i++) ? 1 : 0); // Upp-right
        i = 1;
        while(arr[2] + i < n  && arr[3] + i < m) totCount += (canRookStrike(arr[0], arr[1], arr[2] + i, arr[3] + i++) ? 1 : 0); // Down-right
    }
    
    // Return solution
    return totCount;
}

bool canRookStrike(int knightI, int knightJ, int rookI, int rookJ) => (rookI == knightI || rookJ == knightJ);

bool canBishopStrike(int knightI, int knightJ, int bishopI, int bishopJ) => Math.Abs(bishopI - knightI) == Math.Abs(bishopJ - knightJ);
