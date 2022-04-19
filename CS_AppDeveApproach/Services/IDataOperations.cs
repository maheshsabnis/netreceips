using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AppDeveApproach.Services
{
    /// <summary>
    /// Interface That will have Method definitions for Read/Write Operations
    /// This interface Should be used for performing Read/Write Operations
    /// for any of the Model class e.g. Department and Employee
    /// TModel will be a Model class (Department, Employee, etc)
    /// The 'in' represents an 'input parameter' to a method that will be passed to a method which will be declared into the Generic interface
    /// TId will be an input parameter
    /// Thew TModel will always be a class-type
    /// </summary>
    internal interface IDataOperations<TModel,in TId> where TModel : class
    {
        /// <summary>
        /// Since, IEnumerable is implemented by all collection classes 
        /// instead of using a specific collection to store output, use the interface
        /// </summary>
        /// <returns></returns>
        IEnumerable<TModel> GetAll();
        TModel GetById(TId id);
        TModel Create(TModel record);
        TModel Update(TId id, TModel record);
        TModel Delete(TId id);
    }
}
