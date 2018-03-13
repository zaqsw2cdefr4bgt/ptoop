using Oop3.Contracts;
using Oop6.WeirdContracts;

namespace Oop6.Contracts.WeirdCreatures
{
    public class WeirdCreatureAdapter : Person
    {
        private readonly IWeirdCreature _weirdCreature;

        public WeirdCreatureAdapter(string name) : base(name)
        {
            _weirdCreature = new Axolotl();
        }

        public WeirdCreatureAdapter()
        {
            _weirdCreature = new Axolotl();
        }

        public override string FullName
        {
            get
            {
                if (_weirdCreature == null)
                {
                    return "WeirdCreatureAdapter for unknown creature!";
                }

                return _weirdCreature.GetType().Name + " " + _weirdCreature.WeirdName;
            }
        }

        public override string Name
        {
            get
            {
                return _weirdCreature?.WeirdName;
            }
            set
            {
                if (_weirdCreature != null)
                {
                    _weirdCreature.WeirdName = value;
                }
            }
        }
    }
}
