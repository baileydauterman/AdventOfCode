
namespace AdventOfCode
{
    public class FileSystem : IFileSystem
    {
        public string FullName { get; set; }

        public int Size { get; set; }

        public EFileType FileType { get; set; }
    }
}

