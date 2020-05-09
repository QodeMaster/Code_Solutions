// Solution

string[] fileNaming(string[] names) {
    List<string> newNames = new List<string>();
    List<int> inst = new List<int>();

    for(int i = 0; i < names.Length; i++) {
        if(newNames.Contains(names[i])) {
            int listIndex = newNames.IndexOf(names[i]);

            int fileIndex = inst[listIndex];
            string newName = names[i] + "(" + fileIndex + ")";

            while(newNames.Contains(newName)) {
                fileIndex++;
                newName = names[i] + "(" + fileIndex + ")";
            }

            inst[listIndex] = fileIndex;
            newNames.Add(newName);
            inst.Add(1);
        } else {
            newNames.Add(names[i]);
            inst.Add(1);
        }
    }

    return newNames.ToArray();
}
