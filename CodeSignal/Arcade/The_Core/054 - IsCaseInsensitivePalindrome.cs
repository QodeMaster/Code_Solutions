// Solution

bool isCaseInsensitivePalindrome(string inputString) {
    string str = inputString.ToLower();
    
    for(int i = 0; i < str.Length / 2; i++) {
        if(str[i] != str[str.Length - i - 1]) return false;
    }
    
    return true;
}
