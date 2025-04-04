using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
	internal abstract class Etel
	{
		protected double caloriesPerDkg;
		protected double weight;
		protected string name;

		protected Etel(double caloriesPerDkg, double weight, string name)
		{
			this.caloriesPerDkg = caloriesPerDkg;
			this.weight = weight;
			this.name = name;
			IsItDairyFree = false;
		}

		private bool isItDairyFree;
		public bool IsItDairyFree { get => isItDairyFree; set => isItDairyFree = value; }

		public abstract double CountCalories();
	}
}
