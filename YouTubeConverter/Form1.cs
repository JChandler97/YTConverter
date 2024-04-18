using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using MediaToolkit;
using MediaToolkit.Model;

namespace YouTubeConverter
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            LinkCheck(url);
        }

        private bool LinkCheck(string url)
        {
            if (url.Contains("youtube.com/watch?v=") || url.Contains("youtu.be/"))
            {
                labelCheck.ForeColor = Color.Green;
                labelCheck.MaximumSize = new Size(200, 0);
                labelCheck.Text = "Link works! Proceed to download!";
                labelCheck.Visible = true;
                DLButton.Visible = true;
                return true;
            }
            else
            {
                labelCheck.ForeColor = Color.Red;
                labelCheck.MaximumSize = new Size(100, 0);
                labelCheck.AutoSize = true;
                labelCheck.Text = "Link does not work! Please try again!";
                labelCheck.Visible = true;
                DLButton.Visible = false;
                return false;
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if(folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FPDisplay.Text = folder.SelectedPath;
            }
        }

        private void VideoDownload(string url)
        {
            string filePath = FPDisplay.Text;


                if (LinkCheck(url) == true)
                {
                    var youtube = YouTube.Default;
                    var video = youtube.GetVideo(url);

                //Checks to see if any invalid characters in the path name
                //Since the API doesn't know any better, we'll have to create a variable for the video title to do so
                var videoName = video.Title;

                foreach(char c in System.IO.Path.GetInvalidFileNameChars())
                    {
                        videoName = videoName.Replace(c, ' ');
                    }

                    //ew yuck below
                    string trueFileName = filePath + @"\" + videoName;
                        
                    // Just a test to check if filepath is actually good to go
                    //FPDisplay.Text = trueFileName;

                    byte[] bytes = video.GetBytes();

                    //Need to figure out what Stream() actually does and if it's useful for the actual program
                    //You may not even be able to even need Stream() regardless
                    //var stream = video.Stream();

                    File.WriteAllBytes(@trueFileName, video.GetBytes());

                        //Actual conversion HERE
                        var inputFile = new MediaFile { Filename = trueFileName };
                        var outputFile = new MediaFile { Filename = $"{trueFileName}.mp3" };

                    using(var engine = new Engine())
                    {
                        engine.GetMetadata(inputFile);
                        engine.Convert(inputFile, outputFile);
                    }

                //Cleanup and Confirmation
                File.Delete(Path.Combine(filePath, videoName));
                DialogResult result = MessageBox.Show("Your file is now complete!", "Confirmation");
                GC.Collect();
                }

                else
                {
                    DialogResult result = MessageBox.Show("Link does not work! Try again.", "Warning");
                }

        }

        private void DLButton_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            string filePath = FPDisplay.Text;

            if (Directory.Exists(filePath))
            {
                VideoDownload(url);
            }
            else
            {
                DialogResult result = MessageBox.Show("Please choose a valid location for your file.", "Warning");
            }

        }
    }
}
