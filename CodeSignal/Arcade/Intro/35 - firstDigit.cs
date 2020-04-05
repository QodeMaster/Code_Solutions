// Basic solution

char firstDigit(string inputString) {
    Regex rgx = new Regex(@"[\d]");
    string str = rgx.Matches(inputString)[0].ToString();
    return char.Parse(str);
}

/*------------------------------------------------------*/
/*------------------------------------------------------*/

// One-liner

char firstDigit(string inputString) => char.Parse(new Regex(@"[\d]").Matches(inputString)[0].ToString());
