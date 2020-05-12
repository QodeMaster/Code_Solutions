// Basic Solution

int addTwoDigits(int n) {
    return n % 10 + (n - n % 10) / 10;
}


/*------------------------------------------------------*/
/*------------------------------------------------------*/

// One-liner

int addTwoDigits(int n) => n % 10 + (n - n % 10) / 10;
