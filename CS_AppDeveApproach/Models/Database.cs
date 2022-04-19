using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AppDeveApproach.Models
{
    /// <summary>
    /// Define a Generic Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class StackDatabase<T>
    {
        // define a stack

        Stack<T> stk = null;
        


        public StackDatabase()
        {
            stk = new Stack<T>();
        }

        /// <summary>
        /// Generic Method with generic input paramerter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="record"></param>
        public void AddRecord(T record)
        {
            stk.Push(record);
        }
        /// <summary>
        /// Generic Method with Generic Return Type 
        /// </summary>
        /// <returns></returns>
        public T RemoveRecord()
        { 
            return stk.Pop();
        }

        public Stack<T> GetRecords()
        {
            return stk;
        }

        public T GetTopRecord()
        { 
            return stk.Peek();
        }

        
    }
}
