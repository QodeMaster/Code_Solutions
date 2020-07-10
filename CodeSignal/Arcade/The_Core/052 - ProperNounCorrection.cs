// Basic Solution

string properNounCorrection(string noun) {
    string fixedNoun = noun.ToLower().Substring(1);
    
    if(64 < (int)noun[0] && (int)noun[0] < 91) {
        return noun[0] + fixedNoun;
    } else {
        return (char)((int)noun[0] - 32) + fixedNoun;
    }
}

/*-------------------------------------------------------------------------*/
/*-------------------------------------------------------------------------*/

// One-liner

string properNounCorrection(string noun) => ((64 < (int)noun[0] && (int)noun[0] < 91) ? noun[0] : (char)(noun[0] - ' ')) + noun.ToLower().Substring(1);
