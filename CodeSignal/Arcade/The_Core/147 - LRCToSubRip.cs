// Solution

string[] solution(string[] lrcLyrics, string songLength) {
    string[] output = new string[(lrcLyrics.Length * 4) - 1];
    
    for (int i = 0; i < lrcLyrics.Length; i++) {
        int outputIndex = i * 4;
        
        output[outputIndex++]     = (i + 1).ToString();
        output[outputIndex++] = GetTime(lrcLyrics[i].Substring(1, 8), false) 
        + " --> "  + (((i + 1) <= (lrcLyrics.Length - 1)) 
        ? GetTime(lrcLyrics[i + 1].Substring(1, 8), false) 
        : GetTime(songLength, true));
        output[outputIndex++] = (lrcLyrics[i].Length <= 10) ? "" : lrcLyrics[i].Substring(11);
        
        if (i != lrcLyrics.Length - 1) output[outputIndex] = "";
    }
        
    return output;
}

string GetTime(string timeStr, bool isSongLength) {
    string t = "";
    
    if (isSongLength) {
        t += timeStr.Substring(0, 2) + ":";
        t += timeStr.Substring(3, 2) + ":";
        t += timeStr.Substring(6, 2) + ",000";
    } else {
        t += (int.Parse(timeStr.Substring(0, 2)) / 60).ToString("00") + ":";
        t += (int.Parse(timeStr.Substring(0, 2)) % 60).ToString("00") + ":";
        t += (int.Parse(timeStr.Substring(3, 2)) % 60).ToString("00") + ",";
        t += timeStr.Substring(6, 2); //Milliseconds
    }
    
    while (t.Length < 12) t += "0";
    
    return t;
}
