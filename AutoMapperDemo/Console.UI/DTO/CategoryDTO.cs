using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.UI.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        // public int Value { get; set; }
        public string Name { get; set; }
        public int MainCategory { get; set; }
        public int Order { get; set; }
    }
}
