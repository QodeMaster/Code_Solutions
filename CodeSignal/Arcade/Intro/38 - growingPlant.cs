// Basic Solution

int growingPlant(int upSpeed, int downSpeed, int desiredHeight) {
    int total = 0;
    int days = 0;

    while(total < desiredHeight) {
        days++;
        total += upSpeed;
        if(total >= desiredHeight) break;
        total -= downSpeed;
    }

    return days;
}
