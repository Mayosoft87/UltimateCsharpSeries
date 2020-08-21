using System;

namespace VariablesConstantsC
{
	class Variables
	{
		static void Main(string[] args)
		{
			//Using the Primitive Types Explicit
			int count = 10;
			byte number = 255;
			float pi = 9.14f;
			bool isWorking = false;
			char grade = 'A';
			string firstName = "Mario";

			//Using var the compiler will be resolve the type variable
			var surName = "Velazquez";

			//Overflowing
			//If you add the checked Scope  you can catch the exception
			//checked
			//{
			//	number += 1;
			//}

			//Using arguments on the string {}
			Console.WriteLine("Hola {0} {1}",firstName,surName);
			Console.WriteLine(count);
			Console.WriteLine(number);
			Console.WriteLine(pi);
			Console.WriteLine(isWorking);
			Console.WriteLine(grade);


			//Check the Max and Min value
			Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);
			Console.WriteLine("{0} {1}",float.MinValue,float.MaxValue);

			//Constants
			const float PiValue = 3.1416f;
			Console.WriteLine(PiValue);


			//Type conversion 

			//Implicit
			byte bi = 1;
			int i = bi;

			//Explicit (Casting)
			float f = 1.0f;
			int intConvert = (int)f;

			//Non-compatability types
			string n = "1";
			int sConvert = Convert.ToInt32(n);
			int j = int.Parse(n);


			//Opreators 
			var a = 3;
			var b = 4;
			var c = 6;

			Console.WriteLine(a+b);

			//If you want the result in float you have to parse the number as float
			Console.WriteLine((float)a/(float)b);

			//Precedents
			Console.WriteLine((a+b)*c);
			
			//Compare values
			Console.WriteLine(a==b);

			Console.WriteLine(a!=b);
			

		}
	}
}
