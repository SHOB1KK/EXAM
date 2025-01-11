string x = Console.ReadLine();

int cons = 0;
int vovl = 0;
void Text(int[] arr, int sum)
{
    for (int i = 0; i < x.Length; i++)
    {
        if (x.Length == 'e' || x.Length == 'a' || x.Length == 'o' || x.Length == 'u' || x.Length == 'i')
        {vovl++;}
    }
    else {
        cons++;
    }
    System.Console.WriteLine("Vowels: " + vovl);
    System.Console.WriteLine("Consonants: " + cons);
}
Text(arr, x);