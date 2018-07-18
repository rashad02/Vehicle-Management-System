using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleSystem.Models;

namespace VehicleSystem
{
    public partial class VehicleSystemUi : Form
    {
        Vehicle vehicle=new Vehicle();
        List<Vehicle> VehicleList=new List<Vehicle>();
        
        public VehicleSystemUi()
        {
            InitializeComponent();
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            vehicle.VehicleName = vehicleNameTextBox.Text;
            vehicle.RegNo = regNoTextBox.Text;
            vehicle.CreateVehicle();
            VehicleList.Add(vehicle);
            vehicleNameLabel.Text = vehicle.VehicleName;
            vehicleNameTextBox.Text=String.Empty;
            regNoTextBox.Text=String.Empty;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (vehicle == null) return;
            vehicle.Speed.Add(Convert.ToDouble(speedTextBox.Text));
            vehicle.Speed.Sort();

            speedTextBox.Text=String.Empty;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            maxSpeedTextBox.Text = vehicle.Speed[vehicle.Speed.Count - 1].ToString();
            minSpeedTextBox.Text = vehicle.Speed[0].ToString();
            averageSpeedTextBox.Text = vehicle.Speed.Average().ToString();
        }

        private void showListButton_Click(object sender, EventArgs e)
        {
            vehicleListView.Clear();
            ListViewItem item=new ListViewItem();
            foreach (var veicle in VehicleList)
            {
                item.Text = veicle.VehicleName;
                item.SubItems.Add(veicle.RegNo);
                item.SubItems.Add(veicle.Speed.Average().ToString());

                vehicleListView.Items.Add(item);
            }
            
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            foreach (var vehicle in VehicleList)
            {
                if ((vehicle.VehicleName).Contains(searchTextBox.Text))
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = vehicle.VehicleName;
                    item.SubItems.Add(vehicle.RegNo);
                    item.SubItems.Add(averageSpeed.ToString());

                    vehicleListView.Items.Add(item);
                }
            }
        }
      
    }
}
