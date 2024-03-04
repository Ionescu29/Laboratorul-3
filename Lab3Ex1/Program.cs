// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Scrieti o functie care va calcula suma cifrelor unui numar
Console.WriteLine("introduceti numarul n");
int n = int.Parse(Console.ReadLine());
// AICI voi scrie functia 
int GetSuma(int n)
{
    int suma = 0;
    for(var i=0; i<=n;i++)
    {
        suma = n % 10 + n / 10;
    }
    return suma;
}