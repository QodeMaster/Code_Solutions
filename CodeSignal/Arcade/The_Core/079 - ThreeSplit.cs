// Solution

int threeSplit(int[] a) {
    long sum = 0;
    foreach(int i in a) sum += i;
    int cut = 0;
    int total = 0;
    long currSum = 0;
    
    for(int i = 0; i < a.Length; i++) {
        currSum += a[i];
        
        if(currSum == 2 * sum / 3) {
            total += cut;
            if(sum / 3 == 0) total--;
        }
        if(currSum == sum / 3) cut++;
    }
    
    return total + (sum == 0 ? 1 : 0);
}
