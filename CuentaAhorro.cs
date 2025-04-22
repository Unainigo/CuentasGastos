using System;
using System.Collections.Generic;

public class CuentaAhorro
{
	public int DineroTotal = 0;
	public int Ingresos { get; set; };
	public int GastoTotal = 0;
	public int GastoObligatorioMensual { get; set; };
	public int GastoOcio { get; set; };
	public CuentaAhorro(int ingresos, int gastoObligatorio, int gastoMensual)
	{
		this.Ingresos = ingresos;
		this.GastoObligatorioMensual = gastoObligatorio;
		this.GastoOcio = gastoMensual;
		this.GastoTotal = GastoObligatorioMensual + GastoOcio;
		this.DineroTotal = Ingresos - GastoTotal;
	}
}
