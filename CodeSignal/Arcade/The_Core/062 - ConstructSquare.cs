// Solution

int constructSquare(string s) {
    int top = (int)Math.Pow(10, s.Length) - 1;
    int upper = (int)Math.Floor(Math.Pow((top), 0.5));
    int lower = (int)Math.Pow((top + 1) / 10, 0.5);
    var a = s.ToLookup(c => c);
    int distinct = a.Count();
    int[] arr = a.Select(x => x.Count()).ToArray();
    
    
    for(int i = upper; i > lower; i--) {
        string sqr = (i * i).ToString();
        if(distinct == sqr.Distinct().Count()) {
            var digitArr = sqr.ToLookup(c => c).Select(x => x.Count());
            if(!arr.Any(x => !digitArr.Contains(x))) return int.Parse(sqr);
        }
    }
    
    return -1;
}
