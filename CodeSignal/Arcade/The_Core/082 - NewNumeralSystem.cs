// Solution

string[] newNumeralSystem(char number) {
    List<string> arr = new List<string>();
    char num = 'A';
    
    while((int)num <= (int)number) {
        arr.Add($"{num} + {number}");
        num = (char)((int)num + 1);
        number = (char)((int)number - 1);
    }
    
    return arr.ToArray();
}
