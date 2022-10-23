Console.Clear();

string[] array = GetArray();
string[] result = FindLessThan(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLessThan(string[] arr, int n) {
    string[] output = new string[CounString(arr, n)];

    for(int i = 0, j = 0; i < arr.Length; i++) {
        if(arr[i].Length <= n) {
            output[j] = arr[i];
            j++;
        }
    }

    return output;
}

int CounString(string[] arr, int n) {
    int count = 0;

    for(int i = 0; i < arr.Length; i++) {
        if(arr[i].Length <= n) {
            count++;
        }
    }

    return count;
}


string[] GetArray() {
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}
