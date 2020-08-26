// Solution

int arrayConversion(int[] inputArray) {
    List<int> even = new List<int>();
    List<int> odd = new List<int>(inputArray);
    
    for(int i = 1; ; i++) {
        if(even.Count() == 1 || odd.Count() == 1) return (even.Count() == 1 ? even[0] : odd[0]);
        if(i % 2 == 1) {
            for(int j = 0; j < odd.Count(); j += 2) even.Add(odd[j] + odd[j + 1]);
            odd.Clear();
        } else {
            for(int j = 0; j < even.Count(); j += 2) odd.Add(even[j] * even[j + 1]);
            even.Clear();
        }
    }
}
