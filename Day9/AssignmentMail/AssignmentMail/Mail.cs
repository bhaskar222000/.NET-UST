using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMail
{
    public class Mail
    {
        private long _id;
        public long ID
        {
            get {
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
        { get {
                return _content;
            }
            set
            {
                _content= value;
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
        public Mail(long _id, string _to, string _from, string _subject, string _content, DateTime _receivedDate, double _size)
        {
            this._id = _id;
            this._to = _to;
            this._from = _from;
            this._subject = _subject;
            this._content = _content;
            this._receivedDate = _receivedDate;
            this._size = _size;

        }
        public override string ToString()
        {
            return string.Format("_id:{0}\n_to:{1}\n_from{2}\n_subject{3}\n_content{4}\n_receiceddDate{5}\n_size{6}\n",
                               _id,_to,_from,_subject,_content,_receivedDate.ToString("dd-MM-yyyy", null),_size.ToString("0.0"));
        }
        public override bool Equals(object obj)
        {
            Mail m = obj as Mail;
            if (m.TO == TO && m.FROM == FROM && m.SUBJECT == SUBJECT)
                return true;
            else 
                return false;   
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }

}
