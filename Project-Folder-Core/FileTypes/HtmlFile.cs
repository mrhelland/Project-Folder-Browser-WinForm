using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectFolderCore.FileTypes {
    public class HtmlFile : TextFile {
        public override int ImageIndex {
            get {
                return ImageIndices.HtmlFile;
            }
        }
        new static public bool IsType(FileInfo f) {
            return (f.Extension.ToLower().Equals(".html") || f.Extension.ToLower().Equals(".htm"));
        }

        public HtmlFile(FileInfo f) : base(f) {

        }
    }
}
