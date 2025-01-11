int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [a];

for (int i=0; i<a; i++){
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int maxx = -999999;
int minn = 9999999;

for (int i=0; i<a; i++){
    if (arr[i]>maxx){
        maxx = arr[i];
    }
}
for (int i=0; i<a; i++){
    if (arr[i]<minn){
        minn = arr[i];
    }
}
System.Console.WriteLine("min: " + minn);
System.Console.WriteLine("max: " + maxx);
int sum = maxx+minn;
System.Console.WriteLine("sum:" + sum);