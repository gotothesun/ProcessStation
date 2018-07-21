using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace ProcessStation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string strPath = "";
        private string strName = "";
        private string strPrevent = "";
        private bool bAscending = true;

        public class ListViewItemComparer:System.Collections.IComparer
        {
            private int col;
            private SortOrder order;

            public ListViewItemComparer()
            {
                col = 0;
                order = SortOrder.Ascending;
            }


            public ListViewItemComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }


            public int Compare(object x, object y)
            {
                int returnVal = -1;
                float a = 0, b = 0;
                if(float.TryParse(((ListViewItem)x).SubItems[col].Text, out a) && float.TryParse(((ListViewItem)y).SubItems[col].Text, out b))
                {
                    returnVal = a >= b ? (a == b ? 0 : 1) : -1;
                }
                else
                {
                    returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                }
                if (order == SortOrder.Descending)
                {
                    returnVal *= -1;
                }
                return returnVal;
            }
        }

        private int RefreshView()
        {
            Process[] ps = Process.GetProcesses();
            listProcess.Items.Clear();
            listProcess.BeginUpdate();
            foreach (Process p in ps)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.ProcessName;
                lvi.SubItems.Add(p.Id.ToString());
                try
                {
                    lvi.SubItems.Add(p.MainModule.FileName);
                    listProcess.Items.Add(lvi);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(p.ProcessName,ex.Message);
                }
            }
            listProcess.EndUpdate();
            return ps.Count();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int iTotalProcess = RefreshView();
            int iLoadedProcess = listProcess.Items.Count;
            toolStripStatusLabel3.Text = String.Format("系统目前正在运行的进程数为：{0}/{1}", iLoadedProcess.ToString(), iTotalProcess.ToString());
            
        }

        private void listProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iTotalProcess = RefreshView();
            int iLoadedProcess = listProcess.Items.Count;
            toolStripStatusLabel3.Text = String.Format("系统目前正在运行的进程数为：{0}/{1}", iLoadedProcess.ToString(), iTotalProcess.ToString());

        }

        private void buttonKill_Click(object sender, EventArgs e)
        {
            if (listProcess.SelectedItems.Count == 0)
                return;
            string ProcessID = listProcess.SelectedItems[0].SubItems[1].Text;
            Process p = Process.GetProcessById(int.Parse(ProcessID));
            p.Kill();
            int i = listProcess.SelectedItems[0].Index;
            listProcess.Items[i].Remove();
        }

        private void listProcess_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (bAscending)
            {
                listProcess.ListViewItemSorter = new ListViewItemComparer(e.Column, SortOrder.Ascending);
                bAscending = false;
            }
            else
            {
                listProcess.ListViewItemSorter = new ListViewItemComparer(e.Column, SortOrder.Descending);
                bAscending = true;
            }
            listProcess.Sort();
        }

        private void buttonProtect_Click(object sender, EventArgs e)
        {
            if (listProcess.SelectedItems.Count == 0)
                MessageBox.Show("请选中你要进行保护的进程！");
            else
            {
                timer1.Start();
                strName = listProcess.SelectedItems[0].Text;
                strPath = listProcess.SelectedItems[0].SubItems[2].Text;
                toolStripStatusLabel1.Text = String.Format("正在保护进程：{0}     " + strName);
                Debug.WriteLine(strPath);
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int iTotalProcess = RefreshView();
            int iLoadedProcess = listProcess.Items.Count;
            toolStripStatusLabel3.Text = String.Format("系统目前正在运行的进程数为：{0}/{1}", iLoadedProcess.ToString(), iTotalProcess.ToString());
            if (strName != "")
            {
                bool bFound = false;
                foreach (ListViewItem item in listProcess.Items)
                {
                    if (item.SubItems[0].Text.Equals(strName))
                    {
                        Debug.WriteLine("请放心，进程安在。");
                        bFound = true;
                        break;
                    }
                }
                if (!bFound)
                {
                    Process p = new Process();
                    p.StartInfo.FileName = strPath;
                    p.Start();
                    Debug.WriteLine("进程不在，已重新启动！");
                }
            }
            if(strPrevent!="")
            {
                Process[] ps = Process.GetProcessesByName(strPrevent);
                if (ps.Count() == 0)
                    return;
                foreach(Process p in ps)
                {
                    p.Kill();
                    Debug.WriteLine(String.Format("发现进程{0}，已杀死！", strPrevent));
                }
            }
        }

        private void buttonPrevent_Click(object sender, EventArgs e)
        {
            if (listProcess.SelectedItems.Count == 0)
                MessageBox.Show("请选中你要进行阻止的进程！");
            else
            {
                timer1.Start();
                strPrevent = listProcess.SelectedItems[0].Text;
                toolStripStatusLabel2.Text = String.Format("正在阻止进程：{0}     ", strPrevent);
                Debug.WriteLine(strPrevent);
            }
        }
    }
}
