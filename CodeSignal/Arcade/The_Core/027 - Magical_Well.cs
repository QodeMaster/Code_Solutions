// Solution

int magicalWell(int a, int b, int n) {
    int sum = 0;
    
    while(n-- != 0) {
        sum += a++ * b++;
    }
    
    return sum;
}
