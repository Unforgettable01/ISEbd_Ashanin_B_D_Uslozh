﻿namespace WindowsFormsTank
{
    partial class FormTank
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxTank = new System.Windows.Forms.PictureBox();
            this.buttonCreateArmoredVehicle = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.comboBoxNumberDopGun = new System.Windows.Forms.ComboBox();
            this.buttonCreateTank = new System.Windows.Forms.Button();
            this.button_GunsFirstStyle = new System.Windows.Forms.Button();
            this.button_GunsSecondStyle = new System.Windows.Forms.Button();
            this.button_GunsThirdStyle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTank)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTank
            // 
            this.pictureBoxTank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTank.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTank.Name = "pictureBoxTank";
            this.pictureBoxTank.Size = new System.Drawing.Size(1696, 679);
            this.pictureBoxTank.TabIndex = 0;
            this.pictureBoxTank.TabStop = false;
            // 
            // buttonCreateArmoredVehicle
            // 
            this.buttonCreateArmoredVehicle.Location = new System.Drawing.Point(167, 2);
            this.buttonCreateArmoredVehicle.Name = "buttonCreateArmoredVehicle";
            this.buttonCreateArmoredVehicle.Size = new System.Drawing.Size(205, 30);
            this.buttonCreateArmoredVehicle.TabIndex = 1;
            this.buttonCreateArmoredVehicle.Text = "Создать брон.машину";
            this.buttonCreateArmoredVehicle.UseVisualStyleBackColor = true;
            this.buttonCreateArmoredVehicle.Click += new System.EventHandler(this.buttonCreateArmoredVehicle_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackColor = System.Drawing.SystemColors.Control;
            this.buttonUp.BackgroundImage = global::WindowsFormsTank.Properties.Resources.Up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(1164, 496);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::WindowsFormsTank.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(1137, 522);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::WindowsFormsTank.Properties.Resources.Down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(1164, 550);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::WindowsFormsTank.Properties.Resources.Right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(1191, 522);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // comboBoxNumberDopGun
            // 
            this.comboBoxNumberDopGun.FormattingEnabled = true;
            this.comboBoxNumberDopGun.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxNumberDopGun.Location = new System.Drawing.Point(378, 4);
            this.comboBoxNumberDopGun.Name = "comboBoxNumberDopGun";
            this.comboBoxNumberDopGun.Size = new System.Drawing.Size(121, 28);
            this.comboBoxNumberDopGun.TabIndex = 6;
            // 
            // buttonCreateTank
            // 
            this.buttonCreateTank.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateTank.Name = "buttonCreateTank";
            this.buttonCreateTank.Size = new System.Drawing.Size(161, 32);
            this.buttonCreateTank.TabIndex = 7;
            this.buttonCreateTank.Text = "Создать танк";
            this.buttonCreateTank.UseVisualStyleBackColor = true;
            this.buttonCreateTank.Click += new System.EventHandler(this.buttonCreateTank_Click);
            // 
            // button_GunsFirstStyle
            // 
            this.button_GunsFirstStyle.Location = new System.Drawing.Point(590, 2);
            this.button_GunsFirstStyle.Name = "button_GunsFirstStyle";
            this.button_GunsFirstStyle.Size = new System.Drawing.Size(94, 42);
            this.button_GunsFirstStyle.TabIndex = 8;
            this.button_GunsFirstStyle.Text = "Стиль 1";
            this.button_GunsFirstStyle.UseVisualStyleBackColor = true;
            this.button_GunsFirstStyle.Click += new System.EventHandler(this.buttonGunsStyle_Click);
            // 
            // button_GunsSecondStyle
            // 
            this.button_GunsSecondStyle.Location = new System.Drawing.Point(713, 2);
            this.button_GunsSecondStyle.Name = "button_GunsSecondStyle";
            this.button_GunsSecondStyle.Size = new System.Drawing.Size(92, 42);
            this.button_GunsSecondStyle.TabIndex = 9;
            this.button_GunsSecondStyle.Text = "Стиль 2";
            this.button_GunsSecondStyle.UseVisualStyleBackColor = true;
            this.button_GunsSecondStyle.Click += new System.EventHandler(this.buttonGunsStyle_Click);
            // 
            // button_GunsThirdStyle
            // 
            this.button_GunsThirdStyle.Location = new System.Drawing.Point(834, 2);
            this.button_GunsThirdStyle.Name = "button_GunsThirdStyle";
            this.button_GunsThirdStyle.Size = new System.Drawing.Size(84, 42);
            this.button_GunsThirdStyle.TabIndex = 10;
            this.button_GunsThirdStyle.Text = "Стиль 3";
            this.button_GunsThirdStyle.UseVisualStyleBackColor = true;
            this.button_GunsThirdStyle.Click += new System.EventHandler(this.buttonGunsStyle_Click);
            // 
            // FormTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 679);
            this.Controls.Add(this.button_GunsThirdStyle);
            this.Controls.Add(this.button_GunsSecondStyle);
            this.Controls.Add(this.button_GunsFirstStyle);
            this.Controls.Add(this.buttonCreateTank);
            this.Controls.Add(this.comboBoxNumberDopGun);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonCreateArmoredVehicle);
            this.Controls.Add(this.pictureBoxTank);
            this.Name = "FormTank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tank";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTank;
        private System.Windows.Forms.Button buttonCreateArmoredVehicle;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.ComboBox comboBoxNumberDopGun;
        private System.Windows.Forms.Button buttonCreateTank;
        private System.Windows.Forms.Button button_GunsFirstStyle;
        private System.Windows.Forms.Button button_GunsSecondStyle;
        private System.Windows.Forms.Button button_GunsThirdStyle;
    }
}

