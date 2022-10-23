Console.Clear();


string[] GetArray() 
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}



int CountLength(string[] arr, int n) 
{
    int count = 0;
    for(int i = 0; i <arr.Length; i++) 

        if(arr[i].Length <= n) count++;
       
    return count;
    
}


string[] FindLessThan(string[] arr, int n) 
{
    string[] res = new string[CountLength(arr, n)];

    for(int i = 0, j = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= n) {
            res[j] = arr[i];
            j++;
        }
    }
    return res;
}


string[] array = GetArray();
string[] result = FindLessThan(array, 3);

Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");