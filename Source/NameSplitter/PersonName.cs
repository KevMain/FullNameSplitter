namespace NameSplitter
{
    public class PersonName
    {
        private readonly NameParts _nameParts;

        public PersonName(INameSplitter nameSplitter, string name)
        {
            this._nameParts = nameSplitter.GetNamePartsFromName(name);
        }

        public string GetFirstName()
        {
            return this._nameParts.FirstName;
        }

        public string GetSurname()
        {
            return this._nameParts.Surname;
        }
    }
}
