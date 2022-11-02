using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using CommonLib;

namespace IRSV_NetPro_SDK_CSharp
{
    public partial class FormIP : Form
    {
        List<string> _ListIP = new List<string>();

        public FormIP()
        {
            InitializeComponent();
        }

        private void FormIP_Load(object sender, EventArgs e)
        {
            _ListIP = ReadIPFile();
            listViewInit();
        }

        //初始化列：
        private void listViewInit()
        {
            try
            {
                listView1.HideSelection = false;

                listView1.BeginUpdate();
                listView1.Items.Clear();
                //listView1.Columns.Add("IP地址", 500, HorizontalAlignment.Left);
                foreach (string p in _ListIP)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = p;
                    listView1.Items.Add(lvi);
                }
                listView1.EndUpdate();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private List<string> ReadIPFile()
        {
            List<string> ListIP = new List<string>();
            string ip;
            string file = Application.StartupPath + "\\Config\\IP.txt";
            if (File.Exists(file))
            {
                using (FileStream aFile = new FileStream(file, FileMode.Open))
                using (StreamReader sr = new StreamReader(aFile, Encoding.GetEncoding("gb2312")))  //System.Text.Encoding.Default
                {
                    while (!sr.EndOfStream)
                    {
                        ip = sr.ReadLine();
                        if (!string.IsNullOrEmpty(ip))
                        {
                            if (ip.Trim() != "")
                                ListIP.Add(ip.Trim());
                        }
                    }
                }
            }
            return ListIP;
        }

        private void textBox_ip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && textBox_ip.Text != "")
            {
                button_add_Click(null, null);
            }
        }

        //添加
        private void button_add_Click(object sender, EventArgs e)
        {
            if(!IsRightIP(textBox_ip.Text))
            {
                MessageBox.Show(Iinternational.GlobalLanguage.msg_IPAddressInvalid, Iinternational.GlobalLanguage.msg_Prompt, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            ListViewItem lvi = new ListViewItem();
            lvi.Text = textBox_ip.Text;
            listView1.Items.Add(lvi);
        }

        //上移
        private void button_up_Click(object sender, EventArgs e)
        {
            ListViewUpMove(listView1);
        }

        //下移
        private void button_down_Click(object sender, EventArgs e)
        {
            ListViewDownMove(listView1);
        }

        //删除
        private void button_del_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show(Iinternational.GlobalLanguage.msg_SelectContent, Iinternational.GlobalLanguage.msg_Prompt, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int indexMaxSelectedItem = listView1.SelectedItems[listView1.SelectedItems.Count - 1].Index;
            listView1.Items[indexMaxSelectedItem].Remove();

            if (listView1.Items.Count > 0)
            {
                if (listView1.Items.Count > indexMaxSelectedItem)
                    listView1.Items[indexMaxSelectedItem].Selected = true;
                else
                    listView1.Items[0].Selected = true;
            }
        }

        //保存
        private void button_ok_Click(object sender, EventArgs e)
        {
            string file = Application.StartupPath + "\\Config\\IP.txt";
            try
            {
                using (FileStream aFile = new FileStream(file, FileMode.Create))
                using (StreamWriter sr = new StreamWriter(aFile, Encoding.GetEncoding("gb2312")))
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        sr.WriteLine(listView1.Items[i].Text);
                    }
                }
                MessageBox.Show(Iinternational.GlobalLanguage.msg_SaveScceed, Iinternational.GlobalLanguage.msg_Prompt, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(Iinternational.GlobalLanguage.msg_SaveFailed + ex.Message, Iinternational.GlobalLanguage.msg_Prompt, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //取消
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 判断ip地址是否正确，正确返回true 错误false
        /// </summary>
        /// <param name="strLocalIP">需要判断的字符串(IP地址)</param>
        /// <returns>TRUE OR FALSE</returns>
        private bool IsRightIP(string strLocalIP)
        {
            bool bFlag = false;
            bool Result = true;

            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}$");
            bFlag = regex.IsMatch(strLocalIP);
            if (bFlag == true)
            {
                string[] strTemp = strLocalIP.Split(new char[] { '.' });
                int nDotCount = strTemp.Length - 1; //字符串中.的数量，若.的数量小于3，则是非法的ip地址
                if (3 == nDotCount)//判断 .的数量
                {
                    for (int i = 0; i < strTemp.Length; i++)
                    {
                        if (Convert.ToInt32(strTemp[i]) > 255)   //大于255不符合返回false
                        {
                            Result = false;
                        }
                    }
                }
                else
                {
                    Result = false;
                }
            }
            else
            {
                //输入非数字则提示，不符合IP格式
                //MessageBox.Show("不符合IP格式");
                Result = false;
            }
            return Result;
        }

        //上移
        private void ListViewUpMove(ListView listView)
        {
            if (listView.SelectedItems.Count == 0)
            {
                return;
            }
            listView.BeginUpdate();
            if (listView.SelectedItems[0].Index > 0)
            {
                foreach (ListViewItem lvi in listView.SelectedItems)
                {
                    ListViewItem lviSelectedItem = lvi;
                    int indexSelectedItem = lvi.Index;
                    listView.Items.RemoveAt(indexSelectedItem);
                    listView.Items.Insert(indexSelectedItem - 1, lviSelectedItem);
                }
            }
            listView.EndUpdate();
            if (listView.Items.Count > 0 && listView.SelectedItems.Count > 0)
            {
                listView.Focus();
                listView.SelectedItems[0].Focused = true;
                listView.SelectedItems[0].EnsureVisible();
            }
        }

        //下移
        private void ListViewDownMove(ListView listView)
        {
            if (listView.SelectedItems.Count == 0)
            {
                return;
            }
            listView.BeginUpdate();
            int indexMaxSelectedItem = listView.SelectedItems[listView.SelectedItems.Count - 1].Index;
            if (indexMaxSelectedItem < listView.Items.Count - 1)
            {
                for (int i = listView.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem lviSelectedItem = listView.SelectedItems[i];
                    int indexSelectedItem = lviSelectedItem.Index;
                    listView.Items.RemoveAt(indexSelectedItem);
                    listView.Items.Insert(indexSelectedItem + 1, lviSelectedItem);
                }
            }
            listView.EndUpdate();
            if (listView.Items.Count > 0 && listView.SelectedItems.Count > 0)
            {
                listView.Focus();
                listView.SelectedItems[listView.SelectedItems.Count - 1].Focused = true;
                listView.SelectedItems[listView.SelectedItems.Count - 1].EnsureVisible();
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            
            int indexMaxSelectedItem = listView1.SelectedItems[listView1.SelectedItems.Count - 1].Index;
            textBox_ip.Text = listView1.SelectedItems[listView1.SelectedItems.Count - 1].Text;
        }

        


    }
}
