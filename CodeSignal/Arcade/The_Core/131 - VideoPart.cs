// Solution

/*
  Sub-optimal solution since we are iterating from i = 2 to i = total time.
  Can be further reduced and optimized if wanted.
*/

int[] solution(string part, string total) {
    // Get time for part - watched
    int partTime = (10 * (part[0] - '0') + (part[1] - '0')) * 60 * 60
    + (10 * (part[3] - '0') + (part[4] - '0')) * 60
    + (10 * (part[6] - '0') + (part[7] - '0'));
    
    // Get time for total
    int totalTime = (10 * (total[0] - '0') + (total[1] - '0')) * 60 * 60
    + (10 * (total[3] - '0') + (total[4] - '0')) * 60
    + (10 * (total[6] - '0') + (total[7] - '0'));
    
    // Turn result into fraction
    for(int i = 2; i <= totalTime; i++) {
        while((partTime / i) * i == partTime 
        && (totalTime / i) * i == totalTime) {
            partTime  /= i;
            totalTime /= i;
        }
    }
    
    // Return fraction
    return new int[] { partTime, totalTime };
}
