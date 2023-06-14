using linq_play.model;

internal class Program
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

    public Program()
    {
    }

    private static void Main(string[] args)
    {
        new Program().Run();
    }

    private IEnumerable<Person> GetQuery() =>
            from person in persons
            where person.Status == 1
            select person;

    private IEnumerable<Person> GetPersonsWhereNameContains(string search)
    {
        var query = GetQuery();

        return from p in query
                where
                !string.IsNullOrWhiteSpace(p.Name)
                &&
                p.Name.Contains(search, StringComparison.OrdinalIgnoreCase)
                select p;
    }

    private void Run()
    {
        var query = GetPersonsWhereNameContains("justina");

        foreach (var person in query)
        {
            Console.WriteLine($"{person.Name} ({person.Email})");
        }

        // Justina Merritt (nec.malesuada@icloud.edu)
        Console.ReadKey();
    }
}