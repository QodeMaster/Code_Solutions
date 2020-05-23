// Solution

bool isInfiniteProcess(int a, int b) {

    while(a != b) {
        a++;
        b--;
        if(a > b) return true;
    }

    return false;
}
