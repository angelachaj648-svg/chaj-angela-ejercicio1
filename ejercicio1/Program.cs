//Triaje médico y prioridad de atención
Console.WriteLine("triage medico");
Console.WriteLine("tipo de atencion");
Console.WriteLine("1.EMERGENCIA");
Console.WriteLine("2.Consulta");
Console.WriteLine("3.pediadria");
Console.WriteLine("4.traumatologo");
int tipo = int.Parse(Console.ReadLine());
Console.WriteLine("edad");
int.Parse(Console.ReadLine());
Console.WriteLine("TEMPERATURA");
double temperatura = double.Parse(Console.ReadLine());
Console.WriteLine("Saturacion de oxigeno %");
int oxigeno = int.Parse(Console.ReadLine());
Console.WriteLine("NIVEL DEL DOLOR 0-10");
int dolor = int.Parse(Console.ReadLine());
Console.WriteLine("PRECION SISTOLOLICA");
int precion = int.Parse(Console.ReadLine());
int edad = int.Parse(Console.ReadLine());

if (edad < 0 || edad > 120)
{
	Console.WriteLine("error edad fuera del rango");
	return;
}
else if (oxigeno < 0 || oxigeno > 100)
{
	Console.WriteLine("error oxigeno fuera del rango ");
	return;
}
else if (dolor < 0 || dolor > 10 )
{
	Console.WriteLine("ERROR PRECION FUERA DEL RANGO");
	return;
}
int prioridad = 3;
string accion = "consulta normal";

switch (tipo)
{
	case 1:
		if (oxigeno < 90)
		{
			prioridad = 1;
			accion = "reanimacion inmediata";
		}
		else
		{
			if (temperatura >= 39 && dolor >= 8)
			{
				prioridad = 2;
				accion = "atencion";
			}
			else
			{
				prioridad = 3;
				accion = "observacion";
			}
		}
		break;
	case 2:
		if (dolor >= 7)
		{
			prioridad = 2;
			accion = "consulta priorioritaria";
		}
		else
		{
			prioridad = 3;
			accion = "consulta";
		}
		break;
	case 3:
		if (edad < 12)
		{
			if (temperatura > 38.5)
			{
				prioridad = 1;
				accion = "atencion pedriatica argente";
			}
		}
		break;
	case 4:
		if (dolor >= 8)
		{
			prioridad = 1;
			accion = "atencion traumatologica urgente";
		}
		else
		{
			prioridad = 2;
			accion = "radiografia y evaluacion";
		}
		break; }


















