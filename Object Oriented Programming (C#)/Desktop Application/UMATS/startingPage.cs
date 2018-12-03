using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using AForge.Video; //capture
using AForge.Video.DirectShow;//capture
using OnBarcode.Barcode.BarcodeScanner;//scan
using System.IO;//for create a folder

namespace UMATS
{
    public partial class startingPage : Form
    {
        public startingPage()
        {
            InitializeComponent();
        }

        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam1;
        private String[] ReadBarcodeFromFile(string _Filepath)
        {
            String[] barcodes = OnBarcode.Barcode.BarcodeScanner.BarcodeScanner.Scan(_Filepath, OnBarcode.Barcode.BarcodeScanner.BarcodeType.Code39);
            return barcodes;
            //MessageBox.Show(barcodes);
        }
        private void camera_Start()
        {
            //This part will start the camera
            cam1 = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
            cam1.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam1.Start();
            //This part will start the camera
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Make the folder initially
            if (!Directory.Exists("Scan"))
            {
                Directory.CreateDirectory("Scan");
            }
            //Make the folder end
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                comboBox1.Items.Add(VideoCaptureDevice.Name);
            }
            comboBox1.SelectedIndex = 0;
            camera_Start();

        }



        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bit;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string currentPath = Directory.GetCurrentDirectory();
            string currentPathcomplete = currentPath + "\\Scan" + "\\1.jpg";
            pictureBox1.Image.Save(currentPathcomplete); //save the capture image at given location
            if (cam1.IsRunning) //after capturing the camera will stop.
            {
                cam1.Stop();
            }

            try
            {
                //The scan part
                startingPage f2_obj1 = new startingPage(); //object for this scan part
                string image_sTring = currentPathcomplete; //call the image
                string[] get_the_value = f2_obj1.ReadBarcodeFromFile(image_sTring); //image processing

                string msg = ""; //empty string to fill it later
                foreach (string val in get_the_value)
                    msg += val;
                string sub_msg = msg.Substring(1); //I am diselecting first letter.
                MessageBox.Show(sub_msg);
                aScan obj_aScan = new aScan();
                obj_aScan.aScanFunc(sub_msg);
                camera_Start(); //it will restart the camera
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please hold the Barcode properly", "Can't detect barcode by scan operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                camera_Start();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string currentPath = Directory.GetCurrentDirectory();
            string currentPathcomplete = currentPath + "\\Scan" + "\\1.jpg";
            pictureBox1.Image.Save(currentPathcomplete);

            if (cam1.IsRunning)
            {
                cam1.Stop();
            }

            try
            {
                //The scan part
                startingPage f2_obj = new startingPage();
                string image_sTring = currentPathcomplete;
                string[] get_the_value = f2_obj.ReadBarcodeFromFile(image_sTring);
                //$$$$$$$$$$$$$$$
                string msg = "";
                foreach (string val in get_the_value)
                    msg += val;
                string sub_msg = msg.Substring(1); //I am diselecting first letter.
                MessageBox.Show(sub_msg);
                //Form1 f1_value_PASS = new Form1(sub_msg);
                //$$$$$$$$$$$$$$$
                //The scan part
                //open the new form
                this.Hide();
                nextPage f1_For_show = new nextPage(sub_msg);
                f1_For_show.ShowDialog();
                //this.Close();
                //open the new form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please hold the Barcode properly", "Can't detect barcode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                camera_Start();
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
