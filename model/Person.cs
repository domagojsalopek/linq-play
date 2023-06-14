using System;
namespace linq_play.model
{
	public class Person
	{
		public Person(string name, string email, int status)
		{
			Name = name;
			Email = email;
			Status = status;
		}

		public string Name { get; }

        public string Email { get; }

		public int Status { get; }
    }
}

