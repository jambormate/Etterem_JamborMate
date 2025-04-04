using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
	internal abstract class Etel
	{
		private double caloriesPerDkg;
		private double weight;
		private string name;

		protected Etel(double caloriesPerDkg, double weight, string name)
		{
			this.caloriesPerDkg = caloriesPerDkg;
			this.weight = weight;
			this.name = name;
		}

		private bool isItDairyFree;
		public bool IsItDairyFree { get => isItDairyFree; set => isItDairyFree = false; }

		public abstract double CountCalories();
	}
}
