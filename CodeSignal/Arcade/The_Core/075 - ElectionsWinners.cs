// Basic Solution

int electionsWinners(int[] votes, int k) {
    int max = votes.Max();
    int count = 0;

    if(k == 0) {
        votes[Array.IndexOf(votes, max)] = -1;
        if(votes.Max() == max) return 0;
        else votes[Array.IndexOf(votes, -1)] = max;

        return 1;
    }

    foreach(int i in votes) {
        if(max - k < i) count++;
    }

    return count;
}

/*-----------------------------------------------------------------*/
/*-----------------------------------------------------------------*/

// Functional Solution

int electionsWinners(int[] votes, int k) {
    int max = votes.Max();
    int[] winners = votes.Where(x => (k != 0 ? max < (x + k) : x == max)).ToArray();
    
    if(k == 0) return (winners.Length != 1 ? 0 : 1);
    return winners.Length;
}
