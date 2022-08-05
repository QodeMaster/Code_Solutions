// Solution
// Inspired by armin_k1

int[] p, q;
int n, s, r;

int solution(char[][] F, int[][] C, char[] B, int[][] N) =>
    C.Sum (c => {
        if (F[c[0]][c[1]] > 46) {
            p = c;
            return 0;
        }
        if (p == q || 1 > R(F, new int[9, 9], p[1], p[r = 0], c[1], c[0])) {
            p = q;
            return 0;
        }
        F[c[0]][c[1]] = F[p[0]][p[1]];
        F[p[0]][p[1]] = '.';
        p = q;
        s = S(F);
        return s > 0 ? s : "   ".Max(_ => F[N[n][0]][N[n][1]] = B[n++]) * 0 + S(F);
    });

int R(dynamic F, int[,]V, int x, int y, int X, int Y) =>
    x < 0 | x > 8 | y < 0 | y > 8 || r++ > 0 && F[y][x] + V[y,x]++ > 46 ? 0 :
    x == X & y == Y ? 1 :
    "681=".Max (d => R(F, V, x + d % 3 - 1, y + d/6 - 9, X, Y));

int S(dynamic F) {
    var D = new int[9,9];
    int s = 0, m, M, i = 9, j, d;
    for (; i-- > 0; )
        for (d = -1; d < 3; ++d) {
            j = d < 2 ? F[i][4] : F[4][i];
            if (j > 46) {
                m = M = 0;
                try {
                    for (; (d < 2 ? F[i + d * m - d][m + 3] : F[m + 3][i]) == j; ) m--;
                } catch {}
                try {
                    for (; (d < 2 ? F[i + d * ++M][M + 4] : F[++M + 4][i]) == j;);
                } catch {}
                if (m + 4 < M) {
                    for (s += M - m + 1; m < M; ) {
                        if (d < 2) D[i + d * m, 4 + m++] = 1;
                        else D[4 + m++, i] = 1;
                    }
                }
            }
        }
    for (i = 9; i-- > 0; ) for (j = 9; j-- > 0; ) if (D[i,j] > 0) F[i][j] = '.';
    return s > 0 ? s - 1 : 0;
}
