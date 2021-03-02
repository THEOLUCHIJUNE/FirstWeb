using FirstWeb.Interface;
using FirstWeb.Models;

namespace FirstWeb.Services
{
    public class CheckLegalAge : ICheckLegalAge
    {
        public string CheckLegalAgeForPass(TellAge model)
        {
            return "Welcome to June's club. hat drink would you like to order? ";
        }
            
    }
}