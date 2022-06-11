using AForge.Video;
using AForge.Video.DirectShow;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZXing;

namespace QR_Scanner
{
    public partial class Form1 : Form
    {
        public List<string> Numbers = new List<string>();
        public Form1()
        {
            InitializeComponent();
            //SaveRecover();
            VideoStart();
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice VideoCaptureDevice;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        ///Initializing video device and creating handler
        public void VideoStart()
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            VideoCaptureDevice = new VideoCaptureDevice(FilterInfoCollection[0].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.NewFrame += GoLive;
            VideoCaptureDevice.Start();
        }
        private void GoLive(object sender, NewFrameEventArgs eventArgs)
        {
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode((Bitmap)eventArgs.Frame.Clone());
            if (result != null)
            {
                this.Invoke((MethodInvoker)delegate {
                    labelScanned.Text = result.Text;
                });

            }
        }
        ///Handler for picture box updating
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxWebCam.Image = (Bitmap)eventArgs.Frame.Clone();
            Scanning(eventArgs);
        }

        ///Save and generate QR.
        private void BtnSaveQR_Click(object sender, EventArgs e)
        {
            var data = ListBoxOfAllCodes.SelectedItem.ToString();
            var path = $@"C:\\Users\\Xeon\\Desktop\\{ListBoxOfAllCodes.SelectedIndex}.Bmp";
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Write(data).Save(path);
        }

        ///Method decode bitmap and updating scanned QR.
        private string scannedText;
        private void Scanning(NewFrameEventArgs eventArgs)
        {
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode((Bitmap)eventArgs.Frame.Clone());
            if (result != null)
            {
                scannedText = result.Text;

            }

        }
        ///Scanning button.
        private void BtnScanning_Click_1(object sender, EventArgs e)
        {
            if (scannedText != null)
            {
                ListBoxOfAllCodes.SelectedItem = scannedText;
                labelScanned.Text = scannedText;
            }
            scannedText = null;
        }

        ///Filepath.
        public string filePath;
        public Document doc;
        private void BtnPath_Click(object sender, EventArgs e)
        {
            Numbers = null;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                labelPath.Text = ofd.FileName;
            }
            if (filePath != null)
            {
                //Create a Document object
                doc = new Document();
                //Load a Word file
                doc.LoadFromFile(filePath);
                var text = doc.GetText();
                Numbers = text.Split(',').ToList();
                foreach (var number in Numbers)
                {
                    if (number.Length < 20)
                    {
                        ListBoxOfAllCodes.Items.Add(number);
                    }
                }
            }
        }
    }
}
