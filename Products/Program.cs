// See https://aka.ms/new-console-template for more information
using Products;

ProductManager productManager = new ProductManager();
//ProductDataService productDataService = new ProductDataService();
Console.WriteLine("Please enter your name.");
string name = Console.ReadLine();
Top:
Console.WriteLine("Hello " + name + ".");
Console.WriteLine("1.Insert product.");
Console.WriteLine("2.Update product.");
Console.WriteLine("3.Delete product.");
Console.WriteLine("4.Display all product.");
string OperationNumber = Console.ReadLine();
Console.Clear();
switch (Convert.ToInt32(OperationNumber))
{
    case 1:
        productManager.InsertProduct();
        break;
    case 2:
        productManager.UpdateProduct();
        break;
    case 3:
        productManager.DeleteProduct();
        break;
    case 4:
        productManager.DisplayAllProducts();
        break;
}
Answer:
Console.WriteLine("What do you want? ");
Console.WriteLine("1.Continue");
Console.WriteLine("2.Leave");
string Answer = Console.ReadLine();
Console.Clear();
switch(Convert.ToInt32(Answer))
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
