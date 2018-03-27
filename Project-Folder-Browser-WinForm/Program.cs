using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectFolderCore.FileTypes;
using System.IO;

namespace Project_Folder_Browser_WinForm {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Console.WriteLine("Creating txt Object");
            FileInfo a, b, c, d;
            a = new FileInfo("bob.txt");
            b = new FileInfo("sally.cs");
            c = new FileInfo("joe.docx");
            d = new FileInfo("landon.html");
            FileObject f1 = FileObject.Instantiate(a);
            FileObject f2 = FileObject.Instantiate(b);
            FileObject f3 = FileObject.Instantiate(c);
            FileObject f4 = FileObject.Instantiate(d);

            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());
            Console.WriteLine(f3.ToString());
            Console.WriteLine(f4.ToString());

        }
    }
}
