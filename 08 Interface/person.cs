using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Interface
{
	interface person
	{
		public String Name
		{
			get;
			set;
		}

		public String LastName
		{
			get;
			set;
		}

		public String School
		{
			get;
			set;
		}

		public DateTime DateOfBorn
		{
			get;
			set;
		}
		
		void presentation();
		void document();
		int calculateAge();
	}
}
