using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasetManager
{
    public partial class DatasetManager : Form
    {
        List<List<string>> data = new List<List<string>>();
        List<string> labels = new List<string>();

        string directoryPath = "";

        public DatasetManager()
        {
            InitializeComponent();
        }


        public void read_csvFile(string filePath, char separator, bool labelHeader)
        {
            string line;
            int counter = 0;
            bool dataStarts = false;
            string state = null;
            string type = null;
            
            // Read the file and display it line by line.
            System.IO.StreamReader file =
            new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                string[] newLine = line.Split(separator);
                if (state == null)
                {
                    state = newLine[0];
                    type = newLine[1];
                }
                else if (newLine[0] == "Date")
                    dataStarts = true;
                else if (dataStarts)
                {
                    List<string> sample = new List<string>();
                    sample.Add(state);
                    sample.Add(newLine[0].Substring(0, 4));
                    sample.Add(newLine[0].Substring(4));
                    sample.Add(newLine[1]);
                    /*
                    for (int i = 0; i < sample.Count; i++)
                    {
                        Console.WriteLine(sample[i]);
                    }*/
                    data.Add(sample); counter++;
                }

            }
            file.Close();

            System.Console.WriteLine("There were {0} lines.", counter);
        }

        private void loadDatasetFolderButton_Click(object sender, EventArgs e)
        {
            string folder;
            int filecount = 0;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                folder = fbd.SelectedPath;
                directoryPath = fbd.SelectedPath;
                string[] fileEntries = Directory.GetFiles(folder);
                filecount = fileEntries.Length;
                foreach (string fileName in fileEntries)
                    read_csvFile(fileName, ',', true);


                labels.Add("State");
                labels.Add("Year");
                labels.Add("Month");
                labels.Add(Path.GetFileName(folder));
            }


            Console.WriteLine("Lines gathered : " + data.Count);
            newNameTextBox.Text = Path.GetFileName(directoryPath);
            readyToExportlabel.Text = "READY TO EXPORT " + data.Count + " lines \r\n of " + filecount + "files";
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            
            write_csvFile();
        }


        private void Transform(List<string> oldLabels, List<string> newlabels)
        {
            for(int i = 1;i < data.Count;i++)
            {
                int index = oldLabels.IndexOf(data[i][0].ToString());
                data[i][0] = newlabels[index];
                
            }
            for (int i = 0; i < labels.Count; i++)
                Console.WriteLine(oldLabels[i] + "-->" + newlabels[i]);
        }

        public void write_csvFile()
        {
            //string[] lines = { "First line", "Second line", "Third line" };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            //System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);
            List<string> datasetTocsv = new List<string>();
            string lineLabels = labels[0];
            for (int j = 1; j < labels.Count; j++)
            lineLabels += ',' + labels[j];
            datasetTocsv.Add(lineLabels);
            for (int i = 0; i < data.Count; i++)
            {
                string line = data[i][0];
                for (int j = 1; j < data[i].Count; j++)
                    line += ',' + data[i][j];
                datasetTocsv.Add(line);
            }
            string[] readyToWrite = datasetTocsv.ToArray();

            System.IO.File.WriteAllLines(directoryPath + @"\" + newNameTextBox.Text + ".csv", readyToWrite);
            Console.WriteLine("Writting file at " + directoryPath + @"\" + newNameTextBox.Text + ".csv");
            generatedlabel.Text = "FILE GENERATED";
        }
    }
}
