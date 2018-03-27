using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProjectFolderCore.Actions;

namespace ProjectFolderCore.FileTypes {
    public class HtmlFile : TextFile, Actions.IBrowse {
        public override int ImageIndex {
            get {
                return ImageIndices.HtmlFile;
            }
        }
        new static public bool IsType(FileInfo f) {
            return (f.Extension.ToLower().Equals(".html") || f.Extension.ToLower().Equals(".htm"));
        }

        void IBrowse.Browse() {
            throw new NotImplementedException();
        }

        void IBrowse.Edit() {
            throw new NotImplementedException();
        }

        void IBrowse.View() {
            throw new NotImplementedException();
        }

        void IBrowse.FolderBrowse() {
            throw new NotImplementedException();
        }

        public HtmlFile(FileInfo f) : base(f) {

        }


    }
}
