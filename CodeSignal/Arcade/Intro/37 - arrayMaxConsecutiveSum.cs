// Basic Solution

int arrayMaxConsecutiveSum(int[] inputArray, int k) {
    int max = 0;
    int kernel = 0;

    for(int i = 0; i < k; i++) kernel += inputArray[i];

    max = kernel;
    
    for(int i = k; i < inputArray.Length; i++) {
        kernel += inputArray[i] - inputArray[i - k];
        if(max < kernel) max = kernel;
    }


    return max;
}
