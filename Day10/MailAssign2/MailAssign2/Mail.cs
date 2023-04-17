using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MailAssign2

{
    public class Mail

    {
        private long _id;
        public long ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        private string _to;
        public string TO
        {
            get
            {
                return _to;
            }
            set
            {
                _to = value;
            }
        }
        private string _from;
        public string FROM
        {
            get
            {
                return _from;
            }
            set { _from = value; }
        }
        private string _subject;
        public string SUBJECT
        {
            get
            {
                return _subject;
            }
            set
            {
                _subject = value;
            }
        }
        private string _content;
        public string CONTENT
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
            }
        }
        private DateTime _receivedDate;
        public DateTime RECEIVEDDATE
        {
            get
            {
                return _receivedDate;
            }
            set
            {
                _receivedDate = value;
            }
        }
        private double _size;
        public double SIZE
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }

        public Mail()
        {

        }
        public Mail(long id, string to, string from, string subject, string content, DateTime receivedDate, double size)
        {
            _id = id;
            _to = to;
            _from = from;
            _subject = subject;
            _content = content;
            _receivedDate = receivedDate;
            _size = size;

        }

        public override string ToString()
        {
            return string.Format($"{_id}\t{_to}\t{_from}\t{_subject}\t{_content}\t{_receivedDate}\t{_size}");
        }

        public static Mail CreateMail(string detail)
        {
            string[] details = detail.Split(',');
            DateTime dt = DateTime.ParseExact(details[5], "dd-MM-yyyy", null);
            Mail ml = new Mail(long.Parse(details[0]), details[1], details[2], details[3],details[4], dt, double.Parse(details[6]));
            return ml;
            
        }





    }
}



