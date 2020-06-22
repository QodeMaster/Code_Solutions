// Basic Solution

int[] replaceMiddle(int[] arr) {
    if(arr.Length % 2 == 1) {
        return arr;
    } else {
        int[] sum = new int[1] { arr[arr.Length / 2 - 1] + arr[arr.Length / 2] };
        
        return arr.Take(arr.Length / 2 - 1).Concat(sum.Concat(arr.Skip(arr.Length / 2 + 1))).ToArray();
    }
}

/*----------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------*/

// One-liner

int[] replaceMiddle(int[] arr) => (arr.Length % 2 == 1) ? arr : arr.Take(arr.Length / 2 - 1).Concat((new int[1] { arr[arr.Length / 2 - 1] + arr[arr.Length / 2] }).Concat(arr.Skip(arr.Length / 2 + 1))).ToArray();
