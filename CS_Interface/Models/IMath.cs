using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface.Models
{
    /// <summary>
    /// INterface Methods Need not to have access-specifier
    ///  All methods of interface are default to 'Public' Access Specifier 
    /// </summary>
    internal interface IMath
    {
        int Add(int x, int y);
        int Sub(int x, int y);
        int Multi(int x, int y);
        int Divide(int x, int y);
    }


    internal interface IMathNew
    {
        int Add(int x, int y);
        int Sub(int x, int y);
        int Multi(int x, int y);
        int Divide(int x, int y);
    }
}
