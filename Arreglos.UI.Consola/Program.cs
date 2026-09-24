using Arreglos.Logica;

Console.WriteLine("Operaciones de pila\n");

Console.WriteLine("Arreglo");
MiArreglo oMiArreglo = new MiArreglo(10);  //logico

oMiArreglo.Llenar(1, 20);   //fisico

Console.WriteLine("Arreglo desordenado\n");
Console.WriteLine(oMiArreglo);  //para recorrer

Console.WriteLine("Arreglo ordenado ascendente\n");
oMiArreglo.Ordenar();
Console.WriteLine(oMiArreglo);  

Console.WriteLine("Arreglo ordenado descendente\n");
oMiArreglo.Ordenar(false);
Console.WriteLine(oMiArreglo);  


Console.ReadKey();
