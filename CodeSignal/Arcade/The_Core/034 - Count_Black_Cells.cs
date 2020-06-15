// Solution

int countBlackCells(int n, int m) {
    int commonDividor = 0;
    
    for(int i = 1; i <= n; i++) {
        if(n % i == 0 && m % i == 0) commonDividor = i;
    }
    
    return --n + m + --commonDividor;
}
