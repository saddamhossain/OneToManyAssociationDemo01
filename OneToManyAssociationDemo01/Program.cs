Student student1 = new Student() { Name = "Saddam", Id = "111-2", Address = "Dhaka" };

Student student2 = new Student() { Name = "Hossain", Id = "111-3", Address = "Sylhet" };

Student student3 = new Student() { Name = "Rana", Id = "111-1", Address = "Khulna" };

Department department = new Department() { Name = "Computer Science" };
try
{
    department.Add(student1);
    department.Add(student2);
    department.Add(student3);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

foreach (Student aStudent in department.GetStudents())
{
    Console.WriteLine(aStudent.Id + " " + aStudent.Name + " " + aStudent.Address);
}