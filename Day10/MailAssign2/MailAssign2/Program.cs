using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MailAssign2
{
    class Program
    {
       static void Main(string[] args)
        {
            List<Mail> ls= new List<Mail>();
            Console.WriteLine("Enter the name of the folder");
            string name=Console.ReadLine();
            MailFolder mf= new MailFolder(name,ls);
            Mail mail=new Mail();
            bool ac = true;
            while(ac)
            {
                Console.WriteLine("1.Add Mail\n2.Delete Mail\n3.Display Mail\n4.Exit\nEnter your choice:");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the details of mail in CVS format:");
                        string s = Console.ReadLine();
                         mail = Mail.CreateMail(s);
                        mf.AddMailToFolder(mail);      
                        Console.WriteLine("Mail Successfully added");
                        break;

                    case 2:
                        Console.WriteLine("Enter the id of the mail to be deleted");
                        long mailid=int.Parse(Console.ReadLine());
                        
                        if (mf.RemoveMailFromFolder(mailid))
                        {
                            Console.WriteLine("Mail successfully deleted");
                        }
                        else
                            Console.WriteLine("Mail not found in folder");
                        break;

                    case 3:
                        mf.DisplayMails();
                        break;

                    case 4:
                        ac = false;
                        Console.WriteLine("Sucessfully Exit");

                        break;

                    default:

                        Console.WriteLine("Enter Correct Choice");
                        break;
                }
            }
        }
    }
}


























    //        Console.WriteLine("Enter the name of the folder:");
    //        string folderName = Console.ReadLine();
    //        Mail.MailFolder mailFolder = new Mail.MailFolder(folderName, new List<Mail>());
    //        while (true)
    //        {
    //            Console.WriteLine("\n1. Add Mail\n2. Delete Mail\n3. Display Mails\n4. Exit");
    //            Console.WriteLine("Enter your choice:");
    //            int choice = Convert.ToInt32(Console.ReadLine());
    //            switch (choice)
    //            {
    //                case 1:
    //                    Console.WriteLine("\nEnter the details of mail in CSV format:");
    //                    string mailDetails = Console.ReadLine();
    //                    Mail mail = Mail.CreateMail(mailDetails);
    //                    mailFolder.AddMailToFolder(mail);
    //                    Console.WriteLine("Mail successfully added");
    //                    break;
    //                case 2:
    //                    Console.WriteLine("\nEnter the id of the mail to be deleted:");
    //                    long mailId = Convert.ToInt64(Console.ReadLine());
    //                    break;
    //            }

    //        }
    //    }
    //}

