using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_work_2
{
    public partial class Form2 : Form
    {
        private int width;
        private int height;
        public Form2(int height, int width)
        {
            this.height = height;
            this.width = width;
            InitializeComponent();
        }

    }
}
