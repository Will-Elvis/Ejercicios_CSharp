/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 24/8/2024
 * Hora: 08:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_1
{
	
	class Program
	{
		public static void Main(string[] args)
		{
			
			Cola cola = new Cola();
			llenar(cola);
			informar(cola);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		//implementando una funcion llenar 
		public static void llenar(Coleccionable coleccion){
			for (int i = 0; i < 20; i++) {
				Comparable com = new Numero(i);
				coleccion.agregar(com);
			}
		}
		
		public static void informar(Coleccionable coleccion){
			Console.WriteLine(coleccion.cuantos());
			Console.WriteLine(coleccion.minimo());
			Console.WriteLine(coleccion.maximo());
		}
		
	}
}