// See https://aka.ms/new-console-template for more information
using Products;

ProductManager productManager = new ProductManager();
Console.WriteLine("Please enter your name.");
string name = Console.ReadLine();
Top:
Console.WriteLine("Hello " + name + ".");
Console.WriteLine("1.Insert product.");
Console.WriteLine("2.Update product.");
Console.WriteLine("3.Delete product.");
Console.WriteLine("4.Display all products.");
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
Console.WriteLine("What do you want? leave or continue");
string Answer = Console.ReadLine();
Console.Clear();
if (Answer == "continue")
{
    goto Top;
}
else if (Answer == "leave")
{
    goto End;
}
else
{
    Console.WriteLine("You type wrong word.Please try again.");
    goto Answer;
}
End:
Console.ReadKey();
