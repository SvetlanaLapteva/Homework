int a, b, c;
Console.WriteLine("Введите три числа");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
if ((a>=b) & (a>=c)) {
   Console.WriteLine("{0} наибольшее число", a); 
}
else if ((b>=a) & (b>=c)) {
    Console.WriteLine("{0} наибольшее число", b);
}
else if ((c>=a) & (c>=b)) {
    Console.WriteLine("{0} наибольшее число", c);
}    