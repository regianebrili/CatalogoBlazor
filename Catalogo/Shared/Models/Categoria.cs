using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Shared.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [MaxLength(100)]
        public string Name { get; set;}

        [MaxLength(200)]
        public string Descricao { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
