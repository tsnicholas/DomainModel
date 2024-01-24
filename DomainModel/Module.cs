namespace DomainModel;
using static DomainModel.Assignment;

public class Module {
    public String name { get; set; }
    public List<Assignment> assignments { get; }
    private bool isPublished;

    public Module(String name, List<Assignment> assignments, bool isPublished) {
        this.name = name;
        this.assignments = assignments;
        this.isPublished = isPublished;
    }

    public void publish() {
        isPublished = true;
    }

    public void addAssignment(Assignment assignment) {
        this.assignments.Add(assignment);
    }
}
