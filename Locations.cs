using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarBusinessSkeleton
{
    public partial class Locations : Form
    {
        public Locations()
        {
            InitializeComponent();

            LocationNames();//gets location names when form is loaded
        }
        public void LocationNames()
        {
            try
            {
                string[] locationNames = new string[4];
                locationNames[0] = File.ReadLines("Location1.csv").ElementAt(0);
                locationNames[1] = File.ReadLines("Location2.csv").ElementAt(0);
                locationNames[2] = File.ReadLines("Location3.csv").ElementAt(0);
                locationNames[3] = File.ReadLines("Location4.csv").ElementAt(0);
                //gets location names of each file by just using readline which is better on processing
                Array.Sort(locationNames);
                for (int i = 0; i < locationNames.Length; i++)
                {
                    locationsList.Items.Add(locationNames[i]); //sorts locations in alphabetical order
                }
            }
            catch(Exception)
            {
                MessageBox.Show("The file is currently in usage or empty.");//catches these errors
            }
        }

        private void selectLocation_Click(object sender, EventArgs e)
        {
            Form myForm = new Vehicles();
            myForm.Show();//opens vehicles form to see list of all vehicles
        }

        private void locationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationData passData = new LocationData(); //gets data from locations to see what location has been chosen
            

            if (locationsList.SelectedIndex == 0)//lisbon has been highlighted
            {
                LocationDataGet(passData.location2);

            }

            if (locationsList.SelectedIndex == 1)//london has been highlighted
            {
                LocationDataGet(passData.location1);

            }

            if (locationsList.SelectedIndex == 2)//tokyo has been highlighted
            {
                LocationDataGet(passData.location3);

            }

            if (locationsList.SelectedIndex == 3)//paris has been highlighted
            {
                LocationDataGet(passData.location4);

            }
        }

        public void LocationDataGet(string[] data)
        { 
            //finds info regarding each location
            string[] tempData = data.Skip(1).ToArray(); //do not want location name displayed
            int vehicleCount = 0;
            int totalVal = 0;
            int vehicleVal = 0;
            string vehicleType = "";

            foreach (string price in tempData)//iterates through each line in location files
            {
                vehicleCount++;

                string[] delimitedLine = price.Split(','); //splits commas so we get into elements for array
                int temp = int.Parse(delimitedLine[4]);
                totalVal += int.Parse(delimitedLine[4]); //looking at price columnn to add up total value

                if (temp > vehicleVal)//compares individual vehicle prices
                {
                    vehicleVal = temp; //saves most expensive vehicle
                    vehicleType = delimitedLine[0]; //finds type of vehicle that is most expensive
                }
            }
            vehiclesInStock.Text = Convert.ToString(vehicleCount); //shows total vehicles again specific to each location
            totalValue.Text = ("£" + Convert.ToString(totalVal)); //shows total value of vehicles
            mostExpensive.Text = ("£" + Convert.ToString(vehicleVal)); //shows most expensive vehicle
            mostExpensiveType.Text = vehicleType; //and type for most expensive vehicle

        }

    }
    public class LocationData
    { //gets enteries from each location
        public string[] location1 = File.ReadAllLines("Location1.csv");//London
        public string[] location2 = File.ReadAllLines("Location2.csv");//Lisbon
        public string[] location3 = File.ReadAllLines("Location3.csv");//Tokyo
        public string[] location4 = File.ReadAllLines("Location4.csv");//Paris
        
    }

}
