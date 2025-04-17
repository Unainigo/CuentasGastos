using System;
using System.Collections.Generic;


public class usuario{
	private int id_Usuario { set; get; };
	private string nombre { set; get; }
	private string correo { set; get; }
	private string contraseña { set; get; }
	private string Telefono { set; get; }
	private List <cuentaAhorro> cuentas { set; get; }
	public Usuario(int id_Usuario, string nombre, string correo, string contraseña, string telefono){
		this.id_Usuario = id_Usuario;
		this.nombre = nombre;
		this.correo = correo;
		this.contraseña = contraseña;
		this.Telefono = telefono;
		this.cuentas = new	List<cuentaAhorro>();
	}
	private void añadirCuenta(cuentaAhorro cuenta){
		cuentas.add(cuenta);
    }
	private void cambiarContraseña(string nuevaContraseña){
		contraseña = nuevaContraseña;
    }
}
