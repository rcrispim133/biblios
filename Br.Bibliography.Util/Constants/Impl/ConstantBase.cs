using Br.Bibliography.Util.Constants.Interfaces;
using Br.Bibliography.Util.Resources;

namespace Br.Bibliography.Util.Constants.Impl
{
    public class ConstantBase : IConstantBase
    {
        private ConstantBase() { }

        public static IConstantBase Factory() => new ConstantBase();

        public string CREDIT => ResourceBase.CREDIT;

        public string EFFORT => ResourceBase.EFFORT;

        public string LECTURE => ResourceBase.LECTURE;

        public string PRE => ResourceBase.PRE;

        public string TEACHER => ResourceBase.TEACHER;

        public string TYPE => ResourceBase.TYPE;

        public string WORK => ResourceBase.WORK;

        public string AUTHOR => ResourceBase.AUTHOR;

        public string BIBLIO => ResourceBase.BIBLIO;

        public string IMAGE => ResourceBase.IMAGE;

        public string DISCLAIMER => ResourceBase.DISCLAIMER;

        public string EDITION => ResourceBase.EDITION;

        public string LANGUAGE => ResourceBase.LANGUAGE;

        public string PUBLISHER => ResourceBase.PUBLISHER;

        public string TITLE => ResourceBase.TITLE;

        public string URL => ResourceBase.URL;

        public string YEAR => ResourceBase.YEAR;

        public string ROLE => ResourceBase.ROLE;

        public string USER => ResourceBase.USER;

        public string CLAIM => ResourceBase.CLAIM;

        public string CITY => ResourceBase.CITY;

        public string COUNTRY => ResourceBase.COUNTRY;

        public string STATE => ResourceBase.STATE;

        public string DETAIL => ResourceBase.DETAIL;

        public string LINE => ResourceBase.LINE;

        public string SECTION => ResourceBase.SECTION;

        public string COURSE => ResourceBase.COURSE;

        public string CYCLE => ResourceBase.CYCLE;

        public string DURATION => ResourceBase.DURATION;

        public string PERIOD => ResourceBase.PERIOD;

        public string UNIT => ResourceBase.UNIT;
    }
}
