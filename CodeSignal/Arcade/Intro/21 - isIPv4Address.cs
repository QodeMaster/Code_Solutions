// Solution

bool isIPv4Address(string inputString) {
    Regex l = new Regex(@"\d+\.\d+\.\d+\.\d+");
    if(!l.IsMatch(inputString)) return false;
    if(inputString != l.Matches(inputString)[0].ToString()) return false;
    
    String[] arr = inputString.Split('.');
    
    foreach(string i in arr) if(i.Length > 3 || int.Parse(i) > 255 || (i.Length > 1 && i[0] == '0')) return false;
    
    return true;
}
