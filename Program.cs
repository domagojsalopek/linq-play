// Data Source
var customers = new[] {
    new {
        FirstName = "Kalia",
        LastName = "Burt"
    },
    new {
        FirstName = "Christine",
        LastName = "Carver"
    },
    new {
        FirstName = "Tanisha",
        LastName = "Dotson"
    },
    new {
        FirstName = "Josiah",
        LastName = "Morales"
    },
    new {
        FirstName = "Venus",
        LastName = "Hubbard"
    },
    new {
        FirstName = "Jelani",
        LastName = "Miles"
    },
    new {
        FirstName = "Rooney",
        LastName = "Herrera"
    },
    new {
        FirstName = "Bert",
        LastName = "Moon"
    },
    new {
        FirstName = "Bort",
        LastName = "Moon"
    }
};

// Query Expression
var relevantCusstomers =
    from customer in customers
    where customer.LastName == "Moon"
    select customer;

// Execute the query.
foreach (var customer in relevantCusstomers)
{
    Console.WriteLine($"{customer.LastName}, {customer.FirstName}");
}

// Output:
// Moon, Bert
// Moon, Bort

var students = new[] {
    new {
        Name = "Fallon Norris",
        Grade = 4,
        Email = "fallonnorris7107@outlook.ca",
        Zip = "52462"
    },
    new {
        Name = "Zenaida Pace",
        Grade = 5,
        Email = "zenaidapace8936@protonmail.ca",
        Zip = "55596"
    },
    new {
        Name = "Dora Fry",
        Grade = 2,
        Email = "dorafry@google.net",
        Zip = "57232"
    },
    new {
        Name = "Basil Farrell",
        Grade = 3,
        Email = "basilfarrell4451@icloud.com",
        Zip = "41748"
    },
    new {
        Name = "Cairo Galloway",
        Grade = 3,
        Email = "cairogalloway1741@hotmail.ca",
        Zip = "34176"
    }
};




// Query
var goodStudents =
    from student in students
    where student.Grade > 3
    orderby student.Grade descending
    select student;

// Execution
var goodStudentsList = goodStudents.ToList();




// Execute the query.
foreach (var student in goodStudents)
{
    Console.WriteLine($"{student.Name}: {student.Grade}");
}

// Zenaida Pace: 5
// Fallon Norris: 4

//var averageStudents = students
//    .Where(s => s.Grade <= 3)
//    .OrderByDescending(s => s.Grade);

//// Execute the query.
//foreach (var student in averageStudents)
//{
//    Console.WriteLine($"{student.Name}: {student.Grade}");
//}

// Basil Farrell: 3
// Cairo Galloway: 3
// Dora Fry: 2

var extraordinaryStudents =
    from student in students
    where student.Grade == 5
    select student;

int numberOFExtraordinaryStudents = extraordinaryStudents.Count();

int numberOfExtraordinaryStudents2 = (
    from s in students
    where s.Grade > 4
    select s
).Count();

Console.ReadKey();