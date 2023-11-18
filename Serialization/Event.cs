using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
	[Serializable] // Mark the class as serializable 
	public class Event
	{
		//Properties
		public int EventNumber
		{
			get;
			set;
		}

		public string Location
		{
			get;
			set;
		}


		//Constructor
		public Event(int eventNumber, string location) // No arg and default constructor 
		{
			this.EventNumber = eventNumber;
			this.Location = location;	
	
		}
	}
}
