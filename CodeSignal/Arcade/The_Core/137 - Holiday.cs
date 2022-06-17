// Solution

int solution(int x, string weekDay, string month, int yearNumber) {
    // Declare essential
    string[] months    = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
    int[] daysInMonth  = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    string[] weekDays  = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    int[] weekDayIndex = new int[] { 1, 2, 3, 4, 5, 6, 7 };
    
    // Add a day to February if it's a leap year
    daysInMonth[1] += (((yearNumber % 4 == 0) && ((yearNumber / 100) * 100 != yearNumber)) 
    || ((yearNumber / 400) * 400 == yearNumber) ? 1 : 0);
    int monthInt = Array.IndexOf(months, month) + 1;
    
    // Retrieve week day of the 1:st in month
    DateTime firstDate = new DateTime(yearNumber, monthInt, 1);
    int day = ((int)firstDate.DayOfWeek == 0 ? 7 : (int)firstDate.DayOfWeek);
    
    // Count how many days until the first occurence of the desired week days 
    int firstWeekDayOccurenceInMonth = Array.IndexOf(weekDays, weekDay) + 1;
    int date = firstWeekDayOccurenceInMonth - day + 1 + (day <= firstWeekDayOccurenceInMonth ? 0 : 7);
    
    
    // Return date in month
    int dateInMonth = date + (x - 1) * 7;
    return (daysInMonth[Array.IndexOf(months, month)] < dateInMonth ? -1 : dateInMonth);
}
