
namespace ArduinoProject
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblBPM = new System.Windows.Forms.Label();
            this.lblNofinger = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblFine = new System.Windows.Forms.Label();
            this.chrtIR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpInstrucciones = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.picFine = new System.Windows.Forms.PictureBox();
            this.picWarning = new System.Windows.Forms.PictureBox();
            this.picDedo = new System.Windows.Forms.PictureBox();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.picHeart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chrtIR)).BeginInit();
            this.grpInstrucciones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDedo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.White;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIniciar.Location = new System.Drawing.Point(824, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(117, 50);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblBPM
            // 
            this.lblBPM.AutoSize = true;
            this.lblBPM.Font = new System.Drawing.Font("DSEG7 Classic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPM.Location = new System.Drawing.Point(3, 0);
            this.lblBPM.Name = "lblBPM";
            this.lblBPM.Size = new System.Drawing.Size(59, 48);
            this.lblBPM.TabIndex = 2;
            this.lblBPM.Text = "-";
            // 
            // lblNofinger
            // 
            this.lblNofinger.AutoSize = true;
            this.lblNofinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNofinger.Location = new System.Drawing.Point(329, 405);
            this.lblNofinger.Name = "lblNofinger";
            this.lblNofinger.Size = new System.Drawing.Size(371, 29);
            this.lblNofinger.TabIndex = 3;
            this.lblNofinger.Text = "Coloque su dedo sobre el sensor";
            this.lblNofinger.Visible = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(354, 132);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(306, 31);
            this.lblWarning.TabIndex = 10;
            this.lblWarning.Text = "Ritmo Cardiaco Elevado";
            this.lblWarning.Visible = false;
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.Location = new System.Drawing.Point(353, 347);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(320, 33);
            this.lblFine.TabIndex = 12;
            this.lblFine.Text = "Ritmo Cardiaco Normal";
            this.lblFine.Visible = false;
            // 
            // chrtIR
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtIR.ChartAreas.Add(chartArea1);
            this.chrtIR.Location = new System.Drawing.Point(12, 453);
            this.chrtIR.Name = "chrtIR";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chrtIR.Series.Add(series1);
            this.chrtIR.Size = new System.Drawing.Size(929, 204);
            this.chrtIR.TabIndex = 13;
            // 
            // grpInstrucciones
            // 
            this.grpInstrucciones.Controls.Add(this.label9);
            this.grpInstrucciones.Controls.Add(this.label5);
            this.grpInstrucciones.Controls.Add(this.label4);
            this.grpInstrucciones.Controls.Add(this.label3);
            this.grpInstrucciones.Controls.Add(this.label2);
            this.grpInstrucciones.Controls.Add(this.label1);
            this.grpInstrucciones.Location = new System.Drawing.Point(12, 166);
            this.grpInstrucciones.Name = "grpInstrucciones";
            this.grpInstrucciones.Size = new System.Drawing.Size(929, 259);
            this.grpInstrucciones.TabIndex = 14;
            this.grpInstrucciones.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(845, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "- Utilize la grafica para verificar si la posicion de su dedo es ideal.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(851, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "- Al terminar los 15 segundos, se mostrara el resultado en bpm.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(759, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "- Se tardara 15 segundas en tomar una medicion";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(654, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "- Presione el boton de Iniciar para tomar mediciones.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 43);
            this.label1.TabIndex = 15;
            this.label1.Text = "Instrucciones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "Monitor de Ritmo Cardiaco";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "bpm = latidos por minuto";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 37);
            this.label8.TabIndex = 21;
            this.label8.Text = "bpm";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblBPM, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(148, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 76);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(845, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "- Un ritmo cardiaco de mas de 100 bpm es considerado acelerado.";
            // 
            // picFine
            // 
            this.picFine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFine.Image = global::ArduinoProject.Properties.Resources.success;
            this.picFine.Location = new System.Drawing.Point(327, 166);
            this.picFine.Name = "picFine";
            this.picFine.Size = new System.Drawing.Size(373, 179);
            this.picFine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFine.TabIndex = 11;
            this.picFine.TabStop = false;
            this.picFine.Visible = false;
            // 
            // picWarning
            // 
            this.picWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWarning.Image = global::ArduinoProject.Properties.Resources.warning;
            this.picWarning.Location = new System.Drawing.Point(323, 166);
            this.picWarning.Name = "picWarning";
            this.picWarning.Size = new System.Drawing.Size(373, 178);
            this.picWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWarning.TabIndex = 9;
            this.picWarning.TabStop = false;
            this.picWarning.Visible = false;
            // 
            // picDedo
            // 
            this.picDedo.Image = global::ArduinoProject.Properties.Resources.manoB;
            this.picDedo.Location = new System.Drawing.Point(275, 128);
            this.picDedo.Name = "picDedo";
            this.picDedo.Size = new System.Drawing.Size(479, 245);
            this.picDedo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDedo.TabIndex = 7;
            this.picDedo.TabStop = false;
            this.picDedo.Visible = false;
            // 
            // picLoad
            // 
            this.picLoad.Image = global::ArduinoProject.Properties.Resources.loading_rojo;
            this.picLoad.Location = new System.Drawing.Point(398, 194);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(220, 145);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoad.TabIndex = 6;
            this.picLoad.TabStop = false;
            this.picLoad.Visible = false;
            // 
            // picHeart
            // 
            this.picHeart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picHeart.Image = global::ArduinoProject.Properties.Resources.heart1;
            this.picHeart.Location = new System.Drawing.Point(12, 54);
            this.picHeart.Name = "picHeart";
            this.picHeart.Size = new System.Drawing.Size(130, 120);
            this.picHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeart.TabIndex = 5;
            this.picHeart.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(956, 669);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpInstrucciones);
            this.Controls.Add(this.chrtIR);
            this.Controls.Add(this.lblFine);
            this.Controls.Add(this.picFine);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.picWarning);
            this.Controls.Add(this.picDedo);
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.picHeart);
            this.Controls.Add(this.lblNofinger);
            this.Controls.Add(this.btnIniciar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Monitor de Ritmo Cardiaco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtIR)).EndInit();
            this.grpInstrucciones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDedo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblBPM;
        private System.Windows.Forms.Label lblNofinger;
        private System.Windows.Forms.PictureBox picHeart;
        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.PictureBox picDedo;
        private System.Windows.Forms.PictureBox picWarning;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.PictureBox picFine;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtIR;
        private System.Windows.Forms.GroupBox grpInstrucciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
    }
}

