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
    class szamitogep : aru
    {
        public string ProcessorType { get; set; }
        public int MemorySize { get; set; }
        public string OperatingSystemName { get; set; }
        public szamitogep()
        {
            
        }

        public override void ClickButton()
        {
            button1.Click += (ss, ee) =>
            {
                MessageBox.Show($"{ProcessorType}\n{MemorySize}\n{OperatingSystemName}");
            };
        }
    }
}
