using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Delocator
{
    public partial class UIForm : Form
    {
        public UIForm()
        {
            InitializeComponent();
            //List<string> test = new List<string>(){"Testing", "One", "Two", "Three"};
            //Tools.Logger(test);

            ProjectFolders.CreateCommonFolder();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            textBoxFile.Text = Tools.GetFilePath();
            Tools.WriteImageData(textBoxFile.Text);
            Tools.Delocate(textBoxFile.Text);
            this.Close();
        }

    }
}
