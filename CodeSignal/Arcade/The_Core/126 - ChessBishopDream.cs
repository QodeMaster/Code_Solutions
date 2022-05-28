// Solution

int[] solution(int[] boardSize, int[] initPosition, int[] initDirection, int k) {
    // Final position coordinate
    int[] endCoord = new int[2];
    
    int[] repeatingIPos = new int[3 * boardSize[0]];
    int[] repeatingJPos = new int[3 * boardSize[1]];
    int ki = k % (2 * boardSize[0]);
    int kj = k % (2 * boardSize[1]);
    
    for(int i = 0; i < boardSize[0]; i++) {
        repeatingIPos[i] = i;
        repeatingIPos[i + 2 * boardSize[0]] = i;
        
        repeatingIPos[i + boardSize[0]] = boardSize[0] - i - 1;
    }
    
    for(int i = 0; i < boardSize[1]; i++) {
        repeatingJPos[i] = i;
        repeatingJPos[i + 2 * boardSize[1]] = i;
        
        repeatingJPos[i + boardSize[1]] = boardSize[1] - i - 1;
    }
    
    if(initDirection[0] == 1) {
        endCoord[0] = repeatingIPos[initPosition[0] + ki];
    } else { endCoord[0] = repeatingIPos[initPosition[0] - ki + 2*boardSize[0]]; }
    
    if(initDirection[1] == 1) {
        endCoord[1] = repeatingJPos[initPosition[1] + kj];
    } else { endCoord[1] = repeatingJPos[initPosition[1] - kj + 2*boardSize[1]]; }

    return endCoord;
}
