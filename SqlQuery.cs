using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELKOJlogTranEmpOrg
{
    internal class SqlQuery : Common
    {
        public string InsertTbInfOrgInfo(Hashtable _hashtable)
        {
            SqlConnection Con = null;
            string result = string.Empty;

            try
            {
                using (Con = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Cmd = new SqlCommand())
                    {
                        Cmd.Connection = Con;

                        Cmd.CommandText = "Insert into tb_inf_org_info"
                                        + " (org_name, org_etc_cd1, brand_nm, org_etc_cd2, store_nm, org_etc_cd3, area_type, org_type_cd"
                                        + " , zip_no, addr1, addr2, addr3, addr4, city, city2, tel_no, fax_no, email, user_id, sta_ymd, end_ymd) "
                                        + " values "
                                        + " (@org_name, @org_etc_cd1, @brand_nm, @org_etc_cd2, @store_nm, @org_etc_cd3, @area_type, @org_type_cd"
                                        + " , @zip_no, @addr1, @addr2, @addr3, @addr4, @city, @city2, @tel_no, @fax_no, @email, @user_id, @sta_ymd, @end_ymd) ";
                        Cmd.CommandType = CommandType.Text;

                        Cmd.Parameters.Add("@org_name", SqlDbType.VarChar, 100);
                        Cmd.Parameters.Add("@org_etc_cd1", SqlDbType.VarChar, 10);
                        Cmd.Parameters.Add("@brand_nm", SqlDbType.VarChar, 50);
                        Cmd.Parameters.Add("@org_etc_cd2", SqlDbType.VarChar, 10);
                        Cmd.Parameters.Add("@store_nm", SqlDbType.VarChar, 50);
                        Cmd.Parameters.Add("@org_etc_cd3", SqlDbType.VarChar, 10);
                        Cmd.Parameters.Add("@area_type", SqlDbType.VarChar, 30);
                        Cmd.Parameters.Add("@org_type_cd", SqlDbType.VarChar, 3);
                        Cmd.Parameters.Add("@zip_no", SqlDbType.VarChar, 6);
                        Cmd.Parameters.Add("@addr1", SqlDbType.VarChar, 200);
                        Cmd.Parameters.Add("@addr2", SqlDbType.VarChar, 200);
                        Cmd.Parameters.Add("@addr3", SqlDbType.VarChar, 200);
                        Cmd.Parameters.Add("@addr4", SqlDbType.VarChar, 200);
                        Cmd.Parameters.Add("@city", SqlDbType.VarChar, 20);
                        Cmd.Parameters.Add("@city2", SqlDbType.VarChar, 20);
                        Cmd.Parameters.Add("@tel_no", SqlDbType.VarChar, 15);
                        Cmd.Parameters.Add("@fax_no", SqlDbType.VarChar, 15);
                        Cmd.Parameters.Add("@email", SqlDbType.VarChar, 50);
                        Cmd.Parameters.Add("@user_id", SqlDbType.VarChar, 50);
                        Cmd.Parameters.Add("@sta_ymd", SqlDbType.VarChar, 50);
                        Cmd.Parameters.Add("@end_ymd", SqlDbType.VarChar, 50);

                        Cmd.Parameters["@org_name"].Value = _hashtable["org_name"];
                        Cmd.Parameters["@org_etc_cd1"].Value = _hashtable["org_etc_cd1"];
                        Cmd.Parameters["@brand_nm"].Value = _hashtable["brand_nm"];
                        Cmd.Parameters["@org_etc_cd2"].Value = _hashtable["org_etc_cd2"];
                        Cmd.Parameters["@store_nm"].Value = _hashtable["store_nm"];
                        Cmd.Parameters["@org_etc_cd3"].Value = _hashtable["org_etc_cd3"];
                        Cmd.Parameters["@area_type"].Value = _hashtable["area_type"];
                        Cmd.Parameters["@org_type_cd"].Value = _hashtable["org_type_cd"];
                        Cmd.Parameters["@zip_no"].Value = _hashtable["zip_no"];
                        Cmd.Parameters["@addr1"].Value = _hashtable["addr1"];
                        Cmd.Parameters["@addr2"].Value = _hashtable["addr2"];
                        Cmd.Parameters["@addr3"].Value = _hashtable["addr3"];
                        Cmd.Parameters["@addr4"].Value = _hashtable["addr4"];
                        Cmd.Parameters["@city"].Value = _hashtable["city"];
                        Cmd.Parameters["@city2"].Value = _hashtable["city2"];
                        Cmd.Parameters["@tel_no"].Value = _hashtable["tel_no"];
                        Cmd.Parameters["@fax_no"].Value = _hashtable["fax_no"];
                        Cmd.Parameters["@email"].Value = _hashtable["email"];
                        Cmd.Parameters["@user_id"].Value = _hashtable["user_id"];
                        Cmd.Parameters["@sta_ymd"].Value = _hashtable["sta_ymd"];
                        Cmd.Parameters["@end_ymd"].Value = _hashtable["end_ymd"];

                        Con.Open();

                        Cmd.ExecuteNonQuery().ToString();

                        Con.Close();

                        result = Success;
                    }
                }
            }
            catch (Exception ex)
            {
                result = Fail + "[tb_inf_org_info insert] " + ex.Message;
            }
            finally
            {
                if (Con != null) Con.Close();
            }

            return result;
        }

        public string InsertTbInfEmpInfo(Hashtable _hashtable)
        {
            SqlConnection Con = null;
            string result = string.Empty;

            try
            {
                using (Con = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Cmd = new SqlCommand())
                    {
                        Cmd.Connection = Con;

                        Cmd.CommandText = " Insert into tb_inf_emp_info"
                                        + " (emp_no, user_id, emp_nm, eng_nm, assignment_no, primary_assignment_flag, org_name, org_type_cd, org_etc_cd1, ent_ymd, emp_status, org_cd, org_emp_no, solar_type"
                                        + " , birth_ymd, hire_ym, year_num, dept_name, pos_grd_nm, email, phone_no, cell_no) "
                                        + " values "
                                        + " (@emp_no, @user_id, @emp_nm, @eng_nm, @assignment_no, @primary_assignment_flag, @org_name, @org_type_cd, @org_etc_cd1, @ent_ymd, @emp_status, @org_cd, @org_emp_no, @solar_type"
                                        + " , @birth_ymd, @hire_ym, @year_num, @dept_name, @pos_grd_nm, @email, @phone_no, @cell_no) ";
                        Cmd.CommandType = CommandType.Text;

                        Cmd.Parameters.Add("@emp_no", SqlDbType.VarChar, 50);
                        Cmd.Parameters.Add("@user_id", SqlDbType.VarChar, 50);
                        Cmd.Parameters.Add("@emp_nm", SqlDbType.VarChar, 100);
                        Cmd.Parameters.Add("@eng_nm", SqlDbType.VarChar, 100);
                        Cmd.Parameters.Add("@assignment_no", SqlDbType.VarChar, 100);
                        Cmd.Parameters.Add("@primary_assignment_flag", SqlDbType.VarChar, 10);
                        Cmd.Parameters.Add("@org_name", SqlDbType.VarChar, 500);
                        Cmd.Parameters.Add("@org_type_cd", SqlDbType.VarChar, 10);
                        Cmd.Parameters.Add("@org_etc_cd1", SqlDbType.VarChar, 50);
                        Cmd.Parameters.Add("@ent_ymd", SqlDbType.VarChar, 50);
                        Cmd.Parameters.Add("@emp_status", SqlDbType.VarChar, 50);
                        Cmd.Parameters.Add("@org_cd", SqlDbType.VarChar, 50);
                        Cmd.Parameters.Add("@org_emp_no", SqlDbType.VarChar, 50);
                        Cmd.Parameters.Add("@solar_type", SqlDbType.VarChar, 20);
                        Cmd.Parameters.Add("@birth_ymd", SqlDbType.VarChar, 50);
                        Cmd.Parameters.Add("@hire_ym", SqlDbType.VarChar, 30);
                        Cmd.Parameters.Add("@year_num", SqlDbType.VarChar, 20);
                        Cmd.Parameters.Add("@dept_name", SqlDbType.VarChar, 500);
                        Cmd.Parameters.Add("@pos_grd_nm", SqlDbType.VarChar, 500);
                        Cmd.Parameters.Add("@email", SqlDbType.VarChar, 500);
                        Cmd.Parameters.Add("@phone_no", SqlDbType.VarChar, 50);
                        Cmd.Parameters.Add("@cell_no", SqlDbType.VarChar, 50);

                        Cmd.Parameters["@emp_no"].Value = _hashtable["emp_no"];
                        Cmd.Parameters["@user_id"].Value = _hashtable["user_id"];
                        Cmd.Parameters["@emp_nm"].Value = _hashtable["emp_nm"];
                        Cmd.Parameters["@eng_nm"].Value = _hashtable["eng_nm"];
                        Cmd.Parameters["@assignment_no"].Value = _hashtable["assignment_no"];
                        Cmd.Parameters["@primary_assignment_flag"].Value = _hashtable["primary_assignment_flag"];
                        Cmd.Parameters["@org_name"].Value = _hashtable["org_name"];
                        Cmd.Parameters["@org_type_cd"].Value = _hashtable["org_type_cd"];
                        Cmd.Parameters["@org_etc_cd1"].Value = _hashtable["org_etc_cd1"];
                        Cmd.Parameters["@ent_ymd"].Value = _hashtable["ent_ymd"];
                        Cmd.Parameters["@emp_status"].Value = _hashtable["emp_status"];
                        Cmd.Parameters["@org_cd"].Value = _hashtable["org_cd"];
                        Cmd.Parameters["@org_emp_no"].Value = _hashtable["org_emp_no"];
                        Cmd.Parameters["@solar_type"].Value = _hashtable["solar_type"];
                        Cmd.Parameters["@birth_ymd"].Value = _hashtable["birth_ymd"];
                        Cmd.Parameters["@hire_ym"].Value = _hashtable["hire_ym"];
                        Cmd.Parameters["@year_num"].Value = _hashtable["year_num"];
                        Cmd.Parameters["@dept_name"].Value = _hashtable["dept_name"];
                        Cmd.Parameters["@pos_grd_nm"].Value = _hashtable["pos_grd_nm"];
                        Cmd.Parameters["@email"].Value = _hashtable["email"];
                        Cmd.Parameters["@phone_no"].Value = _hashtable["phone_no"];
                        Cmd.Parameters["@cell_no"].Value = _hashtable["cell_no"];

                        Con.Open();

                        Cmd.ExecuteNonQuery().ToString();

                        Con.Close();

                        result = Success;
                    }
                }
            }
            catch (Exception ex)
            {
                result = Fail + "[tb_inf_emp_info insert] " + ex.Message;
            }
            finally
            {
                if (Con != null) Con.Close();
            }

            return result;
        }
    }
}