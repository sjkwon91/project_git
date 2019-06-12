using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELKOJlogTranEmpOrg
{
    internal class DataProcess : Common
    {
        private Hashtable hashTable = new Hashtable();

        public void ReadData(string fileName)
        {
            string result = string.Empty;
            int errorCount = 0;

            if (CheckFileExist(fileName))
            {
                string[] textValue = System.IO.File.ReadAllLines(FilePath(fileName));

                if (textValue.Length > 0)
                {
                    for (int i = 0; i < textValue.Length; i++)
                    {
                        string[] textList = textValue[i].Split(FileSplitMark);

                        if (fileName.Equals(EmpFileName))
                            result = InsertEmpData(textList);
                        else if (fileName.Equals(DeptFileName))
                            result = InsertOrgData(textList);

                        hashTable.Clear();

                        if (!result.Equals(Success))
                        {
                            WriteLogResult(result + "(" + i + ")", fileName); // 로직 실패 결과 기록
                            errorCount++;
                        }
                    }

                    WriteLogResult("finish > error Count : " + errorCount, fileName); // DB 데이터 삽입 성공
                }
                else
                {
                    WriteLogResult(Fail + "[File Content Empty] ", fileName); // 파일 안에 내용이 아무것도 없을 때
                }
            }
            else
            {
                WriteLogResult(Fail + "[File Not Exist] ", fileName); // 파일이 존재 하지 않을 때
            }
        }

        public string InsertEmpData(string[] textList)
        {
            try
            {
                hashTable.Add("emp_no", textList[0]);
                hashTable.Add("user_id", textList[1]);
                hashTable.Add("emp_nm", textList[2]);
                hashTable.Add("eng_nm", textList[3]);
                hashTable.Add("assignment_no", textList[4]);
                hashTable.Add("primary_assignment_flag", textList[5]);
                hashTable.Add("org_name", textList[6]);
                hashTable.Add("org_type_cd", textList[7]);
                hashTable.Add("org_etc_cd1", textList[8]);
                hashTable.Add("ent_ymd", textList[9]);
                hashTable.Add("emp_status", textList[10]);
                hashTable.Add("org_cd", textList[11]);
                hashTable.Add("org_emp_no", textList[12]);
                hashTable.Add("solar_type", textList[13]);
                hashTable.Add("birth_ymd", textList[14]);
                hashTable.Add("hire_ym", textList[15]);
                hashTable.Add("year_num", textList[16]);
                hashTable.Add("dept_name", textList[17]);
                hashTable.Add("pos_grd_nm", textList[18]);
                hashTable.Add("email", textList[19]);
                hashTable.Add("phone_no", textList[20]);
                hashTable.Add("cell_no", textList[21]);
            }
            catch (Exception ex)
            {
                return Fail + "[EmpData hashTable.Add] " + ex.Message;
            }

            return new SqlQuery().InsertTbInfEmpInfo(hashTable);
        }

        public string InsertOrgData(string[] textList)
        {
            try
            {
                hashTable.Add("org_name", textList[0]);
                hashTable.Add("org_etc_cd1", textList[1]);
                hashTable.Add("brand_nm", textList[2]);
                hashTable.Add("org_etc_cd2", textList[3]);
                hashTable.Add("store_nm", textList[4]);
                hashTable.Add("org_etc_cd3", textList[5]);
                hashTable.Add("area_type", textList[6]);
                hashTable.Add("org_type_cd", textList[7]);
                hashTable.Add("zip_no", textList[8]);
                hashTable.Add("addr1", textList[9]);
                hashTable.Add("addr2", textList[10]);
                hashTable.Add("addr3", textList[11]);
                hashTable.Add("addr4", textList[12]);
                hashTable.Add("city", textList[13]);
                hashTable.Add("city2", textList[14]);
                hashTable.Add("tel_no", textList[15]);
                hashTable.Add("fax_no", textList[16]);
                hashTable.Add("email", textList[17]);
                hashTable.Add("user_id", textList[18]);
                hashTable.Add("sta_ymd", textList[19]);
                hashTable.Add("end_ymd", textList[20]);
            }
            catch (Exception ex)
            {
                return Fail + "[OrgData hashTable.Add] " + ex.Message;
            }

            return new SqlQuery().InsertTbInfOrgInfo(hashTable);
        }
    }
}