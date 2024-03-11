namespace PP2
{
    public class University : Organiztion
    {
        protected List<Faculty> faculties;

        public University() : base()
        {
            faculties = new List<Faculty>();
        }
        public University(University university)
        {
            faculties = university.faculties;
            name = university.name; 
            shortName = university.shortName;
            address = university.address;
            timeStamp = university.timeStamp;

        }
        public University(string name , string shortName, string address) : base(name,shortName,address)
        {
        }
        public int addFaculty(Faculty fac)
        {
            faculties.Add(fac);
            return 0;
        }
        public bool delFaculty(int index)
        {
            faculties.RemoveAt(index);
            return true;
        }
        public bool updFaculty(Faculty fac)
        {
            faculties[0] = fac;
            return true;
        }
        private bool verFaculties(int index)
        {
            if (faculties[index] == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Faculty> GetFaculties()
        {
            return faculties;
        }


    }
}
