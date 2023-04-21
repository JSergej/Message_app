using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messaginApp
{
    internal class Data
    {
        static string connString = ConfigurationManager.AppSettings["connectionString"];

        public static List<T> GetData<T>(string SQL, CommandType cmdType) // method 
        {

                 // Connect to DB to retrieve data
            using (SqlConnection conn = new SqlConnection(connString))
            {

                // Create variable to hold whatever value of whatever data type that comes back from database  
                var objProperties = Activator.CreateInstance<T>().GetType().GetProperties();

                // Create a list variable to return the list to the caller 
                var returnList = new List<T>();
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {

                    //Type of command we us to retrieve the data .in our case it will be  Text 
                    // because we are passing in a string.
                    cmd.CommandType = cmdType;
                         // set time out 30sec.If result set not returned within 30 sec , close the connection
                         // and allow the program carry on without data . 
                    cmd.CommandTimeout = 30000;

                    try
                    {
                        // open the connection to DB.
                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader(); // Retrieves multiple records;
                            // Sort through each column of data in each row 
                        var columns = reader.GetSchemaTable().Rows.Cast<DataRow>().Select(row => row["ColumnName"].ToString().ToLower()).ToList();

                        while (reader.Read())
                        {
                            var thisRow = Activator.CreateInstance<T>();
                            foreach (var prop in objProperties)
                            { 
                                   // if the current sql column name ==  the c# property name of the
                                   // Type(SMS,MMS)-Assign the value to the property(ID, Recipient etc.)
                                if (columns.Contains(prop.Name.ToLower()))
                                {
                                       // if the value happens to be empty set the property value to a C# null
                                    if (reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        prop.SetValue(thisRow, null, null);
                                    }
                                    else
                                    {
                                        //otherwise go ahead and assign the value as a C# readable value
                                        prop.SetValue(thisRow, reader[prop.Name], null);
                                    }
                                }
                            }
                            returnList.Add(thisRow);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw ex;
                    }
                    finally    // always runs whether the try ran successfully on an exception or 
                    {
                        if (conn.State != ConnectionState.Closed)
                        {
                            conn.Close();
                        }
                    }
                }

                return returnList;

            }
            
        }
        //ExecuteSqlNonQuer() - can be used for inserts, updates
        public static int ExecuteSqlNonQuery(string sql, CommandType cmdType)
        {
               // variable to hold the number of affected rows
            int num = 0;
            try
            {
                using (SqlConnection cnn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.CommandType = cmdType;
                        cmd.CommandTimeout = 30000;

                        cnn.Open();

                        num = cmd.ExecuteNonQuery();
                    }
                }
                return num;
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return num;
            }
        }

        //  Retieves a sing value. returns the value in the first column of the first row from the resultset.
        public static string ExecuteSqlScalar(string sql, CommandType cmdType)
        {
            string res = "";
            try
            {
                using (SqlConnection cnn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.CommandType = cmdType;
                        cmd.CommandTimeout = 30000;

                        cnn.Open();

                        var sqlResult = cmd.ExecuteScalar();

                        res = sqlResult.ToString();
                    }
                }
                return res;
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return res;
            }
        }

    }
}
