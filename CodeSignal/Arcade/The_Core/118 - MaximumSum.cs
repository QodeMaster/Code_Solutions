// Solution

int solution(int[] a, int[][] q) {
    int[] occurences = new int[a.Length];
    int maxSum = 0;
    
    // Sort "a" to get access to the largest values
    Array.Sort(a);
    
    // Increment occurences
    foreach(int[] bound in q) {
        for(int j = bound[0]; j <= bound[1]; j++) {
            occurences[j]++;
        }
    }
    
    // Sort increment for later addition
    Array.Sort(occurences);
    
    // Add to maxSum
    for(int i = 0; i < occurences.Length; i++) {
        maxSum += (occurences[i] * a[i]);
    }
    
    // Return the maximum value
    return maxSum;
}
