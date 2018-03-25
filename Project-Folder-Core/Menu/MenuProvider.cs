using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectFolderCore.Menu {
    public class MenuProvider {

        private SortedList<string, ToolStripMenuItem> _MenuItems;
        private SortedList<string, ToolStripButton> _ButtonItems;

        public MenuProvider() {
            _MenuItems = new SortedList<string, ToolStripMenuItem>();
            _ButtonItems = new SortedList<string, ToolStripButton>();
        }

        public void Add(string Key, string MenuText, Icon MenuIcon, bool MenuEnabled, object MenuTag, EventHandler Handler) {
            ToolStripMenuItem mi = new ToolStripMenuItem();
            ToolStripButton btn = new ToolStripButton();
            mi.Text = MenuText;
            btn.Text = MenuText;
            btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            try {
                mi.Image = Bitmap.FromHicon(MenuIcon.Handle);
                btn.Image = mi.Image;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            mi.Enabled = MenuEnabled;
            btn.Enabled = MenuEnabled;
            mi.Click += Handler;
            btn.Click += Handler;
            _MenuItems.Add(Key, mi);
            _ButtonItems.Add(Key, btn);
        }

        public void SetEnabled(string Key, bool value) {
            _MenuItems[Key].Enabled = value;
            _ButtonItems[Key].Enabled = value;
        }

        public SortedList<string, ToolStripMenuItem> MenuItems {
            get {
                return _MenuItems;
            }
        }

        public SortedList<string, ToolStripButton> Buttons {
            get {
                return _ButtonItems;
            }
        }

        public bool Contains(string key) {
            return _MenuItems.ContainsKey(key);
        }
    }
}
