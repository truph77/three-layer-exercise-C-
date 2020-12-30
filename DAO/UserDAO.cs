using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance
        { 
            get
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }  
        }

        public UserDAO() { }

        public List<User> Xem()
        {
            List<User> users = new List<User>();

            using (ThisIsLINQDataContext db = new ThisIsLINQDataContext())
            {
                users =
            }

            //string query = "select * from users";

            //DataTable data = DataProvider.Instance.ExecuteQuery(query);

            //foreach (DataRow item in data.Rows)
            //{
            //    string id = item["ID"].ToString();
            //    string name = item["Name"].ToString();
            //    DateTime? dob =item["DateOfBirth"].ToString() == null ? null : (DateTime?)item["DateOfBirth"];
            //    string info = item["Info"].ToString();
            //    bool? sex = item["Sex"].ToString() == null ? null : (bool?)item["Sex"];

            //    User user = new User();
            //    user.name = name;
            //    user.info = info;
            //    user.dateOfBirth = dob;
            //    user.sex = sex;
            //    user.id = int.Parse(id);

            //    users.Add(user);
            //}
            return users;
        }

        public bool Sua(string id, User user)
        {
            //string query = " Update users set name = @name , dateofbirth = @dateofbirth , info = @info , sex = @sex where id = @oldid ";

            //object[] para = new object[] {user.Name, user.DateOfBirth, user.Info, user.Sex, id };

            //if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            //{
            //    return true;
            //}

            return false;
        }
    }
}
