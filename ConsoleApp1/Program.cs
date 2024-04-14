//#0
using System;

Console.WriteLine("Eded daxil et:");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 0)
{
    Console.WriteLine("Eded sifirdi");
}
else if (num < 0)
{
    Console.WriteLine("eded menfidir");
}
else
{
    Console.WriteLine("eded musbetdir");
}
//#1
Console.WriteLine("5 eded daxil edin");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int num4 = Convert.ToInt32(Console.ReadLine());
int num5 = Convert.ToInt32(Console.ReadLine());
int sum = num1 + num2 + num3 + num4 + num5;
Console.WriteLine("ededlerin cemi:" + sum);
//#2
Console.WriteLine("Eded daxil et:");
int number = Convert.ToInt32(Console.ReadLine());
int pow = number * number;
Console.WriteLine("Ededin kvadrati " + pow);
//#3
Console.WriteLine("3 eded daxil edin");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number2)
{
    Console.WriteLine("en boyuk eded: " + number1);
}
else if (number3 > number1 && (number3 > number2))
{
    Console.WriteLine("en boyuk eded: " + number3);
}
else if (number2 > number1 && number2 > number1)
{
    Console.WriteLine("en boyuk eded: " + number2);
}
else
{
    Console.WriteLine("Ededler beraberdi");
}
//#4
Console.WriteLine("2 eded daxil edin");
int numbers1 = Convert.ToInt32(Console.ReadLine());
int numbers2 = Convert.ToInt32(Console.ReadLine());
if (numbers1 * numbers1 * numbers1 > numbers2)
{
    Console.WriteLine("birinci ededin kubu ikinci ededden boyukdur");
}
else if (numbers1 * numbers1 * numbers1 < numbers2)
{
    Console.WriteLine("ikinci eded birinci ededin kubundan boyukdur");
}
else
{
    Console.WriteLine("birinci ededin kubu ikinci edede beraberdi");
}
//#5
Console.WriteLine("Eded daxil et:");
int nums1 = Convert.ToInt32(Console.ReadLine());
if (nums1 % 3 == 0 && nums1 % 5 == 0)
{
    Console.WriteLine("eded 3e ve 5e tam bolunur");
}
else
{
    Console.WriteLine("eded 3e ve 5e bolunmur");
}
//#6
Console.WriteLine("kartdaki meblegi daxil et");
int cash = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("mehsulun qiymeti");
int price = Convert.ToInt32(Console.ReadLine());
if (cash == price || cash > price)
{
    Console.WriteLine("sen mehsulu ala bilersen");
}
else
{
    Console.WriteLine("senin pulun azdi )");
}
//#7
Initalaizer:
Console.WriteLine("imtahanlardan aldığin balı qeyd elə:");
int bal1 = Convert.ToInt32(Console.ReadLine());
int bal2 = Convert.ToInt32(Console.ReadLine());
int bal3 = Convert.ToInt32(Console.ReadLine());
int bal4 = Convert.ToInt32(Console.ReadLine());
int bal5 = Convert.ToInt32(Console.ReadLine());
if (bal1 < 0 || bal2 < 0 || bal3 < 0 || bal4 < 0 || bal5 < 0 || bal1 > 100 || bal2 > 100 || bal3 > 100 || bal4 > 100 || bal5 > 100)
{
    Console.WriteLine("tezden qeyd ele:");
    goto Initalaizer;
}

