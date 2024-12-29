using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Class_POS;

namespace projectUAS
{
    public partial class FormChat : Form
    {
        private Koneksi koneksi;
        private string currentUser;
        private string friendUser;
        private Chat chat;

        public FormChat()
        {
            InitializeComponent();
            currentUser = Session.Username;
            koneksi = new Koneksi();
            this.chat = new Chat(koneksi);
            LoadFriends(); // Load friends when the form is initialized
            listBoxFriends.SelectedIndexChanged += listBoxFriends_SelectedIndexChanged;
        }

        private void LoadFriends()
        {
            // Assuming you have a method to get friends
            List<string> friends = new Friends(koneksi).GetFriends(currentUser);
            listBoxFriends.Items.Clear();
            foreach (var friend in friends)
            {
                listBoxFriends.Items.Add(friend);
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItem != null)
            {
                string selectedFriend = listBoxFriends.SelectedItem.ToString();
                LoadMessages(selectedFriend); // Load messages for the selected friend
            }
        }

        private void LoadMessages(string friendUser)
        {
            rtbChat.Clear(); // Clear the RichTextBox
            List<ChatMessage> messages = chat.GetMessages(currentUser, friendUser);
            foreach (var message in messages)
            {
                // Append messages to the RichTextBox
                rtbChat.AppendText($"{message.Timestamp}: {message.Sender}: {message.Message}\n");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            if (!string.IsNullOrEmpty(message) && listBoxFriends.SelectedItem != null)
            {
                string selectedFriend = listBoxFriends.SelectedItem.ToString();
                chat.SendMessage(currentUser, selectedFriend, message);
                textBox1.Clear(); // Clear the input TextBox
                LoadMessages(selectedFriend); // Refresh the message list for the selected friend
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            koneksi.Dispose();

            while (FormManager.Pop() != null) { }


            FormUtama mainForm = new FormUtama();
            mainForm.Show();


            this.Close();
        }
    }
}
