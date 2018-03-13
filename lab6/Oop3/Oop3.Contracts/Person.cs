namespace Oop3.Contracts
{
    public abstract class Person
    {
        public virtual string Name { get; set; }
        public virtual string FullName => GetType().Name + " " + Name;

        protected Person(string name)
        {
            // ReSharper disable once VirtualMemberCallInConstructor
            Name = name;
        }

        protected Person()
        {
        }
    }
}
