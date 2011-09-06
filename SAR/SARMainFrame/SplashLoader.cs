using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SARMainFrame
{
    public partial class SplashLoader : Form
    {
        public SplashLoader()
        {
            InitializeComponent();  
        }
        
        private void SplashLoader_Shown(object sender, EventArgs e)
        {
            this.Hide();
            loadLogin();
            loadMainFrame();
        }

        private void loadLogin()
        {
            var result = new LoginHandler().ShowDialog();
            if (result == DialogResult.Abort || result == DialogResult.Cancel)
            {
                Environment.Exit(0);
            }
        }

        private void loadMainFrame()
        {
            if (Hades.session.SessionManager.isLogedIn)
            {
                // Implement the mainframe loading
            }
        }
    }
}
