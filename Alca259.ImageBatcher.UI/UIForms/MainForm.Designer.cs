using Alca259.ImageBatcher.UI.UserControls;

namespace Alca259.ImageBatcher.UI.UIForms
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkAspectRatio = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddCategory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddWidth = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.scDimensions = new Alca259.ImageBatcher.UI.UserControls.SizeControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLoadPreset = new System.Windows.Forms.Button();
            this.btnSavePreset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreset = new System.Windows.Forms.TextBox();
            this.btnBrowsePreset = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.progressBarExport = new System.Windows.Forms.ProgressBar();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabProcesado = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveFilePresetDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFilePresetDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabProcesado.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileImageDialog
            // 
            this.openFileImageDialog.Filter = "PNG|*.png";
            this.openFileImageDialog.Title = "Select a image with good resolution...";
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(101, 5);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.ReadOnly = true;
            this.txtImagen.Size = new System.Drawing.Size(620, 20);
            this.txtImagen.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(727, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(25, 20);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source image";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.scDimensions);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 444);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimensions";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtAddCategory);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtAddHeight);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtAddWidth);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 381);
            this.panel3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.checkAspectRatio);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 350);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(249, 31);
            this.panel6.TabIndex = 8;
            // 
            // checkAspectRatio
            // 
            this.checkAspectRatio.AutoSize = true;
            this.checkAspectRatio.Checked = true;
            this.checkAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAspectRatio.Location = new System.Drawing.Point(8, 8);
            this.checkAspectRatio.Name = "checkAspectRatio";
            this.checkAspectRatio.Size = new System.Drawing.Size(202, 17);
            this.checkAspectRatio.TabIndex = 1;
            this.checkAspectRatio.Text = "Maintain aspect ratio on export";
            this.checkAspectRatio.UseVisualStyleBackColor = true;
            this.checkAspectRatio.CheckedChanged += new System.EventHandler(this.checkAspectRatio_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Category";
            // 
            // txtAddCategory
            // 
            this.txtAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCategory.Location = new System.Drawing.Point(79, 63);
            this.txtAddCategory.Name = "txtAddCategory";
            this.txtAddCategory.Size = new System.Drawing.Size(166, 20);
            this.txtAddCategory.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Height";
            // 
            // txtAddHeight
            // 
            this.txtAddHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddHeight.Location = new System.Drawing.Point(79, 36);
            this.txtAddHeight.MaxLength = 4;
            this.txtAddHeight.Name = "txtAddHeight";
            this.txtAddHeight.Size = new System.Drawing.Size(166, 20);
            this.txtAddHeight.TabIndex = 4;
            this.txtAddHeight.Text = "0";
            this.txtAddHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAddHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddHeight_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Width";
            // 
            // txtAddWidth
            // 
            this.txtAddWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddWidth.Location = new System.Drawing.Point(79, 10);
            this.txtAddWidth.MaxLength = 4;
            this.txtAddWidth.Name = "txtAddWidth";
            this.txtAddWidth.Size = new System.Drawing.Size(166, 20);
            this.txtAddWidth.TabIndex = 1;
            this.txtAddWidth.Text = "0";
            this.txtAddWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAddWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddWidth_KeyPress);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRemoveAll);
            this.panel5.Controls.Add(this.btnRemoveSelected);
            this.panel5.Controls.Add(this.btnAddNew);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(252, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(41, 381);
            this.panel5.TabIndex = 4;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.Location = new System.Drawing.Point(7, 72);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(28, 27);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelected.Location = new System.Drawing.Point(7, 39);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(28, 27);
            this.btnRemoveSelected.TabIndex = 1;
            this.btnRemoveSelected.Text = "<";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(7, 6);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(28, 27);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = ">";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // scDimensions
            // 
            this.scDimensions.Dock = System.Windows.Forms.DockStyle.Right;
            this.scDimensions.Location = new System.Drawing.Point(293, 60);
            this.scDimensions.Name = "scDimensions";
            this.scDimensions.Size = new System.Drawing.Size(471, 381);
            this.scDimensions.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLoadPreset);
            this.panel4.Controls.Add(this.btnSavePreset);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtPreset);
            this.panel4.Controls.Add(this.btnBrowsePreset);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(761, 44);
            this.panel4.TabIndex = 3;
            // 
            // btnLoadPreset
            // 
            this.btnLoadPreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPreset.Location = new System.Drawing.Point(604, 3);
            this.btnLoadPreset.Name = "btnLoadPreset";
            this.btnLoadPreset.Size = new System.Drawing.Size(76, 26);
            this.btnLoadPreset.TabIndex = 4;
            this.btnLoadPreset.Text = "Load preset";
            this.btnLoadPreset.UseVisualStyleBackColor = true;
            this.btnLoadPreset.Click += new System.EventHandler(this.btnLoadPreset_Click);
            // 
            // btnSavePreset
            // 
            this.btnSavePreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePreset.Location = new System.Drawing.Point(686, 3);
            this.btnSavePreset.Name = "btnSavePreset";
            this.btnSavePreset.Size = new System.Drawing.Size(72, 26);
            this.btnSavePreset.TabIndex = 3;
            this.btnSavePreset.Text = "Save preset";
            this.btnSavePreset.UseVisualStyleBackColor = true;
            this.btnSavePreset.Click += new System.EventHandler(this.btnSavePreset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preset file";
            // 
            // txtPreset
            // 
            this.txtPreset.Location = new System.Drawing.Point(101, 6);
            this.txtPreset.Name = "txtPreset";
            this.txtPreset.ReadOnly = true;
            this.txtPreset.Size = new System.Drawing.Size(466, 20);
            this.txtPreset.TabIndex = 0;
            // 
            // btnBrowsePreset
            // 
            this.btnBrowsePreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowsePreset.Location = new System.Drawing.Point(573, 6);
            this.btnBrowsePreset.Name = "btnBrowsePreset";
            this.btnBrowsePreset.Size = new System.Drawing.Size(25, 20);
            this.btnBrowsePreset.TabIndex = 1;
            this.btnBrowsePreset.Text = "...";
            this.btnBrowsePreset.UseVisualStyleBackColor = true;
            this.btnBrowsePreset.Click += new System.EventHandler(this.btnBrowsePreset_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportar.Location = new System.Drawing.Point(698, 0);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(67, 26);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Export";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // progressBarExport
            // 
            this.progressBarExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarExport.Location = new System.Drawing.Point(0, 0);
            this.progressBarExport.Name = "progressBarExport";
            this.progressBarExport.Size = new System.Drawing.Size(698, 26);
            this.progressBarExport.Step = 1;
            this.progressBarExport.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarExport.TabIndex = 4;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabProcesado);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(784, 561);
            this.tabs.TabIndex = 5;
            // 
            // tabProcesado
            // 
            this.tabProcesado.Controls.Add(this.flowLayoutPanel1);
            this.tabProcesado.Location = new System.Drawing.Point(4, 22);
            this.tabProcesado.Name = "tabProcesado";
            this.tabProcesado.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcesado.Size = new System.Drawing.Size(776, 535);
            this.tabProcesado.TabIndex = 0;
            this.tabProcesado.Text = "Process";
            this.tabProcesado.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(770, 529);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtImagen);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 31);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBarExport);
            this.panel2.Controls.Add(this.btnExportar);
            this.panel2.Location = new System.Drawing.Point(3, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 26);
            this.panel2.TabIndex = 4;
            // 
            // saveFilePresetDialog
            // 
            this.saveFilePresetDialog.FileName = "FilePresets";
            this.saveFilePresetDialog.Filter = "XML|*.xml";
            this.saveFilePresetDialog.Title = "Save preset file...";
            // 
            // openFilePresetDialog
            // 
            this.openFilePresetDialog.Filter = "XML|*.xml";
            this.openFilePresetDialog.Title = "Select preset file...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Image Batcher Resizer";
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabProcesado.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileImageDialog;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.ProgressBar progressBarExport;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabProcesado;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private SizeControl scDimensions;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreset;
        private System.Windows.Forms.Button btnBrowsePreset;
        private System.Windows.Forms.Button btnLoadPreset;
        private System.Windows.Forms.Button btnSavePreset;
        private System.Windows.Forms.TextBox txtAddWidth;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddCategory;
        private System.Windows.Forms.SaveFileDialog saveFilePresetDialog;
        private System.Windows.Forms.OpenFileDialog openFilePresetDialog;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox checkAspectRatio;
    }
}

