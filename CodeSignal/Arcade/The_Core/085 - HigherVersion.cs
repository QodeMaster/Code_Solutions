// Solution

bool higherVersion(string ver1, string ver2) {
    string[] arr1 = ver1.Split('.');
    string[] arr2 = ver2.Split('.');
    
    for(int i = 0; i < arr1.Length; i++) {
        if(arr1[i] == arr2[i]) continue;
        return int.Parse(arr2[i]) < int.Parse(arr1[i]);
    }
    
    return false;
}
