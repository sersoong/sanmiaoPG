using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace sanmiaoPG
{
    
    public partial class Form1 : Form
    {
        string host = "localhost";
        string user = "postgres";
        string password = "root";
        string port = "5432";
        string database = "demo";

        string ConStr = "";
        public Form1()
        {   
            ConStr = string.Format("PORT={0};DATABASE={1};HOST={2};PASSWORD={3};USER ID={4}", port,database,host,password,user);
            InitializeComponent();
        }
    }
}
