// Basic Solution

int lateRide(int n) {
    int hour = n / 60;
    int minute = n - hour * 60;
    int hourSum = hour % 10 + hour / 10;
    int minuteSum = minute % 10 + minute / 10;


    return hourSum + minuteSum;
}

/*---------------------------------------------------------*/
/*---------------------------------------------------------*/

// One-liner

int lateRide(int n) => (n / 60) % 10 + (n - (n / 60) * 60) % 10 + (n / 60) / 10 + (n - (n / 60) * 60) / 10;
