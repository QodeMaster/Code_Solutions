// Bitwise Solution

int mirrorBits(int a) {
    int newNum = 0;

    while(a > 1) {
        if((a & 1) == 1) newNum++;
        newNum <<= 1;
        a >>= 1;
    }

    return newNum + 1;
}

/*-------------------------------------------*/
/*-------------------------------------------*/

// Binary string solution

int mirrorBits(int a) => Convert.ToInt32(Reverse(Convert.ToString(a, 2)), 2);

static string Reverse(string s) {
    char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
}
