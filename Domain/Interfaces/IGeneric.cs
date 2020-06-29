using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T : class
    {
        Task Add(T Objet);
        Task Update(T Objet);
        Task Delete(T Objet);
        Task<T> GetEntityById(int Id);
        Task<List<T>> List();
    }
}
