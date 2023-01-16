namespace AdventOfCode
{
    interface IFileSystem
    {
        string FullName { get; set; }

        int Size { get; set; }

        public EFileType FileType { get; set; }
    }
}

