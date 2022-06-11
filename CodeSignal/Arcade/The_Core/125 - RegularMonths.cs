// Solution

string solution(string currMonth) {
    // Declare essential variables
    int currentYear   = Convert.ToInt32(currMonth.Substring(3));
    int currentMonth  = Convert.ToInt32(currMonth.Substring(0, 2)) - 1;
    int[] daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    int dayOfTheWeek  = Convert.ToInt32(new DateTime(currentYear, currentMonth + 1, 1).DayOfWeek);
    
    daysInMonth[1] = 28 + (isLeapYear(currentYear) ? 1 : 0);
    
    // Iterate days until a new Monday is reached
    do {
        if(currentMonth == 12) {
            currentMonth = 0;
            currentYear++;
            daysInMonth[1] = 28 + (isLeapYear(currentYear) ? 1 : 0);
        }
        dayOfTheWeek += (daysInMonth[currentMonth++] - 28);
    } while(dayOfTheWeek % 7 != 1);
    
    // Return Date
    return (++currentMonth < 10 ? $"0{currentMonth}" : $"{currentMonth}") + "-" + currentYear;
}

bool isLeapYear(int year) {
    return (((year % 4 == 0) && ((year / 100) * 100 != year)) || ((year / 400) * 400 == year));
}
