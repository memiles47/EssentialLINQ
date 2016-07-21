using System.Linq;

namespace Methods
{
    public static class SpecialString
    {
        //Regular Method
        //public static bool IsState(string source)
        
        //Extention Method
        public static bool IsState(this string source)
        {
            string[] stateCodes =
            {
                "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC",
                "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY",
                "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT",
                "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH",
                "OK", "OR", "PA", "RI", "SC", "DS", "TN", "TX", "UT",
                "VT", "VA", "WA", "WV", "WI", "WY"
            };

            if (source == null)
                return false;

            source = source.ToUpper();

            //Converted foreach loop into LINQ Exression
            return stateCodes.Any(item => source == item);

            //foreach (var item in stateCodes)
            //{
            //    if (source == item)
            //    {
            //        return true;
            //    }
            //}
        }
    }
}