namespace DomainModel;
using static DomainModel.People;

public class Student : People {
    public double grade { get; set; }
    
    public Student(String name, String biography, double grade) : base(name, biography) {
        this.grade = grade;
    }
}
