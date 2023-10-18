int solution(int[] a) {
    HashSet<int> alreadyVisited = new HashSet<int>();
    
    foreach(int i in a) {
        if(alreadyVisited.Contains(i)) return i;
        alreadyVisited.Add(i);
    }
    
    return -1;
}
