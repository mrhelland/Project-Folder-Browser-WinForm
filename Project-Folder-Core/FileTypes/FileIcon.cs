using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace ProjectFolderCore.FileTypes {
    public class FileIcon {

        private Icon _icon;
        private string _extension;
        public Icon Icon {
            get { return _icon; }
        }
        public string Extension {
            get { return _extension; }
        }

        public FileIcon(string extension, Icon icon) {
            _extension = extension;
            _icon = icon;
        }

        public bool IsFileType(FileInfo f) {
            return f.Extension.Equals(_extension);
        }

        public bool IsExtension(string extension) {
            return extension.Equals(_extension);
        }

        public override string ToString() {
            return _extension;
        }

    }
}
