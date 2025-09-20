
using LINQTut05.Shared;

namespace Data_Partitioning.Chunck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = Repository.LoadEmployees();

            var x = emp.Chunk(10).ToList();

            for (int i = 0; i < x.Count; i++)
            {
                x[i].Print($"Chunk {i+1}");
            }
        }
    }
}
