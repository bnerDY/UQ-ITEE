﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac4LINQ
{
    public partial class AppointmentRescheduling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                LINQDatabaseService service = new LINQDatabaseService();
                Appointment ap = service.GetAppointment(txtPatientFirstName.Text, txtPatientLastName.Text, txtDoctorFirstName.Text, txtDoctorLastName.Text);
                if (ap == null)
                {
                    lblResult.Text = "Not found";
                }
                else
                {
                    txtDate.Text = ap.datetime.Date.ToShortDateString();
                    txtTime.Text = ap.datetime.TimeOfDay.ToString();
                    txtClinicName.Text = ap.clinicname;
                    txtDoctorFirstName.ReadOnly = true;
                    txtDoctorLastName.ReadOnly = true;
                    txtPatientFirstName.ReadOnly = true;
                    txtPatientLastName.ReadOnly = true;
                    txtClinicName.ReadOnly = true;
                }

            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
        }

        protected void btnReschedule_Click(object sender, EventArgs e)
        {
            try
            {
                LINQDatabaseService service = new LINQDatabaseService();
                bool success= service.AppointmentReschedule(txtPatientFirstName.Text, txtPatientLastName.Text, txtDoctorFirstName.Text, txtDoctorLastName.Text, Convert.ToDateTime(txtDate.Text + " " + txtTime.Text));
                if (success)
                {
                    lblResult.Text = "Updated Successfully";
                }
                else
                {
                    lblResult.Text = "Exception Happened";
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
        }
    }
}