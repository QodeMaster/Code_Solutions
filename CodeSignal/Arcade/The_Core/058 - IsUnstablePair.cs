// Solution

bool isUnstablePair(string filename1, string filename2) {
    if(String.Compare(filename2, filename1, StringComparison.Ordinal) > 0) return String.Compare(filename2.ToUpper(), filename1.ToUpper(), StringComparison.Ordinal) < 0;
    else if(String.Compare(filename2, filename1, StringComparison.Ordinal) < 0) return String.Compare(filename2.ToLower(), filename1.ToLower(), StringComparison.Ordinal) > 0;
    
    return false;
}
