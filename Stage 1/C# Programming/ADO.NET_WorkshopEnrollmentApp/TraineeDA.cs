using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WorkShopEnrollmentApp
{
    //Write your code here
    public class TraineeDA
    {
        public string ConnectionString => ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;


        public bool AddTraineeDetails(TraineeBO objBO)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                string queryString =
                    "insert into tblTrainee values("+objBO.TraineeId+",'"+objBO.TraineeName+"','"+objBO.BatchCode+"')";
                SqlCommand command = new SqlCommand(queryString, connection);
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
