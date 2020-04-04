// Basic solution

int circleOfNumbers(int n, int firstNumber) {
    int position = firstNumber + n / 2;
    return position % n;
}

/*--------------------------------------------------*/
/*--------------------------------------------------*/

// One-liner

int circleOfNumbers(int n, int firstNumber) => (firstNumber + n / 2) % n;
