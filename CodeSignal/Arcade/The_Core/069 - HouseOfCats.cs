// Solution

int[] houseOfCats(int legs) {
    int[] arr = new int[1 + legs / 4];
    arr[0] = (legs % 4) / 2;
    
    for(int i = 1; i < arr.Length; i++) {
        arr[i] = arr[i - 1] + 2;
    }
    
    return arr;
}
