using Arreglos.Logica;

Console.WriteLine("Operaciones de pila\n");

Console.WriteLine("Arreglo\n");
MiArreglo oMiArreglo = new MiArreglo(5);  //logico

try
{
    oMiArreglo.Agregar(7);
    oMiArreglo.Agregar(-2);
    Console.WriteLine(oMiArreglo);

    Console.ReadKey();  //al dar enter invocar insertar
    oMiArreglo.Insertar(500,20);

}
catch (Exception ex )
{
    Console.WriteLine(ex.Message);  //mostrar mensaje de error
}


Console.WriteLine(oMiArreglo);

//oMiArreglo.Llenar(1, 20);   //fisico

//Console.WriteLine("Arreglo desordenado\n");
//Console.WriteLine(oMiArreglo);  //para recorrer

//Console.WriteLine("Arreglo ordenado ascendente\n");
//oMiArreglo.Ordenar();
//Console.WriteLine(oMiArreglo);  

//Console.WriteLine("Arreglo ordenado descendente\n");
//oMiArreglo.Ordenar(false);
//Console.WriteLine(oMiArreglo);  



Console.ReadKey();
