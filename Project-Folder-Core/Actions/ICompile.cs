using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolderCore.Actions {
    interface ICompile {
        void Compile();
        void Execute();
        void Edit();
        void ViewSource();
        void FolderBrowse();
    }
}
