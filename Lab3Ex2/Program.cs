// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatul
Console.WriteLine("introduceti numarul n");
int n = int.Parse(Console.ReadLine());
//urmeaza sa scriu functia
int GetPatrat(int n)
{
    int patrat = 0;
    for (var i=0;i<=n;i++)
    {
        patrat = patrat * n; 
    }
    return patrat;
}
Console.WriteLine(GetPatrat(n));