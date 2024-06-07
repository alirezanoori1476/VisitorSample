using Directory = VisitorSample.Entities.Directory;
using File = VisitorSample.Entities.File;

namespace VisitorSample;

public interface IFileSSystemVisitor
{
    public void Visit(Directory directory);
    public void Visit(File directory);
}