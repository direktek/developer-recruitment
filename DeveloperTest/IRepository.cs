using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeveloperTest.Models;

namespace DeveloperTest
{
    public interface IRepository
    {
        IEnumerable<Invoice> All();
    }
}
