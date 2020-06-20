// Basic Solution

int[] removeArrayPart(int[] inputArray, int l, int r) {
    List<int> list = new List<int>();
    
    for(int i = 0; i < inputArray.Length; i++) {
        if(!(l <= i && i <= r)) list.Add(inputArray[i]); 
    }
    
    return list.ToArray();
}

/*----------------------------------------------------------*/
/*----------------------------------------------------------*/

// One-liner 

int[] removeArrayPart(int[] inputArray, int l, int r) => inputArray.Take(l).Concat(inputArray.Skip(++r)).ToArray();
