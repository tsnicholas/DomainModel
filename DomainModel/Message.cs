namespace DomainModel;
using static DomainModel.People;

public class Message {
    public People author { get; }
    public String title { get; }
    public String body { get; }
    
    public Message(People author, String title, String body) {
        this.author = author;
        this.title = title;
        this.body = body;
    }
}
