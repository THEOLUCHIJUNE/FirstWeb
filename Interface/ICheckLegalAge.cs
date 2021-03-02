using FirstWeb.Models;

namespace FirstWeb.Interface
{
    public interface ICheckLegalAge
    {
        string CheckLegalAgeForPass(TellAge model);
    }
}