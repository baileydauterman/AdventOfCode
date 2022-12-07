namespace AdventOfCode.Test
{
    public interface ITest
    {
        public void Test();
        public void Prod();

        public string TestPath { get; set; }

        public string ProdPath { get; set; }


    }
}
