using CoreWebApplication.Controllers;
using CoreWebApplication.Model;
using System.Collections.Generic;

namespace CoreWebApplication.Services
{
    public interface IPremiumBAL
    {
        public double CalculatePremium(PremiumVM premium);
    }
}