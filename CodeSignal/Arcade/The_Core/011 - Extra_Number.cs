// Solution

int extraNumber(int a, int b, int c) {
    int diffAB = a - b;
    int diffAC = a - c;
    int diffBC = b - c;

    if(diffAB == 0) return c;
    if(diffAC == 0) return b;
    if(diffBC == 0) return a;

    return 1;
}
