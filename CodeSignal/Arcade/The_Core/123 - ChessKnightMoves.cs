// Solution

int solution(string cell) {
    int x = cell[0] - 'a' + 1;
    int y = cell[1] - '0';
    int count = 0;
    
    // To see if the coordinates are in the board
    int mesh(int a, int b) => ((0 < a && a < 9) && (0 < b && b < 9) ? 1 : 0);
    
    // Add to counter if the coordinates are in the board
    for(int i = -2; i < 3; i+=4) count += mesh(x + i, y - 1) + mesh(x + i, y + 1);
    for(int i = -1; i < 2; i+=2) count += mesh(x + i, y - 2) + mesh(x + i, y + 2);
    
    return count;
}
