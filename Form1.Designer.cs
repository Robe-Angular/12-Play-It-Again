
namespace _12_Play_It_Again
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toogleEnabled = new System.Windows.Forms.Button();
            this.startTimer = new System.Windows.Forms.Button();
            this.stopTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toogleEnabled
            // 
            this.toogleEnabled.Location = new System.Drawing.Point(149, 74);
            this.toogleEnabled.Name = "toogleEnabled";
            this.toogleEnabled.Size = new System.Drawing.Size(116, 66);
            this.toogleEnabled.TabIndex = 0;
            this.toogleEnabled.Text = "Toogle enabled";
            this.toogleEnabled.UseVisualStyleBackColor = true;
            this.toogleEnabled.Click += new System.EventHandler(this.toogleEnabled_Click);
            // 
            // startTimer
            // 
            this.startTimer.Location = new System.Drawing.Point(295, 74);
            this.startTimer.Name = "startTimer";
            this.startTimer.Size = new System.Drawing.Size(116, 66);
            this.startTimer.TabIndex = 1;
            this.startTimer.Text = "Start timer";
            this.startTimer.UseVisualStyleBackColor = true;
            this.startTimer.Click += new System.EventHandler(this.startTimer_Click);
            // 
            // stopTimer
            // 
            this.stopTimer.Location = new System.Drawing.Point(441, 74);
            this.stopTimer.Name = "stopTimer";
            this.stopTimer.Size = new System.Drawing.Size(116, 66);
            this.stopTimer.TabIndex = 2;
            this.stopTimer.Text = "Stop timer";
            this.stopTimer.UseVisualStyleBackColor = true;
            this.stopTimer.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopTimer);
            this.Controls.Add(this.startTimer);
            this.Controls.Add(this.toogleEnabled);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button toogleEnabled;
        private System.Windows.Forms.Button startTimer;
        private System.Windows.Forms.Button stopTimer;
    }
}

