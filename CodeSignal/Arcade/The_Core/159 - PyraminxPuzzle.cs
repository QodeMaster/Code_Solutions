// Solution
// Inspired by me281

char[][] solution(char[] faceColors, string[] moves) {

  char[][] result = Enumerable.Range(0, 4)
    .Select(p => Enumerable.Repeat(faceColors[p], 9).ToArray())
    .ToArray();

  Dictionary<char, int[]> movelist = new Dictionary<char, int[]>() {
    ['U'] = new int[] { 0, 2, 3 },
    ['B'] = new int[] { 1, 3, 2 },
    ['L'] = new int[] { 2, 0, 1 },
    ['R'] = new int[] { 3, 1, 0 },
  };

  int[] smallmove = new int[] { 0, 4, 8 };
  int[][] bigmove = new int[][] { 
    new int[] { 1, 2, 3 }, 
    new int[] { 6, 5, 1 }, 
    new int[] { 3, 7, 6 } 
  };

  foreach (string move in moves.Reverse()) { 
    char[][] res = result.Select(p => p.Select(q => q).ToArray()).ToArray();

    string hm = move.ToUpper();
    int[] ml  = movelist[hm[0]];

    for (int i = 0; i < 3; i++) {
      int j = (3 + i + ((move.Length == 2) ? 1 : -1)) % 3;
      result[ml[i]][smallmove[i]] = res[ml[j]][smallmove[j]];
      if (hm != move) {
        for (int k = 0; k < 3; k++) {
          result[ml[i]][bigmove[i][k]] = res[ml[j]][bigmove[j][k]];
        }
      }
    }
  }

  return result;
}
