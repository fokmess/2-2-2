
namespace _2_2_2
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.destination = new System.Windows.Forms.Label();
            this.dateFly = new System.Windows.Forms.Label();
            this.durationFly = new System.Windows.Forms.Label();
            this.freePlaces = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Segoe UI Black", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 50;
            this.listBox.Location = new System.Drawing.Point(75, 228);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(283, 504);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // fileName
            // 
            this.fileName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fileName.Location = new System.Drawing.Point(75, 96);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(283, 51);
            this.fileName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(465, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.destination.Location = new System.Drawing.Point(465, 365);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(233, 46);
            this.destination.TabIndex = 3;
            this.destination.Text = "Направление";
            // 
            // dateFly
            // 
            this.dateFly.AutoSize = true;
            this.dateFly.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dateFly.Location = new System.Drawing.Point(465, 452);
            this.dateFly.Name = "dateFly";
            this.dateFly.Size = new System.Drawing.Size(258, 46);
            this.dateFly.TabIndex = 4;
            this.dateFly.Text = "Время вылета";
            // 
            // durationFly
            // 
            this.durationFly.AutoSize = true;
            this.durationFly.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.durationFly.Location = new System.Drawing.Point(465, 537);
            this.durationFly.Name = "durationFly";
            this.durationFly.Size = new System.Drawing.Size(578, 46);
            this.durationFly.TabIndex = 5;
            this.durationFly.Text = "Длительность полета составит";
            // 
            // freePlaces
            // 
            this.freePlaces.AutoSize = true;
            this.freePlaces.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.freePlaces.Location = new System.Drawing.Point(465, 623);
            this.freePlaces.Name = "freePlaces";
            this.freePlaces.Size = new System.Drawing.Size(458, 46);
            this.freePlaces.TabIndex = 6;
            this.freePlaces.Text = "Свободных мест осталось";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(465, 277);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(92, 46);
            this.name.TabIndex = 7;
            this.name.Text = "Рейс";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 778);
            this.Controls.Add(this.name);
            this.Controls.Add(this.freePlaces);
            this.Controls.Add(this.durationFly);
            this.Controls.Add(this.dateFly);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label dateFly;
        private System.Windows.Forms.Label durationFly;
        private System.Windows.Forms.Label freePlaces;
        private System.Windows.Forms.Label name;
    }
}

