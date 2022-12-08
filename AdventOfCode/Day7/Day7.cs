
namespace AdventOfCode
{
    public class Day7
	{
        private Stack<string> fwd;
        private List<IFileSystem> files;

        public Day7()
        {
            fwd = new Stack<string>();
            files = new List<IFileSystem>();
        }

        public int ReadCommands(string path)
        {
            using (var stream = File.OpenRead(path))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    if (line.StartsWith("$ "))
                    {
                        ProcessCommand(line);
                        continue;
                    }

                    BuildFileSystem(line);
                }
            }

            return -1;
        }

        public void ProcessCommand(string line)
        {
            var split = line.Split(" ");

            switch (split[0])
            {
                case "cd":

                    switch (split[1])
                    {
                        case "..":
                            fwd.Pop();
                            break;
                        default:
                            fwd.Push(split[1]);
                            break;
                    }
                    break;

                case "ls":
                default:
                    break;
            }
        }

        public void BuildFileSystem(string line)
        {
            var filesSplit = line.Split(" ");

            switch (filesSplit[0])
            {
                case "dir":
                    files.Add(new FileSystem
                    {
                        FullName = $"{string.Join("/", fwd)}/{filesSplit[1]}",
                        FileType = EFileType.Directory,
                    });
                    break;

                default:
                    files.Add(new FileSystem
                    {
                        FullName = $"{string.Join("/", fwd)}/{line[1]}",
                        Size = int.Parse(filesSplit[0]),
                        FileType = EFileType.File
                    });
                    break;
            }
        }
    }

    public enum EFileType
    {
        Directory,
        File,
    }
}

