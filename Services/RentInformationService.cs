using System.Reflection.Emit;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using FirstWeb.Models;
using FirstWeb.Interface;
using FirstWeb.DatabaseContext;

namespace FirstWeb.Services
{
    public class RentInformationService : IRentInformationService
    {
        private readonly ApplicationDbContext _context;
        public RentInformationService(
            ApplicationDbContext context
        )

        {
            _context = context;
        }

        public List<Person> GetAllPersons()
        {
            return _context.Persons.ToList();
        }
        public Person GetOnePerson(string id)
        {
            return _context.Persons.FirstOrDefault(PID => PID.Id == id);
        }
        public Person AddPerson(Person model)
        {
            var person = new Person
            {
                Id = Guid.NewGuid().ToString(),
                FullName = model.FullName,
                Age = model.Age,
                Amount = model.Amount,
                RoomNumber = model.RoomNumber
            };

            _context.Persons.Add(person);
            _context.SaveChanges();

            return person;
                
        }

        public Person UpdatePerson(Person model)
        {
            var person = GetOnePerson(model.Id);
            

            if (person != null) {
                person.FullName = model.FullName;
                person.Age = model.Age;
                person.Amount = model.Amount;
                person.RoomNumber = model.RoomNumber;
            };

            _context.Persons.Update(person);
            _context.SaveChanges();

            return person;
                
        }

        public Person DeletePerson(Person model)
        {
            var person = GetOnePerson(model.Id);
            
            if (person != null) {
                person.FullName = model.FullName;
                person.Age = model.Age;
                person.Amount = model.Amount;
                person.RoomNumber = model.RoomNumber;
            };

            _context.Persons.Remove(person);
            _context.SaveChanges();

            return person;
                
        }
    }
}