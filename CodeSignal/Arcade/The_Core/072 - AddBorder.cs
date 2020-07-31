// Solution

string[] addBorder(string[] picture) {
    string ast = "";
    foreach(char c in picture[0]) ast += "*";
    string[] astBorder = new string[] {ast};
    
    return astBorder.Concat(picture).Concat(astBorder).Select(x => "*" + x + "*").ToArray();
}
