using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            tBrowse.Text = Defines.initial_path;
            file.InitialDirectory = Defines.initial_path;
            file.FileName = Defines.initial_path;
            //StreamReader myStream = new StreamReader(path);
            // var list = new List<Data>();
            loadGrammar();

            populateTables();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            formClear();
            input = tInput.Text + "$";
            tStack.AppendText("$ " + stiva + "\r\n");
            tString_Input.AppendText(input + "\r\n");

            while (input != "accept")
            {
                searchInActions();
                displacement();
                reduction(); 
                if (result == "false")
                {
                    tStack.AppendText("Nu a fost gasit");
                    tString_Input.AppendText("Nu a fost gasit");
                    break;
                }
                if (result == "accept")
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Find the data for each action in list of actions
        /// </summary>
        private void searchInActions()
        {
            foreach (Actiuni act in list_actiuni)
            {
                result = "false";
                if ((act.intStatusNumber.ToString() == stiva.Substring(stiva.Length - nr, nr) || act.intStatusNumber.ToString() == stiva.Substring(stiva.Length - nr - 1, nr))
                    && act.strTerminal == input.Substring(0, 1))
                {
                    result = act.strData;
                    tActiune.AppendText(result);
                    break;
                }
            }
        }

        ///<summary>
        ///Move data from input to stack
        /// </summary>  
        private void displacement()
        {
            if (result.IndexOf('d') != -1 && input.Length > 0)
            {
                stiva += input.Substring(0, 1) + result.Substring(1);
                input = input.Remove(0, 1);
                tString_Input.AppendText(input + "\r\n");
                nr = result.Substring(1).Length;
                tStack.AppendText("$ " + stiva + "\r\n");
                tActiune.AppendText("\r\n");
                stiva += " ";
            }
        }
        /// <summary>
        /// Reduce the production to it`s key
        /// </summary>
        private void reduction()
        {
            if (result.IndexOf('r') != -1 && input.Length > 0)
            {
                int index = int.Parse(result.Substring(1, 1)) - 1;
                string key = list[index].strKey;
                string productie = list[index].strProduction;
                count = stiva.Count(f => f == ' ');
                tActiune.AppendText(" => " + key + "+TS(");
                if (productie.Length > 1)
                {
                    stiva = stiva.Remove(stiva.Length - 2 * productie.Length - (nr-1) - 3);
                }
                else
                {
                    stiva = stiva.Remove(stiva.Length - 2 * productie.Length - nr);
                }
                stiva = stiva.Insert(stiva.Length, key);
                findInJump(key);
            }
        }
        /// <summary>
        /// Find the data from each jump in list of jumps
        /// </summary>
        /// <param name="key"></param>
        private void findInJump(string key)
        {
            foreach (Salt salt in list_salt)
            {
                if (salt.intStatusNumber.ToString() == stiva.Substring(stiva.Length - 2 - key.Length, 1) &&
                    salt.strData == stiva.Substring(stiva.Length - 1, 1))
                {
                    nr = salt.intData.ToString().Length;
                    stiva += salt.intData.ToString();
                    tStack.AppendText("$ " + stiva + "\r\n");
                    stiva += " ";
                    tActiune.AppendText(salt.intStatusNumber.ToString() + salt.strData + ") \r\n");
                    break;
                }
            }
            tString_Input.AppendText(input + "\r\n");
        }
        /// <summary>
        /// Populate lists with hardcode dataes
        /// </summary>
        private void populateTables()
        {
            list_actiuni.Add(new Actiuni(0, "a", "d5"));
            list_actiuni.Add(new Actiuni(0, "(", "d4"));
            list_actiuni.Add(new Actiuni(1, "+", "d6"));
            list_actiuni.Add(new Actiuni(1, "$", "accept"));
            list_actiuni.Add(new Actiuni(2, "+", "r2"));
            list_actiuni.Add(new Actiuni(2, "*", "d7"));
            list_actiuni.Add(new Actiuni(2, ")", "r2"));
            list_actiuni.Add(new Actiuni(2, "$", "r2"));
            list_actiuni.Add(new Actiuni(3, "+", "r4"));
            list_actiuni.Add(new Actiuni(3, "*", "r4"));
            list_actiuni.Add(new Actiuni(3, ")", "r4"));
            list_actiuni.Add(new Actiuni(3, "$", "r4"));
            list_actiuni.Add(new Actiuni(4, "a", "d5"));
            list_actiuni.Add(new Actiuni(4, "(", "d4"));
            list_actiuni.Add(new Actiuni(5, "+", "r6"));
            list_actiuni.Add(new Actiuni(5, "(", "d4"));
            list_actiuni.Add(new Actiuni(5, "*", "r6"));
            list_actiuni.Add(new Actiuni(5, ")", "r6"));
            list_actiuni.Add(new Actiuni(5, "$", "r6"));
            list_actiuni.Add(new Actiuni(6, "a", "d5"));
            list_actiuni.Add(new Actiuni(6, "(", "d4"));
            list_actiuni.Add(new Actiuni(7, "a", "d5"));
            list_actiuni.Add(new Actiuni(7, "(", "d4"));
            list_actiuni.Add(new Actiuni(8, "+", "d6"));
            list_actiuni.Add(new Actiuni(8, ")", "d11"));
            list_actiuni.Add(new Actiuni(9, "+", "r1"));
            list_actiuni.Add(new Actiuni(9, "*", "d7"));
            list_actiuni.Add(new Actiuni(9, ")", "r1"));
            list_actiuni.Add(new Actiuni(9, "$", "r1"));
            list_actiuni.Add(new Actiuni(10, "+", "r3"));
            list_actiuni.Add(new Actiuni(10, "*", "r3"));
            list_actiuni.Add(new Actiuni(10, ")", "r3"));
            list_actiuni.Add(new Actiuni(10, "$", "r3"));
            list_actiuni.Add(new Actiuni(11, "+", "r5"));
            list_actiuni.Add(new Actiuni(11, "*", "r5"));
            list_actiuni.Add(new Actiuni(11, ")", "r5"));
            list_actiuni.Add(new Actiuni(11, "$", "r5"));

            list_salt.Add(new Salt(0, "E", 1));
            list_salt.Add(new Salt(0, "T", 2));
            list_salt.Add(new Salt(0, "F", 3));
            list_salt.Add(new Salt(4, "E", 8));
            list_salt.Add(new Salt(4, "T", 2));
            list_salt.Add(new Salt(4, "F", 3));
            list_salt.Add(new Salt(6, "T", 9));
            list_salt.Add(new Salt(6, "F", 3));
            list_salt.Add(new Salt(7, "F", 10));
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            formClear();
        }

        private void formClear()
        {
            tActiune.Clear();
            tStack.Clear();
            tString_Input.Clear();
            stiva = "0 ";
            input = " $";
            ct = 0;
            nr = 1;
            text = "";
            r = false;
            result = "";
        }

        private void btnGramatica_Click(object sender, EventArgs e)
        {
           
            file.Title = "Inport new Grammar";
            file.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            if(file.ShowDialog() == DialogResult.OK)
            {
                tBrowse.Text = file.FileName;
                string safe_path = tBrowse.Text.Remove(tBrowse.Text.Length - file.SafeFileName.Length);
                file.InitialDirectory = safe_path;
                path = tBrowse.Text;
                tProd.Clear();
                text = "";
                list.Clear();
                loadGrammar();
            }

        }

        private void loadGrammar()
        {
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string[] readText = File.ReadAllLines(path);
                foreach (string s in readText)
                {
                    ct++;
                }
                sr.Close();
            }
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                text = sr.ReadLine();
                //tStiva.AppendText(text + "\r\n");
                text = sr.ReadLine();
                //tStiva.AppendText(text + "\r\n");
                text = sr.ReadLine();
                //tStiva.AppendText(text + "\r\n");
                text = sr.ReadToEnd().Replace(Environment.NewLine, ""); //elimina \r\n, simbolurile pentru newline
                string[] lines = text.Split(',');
                int par = 0;
                string aux1 = "", aux2;
                foreach (string s in lines)
                {
                    if (par % 2 == 0)
                    {
                        aux1 = s;
                        par++;
                    }
                    else
                    {
                        aux2 = s;
                        list.Add(new Data(aux1, aux2));
                        par++;

                    }
                }
                sr.Close();
            }
            foreach (Data s in list)
            {
                tProd.AppendText(String.Join("\r\n", s.strKey));
                tProd.AppendText(" -> ");
                tProd.AppendText(String.Join("\r\n", s.strProduction));
                tProd.AppendText("\r\n");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Process start = Process.Start(file.FileName);
            start.WaitForExit();
            tProd.Clear();
            text = "";
            list.Clear();
            loadGrammar();
            formClear();
        }

        //~~~~~~~~EOF~~~~~~~~~~
    }
}
