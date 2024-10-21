namespace OneToManyAssociationDemo01;

public class Department
{
    public string Name { get; set; }
    public string Location { get; set; }
    public int StudentCapacity { get; private set; }
    public int RemainingSeats { get; private set; }
    private List<Student> students { get; set; }

    public Department()
    {
        students = new List<Student>();
        StudentCapacity = 2;
    }

    public void Add(Student student)
    {
        if (students.Count < StudentCapacity)
        {
            students.Add(student);
        }
        else
        {
            throw new ApplicationException("Capacity reached");
        }
    }

    public List<Student> GetStudents()
    {
        return students.ToList();
    }
}