// Setup
Console.WriteLine("\n----- Setup -----\n");
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);


// Ejercicio 1
Console.WriteLine("\n----- Ejercicio Numero 1 -----\n");
float X, Y;
bool checkParse;

Console.Write("Ingrese un numero mayor a 0: ");
checkParse = float.TryParse(Console.ReadLine(), out X);

while ((checkParse == false) || (X <= 0))
{
    Console.WriteLine("\nERROR: Debe ingresar un NUMERO que sea MAYOR A '0'.");
    Console.Write("Ingrese un numero: ");
    checkParse = float.TryParse(Console.ReadLine(), out X);
}


Y = (1/X);
Console.WriteLine("\nEl inverso del numero '" + X + "' es: '" + Y + "'");