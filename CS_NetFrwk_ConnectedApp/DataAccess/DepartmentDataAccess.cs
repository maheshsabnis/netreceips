using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Using Models and Database Namespaces
using System.Data;
using System.Data.SqlClient;
using CS_NetFrwk_ConnectedApp.Models;

namespace CS_NetFrwk_ConnectedApp.DataAccess
{
    internal class DepartmentDataAccess : IDataAccess<Department, int> 
    {
        SqlConnection Conn;
        SqlCommand Cmd;
        private bool disposedValue;

        /// <summary>
        /// Instantite the SqlConnection by passing ConnectionString to
        /// Constructor of the SqlConnection
        /// </summary>
        public DepartmentDataAccess()
        {
            Conn = new SqlConnection("Data Source=.;Initial Catalog=Enterprise;Integrated Security=SSPI");
        }

        
         

        /// <summary>
        /// Create a new Department Record 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Department IDataAccess<Department, int>.Create(Department entity)
        {
            Department department = null;
            try
            {
                
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = $"Insert into Department Values({entity.DeptNo}, '{entity.DeptName}', '{entity.Location}',{entity.Capacity})";
                // Execute the Command Object
                int res = Cmd.ExecuteNonQuery();
                if (res == 0) // Some Error Occured
                {
                     department = null;
                }
                else
                { 
                    // if successful store the entity into the department
                    department = new Department();
                    department = entity;
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally // this will be executed irrespective of try or catch block
            {
                // if the Connection is still open the close it
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return department;
        }

        Department IDataAccess<Department, int>.Delete(int id)
        {
            Department department = new Department();
            try
            {
                
                    Conn.Open();
                    // Create paramerized query
                    Cmd.CommandText = "Delete From Department where DeptNo=@DeptNo";

                    SqlParameter pDeptNo = new SqlParameter();
                    pDeptNo.ParameterName = "@DeptNo";
                    pDeptNo.SqlDbType = SqlDbType.Int;
                    pDeptNo.Direction = ParameterDirection.Input;
                    pDeptNo.Value = id;


                    
                    // Add parameters into the Parameters Collection of the Command object
                    Cmd.Parameters.Add(pDeptNo);

                    // Call the execute method
                    int res = Cmd.ExecuteNonQuery();

                    if (res == 0)
                    {
                        department = null;
                    }
            }
            // for one try there can be multiple catch
            // make sure that the specific catch appears before 
            // the general catch (i.e. Exception class)
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return department;
        }

        IEnumerable<Department> IDataAccess<Department, int>.GetData()
        {
            List<Department> departments = new List<Department>(); 
            try
            {
                // Open
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "Select * from Department";
                SqlDataReader Reader = Cmd.ExecuteReader();

                // Iterate over the Reader for Department Rows
                while (Reader.Read())
                {
                    // Read each row using the Reader
                    // and add it into the departments list by storing
                    // each column value of the record into the Department object
                    departments.Add(
                          new Department() { 
                            DeptNo = Convert.ToInt32(Reader["DeptNo"]),
                            DeptName = Reader["DeptName"].ToString(),
                            Location = Reader["Location"].ToString(),
                            Capacity = Convert.ToInt32(Reader["Capacity"])
                          }
                        );
                }
                Reader.Close();
                // Close
                Conn.Close();
            }
            catch (SqlException ex)
            {


                throw ex;
            }
            finally // this will be executed irrespective of try or catch block
            {
                // if the Connection is still open the close it
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return departments;
        }
        /// <summary>
        /// Return a Single Record based on id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Department IDataAccess<Department, int>.GetData(int id)
        {
            Department department = new Department();   
            try
            {
                Conn.Open();
                // We can also pass the Command Tetx and Commection Object to the Constrctor
                Cmd = new SqlCommand($"Select * from Department where DeptNo = {id}", Conn);
                SqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    department.DeptNo = Convert.ToInt32(Reader["DeptNo"]);
                    department.DeptName = Reader["DeptName"].ToString();
                    department.Location = Reader["Location"].ToString();
                    department.Capacity = Convert.ToInt32(Reader["Capacity"]);
                }
                Reader.Close();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return department;
        }

        /// <summary>
        /// Using the Parameterized Query
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        Department IDataAccess<Department, int>.Update(int id, Department entity)
        {
            Department department = new Department();
            try
            {
                // check if id and the DeptNo value of the entity is same
                if (id == entity.DeptNo)
                {
                    Conn.Open();
                    // Create paramerized query
                    Cmd.CommandText = "Update Department Set DeptName=@DeptName, Location=@Location, Capacity=@Capacity where DeptNo=@DeptNo";

                    SqlParameter pDeptNo = new SqlParameter();
                    pDeptNo.ParameterName = "@DeptNo";
                    pDeptNo.SqlDbType = SqlDbType.Int;
                    pDeptNo.Direction = ParameterDirection.Input;
                    pDeptNo.Value = id;


                    SqlParameter pDeptName = new SqlParameter();
                    pDeptName.ParameterName = "@DeptName";
                    pDeptName.SqlDbType = SqlDbType.VarChar;
                    pDeptName.Size = 200;
                    pDeptName.Direction = ParameterDirection.Input;
                    pDeptName.Value = entity.DeptName;

                    SqlParameter pLocation = new SqlParameter();
                    pLocation.ParameterName = "@Location";
                    pLocation.SqlDbType = SqlDbType.VarChar;
                    pLocation.Size = 200;
                    pLocation.Direction = ParameterDirection.Input;
                    pLocation.Value = entity.Location;

                    SqlParameter pCapacity = new SqlParameter();
                    pCapacity.ParameterName = "@Capacity";
                    pCapacity.SqlDbType = SqlDbType.Int;
                    pCapacity.Direction = ParameterDirection.Input;
                    pCapacity.Value = entity.Capacity;

                    // Add parameters into the Parameters Collection of the Command object
                    Cmd.Parameters.Add(pDeptNo);
                    Cmd.Parameters.Add(pDeptName);
                    Cmd.Parameters.Add(pLocation);
                    Cmd.Parameters.Add(pCapacity);

                    // Call the execute method
                    int res = Cmd.ExecuteNonQuery();

                    if (res == 0)
                    {
                        department = null;
                    }
                    else
                    {
                        department = entity;
                    }
                }
                else
                {
                    throw new Exception($"the {id} and {entity.DeptNo} does not match");
                }
            }
            // for one try there can be multiple catch
            // make sure that the specific catch appears before 
            // the general catch (i.e. Exception class)
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return department;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~DepartmentDataAccess()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
           Conn.Dispose(); // Kill the Object
        }
    }
}
