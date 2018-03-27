using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectFolderCore.FileTypes {
    public class TextFile: FileObject {

        public override int ImageIndex {
            get {
                return ImageIndices.TextFile;
            }
        }
        new static public bool IsType(FileInfo f) {
            return f.Extension.ToLower().Equals(".txt");
        }

        public TextFile(FileInfo f) : base(f) {

        }

    }
}
