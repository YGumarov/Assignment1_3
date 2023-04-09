static bool isPrime(int n,int temp=2)
{
    if (temp == n){ return true;}
    if (n % temp == 0) {return false;} 
    bool result=isPrime(n,temp+1);
    return result;
}

int n = int.Parse(Console.ReadLine());
if (isPrime(n) == true)
{
    Console.WriteLine("Prime");
}
else
{
    Console.WriteLine("Composite");
}