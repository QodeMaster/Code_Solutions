// Solution

int arrayChange(int[] inputArray) {
    int sum = 0;
    
    for(int i = 1; i < inputArray.Length; i++) {
        int prev = inputArray[i - 1];
        
        if(prev >= inputArray[i]) {
            sum += prev - inputArray[i] + 1;
            inputArray[i] = prev + 1;
        
        }
    }


    return sum;
}
