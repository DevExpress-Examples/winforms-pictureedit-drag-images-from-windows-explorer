using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;


namespace DXSample {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }
        DragDropProvider provider;

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

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (provider != null)
                provider.DisableDragDrop();
        }
    }
}
