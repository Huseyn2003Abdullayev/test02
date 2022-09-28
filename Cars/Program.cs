// See https://aka.ms/new-console-template for more information
using Cars;

CarsDataManager carsDataManager = new CarsDataManager();
Console.WriteLine("Please enter your name.");
string name = Console.ReadLine();
Top:
Console.WriteLine("Hello " + name + ".");
Console.WriteLine("1.Insert car.");
Console.WriteLine("2.Update car.");
Console.WriteLine("3.Delete car.");
Console.WriteLine("4.Display all cars.");
Console.WriteLine("5.Display cars by brand.");
Console.WriteLine("6.Order by cost.");
int OperationNumber = 0;
try
{
    OperationNumber = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Please insert number.");
}
Console.Clear();
switch (OperationNumber)
{
    case 1:
        carsDataManager.InsertCar();
        break;
    case 2:
        carsDataManager.UpdateCar();
        break;
    case 3:
        carsDataManager.DeleteCar();
        break;
    case 4:
        carsDataManager.DisplayAllCars();
        break;
    case 5:
        carsDataManager.DisplayCarsByFilters();
        break;
}
Console.WriteLine("What do you want? ");
Console.WriteLine("1.Continue");
Console.WriteLine("2.Leave");
Answer:
int Answer = 0;
try
{
    Answer = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Please insert number.");
    goto Answer;
}
Console.Clear();
switch (Convert.ToInt32(Answer))
{
    case 1:
        goto Top;
    case 2:
        goto End;
    default:
        Console.WriteLine(" Please type correct number.");
        goto Answer;
}
End:
Console.ReadKey();