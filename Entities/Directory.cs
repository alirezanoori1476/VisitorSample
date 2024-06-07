namespace VisitorSample.Entities;

public class Directory(params FileSystemItem[] children) : FileSystemItem
{
    private readonly List<FileSystemItem> _children = children.ToList();

    public override long Size()
    {
        return _children
            .Sum(child => child.Size());
    }

    public override void Accept(IFileSSystemVisitor visitor)
    {
        visitor.Visit(this);  // Using double dispatching

        foreach (var child in _children)
            child.Accept(visitor);
    }
}