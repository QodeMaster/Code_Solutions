// Solution

int[] firstReverseTry(int[] arr) {
    if(arr.Length < 2) return arr;
    int firstItem = arr[0];
    arr[0] = arr[arr.Length - 1];
    arr[arr.Length - 1] = firstItem;
    
    return arr;
}
