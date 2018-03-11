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
using Microsoft.Win32;

namespace EditMyPC
{
    public partial class Form_main : Form
    {
        [DllImport("shell32.dll", EntryPoint = "ExtractIconEx", CharSet = CharSet.Auto)]
        public static extern int ExtractIconEx([MarshalAs(UnmanagedType.LPTStr)] string file, int index, out IntPtr largeIconHandle, out IntPtr smallIconHandle, int icons);

        [DllImport("User32.dll")]
        private static extern bool DestroyIcon(IntPtr hIcon);

        private static readonly string shell32_path = Environment.SystemDirectory + @"\imageres.dll";




        private static readonly CheckBox[] checkbox_details = new CheckBox[7];
        private static readonly string[] path_keys = new string[]
        {
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\",
            @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\"
        };

        private static readonly Dictionary<string, string[]> name_keys = new Dictionary<string, string[]>()
        {
            {"Desktop",  new string[]{"{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}"}},
            {"Documents", new string[]{"{A8CDFF1C-4878-43be-B5FD-F8091C1C60D0}", "{d3162b92-9365-467a-956b-92703aca08af}"}},
            {"Downloads", new string[]{"{374DE290-123F-4565-9164-39C4925E467B}", "{088e3905-0323-4b02-9826-5d99428e115f}"}},
            {"Music", new string[]{"{1CF1260C-4DD0-4ebb-811F-33C572699FDE}", "{3dfdf296-dbec-4fb4-81d1-6a3438bcf4de}"}},
            {"Pictures", new string[]{"{3ADD1653-EB32-4cb0-BBD7-DFA0ABB5ACCA}", "{24ad3ad4-a569-4530-98e1-ab02f9417aa8}"}},
            {"Videos", new string[]{"{A0953C92-50DC-43bf-BE83-3742FED03C9C}", "{f86fa3ab-70d2-4fc7-9c99-fcbf05467f3a}"}},
            {"3D Objects", new string[]{"{0DB7E03F-FC29-4DC6-9020-FF41B59E513A}"}}
        };

        private static readonly Dictionary<string, int> icon_indexes = new Dictionary<string, int>()
        {
            {"Desktop",  174},
            {"Documents", 107},
            {"Downloads", 175},
            {"Music", 103},
            {"Pictures", 108},
            {"Videos", 178},
            {"3D Objects", 187}
        };









        public Form_main()
        {
            InitializeComponent();
            tableLayoutPanel_details.Controls.CopyTo(checkbox_details, 0);
            init_all_checkbox();
        }

        private void init_all_checkbox()
        {
            foreach (CheckBox cur in checkbox_details)
            {
                bool exists = true;
                foreach (string path in path_keys)
                    foreach (string name in name_keys[cur.Text])
                    {
                        if (Registry.LocalMachine.OpenSubKey(path + name, false) == null)
                            exists = false;
                    }
                cur.Image = GetIconImage(icon_indexes[cur.Text], true).ToBitmap();
                cur.Checked = exists;
            }

        }



        private void button_apply_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cur in checkbox_details)
                foreach (string path in path_keys)
                    foreach (string name in name_keys[cur.Text])
                    {
                        if (cur.Checked)
                            Registry.LocalMachine.CreateSubKey(path + name, true);
                        else
                            Registry.LocalMachine.DeleteSubKeyTree(path + name, false);
                    }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }







        private int handling_allcheck = -1;
        private object handling_allcheck_lock = new object();
        private void checkBox_All_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox == null)
                return;
            
            ++handling_allcheck;

            if (checkBox.CheckState != CheckState.Indeterminate)
                foreach (CheckBox cur in checkbox_details)
                    cur.CheckState = checkBox.CheckState;
            
            --handling_allcheck;
            
        }

        private void checkBox_Details_CheckedChanged(object sender, EventArgs e)
        {
            lock (handling_allcheck_lock)
            {
                if (handling_allcheck != -1)
                    return;

                ++handling_allcheck;

                CheckBox checkBox = sender as CheckBox;
                if (checkBox == null)
                    return;

                CheckState checkState_to_be = checkBox.CheckState;
                foreach (CheckBox cur in checkbox_details)
                    if (cur.CheckState != checkState_to_be)
                        checkState_to_be = CheckState.Indeterminate;


                checkBox_All.CheckState = checkState_to_be;
            
                --handling_allcheck;
            }
        }






















        public static Icon GetIconImage(int icon_index, bool big_icon)
        {
            
            try
            {
                Icon[] icons = new Icon[2];
                IntPtr largeIconHandle = IntPtr.Zero;
                IntPtr smallIconHandle = IntPtr.Zero;
                ExtractIconEx(shell32_path, icon_index, out largeIconHandle, out smallIconHandle, 1);
                icons[0] = (Icon)Icon.FromHandle(largeIconHandle).Clone();
                icons[1] = (Icon)Icon.FromHandle(smallIconHandle).Clone();
                DestroyIcon(largeIconHandle);
                DestroyIcon(smallIconHandle);

                if (big_icon)
                {
                    return icons[0];
                }
                else
                {
                    return icons[1];
                }
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}
