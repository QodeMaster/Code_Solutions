// Basic Solution

string[] solution(string[] inputArray) {
    // Bubble sort, stable sort
    for(int i = 1; i < inputArray.Length; i++) {
        for(int j = 0; j < inputArray.Length - i; j++) {
            if(inputArray[j + 1].Length < inputArray[j].Length) {
                string holder = inputArray[j];
                inputArray[j] = inputArray[j + 1];
                inputArray[j + 1] = holder;
            }
        }
    }
    
    return inputArray;
}

/*--------------------------------------------------------*/
/*--------------------------------------------------------*/

// Using Linq to sort

string[] solution(string[] inputArray) {
    // Using LINQ OrderBy, not memory efficient
    return inputArray.OrderBy(s => s.Length).ToArray();
}
