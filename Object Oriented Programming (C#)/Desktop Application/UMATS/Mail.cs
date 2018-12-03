using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace UMATS
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); 
                MailMessage message = new MailMessage(); 
                message.From = new MailAddress(textBox1.Text); 
                message.To.Add(textBox2.Text); 
                message.Body = textBox5.Text; 
                message.Subject = textBox6.Text; 
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                if (textBox6.Text != "")
                {
                    message.Attachments.Add(new Attachment(textBox6.Text)); 
                }
                client.Credentials = new System.Net.NetworkCredential(textBox1.Text, textBox2.Text); 
         
                client.Send(message);
                
            
                message = null; 
                MessageBox.Show("Email Sent! ;)");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MailC m = new MailC();
            m.logout();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MailC bk = new MailC();
            bk.Back();
            Close();
        }
    }
}
