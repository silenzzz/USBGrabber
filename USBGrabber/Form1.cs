using System;
using System.IO;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace USBGrabber
{
    public partial class MainForm : Form
    {
        private ManagementEventWatcher watcher = new ManagementEventWatcher();
        private WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2");

        private Thread copyThread;

        public MainForm()
        {
            InitializeComponent();
            SetNotifyIcon();
            this.ShowInTaskbar = false;

            watcher.EventArrived += new EventArrivedEventHandler(UsbPlugged);
            watcher.Query = query;

            watcher.Start();
        }

        private void UsbPlugged(object sender, EventArgs e)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    //listBoxUSB.Items.Add(string.Format("({0}) {1}", drive.Name.Replace("\\", ""), drive.VolumeLabel));
                    CopyData(drive);
                }
            }
            watcher.WaitForNextEvent();
        }

        private void CopyData(DriveInfo drive)
        {
            Invoke(new Action(() =>
            {
                toolStripButtonCount.Text = "0 / 0";
                toolStripProgressBar.Value = 0;
                listBoxUSB.Items.Clear();
                toolStripButtonCurrent.Text = "";
            }));
            copyThread = new Thread(() =>
            {
                try
                {
                    string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + "_dump");
                    Directory.CreateDirectory(tempDirectory);

                    string[] files = Directory.GetFiles(drive.RootDirectory.Name, "*.*", SearchOption.AllDirectories);
                    listBoxUSB.Invoke(new Action(() =>
                    {
                        toolStripProgressBar.Maximum = files.Length;
                        toolStripButtonCount.Text = $"0 / {files.Length}";
                    }));

                    int i = 1;
                    foreach (string srcPath in files)
                    {
                        string name = Path.GetFileName(srcPath);
                        File.Copy(srcPath, tempDirectory + "\\" + name, true);
                        listBoxUSB.Invoke(new Action(() =>
                        {
                            listBoxUSB.Items.Add($"{i}. {name}");
                            toolStripProgressBar.Increment(1);
                            toolStripButtonCount.Text = $"{i} / {files.Length}";
                            toolStripButtonCurrent.Text = name;
                        }));
                        i++;
                    }
                }
                catch (ThreadAbortException e)
                {
                    return;
                }
                catch (Exception e)
                {
                    //MessageBox.Show("ERROR WHILE COPYING");
                    //MessageBox.Show(e.Message);
                }
            });

            copyThread.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCopy();
        }

        private void toolStripButtonSTOP_Click(object sender, EventArgs e)
        {
            StopCopy();
        }

        private void StopCopy()
        {
            if (copyThread != null)
            {
                copyThread.Abort();
            }
        }

        private void SetNotifyIcon()
        {
            ContextMenu iconMenu = new ContextMenu();
            MenuItem openItem = new MenuItem("Show");
            MenuItem closeItem = new MenuItem("Exit");

            var handler = new EventHandler(OnClickIconMenuItem);
            openItem.Click += handler;
            closeItem.Click += handler;
            iconMenu.MenuItems.Add(openItem);
            iconMenu.MenuItems.Add(closeItem);

            notifyIcon.Text = "USBGrabber";
            notifyIcon.BalloonTipTitle = "USBGrabber";
            notifyIcon.BalloonTipText = "USBGrabber";
            notifyIcon.ContextMenu = iconMenu;
        }

        private void OnClickIconMenuItem(object sender, EventArgs e)
        {
            var item = sender as MenuItem;
            string text = item.Text;
            if (text.Equals("Exit")) {
                StopCopy();
                this.Close();
            } else if (text.Equals("Show"))
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
