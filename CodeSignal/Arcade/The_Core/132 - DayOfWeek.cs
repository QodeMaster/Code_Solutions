// Solution

int solution(string birthdayDate) {
    int dayOfWeekSinceBirthDay = 0;
    int year  = Convert.ToInt32(birthdayDate.Substring(6));
    int month = Convert.ToInt32(birthdayDate.Substring(0, 2));
    int day   = Convert.ToInt32(birthdayDate.Substring(3, 2));
    
    if(month == 2 && day == 29) { // If birthday is in Feb 29
        do {
            if(isLeapYear(year + 4)) {
                dayOfWeekSinceBirthDay += 5;
                year += 4;
            } else {
                dayOfWeekSinceBirthDay += 2;
                year += 8;
            }
        } while(dayOfWeekSinceBirthDay % 7 != 0);
    
    } else { // If birthday is not in Feb 29
        bool isBefore29Feb = (month == 1 || (month == 2 && day < 29));
        
        do {
            dayOfWeekSinceBirthDay += ((isLeapYear(year) && isBefore29Feb)
            || (isLeapYear(year + 1) && !isBefore29Feb) ? 2 : 1);
            year++;
        } while(dayOfWeekSinceBirthDay % 7 != 0);
    }
    
    return year - Convert.ToInt32(birthdayDate.Substring(6));
}

bool isLeapYear(int year) {
    return (((year % 4 == 0) && ((year / 100) * 100 != year)) || ((year / 400) * 400 == year));
}
