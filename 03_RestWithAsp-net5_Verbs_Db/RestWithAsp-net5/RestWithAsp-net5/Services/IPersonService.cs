﻿using System.Collections.Generic;
using RestWithAsp_net5.model;


namespace RestWithAsp_net5.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        Person Update(Person person);
        List<Person> FindAll();
        void Delete(long id);
    }
}
