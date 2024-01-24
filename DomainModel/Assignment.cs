namespace DomainModel;
using static DomainModel.Student;
using System;

public class Assignment {
    public String name { get; set; }
    public String description { get; set; }
    public DateTime dueDate { get; set; }
    public int points { get; set; }
    public bool isPublished;

    public Assignment(String name, String description, DateTime dueDate, int points, bool isPublished) {
        this.name = name;
        this.description = description;
        this.dueDate = dueDate;
        this.points = points;
        this.isPublished = isPublished;
    }

    public void publish() {
        this.isPublished = true;
    }

    public void grade(Student student, int pointsEarned) {
        student.grade += (pointsEarned / this.points);
    }
}