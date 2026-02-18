// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;

namespace Calculadora
{
	internal class program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Claculadora ITM v1.0");
			//1 MODULO
			//solicita primero un numero
			Console.Write("Ingresa un Numero");
			double num1;

			//verificacion si el numero ingresado es valido
			double.TryParse(Console.ReadLine(), out num1);

			
			//solicita el segundo numero
			Console.Write("Ingresa otro Numero");
			double num2;
			//verificacion si el numero ingresado es valido
			double.TryParse(Console.ReadLine(), out num2);

			// 2 MODULO
			//Seleccionar que  tipo de operacion desea realizar 
			const int MaxIntentos = 5;
			string operacion = null;

			for (int intento = 1; intento <= MaxIntentos; intento++)
			{
				Console.WriteLine("\nSeleccione la Operación (+, -, *, /):");
				string entrada = Console.ReadLine()?.Trim();

				if (entrada == "+" || entrada == "-" || entrada == "*" || entrada == "/")
				{
					operacion = entrada;
					break;
				}

				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine($"Opcion No Permitida use solo los operadores + - * /  \n Intento {intento} de {MaxIntentos} \n Try Again");
				Console.ResetColor();
			}

			if (operacion == null)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Se Agotaron los Permisos.  El Programa se Cerrará. ");
				Console.ResetColor();
				return;
			}
			double resultado = 0;

			//3 MODULO
			switch (operacion)
			{
				case "+":
					resultado = num1 + num2;
					break;
				case "-":
					resultado = num1 - num2;
					break;
				case "*":
					resultado = num1 * num2;
					break;
				case "/":
					//verificacion dvision por cero
					if (num2 == 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Error. No existe la Division entre 0");
						Console.ResetColor();
						return;

					}
					else
						resultado = num1 / num2;
					break;

				default:
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Opcion No Permitida. ");
					Console.ResetColor();
					return;

			}


			//Pregunta si 
			//Console.Write("Desea ingresar mas Numeros ?");
			//condicional en caso que el usuario desee ingresar mas numeros 



			//4 MODULO
			//Salida de Resultados 
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"\nRESULTADO: {num1} {operacion} {num2} = {resultado}");

			//resetear para dejar consola limpia
			Console.ResetColor();

			//Esperar hasta que el usuario cierre la ventana 
			Console.WriteLine("\n ¿Desea Realizar otra operación? ");
			Console.WriteLine("\nPresione S = continuar | C = cancelar y salir");
			string continuar = Console.ReadLine()?.ToUpperInvariant();

			if (continuar == "S")
			{
				Console.WriteLine("Continuar Operando.");
			}
			else if (continuar == "C")
			{
				Console.WriteLine("Saliendo de la calculadora...");
				return;
			}

			//validacion si el usuario desea continuar o no haciendo operaciones


			Console.ReadKey();

		}
	}

}
