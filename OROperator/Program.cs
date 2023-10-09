//Math >= 90 OR chemistry >=90

//math && chemistry || math && biology || chemistry && biology
int math, biology, chemistry;

Console.WriteLine("Enter your math result");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result");
chemistry = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result");
biology = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry>= 90) || (math >= 90 && biology >=90) || (chemistry>=90 && biology>=90))
{
    Console.WriteLine("Congratulations! You got accepted");
}
else
{
    Console.WriteLine("Sorry, your application was denied");
}