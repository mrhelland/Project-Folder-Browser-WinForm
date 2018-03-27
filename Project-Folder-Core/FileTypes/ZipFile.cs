using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProjectFolderCore.Actions;

namespace ProjectFolderCore.FileTypes {
    public class ZipFile : FileObject {
        public override int ImageIndex {
            get {
                return ImageIndices.ZipFile;
            }
        }
        new static public bool IsType(FileInfo f) {
            return f.Extension.ToLower().Equals(".zip");
        }

        public ZipFile(FileInfo f) : base(f) {

        }
    }
}
