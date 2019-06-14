namespace CarBusinessSkeleton
{
    partial class Vehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Make = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Colour = new System.Windows.Forms.Label();
            this.colourTextBox = new System.Windows.Forms.TextBox();
            this.Registration = new System.Windows.Forms.Label();
            this.regTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfDoors = new System.Windows.Forms.Label();
            this.numDoorsTextBox = new System.Windows.Forms.TextBox();
            this.EngineSize = new System.Windows.Forms.Label();
            this.engineSizeTextBox = new System.Windows.Forms.TextBox();
            this.ElectricWindows = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.AltitudeLimitPlane = new System.Windows.Forms.Label();
            this.alLimPlaneTextBox = new System.Windows.Forms.TextBox();
            this.hoursUsedPlane = new System.Windows.Forms.Label();
            this.hoursUsedPlanTextBox = new System.Windows.Forms.TextBox();
            this.AirworthyPlane = new System.Windows.Forms.Label();
            this.AltitudeLimitHeli = new System.Windows.Forms.Label();
            this.altitudeLimHeliTextBox = new System.Windows.Forms.TextBox();
            this.HoursUsedHeli = new System.Windows.Forms.Label();
            this.hoursUsedHeliTextBox = new System.Windows.Forms.TextBox();
            this.AirworthyHeli = new System.Windows.Forms.Label();
            this.Engines = new System.Windows.Forms.Label();
            this.enginesTextBox = new System.Windows.Forms.TextBox();
            this.Seats = new System.Windows.Forms.Label();
            this.seatsTextBox = new System.Windows.Forms.TextBox();
            this.elecWindowsCombo = new System.Windows.Forms.ComboBox();
            this.carDetails = new System.Windows.Forms.GroupBox();
            this.truckDetails = new System.Windows.Forms.GroupBox();
            this.airWorthyHeliCombo = new System.Windows.Forms.ComboBox();
            this.airWorthyPlaneCombo = new System.Windows.Forms.ComboBox();
            this.heliDetails = new System.Windows.Forms.GroupBox();
            this.planeDetails = new System.Windows.Forms.GroupBox();
            this.addVehicle = new System.Windows.Forms.Button();
            this.carDetails.SuspendLayout();
            this.truckDetails.SuspendLayout();
            this.heliDetails.SuspendLayout();
            this.planeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // Make
            // 
            this.Make.AutoSize = true;
            this.Make.Location = new System.Drawing.Point(27, 80);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(34, 13);
            this.Make.TabIndex = 0;
            this.Make.Text = "Make";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(26, 132);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 1;
            this.Model.Text = "Model";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(30, 30);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 2;
            this.Type.Text = "Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(29, 46);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(110, 21);
            this.typeComboBox.TabIndex = 3;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(29, 148);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(108, 20);
            this.modelTextBox.TabIndex = 4;
            this.modelTextBox.TextChanged += new System.EventHandler(this.modelTextBox_TextChanged);
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(29, 96);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(108, 20);
            this.makeTextBox.TabIndex = 5;
            this.makeTextBox.TextChanged += new System.EventHandler(this.makeTextBox2_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(30, 197);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(108, 20);
            this.yearTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(29, 247);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(108, 20);
            this.priceTextBox.TabIndex = 7;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(29, 298);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(108, 20);
            this.weightTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(28, 231);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 10;
            this.Price.Text = "Price";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(28, 282);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(41, 13);
            this.Weight.TabIndex = 11;
            this.Weight.Text = "Weight";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(28, 181);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 12;
            this.Year.Text = "Year";
            // 
            // Colour
            // 
            this.Colour.AutoSize = true;
            this.Colour.Location = new System.Drawing.Point(28, 332);
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(37, 13);
            this.Colour.TabIndex = 14;
            this.Colour.Text = "Colour";
            // 
            // colourTextBox
            // 
            this.colourTextBox.Location = new System.Drawing.Point(29, 348);
            this.colourTextBox.Name = "colourTextBox";
            this.colourTextBox.Size = new System.Drawing.Size(108, 20);
            this.colourTextBox.TabIndex = 13;
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Location = new System.Drawing.Point(28, 383);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(63, 13);
            this.Registration.TabIndex = 16;
            this.Registration.Text = "Registration";
            // 
            // regTextBox
            // 
            this.regTextBox.Location = new System.Drawing.Point(29, 399);
            this.regTextBox.Name = "regTextBox";
            this.regTextBox.Size = new System.Drawing.Size(108, 20);
            this.regTextBox.TabIndex = 15;
            // 
            // NumberOfDoors
            // 
            this.NumberOfDoors.AutoSize = true;
            this.NumberOfDoors.Location = new System.Drawing.Point(6, 20);
            this.NumberOfDoors.Name = "NumberOfDoors";
            this.NumberOfDoors.Size = new System.Drawing.Size(85, 13);
            this.NumberOfDoors.TabIndex = 18;
            this.NumberOfDoors.Text = "Number of doors";
            // 
            // numDoorsTextBox
            // 
            this.numDoorsTextBox.Location = new System.Drawing.Point(7, 36);
            this.numDoorsTextBox.Name = "numDoorsTextBox";
            this.numDoorsTextBox.Size = new System.Drawing.Size(108, 20);
            this.numDoorsTextBox.TabIndex = 17;
            // 
            // EngineSize
            // 
            this.EngineSize.AutoSize = true;
            this.EngineSize.Location = new System.Drawing.Point(6, 72);
            this.EngineSize.Name = "EngineSize";
            this.EngineSize.Size = new System.Drawing.Size(61, 13);
            this.EngineSize.TabIndex = 20;
            this.EngineSize.Text = "Engine size";
            // 
            // engineSizeTextBox
            // 
            this.engineSizeTextBox.Location = new System.Drawing.Point(7, 88);
            this.engineSizeTextBox.Name = "engineSizeTextBox";
            this.engineSizeTextBox.Size = new System.Drawing.Size(108, 20);
            this.engineSizeTextBox.TabIndex = 19;
            // 
            // ElectricWindows
            // 
            this.ElectricWindows.AutoSize = true;
            this.ElectricWindows.Location = new System.Drawing.Point(6, 121);
            this.ElectricWindows.Name = "ElectricWindows";
            this.ElectricWindows.Size = new System.Drawing.Size(86, 13);
            this.ElectricWindows.TabIndex = 22;
            this.ElectricWindows.Text = "Electric windows";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Length";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(5, 133);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(108, 20);
            this.textBox9.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Number of wheels";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(5, 84);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(108, 20);
            this.textBox10.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Weight limit";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(5, 32);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(108, 20);
            this.textBox11.TabIndex = 23;
            // 
            // AltitudeLimitPlane
            // 
            this.AltitudeLimitPlane.AutoSize = true;
            this.AltitudeLimitPlane.Location = new System.Drawing.Point(5, 123);
            this.AltitudeLimitPlane.Name = "AltitudeLimitPlane";
            this.AltitudeLimitPlane.Size = new System.Drawing.Size(62, 13);
            this.AltitudeLimitPlane.TabIndex = 34;
            this.AltitudeLimitPlane.Text = "Altitude limit";
            // 
            // alLimPlaneTextBox
            // 
            this.alLimPlaneTextBox.Location = new System.Drawing.Point(6, 139);
            this.alLimPlaneTextBox.Name = "alLimPlaneTextBox";
            this.alLimPlaneTextBox.Size = new System.Drawing.Size(108, 20);
            this.alLimPlaneTextBox.TabIndex = 33;
            // 
            // hoursUsedPlane
            // 
            this.hoursUsedPlane.AutoSize = true;
            this.hoursUsedPlane.Location = new System.Drawing.Point(5, 74);
            this.hoursUsedPlane.Name = "hoursUsedPlane";
            this.hoursUsedPlane.Size = new System.Drawing.Size(61, 13);
            this.hoursUsedPlane.TabIndex = 32;
            this.hoursUsedPlane.Text = "Hours used";
            // 
            // hoursUsedPlanTextBox
            // 
            this.hoursUsedPlanTextBox.Location = new System.Drawing.Point(6, 90);
            this.hoursUsedPlanTextBox.Name = "hoursUsedPlanTextBox";
            this.hoursUsedPlanTextBox.Size = new System.Drawing.Size(108, 20);
            this.hoursUsedPlanTextBox.TabIndex = 31;
            // 
            // AirworthyPlane
            // 
            this.AirworthyPlane.AutoSize = true;
            this.AirworthyPlane.Location = new System.Drawing.Point(5, 22);
            this.AirworthyPlane.Name = "AirworthyPlane";
            this.AirworthyPlane.Size = new System.Drawing.Size(50, 13);
            this.AirworthyPlane.TabIndex = 30;
            this.AirworthyPlane.Text = "Airworthy";
            // 
            // AltitudeLimitHeli
            // 
            this.AltitudeLimitHeli.AutoSize = true;
            this.AltitudeLimitHeli.Location = new System.Drawing.Point(5, 116);
            this.AltitudeLimitHeli.Name = "AltitudeLimitHeli";
            this.AltitudeLimitHeli.Size = new System.Drawing.Size(62, 13);
            this.AltitudeLimitHeli.TabIndex = 40;
            this.AltitudeLimitHeli.Text = "Altitude limit";
            // 
            // altitudeLimHeliTextBox
            // 
            this.altitudeLimHeliTextBox.Location = new System.Drawing.Point(6, 132);
            this.altitudeLimHeliTextBox.Name = "altitudeLimHeliTextBox";
            this.altitudeLimHeliTextBox.Size = new System.Drawing.Size(108, 20);
            this.altitudeLimHeliTextBox.TabIndex = 39;
            // 
            // HoursUsedHeli
            // 
            this.HoursUsedHeli.AutoSize = true;
            this.HoursUsedHeli.Location = new System.Drawing.Point(5, 67);
            this.HoursUsedHeli.Name = "HoursUsedHeli";
            this.HoursUsedHeli.Size = new System.Drawing.Size(61, 13);
            this.HoursUsedHeli.TabIndex = 38;
            this.HoursUsedHeli.Text = "Hours used";
            // 
            // hoursUsedHeliTextBox
            // 
            this.hoursUsedHeliTextBox.Location = new System.Drawing.Point(6, 83);
            this.hoursUsedHeliTextBox.Name = "hoursUsedHeliTextBox";
            this.hoursUsedHeliTextBox.Size = new System.Drawing.Size(108, 20);
            this.hoursUsedHeliTextBox.TabIndex = 37;
            // 
            // AirworthyHeli
            // 
            this.AirworthyHeli.AutoSize = true;
            this.AirworthyHeli.Location = new System.Drawing.Point(5, 15);
            this.AirworthyHeli.Name = "AirworthyHeli";
            this.AirworthyHeli.Size = new System.Drawing.Size(50, 13);
            this.AirworthyHeli.TabIndex = 36;
            this.AirworthyHeli.Text = "Airworthy";
            // 
            // Engines
            // 
            this.Engines.AutoSize = true;
            this.Engines.Location = new System.Drawing.Point(5, 216);
            this.Engines.Name = "Engines";
            this.Engines.Size = new System.Drawing.Size(45, 13);
            this.Engines.TabIndex = 44;
            this.Engines.Text = "Engines";
            // 
            // enginesTextBox
            // 
            this.enginesTextBox.Location = new System.Drawing.Point(6, 232);
            this.enginesTextBox.Name = "enginesTextBox";
            this.enginesTextBox.Size = new System.Drawing.Size(108, 20);
            this.enginesTextBox.TabIndex = 43;
            // 
            // Seats
            // 
            this.Seats.AutoSize = true;
            this.Seats.Location = new System.Drawing.Point(5, 167);
            this.Seats.Name = "Seats";
            this.Seats.Size = new System.Drawing.Size(34, 13);
            this.Seats.TabIndex = 42;
            this.Seats.Text = "Seats";
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.Location = new System.Drawing.Point(6, 183);
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.Size = new System.Drawing.Size(108, 20);
            this.seatsTextBox.TabIndex = 41;
            // 
            // elecWindowsCombo
            // 
            this.elecWindowsCombo.FormattingEnabled = true;
            this.elecWindowsCombo.Location = new System.Drawing.Point(5, 136);
            this.elecWindowsCombo.Name = "elecWindowsCombo";
            this.elecWindowsCombo.Size = new System.Drawing.Size(110, 21);
            this.elecWindowsCombo.TabIndex = 45;
            // 
            // carDetails
            // 
            this.carDetails.Controls.Add(this.NumberOfDoors);
            this.carDetails.Controls.Add(this.elecWindowsCombo);
            this.carDetails.Controls.Add(this.numDoorsTextBox);
            this.carDetails.Controls.Add(this.engineSizeTextBox);
            this.carDetails.Controls.Add(this.EngineSize);
            this.carDetails.Controls.Add(this.ElectricWindows);
            this.carDetails.Location = new System.Drawing.Point(166, 59);
            this.carDetails.Name = "carDetails";
            this.carDetails.Size = new System.Drawing.Size(129, 169);
            this.carDetails.TabIndex = 46;
            this.carDetails.TabStop = false;
            this.carDetails.Visible = false;
            // 
            // truckDetails
            // 
            this.truckDetails.Controls.Add(this.textBox9);
            this.truckDetails.Controls.Add(this.textBox11);
            this.truckDetails.Controls.Add(this.label12);
            this.truckDetails.Controls.Add(this.textBox10);
            this.truckDetails.Controls.Add(this.label11);
            this.truckDetails.Controls.Add(this.label10);
            this.truckDetails.Location = new System.Drawing.Point(166, 59);
            this.truckDetails.Name = "truckDetails";
            this.truckDetails.Size = new System.Drawing.Size(129, 172);
            this.truckDetails.TabIndex = 47;
            this.truckDetails.TabStop = false;
            this.truckDetails.Visible = false;
            // 
            // airWorthyHeliCombo
            // 
            this.airWorthyHeliCombo.FormattingEnabled = true;
            this.airWorthyHeliCombo.Location = new System.Drawing.Point(6, 33);
            this.airWorthyHeliCombo.Name = "airWorthyHeliCombo";
            this.airWorthyHeliCombo.Size = new System.Drawing.Size(110, 21);
            this.airWorthyHeliCombo.TabIndex = 48;
            // 
            // airWorthyPlaneCombo
            // 
            this.airWorthyPlaneCombo.FormattingEnabled = true;
            this.airWorthyPlaneCombo.Location = new System.Drawing.Point(4, 38);
            this.airWorthyPlaneCombo.Name = "airWorthyPlaneCombo";
            this.airWorthyPlaneCombo.Size = new System.Drawing.Size(110, 21);
            this.airWorthyPlaneCombo.TabIndex = 49;
            // 
            // heliDetails
            // 
            this.heliDetails.Controls.Add(this.altitudeLimHeliTextBox);
            this.heliDetails.Controls.Add(this.AirworthyHeli);
            this.heliDetails.Controls.Add(this.airWorthyHeliCombo);
            this.heliDetails.Controls.Add(this.hoursUsedHeliTextBox);
            this.heliDetails.Controls.Add(this.HoursUsedHeli);
            this.heliDetails.Controls.Add(this.AltitudeLimitHeli);
            this.heliDetails.Location = new System.Drawing.Point(165, 59);
            this.heliDetails.Name = "heliDetails";
            this.heliDetails.Size = new System.Drawing.Size(130, 169);
            this.heliDetails.TabIndex = 50;
            this.heliDetails.TabStop = false;
            this.heliDetails.Visible = false;
            // 
            // planeDetails
            // 
            this.planeDetails.Controls.Add(this.alLimPlaneTextBox);
            this.planeDetails.Controls.Add(this.AirworthyPlane);
            this.planeDetails.Controls.Add(this.airWorthyPlaneCombo);
            this.planeDetails.Controls.Add(this.hoursUsedPlanTextBox);
            this.planeDetails.Controls.Add(this.Engines);
            this.planeDetails.Controls.Add(this.hoursUsedPlane);
            this.planeDetails.Controls.Add(this.enginesTextBox);
            this.planeDetails.Controls.Add(this.Seats);
            this.planeDetails.Controls.Add(this.AltitudeLimitPlane);
            this.planeDetails.Controls.Add(this.seatsTextBox);
            this.planeDetails.Location = new System.Drawing.Point(164, 59);
            this.planeDetails.Name = "planeDetails";
            this.planeDetails.Size = new System.Drawing.Size(131, 261);
            this.planeDetails.TabIndex = 51;
            this.planeDetails.TabStop = false;
            this.planeDetails.Visible = false;
            // 
            // addVehicle
            // 
            this.addVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.addVehicle.Location = new System.Drawing.Point(498, 15);
            this.addVehicle.Name = "addVehicle";
            this.addVehicle.Size = new System.Drawing.Size(142, 52);
            this.addVehicle.TabIndex = 52;
            this.addVehicle.Text = "Add";
            this.addVehicle.UseVisualStyleBackColor = true;
            this.addVehicle.Click += new System.EventHandler(this.addVehicle_Click);
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.addVehicle);
            this.Controls.Add(this.planeDetails);
            this.Controls.Add(this.heliDetails);
            this.Controls.Add(this.truckDetails);
            this.Controls.Add(this.carDetails);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.regTextBox);
            this.Controls.Add(this.Colour);
            this.Controls.Add(this.colourTextBox);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Make);
            this.Name = "Vehicle";
            this.Text = "Vehicle";
            this.carDetails.ResumeLayout(false);
            this.carDetails.PerformLayout();
            this.truckDetails.ResumeLayout(false);
            this.truckDetails.PerformLayout();
            this.heliDetails.ResumeLayout(false);
            this.heliDetails.PerformLayout();
            this.planeDetails.ResumeLayout(false);
            this.planeDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Make;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Colour;
        private System.Windows.Forms.TextBox colourTextBox;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.TextBox regTextBox;
        private System.Windows.Forms.Label NumberOfDoors;
        private System.Windows.Forms.TextBox numDoorsTextBox;
        private System.Windows.Forms.Label EngineSize;
        private System.Windows.Forms.TextBox engineSizeTextBox;
        private System.Windows.Forms.Label ElectricWindows;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label AltitudeLimitPlane;
        private System.Windows.Forms.TextBox alLimPlaneTextBox;
        private System.Windows.Forms.Label hoursUsedPlane;
        private System.Windows.Forms.TextBox hoursUsedPlanTextBox;
        private System.Windows.Forms.Label AirworthyPlane;
        private System.Windows.Forms.Label AltitudeLimitHeli;
        private System.Windows.Forms.TextBox altitudeLimHeliTextBox;
        private System.Windows.Forms.Label HoursUsedHeli;
        private System.Windows.Forms.TextBox hoursUsedHeliTextBox;
        private System.Windows.Forms.Label AirworthyHeli;
        private System.Windows.Forms.Label Engines;
        private System.Windows.Forms.TextBox enginesTextBox;
        private System.Windows.Forms.Label Seats;
        private System.Windows.Forms.TextBox seatsTextBox;
        private System.Windows.Forms.ComboBox elecWindowsCombo;
        private System.Windows.Forms.GroupBox carDetails;
        private System.Windows.Forms.GroupBox truckDetails;
        private System.Windows.Forms.ComboBox airWorthyHeliCombo;
        private System.Windows.Forms.ComboBox airWorthyPlaneCombo;
        private System.Windows.Forms.GroupBox heliDetails;
        private System.Windows.Forms.GroupBox planeDetails;
        private System.Windows.Forms.Button addVehicle;
    }
}