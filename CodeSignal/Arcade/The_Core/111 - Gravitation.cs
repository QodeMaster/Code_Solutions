// Solution

int[] gravitation(string[] rows) {
    int wid = rows[0].Length;
    int hei = rows.Length;
    int[] motionLess = new int[wid];
    int minIterations = 10000;
    int minIterationsDuplicates = 0;
    
    for(int i = 0; i < wid; i++) {
        int emptySteps = 0;
        int gapCount = 0;
        
        for(int j = hei - 1; j >= 0; j--) {
            emptySteps += (rows[j][i] == '.' ? 1 : 0);
            if(rows[j][i] == '#') {
                gapCount += emptySteps;
                emptySteps = 0;
            }
        }

        minIterationsDuplicates += (gapCount == minIterations ? 1 : 0);
        if(gapCount < minIterations) {
            minIterations = gapCount;
            minIterationsDuplicates = 1;
        }
        
        motionLess[i] = gapCount;
    }
    
    int[] indicies = new int[minIterationsDuplicates];
    for(int i = 0; i < wid; i++) {
        if(motionLess[i] == minIterations) {
            indicies[--minIterationsDuplicates] = i;
        }
    }
    
    Array.Reverse(indicies);
    return indicies;
}
