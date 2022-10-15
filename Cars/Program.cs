// See https://aka.ms/new-console-template for more information
using Cars;

CarsDataManager carsDataManager = new CarsDataManager();

Checking checking = new Checking();

Console.WriteLine("Please enter your name.");
string? name = Console.ReadLine();

bool Quality = false;

do
{
    Console.WriteLine("Hello " + name + ".");
    Console.WriteLine("1.Insert car.");
    Console.WriteLine("2.Update car.");
    Console.WriteLine("3.Delete car.");
    Console.WriteLine("4.Display all cars.");
    Console.WriteLine("5.Display cars by brand.");
    Console.WriteLine("6.Order by cost.");

    int OperationNumber = 0;
    OperationNumber = checking.CheckNumber(OperationNumber);

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
        case 6:
            carsDataManager.DisplayCarsByCost();
            break;
    }

    Console.WriteLine("What do you want? ");
    Console.WriteLine("1.Continue");
    Console.WriteLine("2.Leave");

    int Answer = 0;
    checking.CheckNumber(Answer);

    Console.Clear();

    switch (Convert.ToInt32(Answer))
    {
        case 1:
            Quality = false;
            break;
        case 2:
            Quality = true;
            break;
    }
} while (Quality == false);

Console.ReadKey();