// Solution

string longestWord(string text) {
    string winner = "";
    Regex rgx = new Regex(@"[A-Za-z]*");

    foreach(Match matches in rgx.Matches(text)) {
        if(winner.Length < matches.Length) winner = matches.ToString();
    }


    return winner;
}
