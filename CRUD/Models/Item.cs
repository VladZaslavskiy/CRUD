using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        [DisplayName("Sell Price")]
        public int SellPrice { get; set; }

    }
}
