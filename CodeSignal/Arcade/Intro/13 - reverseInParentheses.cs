// Regex solution

string reverseInParentheses(string inputString) {
    Regex d = new Regex(@"(\([a-z]*\))");
    while(d.IsMatch(inputString)) {
        int count = 0;
        
        var rep = d.Matches(inputString)[count++];
        string repo = Reverse(rep.ToString().Substring(1, rep.Length - 2));
        
        Console.WriteLine(repo);
        inputString = d.Replace(inputString, repo, 1);
    }
    
    
    return inputString;
}


public static string Reverse( string s ) {
    char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
}
