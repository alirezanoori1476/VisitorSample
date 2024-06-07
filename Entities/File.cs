namespace VisitorSample.Entities;

public class File(long fileSize) : FileSystemItem
{
    private long FileSize { get; set; } = fileSize;

    public override long Size()
    {
        return FileSize;
    }

    public override void Accept(IFileSSystemVisitor visitor)
    {
        visitor.Visit(this); // Using double dispatching
    }
}