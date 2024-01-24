namespace DomainModel;
using static DomainModel.Student;
using static DomainModel.Teacher;
using static DomainModel.Module;

public class Course
{
    public String name { get; set; }
    public Teacher teacher { get; }
    public List<Module> modules { get; }
    public List<Student> students { get; }

    public Course(String name, Teacher teacher, List<Module> modules, List<Student> students) {
        this.name = name;
        this.teacher = teacher;
        this.modules = modules;
        this.students = students;
    }

    public void addModule(Module module) {
        this.modules.Add(module);
    }

    public void addStudent(Student student) {
        this.students.Add(student);
    }
}
