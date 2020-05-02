// Solution

string buildPalindrome(string st) {
    string build = "";
    
    bool CheckPal(string fir) {
        int len = fir.Length / 2;
        for(int i = 0; i < len; i++) if(fir[i] != fir[fir.Length - 1 - i]) return false;
        
        return true;
    }

    foreach(char c in st) {
        if(CheckPal(st + build)) return st + build;
        build = c + build;
    }

    return "wasd";
}
