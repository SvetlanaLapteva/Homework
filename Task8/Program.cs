int n, i;
Console.Write("Введите число n: ");
string s = Console.ReadLine();
n = Convert.ToInt32(s);
i = 1;
while (i <= n)
{
  if (i % 2 == 0){
    Console.WriteLine(i);
  }
  i++;
}
