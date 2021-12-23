// Solution

int[] solution(int[] shuffled) {
    // Sort arr
    Array.Sort(shuffled);
    
    // Find the sum element
    int sum = shuffled.Sum();
    int index = 0;
    while(sum != 2 * shuffled[index]) index++;
    
    // Define new array with one size less
    int[] originalArr = new int[shuffled.Length - 1];
    
    // Assign elements from old array to the new array
    int offset = 0;
    for(int i = 0; i < shuffled.Length; i++) {
        if(i != index) {
            originalArr[i - offset] = shuffled[i];
        } else offset = 1;
    }
    
    // return the new array
    return originalArr;
}
