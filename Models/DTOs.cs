namespace Models;

public class ParentDTO
{
    public string? Id { get; set; }
    public ICollection<ChildDTO>? Childrens { get; set; }
}

public class ChildDTO
{
    public string? ChildId { get; set; }
}
