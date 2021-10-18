using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Interface
{
	class student : person
	{
		private String name;
		private String lastName;
		private String school;
		private DateTime dateOfBorn;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}

		public String LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		public String School
		{
			get { return school; }
			set { school = value; }
		}

		public DateTime DateOfBorn
		{
			get { return dateOfBorn; }
			set { dateOfBorn = value; }
		}

		public student()
		{
			name = "Default";
			lastName = "Student";
			School = "00001";
			dateOfBorn = new DateTime(2004, 1, 1);
		}

		public student(String name, String lastName, String school, DateTime dateOfBorn)
		{
			this.name = name;
			this.lastName = lastName;
			this.school = school;
			this.dateOfBorn = dateOfBorn;
		}

		public void presentation()
		{
			Console.WriteLine("Hello my name is {0} {1} and I study in {2}", name, lastName, school);
		}

		public void document()
		{
			Console.WriteLine("Name: {0}", name);
			Console.WriteLine("Last name: {0}", lastName);
			Console.WriteLine("Date of born: {0}", dateOfBorn);
		}

		public int calculateAge()
		{
			int age = DateTime.Today.AddTicks(-dateOfBorn.Ticks).Year - 1;

			return age;
		}
	}
}
