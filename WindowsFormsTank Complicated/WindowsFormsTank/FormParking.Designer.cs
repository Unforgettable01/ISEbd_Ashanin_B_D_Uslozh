namespace WindowsFormsTank
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonParkingArmoredVehicle = new System.Windows.Forms.Button();
            this.buttonParkingTank = new System.Windows.Forms.Button();
            this.groupBoxForGetVehicle = new System.Windows.Forms.GroupBox();
            this.buttonSvobodMesta = new System.Windows.Forms.Button();
            this.buttonGetVehicle = new System.Windows.Forms.Button();
            this.maskedTextBoxParkingNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelParkingNumber = new System.Windows.Forms.Label();
            this.button_GunsFirstStyle = new System.Windows.Forms.Button();
            this.button_GunsSecondStyle = new System.Windows.Forms.Button();
            this.button_GunsThirdStyle = new System.Windows.Forms.Button();
            this.comboBoxNumberDopGun = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxForGetVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1693, 621);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonParkingArmoredVehicle
            // 
            this.buttonParkingArmoredVehicle.Location = new System.Drawing.Point(1538, 12);
            this.buttonParkingArmoredVehicle.Name = "buttonParkingArmoredVehicle";
            this.buttonParkingArmoredVehicle.Size = new System.Drawing.Size(97, 125);
            this.buttonParkingArmoredVehicle.TabIndex = 1;
            this.buttonParkingArmoredVehicle.Text = "Припарковать брон.машину";
            this.buttonParkingArmoredVehicle.UseVisualStyleBackColor = true;
            this.buttonParkingArmoredVehicle.Click += new System.EventHandler(this.buttonParkingArmoredVehicle_Click);
            // 
            // buttonParkingTank
            // 
            this.buttonParkingTank.Location = new System.Drawing.Point(1538, 143);
            this.buttonParkingTank.Name = "buttonParkingTank";
            this.buttonParkingTank.Size = new System.Drawing.Size(97, 88);
            this.buttonParkingTank.TabIndex = 2;
            this.buttonParkingTank.Text = "Припарковать танк";
            this.buttonParkingTank.UseVisualStyleBackColor = true;
            this.buttonParkingTank.Click += new System.EventHandler(this.buttonParkingTank_Click);
            // 
            // groupBoxForGetVehicle
            // 
            this.groupBoxForGetVehicle.Controls.Add(this.buttonSvobodMesta);
            this.groupBoxForGetVehicle.Controls.Add(this.buttonGetVehicle);
            this.groupBoxForGetVehicle.Controls.Add(this.maskedTextBoxParkingNumber);
            this.groupBoxForGetVehicle.Controls.Add(this.labelParkingNumber);
            this.groupBoxForGetVehicle.Location = new System.Drawing.Point(1632, 279);
            this.groupBoxForGetVehicle.Name = "groupBoxForGetVehicle";
            this.groupBoxForGetVehicle.Size = new System.Drawing.Size(97, 274);
            this.groupBoxForGetVehicle.TabIndex = 3;
            this.groupBoxForGetVehicle.TabStop = false;
            this.groupBoxForGetVehicle.Text = "Забрать транспорт";
            // 
            // buttonSvobodMesta
            // 
            this.buttonSvobodMesta.Location = new System.Drawing.Point(0, 221);
            this.buttonSvobodMesta.Name = "buttonSvobodMesta";
            this.buttonSvobodMesta.Size = new System.Drawing.Size(91, 47);
            this.buttonSvobodMesta.TabIndex = 3;
            this.buttonSvobodMesta.Text = "Проверка";
            this.buttonSvobodMesta.UseVisualStyleBackColor = true;
            this.buttonSvobodMesta.Click += new System.EventHandler(this.buttonSvobodMesta_Click);
            // 
            // buttonGetVehicle
            // 
            this.buttonGetVehicle.Location = new System.Drawing.Point(27, 142);
            this.buttonGetVehicle.Name = "buttonGetVehicle";
            this.buttonGetVehicle.Size = new System.Drawing.Size(55, 59);
            this.buttonGetVehicle.TabIndex = 2;
            this.buttonGetVehicle.Text = "Забрать";
            this.buttonGetVehicle.UseVisualStyleBackColor = true;
            this.buttonGetVehicle.Click += new System.EventHandler(this.buttonGetVehicle_Click);
            // 
            // maskedTextBoxParkingNumber
            // 
            this.maskedTextBoxParkingNumber.Location = new System.Drawing.Point(27, 95);
            this.maskedTextBoxParkingNumber.Name = "maskedTextBoxParkingNumber";
            this.maskedTextBoxParkingNumber.Size = new System.Drawing.Size(55, 26);
            this.maskedTextBoxParkingNumber.TabIndex = 1;
            // 
            // labelParkingNumber
            // 
            this.labelParkingNumber.AutoSize = true;
            this.labelParkingNumber.Location = new System.Drawing.Point(7, 71);
            this.labelParkingNumber.Name = "labelParkingNumber";
            this.labelParkingNumber.Size = new System.Drawing.Size(57, 20);
            this.labelParkingNumber.TabIndex = 0;
            this.labelParkingNumber.Text = "Место";
            // 
            // button_GunsFirstStyle
            // 
            this.button_GunsFirstStyle.Location = new System.Drawing.Point(1641, 13);
            this.button_GunsFirstStyle.Name = "button_GunsFirstStyle";
            this.button_GunsFirstStyle.Size = new System.Drawing.Size(88, 56);
            this.button_GunsFirstStyle.TabIndex = 4;
            this.button_GunsFirstStyle.Text = "Стиль 1";
            this.button_GunsFirstStyle.UseVisualStyleBackColor = true;
            this.button_GunsFirstStyle.Click += new System.EventHandler(this.buttonGunsStyle_Click);
            // 
            // button_GunsSecondStyle
            // 
            this.button_GunsSecondStyle.Location = new System.Drawing.Point(1641, 89);
            this.button_GunsSecondStyle.Name = "button_GunsSecondStyle";
            this.button_GunsSecondStyle.Size = new System.Drawing.Size(88, 49);
            this.button_GunsSecondStyle.TabIndex = 5;
            this.button_GunsSecondStyle.Text = "Стиль 2";
            this.button_GunsSecondStyle.UseVisualStyleBackColor = true;
            this.button_GunsSecondStyle.Click += new System.EventHandler(this.buttonGunsStyle_Click);
            // 
            // button_GunsThirdStyle
            // 
            this.button_GunsThirdStyle.Location = new System.Drawing.Point(1641, 159);
            this.button_GunsThirdStyle.Name = "button_GunsThirdStyle";
            this.button_GunsThirdStyle.Size = new System.Drawing.Size(88, 42);
            this.button_GunsThirdStyle.TabIndex = 6;
            this.button_GunsThirdStyle.Text = "Стиль 3";
            this.button_GunsThirdStyle.UseVisualStyleBackColor = true;
            this.button_GunsThirdStyle.Click += new System.EventHandler(this.buttonGunsStyle_Click);
            // 
            // comboBoxNumberDopGun
            // 
            this.comboBoxNumberDopGun.FormattingEnabled = true;
            this.comboBoxNumberDopGun.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxNumberDopGun.Location = new System.Drawing.Point(1608, 230);
            this.comboBoxNumberDopGun.Name = "comboBoxNumberDopGun";
            this.comboBoxNumberDopGun.Size = new System.Drawing.Size(121, 28);
            this.comboBoxNumberDopGun.TabIndex = 7;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1741, 626);
            this.Controls.Add(this.comboBoxNumberDopGun);
            this.Controls.Add(this.button_GunsThirdStyle);
            this.Controls.Add(this.button_GunsSecondStyle);
            this.Controls.Add(this.button_GunsFirstStyle);
            this.Controls.Add(this.groupBoxForGetVehicle);
            this.Controls.Add(this.buttonParkingTank);
            this.Controls.Add(this.buttonParkingArmoredVehicle);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxForGetVehicle.ResumeLayout(false);
            this.groupBoxForGetVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkingArmoredVehicle;
        private System.Windows.Forms.Button buttonParkingTank;
        private System.Windows.Forms.GroupBox groupBoxForGetVehicle;
        private System.Windows.Forms.Button buttonGetVehicle;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxParkingNumber;
        private System.Windows.Forms.Label labelParkingNumber;
        private System.Windows.Forms.Button button_GunsFirstStyle;
        private System.Windows.Forms.Button button_GunsSecondStyle;
        private System.Windows.Forms.Button button_GunsThirdStyle;
        private System.Windows.Forms.ComboBox comboBoxNumberDopGun;
        private System.Windows.Forms.Button buttonSvobodMesta;
    }
}