using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_4_ASP_NET_List
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack) return;// Только для инициализации

            ArrayList tmp = new ArrayList();// Создать промежуточный источник
            tmp.Add("Hamburger");
            tmp.Add("Yoghurt");
            tmp.Add("Butter");
            tmp.Add("Milk");
            tmp.Add("Flour");
            tmp.Add("Sugar");
            tmp.Add("Cream");
            tmp.Add("Cheese");
            tmp.Add("Bread");
            ListBox1.DataSource = tmp;// Связать
            ListBox1.DataBind(); // Загрузить
            ListBox1.Rows = ListBox2.Rows = 10; // Высота списков в строках
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Создаем коллекцию для временного хранения строк списка
            ListItemCollection tmp = new ListItemCollection();

            // Перебираем левый список и ищем выделенное
            foreach (ListItem s in ListBox1.Items)
            {
                if (s.Selected)
                    tmp.Add(s);
            }

            // Слева уничтожаем, справа добавляем то, что нашли выделенное
            foreach (ListItem s in tmp)
            {
                ListBox1.Items.Remove(s);
                ListBox2.Items.Add(s);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Создаем коллекцию для временного хранения строк списка
            ListItemCollection tmp = new ListItemCollection();

            // Перебираем правый список и ищем выделенное
            foreach (ListItem s in ListBox2.Items)
            {
                if (s.Selected)
                    tmp.Add(s);
            }

            // Справа уничтожаем, слева добавляем то, что нашли выделенное
            foreach (ListItem s in tmp)
            {
                ListBox2.Items.Remove(s);
                ListBox1.Items.Add(s);
            }
        }

        protected void btnAllBasket_Click(object sender, EventArgs e)
        {
            // Создаем коллекцию для временного хранения строк списка
            ListItemCollection tmp = new ListItemCollection();

            // Перебираем левый список
            foreach (ListItem s in ListBox1.Items)
            {                
                    tmp.Add(s);
            }

            // Все добавляем  в корзину
            foreach (ListItem s in tmp)
            {                
                ListBox2.Items.Add(s);
            }
        }

        protected void btnDelAllBasket_Click(object sender, EventArgs e)
        {
            // Создаем коллекцию для временного хранения строк списка
            ListItemCollection tmp = new ListItemCollection();

            // Перебираем правый список
            foreach (ListItem s in ListBox2.Items)
            {
                tmp.Add(s);
            }

            // Все удаляем
            foreach (ListItem s in tmp)
            {                
                ListBox2.Items.Remove(s);
            }
        }
    }
}
    
