// Solution

/*
  ^[A-Z] checks if the first character is a capital letter.
  [^!?.]* checks if the characters "!", "?" and "." don't appear in the middle of the sentence.
  [.!?]{1}$ checks if the sentence ends with one and only one "!", "?" or ".".
*/

bool solution(string sentence)
{
  Regex regex = new Regex(@"^[A-Z][^!?.]*[.!?]{1}$");
  return regex.IsMatch(sentence);
}
