using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nexus;

namespace SAMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RENTECOSAContext db = new RENTECOSAContext();
            var resultado = db.People.Where( x => x.Name == "Jose Luis").First().PersonPhones.ToList();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
