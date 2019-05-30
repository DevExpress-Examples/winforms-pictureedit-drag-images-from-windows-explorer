using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;


namespace DXSample
{
    public partial class Main : XtraForm
    {
        DragDropProvider provider;

        public Main()
        {
            InitializeComponent();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if(provider != null)
                provider.DisableDragDrop();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            provider = new DragDropProvider(pictureEdit1);
            provider.EnableDragDrop();
        }

        private void OnSimpleButtonMouseDown(object sender, MouseEventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            pictureEdit1.DoDragDrop(btn.Image, DragDropEffects.Copy);
        }
    }
}
