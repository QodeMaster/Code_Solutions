// Solution

int solution(int year, int[] daysOfTheWeek, string[] holidays) {
    // Declare essential variables
    int count = 0;
    List<int> nonWeekendDays = daysOfTheWeek.ToList(); // RemoveAll() only works for lists
     
    // Remove weekends from nonWeekendDays
    //nonWeekendDays.RemoveAll(x => 5 < x); // Removing Saturday and Sunday 
    
    // Iterate through the holidays
    foreach(string holiday in holidays) {
        int holidayMonth = Convert.ToInt32(holiday.Substring(0, 2));
        int holidayDay   = Convert.ToInt32(holiday.Substring(3));
        DateTime day     = new DateTime(year + (7 < holidayMonth ? 0 : 1), holidayMonth, holidayDay);
        
        if(nonWeekendDays.Contains((int)day.DayOfWeek == 0 ? 7 : (int)day.DayOfWeek)) {
            count++;
        }
    }
    
    // Return count
    return count;
}

/*
  Description stated that the lessons on the weekends didn't count, however the test cases expected that you take
  into account the weekends as well.
*/
