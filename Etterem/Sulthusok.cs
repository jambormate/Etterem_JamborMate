using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
	internal class Sulthusok : Etel
	{
		public Sulthusok(double caloriesPerDkg, double weight, string name) : base(caloriesPerDkg, weight, name)
		{
		}

		public override double CountCalories()
		{
			return caloriesPerDkg * weight; //Ez akkor ha a weight dkg-be van megadva  
		}
	}
}
