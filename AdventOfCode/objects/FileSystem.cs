
namespace AdventOfCode
{
    public class FileSystem : IFileSystem
    {
        public string FullName { get; set; } = string.Empty;

        public int Size { get; set; }

        public EFileType FileType { get; set; }

        public override string ToString()
        {
            return $"{Size} {FullName} ({FileType})";
        }
    }
}

