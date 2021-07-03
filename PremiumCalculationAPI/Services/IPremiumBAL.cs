using CoreWebApplication.Controllers;
using System.Collections.Generic;

namespace CoreWebApplication.Services
{
    public interface IPremiumBAL
    {
        public double CalculatePremium(PremiumVM premium);
    }
}