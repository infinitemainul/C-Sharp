using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Bsinesslogiclayer
{
    public class Eventservice
    {
        Eventdataaccess evenData;
        Userdataaccess userData;
        public Eventservice()
        {
            evenData = new Eventdataaccess();
            userData = new Userdataaccess();
        }

        public List<Events> GetAllEvent(int id)
        {
            return evenData.GetAllEvents(id);
        }

        public User GetUser(string userName)
        {
            return userData.GetUser(userName);
        }
        public Events Getthatevent(int id)
        {
            return evenData.GetthatEvent(id);
        }

        public int AddEvent(string proName, string createdate, string eventdate, string pic, string description, int uid, string importance)
        {
            Events p = new Events() { Name = proName, Createdate = createdate, Eventdate = eventdate, Pic = pic, Description = description, Uid = uid, Importance = importance };
            return evenData.AddEvent(p);
        }
        public int Adduser(string name, string passward)
        {
            User p = new User() { Name = name, Password = passward };
            return userData.AddUser(p);

        }

        public int DeleteEvent(int id)
        {
            return evenData.DeleteEvent(id);
        }
        public int UpdateEvent(string proName, string createdate, string modify, string eventdate, string pic, string description, int uid, string importance, int eid)
        {
            Events p = new Events() { Name = proName, Createdate = createdate, Eventdate = eventdate, Modifydate = modify, Pic = pic, Description = description, Uid = uid, Importance = importance };
            return evenData.Updateevent(p, eid);
        }
    }
}
