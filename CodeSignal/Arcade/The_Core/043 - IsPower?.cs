// Solution

bool isPower(int n) {
    if(n == 1) return true;
    for(int i = 2; i <= 20; i++) {
        int exp = 1;
        while(Math.Pow(i, exp++) <= 400) {
            if(Math.Pow(i, exp) == n) return true;
        }
    }
    
    return false;
}
