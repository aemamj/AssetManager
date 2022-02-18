using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManager
{
    public partial class CopyTools : MetroForm
    {
        public CopyTools()
        {

            InitializeComponent();

        }
        string _mainpath;
        private void CopyTest_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var List = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(openFileDialog1.FileName));
            folderBrowserDialog1.ShowDialog();
            _mainpath = folderBrowserDialog1.SelectedPath;
            CopyList(List);
            //File.Copy(@"G:\Alavi3d-android\AssetBundles\Android\alavi\center\model\alavi.center1.model.door", @"C:\Directory2\Alavi3d-android\AssetBundles\Android\alavi\center\model\alavi.center1.model.door");
        }
        async void CopyList(List<string> _list)
        {
            //_mainpath = @"G:\Alavi3d-android\AssetBundles\Android\alavi\center\";
            string _pathSave = @"C:\Directory2";
            

            if(!Directory.Exists(_pathSave))
            {
                Directory.CreateDirectory(@"C:\Directory2");
            }
            foreach(var file in _list)
            {
                int index = file.LastIndexOf(@"/");
                int index2 = file.IndexOf(@"/");
                string _AddPatch;

                if (file.Contains(@"/"))
                    _AddPatch =@"\" + file.Remove(index, file.Length-index).Replace(@"/", @"\");
                else
                    _AddPatch = "";

                file.Replace(@"/", @"\");
                file.Replace(@".highpack", @".smallpack");
                file.Replace(@".lowpack", @".smallpack");
                Console.WriteLine(_AddPatch);
                Console.WriteLine(_pathSave);
                Console.WriteLine(file);
                if (!Directory.Exists(_pathSave+ _AddPatch))
                    Directory.CreateDirectory(_pathSave + _AddPatch);
                File.Copy(_mainpath + @"\" + file, _pathSave+ @"\"+ file);
                File.Copy(_mainpath + @"\" + file+ ".manifest", _pathSave+ @"\"+ file + ".manifest");
                Console.WriteLine(_mainpath + file);
                Console.WriteLine(_pathSave + file);
            }
        }
    }
}