using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;
namespace Manning.MyPhotoControls
{
    public partial class AlbumEditDialog : Manning.MyPhotoControls.BaseEditDialog
    {
        private AlbumManager _manager;
        private AlbumManager Manager
        {
            get { return _manager; }
        }

        public AlbumEditDialog(AlbumManager mgr)
        {
            if (mgr == null)
                throw new ArgumentException("Album manager cannot be null");

                InitializeComponent();

            _manager = mgr;
            ResetDialog();
        }

        private void cbxPassWord_CheckedChanged(object sender, EventArgs e)
        {
            bool enable = cbxPassword.Checked;
            txtPassword.Enabled = enable;
            lblConfirm.Enabled = enable;
            txtConfirm.Enabled = enable;

            //if enable , assis focus 
            if (enable)
                txtPassword.Focus();
        }

        protected override void ResetDialog()
        {   
            PhotoAlbum album = Manager.Album;
            //Assign text boxes
            txtAlbumFile.Text = Manager.FullName;
            txtTitle.Text = album.Title;

            //Assign radio button
            switch(album.PhotoDecriptor)
            {
                case PhotoAlbum.DescriptorOption.Caption:
                    rbtnCaption.Checked = true;
                    break;
                case PhotoAlbum.DescriptorOption.DateTaken:
                    rbtnDateTaken.Checked = true;
                    break;
                case PhotoAlbum.DescriptorOption.Filename:
                    rbtnFileName.Checked = true;
                    break;
            }

            // assign checked box
            string pwd = Manager.Password;
            cbxPassword.Checked = (pwd != null && pwd.Length > 0);
            txtPassword.Text = pwd;
            txtConfirm.Text = pwd;
            base.ResetDialog();
        }

         private bool ValidPassword()
        {
            if (cbxPassword.Checked)
                return (txtPassword.TextLength > 0 &&
                       txtConfirm.Text == txtPassword.Text);
            else
                return true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {   
            if(DialogResult == DialogResult.OK)
            {
                if (!ValidPassword())
                {
                    DialogResult result = MessageBox.Show("The current password is blank"
                        +" or the two password entries" 
                        +" do not match.",
                        "Invalid Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    e.Cancel = true;
                }
                if (!e.Cancel)
                    SaveSetting();

            }
            base.OnClosing(e);
        }

        private void SaveSetting()
        {
            PhotoAlbum album = Manager.Album;
            if( album != null)
            {
                album.Title = txtTitle.Text;

                if (rbtnCaption.Checked)
                    album.PhotoDecriptor = PhotoAlbum.DescriptorOption.Caption;
                if (rbtnDateTaken.Checked)
                    album.PhotoDecriptor = PhotoAlbum.DescriptorOption.DateTaken;
                if (rbtnFileName.Checked)
                    album.PhotoDecriptor = PhotoAlbum.DescriptorOption.Filename;

                if (cbxPassword.Checked && ValidPassword())
                    Manager.Password = txtPassword.Text;
                else
                    Manager.Password = null;
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            Text = txtTitle.Text + "- Album Properties";
        }

        private void AlbumEditDialog_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.TextLength > 0)
                errorProvider1.SetError(txtPassword, "");
            else
                errorProvider1.SetError(txtPassword, "The assigned password blank");
        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if(txtConfirm.Text == txtPassword.Text)
                errorProvider1.SetError(txtConfirm, "");
            else
                errorProvider1.SetError(txtConfirm, "The password and confirmation entries not to match");

        }
    }
}
