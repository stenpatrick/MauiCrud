using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCrud.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrememt]
        public int Id { get; set; }

    }
}
