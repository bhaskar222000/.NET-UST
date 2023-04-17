
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAssign2
{
    public class MailFolder
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }

        private List<Mail> _maillist = new List<Mail>();
        public List<Mail> MailList
        {
            get { return _maillist; }
            set { _maillist = value; }
        }
        public MailFolder() { }
        public MailFolder(string name, List<Mail> maillist)
        {
            _name = name;
            _maillist = maillist;
        }
        public void AddMailToFolder(Mail mail)
        {
            _maillist.Add(mail);
        }

        public bool RemoveMailFromFolder(long id)
        {
            int count = 0;
            foreach (var item in _maillist)
            {
                if (item.ID == id)
                {
                    _maillist.Remove(item);
                    count = 1;
                    break;
                }
            }
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DisplayMails()
        {
            if (_maillist.Count != 0)
            {

                Console.WriteLine("Mails in Inbox");
                
                Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15} {6,15}",
                    "Id", "From", "To", "Subject", "Content", "Received Date", "Size");
                foreach (var item in _maillist)
                {
                    Console.WriteLine(item.ToString());
                }
                   


            }
            else
            {
                Console.WriteLine("No mails to show");
            }

        }

    }
}
