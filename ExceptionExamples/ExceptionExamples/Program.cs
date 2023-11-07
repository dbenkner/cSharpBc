
using ExceptionExamples;

try
{
    method1();
} catch (Exception ex)
{
    Console.WriteLine("Something went wrong");
}
void method1()
{
    try
    {
        method2();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Caught");
    }
}
void method2()
{
    method3();
}
void method3()
{
    method4();
}
void method4()
{
    var d = 0;
    var e = 1 / d;
}
/*
int n = 1;
int d = 0;

try
{ 
    throw new Exception("WHY?");
    var a = n / d;
} 
catch (DivideByZeroException)
{
    Console.WriteLine("Don't divide by zero!");
}
catch (Exception)
{
    Console.WriteLine("This is a general exception!");
}
finally
{
    Console.WriteLine("This will always be executed!!!");
}

Console.WriteLine("Done...");
*/