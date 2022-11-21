using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABC_Hospital
{
    public partial class PatientLogin: Form
    {
        public static PatientLogin PatientLoginInstance;
        public PatientLogin()
        {
           
            PatientLogin AdminLoginInstance = this;
        }
        SqlConnection conn = new SqlConnection();
    }




}
