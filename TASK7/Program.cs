int x = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[x];

for (int i = 0; i < x; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int sum = Convert.ToInt32(Console.ReadLine());

void FindPairs(int[] arr, int sum)
{
    bool found = false;

    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] + arr[j] == sum)
            {
                System.Console.WriteLine(arr[i] + " " + arr[j]);
                found = true;
            }
        }
    }

    if (!found)
    {
        System.Console.WriteLine("Not Found");
    }
}
FindPairs(arr, sum);