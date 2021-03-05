using FirstWeb.Interface;
using FirstWeb.Models;

namespace FirstWeb.Services
{
    public class ConvertNaira : IConvertToDollars
    {
        public int Convertnaira(CalculateDollar model)
        {
            return int.Parse(model.Naira) / 432;
        }
    }
}