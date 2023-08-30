using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoftRapidBus.DB
{
    public class DbContexto
    {
        private readonly SQLiteAsyncConnection cnx;
        // Constructor
        public DbContexto(string ruta)
        {
            cnx = new SQLiteAsyncConnection(ruta);
            // Crear la tabla
            cnx.CreateTableAsync<Terminal>().Wait();
            cnx.CreateTableAsync<Servicio>().Wait();
        }
        //Ingresar reg (datos del un formulario xaml)
        public async Task<int> ingresar(Terminal reg)
        {
            return await cnx.InsertAsync(reg);
        }

        internal async Task<List<Servicio>> GetServicios()
        {
            return await cnx.Table<Servicio>().ToListAsync();
        }


        public async Task<int> eliminar(Terminal reg)
        {
            return await cnx.DeleteAsync(reg);
        }

        internal async Task<int> insertarData(Servicio reg)
        {
            return await cnx.InsertAsync(reg);
        }

        public async Task<List<Terminal>> GetTerminales()
        {
            return await cnx.Table<Terminal>().ToListAsync();
        }

        internal async Task<int> limpiar(Servicio reg)
        {
            return await cnx.DeleteAsync(reg);
        }

        internal async Task<int> modificar(Servicio reg)
        {
            return await cnx.UpdateAsync(reg);
        }
    }
}
