/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 24/8/2024
 * Hora: 10:47
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Practica_1
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola : Coleccionable
	{
		
		private List <Comparable> elementos ;
		
		public Cola()
		{
			this.elementos = new List<Comparable>();
		}
		
		public void encolar(Comparable c){
			this.elementos.Add(c);
		}
		
		public Comparable desencolar(){
			Comparable aux= elementos[0];
			elementos.Remove(0);
			return aux;
		}
		
		//IMplemento interfaz coleccionable 
		public int cuantos(){
			return elementos.Count;
		}
		public Comparable minimo(){
			Comparable minimo = elementos[0];
			foreach (Comparable com in elementos) {
				if (minimo.sosMayor(com)) {
					minimo = com;
				}
				return minimo;
			}
		}
		
		
		public Comparable maximo(){
			for (int i = 1; i < this.cuantos(); i++) {
				if (maximo.sosMenor(elementos[i])) {
					maximo = elementos[i];
				}
			}
			return maximo;
			
		}
		
		private void agregar(Comparable c){
			this.encolar(c);
		}
		//===============================
		public bool contiene(Comparable c){ 
		}
	}
	
	
}
