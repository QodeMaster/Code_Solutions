// Basic solution

int adjacentElementsProduct(int[] inputArray) {
    int max = 1000 * -1000; // Lowest possible prduct according to the constraints
    for(int i = 0; i < inputArray.Length - 1; i++) {
        if(inputArray[i] * inputArray[i + 1] > max) { 
            max = inputArray[i] * inputArray[i + 1];
         }
      }
    
    
    return max;
}

/*------------------------------------------------*/
/*------------------------------------------------*/

// Same as above except it's been shortend

int adjacentElementsProduct(int[] inputArray) {
    int max = 1000 * -1000;  
    for(int i = 0; i < inputArray.Length - 1; i++) if(inputArray[i] * inputArray[i + 1] > max) max = inputArray[i] * inputArray[i + 1];
    
    
    return max;
}
