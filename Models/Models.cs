namespace Models;

public class Parent
{
    public string? Id { get; set; }

    public ICollection<Child>? Childrens { get; set; }
}

public class Child
{
    public string? ChildId { get; set; }
}
