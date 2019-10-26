using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SysmonCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            //pinfo.WindowStyle = ProcessWindowStyle.Hidden;
            //pinfo.CreateNoWindow = true;
            //pinfo.UseShellExecute = false;
            //pinfo.RedirectStandardOutput = true;
            InitializeComponent();
        }
        string dosya_yolu = Application.StartupPath + @"\" + "BekraSysmon.xml"; ProcessStartInfo pinfo = new ProcessStartInfo();
        Process proc = new Process();
        Thread th;string baslangic = "<Sysmon schemaversion=\"4.00\">\n  <HashAlgorithms>*</HashAlgorithms>\n  \t<EventFilter" +
    "ing>\n     <ProcessCreate onmatch=\"exclude\">\n";
        string bitis = "\t</ProcessCreate>\n\t<ProcessTerminate onmatch=\"include\" />\n\t<FileCreateTime onmatc" +
    "h=\"include\" />\n    <NetworkConnect onmatch=\"exclude\">   \n    </NetworkConnect>\n " +
    " </EventFiltering>\n</Sysmon>";
        private void createrr()
        {
            richTextBox1.AppendText(baslangic);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                richTextBox1.AppendText("\t \t<Image condition=\"contains\">" + listBox1.Items[i].ToString()+"</Image>\n");
            }
            richTextBox1.AppendText(bitis);
            folderrwite(richTextBox1.Text);
            webBrowser1.Navigate(dosya_yolu);
            webBrowser1.Show();
        }
        private void folderrwite(string text)
        {
          
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(text);
            sw.Flush();
            sw.Close();
            fs.Close();
            MessageBox.Show("Sysmon Dosya Aktarma İşlemi Tamamlandı.", "Ebubekir Bastama");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex !=-1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        private void xmlCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th = new Thread(createrr); th.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Hide();
        }
        private void sysmonİnstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th = new Thread(insfstall);th.Start();
        }
        void insfstall()
        {
            pinfo.FileName = Application.StartupPath + "\\Sysmon64.exe";
            pinfo.Arguments = "-i " + "BekraSysmon.xml";
            proc.StartInfo = pinfo;
            proc.Start();
        }
        void update()
        {
            pinfo.FileName = Application.StartupPath + "\\Sysmon64.exe";
            pinfo.Arguments ="-c "+ "BekraSysmon.xml";
            proc.StartInfo = pinfo;
            proc.Start();
        }
        private void sysmonUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th = new Thread(update); th.Start();
        }
    }
}
