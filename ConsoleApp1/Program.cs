// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
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

			//verificacion si el numero ingresado es valido

			//Nota: se pued hacer uso de double.TryParse ForegroundColor


			//solicita el segundo numero
			Console.Write("Ingresa otro Numero");

			//verificacion si el numero ingresado es valido


			//Pregunta si 
			Console.Write("Desea ingresar mas Numeros ?");

			//condicional en caso que el usuario desee ingresar mas numeros 

			//2 MODULO
			//Seleccionar que  tipo de operacion desea realizar 
			Console.WriteLine("\nSeleccione la Operación (+, -, *, /):");
			xxxx operacion = Console.ReadLine();
			yyyy Resultado = 0;


			//3 MODULO
			switch (operacion)
			{
				case "+":
					Resultado = num1 + num2;
					break;
				case "-";
					Resultado = num1 - num2;
					break;
				case "*":
					Resultado = num1 * num2;
					break;
				case "/":
					//verificacion dvision por cero
					if (num2 == 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Error. No existe la Division entre 0");
						return;
					}
					else
						Resultado = num1 / num2;
					break;

				default:
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Opcion No Permitida. ");
					return;

			}
			//4 MODULO
			//Salida de Resultados 
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"\nRESULTADO: {num1} {operacion} {num2} = {Resultado}");

			//resetear para dejar consola limpia
			Console.ResetColor();

			//Esperar hasta que el usuario cierre la ventana 
			Console.WriteLine("\nDesea Realizar otra operacion? ");
			Console.WriteLine("\nPresione S para continuar o Presione C para cancelar y salir");

			//validacion si el usuario desea continuar o no haciendo operaciones


			Console.ReadKey();

		}
	}
	
}