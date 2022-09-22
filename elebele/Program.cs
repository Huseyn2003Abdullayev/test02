// See https://aka.ms/new-console-template for more information
int n = 0;
int m = 0;
//n = Convert.ToInt32(Console.ReadLine());
tezden:
try
{
    
    n = Convert.ToInt32(Console.ReadLine());
    m = Convert.ToInt32(Console.ReadLine());

}
catch
{
    Console.WriteLine("sehvdi");
    goto tezden;
}


// Error: Use of unassigned local variable 'n'.
Console.ReadKey();