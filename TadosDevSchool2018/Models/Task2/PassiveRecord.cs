using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TadosDevSchool2018.Models.Task2
{
    public abstract class PassiveRecord<T>
    {
        protected abstract string Table { get; }

        public static T[] All()
        {
            throw new NotImplementedException();
        }

        public static T Create()
        {
            throw new NotImplementedException();
        }

        public static bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public static T Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }

}
