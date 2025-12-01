
namespace AdventOfCode
{
    public class Day7
	{
        private Stack<string> fwd;
        private List<IFileSystem> files;
        private Dictionary<string, int> sizes;

        public Day7()
        {
            fwd = new Stack<string>();
            files = new List<IFileSystem>();
            sizes = new Dictionary<string, int>();
        }

        public void ReadCommands(string path)
        {
            using (var stream = File.OpenRead(path))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }

                    if (line.StartsWith("$ "))
                    {
                        ProcessCommand(line);
                        continue;
                    }

                    BuildFileSystem(line);
                }
            }

            foreach (var dir in files.Where(f => f.FileType == EFileType.Directory))
            {
                sizes.Add(dir.FullName, files.Where(f => f.FileType == EFileType.File && f.FullName.Contains(dir.FullName))
                    .Select(e => e.Size)
                    .Sum());
            }

            sizes.Add("/", files.Select(f => f.Size).Sum());
        }

        public int FindUnder(string path)
        {
            ReadCommands(path);

            return sizes.Where(f => f.Value <= 100000).Select(f => f.Value).Sum();
        }

        public int FindDelete(string path)
        {
            ReadCommands(path);

            var freeSpace = 70000000 - sizes["/"];
            var potentialDeletes = new Dictionary<string, int>();

            foreach (var size in sizes)
            {
                if (freeSpace + size.Value >= 30000000)
                {
                    potentialDeletes.Add(size.Key, size.Value);
                }
            }

            return potentialDeletes.Select(f => f.Value).Min();
        }

        public void ProcessCommand(string line)
        {
            var split = line.Replace("$ ", "").Split(" ");

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
                        FullName = $"{string.Join("/", fwd.Reverse())}/{filesSplit[1]}",
                        FileType = EFileType.Directory,
                    });
                    break;

                default:
                    files.Add(new FileSystem
                    {
                        FullName = $"{string.Join("/", fwd.Reverse())}/{filesSplit[1]}",
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

