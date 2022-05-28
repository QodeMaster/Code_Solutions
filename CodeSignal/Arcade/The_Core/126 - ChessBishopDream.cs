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

/*--------------------------------------------------------------------------------------------------*/
/*--------------------------------------------------------------------------------------------------*/

// A less repetitive and more elegant solution

int[] solution(int[] boardSize, int[] initPosition, int[] initDirection, int k) {
    // Final position coordinate
    int[] endCoord = new int[2];
    
    for(int I = 0; I < 2; I++) {
        int[] repeatingPattern = new int[3 * boardSize[I]];
        int kI = k % (2 * boardSize[I]);
        
        // Filling pattern array
        for(int i = 0; i < boardSize[I]; i++) {
            // For the 'i' position in the example: [0, 1, 2, 2, 1, 0, 0, 1, 2];
            //         'j' position in the example: [0, 1, 2, 3, 4, 5, 6, 6, 5, 4, 3, 2, 1, 0, 0, 1, 2, 3, 4, 5, 6];
            repeatingPattern[i] = i;
            repeatingPattern[i + 2 * boardSize[I]] = i;
            repeatingPattern[i + boardSize[I]] = boardSize[I] - i - 1;
        }
        
        // Calculate end position for the respective axis
        endCoord[I] = repeatingPattern[initPosition[I] + initDirection[I] * kI + (1 - initDirection[I]) * boardSize[I]];
    }
    
    // Return ending coordinates
    return endCoord;
}
