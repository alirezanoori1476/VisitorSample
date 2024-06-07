namespace VisitorSample.Entities;

public abstract class FileSystemItem
{
    public string Name { get; set; }
    public abstract long Size();

    public abstract void Accept(IFileSSystemVisitor visitor);
}