using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long id);
        void Delete(long id);
        Person Update(Person person);
        List<Person> FindAll();
        bool Exists(long id);
    }
}
