// Basic Solution

bool validTime(string time) {
    if((time[0] - '0' == 2 && time[1] - '0' >= 4) || time[0] - '0' > 2 || time[3] - '0' > 5) return false;

    return true;
}


/*--------------------------------------------------------------------------*/
/*--------------------------------------------------------------------------*/

// One-liner solution

bool validTime1(string time) => !((time[0] - '0' == 2 && time[1] - '0' >= 4) || time[0] - '0' > 2 || time[3] - '0' > 5);
