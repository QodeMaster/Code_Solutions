// Solution

int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem) {
    for(int i = 0; i < inputArray.Length; i++) if(inputArray[i] == elemToReplace) inputArray[i] = substitutionElem;
    
    return inputArray;
}
