using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_3_ASP_NET_ListBoxDeleteEditing
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {     
           if (Page.IsPostBack) return;

            int count = 0;

            ArrayList tmp = new ArrayList();

            lblTitle.Text = "<h1 style='color: #FF0000'>ListBox Example "
           + "Add Editing Delete</h1>";

            object objCount = ViewState["count"];
            object objTmp = ViewState["arrTmp"];

            if (objTmp != null)
            {
                tmp = (ArrayList)objTmp;
            }
            tmp.Add("Hamburger");
            tmp.Add("Yoghurt");
            tmp.Add("Butter");
            tmp.Add("Milk");
            tmp.Add("Flour");
            tmp.Add("Sugar");
            tmp.Add("Cream");
            tmp.Add("Cheese");
            tmp.Add("Bread");
            ViewState["arrTmp"] = tmp;

            if (objCount != null)
            {
                count = (int)objCount;
            }
            ViewState["count"] = count;
            ListBox1.DataSource = tmp;
            ListBox1.DataBind();
            count = ListBox1.Items.Count;
            ViewState["count"] = count;
            ListBox1.Items[count - 1].Selected = true;

            txtAdd.Text = txtEdit.Text = txtEdit.Text = "";           
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ListItemCollection tmp = new ListItemCollection();

            tmp.Add(txtAdd.Text);
            ListBox1.Items.Add(tmp[0]);           
            txtAdd.Text = "";           
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            

            if (txtEdit.Text == "")
            {
                // Создаем коллекцию для временного хранения строк списка
                ListItemCollection tmp = new ListItemCollection();

                // Перебираем список и ищем выделенное
                foreach (ListItem s in ListBox1.Items)
                {
                    if (s.Selected) tmp.Add(s);
                }
                // Выводим выделенное
                foreach (ListItem s in tmp)
                {
                    txtEdit.Text += s;
                }
            }

            else
            {
                // Создаем коллекцию для временного хранения строк списка
                ListItemCollection tmp = new ListItemCollection();

                // Перебираем список и ищем выделенное
                foreach (ListItem s in ListBox1.Items)
                {
                    if (s.Selected) tmp.Add(s);
                }

                // Выводим выделенное
                foreach (ListItem s in tmp)
                {
                    ListBox1.Items.Remove(s);
                    ListBox1.Items.Add(txtEdit.Text);
                }

                txtEdit.Text = "";
            }
            
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем коллекцию для временного хранения строк списка
                ListItemCollection tmp = new ListItemCollection();

                // Перебираем список и ищем выделенное
                foreach (ListItem s in ListBox1.Items)
                {
                    if (s.Selected)
                    {
                        tmp.Add(s);

                    }
                }

                txtDel.Text += tmp[0];

                // уничтожаем
                foreach (ListItem s in tmp)
                {
                    ListBox1.Items.Remove(s);
                }

                Thread.Sleep(3000);
                txtDel.Text = "";
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }
    }
}