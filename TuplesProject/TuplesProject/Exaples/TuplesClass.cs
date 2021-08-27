namespace TuplesProject.Exaples
{
    class TuplesClass
    {
        public TuplesClass(string firstName, string middleName, string lastName)
        {
            (FirstName, MiddleName, LastName) = (firstName, middleName, lastName);
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
