﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.WEB.Repositories
{
    interface IRepository<T> where T : class
    {
        void Add(T model);
        void Update(T model);
        void Delete(int id);
        void Save();
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}
