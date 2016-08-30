using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SixToFourExplorer_build
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private string version = "1.0.0 Beta Aug 30 2016";
        private string TempDirPath = Environment.GetEnvironmentVariable("TEMP") + @"\SeyoWork\6to4Explorer\";
        private string LogFilePath = Environment.GetEnvironmentVariable("TEMP") + @"\SeyoWork\6to4Explorer\log.dat";

        private void loadLog()
        {
            if (!Directory.Exists(TempDirPath))
            {
                Directory.CreateDirectory(TempDirPath);
            }
            if (File.Exists(LogFilePath))
            {
                StreamReader LogFile = new StreamReader(LogFilePath);
                while(!LogFile.EndOfStream)
                {
                    comboBoxWebAddr.Items.Add(LogFile.ReadLine());
                }
                LogFile.Close();
            }
            else
            {
                FileStream LogFileCreate = new FileStream(LogFilePath, FileMode.CreateNew, FileAccess.Write);
                LogFileCreate.Close();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            labelVer.Text += version;

            loadLog();

            comboBoxWebAddr.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxWebAddr.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void RunCMD(string command)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(command);
            p.StandardInput.WriteLine("exit");
            p.WaitForExit();
            p.Close();
        }

        private void buttonIPv4home_Click(object sender, EventArgs e)
        {
            string webAddr = "http://www.114la.com.sixxs.org";
            RunCMD("start " + webAddr);
        }

        private void buttonIPv6home_Click(object sender, EventArgs e)
        {
            string webAddr = "http://inc.ucas.ac.cn/home/download/2174";
            RunCMD("start " + webAddr);
        }

        private void buttonIPv6TVneu_Click(object sender, EventArgs e)
        {
            string webAddr = "http://hdtv.neu6.edu.cn";
            RunCMD("start " + webAddr);
        }

        private void buttonIPv6TVbyr_Click(object sender, EventArgs e)
        {
            string webAddr = "http://tv.byr.cn";
            RunCMD("start " + webAddr);
        }

        private void buttonNEU_Click(object sender, EventArgs e)
        {
            string webAddr = "http://bt.neu6.edu.cn";
            RunCMD("start " + webAddr);
        }

        private void buttonBYR_Click(object sender, EventArgs e)
        {
            string webAddr = "http://bt.byr.cn";
            RunCMD("start " + webAddr);
        }

        private void buttonVisit_Click(object sender, EventArgs e)
        {
            string webAddrSrc = comboBoxWebAddr.Text;
            string webAddr = webAddrSrc + ".sixxs.org";
            RunCMD("start " + webAddr);

            if(!comboBoxWebAddr.Items.Contains(webAddrSrc))
            {
                comboBoxWebAddr.Items.Add(webAddrSrc);

                StreamWriter LogFile = new StreamWriter(LogFilePath, true);
                LogFile.WriteLine(webAddrSrc);
                LogFile.Close();
            }
        }
    }
}
