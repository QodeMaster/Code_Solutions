// Basic Solution

bool isSmooth1(int[] arr) {
    if(arr.Length % 2 == 1) {
        int len = (arr.Length - 1) / 2;
        
        if(arr[0] == arr[len] && arr[len * 2] == arr[len]) return true;
    } else {
        int len = arr.Length / 2;
        
        if(arr[0] == arr[len] + arr[len - 1] && arr[len * 2 - 1] == arr[len] + arr[len - 1]) return true;
    }
    
    return false;
}

/*---------------------------------------------------------------------*/
/*---------------------------------------------------------------------*/

// One-liner ternary solution

bool isSmooth(int[] arr) => ((arr.Length % 2 == 1) ? (arr[0] == arr[(arr.Length - 1) / 2] && arr[arr.Length - 1] == arr[(arr.Length - 1) / 2]) : (arr[0] == arr[arr.Length / 2] + arr[arr.Length / 2 - 1] && arr[arr.Length - 1] == arr[arr.Length / 2] + arr[arr.Length / 2 - 1]));
