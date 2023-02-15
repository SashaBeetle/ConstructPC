using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Mocks
{
    public class MockCase : IAllCases
    {
        public IEnumerable<CaseBox> Cases
        {
            get
            {
                return new List<CaseBox> {
                    new CaseBox{ formfactor = "ATX", name="Deepcool CK", img="/img/Cases/Case_DeepCoolCK500.jpg", fan_s = 4},
                    new CaseBox{ formfactor = "ATX", name="MPG SEKIRA", img="/img/Cases/Case_msiATX.jpg", fan_s = 6},
                    new CaseBox{ formfactor = "ATX", name="AeroCool Cronus", img="/img/Cases/Case_AerocoolATX.jpg", fan_s = 6},
                    new CaseBox{ formfactor = "ATX", name="ASUS TUF Gaming", img="/img/Cases/Case_AsusATX.jpg", fan_s = 7},
                    new CaseBox{ formfactor = "Micro-ATX", name="2E Basis", img="/img/Cases/2EBasisMiniATX.jpg", fan_s = 2},
                    new CaseBox{ formfactor = "Micro-ATX", name="Be quiet! Pure Base", img="/img/Cases/BeQueitMiniATX.jpg", fan_s = 3}
                };
            }
        }


        public CaseBox getobjectCase(int Caseid)
        {
            throw new NotImplementedException();
        }
    }
}