else
{
    Console.WriteLine("I checked");
}
int avg = (bal1 + bal2 + bal3 + bal4 + bal5) / 5;
if (avg < 65)
{
    Console.WriteLine("Siz kesilmisiz(");
}
else
{
    Console.WriteLine("Siz semestri kecmisiz)");
}
//#8
Repeat:
Console.WriteLine("2 eded daxil et");
int natnum1 = Convert.ToInt32(Console.ReadLine());
int natnum2 = Convert.ToInt32(Console.ReadLine());
if (natnum1 < 0 || natnum2 < 0)
{
    Console.WriteLine("tezden qeyd ele:");
    goto Repeat;
}
else if (natnum1 > natnum2)
{
    Console.WriteLine("birinci eded boyukdu");
}
else if (natnum1 < natnum2)
{
    Console.WriteLine("ikinci eded boyukdu");
}
else
{
    Console.WriteLine("ededler eynidi");
}
//#9
Console.WriteLine("Temperatur daxil et");
int temperature = Convert.ToInt32(Console.ReadLine());
if (temperature < 0)
{
    Console.WriteLine("temperatur suyun donma derecesinden ashağıdı");
}
else if (temperature > 0)
{
    Console.WriteLine("temperatur suyun donma derecesinden yuxarıdı");
}
else
{
    Console.WriteLine("temperatur suyun donma derecesine beraberdi");
}
//************************************************************************************************
//************************************************************************************************
//#1
Console.WriteLine("50 geder ededler");
for (int i = 1; i <= 50; i++)
{
    Console.WriteLine(i);
}
//#2
Console.WriteLine("40 geder  3e bolunen ededler sayi:");
int j = 0;
for (int a = 1; a <= 40; a++)
{
    if (a % 3 == 0)
    {
        j++;
    }
}
Console.WriteLine(j);
//#3
Console.WriteLine("100 geder  3e  ve 7e bolunen ededler");
for (int b = 1; b <= 100; b++)
{
    if (b % 3 == 0 && b % 7 == 0)
    {
        Console.WriteLine(b);
    }
}
//#4
Console.WriteLine("eded daxil ele1");
int ctr = 0;
int t = Convert.ToInt32(Console.ReadLine());
while (t > 0)
{
    t = t / 10;
    ctr++;
}
Console.WriteLine(ctr);
//#5
Console.WriteLine("eded daxil ele2");
int rem = 0;
int rev = 0;
int d = Convert.ToInt32(Console.ReadLine());
while (d > 0)
{

    rem = d % 10;
    rev = rev * 10 + rem;
    d = d / 10;
}
Console.WriteLine(rev);
//#6
Console.WriteLine("eded daxil et3");
int c = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int fac = 1; fac <= c; fac++)
{
    factorial *= fac;
}
Console.WriteLine(factorial);
//#7
Console.WriteLine("eded daxil et4");
int v = Convert.ToInt32(Console.ReadLine());
bool s = true;
for (int n = 2; n < (int)Math.Sqrt(v); n++)
{
    if (v % n == 0)
    {
        s = false;
        break;
    }
}
if (s)
{
    Console.WriteLine("eded sadedir");
}
else
    Console.WriteLine("eded murekkebdir");
//#8
Console.WriteLine("eded daxil et5");
int l = Convert.ToInt32(Console.ReadLine());
int sum1 = 0;
while (l != 0)
{
    sum1 += l % 10;
    l /= 10;
}
Console.WriteLine(sum1);
//#9
Console.WriteLine("eded daxil et6");
int p = Convert.ToInt32(Console.ReadLine());
int max = 0;
while (p > 0)
{
    if (max < p % 10) max = p % 10;
    p /= 10;
}
Console.WriteLine(max);
//#10
Console.WriteLine("Ededlerin cut sirasi");
for (int u = 1; u <= 70; u++)
{
    if (u % 2 == 0)
    {
        Console.WriteLine(u);
    }
}
//#11
Console.WriteLine("ay daxil et");
int ay = Convert.ToInt32(Console.ReadLine());
switch (ay)
{
    case 1:
    case 2:
    case 12:
        Console.WriteLine("Qis");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("yaz");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yay");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Payiz");
        break;
    default: Console.WriteLine("ayi deyish"); break;
}
//#12
Console.Write("input size: ");
int size = Convert.ToInt32(Console.ReadLine());
for (int q = 0; q < size; q++)
{
    Console.Write("* ");
}
Console.WriteLine();
for (int q = 0; q < size - 2; q++)
{
    Console.Write("* ");
    for (int e = 0; e < size - 2; e++)
    {
        Console.Write("* ");
    }
    Console.WriteLine("* ");
}
for (int q = 0; q < size; q++)
{
    Console.Write("* ");
}
Console.WriteLine();
//#13    
Console.Write("input size");
int height = Convert.ToInt32(Console.ReadLine());

for (int w = 1; w <= height; w++)
{
    for (int x = 1; x <= w; x++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
//#14
Console.Write("input size");
int heights = Convert.ToInt32(Console.ReadLine());

for (int g = heights; g >= 1; g--)
{
    for (int m = 1; m <= g; m++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}