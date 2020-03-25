// Basic Solution

bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight) {
    int ymax = Math.Max(yourLeft, yourRight);
    int fmax = Math.Max(friendsLeft, friendsRight);
    
    int ymin = Math.Min(yourLeft, yourRight);
    int fmin = Math.Min(friendsLeft, friendsRight);
 
    
    return ymax == fmax && ymin == fmin;
}
