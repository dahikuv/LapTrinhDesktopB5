// Department class (Khoa)
public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Class> Classes { get; set; }

    public Department()
    {
        Classes = new List<Class>();
    }

    public override string ToString()
    {
        return Name;
    }
}

// Class class (Lớp)
public class Class
{
    public string ClassCode { get; set; }
    public string ClassName { get; set; }
    public Department Department { get; set; }
    public List<Student> Students { get; set; }

    public Class()
    {
        Students = new List<Student>();
    }

    public override string ToString()
    {
        return ClassCode;
    }
}

// Student class (Sinh viên)
public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public Class Class { get; set; }

    public override string ToString()
    {
        return FullName;
    }
}