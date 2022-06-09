// Solution

bool solution(string time) {
    // Compare hour
    bool isHourValid   = (time[0] - '0') * 10 + (time[1] - '0') < 24;
    
    // Compare minute
    bool isMinuteValid = (time[3] - '0') * 10 + (time[4] - '0') < 60;
    
    // Return evaluation
    return isHourValid && isMinuteValid;
}

/*----------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------*/

// One-line with the built-in DateTime function

bool solution(string time) => DateTime.TryParse(time, out _);
