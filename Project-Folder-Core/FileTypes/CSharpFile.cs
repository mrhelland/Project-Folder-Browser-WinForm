using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProjectFolderCore.Actions;

namespace ProjectFolderCore.FileTypes {
    public class CSharpFile : TextFile, ITextEdit, ICompile  {
        public override int ImageIndex {
            get {
                return ImageIndices.CsFile;
            }
        }
        new static public bool IsType(FileInfo f) {
            return f.Extension.ToLower().Equals(".cs");
        }

        void ITextEdit.View() {
            throw new NotImplementedException();
        }

        void ITextEdit.Edit() {
            throw new NotImplementedException();
        }

        void ITextEdit.FolderBrowse() {
            throw new NotImplementedException();
        }

        void ICompile.Compile() {
            throw new NotImplementedException();
        }

        void ICompile.Execute() {
            throw new NotImplementedException();
        }

        void ICompile.Edit() {
            throw new NotImplementedException();
        }

        void ICompile.View() {
            throw new NotImplementedException();
        }

        void ICompile.FolderBrowse() {
            throw new NotImplementedException();
        }

        public CSharpFile(FileInfo f) : base(f) {

        }
    }
}
