using System;
using System.Windows.Forms;

using CommonLib;
using IRSV_NetPro_SDK;

namespace IRSV_NetPro_SDK_CSharp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppInit();
            bool createNew;
            if (SysSdk.AloneApp)//只允许程序打开一个
            {
                var m = new System.Threading.Mutex(true, Application.ProductName, out createNew);
                if (createNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FormMain());
                }
                else
                {
                    MessageBox.Show("您已经运行了本系统程序!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
        }

        private static void AppInit()
        {
            SysSdk.systemType = SystemType.Complete;
            SysSdk.SDKInit();  //sdk初始化
        }
    }
}
