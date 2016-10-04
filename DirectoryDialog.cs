using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektGenerator_Test1
{
    class DirectoryDialog
    {
        public string GetDirectoryFromUser()
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            return dialog.SelectedPath.ToString();
        }
    }
}
