// Solution

int[] solution(int[] a) {
    // An array to hold the digit difference for each element in the "a" array
    int[] digitDiffrenceHolder = new int[a.Length];
    // Reversing it so that the larger index comes first
    Array.Reverse(a);
    
    // Filling the digitDiffrence array with the maximum digit difference of each number
    for(int i = 0; i < a.Length; i++) digitDiffrenceHolder[i] = digitDiffrence(a[i]);
    
    // Bubble sort
    // Even though bubble sort is a naive sorting algorithm it's still useful since it sorts with stabillity intact
    for(int i = 1; i < a.Length; i++) {
        for(int j = 0; j < a.Length - i; j++) {
            if(digitDiffrenceHolder[j + 1] < digitDiffrenceHolder[j]) {
                int holder = digitDiffrenceHolder[j];
                digitDiffrenceHolder[j] = digitDiffrenceHolder[j + 1];
                digitDiffrenceHolder[j + 1] = holder;
                
                holder = a[j];
                a[j] = a[j + 1];
                a[j + 1] = holder;
            }
        }
    }
    
    return a;
}

int digitDiffrence(int num) {
    int max = 0;
    int min = 10;
    
    int firstDig = num % 10;
    while(num != 0) {
        if(max < firstDig) max = firstDig;
        if(firstDig < min) min = firstDig;
        
        num /= 10;
        firstDig = num % 10;
    }
    
    return max - min;
}
