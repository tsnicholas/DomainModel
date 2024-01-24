namespace DomainModel;
using static DomainModel.Message;
using System;

public class People {
    protected String name { get; set; }
    protected String biography { get; set; }
    protected List<Message> messages = new List<Message>();

    public People(String name, String biography) {
        this.name = name;
        this.biography = biography;
    }

    public void sendMessage(People person, Message message) {
        person.receiveMessage(message);
    }

    public void receiveMessage(Message message) {
        messages.Add(message);
    }
}
