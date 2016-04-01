using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    public class Msg
    {
        private int id, sender_id, receiver_id;
        private String title, message, file_name;
        private Msgr sender, receiver;

        public Msg(int id, int senderId, int receiverId, string title, string message, string fileName, Msgr sender, Msgr receiver)
        {
            this.id = id;
            sender_id = senderId;
            receiver_id = receiverId;
            this.title = title;
            this.message = message;
            file_name = fileName;
            this.sender = sender;
            this.receiver = receiver;
        }

        public Msg(int senderId, int receiverId, string title, string message, string fileName, Msgr sender, Msgr receiver)
        {
            sender_id = senderId;
            receiver_id = receiverId;
            this.title = title;
            this.message = message;
            this.receiver = receiver;
            this.sender = sender;
            file_name = fileName;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int SenderId
        {
            get { return sender_id; }
            set { sender_id = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int ReceiverId
        {
            get { return receiver_id; }
            set { receiver_id = value; }
        }

        public string FileName
        {
            get { return file_name; }
            set { file_name = value; }
        }

        public Msgr Sender
        {
            get { return sender; }
            set { sender = value; }
        }

        public Msgr Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }
    }
}
