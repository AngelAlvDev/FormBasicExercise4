namespace FormBasicExercise4
{
    partial class GastosEnvio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GastosEnvio));
            this.envioGroupBox = new System.Windows.Forms.GroupBox();
            this.correoNormalRadioButton = new System.Windows.Forms.RadioButton();
            this.PaqueteriaNormalRadioButton = new System.Windows.Forms.RadioButton();
            this.PaqueteriaUrgenteRadioButton = new System.Windows.Forms.RadioButton();
            this.notificacionGroupBox = new System.Windows.Forms.GroupBox();
            this.EmailCheckBox = new System.Windows.Forms.CheckBox();
            this.telefonoCheckBox = new System.Windows.Forms.CheckBox();
            this.faxCheckBox = new System.Windows.Forms.CheckBox();
            this.envioLabel = new System.Windows.Forms.Label();
            this.notificacionLabel = new System.Windows.Forms.Label();
            this.explicacionLabel = new System.Windows.Forms.Label();
            this.calcularButton = new System.Windows.Forms.Button();
            this.costeLabel = new System.Windows.Forms.Label();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.precioTelefonoLabel = new System.Windows.Forms.Label();
            this.precioEmailLabel = new System.Windows.Forms.Label();
            this.precioFaxLabel = new System.Windows.Forms.Label();
            this.precioCorreoNormalLabel = new System.Windows.Forms.Label();
            this.precioPaqueteriaNormalLabel = new System.Windows.Forms.Label();
            this.precioPaqueteriaUrgenteLabel = new System.Windows.Forms.Label();
            this.envioGroupBox.SuspendLayout();
            this.notificacionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // envioGroupBox
            // 
            this.envioGroupBox.Controls.Add(this.precioPaqueteriaUrgenteLabel);
            this.envioGroupBox.Controls.Add(this.precioPaqueteriaNormalLabel);
            this.envioGroupBox.Controls.Add(this.precioCorreoNormalLabel);
            this.envioGroupBox.Controls.Add(this.PaqueteriaUrgenteRadioButton);
            this.envioGroupBox.Controls.Add(this.PaqueteriaNormalRadioButton);
            this.envioGroupBox.Controls.Add(this.correoNormalRadioButton);
            this.envioGroupBox.Location = new System.Drawing.Point(39, 75);
            this.envioGroupBox.Name = "envioGroupBox";
            this.envioGroupBox.Size = new System.Drawing.Size(233, 134);
            this.envioGroupBox.TabIndex = 0;
            this.envioGroupBox.TabStop = false;
            this.envioGroupBox.Text = "Tipo de envío";
            // 
            // correoNormalRadioButton
            // 
            this.correoNormalRadioButton.AutoSize = true;
            this.correoNormalRadioButton.Location = new System.Drawing.Point(38, 33);
            this.correoNormalRadioButton.Name = "correoNormalRadioButton";
            this.correoNormalRadioButton.Size = new System.Drawing.Size(90, 17);
            this.correoNormalRadioButton.TabIndex = 0;
            this.correoNormalRadioButton.TabStop = true;
            this.correoNormalRadioButton.Text = "Correo normal";
            this.correoNormalRadioButton.UseVisualStyleBackColor = true;
            // 
            // PaqueteriaNormalRadioButton
            // 
            this.PaqueteriaNormalRadioButton.AutoSize = true;
            this.PaqueteriaNormalRadioButton.Location = new System.Drawing.Point(38, 57);
            this.PaqueteriaNormalRadioButton.Name = "PaqueteriaNormalRadioButton";
            this.PaqueteriaNormalRadioButton.Size = new System.Drawing.Size(106, 17);
            this.PaqueteriaNormalRadioButton.TabIndex = 1;
            this.PaqueteriaNormalRadioButton.TabStop = true;
            this.PaqueteriaNormalRadioButton.Text = "Paquetría normal";
            this.PaqueteriaNormalRadioButton.UseVisualStyleBackColor = true;
            // 
            // PaqueteriaUrgenteRadioButton
            // 
            this.PaqueteriaUrgenteRadioButton.AutoSize = true;
            this.PaqueteriaUrgenteRadioButton.Location = new System.Drawing.Point(38, 81);
            this.PaqueteriaUrgenteRadioButton.Name = "PaqueteriaUrgenteRadioButton";
            this.PaqueteriaUrgenteRadioButton.Size = new System.Drawing.Size(117, 17);
            this.PaqueteriaUrgenteRadioButton.TabIndex = 2;
            this.PaqueteriaUrgenteRadioButton.TabStop = true;
            this.PaqueteriaUrgenteRadioButton.Text = "Paquetería urgente";
            this.PaqueteriaUrgenteRadioButton.UseVisualStyleBackColor = true;
            // 
            // notificacionGroupBox
            // 
            this.notificacionGroupBox.Controls.Add(this.precioFaxLabel);
            this.notificacionGroupBox.Controls.Add(this.precioEmailLabel);
            this.notificacionGroupBox.Controls.Add(this.precioTelefonoLabel);
            this.notificacionGroupBox.Controls.Add(this.faxCheckBox);
            this.notificacionGroupBox.Controls.Add(this.telefonoCheckBox);
            this.notificacionGroupBox.Controls.Add(this.EmailCheckBox);
            this.notificacionGroupBox.Location = new System.Drawing.Point(360, 75);
            this.notificacionGroupBox.Name = "notificacionGroupBox";
            this.notificacionGroupBox.Size = new System.Drawing.Size(229, 134);
            this.notificacionGroupBox.TabIndex = 1;
            this.notificacionGroupBox.TabStop = false;
            this.notificacionGroupBox.Text = "Modo de notificación";
            this.notificacionGroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // EmailCheckBox
            // 
            this.EmailCheckBox.AutoSize = true;
            this.EmailCheckBox.Location = new System.Drawing.Point(39, 33);
            this.EmailCheckBox.Name = "EmailCheckBox";
            this.EmailCheckBox.Size = new System.Drawing.Size(51, 17);
            this.EmailCheckBox.TabIndex = 0;
            this.EmailCheckBox.Text = "Email";
            this.EmailCheckBox.UseVisualStyleBackColor = true;
            // 
            // telefonoCheckBox
            // 
            this.telefonoCheckBox.AutoSize = true;
            this.telefonoCheckBox.Location = new System.Drawing.Point(39, 57);
            this.telefonoCheckBox.Name = "telefonoCheckBox";
            this.telefonoCheckBox.Size = new System.Drawing.Size(68, 17);
            this.telefonoCheckBox.TabIndex = 1;
            this.telefonoCheckBox.Text = "Teléfono";
            this.telefonoCheckBox.UseVisualStyleBackColor = true;
            // 
            // faxCheckBox
            // 
            this.faxCheckBox.AutoSize = true;
            this.faxCheckBox.Location = new System.Drawing.Point(39, 81);
            this.faxCheckBox.Name = "faxCheckBox";
            this.faxCheckBox.Size = new System.Drawing.Size(43, 17);
            this.faxCheckBox.TabIndex = 2;
            this.faxCheckBox.Text = "Fax";
            this.faxCheckBox.UseVisualStyleBackColor = true;
            // 
            // envioLabel
            // 
            this.envioLabel.AutoSize = true;
            this.envioLabel.Location = new System.Drawing.Point(74, 43);
            this.envioLabel.Name = "envioLabel";
            this.envioLabel.Size = new System.Drawing.Size(125, 13);
            this.envioLabel.TabIndex = 2;
            this.envioLabel.Text = "Escoja el modo de envío";
            this.envioLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // notificacionLabel
            // 
            this.notificacionLabel.AutoSize = true;
            this.notificacionLabel.Location = new System.Drawing.Point(396, 43);
            this.notificacionLabel.Name = "notificacionLabel";
            this.notificacionLabel.Size = new System.Drawing.Size(151, 13);
            this.notificacionLabel.TabIndex = 3;
            this.notificacionLabel.Text = "Escoja el modo de notificación";
            // 
            // explicacionLabel
            // 
            this.explicacionLabel.AutoSize = true;
            this.explicacionLabel.Location = new System.Drawing.Point(396, 212);
            this.explicacionLabel.Name = "explicacionLabel";
            this.explicacionLabel.Size = new System.Drawing.Size(160, 13);
            this.explicacionLabel.TabIndex = 4;
            this.explicacionLabel.Text = "(Pueden ser tantas como desee)";
            this.explicacionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(124, 266);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(75, 23);
            this.calcularButton.TabIndex = 5;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // costeLabel
            // 
            this.costeLabel.Location = new System.Drawing.Point(316, 271);
            this.costeLabel.Name = "costeLabel";
            this.costeLabel.Size = new System.Drawing.Size(88, 18);
            this.costeLabel.TabIndex = 6;
            this.costeLabel.Text = "Coste del envío:";
            this.costeLabel.Visible = false;
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(407, 271);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(7, 13);
            this.resultadoLabel.TabIndex = 7;
            this.resultadoLabel.Text = "\r\n";
            this.resultadoLabel.Visible = false;
            // 
            // precioTelefonoLabel
            // 
            this.precioTelefonoLabel.AutoSize = true;
            this.precioTelefonoLabel.Location = new System.Drawing.Point(114, 57);
            this.precioTelefonoLabel.Name = "precioTelefonoLabel";
            this.precioTelefonoLabel.Size = new System.Drawing.Size(37, 13);
            this.precioTelefonoLabel.TabIndex = 3;
            this.precioTelefonoLabel.Text = "0,85 €";
            // 
            // precioEmailLabel
            // 
            this.precioEmailLabel.AutoSize = true;
            this.precioEmailLabel.Location = new System.Drawing.Point(114, 33);
            this.precioEmailLabel.Name = "precioEmailLabel";
            this.precioEmailLabel.Size = new System.Drawing.Size(37, 13);
            this.precioEmailLabel.TabIndex = 4;
            this.precioEmailLabel.Text = "0,25 €";
            // 
            // precioFaxLabel
            // 
            this.precioFaxLabel.AutoSize = true;
            this.precioFaxLabel.Location = new System.Drawing.Point(117, 81);
            this.precioFaxLabel.Name = "precioFaxLabel";
            this.precioFaxLabel.Size = new System.Drawing.Size(37, 13);
            this.precioFaxLabel.TabIndex = 5;
            this.precioFaxLabel.Text = "0,65 €";
            // 
            // precioCorreoNormalLabel
            // 
            this.precioCorreoNormalLabel.AutoSize = true;
            this.precioCorreoNormalLabel.Location = new System.Drawing.Point(161, 33);
            this.precioCorreoNormalLabel.Name = "precioCorreoNormalLabel";
            this.precioCorreoNormalLabel.Size = new System.Drawing.Size(22, 13);
            this.precioCorreoNormalLabel.TabIndex = 3;
            this.precioCorreoNormalLabel.Text = "2 €";
            // 
            // precioPaqueteriaNormalLabel
            // 
            this.precioPaqueteriaNormalLabel.AutoSize = true;
            this.precioPaqueteriaNormalLabel.Location = new System.Drawing.Point(161, 57);
            this.precioPaqueteriaNormalLabel.Name = "precioPaqueteriaNormalLabel";
            this.precioPaqueteriaNormalLabel.Size = new System.Drawing.Size(22, 13);
            this.precioPaqueteriaNormalLabel.TabIndex = 4;
            this.precioPaqueteriaNormalLabel.Text = "3 €";
            // 
            // precioPaqueteriaUrgenteLabel
            // 
            this.precioPaqueteriaUrgenteLabel.AutoSize = true;
            this.precioPaqueteriaUrgenteLabel.Location = new System.Drawing.Point(161, 81);
            this.precioPaqueteriaUrgenteLabel.Name = "precioPaqueteriaUrgenteLabel";
            this.precioPaqueteriaUrgenteLabel.Size = new System.Drawing.Size(22, 13);
            this.precioPaqueteriaUrgenteLabel.TabIndex = 5;
            this.precioPaqueteriaUrgenteLabel.Text = "5 €";
            // 
            // GastosEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 345);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.costeLabel);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.explicacionLabel);
            this.Controls.Add(this.notificacionLabel);
            this.Controls.Add(this.envioLabel);
            this.Controls.Add(this.notificacionGroupBox);
            this.Controls.Add(this.envioGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GastosEnvio";
            this.Text = "Cálculo de gastos de envío";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.envioGroupBox.ResumeLayout(false);
            this.envioGroupBox.PerformLayout();
            this.notificacionGroupBox.ResumeLayout(false);
            this.notificacionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox envioGroupBox;
        private System.Windows.Forms.RadioButton PaqueteriaUrgenteRadioButton;
        private System.Windows.Forms.RadioButton PaqueteriaNormalRadioButton;
        private System.Windows.Forms.RadioButton correoNormalRadioButton;
        private System.Windows.Forms.GroupBox notificacionGroupBox;
        private System.Windows.Forms.CheckBox faxCheckBox;
        private System.Windows.Forms.CheckBox telefonoCheckBox;
        private System.Windows.Forms.CheckBox EmailCheckBox;
        private System.Windows.Forms.Label envioLabel;
        private System.Windows.Forms.Label notificacionLabel;
        private System.Windows.Forms.Label explicacionLabel;
        private System.Windows.Forms.Label precioPaqueteriaUrgenteLabel;
        private System.Windows.Forms.Label precioPaqueteriaNormalLabel;
        private System.Windows.Forms.Label precioCorreoNormalLabel;
        private System.Windows.Forms.Label precioFaxLabel;
        private System.Windows.Forms.Label precioEmailLabel;
        private System.Windows.Forms.Label precioTelefonoLabel;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label costeLabel;
        private System.Windows.Forms.Label resultadoLabel;
    }
}

