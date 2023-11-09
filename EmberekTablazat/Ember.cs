using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmberekTablazat
{
	internal class Ember
	{
		private string name;
		private int age;

		public Ember(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
	}
}
