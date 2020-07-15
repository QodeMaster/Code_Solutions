// Solution

bool isMAC48Address(string inputString) {
    Regex reg = new Regex(@"[A-F\d-]{14}-[A-F\d]{2}");
    if(reg.IsMatch(inputString)) {
        if(reg.Matches(inputString)[0].ToString() == inputString) {
            return true;
        }
    } 

    return false;
}
