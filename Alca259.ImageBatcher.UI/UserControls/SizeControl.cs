using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Alca259.ImageBatcher.Common.Models;

namespace Alca259.ImageBatcher.UI.UserControls
{
    public partial class SizeControl : UserControl
    {
        private BindingSource BindingSizeImages;
        private BindingList<SizeImage> SizeImages = new BindingList<SizeImage>();

        public SizeControl()
        {
            InitializeComponent();
        }

        public void AddRange(IEnumerable<SizeImage> sizes)
        {
            foreach (var size in sizes)
            {
                Add(size);
            }
        }

        public bool Exists(SizeImage size)
        {
            return SizeImages.Any(a => a.WidthSize == size.WidthSize 
                && a.HeightSize == size.HeightSize 
                && a.Category.ToLower().Trim().Equals(size.Category.ToLower().Trim()));
        }

        public void Add(SizeImage size)
        {
            BindingSizeImages.Add(size);
        }

        public List<SizeImage> GetAll()
        {
            return SizeImages.ToList();
        }

        public List<SizeImage> GetAllChecked()
        {
            var list = new List<SizeImage>();

            foreach (var checkedItem in checkedListBox.CheckedItems)
            {
                list.Add(checkedItem as SizeImage);
            }

            return list;
        }

        public SizeImage GetSelected()
        {
            return checkedListBox.SelectedItem as SizeImage;
        }

        public void Remove(SizeImage size)
        {
            BindingSizeImages.Remove(size);
        }

        public void RemoveAll()
        {
            BindingSizeImages.Clear();
        }
        
        private void SizeControl_Load(object sender, System.EventArgs e)
        {
            BindingSizeImages = new BindingSource {DataSource = SizeImages};
            BindingSizeImages.ListChanged += BindingSizeImages_Reload;

            checkedListBox.DataSource = BindingSizeImages;
            checkedListBox.DisplayMember = "Label";
            checkedListBox.DataBindings.Add(new Binding("Text", BindingSizeImages, "Label", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void BindingSizeImages_Reload(object sender, ListChangedEventArgs listChangedEventArgs)
        {
            for (var i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, true);
            }
        }
    }
}
