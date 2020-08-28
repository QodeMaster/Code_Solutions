// Solution

bool pairOfShoes(int[][] shoes) {
    List<int> left = new List<int>();
    List<int> right = new List<int>();
    
    foreach(int[] arr in shoes) {
        if(arr[0] == 0) left.Add(arr[1]);
        else right.Add(arr[1]);
    }
    
    List<int> leftMock = left.ToList();
    
    foreach(int i in left) {
        if(right.Contains(i)) {
            leftMock.Remove(i);
            right.Remove(i);
        } else return false;
    }
    
    return (leftMock.Count() == 0 && right.Count() == 0);
}
