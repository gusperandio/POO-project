using POO.Context.Enums;
using POO.SharedContext;
namespace POO.Context
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public string? Title { get; set; }

        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}