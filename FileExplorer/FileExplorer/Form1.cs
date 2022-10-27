using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            foreach(DriveInfo driveInfo in driveInfos)
            {
                TreeNode node = new TreeNode();
                node.Text = driveInfo.Name;
                treeView1.Nodes.Add(node);
                treeView1.NodeMouseClick += TreeView1_NodeMouseClick;
                DirectoryInfo directory = new DirectoryInfo(driveInfo.Name);
               
                  
            }    

        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = sender as TreeNode;
            string address = node.Text;
            DirectoryInfo directoryInfo = new DirectoryInfo(address);
            foreach(DirectoryInfo directory in directoryInfo.GetDirectories())
            {
                TreeNode node1 = new TreeNode();
                node1.Text = directory.Name;
                node.Nodes.Add(node1);
            }    
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }
    }
}
