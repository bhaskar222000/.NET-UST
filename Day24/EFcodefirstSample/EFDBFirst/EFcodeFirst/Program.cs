using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sqlAssgn2Entities ss = new sqlAssgn2Entities();
            foreach (var entity in ss.Client_master)
            {
                Console.WriteLine(entity);
            }
            using (var context = new sqlAssgn2Entities())
            {
                //INSERT
                //var std = new Client_master()
                //{
                //    Clientno = "101",
                //    Name = "Bill",
                //    City = "Vizag",
                //    Pincode = 522598,
                //    State = "Andhra",
                //    Baldue = 3000,
                //};
                //context.Client_master.Add(std);
                //context.SaveChanges();

                var std = new Sales_order()
                {

                };


                //UPDATE
                //var std = context.Client_master.First<Client_master>();
                //std.Name = "Steve";
                //context.SaveChanges();

                //DELETE
                //var std = context.Client_master.Where(y=>y.City=="Hyd").First<Client_master>();
                //context.Client_master.Remove(std);
                //context.SaveChanges();

            }
        }
    }
}
