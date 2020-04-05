// Solution

bool stringsRearrangement(string[] inputArray) {

    bool Check(string one, string two) {
        int strike = 0;
        for(int i = 0; i < one.Length; i++) {
            if(one[i] != two[i]) {
                strike++;
                if(strike > 1) return false;
            }
        }

        return strike == 1;
    }

    string[][] GetPermutation(string[] arr) {
        int len = arr.Length;
        List<string> sequence = new List<string>();
        List<string[]> permutations = new List<string[]>();

        void Permutate(List<string> a) {
            for(int i = 0; i < a.Count; i++) {
                string str = a[i];
                sequence.Add(str);
                if(sequence.Count == len) {
                    permutations.Add(sequence.ToArray());
                } else {
                    var remain = a.Take(i).Concat(a.Skip(i + 1));
                    Permutate(remain.ToList());
                }
                sequence.RemoveAt(sequence.Count - 1);
            }
        }

        Permutate(arr.ToList());
        return permutations.ToArray();
    }

    string[][] array = GetPermutation(inputArray);

    for(int i = 0; i < array.Length; i++) {
        int count = 0;
        for(int j = 1; j < array[0].Length; j++) {
            if(!Check(array[i][j - 1], array[i][j])) count++;
        }
        if(count == 0) return true;
    }

    return false;
}
