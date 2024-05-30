using Models;
using Microsoft.Data.SqlClient; 

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
                string query = "INSERT INTO TB_Car (Name, Color, Year) VALUES (@Name, @Color, @Year)";
                SqlCommand cmd = new SqlCommand(query, conn);
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
            
    
                return true;
        }
        public bool Delete(int id) 
        {
            
    
                return true;
        }
        public Car GetById(int id) 
        {
            
    
                return new Car();
        }
        public List<Car> GetAll() 
        {
            
    
                return new List<Car>();
        }

    }
}
