// Basic Solution

int candies(int n, int m) {
    return m - m % n;
}


/*------------------------------------------------------*/
/*------------------------------------------------------*/

// One-liner

int candies(int n, int m) => m - m % n;
