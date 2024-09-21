using NewDemoConsoleApp;

Console.WriteLine("Demo Project!");
//int num1 = int.Parse(Console.ReadLine());
//string s = Convert.ToString(num1);
//Console.WriteLine(s);
//var demo = 10;
//string s2 = demo.ToString();

//Person.Name = "Satya Ranjan Samal";
//Console.WriteLine(Person.Name);

//Int32[] arr = new Int32[4];
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}
//Array.Reverse(arr);

int[] arr = new int[5];
int[] arr2 = {12,32,41,54,56};
Array.Copy(arr2, 0, arr, 0, arr2.Length);

foreach (int item in arr)
{
    Console.Write(item + "\t");
}
Console.WriteLine();

Array.Clear(arr, 1,3);
foreach (int item in arr)
{
    Console.Write(item + "\t");
} 