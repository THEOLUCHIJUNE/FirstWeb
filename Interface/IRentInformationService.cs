using System.Collections.Generic;
using FirstWeb.Models;

namespace FirstWeb.Interface
{
    public interface IRentInformationService
    {
        List<Person> GetAllPersons();
        Person GetOnePerson(string id);
        Person AddPerson(Person model);
        Person UpdatePerson(Person model);
        Person DeletePerson(Person model);
    }
}