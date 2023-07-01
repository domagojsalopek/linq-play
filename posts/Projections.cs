using System;
using linq_play.model;

namespace linq_play.posts
{
	public class Projections
	{
        private Person[] persons = new[]
        {
            new Person("Noel Pope", "a@google.net", 3),
            new Person("Justina Merritt", "nec.malesuada@icloud.edu", 1),
            new Person("Justina Florrick", "florrick@icloud.edu", 3),
            new Person("Justin Timberlake", "jtimberla.ke@icloud.edu", 1),
            new Person("Gabriel Dawson", "risus.quis.diam@icloud.com", 1),
            new Person("Caldwell Kirkland", "risus.donec@yahoo.com", 4),
            new Person("Tatum Pope", "at.iaculis@yahoo.org", 2),
        };

        public Projections()
		{
		}

        public class PersonInfoViewModel
        {
            public string Name { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
        }

		public void Run()
		{
            var projection = persons
                .Where(p => p.Name.Contains("justin", StringComparison.InvariantCultureIgnoreCase))
                .Select(p => new
                {
                    Name = p.Name,
                    Status = p.Status
                });

            //Name: Justina Merritt, Status: 1.
            //Name: Justina Florrick, Status: 3.
            //Name: Justin Timberlake, Status: 1.
            foreach (var personInfo in projection)
            {
                //Console.WriteLine($"Name: {personInfo.Name}, Status: {personInfo.Status}.");
            }

            IEnumerable<PersonInfoViewModel> persdnInfos = from person in persons
                                                            where person.Status == 1
                                                            select new PersonInfoViewModel
                                                            {
                                                                Email = person.Email,
                                                                Name = person.Name
                                                            };

            foreach (PersonInfoViewModel personInfo in persdnInfos)
            {
                //Console.WriteLine($"Name: {personInfo.Name}, E-Mail: {personInfo.Email}.");
            }

            //Name: Justina Merritt, E-Mail: nec.malesuada @icloud.edu.
            //Name: Justin Timberlake, E-Mail: jtimberla.ke @icloud.edu.
            //Name: Gabriel Dawson, E-Mail: risus.quis.diam @icloud.com.

            IEnumerable<string> output = persons.Select(p => $"Person {p.Name} with an E-Mail Address '{p.Email}' has a Status Value {p.Status}.");

            foreach (string s in output)
            {
                Console.WriteLine(s);
            }

            /*  OUTPUT:
             *  Person Noel Pope with an E-Mail Address 'a@google.net' has a Status Value 3.
                Person Justina Merritt with an E-Mail Address 'nec.malesuada@icloud.edu' has a Status Value 1.
                Person Justina Florrick with an E-Mail Address 'florrick@icloud.edu' has a Status Value 3.
                Person Justin Timberlake with an E-Mail Address 'jtimberla.ke@icloud.edu' has a Status Value 1.
                Person Gabriel Dawson with an E-Mail Address 'risus.quis.diam@icloud.com' has a Status Value 1.
                Person Caldwell Kirkland with an E-Mail Address 'risus.donec@yahoo.com' has a Status Value 4.
                Person Tatum Pope with an E-Mail Address 'at.iaculis@yahoo.org' has a Status Value 2.
            */

            Console.ReadKey();
		}
	}
}

