using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
	internal class Car : Factory
	{
		public string Configuration { get; set; }

		public string MarkCar { get; set; }

		public override string CreateCar(int number)
		{
			switch (number)
			{
				case 1: return "Opel";
				case 2: return "Mazda";
				case 3: return "BMW";
				default: break;
			}
			return "Input correct number";
		}
		public override string BasicEquipment()
		{
			return "tripTronic,boardComputer,fogLights";
		}
		public virtual string AdditionalEquipment()
		{
			return "signaling";
		}
		public override string ToString()
		{
			return "Mark car:" + MarkCar + "\n" + "Configurations car:" + Configuration;
		}
	}
}
