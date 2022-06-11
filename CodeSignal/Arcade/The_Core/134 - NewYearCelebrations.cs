// Solution

int solution(string takeOffTime, int[] minutes) {
    int counter  = 0;       // Celebration counter
    int midnight = 24 * 60; // Midnight, counted in minutes
    int time = Convert.ToInt32(takeOffTime.Substring(0, 2)) * 60 
    + Convert.ToInt32(takeOffTime.Substring(3)); // Take off time in minutes
    time = ((time == 0) ? midnight : time);      // To avoid negative numbers
    
    for(int i = 0; i < minutes.Length; i++) {
        int dt  = minutes[i] - ((i == 0) ? 0 : minutes[i - 1]);
        int timeAfter = time + dt - 60; // After return

        if(time <= midnight && midnight <= time + dt) counter++; // Mid-air celebration
        time += (dt - 60); // Update
    }

    if(time <= midnight) counter++; // Time after last flight
    
    return counter;
}
