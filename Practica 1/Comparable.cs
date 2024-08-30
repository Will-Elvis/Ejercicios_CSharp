/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 24/8/2024
 * Hora: 10:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_1
{
	/// <summary>
	/// Description of Comparable.
	/// </summary>
	public interface Comparable
	{
		//metodos abstaractos que devuelven "True o False "
		// los metodos declarados son publicos y abstractos eso quiere decir que se dice que hace pero no como
		bool sosIgual(Comparable c);
		bool sosMenor(Comparable c);
		bool sosMayor(Comparable c);
		//public abstract  bool sosIgual(Comparable) recibe un objeto que implemente la interfaz : "Comparable"
	}
	
	
	
}
