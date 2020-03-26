// Basic solution

int arrayMaximalAdjacentDifference(int[] inputArray) {
    int max = 0;
    
    for(int i = 0; i < inputArray.Length - 1; i++) {
        int diff = Math.Abs(inputArray[i] - inputArray[i + 1]);
        if(max < diff) max = diff;
    }
    
    
    return max;
}

/*----------------------------------------------------*/
/*----------------------------------------------------*/

// Shorter solution

int arrayMaximalAdjacentDifference(int[] inputArray) {
    int max = 0;
    
    for(int i = 0; i < inputArray.Length - 1; i++) if(max < Math.Abs(inputArray[i] - inputArray[i + 1])) max = Math.Abs(inputArray[i] - inputArray[i + 1]);
    
    
    return max;
}
