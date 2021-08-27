namespace TP.Examples
{
    public class DeconstructAdvancedClass
    {
        public DeconstructAdvancedClass(string firstName, string middleName, string lastName)
            => (FirstName, MiddleName, LastName) = (firstName, middleName, lastName);

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public void Deconstruct(out string firstName, out string middleName, out string lastName)
            => (firstName, middleName, lastName) = (FirstName, MiddleName, LastName);
    }
}
