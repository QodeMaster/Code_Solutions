// Solution

bool evenDigitsOnly(int n) {
    while(true) {
        if(n == 0) return true;
        if((n & 1) == 1) return false;
        n = ~~(n / 10);
    }
}
