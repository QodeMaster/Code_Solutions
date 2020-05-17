// Solution

int phoneCall(int min1, int min2_10, int min11, int s) {
    int call = 0;

    if(s - min1 >= 0) {
        s -= min1;
        call++;
    } else return call;

    for(int i = 0; i < 9; i++) {
        if(s - min2_10 >= 0) {
            s -= min2_10;
            call++;
        } else return call;
    }

    while(s - min11 >= 0) {
        s -= min11;
        call++;
    }

    return call;
}
