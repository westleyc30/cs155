using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework12
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<person> myList = new List<person>();
            person p1 = new person("Mark", 12, 6.2);
            person p2 = new person("Jim", 3, 5.0);
            person p3 = new person("Barry", 5, 4.2);
            person p4 = new person("Jebney", 15, 6.3);
            person p5 = new person("Eris", 22, 5.2);
            person p6 = new person("Parker", 11, 6.2);
            person p7 = new person("El", 10, 4.4);
            person p8 = new person("Bill", 12, 4.2);
            person p9 = new person("Bet", 12, 4.5);
            person p10 = new person("Mak", 12, 4.7);

            myList.Add(p1);
            myList.Add(p2);
            myList.Add(p3);
            myList.Add(p4);
            myList.Add(p5);
            myList.Add(p6);
            myList.Add(p7);
            myList.Add(p8);
            myList.Add(p9);
            myList.Add(p10);

            // FIRST REQUIREMENT
            // PersonGridView.DataSource = from a in myList select a;
            // PersonGridView.DataSource = from a in myList where a.Age <= 12 select a;
            // PersonGridView.DataBind();

            // SECOND REQUIREMENT average height
            // count how many people
            int personCount = (from pa in myList
                               orderby pa.Name, pa.Height, pa.Age
                               select pa).Count();

            double average = 0;
            double sum = 0;
            foreach(var pp in myList)
            {
                sum += pp.Height;
            }
            average = sum / personCount;

            PersonGridView.DataSource = from a in myList where a.Height >= average && a.Age <= 12 select a;
            PersonGridView.DataBind();


        }
        public class person
        {
            String name;
            int age;
            double height;
            
            public person()
            {

            }
            public person(String name, int age, double height)
            {
                this.Name = name;
                this.Age = age;
                this.Height = height;
            }

            
            public int Age { get => age; set => age = value; }
            public string Name { get => name; set => name = value; }
            public double Height { get => height; set => height = value; }
        }
    }
}