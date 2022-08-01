// Solution

int solution(string inputString) {
    return Regex.Matches(inputString, @"\d+|true|false|""[^""]*""").Count;
}
