
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.lblBPM = new System.Windows.Forms.Label();
            this.lblNofinger = new System.Windows.Forms.Label();
            this.RepositionTimeout = new System.Windows.Forms.Timer(this.components);
            this.bpmTimer = new System.Windows.Forms.Timer(this.components);
            this.lblWarning = new System.Windows.Forms.Label();
            this.picFine = new System.Windows.Forms.PictureBox();
            this.picWarning = new System.Windows.Forms.PictureBox();
            this.picDedo = new System.Windows.Forms.PictureBox();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.picHeart = new System.Windows.Forms.PictureBox();
            this.lblFine = new System.Windows.Forms.Label();
            this.chrtIR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpInstrucciones = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDedo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtIR)).BeginInit();
            this.grpInstrucciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.White;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIniciar.Location = new System.Drawing.Point(422, 13);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(84, 32);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.White;
            this.btnDetener.FlatAppearance.BorderSize = 0;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDetener.Location = new System.Drawing.Point(422, 51);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(84, 32);
            this.btnDetener.TabIndex = 1;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // lblBPM
            // 
            this.lblBPM.AutoSize = true;
            this.lblBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPM.Location = new System.Drawing.Point(108, 37);
            this.lblBPM.Name = "lblBPM";
            this.lblBPM.Size = new System.Drawing.Size(25, 33);
            this.lblBPM.TabIndex = 2;
            this.lblBPM.Text = "-";
            // 
            // lblNofinger
            // 
            this.lblNofinger.AutoSize = true;
            this.lblNofinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNofinger.Location = new System.Drawing.Point(109, 305);
            this.lblNofinger.Name = "lblNofinger";
            this.lblNofinger.Size = new System.Drawing.Size(291, 24);
            this.lblNofinger.TabIndex = 3;
            this.lblNofinger.Text = "Coloque su dedo sobre el sensor";
            this.lblNofinger.Visible = false;
            // 
            // RepositionTimeout
            // 
            this.RepositionTimeout.Interval = 6000;
            // 
            // bpmTimer
            // 
            this.bpmTimer.Interval = 10000;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(142, 112);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(243, 25);
            this.lblWarning.TabIndex = 10;
            this.lblWarning.Text = "Ritmo Cardiaco Elevado";
            this.lblWarning.Visible = false;
            // 
            // picFine
            // 
            this.picFine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFine.Image = global::ArduinoProject.Properties.Resources.success;
            this.picFine.Location = new System.Drawing.Point(206, 147);
            this.picFine.Name = "picFine";
            this.picFine.Size = new System.Drawing.Size(119, 94);
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
            this.picWarning.Location = new System.Drawing.Point(206, 147);
            this.picWarning.Name = "picWarning";
            this.picWarning.Size = new System.Drawing.Size(119, 94);
            this.picWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWarning.TabIndex = 9;
            this.picWarning.TabStop = false;
            this.picWarning.Visible = false;
            // 
            // picDedo
            // 
            this.picDedo.Image = global::ArduinoProject.Properties.Resources.mano;
            this.picDedo.Location = new System.Drawing.Point(90, 110);
            this.picDedo.Name = "picDedo";
            this.picDedo.Size = new System.Drawing.Size(344, 180);
            this.picDedo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDedo.TabIndex = 7;
            this.picDedo.TabStop = false;
            this.picDedo.Visible = false;
            // 
            // picLoad
            // 
            this.picLoad.Image = global::ArduinoProject.Properties.Resources.load;
            this.picLoad.Location = new System.Drawing.Point(176, 151);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(149, 98);
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
            this.picHeart.Image = global::ArduinoProject.Properties.Resources.heart;
            this.picHeart.Location = new System.Drawing.Point(12, 17);
            this.picHeart.Name = "picHeart";
            this.picHeart.Size = new System.Drawing.Size(80, 66);
            this.picHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeart.TabIndex = 5;
            this.picHeart.TabStop = false;
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.Location = new System.Drawing.Point(147, 252);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(233, 25);
            this.lblFine.TabIndex = 12;
            this.lblFine.Text = "Ritmo Cardiaco Normal";
            this.lblFine.Visible = false;
            // 
            // chrtIR
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtIR.ChartAreas.Add(chartArea1);
            this.chrtIR.Location = new System.Drawing.Point(12, 331);
            this.chrtIR.Name = "chrtIR";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chrtIR.Series.Add(series1);
            this.chrtIR.Size = new System.Drawing.Size(494, 164);
            this.chrtIR.TabIndex = 13;
            // 
            // grpInstrucciones
            // 
            this.grpInstrucciones.Controls.Add(this.label5);
            this.grpInstrucciones.Controls.Add(this.label4);
            this.grpInstrucciones.Controls.Add(this.label3);
            this.grpInstrucciones.Controls.Add(this.label2);
            this.grpInstrucciones.Controls.Add(this.label1);
            this.grpInstrucciones.Location = new System.Drawing.Point(12, 110);
            this.grpInstrucciones.Name = "grpInstrucciones";
            this.grpInstrucciones.Size = new System.Drawing.Size(485, 180);
            this.grpInstrucciones.TabIndex = 14;
            this.grpInstrucciones.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(473, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "- Cada diez segundos se actualizara el ritmo cardiaco calculado.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "- Coloque su dedo indice sobre el sensor sin aplicar mucha presion.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "- Presione el boton de Iniciar para tomar mediciones.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Instrucciones:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(473, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "- Utilize la grafica para verificar si la posicion de su dedo es ideal.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(518, 507);
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
            this.Controls.Add(this.lblBPM);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Monitor de Ritmo Cardiaco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDedo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtIR)).EndInit();
            this.grpInstrucciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Label lblBPM;
        private System.Windows.Forms.Label lblNofinger;
        private System.Windows.Forms.PictureBox picHeart;
        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.PictureBox picDedo;
        private System.Windows.Forms.Timer RepositionTimeout;
        private System.Windows.Forms.Timer bpmTimer;
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
    }
}

