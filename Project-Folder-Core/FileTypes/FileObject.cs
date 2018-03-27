using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using ProjectFolderCore.Actions;
using System.Diagnostics;

namespace ProjectFolderCore.FileTypes {
    public class FileObject : IFileOpen {
        private FileInfo _file;
        private Process _process;

        public virtual int ImageIndex {
            get {
                return ImageIndices.Default;
            }
        }

        public static bool IsType(FileInfo f) {
            return false;
        }

        public FileObject(FileInfo f) {
            _file = f;
        }

        public static FileObject Instantiate(FileInfo f) {
            object[] args = { f };
            IEnumerable<Type> fileTypes = Assembly.GetExecutingAssembly().GetTypes().Where(x => typeof(FileObject).IsAssignableFrom(x));
            foreach(Type tempClass in fileTypes) {
                MethodInfo IsTypeMethod = tempClass.GetMethod("IsType");
                if ( (bool) IsTypeMethod.Invoke(null, args) ) {
                    return (FileObject)Activator.CreateInstance(tempClass, args);
                }
            }
            return new FileObject(f);
        }

        public bool Open() {
            if(_process != null) {
                try {
                    _process = Process.Start(_file.FullName);
                    return true;
                }
                catch {
                    return false;
                }
            }
            return false;
        }

        public bool Close() {
            if(_process != null) {
                _process.Kill();
                _process.WaitForExit();
                _process = null;
                return true;
            }
            return false;
        }
    }
}
