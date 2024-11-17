using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Domain.Entities.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty; // Código único del producto
        public string Description {  get; set; } = string.Empty;
        public decimal Precio {  get; set; } = 0;
        public decimal Costo {  get; set; } = 0;
        public int Cantidad {  get; set; } = 0;
        public string Category {  get; set; } = string.Empty;
    }
}
