using System;

namespace FullNameSplitter
{
    public class PersonName
    {
        private readonly NameParts _nameParts;

        public PersonName(string name)
        {
            this._nameParts = new NameSplitter().GetNamePartsFromName(name);
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
