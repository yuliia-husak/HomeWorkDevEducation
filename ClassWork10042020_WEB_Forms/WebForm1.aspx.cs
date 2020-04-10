using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassWork10042020_WEB_Forms
{
    public partial class WebForm1 : System.Web.UI.Page    {
        private bool saveNested;


        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    //Output.Text = "Hello world! Time on server " + DataTime.Now.ToLongTimeString();
        //}


        //protected void AddOneBtn_Click(object sender, EventArgs e)
        //{
        //    int counter = 0;
        //    object obj = ViewState["counter"];

        //    if (obj != null)
        //    {
        //        counter = (int)obj;
        //    }
        //    counter += 1;
        //    ViewState["counter"] = counter;
        //}

        //protected void AddTwoBtn_Click(object sender, EventArgs e)
        //{
        //    int counter = 0;
        //    object obj = ViewState["counter"];

        //    if (obj != null)
        //    {
        //        counter = (int)obj;
        //    }
        //    counter += 2;
        //    ViewState["counter"] = counter;
        //}

        //protected void Page_LoadComplete(object sender, EventArgs e)
        //{
        //    CounterLabel.Text = Convert.ToString(ViewState["counter"]);
        //}

        protected void Page_Load(object sender, EventArgs e) { }
        protected void cmdSave_Click(object sender, EventArgs e)
        {
            SaveAllText(Page.Controls, true);
        }

        private void SaveAllText(ControlCollection controls, bool v)
        {
            foreach(Control control in controls)
            {
                if(control is TextBox)
                {
                    ViewState[control.ID] = ((TextBox)control).Text;
                }
                if((control.Controls !=null)&& saveNested)
                {
                    SaveAllText(control.Controls, true);
                }
            }
        }

        private void RestoreAllText(ControlCollection controls, bool saveNested)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    if(ViewState[control.ID]!=null)
                    ((TextBox)control).Text=(string)ViewState[control.ID];
                }
                if ((control.Controls != null) && saveNested)
                {
                    RestoreAllText(control.Controls, true);
                }
            }
        }

        protected void cmdRestore_Click(object sender, EventArgs e)
        {
            RestoreAllText(Page.Controls, true);
        }
    }
}