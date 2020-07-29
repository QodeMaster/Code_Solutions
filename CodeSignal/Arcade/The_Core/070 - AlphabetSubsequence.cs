// Solution

bool alphabetSubsequence(string s) {
    for(int i = 1; i < s.Length; i++) {
        if((int)s[i] <= (int)s[i - 1]) return false;
    }
    
    return true;
}
