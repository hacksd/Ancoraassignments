using System;
using System.Collections.Generic;
using System.Text;

namespace lab7

{
    class Program
    {
        static void Main(string[] args)
        {
            //lab 7 done by Mohammad and Amar
            //creating 2 new profiles
            DatingProfile Trump = new DatingProfile("Donald", "Trump", 87, "Male");
            Trump.WriteBio("president of the united stetes");

            DatingProfile Hillary = new DatingProfile("Hillary", "Clinton", 55, "Female");
            Hillary.WriteBio("new to this site");
            //send messages
            Console.WriteLine("Trump : ");
            Trump.SendMessage("Hello Hillary", "Want to get some coffee?", Hillary);
            Hillary.ReadMessage();
            Console.WriteLine("Hillary : ");
            Hillary.SendMessage("Hello Trump", "I'm a married women NO Thanks.", Trump);
            Trump.ReadMessage();
        }
    }
    class  InboxMessages
    {
        public DatingProfile sender;
        public string messageTitle;
        public string messageData;
        public bool isRead;

        public  InboxMessages(DatingProfile sender, string messageTitle, string messageData)
        {
            this.sender = sender;
            this.messageTitle = messageTitle;
            this.messageData = messageData;
            isRead = false;
        }

    }
    class DatingProfile
    {
        public string firstName;
        private string lastName;
        public int age;
        public string gender;
        public string bio;
        private List< InboxMessages> myMessages;

        public DatingProfile(string firstName, string lastName, int age, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            myMessages = new List< InboxMessages>();
        }

        public void WriteBio(string text)
        {
            bio = text;
        }

        public void AddToInbox( InboxMessages message)
        {
            myMessages.Add(message);

        }

        public void SendMessage(string messageTitle, string messageData, DatingProfile sentTo)
        {
             InboxMessages message = new  InboxMessages(this, messageTitle, messageData);
            sentTo.AddToInbox(message);
        }

        public void ReadMessage()
        {
            foreach ( InboxMessages message in myMessages)
            {
                if (message.isRead == false)
                {
                    Console.WriteLine(message.messageTitle);
                    Console.WriteLine(message.messageData);
                    message.isRead = true;
                }
            }
        }
    }
}
