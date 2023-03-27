using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListProjectTest.Dal.Interfaces
{
    public interface IBaseRepository<T>
    {

        //Create new entity in bd by TypeFor
        Task Create(T entity);

        //Get all task in bd
        IQueryable<T> GetAll();

        //Delete entity
        Task Delete(T entity);

        //Update / Edit new entity
        Task<T> Update(T entity);

    }
}
