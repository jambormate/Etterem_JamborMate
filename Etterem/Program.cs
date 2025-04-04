using System.Data;

namespace Etterem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Etel> etterem = new List<Etel>();
			etterem.Add(new Levesek(100, 5, "Tejleves"));
			etterem.Add(new Levesek(250, 4, "Húsleves"));
			etterem.Add(new Levesek(125, 5, "Paradicsomleves"));
			etterem.Add(new Kenyerfelek(75, 10, "Fehérkenyér"));
			etterem.Add(new Kenyerfelek(60, 12, "Tejkenyér"));
			etterem.Add(new Kenyerfelek(300, 2, "Aranyozottkenyér"));
			etterem.Add(new Sulthusok(450, 15, "Tejes Csirke"));
			etterem.Add(new Sulthusok(375, 10, "Marha"));
			etterem.Add(new Sulthusok(400, 20, "Disznó"));

			etterem[1].IsItDairyFree = true;
			etterem[2].IsItDairyFree = true;
			etterem[3].IsItDairyFree = true;
			etterem[5].IsItDairyFree = true;
			etterem[7].IsItDairyFree = true;
			etterem[8].IsItDairyFree = true;


			static double SumCalories(List<Etel> etterem)
			{
				double sum = 0;
                foreach (Etel item in etterem)
                {
					sum += item.CountCalories();
                }
				return sum;
            }
            Console.WriteLine($"Összkalória: {SumCalories(etterem)}");

			static List<Etel> Dairyfree(List<Etel> etterem)
			{
				List<Etel> dairyfree = new List<Etel>();
				for (int i = 0; i < etterem.Count; i++)
				{
					if (etterem[i].IsItDairyFree == true)
					{
						dairyfree.Add(etterem[i]);
					}
				}
				return dairyfree;
			}
			Console.WriteLine(Dairyfree(etterem));
        }
	}
}
