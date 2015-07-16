using System;

namespace NameSplitter
{
    public class NameSplitter : INameSplitter
    {
        private const char SPLIT_CHAR = ' ';

        public NameParts GetNamePartsFromName(string name)
        {
            if (String.IsNullOrEmpty(name)) 
                return new NameParts { FirstName = String.Empty, Surname = String.Empty };

            var nameArray = name.Split(SPLIT_CHAR);
         
            if (nameArray.Length == 1)
                return new NameParts { FirstName = nameArray[0], Surname = String.Empty };
            
            var firstName = String.Empty;
            for (var i = 0; i < nameArray.Length - 1; i++)
            {
                firstName += nameArray[i] + " ";
            }
            
            return new NameParts { FirstName = firstName.Trim(), Surname = nameArray[nameArray.Length - 1] };
        }
    }
}
