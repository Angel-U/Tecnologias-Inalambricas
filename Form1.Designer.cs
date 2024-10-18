namespace TecIn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDecaimientoI = new TextBox();
            txtDistancia = new TextBox();
            txtTasaD = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            lblRes = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDecaimientoI
            // 
            txtDecaimientoI.Location = new Point(40, 69);
            txtDecaimientoI.Name = "txtDecaimientoI";
            txtDecaimientoI.Size = new Size(164, 27);
            txtDecaimientoI.TabIndex = 0;
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(40, 263);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(164, 27);
            txtDistancia.TabIndex = 1;
            // 
            // txtTasaD
            // 
            txtTasaD.Location = new Point(40, 162);
            txtTasaD.Name = "txtTasaD";
            txtTasaD.Size = new Size(164, 27);
            txtTasaD.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(40, 337);
            button1.Name = "button1";
            button1.Size = new Size(164, 29);
            button1.TabIndex = 3;
            button1.Text = "Resultado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 240);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "Distancia";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 139);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 5;
            label2.Text = "Tasa de Decaimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 46);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 6;
            label3.Text = "Decaimiento Inicial";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(lblRes);
            panel1.Location = new Point(364, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 320);
            panel1.TabIndex = 7;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.BackColor = Color.FromArgb(224, 224, 224);
            lblRes.Location = new Point(20, 23);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(78, 20);
            lblRes.TabIndex = 0;
            lblRes.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(794, 438);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtTasaD);
            Controls.Add(txtDistancia);
            Controls.Add(txtDecaimientoI);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Decaimiento Exponencial";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDecaimientoI;
        private TextBox txtDistancia;
        private TextBox txtTasaD;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label lblRes;
    }
}
