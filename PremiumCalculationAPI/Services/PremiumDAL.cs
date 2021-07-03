using CoreWebApplication.Data;

namespace CoreWebApplication.Services
{
    public class PremiumDAL : IPremiumDAL
    {
        readonly PremiumContext _pm;

        public PremiumDAL(PremiumContext premiumContext)
        {
            _pm = premiumContext;
        }
        public bool GetPremiumRates()
        {
            return true;
        }
    }
}
