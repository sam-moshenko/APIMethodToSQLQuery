using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace WindowsFormsApplication2
{
    
    public partial class Form1 : Form
    {
        List<String> inputParametr = new List<String>();
        List<String> outputSqlColumn = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            inputParametr.Add(txtInputParam.Text);
            outputSqlColumn.Add(txtSQLColumn.Text);
            listInputs.Items.Add(String.Format("{0}   ->    {1}", txtInputParam.Text, txtSQLColumn.Text));
        }

        private void listInputs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listInputs.SelectedIndex == -1)
                return;
            txtInputParam.Text = inputParametr[listInputs.SelectedIndex];
            txtSQLColumn.Text = outputSqlColumn[listInputs.SelectedIndex];
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            inputParametr[listInputs.SelectedIndex] = txtInputParam.Text;
            outputSqlColumn[listInputs.SelectedIndex] = txtSQLColumn.Text;
            listInputs.Items.Insert(listInputs.SelectedIndex, String.Format("{0}   ->    {1}", txtInputParam.Text, txtSQLColumn.Text));
            listInputs.Items.RemoveAt(listInputs.SelectedIndex + 1);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            inputParametr.RemoveAt(listInputs.SelectedIndex);
            outputSqlColumn.RemoveAt(listInputs.SelectedIndex);
            listInputs.Items.RemoveAt(listInputs.SelectedIndex);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            inputParametr.Clear();
            outputSqlColumn.Clear();
            listInputs.Items.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var client = new RestClient(txtURL.Text);
            var method = Method.POST;
            if (comboMethod.Text == "GET") {
                method = Method.GET;
            }
            var request = new RestRequest(method);
            client.ExecuteAsync(request, response =>
            {
                if (response.ErrorMessage != null) {
                    MessageBox.Show(response.ErrorMessage);
                    return;
                }
                generateSQL(response.Content);

            });
        }

        private void generateSQL(String content)
        {
            var json = JsonConvert.DeserializeObject(content);
            JArray array = null;
            if (json is JObject)
                array = findArray((JObject)json);
            else if (json is JArray)
                array = (JArray)json;
            
            if (array == null)
            {
                MessageBox.Show("Invalid response, Probably it is not in JSON format or does not contain array");
                return;
            }

            var strings = generateStrings(array);

            var thread = new Thread(() => saveFile(strings));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private JArray findArray(JObject content)
        {
            foreach (KeyValuePair<String, JToken> p in content)
            {
                if (p.Value is JArray)
                    return (JArray)p.Value;
                else if (p.Value is JObject)
                {
                    JArray array = findArray((JObject)p.Value);
                    if (array != null)
                    {
                        return array;
                    }
                }
            }
            return null;
        }

        private List<String> generateStrings(JArray array)
        {
            var result = new List<String>();

            foreach (JToken t in array)
            {
                if (t is JObject)
                {
                    String query = "insert into " + txtTableName.Text + "(";
                    String keys = "";
                    String values = "";
                    foreach (KeyValuePair<String, JToken> p in (JObject)t)
                    {
                        var index = inputParametr.IndexOf(p.Key);
                        if (index == -1)
                            continue;
                        var correspondingSQLName = outputSqlColumn[index];
                        keys += correspondingSQLName + ", ";
                        values += "\'" + p.Value + "\'" + ", ";
                    }
                    //just cutting the extra ", " generated
                    keys = keys.Remove(keys.Length - 2);
                    values = values.Remove(values.Length - 2);
                    

                    query += keys + ")\n";
                    query += "values (" + values + ")\n";
                    result.Add(query);
                }
            }

            return result;
        }

        private void saveFile(List<String> strings)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "SQL file|*.sql";
            dialog.Title = "Save the generated SQL";
            dialog.ShowDialog();

            if (dialog.FileName != "") {
                System.IO.File.WriteAllLines(dialog.FileName, strings);
            }
        }
    }
}
