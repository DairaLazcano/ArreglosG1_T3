using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos.Logica
{
    public class MiArreglo
    {
        //Atributos
        private int _tope;
        private int[] _arreglo;

        //Constructor
        public MiArreglo(int n)   //ctor + tab
        {
            N=n;
            _arreglo = new int[N];
            _tope = 0;             //esta limpio el arreglo
            
        }

        //Propiedades
        public int N { get; }  //sin setter para no modificar el tamaño
        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;


        //Metodos
        public void Llenar(int minimo, int maximo)
        {
            Random oRandom = new Random();
            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = oRandom.Next(minimo, maximo + 1);
            }
            _tope = N;
        }

        //Metodo ToString
        public override string ToString()
        {
            if (EstaVacio)
            {
                return "Ésta vacio";
            }

            string cadena = string.Empty;  //Limpiar una cadena de forma eficiente
            int cont = 0;

            for (int i = 0; i < _tope; i++)  //El tope apunta a la sig direccion vacia (se pone -1)
            {
                //cadena = cadena + _arreglo[i];
                cadena += $"{_arreglo[i]}\t";   //interpolacion

                cont++;

                if(cont > 9)
                {
                    cont = 0;         //reinicio el contador
                    cadena += "\n";   //salto de linea cada 10 elementos
                }

            }
            return cadena;
        }
    }
}
