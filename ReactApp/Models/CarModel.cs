using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactApp.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public string Description { get; set; }
        public bool Imported { get; set; }
    }
}
