using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
	public interface IAirport
	{
		void Register(Airline airline);

		bool GiveLandingPermission(string FlightNumber);
	}
}
