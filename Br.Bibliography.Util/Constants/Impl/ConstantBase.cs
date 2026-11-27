using Br.Bibliography.Util.Constants.Interfaces;

namespace Br.Bibliography.Util.Constants.Impl
{
    public class ConstantBase : IConstantBase
    {
        #region Constructor

        private ConstantBase() { }

        #endregion

        #region Factory

        public static IConstantBase Factory() => new ConstantBase();

        #endregion

        #region Constants

        public string CREDIT => "credit";

        public string EFFORT => "effort";

        public string LECTURE => "lecture";

        public string PRE => "pre";

        public string TEACHER => "teacher";

        public string TYPE => "typre";

        public string WORK => "work";

        public string AUTHOR => "author";

        public string BIBLIO => "biblio";

        public string IMAGE => "image";

        public string DISCLAIMER => "disclaimer";

        public string EDITION => "edition";

        public string LANGUAGE => "language";

        public string PUBLISHER => "publisher";

        public string TITLE => "title";

        public string URL => "url";

        public string YEAR => "year";

        public string ROLE => "role";

        public string USER => "user";

        public string CLAIM => "claim";

        public string CITY => "city";

        public string COUNTRY => "country";

        public string STATE => "state";

        public string DETAIL => "detail";

        public string LINE => "line";

        public string SECTION => "section";

        public string COURSE => "course";

        public string CYCLE => "cycle";

        public string DURATION => "duration";

        public string PERIOD => "period";

        public string UNIT => "unit";

        #endregion
    }
}
