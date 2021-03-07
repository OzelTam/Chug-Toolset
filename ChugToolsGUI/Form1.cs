using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChugToolset.Lib.NameCheck;
namespace ChugToolsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Getby_URL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Getby_URL.Text.StartsWith("Attribute"))
            {
                address_item1_URL.SetPlaceholder("Attribute name. 'placeholder, href, etc...'");
                address_item2_URL.SetPlaceholder("Attribute Value.");
            }
            else if (Getby_URL.Text.StartsWith("Class"))
            {
                address_item1_URL.SetPlaceholder("Class Name.");
                address_item2_URL.SetPlaceholder("Attribute to get. 'text, href, etc...'");
            }
            else if (Getby_URL.Text.StartsWith("ID"))
            {
                address_item1_URL.SetPlaceholder("Id.");
                address_item2_URL.SetPlaceholder("Attribute to get. 'text, href, etc...'");
            }
            else if (Getby_URL.Text.StartsWith("RegEx"))
            {
                address_item1_URL.SetPlaceholder("Expression. ");
                address_item2_URL.SetPlaceholder("Group index.");
            }
            else if (Getby_URL.Text.StartsWith("XPath"))
            {
                address_item1_URL.SetPlaceholder("XPath.");
                address_item2_URL.SetPlaceholder("Attribute to get. 'text, href, etc...'");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLoadPackPath.TextField().ReadOnly = true;
            txtLoadedCheckPackName.TextField().ReadOnly = true;
        }


        public Dictionary<string, Finder> findersCreate_URL = new Dictionary<string, Finder>();
        private void btnCreateInfoReq_URL_Click(object sender, EventArgs e)
        {
            if (findersCreate_URL.Count(x => x.Key == FinderTitle_URL.GetText()) > 0)
            {
                MessageBox.Show("There is already an info request with the same title.", "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (ValidateGetBy_URL())
            {
                Finder fndr = null;
                if (Getby_URL.Text.StartsWith("Attribute"))
                {
                    fndr = new Finder(Finder.GetBy.AttributeValue, (address_item1_URL.GetText(), address_item2_URL.GetText()));
                }
                else if (Getby_URL.Text.StartsWith("Class"))
                {
                    fndr = new Finder(Finder.GetBy.ClassName, (address_item1_URL.GetText(), address_item2_URL.GetText()));

                }
                else if (Getby_URL.Text.StartsWith("ID"))
                {
                    fndr = new Finder(Finder.GetBy.Id, (address_item1_URL.GetText(), address_item2_URL.GetText()));

                }
                else if (Getby_URL.Text.StartsWith("RegEx"))
                {
                    fndr = new Finder(Finder.GetBy.RegEx, (address_item1_URL.GetText(), address_item2_URL.GetText()));

                }
                else if (Getby_URL.Text.StartsWith("XPath"))
                {
                    fndr = new Finder(Finder.GetBy.XPath, (address_item1_URL.GetText(), address_item2_URL.GetText()));

                }
                if (fndr == null)
                {
                    MessageBox.Show("Please select an selector method. 'Get By'", "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                findersCreate_URL.Add(FinderTitle_URL.GetText(), fndr);
            }
            else
            {
                MessageBox.Show("Please enter valid info request arguments.", "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            syncInfoReqList();


        }

        private bool ValidateGetBy_URL()
        {
            if (address_item1_URL.GetText() == address_item1_URL.placeHolder || address_item2_URL.GetText() == address_item2_URL.placeHolder)
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(Getby_URL.Text) || String.IsNullOrWhiteSpace(address_item1_URL.GetText()) || String.IsNullOrWhiteSpace(address_item2_URL.GetText()))
            {
                return false;
            }
            if (Getby_URL.Text.StartsWith("RegEx"))
            {
                try
                {
                    var reg = new Regex(address_item1_URL.GetText());
                    var groupIndex = Convert.ToInt32(address_item2_URL.GetText());
                    if (address_item1_URL.GetText().Count<char>(x => x == '(') < groupIndex + 1)
                    {
                        return false;
                    }
                }
                catch { return false; }
            }

            return true;
        }
        private void syncInfoReqList()
        {
            listInfoReq_URL.Items.Clear();
            foreach (var i in findersCreate_URL)
            {
                listInfoReq_URL.Items.Add(i.Key);

            }
        }
        private void btn_RemoveInfoReq_Click(object sender, EventArgs e)
        {
            if (listInfoReq_URL.SelectedIndex > -1)
            {
                try
                {
                    var delKey = listInfoReq_URL.SelectedItem.ToString();
                    findersCreate_URL.Where(x => x.Key == delKey).ToList();
                    findersCreate_URL.Remove(delKey);
                    syncInfoReqList();
                }
                catch { }

            }
        }

        private void listInfoReq_URL_DoubleClick(object sender, EventArgs e)
        {
            if (listInfoReq_URL.SelectedIndex > -1)
            {
                try
                {
                    var getKey = listInfoReq_URL.SelectedItem.ToString();
                    var FinderItem = findersCreate_URL.Where(x => x.Key == getKey).ToList()[0];
                    MessageBox.Show($"Title: {getKey} \n" +
                        $"GetBy: {FinderItem.Value.GetElementBy.ToString()} \n" +
                        $"Address.1 : {FinderItem.Value.Address.Item1} \n" +
                        $"Address.2 : {FinderItem.Value.Address.Item2} \n", 
                        getKey,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch { }

            }
        }


        private List<IChecker> newCheckerList = new List<IChecker>();
        private void SyncNewCheckersList()
        {
            listNewCheckers.Items.Clear();
            foreach(var i in newCheckerList)
            {
                listNewCheckers.Items.Add(i.CheckerTitle);
            }
        }
        private void btnCreateChecker_URL_Click(object sender, EventArgs e)
        {
            if (newCheckerList.Count(x=> x.CheckerTitle == Checkertitle_URL.GetText())>0) {
                MessageBox.Show($"There is a checker with the same name. Please change the checker title. '{Checkertitle_URL.GetText()}'","upsi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if(Checkertitle_URL.GetText() == Checkertitle_URL.placeHolder|| UrlTextBox_URL.placeHolder == UrlTextBox_URL.GetText())
            {
                MessageBox.Show($"Please enter a valid URL/Checker Name", "upsi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var newUrlChecker = new UrlCheck(Checkertitle_URL.GetText(), UrlTextBox_URL.GetText(), findersCreate_URL);
                newCheckerList.Add(newUrlChecker);

            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message, "upsi.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         SyncNewCheckersList();
        }

        private void btnCreatePack_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNewPackName.GetText())|| txtNewPackName.GetText() == txtNewPackName.placeHolder)
            {
                MessageBox.Show("Please give a valid name to the Checker Pack.", "upsi.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "cpck|*.cpck";
            sfd.Title = $"Save Checker Pack. '{txtNewPackName.GetText()}'";
            sfd.FileName = txtNewPackName.GetText();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                var newPack = new CheckPack(txtNewPackName.GetText(), newCheckerList);
                NameCheckFunction.SavePack(newPack,sfd.FileName);
            }
        }

        private void removeNewChecker_Click(object sender, EventArgs e)
        {
            var selectedIndex = listNewCheckers.SelectedIndex;
            if (selectedIndex > -1)
            {
                var checker = newCheckerList.Where(x => x.CheckerTitle == listNewCheckers.Items[selectedIndex].ToString()).ToList()[0];
                var mesRes = MessageBox.Show($"This action will delete the '{checker.CheckerTitle}' checker. \n Are you sure about that", "Attention.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(mesRes == DialogResult.Yes)
                {
                    newCheckerList.Remove(checker);
                }
            }
            SyncNewCheckersList();
        }
        //***********************************************************

        private CheckPack LoadedCheckPack = null;
        private void LoadCheckPack(CheckPack pack)
        {
            LoadedCheckPack = pack;
            txtLoadedCheckPackName.SetText(pack.PackName);
            SyncLoadedCheckers();
            btnStartNameCheck.Enabled = true;

        }
        private void SyncLoadedCheckers()
        {
            listLoadedCheckers.Items.Clear();
            foreach(var i in LoadedCheckPack.GetCheckers())
            {
                listLoadedCheckers.Items.Add(i.CheckerTitle,true);
            }
        }


        private void btnNameCheckLoadPack_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "cpck|*.cpck";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fname = openFileDialog.FileName;
                txtLoadPackPath.SetText(fname);
                var pck = NameCheckFunction.LoadPack(fname);
                LoadCheckPack(pck);


                foreach (IChecker checker in LoadedCheckPack.GetCheckers())
                {
                    lwCheckResults.Columns.Add($"{checker.CheckerTitle} URL");
                    lwCheckResults.Columns.Add($"{checker.CheckerTitle} Status");
                    foreach (var info in checker.GetInfo)
                    {
                        lwCheckResults.Columns.Add($"{checker.CheckerTitle} - {info.Key}");
                    }
                }
                lwCheckResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);//Syncs Listview columns and Checker Pack
            }



        }

        private void btnStartNameCheck_Click(object sender, EventArgs e)
        {

            lwCheckResults.Items.Clear();
            lwCheckResults.Columns.Clear();
            lwCheckResults.Columns.Add("Username");
            var ActiveCheckers = LoadedCheckPack.GetCheckers().Where(x => listLoadedCheckers.CheckedItems.Contains(x.CheckerTitle)).ToList();
            foreach (IChecker checker in ActiveCheckers)
            {
                lwCheckResults.Columns.Add($"{checker.CheckerTitle} URL");
                lwCheckResults.Columns.Add($"{checker.CheckerTitle} Status");
                foreach (var info in checker.GetInfo)
                {
                    lwCheckResults.Columns.Add($"{checker.CheckerTitle} - {info.Key}");
                }
              

            }   lwCheckResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);//Syncs Listview columns and Checker Pack
            var ActiveChecekerTitles = ActiveCheckers.Select(x => x.CheckerTitle).ToArray();
            var usernamesToCheck = rtbCheckUsernames.Text.Split("\n");
            LoadedCheckPack.userProfiles = new System.Collections.ObjectModel.ObservableCollection<UserProfile>();
            LoadedCheckPack.userProfiles.CollectionChanged += UserProfiles_CollectionChanged;
            Task.Run(() => LoadedCheckPack.CheckUsername(usernamesToCheck, ActiveChecekerTitles));
           



        }

        private void UserProfiles_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            foreach(UserProfile usr in e.NewItems)
            {
                var lwi = new ListViewItem(usr.Username);
                foreach (var pr in usr.ProfileResults)
                {
                    lwi.SubItems.Add(pr.Url);
                    lwi.SubItems.Add(pr.Status);
                    foreach (var val in pr.Results)
                    {
                        lwi.SubItems.Add(val.Value);
                    }
                    
                }
                if (lwCheckResults.InvokeRequired)
                {
                    lwCheckResults.Invoke((MethodInvoker)delegate{ 
                      lwCheckResults.Items.Add(lwi);
                      lwCheckResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    });
                }
              
            }
        }

        private Dictionary<string,object> GridToDictionary(DataGridView dgw)
        {
            var result = new Dictionary<string, object>();

         // foreach (DataGridViewRow row in dgw.Rows)
         // {
         //     result.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value);
         // }

            return result;
        }


        private async  void btnTest_API_Click(object sender, EventArgs e)
        {
          try
          {

          
                ApiRequestOptions CheckerTest = null;
                if(method_API.SelectedIndex == 0)
                {
                    CheckerTest = new ApiRequestOptions(RestSharp.Method.POST);
                }
                else if(method_API.SelectedIndex == 1)
                {
                    CheckerTest = new ApiRequestOptions(RestSharp.Method.GET);
                }
                else { MessageBox.Show("Please select a method 'GET/POST'", "hey", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                var CheckerAPI = new ApiCheck("TestCheck",txtCheckerURL_API.GetText(),new Dictionary<string, string>(), CheckerTest);
                var Result = await NameCheckFunction.SendReqAsync(CheckerAPI, txtTestUserName_API.GetText());
                jsonTree.SetObjectAsJson(Result);
                txtNodePathAPI.TextField().ReadOnly = true;
            }
             catch (Exception ex) {
                 MessageBox.Show(ex.Message, "Upsi", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void jsonTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
        var PathText = e.Node.FullPath;
            var pathes = PathText.Split("\\");
            PathText = "";
            foreach (var itm in pathes)
            {
                PathText +="\\"  +itm.Split(" ")[0];
            }
            txtNodePathAPI.SetText( PathText.Replace("\\ROOT\\", "") );
        }

        private void btnRemoveInfoReqAPI_Click(object sender, EventArgs e)
        {
            if(listInfoReqAPI.SelectedIndex > -1)
            {
                listInfoReqAPI.Items.RemoveAt(listInfoReqAPI.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an Item to remove", "upsi",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnAddInfoReqAPI_Click(object sender, EventArgs e)
        {
            var title = txtValNameAPI.GetText();
            var path = txtNodePathAPI.GetText();
            if (!String.IsNullOrWhiteSpace(title) && title != txtValNameAPI.placeHolder && !String.IsNullOrWhiteSpace(path)&&path != txtNodePathAPI.placeHolder)
            {
                listInfoReqAPI.Items.Add(title + ":|:" + path);
            }
            else
            {
                MessageBox.Show("Please enter a valid name and path", "upsi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnCreateCheckerAPI_Click(object sender, EventArgs e)
        {
            var chName = txtCheckerName_API.GetText();
            var url = txtCheckerURL_API.GetText();


            if (newCheckerList.Count(x => x.CheckerTitle == chName) > 0)
            {
                MessageBox.Show($"There is a checker with the same name. Please change the checker title. '{chName}'", "upsi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
          if(chName == txtCheckerName_API.placeHolder|| url == txtCheckerURL_API.placeHolder)
            {
                MessageBox.Show($"Please enter a valid CheckerName/URL.", "upsi",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
            Dictionary<string, string> infReq = new Dictionary<string, string>();
            foreach(var itm in listInfoReqAPI.Items)
            {
                var reqName = itm.ToString().Split(":|:")[0];
                var reqPath = itm.ToString().Split(":|:")[1];
                infReq.Add(reqName, reqPath);
            }
            ApiRequestOptions aro;
            if (method_API.SelectedIndex == 0)
            {
                aro = new ApiRequestOptions( RestSharp.Method.POST);
            }
            else
            {
                aro = new ApiRequestOptions(RestSharp.Method.GET);
            }

          
            ApiCheck newApiCheck = new ApiCheck(chName,url,infReq, aro );
            newCheckerList.Add(newApiCheck);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "uspi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         

            SyncNewCheckersList();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
