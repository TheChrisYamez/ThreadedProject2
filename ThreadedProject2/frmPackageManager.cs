﻿using System;
using DBConnector;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProject2
{
    public partial class frmPackageManager : Form
    {
        public frmPackageManager()
        {
            InitializeComponent();

            System.Data.SqlClient.SqlConnection connect = DBConnector.TravelExpertsConnection.GetConnection();
            connect.Open();
        }
    }
}
