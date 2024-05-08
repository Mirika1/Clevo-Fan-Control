using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace OptimizedClevoFan
{
    public partial class AppWindow : Form
    {
        // The path to the key where Windows looks for startup applications
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        const string APP_NAME = "OptimizedClevoFan";

        private Timer timer;

        private FanController fanController;

        private List<FanInfo> fanInfos;

        private bool firstRun = true;

        private FanController LoadConfiguration()
        {
            string confJson = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "configuration.json");
            FanController fanController = JsonConvert.DeserializeObject<FanController>(confJson);

            foreach (Fan fan in fanController.fans)
            {
                fan.SetFanControl(fanController.GetFanControl());
                fan.SetNumberOfValuesForAvgTemperature(fanController.numberOfValuesForAvgTemperature);
            }

            return fanController;
        }

        private FanController LoadConfiguration2()
        {
            string conf2Json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "configuration2.json");
            FanController fanController = JsonConvert.DeserializeObject<FanController>(conf2Json);

            foreach (Fan fan in fanController.fans)
            {
                fan.SetFanControl(fanController.GetFanControl());
                fan.SetNumberOfValuesForAvgTemperature(fanController.numberOfValuesForAvgTemperature);
            }

            return fanController;
        }

        private FanController LoadConfiguration3()
        {
            string conf3Json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "configuration3.json");
            FanController fanController = JsonConvert.DeserializeObject<FanController>(conf3Json);

            foreach (Fan fan in fanController.fans)
            {
                fan.SetFanControl(fanController.GetFanControl());
                fan.SetNumberOfValuesForAvgTemperature(fanController.numberOfValuesForAvgTemperature);
            }

            return fanController;
        }

        private FanController LoadConfiguration4()
        {
            string conf4Json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "configuration4.json");
            FanController fanController = JsonConvert.DeserializeObject<FanController>(conf4Json);

            foreach (Fan fan in fanController.fans)
            {
                fan.SetFanControl(fanController.GetFanControl());
                fan.SetNumberOfValuesForAvgTemperature(fanController.numberOfValuesForAvgTemperature);
            }

            return fanController;
        }

        private FanController LoadConfiguration5()
        {
            string conf5Json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "configuration5.json");
            FanController fanController = JsonConvert.DeserializeObject<FanController>(conf5Json);

            foreach (Fan fan in fanController.fans)
            {
                fan.SetFanControl(fanController.GetFanControl());
                fan.SetNumberOfValuesForAvgTemperature(fanController.numberOfValuesForAvgTemperature);
            }

            return fanController;
        }

        private FanController LoadConfiguration6()
        {
            string conf6Json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "configuration6.json");
            FanController fanController = JsonConvert.DeserializeObject<FanController>(conf6Json);

            foreach (Fan fan in fanController.fans)
            {
                fan.SetFanControl(fanController.GetFanControl());
                fan.SetNumberOfValuesForAvgTemperature(fanController.numberOfValuesForAvgTemperature);
            }

            return fanController;
        }
        private void SaveConfiguration(FanController fanController)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "configuration.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, fanController);
            }
        }

        private void SaveConfiguration2(FanController fanController)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "configuration2.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, fanController);
            }
        }

        private void SaveConfiguration3(FanController fanController)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "configuration3.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, fanController);
            }
        }

        private void SaveConfiguration4(FanController fanController)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "configuration4.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, fanController);
            }
        }

        private void SaveConfiguration5(FanController fanController)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "configuration5.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, fanController);
            }
        }

        private void SaveConfiguration6(FanController fanController)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "configuration6.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, fanController);
            }
        }
        public AppWindow()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.Default;
            this.SystemTrayIcon.Icon = Properties.Resources.Default;

            this.Text = "Clevo Fan Control";
            this.SystemTrayIcon.Text = this.Text;
            this.SystemTrayIcon.Visible = true;

            // Modify the right-click menu of your system tray icon here
            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add("Open", ContextMenuOpen);
            menu.MenuItems.Add("Restart", ContextMenuRestart);
            menu.MenuItems.Add("Exit", ContextMenuExit);
            menu.MenuItems.Add("-");
            menu.MenuItems.Add("Preset 1", ContextMenuPreset1);
            menu.MenuItems.Add("Preset 2", ContextMenuPreset2);
            menu.MenuItems.Add("Preset 3", ContextMenuPreset3);
            menu.MenuItems.Add("Preset 4", ContextMenuPreset4);
            menu.MenuItems.Add("Preset 5", ContextMenuPreset5);
            menu.MenuItems.Add("Preset 6", ContextMenuPreset6);
            this.SystemTrayIcon.ContextMenu = menu;

            this.FormClosing += WindowClosing;

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Check to see the current state (running at startup or not)
            if (rkApp.GetValue(APP_NAME) == null)
                checkBoxStartWithWindows.Checked = false;
            else
            {
                checkBoxStartWithWindows.Checked = true;

                // sleep during 20 seconds so it lets Clevo Control Center start...
                // Kinda horrible solution, but it works in my case
                //System.Threading.Thread.Sleep(20000);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////
            // Create & init fan controller
            try
            {
                this.fanController = this.LoadConfiguration();
            }
            catch (Exception ex)
            {
                this.fanController = new FanController();
                this.fanController.LoadDefaults();
            }

            // Create timer for updating fan RPMs and so on
            timer = new Timer { Interval = fanController.updateFanStep };
            timer.Tick += new EventHandler(CheckFansTick);
            timer.Start();

            ///////////////////////////////////////////////////////////////////////////////////////////////
            // Add infos
            this.step.Text = this.fanController.updateFanStep.ToString() + "ms";

            fanInfos = new List<FanInfo>();
            foreach (Fan fan in this.fanController.fans)
            {
                FanInfo fanInfo = new FanInfo(fan);
                this.panelFanInfos.Controls.Add(fanInfo);
                this.fanInfos.Add(fanInfo);
            }

            // Start minimized
            this.WindowState = FormWindowState.Minimized;
        }

        public void CheckFansTick(object sender, EventArgs e)
        {
            if (sender == timer)
            {
                // Ugly trick to start minimized in task tray
                if (firstRun)
                {
                    this.Hide();
                    firstRun = false;
                }

                this.fanController.DoUpdate(this.offsetTrackBar.Value);

                foreach (FanInfo fanInfo in this.fanInfos)
                    fanInfo.UpdateInfos();
            }
        }

        private void SystemTrayIconDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.Show();
                //this.CenterToScreen();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void offsetTrackBar_Scroll(object sender, EventArgs e)
        {
            this.offsetValue.Text = this.offsetTrackBar.Value.ToString() + "%";
        }

        private void checkBoxStartWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStartWithWindows.Checked)
                rkApp.SetValue(APP_NAME, Application.ExecutablePath);
            else
                rkApp.DeleteValue(APP_NAME, false);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            savePresets.Show(Cursor.Position);
        }

        private void ExitApplication()
        {
            timer.Stop();

            this.fanController.Finish();

            this.SystemTrayIcon.Visible = false;
            Application.Exit();
            Environment.Exit(0);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void ContextMenuExit(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void WindowClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ContextMenuOpen(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.Show();
                //this.CenterToScreen();
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void ContextMenuRestart(object sender, EventArgs e)
        {
            Application.Restart();
			Environment.Exit(0);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click_1(object sender, EventArgs e)
        {
            fanModes.Show(Cursor.Position);

        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void Preset_1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fanController = LoadConfiguration();
            this.Controls.Clear();
            this.InitializeComponent();
            fanInfos = new List<FanInfo>();
            foreach (Fan fan in this.fanController.fans)
            {
                FanInfo fanInfo = new FanInfo(fan);
                this.panelFanInfos.Controls.Add(fanInfo);
                this.fanInfos.Add(fanInfo);
            }
        }

        private void Preset_2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.fanController = LoadConfiguration2();
            this.Controls.Clear();
            this.InitializeComponent();
            fanInfos = new List<FanInfo>();
            foreach (Fan fan in this.fanController.fans)
            {
                FanInfo fanInfo = new FanInfo(fan);
                this.panelFanInfos.Controls.Add(fanInfo);
                this.fanInfos.Add(fanInfo);
            }
        }

        private void Preset_3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.fanController = LoadConfiguration3();
            this.Controls.Clear();
            this.InitializeComponent();
            fanInfos = new List<FanInfo>();
            foreach (Fan fan in this.fanController.fans)
            {
                FanInfo fanInfo = new FanInfo(fan);
                this.panelFanInfos.Controls.Add(fanInfo);
                this.fanInfos.Add(fanInfo);
            }
        }

        private void Preset_4ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.fanController = LoadConfiguration4();
            this.Controls.Clear();
            this.InitializeComponent();
            fanInfos = new List<FanInfo>();
            foreach (Fan fan in this.fanController.fans)
            {
                FanInfo fanInfo = new FanInfo(fan);
                this.panelFanInfos.Controls.Add(fanInfo);
                this.fanInfos.Add(fanInfo);
            }
        }

        private void Preset_5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fanController = LoadConfiguration5();
            this.Controls.Clear();
            this.InitializeComponent();
            fanInfos = new List<FanInfo>();
            foreach (Fan fan in this.fanController.fans)
            {
                FanInfo fanInfo = new FanInfo(fan);
                this.panelFanInfos.Controls.Add(fanInfo);
                this.fanInfos.Add(fanInfo);
            }
        }

        private void Preset_6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fanController = LoadConfiguration6();
            this.Controls.Clear();
            this.InitializeComponent();
            fanInfos = new List<FanInfo>();
            foreach (Fan fan in this.fanController.fans)
            {
                FanInfo fanInfo = new FanInfo(fan);
                this.panelFanInfos.Controls.Add(fanInfo);
                this.fanInfos.Add(fanInfo);
            }
        }

        private void ContextMenuPreset1(object sender, EventArgs e)
        {
            this.fanController = LoadConfiguration();
            this.Controls.Clear();
            this.InitializeComponent();
            fanInfos = new List<FanInfo>();
            foreach (Fan fan in this.fanController.fans)
            {
                FanInfo fanInfo = new FanInfo(fan);
                this.panelFanInfos.Controls.Add(fanInfo);
                this.fanInfos.Add(fanInfo);
            }
        }

        private void ContextMenuPreset2(object sender, EventArgs e)
        {
            this.fanController = LoadConfiguration2();
            this.Controls.Clear();
            this.InitializeComponent();
            fanInfos = new List<FanInfo>();
            foreach (Fan fan in this.fanController.fans)
            {
                FanInfo fanInfo = new FanInfo(fan);
                this.panelFanInfos.Controls.Add(fanInfo);
                this.fanInfos.Add(fanInfo);
            }
        }

        private void ContextMenuPreset3(object sender, EventArgs e)
        {
            this.fanController = LoadConfiguration3();
            this.Controls.Clear();
            this.InitializeComponent();
            fanInfos = new List<FanInfo>();
            foreach (Fan fan in this.fanController.fans)
            {
                FanInfo fanInfo = new FanInfo(fan);
                this.panelFanInfos.Controls.Add(fanInfo);
                this.fanInfos.Add(fanInfo);
            }
        }

        private void ContextMenuPreset4(object sender, EventArgs e)
        {
            this.fanController = LoadConfiguration4();
            this.Controls.Clear();
            this.InitializeComponent();
            fanInfos = new List<FanInfo>();
            foreach (Fan fan in this.fanController.fans)
            {
                FanInfo fanInfo = new FanInfo(fan);
                this.panelFanInfos.Controls.Add(fanInfo);
                this.fanInfos.Add(fanInfo);
            }
        }

        private void ContextMenuPreset5(object sender, EventArgs e)
        {
            this.fanController = LoadConfiguration5();
            this.Controls.Clear();
            this.InitializeComponent();
            fanInfos = new List<FanInfo>();
            foreach (Fan fan in this.fanController.fans)
            {
                FanInfo fanInfo = new FanInfo(fan);
                this.panelFanInfos.Controls.Add(fanInfo);
                this.fanInfos.Add(fanInfo);
            }
        }

        private void ContextMenuPreset6(object sender, EventArgs e)
        {
            this.fanController = LoadConfiguration6();
            this.Controls.Clear();
            this.InitializeComponent();
            fanInfos = new List<FanInfo>();
            foreach (Fan fan in this.fanController.fans)
            {
                FanInfo fanInfo = new FanInfo(fan);
                this.panelFanInfos.Controls.Add(fanInfo);
                this.fanInfos.Add(fanInfo);
            }
        }

        private void preset1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveConfiguration(this.fanController);
        }

        private void preset2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveConfiguration2(this.fanController);
        }

        private void preset3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveConfiguration3(this.fanController);
        }

        private void preset4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveConfiguration4(this.fanController);
        }

        private void preset5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveConfiguration5(this.fanController);
        }

        private void preset6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveConfiguration6(this.fanController);
        }
    }
}
