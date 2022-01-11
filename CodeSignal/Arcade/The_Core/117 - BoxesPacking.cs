// Solution

bool solution(int[] length, int[] width, int[] height) {
    int len = length.Length;
    int[][] allBoxes = new int[len][];
    int[] largestSide = new int[len];
    int[] secLargestSide = new int[len];
    int[] thiLargestSide = new int[len];
    
    // Rotate all boxes so that length becomes the largest
    for(int i = 0; i < len; i++) {
        int[] dimensions = {length[i], width[i], height[i]};
        Array.Sort(dimensions);
        Array.Reverse(dimensions);
        largestSide[i]    = dimensions[0];
        secLargestSide[i] = dimensions[1];
        thiLargestSide[i] = dimensions[2];
        allBoxes[i] = dimensions;
    }
    
    // Remove duplicates
    if(largestSide.Distinct().ToArray().Length != len 
    || secLargestSide.Distinct().ToArray().Length != len 
    || thiLargestSide.Distinct().ToArray().Length != len) return false;
    
    // Bubble sort the largest length to the top of the dimensions array
    for(int i = 1; i < len; i++) {
        for(int j = 0; j < len - i; j++) {
            if(allBoxes[j][0] < allBoxes[j + 1][0]) {
                int holder = allBoxes[j][0];
                allBoxes[j][0] = allBoxes[j + 1][0];
                allBoxes[j + 1][0] = holder;
                
                holder = allBoxes[j][1];
                allBoxes[j][1] = allBoxes[j + 1][1];
                allBoxes[j + 1][1] = holder;
                
                holder = allBoxes[j][2];
                allBoxes[j][2] = allBoxes[j + 1][2];
                allBoxes[j + 1][2] = holder;
            }
        }
    }
    
    // Eliminate each box until there is none left or if condidtion is false
    for(int i = 0; i < len - 1; i++) {
        if(!(allBoxes[i][0] > allBoxes[i + 1][0] 
        && allBoxes[i][1] > allBoxes[i + 1][1] 
        && allBoxes[i][2] > allBoxes[i + 1][2])) return false;
    }
    
    return true;
}
