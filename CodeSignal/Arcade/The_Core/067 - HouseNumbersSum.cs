// Solution

int houseNumbersSum(int[] inputArray) => inputArray.Take(Array.IndexOf(inputArray, 0)).Sum();
