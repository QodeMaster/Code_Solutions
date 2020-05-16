// Basic Solution

int circleOfNumbers(int n, int firstNumber) {
    return (n / 2 + firstNumber) % n;
}

/*----------------------------------------------------*/
/*----------------------------------------------------*/

// One-liner

int circleOfNumbers(int n, int firstNumber) => (n / 2 + firstNumber) % n;
