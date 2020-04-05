// Solution

int[] extractEachKth(int[] inputArray, int k) {
    List<int> arr = new List<int>();

    for(int i = 0; i < inputArray.Length; i++) if((i + 1) % k != 0) arr.Add(inputArray[i]);


    return arr.ToArray();
}
