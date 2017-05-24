using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Concrete
{
    public class OracleReestrRepository : IReestrRepository
    {
        public IEnumerable<Reestr> Reestrs
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
