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
