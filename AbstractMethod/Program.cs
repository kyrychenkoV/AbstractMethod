using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Car opel=new Car();
			opel.MarkCar=opel.CreateCar(1);
			opel.Configuration = opel.BasicEquipment() + "," + opel.AdditionalEquipment();
			Console.WriteLine(opel);

			Car mazda = new Car();
			Factory reference;
			reference = mazda;
			mazda.MarkCar=reference.CreateCar(2);
			mazda.Configuration=reference.BasicEquipment();
			Console.WriteLine(mazda);

			Car bmw = new Car();
			Configuration config = new Configuration();
			bmw.MarkCar =bmw.CreateCar(3);
			bmw.Configuration = bmw.BasicEquipment() + "," + config.AdditionalEquipment();
			Console.WriteLine(bmw);
			
		}
	}
}
