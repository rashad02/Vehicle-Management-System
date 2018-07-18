using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VehicleSystem.Models
{
    class Vehicle
    {
     //   List<double> Speed = new List<double>();
        public string VehicleName { get; set; }
        public string RegNo { get; set; }
        public List<double> Speed =new List<double>();

       
        public void CreateVehicle()
        {
            MessageBox.Show("Vehicle Registered!");
        }
    }
}
