using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectFolderCore.FileTypes {
    public class CSharpFile : TextFile {
        public override int ImageIndex {
            get {
                return ImageIndices.CsFile;
            }
        }
        new static public bool IsType(FileInfo f) {
            return f.Extension.ToLower().Equals(".cs");
        }

        public CSharpFile(FileInfo f) : base(f) {

        }
    }
}
