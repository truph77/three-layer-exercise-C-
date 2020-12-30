using DAODLL;
using DTODLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUSDLL
{
    public class UserBUS
    {
        private static UserBUS instance;

        public static UserBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserBUS();
                }
                return instance;
            }
        }

        public UserBUS() { }

        public void Xem(DataGridView data)
        {
            data.DataSource = UserDAO.Instance.Xem();
        }

        public bool Sua(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string id = row.Cells["ID"].Value.ToString();
            string name = row.Cells["Name"].Value.ToString();
            string info = row.Cells["Info"].Value.ToString();
            DateTime? dob = (DateTime?)row.Cells["DateOfBirth"].Value;
            bool? sex = (bool?)row.Cells["Sex"].Value;


            User user = new User();
            user.name = name;
            user.info = info;
            user.dateOfBirth = dob;
            user.sex = sex;
            user.id = int.Parse(id);

            return UserDAO.Instance.Sua(id, user);
        }
    }
}
