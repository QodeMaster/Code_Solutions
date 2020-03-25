// Solution

bool palindromeRearranging(string inputString) {
    int[] alfbet = new int[26];
    bool strike = true;
    
    foreach(char i in inputString) alfbet[(int)i - 97]++;
    foreach(int i in alfbet) {
        if((i & 1) == 1 && !strike) return false;
        if((i & 1) == 1) strike = false;
    }
    
    
    return true;
}
