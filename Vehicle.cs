using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBusinessSkeleton
{
    public partial class Vehicle : Form
    {
        public string[] addDataCar = new string[11];
        public Vehicle()
        {
            InitializeComponent();

            typeComboBox.Items.Add("Car");
            typeComboBox.Items.Add("Truck");
            typeComboBox.Items.Add("Plane");
            typeComboBox.Items.Add("Helicopter");

            elecWindowsCombo.Items.Add("True");
            elecWindowsCombo.Items.Add("False");

            airWorthyHeliCombo.Items.Add("True");
            airWorthyHeliCombo.Items.Add("False");

            airWorthyPlaneCombo.Items.Add("True");
            airWorthyPlaneCombo.Items.Add("False");
        }

        private void makeTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void modelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { //method is for visual purposes when selecting new type of vehicle to add
            if (typeComboBox.SelectedItem.ToString() == "Car")
            {
                carDetails.Show();
                truckDetails.Hide();
                heliDetails.Hide();
                planeDetails.Hide();

            }
            if (typeComboBox.SelectedItem.ToString() == "Truck")
            {
                truckDetails.Show();
                carDetails.Hide();
                heliDetails.Hide();
                planeDetails.Hide();
            }
            if (typeComboBox.SelectedItem.ToString() == "Helicopter")
            {
                heliDetails.Show();
                carDetails.Hide();
                truckDetails.Hide();
                planeDetails.Hide();
            }
            if (typeComboBox.SelectedItem.ToString() == "Plane")
            {
                planeDetails.Show();
                carDetails.Hide();
                truckDetails.Hide();
                heliDetails.Hide();
            }
        }
        public void addCarDetails()//adds vehicles details to array from users text
        {
            addDataCar[0] = typeComboBox.Text;
            addDataCar[1] = makeTextBox.Text;
            addDataCar[2] = modelTextBox.Text;
            addDataCar[3] = yearTextBox.Text;
            addDataCar[4] = priceTextBox.Text;
            addDataCar[5] = weightTextBox.Text;
            addDataCar[6] = colourTextBox.Text;
            addDataCar[7] = regTextBox.Text;
            addDataCar[8] = numDoorsTextBox.Text;
            addDataCar[9] = engineSizeTextBox.Text;
            addDataCar[10] = elecWindowsCombo.Text;
            addCar(addDataCar);//calls addCar to give data of new vehicle 

        }
        public void addCar(string[] addData)//adds new vehicles data to file
        {
            if (typeComboBox.Text == "Car")
            {

                //converting to CSV line below from https://stackoverflow.com/questions/4756565/convert-array-of-integers-to-comma-separated-string
                String convertCSV = string.Join(",", Array.ConvertAll(addData, x => x.ToString()));
                File.AppendAllText("Location1.csv", Environment.NewLine);
                File.AppendAllText("Location1.csv", convertCSV);
        
            }
            
        }

        private void addVehicle_Click(object sender, EventArgs e)//when add button is clicked will start process 
                                                                //of adding new vehicle
        {
            addCarDetails();
        }
    }
}
