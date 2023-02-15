using ConstructPC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Interfaces
{
    public interface IAllMotherboards
    {
        IEnumerable<Motherboard> Motherboards { get; }
        IEnumerable<Motherboard> AMDmotherboards { get; }
        IEnumerable<Motherboard> INTELmotherboards { get; }
        IEnumerable<Motherboard> getFavMotherboard { get; }
        Motherboard getobjectMotherboard(int Motherid);
    }
}
