using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsAppl.Interfaces
{
    interface ILoginView
    {
        string Username { get; }
        string Password { get; }
        event Action Login;      
        void ShowError(string errorMessage);
    }
}
