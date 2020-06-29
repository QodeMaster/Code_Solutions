// Solution

int[] weakNumbers(int n) {
    int[] nums = new int[n];
    int[] weakness = new int[n];
    int max = 1;
    int weaknessMax = 0;
    
    for(int i = 1; i <= n; i++) {
        int j = 1;
        
        while(0 <= i - j) {
            if(i % j++ == 0) nums[i - 1]++;
        }
        
        if(max < nums[i - 1]) max = nums[i - 1];
        else weakness[i - 1] = nums.Where(x => nums[i - 1] < x).ToArray().Length;
        if(weaknessMax < weakness[i - 1]) weaknessMax = weakness[i - 1];
    }
    
    return new int[] { weaknessMax, weakness.Where(x => x == weaknessMax).ToArray().Length };
}
