using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IRepository<T> where T : class
    {
        int Add(T obj);
        void Remove(T obj);
        void Update(T obj, string cond);

        List<T> GetList(string id);
        List<T> GetAll();
        T Get(string id);
    }
}

