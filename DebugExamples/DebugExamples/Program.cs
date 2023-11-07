
var a = 0;
a++;
var b = ++a;
a = square(a);
a--;


int square(int n)
{
    for(int i = 1; i< 200; i++ )
    {
        n = n + 7;
    }
    return n * n;
}