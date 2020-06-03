// Solution

int swapAdjacentBits(int n)
{
  return ((n & 0x15555555) << 1) | ((n & 0x2AAAAAAA) >> 1);
}
