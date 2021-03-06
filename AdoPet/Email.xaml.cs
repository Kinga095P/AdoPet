﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AdoPet
{
    /// <summary>
    /// Interaction logic for Email.xaml
    /// </summary>
    public partial class Email : Window
    {
        public Email()
        {
            InitializeComponent();
        }
       

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAddres.Text))
                {
                    MessageBox.Show("Proszę uzupełnić adresata");
                }
                else if (string.IsNullOrEmpty(txtTopic.Text))
                {
                    MessageBox.Show("Proszę uzupełnić temat");
                }
                else if (string.IsNullOrEmpty(txtMessage.Text))
                {
                    MessageBox.Show("Proszę uzupełnić treść wiadomości");
                }
                else
                {
                    string[] recipients = txtAddres.Text.Split(',');
                    SmtpClient client = new System.Net.Mail.SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        UseDefaultCredentials = false,
                        Credentials = new System.Net.NetworkCredential("notifications.petadopter@gmail.com", "Petadopter123A")
                    };
                    string from = "Powiadomienie PETAdopter";
                    string subject = txtTopic.Text;
                    string body = txtMessage.Text;
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress("notifications.petadopter@gmail.com");
                    message.Subject = subject;
                    message.Body = body;

                    for (int i = 0; i < recipients.Length; i++)
                    {
                        message.To.Add(new MailAddress(recipients[i].Trim().ToString()));
                    }
                    MessageBox.Show("Wiadomość została wysłana poprawnie");
                  
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Nie udało się wysłać wiadoności");
            }

        }
    }
}
