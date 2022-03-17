using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Koneksi
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }

        public void Connecting()
        {

            SqlConnection con = null;

            try
            {
                con = new SqlConnection("data source = MARSHAL51 ;" + "database=ProdiTI;Integrated Security = True");
                con.Open();

                SqlCommand cm = new SqlCommand("Create Table Mahasiswa (NIM Char(12) not null primary key, Nama Varchar(50), Jenis_kelamin Varchar(5))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Create tabel Berhasil");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }
            finally
            {
                con.Close();
            }
        }
   }
}
