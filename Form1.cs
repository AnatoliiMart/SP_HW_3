using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_HW_3
{
    public partial class Form1 : Form
    {
        private SynchronizationContext context;
        private Task task;
        string searchDisk;
        public Form1()
        {
            InitializeComponent();
            context = SynchronizationContext.Current;
            cmbBox_LogDrives.DataSource = Directory.GetLogicalDrives();
            cmbBox_LogDrives.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void btn_SearchBeg_Click(object sender, EventArgs e)
        {
            btn_SearchBeg.Enabled = false;
            btn_SearchStop.Enabled = true;
            if (string.IsNullOrEmpty(cmbBox_LogDrives.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(txtBox_SearchPattern.Text))
            {
                MessageBox.Show("Выберите HDD или введите расширение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_SearchStop.Enabled = false;
                btn_SearchBeg.Enabled = true;
                return;
            }
            listView1.Items.Clear();
            searchDisk = cmbBox_LogDrives.SelectedItem.ToString();
            task = new Task(() => Method());
            task.Start();

        }
        public async void Method()
        {
            string target = txtBox_SearchValue.Text + txtBox_SearchPattern.Text;

            foreach (var item in await SearchFilesOrFolders(searchDisk, target))
            {
                ListViewItem viewItem = new ListViewItem(item.Name);
               
                viewItem.SubItems.Add(item.Directory.ToString());
                viewItem.SubItems.Add(item.Length.ToString());
                viewItem.SubItems.Add(item.LastAccessTime.ToString());
               
                context.Send(x => listView1.Items.Add(viewItem), null);
            }
        }


        public async Task<List<FileInfo>> SearchFilesOrFolders(string disk, string targetVal)
        {
            List<FileInfo> dirs = new List<FileInfo>();
            try
            {
                foreach (var file in Directory.GetFiles(disk, targetVal))
                    dirs.Add(new FileInfo(file));

                if (chkBox_IncludeSubdirs.Checked)
                {
                    string[] directories = Directory.GetDirectories(disk);

                    if (directories.Length > 0)
                        foreach (string directory in directories)
                            dirs.AddRange(await SearchFilesOrFolders(directory, targetVal));
                }
            }
            catch(UnauthorizedAccessException) 
            {
                task.Wait();
                btn_SearchStop.Enabled = false;
                btn_SearchBeg.Enabled = true;
                MessageBox.Show("Ошибка доступа к файловой системме!");
            }

            return dirs;
        }

        private void btn_SearchStop_Click(object sender, EventArgs e)
        {
            task.Wait();
            btn_SearchStop.Enabled = false;
            btn_SearchBeg.Enabled = true;
        }
    }
}
