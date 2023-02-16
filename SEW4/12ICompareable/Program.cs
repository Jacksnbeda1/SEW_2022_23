using _12IComparable;

Student markus = new Student("Markus", "Leonhardsberger", new DateTime(2002, 12, 30));
Student felix = new Student("Felix", "Heidegger", new DateTime(2004, 12, 12));
Student benedikt = new Student("Benedikt", "Hager", new DateTime(2004, 11, 18));

List<Student> students = new List<Student>();
students.Add(markus);
students.Add(felix);
students.Add(benedikt);

Console.WriteLine("Unsorted: ");
foreach (Student student in students)
{
    Console.WriteLine(student);
}

students.Sort();            // diese Methode verwendet intern das Interface IComparable um die Objekte zu vergleichen

Console.WriteLine("Sorted: ");
foreach (Student student in students)
{
    Console.WriteLine(student);
}

