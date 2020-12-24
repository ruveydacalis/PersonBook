using System;
using System.Collections.Generic;
using System.Text;

namespace PersonExe
{
    interface IPersonService
    {
        public void List();

        public void AddPerson(string name, string surname);

        public void UpdatePerson(int id, string name, string surname);

        public void DeletePerson(int id);

    }
}