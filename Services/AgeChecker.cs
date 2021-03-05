using FirstWeb.Interface;
using FirstWeb.Models;

namespace FirstWeb.Services
{
    public class AgeChecker : IAge
    {
        public string CheckAge (Age model)
        {
            return "Welcome to June's club. hat drink would you like to order? ";
        }
            
    }
}