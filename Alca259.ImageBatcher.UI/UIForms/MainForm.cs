using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Alca259.ImageBatcher.Common.Helpers;
using Alca259.ImageBatcher.Common.Models;

namespace Alca259.ImageBatcher.UI.UIForms
{
    public partial class MainForm : Form
    {
        #region Vars
        private readonly BackgroundWorker _worker;
        private string filePathSourceImage;
        private string filePathPreset;
        private float progress;
        private bool aspectRatio = true;

        private float Progress
        {
            set
            {
                progress = value;
                if (value < 100.0f)
                {
                    _worker.ReportProgress((int) value);
                }
                else
                {
                    _worker.ReportProgress(100);
                }
            }
        }
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();

            _worker = new BackgroundWorker {WorkerReportsProgress = true, WorkerSupportsCancellation = true};
            _worker.DoWork += _worker_DoWork;
            _worker.ProgressChanged += _worker_ProgressChanged;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
        }
        #endregion

        #region Worker
        private void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (progressBarExport.InvokeRequired)
            {
                progressBarExport.Invoke(new Action(() =>
                {
                    progressBarExport.Value = 100;
                }));
            }
            else
            {
                progressBarExport.Value = 100;
            }
        }

        private void _worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (progressBarExport.InvokeRequired)
            {
                progressBarExport.Invoke(new Action(() =>
                {
                    progressBarExport.Value = e.ProgressPercentage;
                }));
            }
            else
            {
                progressBarExport.Value = e.ProgressPercentage;
            }
        }

        private void _worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var fileInfo = new FileInfo(filePathSourceImage);
            var rootDir = fileInfo.DirectoryName ?? "";
            var ext = fileInfo.Extension;

            var data0 = scDimensions.GetAllChecked();

            var totalDataCount = data0.Count;
            var currentCount = 0.0f;

            _worker.ReportProgress((int)progress);

            if (!data0.Any()) return;

            foreach (var sizeImage in data0)
            {
                var destinationFolder = Path.Combine(rootDir, sizeImage.Category);
                var destinationfile = Path.Combine(destinationFolder, sizeImage.Label + ext);
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                if (aspectRatio)
                {
                    ImageHelper.ResizePictureAspectRatio(filePathSourceImage, destinationfile, sizeImage.WidthSize, sizeImage.HeightSize);
                }
                else
                {
                    ImageHelper.ResizePictureNoAspectRatio(filePathSourceImage, destinationfile, sizeImage.WidthSize, sizeImage.HeightSize);
                }

                currentCount++;
                Progress = currentCount / totalDataCount;
            }
        }
        #endregion

        #region Events
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var result = openFileImageDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtImagen.Text = openFileImageDialog.FileName;
                filePathSourceImage = openFileImageDialog.FileName;
            }
        }

        private void btnBrowsePreset_Click(object sender, EventArgs e)
        {
            var result = openFilePresetDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPreset.Text = openFilePresetDialog.FileName;
                filePathPreset = openFilePresetDialog.FileName;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePathSourceImage))
            {
                ShowError("Cannot load image from disk. File path must be specified.");
                return;
            }

            if (!scDimensions.GetAllChecked().Any())
            {
                ShowError("Nothing to export.");
                return;
            }

            if (!File.Exists(filePathSourceImage)) return;

            if (_worker.IsBusy)
            {
                _worker.CancelAsync();
            }

            _worker.RunWorkerAsync();
        }

        private void btnLoadPreset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePathPreset))
            {
                ShowError("Cannot load preset from disk. File path must be specified.");
                return;
            }

            try
            {
                scDimensions.RemoveAll();
                scDimensions.AddRange(XmlHelper<SizeImage>.ReadFromDisk(filePathPreset));
            }
            catch (Exception ex)
            {
                ShowError($"Cannot load preset from disk.{Environment.NewLine}{ex.Message}");
            }
        }

        private void btnSavePreset_Click(object sender, EventArgs e)
        {
            if (!scDimensions.GetAll().Any())
            {
                ShowError("Nothing to save.");
                return;
            }

            var result = saveFilePresetDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    filePathPreset = saveFilePresetDialog.FileName;
                    txtPreset.Text = saveFilePresetDialog.FileName;
                    if (!XmlHelper<SizeImage>.SaveToDisk(scDimensions.GetAll(), filePathPreset, true))
                    {
                        ShowError("Cannot save preset to disk.");
                    }
                }
                catch (Exception ex)
                {
                    ShowError($"Cannot save preset to disk.{Environment.NewLine}{ex.Message}");
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            int width;
            int height;
            if (string.IsNullOrEmpty(txtAddWidth.Text) || !int.TryParse(txtAddWidth.Text, out width)) return;
            if (string.IsNullOrEmpty(txtAddHeight.Text) || !int.TryParse(txtAddHeight.Text, out height)) return;
            if (string.IsNullOrEmpty(txtAddCategory.Text)) return;

            var newData = new SizeImage(width, height, txtAddCategory.Text);

            if (scDimensions.Exists(newData))
            {
                ShowError($"The dimension {newData.Label} already exists in collection.");
                return;
            }

            scDimensions.Add(newData);
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (scDimensions.GetSelected() == null) return;
            scDimensions.Remove(scDimensions.GetSelected());
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            scDimensions.RemoveAll();
        }

        private void txtAddWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtAddHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void checkAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            aspectRatio = checkAspectRatio.Checked;
        }
        #endregion

        #region Messagebox

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        #endregion
    }
}
