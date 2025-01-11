int a = Convert.ToInt32(Console.ReadLine());

if (a/4 == 0 && a/100 == 0 && a/400 == 0){
    System.Console.WriteLine("Leap Year: Yes");
}
else if (a/4 == 0 && a/100!=0 && a/400 !=0){
    System.Console.WriteLine("Leap Year: Yes");
}
else {
    System.Console.WriteLine("Leap Year: No");
}