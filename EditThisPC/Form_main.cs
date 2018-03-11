using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Globalization;


namespace EditMyPC
{
    public partial class Form_main : Form
    {
        [DllImport("shell32", EntryPoint = "ExtractIconEx", CharSet = CharSet.Auto)]
        public static extern int ExtractIconEx([MarshalAs(UnmanagedType.LPTStr)] string file, int index,
            out IntPtr largeIconHandle, out IntPtr smallIconHandle, int icons);

        [DllImport("User32")]
        private static extern bool DestroyIcon(IntPtr hIcon);

        private static readonly string icons_path = Environment.SystemDirectory + @"\imageres.dll";
        


        private static readonly CheckBox[] c_Details = new CheckBox[7];

        // reg parent path
        private static readonly string[] path_keys = new string[]
        {
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\",
            @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\"
        };

        // reg key
        private static readonly Dictionary<string, string[]> name_keys = new Dictionary<string, string[]>()
        {
            {"c_Desktop",  new string[]{"{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}"}},
            {"c_Documents", new string[]{"{A8CDFF1C-4878-43be-B5FD-F8091C1C60D0}", "{d3162b92-9365-467a-956b-92703aca08af}"}},
            {"c_Downloads", new string[]{"{374DE290-123F-4565-9164-39C4925E467B}", "{088e3905-0323-4b02-9826-5d99428e115f}"}},
            {"c_Music", new string[]{"{1CF1260C-4DD0-4ebb-811F-33C572699FDE}", "{3dfdf296-dbec-4fb4-81d1-6a3438bcf4de}"}},
            {"c_Pictures", new string[]{"{3ADD1653-EB32-4cb0-BBD7-DFA0ABB5ACCA}", "{24ad3ad4-a569-4530-98e1-ab02f9417aa8}"}},
            {"c_Videos", new string[]{"{A0953C92-50DC-43bf-BE83-3742FED03C9C}", "{f86fa3ab-70d2-4fc7-9c99-fcbf05467f3a}"}},
            {"c_3D_Objects", new string[]{"{0DB7E03F-FC29-4DC6-9020-FF41B59E513A}"}}
        };

        // icon index
        private static readonly Dictionary<string, int> icon_indexes = new Dictionary<string, int>()
        {
            {"c_Desktop",  174},
            {"c_Documents", 107},
            {"c_Downloads", 175},
            {"c_Music", 103},
            {"c_Pictures", 108},
            {"c_Videos", 178},
            {"c_3D_Objects", 187}
        };









        public Form_main()
        {
            
            InitializeComponent();
            tableLayoutPanel_details.Controls.CopyTo(c_Details, 0);
            init_all_checkbox();
        }


        private void init_all_checkbox()
        {
            foreach (CheckBox cur in c_Details)
            {
                bool exists = true;
                foreach (string path in path_keys)
                    foreach (string name in name_keys[cur.Name])
                    {
                        if (Registry.LocalMachine.OpenSubKey(path + name, false) == null)
                            exists = false;
                    }
                cur.Image = GetIconImage(icon_indexes[cur.Name]).ToBitmap();
                cur.Checked = exists;
            }

        }

        
        private void button_apply_Click(object sender, EventArgs e)
        {
            // confirm user
            DialogResult ask_user = MessageBox.Show(
                "This operation simply edits registries corresponding to 'Folders' in 'This PC', " +
                "but I CANNOT assure you that there is no possibility of malfunction after done. " +
                "Make sure you have backups of your important data.\n\n" +
                "Are you sure you want to apply the modification right now?",
                "WARNING",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (ask_user == DialogResult.No)
                return;
            

            // set reg for each key name in each path
            foreach (CheckBox cur in c_Details)
                foreach (string path in path_keys)
                    foreach (string name in name_keys[cur.Name])
                    {
                        if (cur.Checked)
                            Registry.LocalMachine.CreateSubKey(path + name, true);
                        else
                            Registry.LocalMachine.DeleteSubKeyTree(path + name, false);
                    }


            // ask user to restart explorer.exe right now
            ask_user = MessageBox.Show(
                "Applying changes complete!\n\n" +
                "To be operated properly, you have to restart 'explorer.exe' processes. " +
                "But it will cause all windows of explorer to exit (Folder windows, process of copying files, etc...).\n\n" +
                "DON'T PRESS YES if you are doing some working at your desktop. " +
                "CLOSE ALL PROGRAM BEFORE YOU CONTINUE to avoid cases of sudden stop.\n\n" +
                "Are you sure you want to restart all 'explorer.exe' processes right now?",
                "WARNING",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (ask_user == DialogResult.No)
                return;

            Process[] proc_list = Process.GetProcessesByName("explorer");
            foreach (Process cur_proc in proc_list)
            {
                cur_proc.Kill();
                cur_proc.WaitForExit(5000);
                try
                {
                    // if explorer does not restart automatically, then start it manually
                    if (Process.GetProcessesByName("explorer").Length == 0)
                        cur_proc.Start();
                }
                catch(Exception)
                {

                }
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private int handling_allcheck = -1;
        private object handling_allcheck_lock = new object();
        private void c_All_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox == null)
                return;
            
            ++handling_allcheck;

            // if checkbox_all check state is changed, then modify all states of checkbox_details
            if (checkBox.CheckState != CheckState.Indeterminate)
                foreach (CheckBox cur in c_Details)
                    cur.CheckState = checkBox.CheckState;
            
            --handling_allcheck;
            
        }

        private void c_Details_CheckedChanged(object sender, EventArgs e)
        {
            lock (handling_allcheck_lock)
            {
                if (handling_allcheck != -1)
                    return;

                ++handling_allcheck;

                CheckBox checkBox = sender as CheckBox;
                if (checkBox == null)
                    return;


                // after check is finished, if all checkbox_details has the same states,
                // then change the check state of checkbox_all
                CheckState checkState_to_be = checkBox.CheckState;
                foreach (CheckBox cur in c_Details)
                    if (cur.CheckState != checkState_to_be)
                        checkState_to_be = CheckState.Indeterminate;


                c_All.CheckState = checkState_to_be;
            
                --handling_allcheck;
            }
        }





        


        public static Icon GetIconImage(int icon_index)
        {
            try
            {
                IntPtr largeIconHandle = IntPtr.Zero;
                IntPtr smallIconHandle = IntPtr.Zero;
                ExtractIconEx(icons_path, icon_index, out largeIconHandle, out smallIconHandle, 1);
                Icon icon = (Icon)Icon.FromHandle(largeIconHandle).Clone();
                DestroyIcon(largeIconHandle);
                DestroyIcon(smallIconHandle);

                return icon;
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}
