using EscuelaSystemData.Interface;
using EscuelaSystemModules;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaSystemData.Repositories
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductoRepository(ApplicationDbContext db): base(db)
        {
        }
    }
}
