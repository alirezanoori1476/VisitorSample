using Directory = VisitorSample.Entities.Directory;
using File = VisitorSample.Entities.File;

namespace VisitorSample;

public class LargestFileVisitor : IFileSSystemVisitor
{
    private long _maxSize;

    public void Visit(Directory directory)
    {
      // directory.Accept(this);
    }

    public void Visit(File file)
    {
        var fileSize = file.Size();

        if (_maxSize < fileSize)
            _maxSize = fileSize;
    }

    public long GetMaxSize() => _maxSize;
}