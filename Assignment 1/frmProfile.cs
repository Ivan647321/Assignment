﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_1
{
    public partial class frmProfile : Form
    {
        private static string userName, userID;
       
        public frmProfile()
        {
            InitializeComponent();
        }
        public frmProfile(string nm, string id)
        {
            InitializeComponent();
            userName = nm;
            userID = id;   
        }

        private void lblShowGender1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlProfile2.Visible = true;

            Member frm = new Member(userID);

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want cancle edit?", "Discard Change", buttons);


            if (result == DialogResult.Yes) 
            {
                Member frm = new Member(userID);
                lblShowLevel1.Text = frm.getLevel(userID);
                lblshowLevel2.Text = frm.getLevel(userID);

                Member.viewProfile(frm);
                txtName.Text = frm.Name;
                txtPassword.Text = frm.Password;
                txtEmail.Text = frm.Email;
                txtGender.Text = frm.Gender;
                txtPhone.Text = frm.Phone.ToString();

                pnlProfile.Visible=true;
                pnlProfile2.Visible = false;
            }
            else
            {
            }

        }

        private void btnTraning4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTraining a = new frmTraining();
            a.ShowDialog();
        }

        private void pnlProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblShowName1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Member obj1 = new Member(userID);
            int phone = Int32.Parse(txtPhone.Text);
            MessageBox.Show(obj1.updateProfile(txtName.Text, txtPassword.Text, txtGender.Text, phone, txtEmail.Text));
            pnlProfile.Visible = true;
            pnlProfile2.Visible=false;

            //reget the new information of user
            Member frm = new Member(userID);
            lblShowLevel1.Text = frm.getLevel(userID);
            lblshowLevel2.Text = frm.getLevel(userID);

            Member.viewProfile(frm);
            int i = frm.Password.Length;
            string layout = new string('*', i);
            lblShowName1.Text = frm.Name;
            lblShowPassword1.Text = layout;
            lblShowEmail1.Text = frm.Email;
            lblShowPhone1.Text = frm.Phone.ToString();
            lblShowGender1.Text = frm.Gender;
        }

        private void cbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtPassword.UseSystemPasswordChar = true;
            }
                
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            Member frm = new Member(userID);
            lblShowLevel1.Text = frm.getLevel(userID);
            lblshowLevel2.Text = frm.getLevel(userID);

            Member.viewProfile(frm);
            int i = frm.Password.Length;
            string layout = new string('*', i);
            lblShowName1.Text = frm.Name;
            lblShowPassword1.Text =  layout;
            lblShowEmail1.Text = frm.Email;
            lblShowPhone1.Text = frm.Phone.ToString();
            lblShowGender1.Text = frm.Gender;


            txtName.Text = frm.Name;
            txtPassword.Text = frm.Password;
            txtEmail.Text = frm.Email;
            txtGender.Text = frm.Gender;
            txtPhone.Text = frm.Phone.ToString();

            


        }
    }
}