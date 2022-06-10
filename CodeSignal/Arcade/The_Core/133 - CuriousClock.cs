// Solution

string solution(string someTime, string leavingTime) {
    DateTime sTime = ConvertStringToDateTime(someTime);
    DateTime lTime = ConvertStringToDateTime(leavingTime);
    
    // (lTime - sTime) == time passed since the clock went backwards
    DateTime leavingTimeInClock = (sTime - (lTime - sTime));
    
    // Return new time
    return completeDate(leavingTimeInClock.Year) + "-"
    + completeDate(leavingTimeInClock.Month) + "-"
    + completeDate(leavingTimeInClock.Day)   + " "
    + completeDate(leavingTimeInClock.Hour)  + ":"
    + completeDate(leavingTimeInClock.Minute) ;
}

string completeDate(int num) {
    // Fill in zero if integer is of size 1 digit
    return (num < 10 ? $"0{num}" : num.ToString());
}

DateTime ConvertStringToDateTime(string time) {
    return new DateTime(
        Convert.ToInt32(time.Substring(0, 4)),
        10 * (time[5] - '0')  + (time[6] - '0'),
        10 * (time[8] - '0')  + (time[9] - '0'),
        10 * (time[11] - '0') + (time[12] - '0'),
        10 * (time[14] - '0') + (time[15] - '0'),
        30
    );
}
