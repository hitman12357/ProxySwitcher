using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace ProxyChanger
{
    public partial class MainForm : Form
    {
        private ContextMenuStrip fruitContextMenuStrip;
        public MainForm()
        {
            InitializeComponent();
            // Create a new ContextMenuStrip control.
            fruitContextMenuStrip = new ContextMenuStrip();         
            hideInTray.ContextMenuStrip = fruitContextMenuStrip;
        }

        void cms_SetProxy(object sender, EventArgs e)
        {            
            if (sender.ToString().Length > 0)
                ProxyChange.SetProxy(sender.ToString());
            loadItems();
        }

        private void proxyChangeBtn_Click(object sender, EventArgs e)
        {
            string addr = cBoxProxyList.SelectedItem.ToString();
            bool result = ProxyChange.SetProxy(addr);
            loadItems();
            MessageBox.Show((result) ? "Проксі змінено!" : "Помилка! Проксі не змінено.");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                object obj = ProxyChange.GetSystemProxy();
                string[] list = LoadSettings.LoadProxyList();
                foreach (string addr in list)
                {
                    cBoxProxyList.Items.Add(addr);
                    if (obj.ToString() == addr)
                        fruitContextMenuStrip.Items.Add(addr,  Bitmap.FromFile("g1.gif"), cms_SetProxy);
                    else
                        fruitContextMenuStrip.Items.Add(addr, Bitmap.FromFile("g2.gif"), cms_SetProxy);
                }
                cBoxProxyList.SelectedItem = obj;
                Hide();
                this.ShowInTaskbar = false;
            }
            catch (System.IO.FileNotFoundException ex)
            {                
                MessageBox.Show("Не знайдено файл "+ ex.FileName + ".", "Помилка при завантаженні");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                this.ShowInTaskbar = false;
            }
                
        }

        private void hideInTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            this.Show();            
            this.ShowInTaskbar = true;
            this.Focus();
        }

        private void loadItems()
        {
            object obj = ProxyChange.GetSystemProxy();
            string[] list = LoadSettings.LoadProxyList();
            fruitContextMenuStrip.Items.Clear();
            foreach (string addr in list)
            {
                cBoxProxyList.Items.Add(addr);
                if (obj.ToString() == addr)
                    fruitContextMenuStrip.Items.Add(addr, Bitmap.FromFile("g1.gif"), cms_SetProxy);
                else
                    fruitContextMenuStrip.Items.Add(addr, Bitmap.FromFile("g2.gif"), cms_SetProxy);
            }
            cBoxProxyList.SelectedItem = obj;
        }
    }
}
