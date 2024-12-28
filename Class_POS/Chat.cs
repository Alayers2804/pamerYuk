using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Class_POS
{
    public class Chat
    {
        private Koneksi koneksi;

        public Chat(Koneksi koneksi)
        {
            this.koneksi = koneksi;
        }

        public void SendMessage(string sender, string receiver, string message)
        {
            string query = "INSERT INTO chat (sender, receiver, message, timestamp) VALUES (@sender, @receiver, @message, @timestamp)";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@sender", sender);
                cmd.Parameters.AddWithValue("@receiver", receiver);
                cmd.Parameters.AddWithValue("@message", message);
                cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);

                cmd.ExecuteNonQuery(); // Execute the insert command
            }
        }

        public List<ChatMessage> GetMessages(string user1, string user2)
        {
            List<ChatMessage> messages = new List<ChatMessage>();
            string query = "SELECT * FROM chat WHERE (sender = @user1 AND receiver = @user2) OR (sender = @user2 AND receiver = @user1) ORDER BY timestamp"; // Fixed query

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@user1", user1);
                cmd.Parameters.AddWithValue("@user2", user2);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ChatMessage chatMessage = new ChatMessage
                        {
                            Sender = reader.GetString("sender"),
                            Receiver = reader.GetString("receiver"),
                            Message = reader.GetString("message"),
                            Timestamp = reader.GetDateTime("timestamp")
                        };
                        messages.Add(chatMessage);
                    }
                }
            }
            return messages;
        }
    }

    public class ChatMessage
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }

}
