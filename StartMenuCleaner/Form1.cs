using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartMenuCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("");
            if (System.IO.Directory.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Microsoft\Windows\Start Menu\Programs\Accessories"))
            {
                System.IO.Directory.Delete($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Microsoft\Windows\Start Menu\Programs\Accessories");
            }
            if (System.IO.Directory.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Microsoft\Windows\Start Menu\Programs\Windows Accessories"))
            {
                System.IO.Directory.Delete($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Microsoft\Windows\Start Menu\Programs\Windows Accessories");
            }
            if (System.IO.Directory.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Microsoft\Windows\Start Menu\Programs\Startup"))
            {
                System.IO.Directory.Delete($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Microsoft\Windows\Start Menu\Programs\Startup");
            }
            if (System.IO.Directory.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Microsoft\Windows\Start Menu\Programs\Administrative Tools"))
            {
                System.IO.Directory.Delete($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Microsoft\Windows\Start Menu\Programs\Administrative Tools");
            }
            if (System.IO.Directory.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Microsoft\Windows\Start Menu\Programs\Windows Administrative Tools"))
            {
                System.IO.Directory.Delete($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Microsoft\Windows\Start Menu\Programs\Windows Administrative Tools");
            }
            if (System.IO.File.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Microsoft\Windows\Start Menu\Programs\OneDrive.lnk"))
            {
                System.IO.File.Delete($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Microsoft\Windows\Start Menu\Programs\OneDrive.lnk");
            }
            Environment.Exit(0);
        }
    }
}
