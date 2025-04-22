using System;
using System.Collections.Generic;


public class Usuario{
	public int id_Usuario { set; get; };
	public string nombre { set; get; }
	public string correo { set; get; }
	public string contraseña { set; get; }
	public string Telefono { set; get; }
	public List<cuentaAhorro> cuentas { set; get; }
	public Usuario(int id_Usuario, string nombre, string correo, string contraseña, string telefono){
		this.id_Usuario = id_Usuario;
		this.nombre = nombre;
		this.correo = correo;
		this.contraseña = contraseña;
		this.Telefono = telefono;
		this.cuentas = new	List<cuentaAhorro>();
	}
}
