namespace TP.Examples
{
    public class DeconstructClass
    {
        public DeconstructClass(string firstName, string middleName, string lastName)
            => (FirstName, MiddleName, LastName) = (firstName, middleName, lastName);

        public void Deconstruct(out string firstName,
          out string middleName,
          out string lastName)
        {
            firstName = FirstName;
            middleName = MiddleName;
            lastName = LastName;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
