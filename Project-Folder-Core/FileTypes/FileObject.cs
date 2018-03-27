using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace ProjectFolderCore.FileTypes {
    public class FileObject {
        private FileInfo _file;

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
    }


}
