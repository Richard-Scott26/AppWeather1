
namespace AppWeather1
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblSunrise = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblSunset = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(169, 66);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(186, 31);
            this.txtCiudad.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(381, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Search";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblSunrise
            // 
            this.lblSunrise.AutoSize = true;
            this.lblSunrise.BackColor = System.Drawing.Color.Transparent;
            this.lblSunrise.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunrise.ForeColor = System.Drawing.Color.White;
            this.lblSunrise.Location = new System.Drawing.Point(185, 308);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(42, 23);
            this.lblSunrise.TabIndex = 3;
            this.lblSunrise.Text = "N/A";
            this.lblSunrise.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sunset:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sunrise:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.White;
            this.lblDetails.Location = new System.Drawing.Point(95, 268);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(71, 23);
            this.lblDetails.TabIndex = 6;
            this.lblDetails.Text = "Details:";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.BackColor = System.Drawing.Color.Transparent;
            this.lblCondition.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.ForeColor = System.Drawing.Color.White;
            this.lblCondition.Location = new System.Drawing.Point(95, 223);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(91, 23);
            this.lblCondition.TabIndex = 7;
            this.lblCondition.Text = "Condition:";
            // 
            // lblSunset
            // 
            this.lblSunset.AutoSize = true;
            this.lblSunset.BackColor = System.Drawing.Color.Transparent;
            this.lblSunset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunset.ForeColor = System.Drawing.Color.White;
            this.lblSunset.Location = new System.Drawing.Point(185, 357);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(42, 23);
            this.lblSunset.TabIndex = 8;
            this.lblSunset.Text = "N/A";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.BackColor = System.Drawing.Color.Transparent;
            this.lblPressure.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.ForeColor = System.Drawing.Color.White;
            this.lblPressure.Location = new System.Drawing.Point(428, 186);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(42, 23);
            this.lblPressure.TabIndex = 12;
            this.lblPressure.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(315, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Wind Speed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(339, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pressure:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(428, 137);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(42, 23);
            this.lblSpeed.TabIndex = 9;
            this.lblSpeed.Text = "N/A";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.ErrorImage = null;
            this.picIcon.Location = new System.Drawing.Point(99, 137);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(100, 72);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 461);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblSunset);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSunrise);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblSunrise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblSunset;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.PictureBox picIcon;
    }
}

