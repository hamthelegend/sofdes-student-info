using SofdesStudentInfo;

var numberOfStudents = Extensions.ForceReadNaturalNumberLine("Number of students", 1);;
var students = new Student[numberOfStudents];
Console.WriteLine();

foreach (var i in Enumerable.Range(0, numberOfStudents)) {
    Console.WriteLine($"Input student {i + 1}");
    var firstName = Extensions.ForceReadLine("First name", 1);
    var lastName = Extensions.ForceReadLine("Last name", 1);
    var year = Extensions.ForceReadNaturalNumberLine("Year", 2);
    var course = Extensions.ForceReadLine("Course", 1);
    var section = Extensions.ForceReadLine("Section", 1);
    students[i] = new Student(firstName, lastName, year, course, section);
    Console.WriteLine();
}

Console.WriteLine("Here are your students: ");
foreach(var student in students) {
    Console.WriteLine(student);
}