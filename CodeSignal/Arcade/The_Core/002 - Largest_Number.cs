// Basic Solution

int largestNumber(int n) {
    int pow = (int)Math.Pow(10, n);

    return pow - 1;
}


/*------------------------------------------------------*/
/*------------------------------------------------------*/

// One-liner

int largestNumber(int n) => (int)(Math.Pow(10, n) - 1);
