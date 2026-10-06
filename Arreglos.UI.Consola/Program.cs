using Arreglos.Logica;

Console.WriteLine("Operaciones de pila\n");

Console.WriteLine("Arreglo\n");
MiArreglo oMiArreglo = new MiArreglo(5);  //logico

try
{
    oMiArreglo.Agregar(7);
    oMiArreglo.Agregar(-2);
    oMiArreglo.Agregar(8);

    Console.WriteLine(oMiArreglo);

    Console.WriteLine("\nInsertar 500 en posicion 1");
    Console.ReadKey();  //al dar enter invocar insertar
    oMiArreglo.Insertar(500,1);
    Console.WriteLine(oMiArreglo);

    Console.WriteLine("\nEliminar 500 en posicion 1");
    Console.ReadKey();  //al dar enter invocar eliminar
    oMiArreglo.Eliminar(1);
    Console.WriteLine(oMiArreglo);

}
catch (Exception ex )
{
    Console.WriteLine(ex.Message);  //mostrar mensaje de error
}

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
