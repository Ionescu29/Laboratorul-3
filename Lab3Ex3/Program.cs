// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");
//Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la
//tastatura.Scrieti functii care vor returna:
Console.WriteLine("cate elemente doriti sa cititi");
int n = int.Parse(Console.ReadLine());
int[] vector = new int[n];
//Cel mai mare numar din vector
int GetMax(int[]vector)
{
    int max = 0;
    for(int i=0;i<vector.Lenght;i++)
    {
        max = vector[i];
    }
    return max;
}
Console.WriteLine(Max(vector));
//Cel mai mic numar din vector
int GetMin(int[]vector)
{
    int min = 0;
    for(int i=0;i<vector.Length;i++)
    {
        min = vector[i];
    }
    return min;
}
//numerele divizibile cu 3
int GetDiv(int[]vector)
{
    int k = 0;
    //k fiind numerele divizibile cu 3
    for (int i=0;int<vector.Lenght;i++)
    {
        k = k * vector[i];
    }
    return k;
}
// numerele patrate perfecte
int GetPP(int[]vector)
{
    int pp = 0;
    //pp este patratul perfect
    for (int i=0;i<vector.Length;i++)
    {
        pp = pp * vector[i];
    }
    return pp;
}