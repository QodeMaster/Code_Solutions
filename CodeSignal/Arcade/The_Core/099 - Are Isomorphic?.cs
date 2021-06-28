// Solution

bool areIsomorphic(int[][] array1, int[][] array2) {
    if(array1.Length != array2.Length) {
        return false;
    } else {
        for(int i = 0; i < array1.Length; i++) {
            if(array1[i].Length != array2[i].Length) return false;
        }
        
        return true;
    }
}
