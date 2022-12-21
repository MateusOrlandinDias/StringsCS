using System;

namespace StringsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString().Substring(0, 8);

            id = new Guid("c058af95-25b6-4f4e-93e4-74ef94f6424c");
            Console.WriteLine(id);
        }
    }
}
