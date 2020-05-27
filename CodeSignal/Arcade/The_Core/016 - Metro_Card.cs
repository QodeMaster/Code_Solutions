// Basic Solution

int[] metroCard(int lastNumberOfDays) {
    if(lastNumberOfDays == 31) {
        return new [] { 28, 30, 31 };
    } else {
        return new [] { 31 };
    }
}

/*------------------------------------------------*/
/*------------------------------------------------*/

// One-liner

int[] metroCard(int lastNumberOfDays) => (lastNumberOfDays == 31) ? new [] { 28, 30, 31 } : new [] { 31 };
