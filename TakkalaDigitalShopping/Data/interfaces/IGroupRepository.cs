using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakkalaDigitalShopping.Data.Models;

namespace TakkalaDigitalShopping.Data.interfaces
{
    public interface IGroupRepository
    {
        IEnumerable<Group> Groups { get; }

    }
}
