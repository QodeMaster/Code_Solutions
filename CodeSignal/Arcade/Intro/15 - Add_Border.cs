// Solution

string[] addBorder(string[] picture) {
    int len = picture.Length;
    
    string border = new String('*', picture[0].Length + 2);
    string[] arr = new string[len + 2];
    arr[0] = border;
    arr[arr.Length - 1] = border;
    
    for(int i = 1; i < arr.Length - 1; i++) arr[i] = "*" + picture[i - 1] + "*";
    
    return arr;
}
