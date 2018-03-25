using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProjectFolderCore.Menu;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProjectFolderCore.Submission {

    public abstract class FolderObject : FileSystemObject, IMenuProvider {

        public delegate void FolderStatusChanged(FolderObject f);
        public event FolderStatusChanged OnFolderStatusChanged;

        protected DirectoryInfo _Folder;

        public MenuProvider Menu {
            get {
                return this.GetMenu();
            }
        }

        protected virtual MenuProvider GetMenu() {
            MenuProvider m = new MenuProvider();
            //m.Add("view", "View Folder Contents", Properties.Resources.Icon_SearchFolder, true, null, new System.EventHandler(this.ViewHandler));
            return m;
        }

        protected virtual void ViewHandler(object sender, System.EventArgs e) {
            this.View();
        }

        public virtual bool View() {
            Process p = new Process();
            p.StartInfo.FileName = "explorer.exe";
            p.StartInfo.Arguments = ("\""
                        + (this.Folder.FullName + "\""));
            return p.Start();
        }


        public FolderObject(DirectoryInfo Instance) {
            _Folder = Instance;
        }

        public DirectoryInfo Folder {
            get {
                return _Folder;
            }
        }

        public override string ToString() {
            return _Folder.Name;
        }


    }
}
