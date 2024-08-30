/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 24/8/2024
 * Hora: 08:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_1
{
	class Program
	{
		// En las interfaces no hace falta poner PUBLIC por que todos lo metodos lo tiene por DEFECTO !!
		public interface IAmigable
		{
			void jugar();
		}
		
		public class Musico:IAmigable{
			public void jugar();
		}
		public class Persona : IAmigable{
			public void jugar();
		}
		
		public class Perro : IAmigable{
			public void jugar();
		}
		
		//=== Variable de INTERFACE =================
		
		public void metodo(){
			
			IAmigable c1,c2,c3;
			c1 = new Musico();
			c2 = new Perro();
			c3 = new IAmigable();
			
				
		}
	
		
		//================= MAIN ======
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}