using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace QR_Scanner
{
    public partial class Form1 : Form
    {
        public List<string> Numbers = new List<string>();
        public Form1()
        {
            InitializeComponent();
            SaveRecover();
            VideoStart();
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice VideoCaptureDevice;
        private void SaveData()
        {
            System.IO.Stream ms = File.OpenWrite(@"AutoSave");
            BinaryFormatter formatter = new BinaryFormatter();
            using (BinaryWriter bw = new BinaryWriter(ms))
            {
                formatter.Serialize(ms, Numbers);
            }
        }
        private void SaveRecover()
        {
            if (File.Exists(@"AutoSave"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = File.Open(@"AutoSave", FileMode.Open))
                {
                    Numbers = (List<string>)formatter.Deserialize(fs);
                }
                foreach (var item in Numbers)
                {
                    ListBoxOfAllCodes.Items.Add(item);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void VideoStart()
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            VideoCaptureDevice = new VideoCaptureDevice(FilterInfoCollection[0].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxWebCam.Image = (Bitmap)eventArgs.Frame.Clone();
            Scanning(eventArgs);
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            ListBoxOfAllCodes.Items.Add(TextBoxNewItemName.Text);
            Numbers.Add(TextBoxNewItemName.Text);
            SaveData();
        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            Numbers.Remove(ListBoxOfAllCodes.SelectedItem.ToString());
            ListBoxOfAllCodes.Items.Remove(ListBoxOfAllCodes.SelectedItem);
            SaveData();
        }

        private void BtnSaveQR_Click(object sender, EventArgs e)
        {
            var data = ListBoxOfAllCodes.SelectedItem.ToString();
            var path = $@"D:\\{data}.Bmp";
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Write(data).Save(path);
        }

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

        private void BtnScanning_Click_1(object sender, EventArgs e)
        {
            if (scannedText != null)
            {
                ListBoxOfAllCodes.SelectedItem = scannedText;
            }
            scannedText = null;
        }
    }
}
