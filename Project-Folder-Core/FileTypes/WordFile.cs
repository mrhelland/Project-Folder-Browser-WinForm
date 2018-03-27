using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProjectFolderCore.Actions;

namespace ProjectFolderCore.FileTypes {
    public class WordFile : FileObject {
        public override int ImageIndex {
            get {
                return ImageIndices.DocFile;
            }
        }
        new static public bool IsType(FileInfo f) {
            return (f.Extension.ToLower().Equals(".doc") || f.Extension.ToLower().Equals(".docx"));
        }

        public WordFile(FileInfo f) : base(f) {

        }
    }
}
