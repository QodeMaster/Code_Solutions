// Solution

bool isTandemRepeat(string inputString) => inputString.Substring(0, inputString.Length / 2) == inputString.Substring(inputString.Length / 2);
