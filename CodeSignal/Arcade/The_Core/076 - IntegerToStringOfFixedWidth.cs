// Solution

string integerToStringOfFixedWidth(int number, int width) {
    string num = new String('0', 45) + number.ToString();
    return num.Substring(num.Length - width);
}
