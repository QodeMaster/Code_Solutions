// Basic Solution

int timedReading(int maxLength, string text) {
    Regex rgx = new Regex(@"\w+");
    int count = 0;
    
    foreach(Match match in rgx.Matches(text)) {
        if(match.Value.Length <= maxLength) count++;
    }
    
    return count;
}

/*----------------------------------------------------------*/
/*----------------------------------------------------------*/

// One-liner

int timedReading(int maxLength, string text) => new Regex(@"\w+").Matches(text).Where(x => x.Value.Length <= maxLength).Count();
