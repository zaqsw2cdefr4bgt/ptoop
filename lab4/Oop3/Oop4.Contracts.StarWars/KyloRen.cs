using Oop3.Contracts;

namespace Oop4.Contracts.StarWars
{
    public class KyloRen : Person
    {
        public KyloRen(string name) : base(name)
        {
        }

        public KyloRen() : base("Ben Solo")
        {
        }
    }
}