/* Solution using only static arrays */
/* Time  complexity: O(2n) */
/* Space complexity: O(1)  */

char solution(string s) {
    int[] chrArr    = new int[26];
    int charInOrder = 2;
    // 0   = Char Not encountered
    // 100 = Char Duplicate
    // 2 to 28 = Order of first seen character
    
    // Populate array which non-duplicate chars in their order
    foreach(char c in s) {
        if(chrArr[c - 'a'] == 0) {
            chrArr[c - 'a'] = charInOrder;
            charInOrder++;
        } else {
            chrArr[c - 'a'] = 100;
        }
    }
    
    // Find the smalles charInOrder i.e. the first occuring non-duplicate
    int charOfInterest = -1;
    int minCharInOrder = 100;
    
    // Extract the first in order non-duplicate char
    for(int i = 0; i < chrArr.Length; i++) {
        if(chrArr[i] != 0 && chrArr[i] < minCharInOrder) {
            charOfInterest = i;
            minCharInOrder = chrArr[i];
        }
    }
    
    return (charOfInterest == -1 ? '_' : (char)('a' + charOfInterest));
}
