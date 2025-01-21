using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_01_21_dolgozat
{
    class aru : UserControl
    {
        public Button button1;

        public string name { get; set; }
        public int price { get; set; }

        public aru()
        {
            InitializeComponent();
            ButtonNameChange();
            ClickButton();
        }

        public virtual void ClickButton()
        {
            button1.Click += (ss, ee) =>
            {
                MessageBox.Show(Convert.ToString(price));
            };
        }

        public virtual void ButtonNameChange()
        {
            name = "Crazy";
            button1.Text = name;
        }
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // aru
            // 
            this.Controls.Add(this.button1);
            this.Name = "aru";
            this.Size = new System.Drawing.Size(198, 182);
            this.ResumeLayout(false);

        }
    }

}
