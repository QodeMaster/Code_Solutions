// Solution

int isSumOfConsecutive2(int n) {
    int count = 0;
    int start = 1;
    
    while(start <= n / 2) {
        int sum = start;
        int iteration = start + 1;
        
        while(sum < n) {
            sum += iteration++;
            if(sum == n) count++;
        }
        start++;
    }
    
    return count;
}
