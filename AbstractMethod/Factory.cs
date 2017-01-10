using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
	internal abstract class Factory
	{
		private string configuration;//
		private string markCar;//


		public abstract string CreateCar(int a);
		public abstract string BasicEquipment();


	}
}
