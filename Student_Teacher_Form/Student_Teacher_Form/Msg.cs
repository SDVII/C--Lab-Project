using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    public class Msg //Msg object class
    {
        private int id, sender_id, receiver_id;
        private String title, message, file_name;
        private Msgr sender, receiver;
        private DateTime time;

        public Msg(int id, int senderId, int receiverId, DateTime time, string title, string message, string fileName)
        {
            this.id = id;
            sender_id = senderId;
            receiver_id = receiverId;
            this.time = time;
            this.title = title;
            this.message = message;
            file_name = fileName;
            this.sender = null;
            this.receiver = null;
        }

        public Msg(int senderId, int receiverId, DateTime time, string title, string message, string fileName)
        {
            sender_id = senderId;
            receiver_id = receiverId;
            this.time = time;
            this.title = title;
            this.message = message;
            this.receiver = null;
            this.sender = null;
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

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
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
            get {
                if (sender == null)
                    sender = MsgrDB.Get(sender_id);
                return sender;
            }
            set { sender = value; }
        }

        public Msgr Receiver
        {
            get {
                if (receiver == null)
                    receiver = MsgrDB.Get(receiver_id);
                return receiver;
            }
            set { receiver = value; }
        }
    }
}
