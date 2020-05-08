// Solution

int sumUpNumbers(string inputString) {
    int tot = 0;

    foreach(Match match in Regex.Matches(inputString, @"\d+")) {
        tot += int.Parse(match.ToString());
    }

    return tot;
}
