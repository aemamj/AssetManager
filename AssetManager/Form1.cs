using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Collections;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AssetManager
{
    public partial class AssetEditor : MetroForm
    {
        public static DataEditor AllData = new DataEditor();
        public Dictionary<string, DataAssetViwe> AllDataViwe =new Dictionary<string, DataAssetViwe>();
        public AssetEditor()
        {
            List<bool> A = new List<bool>();
            A.Add(true); A.Add(true); A.Add(true); A.Add(true); A.Add(true); A.Add(true); A.Add(true); A.Add(true);

            List<bool> b = new List<bool>();
            b.Add(true); b.Add(true); b.Add(true); b.Add(true); b.Add(false); b.Add(false); b.Add(false); b.Add(true); b.Add(true); b.Add(true);

            List<bool> c = new List<bool>();
            c.Add(false); c.Add(false); c.Add(false); c.Add(false); c.Add(false); c.Add(false); c.Add(false); c.Add(false); c.Add(false);

            //Console.WriteLine("  a  ");
            //Console.WriteLine("A All : " + A.All(x => false));
            //Console.WriteLine("A Any : " + A.Any(x => false));
            //Console.WriteLine("A TrueForAll : " + A.TrueForAll(x => false));
            //Console.WriteLine("A Contains :" + A.Contains(false));
            //Console.WriteLine("  b  ");
            //Console.WriteLine("B All : " + b.All(x => false));
            //Console.WriteLine("B Any : " + b.Any(x => false));
            //Console.WriteLine("B TrueForAll : " + b.TrueForAll(x => false));
            //Console.WriteLine("B Contains :" + b.Contains(false));
            //Console.WriteLine("  c  ");
            //Console.WriteLine("C All : " + c.All(x => false));
            //Console.WriteLine("C Any : " + c.Any(x => false));
            //Console.WriteLine("C TrueForAll : " + c.TrueForAll(x => false));
            //Console.WriteLine("C Contains :" + c.Contains(false));

            //Console.WriteLine("  a  ");
            //Console.WriteLine("A All : " + A.All(x => true));
            //Console.WriteLine("A Any : " + A.Any(x => true));
            //Console.WriteLine("A TrueForAll : " + A.TrueForAll(x => true));
            //Console.WriteLine("A Contains :" + A.Contains(true));
            //Console.WriteLine("  b  ");
            //Console.WriteLine("B All : " + b.All(x => true));
            //Console.WriteLine("B Any : " + b.Any(x => true));
            //Console.WriteLine("B TrueForAll : " + b.TrueForAll(x => true));
            //Console.WriteLine("B Contains :" + b.Contains(true));
            //Console.WriteLine("  c  ");
            //Console.WriteLine("C All : " + c.All(x => true));
            //Console.WriteLine("C Any : " + c.Any(x => true));
            //Console.WriteLine("C TrueForAll : " + c.TrueForAll(x => true));
            //Console.WriteLine("C Contains :" + c.Contains(true));
            InitializeComponent();
        }

        async void AssetEditor_Load(object sender, EventArgs e)
        {
            load();
            await Task.Delay(10);
        }

        async void load()
        {
            try
            {
                string path = "";
                if (Program.Android)
                    path = @"c:\AssetNewAndroid.json";
                else
                    path = @"c:\AssetNewIOS.json";
                if (File.Exists(path))
                {
                    Console.WriteLine("A-1:" + "here");

                    Assetmanager DataList = new Assetmanager();

                    if (openFileDialog.FileName == "")
                        DataList = JsonConvert.DeserializeObject<Assetmanager>(File.ReadAllText(path));
                    else
                        DataList = JsonConvert.DeserializeObject<Assetmanager>(File.ReadAllText(openFileDialog.FileName));

                    label1.Text = "Update Number : " + DataList.UpdateNumber;
                    TxtBoxPath.Text = openFileDialog.FileName;
                    AllData.Number = DataList.Number;
                    AllData.UpdateNumber = DataList.UpdateNumber;
                    int _n = 0;
                    if (!ChkUpdate.Checked)
                        AllDataViwe.Clear();
                    else
                        _n = AllDataViwe.Count;
                    if (!ChBoxLoad.Checked && folderBrowserDialog.SelectedPath != "")
                    {


                        string _path = folderBrowserDialog.SelectedPath;
                        List<DataAssetViwe> Files = await GetFiles(_path);
                        foreach (var file in Files)
                        {

                            if (AllDataViwe.ContainsKey(file.Name))
                            {
                                Console.WriteLine("b-1:" + "here");


                                if (AllDataViwe[file.Name].modification != file.modification)
                                {
                                    AllDataViwe[file.Name].Version++;
                                    AllDataViwe[file.Name].Size = file.Size;
                                    AllDataViwe[file.Name].modification = file.modification;
                                    if(ChkCopyUpdate.Checked)
                                    {
                                        string _pathSave = _path + @"\"+ AllDataViwe[file.Name].Version;

                                        if (!Directory.Exists(_pathSave))
                                        {
                                            Directory.CreateDirectory(_pathSave);
                                        }

                                        int index = file.Name.LastIndexOf(@"/");
                                        int index2 = file.Name.IndexOf(@"/");
                                        string _AddPatch;

                                        if (file.Name.Contains(@"/"))
                                            _AddPatch = @"\" + file.Name.Remove(index, file.Name.Length - index).Replace(@"/", @"\");
                                        else
                                            _AddPatch = "";

                                        file.Name.Replace(@"/", @"\");

                                        if (!Directory.Exists(_pathSave + _AddPatch))
                                            Directory.CreateDirectory(_pathSave + _AddPatch);
                                        File.Copy(_path + @"\" + file.Name, _pathSave + @"\" + file.Name);
                                        if(!file.Name.Contains("json"))
                                            File.Copy(_path + @"\" + file.Name + ".manifest", _pathSave + @"\" + file.Name + ".manifest");

                                        
                                    }
                                }
                                continue;
                            }
                            else
                            {

                                string _pathSave = "";
                                if (ChkCopyUpdate.Checked)
                                {
                                    if (AllDataViwe.ContainsKey(file.Name))
                                        _pathSave = _path + @"\" + AllDataViwe[file.Name].Version;
                                    else
                                        _pathSave = _path + @"\" + 0;
                                    if (!Directory.Exists(_pathSave))
                                    {
                                        Console.WriteLine("C-3:" + "here");

                                        Directory.CreateDirectory(_pathSave);
                                    }


                                    int index = file.Name.LastIndexOf(@"/");
                                    int index2 = file.Name.IndexOf(@"/");
                                    string _AddPatch;

                                    if (file.Name.Contains(@"/"))
                                        _AddPatch = @"\" + file.Name.Remove(index, file.Name.Length - index).Replace(@"/", @"\");
                                    else
                                        _AddPatch = "";

                                    file.Name.Replace(@"/", @"\");


                                    if (!Directory.Exists(_pathSave + _AddPatch))
                                        Directory.CreateDirectory(_pathSave + _AddPatch);
                                    File.Copy(_path + @"\" + file.Name, _pathSave + @"\" + file.Name);
                                    if (!file.Name.Contains("json"))
                                        File.Copy(_path + @"\" + file.Name + ".manifest", _pathSave + @"\" + file + ".manifest");


                                }
                            }
                            DataAssetViwe _d = new DataAssetViwe();
                            _d.Number = _n;
                            _n++;
                            _d.Version = file.Version;
                            _d.Size = file.Size;
                            _d.Name = file.Name;
                            _d.modification = file.modification;
                            AllDataViwe.Add(file.Name, _d);
                        }
                        dataGridView1.DataSource = AllDataViwe.Values.ToList();
                    }
                    else
                    {

                        foreach (KeyValuePair<string, Datamain> i in DataList.Assetbundle)
                        {
                            if (AllDataViwe.ContainsKey(i.Key))
                            {

                                continue;
                            }
                            
                            DataAssetViwe _d = new DataAssetViwe();
                            _d.Number = _n;
                            _n++;
                            _d.Version = i.Value.Version;
                            _d.Size = i.Value.Size;
                            _d.Name = i.Key;
                            _d.modification = i.Value.modification;
                            AllDataViwe.Add(i.Key, _d);
                        }

                        dataGridView1.DataSource = AllDataViwe.Values.ToList();
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error : " + e.Message , "Error" );
                System.Windows.Forms.MessageBox.Show("Adress : " + e.StackTrace , "Error" );
            }
        }


        async void save()
        {
            Assetmanager DataList = new Assetmanager();
            DataList.Number = AllDataViwe.Count;
            DataList.UpdateNumber = AllData.UpdateNumber;            
            foreach (var i in AllDataViwe)
            {
                Datamain _d = new Datamain();
                _d.Version = i.Value.Version;
                _d.Size = i.Value.Size;
                _d.modification = i.Value.modification;
                DataList.Assetbundle.Add(i.Key, _d);
            }
            await Task.Delay(1);
            if (!ChkSaveAs.Checked)
            {
                if (Program.Android)
                    File.WriteAllText(@"c:\AssetNewAndroid.json", JsonConvert.SerializeObject(DataList));
                else
                    File.WriteAllText(@"c:\AssetNewIOS.json", JsonConvert.SerializeObject(DataList));

            }
            else if (saveFileDialog.FileName != "")
                File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(DataList));
        }


        async void filesave()
        {
            DataEditor DataList = new DataEditor();
            DataList.Number = AllDataViwe.Count;
            DataList.UpdateNumber = AllData.UpdateNumber;
            foreach (var i in AllDataViwe)
            {
                DataAsset _d = new DataAsset();
                _d.Version = i.Value.Version;
                _d.Size = i.Value.Size;
                DataList.Assetbundle.Add(i.Key, _d);
            }
            await Task.Delay(1);

            if (saveFileDialog.FileName == "")
                File.WriteAllText(@"c:\AssetNew2.json", JsonConvert.SerializeObject(DataList));
            else
                File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(DataList));
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (!ChkSaveBase.Checked)
            {
                saveFileDialog.ShowDialog();
                filesave();
            }
            else
            {
                if(ChkSaveAs.Checked)
                    saveFileDialog.ShowDialog();
                save();
            }
        }

        async void Search_Click(object sender, EventArgs e)
        {
            Search.Text = "";
        }
        async void Search_OnValueChanged(object sender, EventArgs e)
        {
            var values = AllDataViwe.Where(key => key.Key.Contains(Search.Text));
            List<DataAssetViwe> data = new List<DataAssetViwe>();
            foreach (KeyValuePair<string, DataAssetViwe> pair in values)
            {
                data.Add(pair.Value);
            }
            await Task.Delay(1);
            dataGridView1.DataSource = data;
        }

        private void BtnPlusUpdate_Click(object sender, EventArgs e)
        {
            AllData.UpdateNumber++;
            label1.Text = "Update Number : " + AllData.UpdateNumber;
        }

        private void BtnMinesUpdate_Click(object sender, EventArgs e)
        {
            AllData.UpdateNumber--;
            label1.Text = "Update Number : " + AllData.UpdateNumber;
        }

        public static async Task<List<DataAssetViwe>> GetFiles(string _path)
        {
            string[] files = Directory.GetFiles(_path, "*.*", SearchOption.AllDirectories);
            List<DataAssetViwe> Files = new List<DataAssetViwe>();
            int _num = 0;
            foreach (string file in files)
            {
                if (file.Contains(".manifest"))
                    continue;
                DataAssetViwe _Dta = new DataAssetViwe();
                FileInfo f = new FileInfo(file);
                _Dta.Name = file.Remove(0, _path.Length+1).Replace(@"\",@"/");
                _Dta.Size = f.Length/ 1000000f; //(f.Length / (float)1048576);
                _Dta.Number = _num;
                _Dta.modification = File.GetLastWriteTime(file);
                Files.Add(_Dta);
                _num++;                
            }
            await Task.Delay(1);
            return Files;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!ChBoxLoad.Checked)
            {
                TxtBoxPath.Text = folderBrowserDialog.SelectedPath;
                folderBrowserDialog.ShowDialog();
                TxtBoxPath.Text = folderBrowserDialog.SelectedPath;
                System.Windows.Forms.MessageBox.Show("Load: ", "");
            }
            else
            {
                openFileDialog.ShowDialog();
            }
            load();
        }

        private void BtnUpAllVersion_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, DataAssetViwe> pair in AllDataViwe)
            {
                pair.Value.Version++;
            }
            dataGridView1.DataSource = AllDataViwe.Values.ToList();
        }

        private void BtnDownAllVersion_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, DataAssetViwe> pair in AllDataViwe)
            {
                pair.Value.Version--;
            }
            dataGridView1.DataSource = AllDataViwe.Values.ToList();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, DataAssetViwe> pair in AllDataViwe)
            {
                pair.Value.Version = 0;
            }
            dataGridView1.DataSource = AllDataViwe.Values.ToList();
        }
    }

    public class DataEditor
    {
        public int UpdateNumber;
        public int Number;
        public Dictionary<string,DataAsset> Assetbundle = new Dictionary<string,DataAsset>();
    }
    public class DataAsset
    {
        public int Version { get; set; }
        public float Size { get; set; }
    }

    public class Assetmanager
    {
        public int UpdateNumber;
        public int Number;
        public Dictionary<string, Datamain> Assetbundle = new Dictionary<string, Datamain>();
    }
    public class Datamain
    {
        public int Version { get; set; }
        public float Size { get; set; }
        public DateTime modification { set; get; }
    }
    public class DataAssetViwe
    {
        
        public int Number { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
        public float Size { get; set; }
        public DateTime modification { set; get; }
    }

}
