using Models;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Collections.Generic;

namespace Repositories
{
    public class CarRepository
    {

        string strConnection;
        SqlConnection conn;

        public CarRepository()
        {
            strConnection += "Data Source=127.0.0.1;"; // Server
            strConnection += "Initial Catalog=DBCar;"; //DataBase
            strConnection += " User Id=sa; Password=SqlServer2019!;";//User and Password
            strConnection += "TrustServerCertificate=Yes;";//certificate
            conn = new SqlConnection(strConnection);
            conn.Open();
        }


        public bool Insert(Car car)
        {
            bool result = false;

            try
            {            
                SqlCommand cmd = new SqlCommand(Car.Insert, conn);
                cmd.Parameters.AddWithValue("@Name", car.Name);
                cmd.Parameters.AddWithValue("@Color", car.Color);
                cmd.Parameters.AddWithValue("@Year", car.Year);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                return result;

            }
            finally
            {
                conn.Close();
            }
            
            return result;
        }
        public bool Update(Car car) 
        {
            bool result = false;

            try
            {                
                SqlCommand cmd = new SqlCommand(Car.Update, conn);
                cmd.Parameters.AddWithValue("@Name", car.Name);
                cmd.Parameters.AddWithValue("@Color", car.Color);
                cmd.Parameters.AddWithValue("@Year", car.Year);
                cmd.Parameters.AddWithValue("@id", car.Id);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                return result;

            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public bool Delete(int id) 
        {
            bool result = false;

            try
            {              
                SqlCommand cmd = new SqlCommand(Car.Delete, conn);
                cmd.Parameters.AddWithValue("@id",id);                
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    result = true;
            }
            catch (Exception)
            {
                return result;

            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public Car GetById(int id) 
        {
            Car car = new Car();
            StringBuilder sb = new StringBuilder();
            sb.Append(Car.GetById);

            try
            {
               SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    car.Id = Convert.ToInt32(dr["Id"]);
                    car.Name = dr["Name"].ToString();
                    car.Color = dr["Color"].ToString();
                    car.Year = Convert.ToInt32(dr["Year"]);
                    
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return car;
        }

        public List<Car> GetAll() 
        {
            List <Car> list = new List<Car>();
            StringBuilder sb = new StringBuilder();
            sb.Append(Car.GetAll);
            // or
            //sb.Append("SELECT       Id, ");
            //sb.Append("             Name, ");
            //sb.Append("             Color, ");
            //sb.Append("             Year ");
            //sb.Append("FROM TB_Car");

            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Car()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = dr["Name"].ToString(),
                        Color = dr["Color"].ToString(),
                        Year = Convert.ToInt32(dr["Year"])
                    });
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();   
            }
            return list;
        }
    }
}
