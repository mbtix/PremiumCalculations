using System;

namespace CoreWebApplication.Controllers
{
    public class PremiumVM
    {
        public string FullName { get; set; }

        public DateTime DOB { get; set; }

        public int Age { get; set; }

        public long DeathAssured { get; set; }

        public string Occupation { get; set; }
        public double CalculatedValue { get; set; }

    }

    public enum  EnumOccupationRating
    {
        //Light Manual
        LMl = 1,
        //Professional
        PRF = 2,
        //White Collar
        WCL = 3,
        //Heavy Manual
        HML = 4,
    }
   
}