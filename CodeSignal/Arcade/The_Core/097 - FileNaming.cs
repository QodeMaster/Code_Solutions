// Solution

string[] fileNaming(string[] names) {
    List<string> keys = new List<string>();
    List<int> values = new List<int>();
    List<string> alteredArr = new List<string>();
    
    bool keysContain = false;
    bool alteredArrContain = false;
    foreach(string name in names) {
        keysContain = keys.Contains(name);
        alteredArrContain = alteredArr.Contains(name);
        if(!keysContain && !alteredArrContain) {
            keys.Add(name);
            values.Add(1);
            alteredArr.Add(name);
        } else if(keysContain) {
            int idx = values[keys.IndexOf(name)];
            while(alteredArr.Contains(name + "(" + idx + ")")) {
                idx++;
            }
            alteredArr.Add(name + "(" + idx + ")");
            values[keys.IndexOf(name)] = idx;
        } else {
            keys.Add(name);
            values.Add(1);
            alteredArr.Add(name + "(" + 1 + ")");
        }
    }
    
    return alteredArr.ToArray();
}
