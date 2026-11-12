using Arreglos.Logica;

Console.WriteLine("Operaciones de pila\n");

//Console.WriteLine("Arreglo\n");
//MiArreglo oMiArreglo = new MiArreglo(100);  //logico

/*try
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
*/

/*oMiArreglo.Llenar(1, 20);   //fisico

Console.WriteLine("Arreglo desordenado\n");
Console.WriteLine(oMiArreglo);  //para recorrer

Console.WriteLine("Arreglo ordenado ascendente\n");
oMiArreglo.Ordenar();
Console.WriteLine(oMiArreglo);  

Console.WriteLine("Arreglo ordenado descendente\n");
oMiArreglo.Ordenar(false);
Console.WriteLine(oMiArreglo);  */

MiArreglo oMiArreglo = new MiArreglo(50000);

try
{
    Console.WriteLine("Arreglo\n");

    var tiempo1 = DateTime.Now;         //Tiempo antes de que se llene
    oMiArreglo.Llenar(1, 999999);

    Console.WriteLine(oMiArreglo);
    var tiempo2 = DateTime.Now;         //Tiempo despues de que se llene

    var restaTiempo = tiempo2 - tiempo1;

    Console.WriteLine($"\nTiempo transcurrido: {restaTiempo.Minutes} minutos, {restaTiempo.Seconds} segundos, {restaTiempo.Milliseconds} milisegundos, {restaTiempo.Nanoseconds} nanosegundos");
    Console.ReadKey();

    /*Console.WriteLine("\nPares\n");
    var verPares = oMiArreglo.ObtenerPares();
    Console.WriteLine(verPares);
    Console.ReadKey();

    Console.WriteLine("\nPares ordenados\n");
    verPares.Ordenar(true);
    Console.WriteLine(verPares);
    Console.ReadKey();*/

    Console.WriteLine("\nPrimos\n");
    var tiempo3 = DateTime.Now;
    var verPrimos = oMiArreglo.ObtenerPrimos();
    Console.WriteLine(verPrimos);
    var tiempo4 = DateTime.Now;

    var restaTiempo2 = tiempo4 - tiempo3;
    
    Console.WriteLine($"\nTiempo transcurrido: {restaTiempo2.Minutes} minutos, {restaTiempo2.Seconds} segundos, {restaTiempo2.Milliseconds} milisegundos, {restaTiempo2.Nanoseconds} nanosegundos");
    Console.ReadKey();

    //---------------------------------------------------------------------------------------
    Console.WriteLine("\nPrimos ordenados\n");
    var tiempo5 = DateTime.Now;
    verPrimos.Ordenar(true);
    Console.WriteLine(verPrimos);
    var tiempo6 = DateTime.Now;

    var restaTiempo3 = tiempo6 - tiempo5;

    Console.WriteLine($"\nTiempo transcurrido: {restaTiempo3.Minutes} minutos, {restaTiempo3.Seconds} segundos, {restaTiempo3.Milliseconds} milisegundos, {restaTiempo3.Nanoseconds} nanosegundos");

    Console.ReadKey();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
  
}



Console.ReadKey();
