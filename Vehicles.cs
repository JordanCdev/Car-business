using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarBusinessSkeleton
{
    public partial class Vehicles : Form
    {
        public string[] allData { get; private set; }

        class VehicleInfo
        {
            public string tradeLocation;
            public string vechileType;
            public string model;
            public int year;
            public int price;
            public int weight;
            public string colour;
            public string reg;
        }
        class Car : VehicleInfo
        {
            public int noOfDoors;
            public double engineSize;
            public bool electricWindows;


        }
        class Truck : VehicleInfo
        {
            public int weightLimit;
            public int noOfWheels;
            public int length;
        }
        class Helicopter : VehicleInfo
        {
            public bool airworthy;
            public int hoursUsed;
            public int altitudeLimit;
        }
        class Plane : Helicopter    //wants to take vehicle and helicopters
        {
            public int seats;
            public string engines;
        }

        public Vehicles()
        {
            InitializeComponent();
            LocationData passData = new LocationData();
            //vehiclesListBox
            

            IEnumerable<string> concatFiles = passData.location1.Skip(1)
                                             .Concat(passData.location2.Skip(1))
                                             .Concat(passData.location3.Skip(1))
                                             .Concat(passData.location4.Skip(1));
            //concatinates all data to be displayed in the list box

            allData = concatFiles.Cast<string>().ToArray(); //puts all values together into single array
      

            for (int i = 0; i < allData.Length; i++)
            {
                vehiclesListBox.Items.Add(allData[i]); //adds all data from the array
            }

        }

        private void add_Click(object sender, EventArgs e)
        {
            Form myform = new Vehicle();
            myform.Show(); //shows the form for adding and modifying vehicles

        }

        private void modify_Click(object sender, EventArgs e)
        {
            Form myform = new Vehicle();
            myform.Show(); //shows the form for adding modifying vehicles
        }
        private void remove_Click(object sender, EventArgs e)
        {
            LocationData removeData = new LocationData();
            string tempFileLocation = Path.GetTempFileName(); //makes temporary file for rewriting purposes
            

            if(removeData.location1.Contains(vehiclesListBox.SelectedItem.ToString()))//compares if selected item is found in location1
            {
                using (var sr = new StreamReader("Location1.csv"))   //Solution from https://stackoverflow.com/questions/668907/how-to-delete-a-line-from-a-text-file-in-c written by Markus Olsson
                using (var sw = new StreamWriter(tempFileLocation))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null) //checks if the line in file is empty, when it is then thats end of file entries
                    {
                        if (line != vehiclesListBox.SelectedItem.ToString()) //writes all the non chosen items that arent needed for deletion
                            sw.WriteLine(line);
                    }
                    
                }
                File.Delete("Location1.csv"); //deletes old file
                File.Move(tempFileLocation, "Location1.csv"); //saves edited file to location1


            }
            if(removeData.location2.Contains(vehiclesListBox.SelectedItem.ToString()))//compares if selected item is found in location2
            {
                
                using (var sr = new StreamReader("Location2.csv")) //Solution from https://stackoverflow.com/questions/668907/how-to-delete-a-line-from-a-text-file-in-c written by Markus Olsson
                using (var sw = new StreamWriter(tempFileLocation))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null) //checks if the line in file is empty, when it is then thats end of file entries
                    {
                        if (line != vehiclesListBox.SelectedItem.ToString())//writes all the non chosen items that arent needed for deletion
                            sw.WriteLine(line);
                    }
                   
                }
                File.Delete("Location2.csv"); //deletes old file
                File.Move(tempFileLocation, "Location2.csv"); //saves edited file to location2
            }
            if(removeData.location3.Contains(vehiclesListBox.SelectedItem.ToString()))//compares if selected item is found in location3
            {
                using (var sr = new StreamReader("Location3.csv")) //Solution from https://stackoverflow.com/questions/668907/how-to-delete-a-line-from-a-text-file-in-c written by Markus Olsson
                using (var sw = new StreamWriter(tempFileLocation))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)//checks if the line in file is empty, when it is then thats end of file entries
                    {
                        if (line != vehiclesListBox.SelectedItem.ToString())//writes all the non chosen items that arent needed for deletion
                            sw.WriteLine(line);
                    }
                    
                }
                File.Delete("Location3.csv"); //deletes old file
                File.Move(tempFileLocation, "Location3.csv"); //saves edited file to location3

            }
            if(removeData.location4.Contains(vehiclesListBox.SelectedItem.ToString()))//compares if selected item is found in location1
            {
                using (var sr = new StreamReader("Location4.csv")) //Solution from https://stackoverflow.com/questions/668907/how-to-delete-a-line-from-a-text-file-in-c written by Markus Olsson
                using (var sw = new StreamWriter(tempFileLocation))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)//checks if the line in file is empty, when it is then thats end of file entries
                    {
                        if (line != vehiclesListBox.SelectedItem.ToString())//writes all the non chosen items that arent needed for deletion
                            sw.WriteLine(line);
                    }
                    
                }
                File.Delete("Location4.csv"); //deletes old file
                File.Move(tempFileLocation, "Location4.csv"); //saves edited file to location4
            }

            vehiclesListBox.Items.Remove(vehiclesListBox.SelectedItem);//removes item
        }

      
    }
}
