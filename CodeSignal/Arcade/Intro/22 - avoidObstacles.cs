// Basic solution

int avoidObstacles(int[] inputArray) {
    int k = 2;
    
    while(All(inputArray, k) != true) k++;
    
    
    return k;
}


public static bool All(int[] arr, int k) {
    foreach(int i in arr) if(i % k == 0) return false;
    
    return true;
}


/*--------------------------------------------------------*/
/*--------------------------------------------------------*/

// Using System.Linq

int avoidObstacles(int[] inputArray) {
    int k = 2;
    
    while(inputArray.Any(x => x % k == 0) == true) k++;
    
    
    return k;
}
