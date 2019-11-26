using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Data;
using System.Windows.Forms;

namespace T
{
    
    class Class1
    {
        //Users Difinations
        public static string UserName;
        public static int UserId;
        public static string CompanyName;
        public static int CompanyId;
        public static string BranchName;
        public static int BranchId;
        public static int FiscalYear;


        //Permissions Definitions as Boolean
        public static Boolean IsAdmin;

        // Server Definition
        public static SqlConnection CN = new SqlConnection();
        public static string CNS;
        public static SqlCommand CMD = new SqlCommand();
        
        // connecting to server
        public static void OpenConnection()
        {
            try
            {
                CNS = File.ReadAllText("CNS.txt");
                CN.Close();
                CN.ConnectionString = CNS;
                if (CN.State == ConnectionState.Closed)
                {
                    CN.Open();
                    //System.Windows.MessageBox.Show("تم الدخول الى السيرفر بنجاح","",MessageBoxButton.OK, MessageBoxImage.Information);
                    
                }

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        // Execute Query
        public static DataTable ExecQuery(string ProcedureName)
        {
            try
            {
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = ProcedureName;
                SqlDataAdapter DA = new SqlDataAdapter(CMD);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                return DS.Tables[0];
            }
            catch (Exception)
            {
                throw;
            }
            
            
        }

        
        // Execute Non Query 
        public static int ExecNonQuery(string ProcedureName)
        {
            try
            {
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = ProcedureName;
                //CMD.Parameters.AddWithValue(ParaName, ParaValue);
                CMD.ExecuteNonQuery();
                return 0;
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        //Fill Combobox

        public static void AddPara(string ParaName, String ParaId)
        {
            
            CMD.Parameters.AddWithValue(ParaName, ParaId);
            
        }
        
        public static void FillComboBox(ComboBox Combo, string ProcedureName, string DisplayMember, string ValueMember)
        {
            Combo.DataSource = ExecQuery(ProcedureName);
            Combo.DisplayMember = DisplayMember;
            Combo.ValueMember = ValueMember;
            Combo.Text = "";
        }

    }

   
}
