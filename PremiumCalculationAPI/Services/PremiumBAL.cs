using CoreWebApplication.Controllers;
using CoreWebApplication.Model;

namespace CoreWebApplication.Services
{
    public class PremiumBAL : IPremiumBAL
    {
        /// <summary>
        /// Assumption : These consts can be stored in database like a system constants - Master table
        /// </summary>
        private const double HMRactingFactor = 1.75;
        private const double LMlRactingFactor = 1.50;
        private const double PRFRactingFactor = 1.0;
        private const double WCLRactingFactor = 1.25;
        public PremiumBAL()
        {
        }
        /// <summary>
        /// Parameters: Age, DeathAssured, Occupation
        /// Set Rating factor based on occupation
        /// Formula to calcualte Premium: (Death Cover amount *Occupation Rating Factor *Age) / 1000 * 12
        /// RatingFactor : Professional - 1.0 / White Collar - 1.25 / Light Manual - 1.50 / Heavy Manual- 1.75
        /// </summary>
        /// <param name="pm"></param>
        /// <returns></returns>
        public double CalculatePremium(PremiumVM pm)
        {
            double deathPremium = 0.0;

           //validate age,death assured and occupation
           if(pm.Age == 0 || pm.DeathAssured == 0 || string.IsNullOrEmpty(pm.Occupation))
            {
                return 0;
            }

            // set rating factor based on Occupation
            double ratingFactor = 0.0;
            if(pm.Occupation == EnumOccupationRating.HML.ToString())
            {
                ratingFactor = HMRactingFactor;
            }
            else if (pm.Occupation == EnumOccupationRating.LMl.ToString())
            {
                ratingFactor = LMlRactingFactor;
            }
            else if (pm.Occupation == EnumOccupationRating.PRF.ToString())
            {
                ratingFactor = PRFRactingFactor;
            }
            else if (pm.Occupation == EnumOccupationRating.WCL.ToString())
            {
                ratingFactor = WCLRactingFactor;
            }

            // Calcuation of premium
            deathPremium = (pm.DeathAssured * ratingFactor * pm.Age) / 1000 * 12;
            return deathPremium;
        }

    }
}
