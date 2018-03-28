using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Collections;


namespace ProjectFolderCore.FileTypes {
    public class FileIconCollection {

        private List<FileIcon> _icons;
        private ImageList _imagelist;
        public ImageList ImageList {
            get {
                return _imagelist;
            }
        }

        public FileIconCollection() {
            _icons = LoadIcons();
            _imagelist = BuildList(_icons.ToArray());
        }

        private ImageList BuildList(FileIcon[] icons) {
            ImageList images = new ImageList();
            foreach(FileIcon icon in icons) {
                images.Images.Add(icon.Extension, icon.Icon);
            }
            return images;
        }

        private List<FileIcon> LoadIcons() {
            List<FileIcon> icons = new List<FileIcon>();
            ResourceSet set = Icons.Icons.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            foreach (DictionaryEntry entry in set) {
                string key = entry.Key.ToString();
                Icon resource = (Icon)entry.Value;
                FileIcon temp;
                if (key.Equals("none") || key.Equals("unknown")) {
                    temp = new FileIcon(key, resource);
                }
                else {
                    temp = new FileIcon("." + key, resource);
                }
                icons.Add(temp);
            }
            return icons;
        }

        public Image GetFileIcon(FileInfo f) {
            return _imagelist.Images[f.Extension];   
        }

        public int GetFileIconIndex(FileInfo f) {
            return _imagelist.Images.IndexOfKey(f.Extension);
        }
    }
}
