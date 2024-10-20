using Pr0221.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr0221.Data
{
    
    public class DataClientes
    {

        public List<Modelo.Cliente> ListarClientes()
        {
            using (var context = new Modelo.AppContext())
            {
                return context.Clientes.ToList();
            }
        }

        public void InsertarCliente(Modelo.Cliente cliente)
        {
            using (var context = new Modelo.AppContext())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }

        public void ModificarCliente(int clienteid, Modelo.Cliente cliente)
        {
            using (var context = new Modelo.AppContext()) 
            {
                var cli = context.Clientes.FirstOrDefault(x => x.ClienteID == clienteid);
                if (cli != null) 
                {
                    context.Entry(cli).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.Entry(cli).CurrentValues.SetValues(cliente);
                    context.SaveChanges();
                }
                
            }
        }


        public void BorrarCliente(int clienteid)
        {
            using (var context = new Modelo.AppContext())
            {
                var cli = context.Clientes.FirstOrDefault(x => x.ClienteID == clienteid);
                if (cli != null)
                {
                    context.Entry(cli).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;   
                    context.SaveChanges();
                }
            }
        }

        private static DataClientes instance;
        public static DataClientes GetInstance() 
        {
            if (instance == null) 
            { 
                instance = new DataClientes();
            }
            return instance;
        }

    }
}
