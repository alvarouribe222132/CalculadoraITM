// See https://aka.ms/new-console-template for more information
using System;

namespace Calculadora
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string continuar = "S";

			while (continuar == "S")
			{
				Console.WriteLine("Calculadora ITM v2.0");
				//1 MODULO
				//solicita primero un numero
				Console.Write("Ingresa un Numero: ");
				double num1;

				//verificacion si el numero ingresado es valido
				double.TryParse(Console.ReadLine(), out num1);


				//solicita el segundo numero
				Console.Write("Ingresa otro Numero: ");
				double num2;
				//verificacion si el numero ingresado es valido
				double.TryParse(Console.ReadLine(), out num2);

				// 2 MODULO
				//Seleccionar que  tipo de operacion desea realizar 
				const int MaxIntentos = 3;
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
					break;
				}
				double resultado = 0;
				bool huboerror = false;

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
							huboerror = true;
						}
						else
						{
							resultado = num1 / num2;
						}
						break;

					default:
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("Opcion No Permitida. ");
						Console.ResetColor();
						huboerror = true;
						break;

				}


				//4 MODULO
				//Salida de Resultados 
				if (!huboerror)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine($"\nRESULTADO: {num1} {operacion} {num2} = {resultado}");

					//resetear para dejar consola limpia
					Console.ResetColor();
				}
				

				//Esperar hasta que el usuario cierre la ventana 
				Console.WriteLine("\n ¿Desea Realizar otra operación? ");
				Console.WriteLine("\nPresione S = continuar | C = cancelar y salir");
				continuar = Console.ReadLine()?.ToUpperInvariant();

				if (continuar == "C")
				{
					Console.WriteLine("Saliendo de la calculadora...");
					break;
				}
				else if (continuar != "S")
				{
					Console.WriteLine("Opción no reconocida. Saliendo..");
					break;
				}
			}
			Console.WriteLine("\nPresione cualquier tecla para cerrar...");
			Console.ReadKey();

		}
	}

}
