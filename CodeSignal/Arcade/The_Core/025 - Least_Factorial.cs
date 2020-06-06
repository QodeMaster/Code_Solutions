// Basic Solution

int leastFactorial(int n) {
    int product = 1;
    int factor = 1;
    
    while(n > product) {
        product *= factor++;
    }
    
    
    return product;
}

/*------------------------------------------------*/
/*------------------------------------------------*/

// Recursive solution

int leastFactorial(int n) => factorial(n, 1, 1);
static int factorial(int n, int i, int f) => (i >= n) ? i : factorial(n, i * ++f, f);
