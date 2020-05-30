// Solution

int rangeBitCount(int a, int b) {
    int count = 0;

    for(int i = a; i <= b; i++) {
        int num = i;

        while(num > 0) {
            if((num & 1) == 1) count++;
            num >>= 1;
        }
    }


    return count;
}
