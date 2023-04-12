using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
	public abstract class Airline
	{
		public string FlightNumber { get; set; }

		public IAirport Airport { get; set; }

		public virtual void GetLandingPermission()
		{

			bool hasPermisson = Airport.GiveLandingPermission(FlightNumber);
			if (hasPermisson)
			{
				Console.WriteLine("Enishe icaze verildi\n");
			}
			else
			{
                Console.WriteLine("Teyyare Qeydiyatdan kecmeyib");
                Console.WriteLine("Enishe icaze verilmedi\n");
			}


		}
	}
}
