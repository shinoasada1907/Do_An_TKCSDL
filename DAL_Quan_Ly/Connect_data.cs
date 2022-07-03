using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Quan_Ly
{
    public class Connect_data
    {
        protected SqlConnection cnn = new SqlConnection(@"Data Source=SINONSAMA\TIENNT;Initial Catalog=MYPHAM;Persist Security Info=True;User ID=sa;Password=tiennt1907");
    }
}
