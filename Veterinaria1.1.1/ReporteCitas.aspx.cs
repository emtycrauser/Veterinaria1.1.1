﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Veterinaria1._1._1
{
    public partial class ReporteUsuario : System.Web.UI.Page
    {
        string conexion2 = "Data Source=DESKTOP-VCSUPFU\\SQLEXPRESS;Initial Catalog=ReporteCitas;Integrated Security=True";


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        protected void btnIngresar2_Click(object sender, EventArgs e)
        {


            using (SqlConnection cn = new SqlConnection(conexion2))
            {
                SqlCommand cmd = new SqlCommand("insert into Citas(Mascota,Fecha,Doctor) values  (" + txtMascota.Text + ",'" + txtFecha.Text + "','" + txtDoctor.Text + " ')", cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();

            }


        }

        protected void btnModificar2_Click(object sender, EventArgs e)


        {

            using (SqlConnection cn = new SqlConnection(conexion2))
            {
                SqlCommand cmd = new SqlCommand("update Citas set Mascota = '" + txtMascota.Text + "',contrasena = '" + txtFecha.Text + "' where id =" + txtDoctor.Text + "", cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();
            }








        }


        protected void btnEliminar2_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(conexion2))
            {
                SqlCommand cmd = new SqlCommand("delete from Citas where Mascota = " + txtMascota.Text, cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();
            }






        }




    }
}  
    
               
     