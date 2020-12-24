using NGuard;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonExe
{
    class PersonService : IPersonService
    {
        private readonly List<Person> _person;
        public PersonService(List<Person> person)
        {
            _person = person;

        }
        public void AddPerson(string name, string surname)
        {
            if (name.Equals("") ||surname.Equals(""))
            {
                throw new Exception("Name or Surname can't be empty");
            }

            if (_person.Count > 0)
            {
                var lastIndex = _person[_person.Count - 1];

                _person.Add(new Person
                {
                    Id = Utils.GenerateId(lastIndex.Id),
                    Name = name,
                    Surname = surname
                });
            }
            else {
                _person.Add(new Person
                {
                    Id = 1,
                    Name = name,
                    Surname = surname
                });
            }
        }

        public void DeletePerson(int id)
        {
            var idToRemove = _person.Find(p => p.Id == id);
             _person.Remove(idToRemove);
        }

        public void List()
        {
            if (_person.Count == 0)
            {
                Console.WriteLine(" Empty List ");
            }
            foreach (var person in _person)
            {
                Console.WriteLine($"Id: {person.Id} Name:{person.Name} Surname:{person.Surname}");
            }
        }

        public void  UpdatePerson(int id, string name, string surname)
        {
            var updatedPerson = _person.Find(p => p.Id == id);

            if (name == "")
            {
                name = updatedPerson.Name;
            }

            if (surname == "")
            {
                surname = updatedPerson.Surname;
            }

            updatedPerson.Name = name;
            updatedPerson.Surname = surname;
        }
    }
}