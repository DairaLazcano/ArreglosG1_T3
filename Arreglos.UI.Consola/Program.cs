using Arreglos.Logica;

Console.WriteLine("Operaciones de pila\n");

Console.WriteLine("Arreglo");
MiArreglo oMiArreglo = new MiArreglo(100);  //logico

oMiArreglo.Llenar(1, 20);   //fisico

Console.WriteLine(oMiArreglo);  //para recorrer


Console.ReadKey();
