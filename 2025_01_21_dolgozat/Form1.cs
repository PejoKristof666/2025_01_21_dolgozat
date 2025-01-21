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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
        } 
        public void Start()
        {
            szamitogep oneSzamitogep = new szamitogep() { ProcessorType = "AMD", MemorySize = 1024, OperatingSystemName = "Windows" };
            this.Controls.Add(oneSzamitogep);
        }
    }
}
