/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 24/8/2024
 * Hora: 10:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_1
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
	public class Numero : Comparable
	{
		private int valor;
		
		public Numero(int valor)
		{
			this.valor = valor;
		}
		
		public int getValor(){
			return this.valor;
		}
		
		// obligado a implememtar los metodos de la Interfaz
		
		
		public bool sosIgual(Comparable c){
			return this.valor == ((Numero)c).getValor();
		}
		
		public bool sosMenor(Comparable c){
			return this.valor < ((Numero)c).getValor();
		}
		public bool sosMayor(Comparable c){
			return this.valor > ((Numero)c).getValor();
		}
		
		public override string ToString()
		{
			return this.valor.ToString();
		}

	}
}
