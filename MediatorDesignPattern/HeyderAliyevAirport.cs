using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
	public class HeyderAliyevAirport : IAirport
	{
		public List<Airline> airlines = new List<Airline>();


		public bool GiveLandingPermission(string FlightNumber)
		{
			foreach (Airline airline in airlines)
			{
				if (airline.FlightNumber == FlightNumber)
					return true;

			}
			return false;
		}

		public void Register(Airline airline)
		{
		
			foreach (var item in airlines)
			{

				if (item.FlightNumber == airline.FlightNumber)
				{
					
					airline.Airport = this;
					return;
				}
			

			}
			airlines.Add(airline);
			airline.Airport = this;
		}
	}
}
