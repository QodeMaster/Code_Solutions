// Basic Solution

bool arithmeticExpression(int a, int b, int c) {

    if(a + b == c) return true;
    if(a - b == c) return true;
    if(a * b == c) return true;
    if(c * b == a) return true;

    return false;
}

/*------------------------------------------------------------*/
/*------------------------------------------------------------*/

// One-liner

bool arithmeticExpression(int a, int b, int c) => a + b == c || a - b == c || a * b == c || c * b == a;
