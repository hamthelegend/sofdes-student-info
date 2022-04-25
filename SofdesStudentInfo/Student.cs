namespace SofdesStudentInfo;

record Student(
    string FirstName,
    string LastName,
    int Year,
    string Course,
    string Section
){
    public override string ToString() {
        return
            $"First name: \t{FirstName}\n" +
            $"Last name: \t{LastName}\n" +
            $"Year: \t\t{Year}\n" +
            $"Course: \t{Course}\n" +
            $"Section: \t{Section}\n";
    }
}