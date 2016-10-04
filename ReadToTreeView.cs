using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ProjektGenerator_Test1
{
    class ReadToTreeView
    {
        public void loadIntoTreeView(string path, TreeView treeView)
        {
            foreach (string s in Directory.EnumerateDirectories(path))
            {
                TreeViewItem item = new TreeViewItem();
                item.Header = s.Substring(s.LastIndexOf('\\') + 1);
                item.Tag = s;
                item.FontWeight = FontWeights.Normal;

                FillTreeView(item, s);
                treeView.Items.Add(item);
            }
        }


        internal void FillTreeView(TreeViewItem parentItem, string path)
        {
            foreach (string str in Directory.EnumerateDirectories(path))
            {
                TreeViewItem item = new TreeViewItem();
                item.Header = str.Substring(str.LastIndexOf('\\') + 1);
                item.Tag = str;
                item.FontWeight = FontWeights.Normal;
                parentItem.Items.Add(item);
                FillTreeView(item, str);
            }
        }
    }
}
