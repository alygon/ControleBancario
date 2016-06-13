using ControleBancarioDominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancarioDominio.Repository
{
    public class ClienteRepository
    {

        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Cliente> Clientes
            {
                get { return _context.Clientes; }
            }
            

    }
}
