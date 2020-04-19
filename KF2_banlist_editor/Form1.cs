using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace KF2_banlist_editor
{
    public partial class Form1 : Form
    {
        bool serverListLoad = false;
        bool banListLoad = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string password = passwordTextBox.Text;

            if (!serverListLoad)
            {
                MessageBox.Show("HTML file did not loaded", "HTML file ERROR");

                return;
            }

            else if (!banListLoad)
            {
                MessageBox.Show("JSON file did not loaded", "JSON file ERROR");

                return;
            }

            if (id.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please enter your ID or password.");

                return;
            }

            int count = 0;
            int max = banBox.Items.Count * serverList.Items.Count;

            Thread work = new Thread(()=>{
                for (int i = 0; i < serverList.Items.Count; i++)
                {
                    string url = serverList.Items[i].ToString();
                    
                    serverLabel.Text = url;
                    string token = "";
                    CookieContainer cookies = new CookieContainer();

                    //get session and certificate cookies
                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url + "/ServerAdmin/");
                    req.Credentials = CredentialCache.DefaultCredentials;
                    req.CookieContainer = cookies;
                    req.KeepAlive = true;

                    HttpWebResponse result = (HttpWebResponse)req.GetResponse();

                    if (result.StatusCode != HttpStatusCode.OK)
                    {
                        MessageBox.Show("LOGIN FAIL");

                        return;
                    }

                    using (Stream dataStream = result.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(dataStream);
                        string rawStr = reader.ReadToEnd();

                        var myDoc = new HtmlAgilityPack.HtmlDocument();
                        myDoc.LoadHtml(rawStr);

                        //get HTML login token
                        var nodes = myDoc.DocumentNode.SelectNodes("//input[@name='token']");
                        token = nodes[0].Attributes["value"].Value;
                    }

                    //sending login post
                    String postData = String.Format("token={0}&username={1}&password={2}&remember=1800", token, id, password);
                    cookies = PostSend(postData, url + "/ServerAdmin/", req.CookieContainer);

                    foreach (string user in banBox.Items)
                    {
                        count++;
                        progressBar.Value = (int)((double)count / max * 100);
                        //sending ban post
                        userLable.Text = user;
                        postData = String.Format("action=add&steamint64={0}uniqueid=", user);
                        cookies = PostSend(postData, url + "/ServerAdmin/policy/bans", req.CookieContainer);
                    }
                }
                MessageBox.Show("Complete Ban");
            });
            work.Start();
        }
        private CookieContainer PostSend(string postData, string url, CookieContainer cookies)
        {   
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.CookieContainer = cookies;
            req.Method = WebRequestMethods.Http.Post;
            req.KeepAlive = true;

            req.AllowAutoRedirect = true;
            req.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

            byte[] sendData = UTF8Encoding.UTF8.GetBytes(postData);
            req.ContentLength = sendData.Length;

            Stream requestStream = req.GetRequestStream();
            requestStream.Write(sendData, 0, sendData.Length);
            requestStream.Close();

            HttpWebResponse result = (HttpWebResponse)req.GetResponse();
            
            if(result.StatusCode == HttpStatusCode.OK)
            {
                using (Stream dataStream = result.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    string rawStr = reader.ReadToEnd();

                    var myDoc = new HtmlAgilityPack.HtmlDocument();
                    myDoc.LoadHtml(rawStr);
                }
            }

            return req.CookieContainer;
        }
        private void serverBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "html";
            openFile.Filter = "html file(*.html)|*.html";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                
                string filePath = openFile.FileName;
                using (StreamReader rdr = new StreamReader(filePath))
                {
                    string rawStr = rdr.ReadToEnd();

                    var myDoc = new HtmlAgilityPack.HtmlDocument();
                    myDoc.LoadHtml(rawStr);

                    var nodeList = myDoc.DocumentNode.SelectNodes("/html/body/div/div/form/select/option");

                    nodeList.RemoveAt(0);

                    foreach (var node in nodeList)
                    {
                        serverList.Items.Add(node.Attributes["value"].Value);
                    }
                }
                serverListLoad = true;
            }
        }

        private void banBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "json";
            openFile.Filter = "baned list(*.json)|*.json";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                
                string filePath = openFile.FileName;
                using (StreamReader rdr = new StreamReader(filePath))
                {
                    string rawStr = rdr.ReadToEnd();

                    JObject applyJObj = JObject.Parse(rawStr);

                    foreach (JToken item in applyJObj["bans"])
                    {
                        banBox.Items.Add(item["steamId64"].ToString());
                    }
                }
                banListLoad = true;
                
            }
        }
    }
}
