using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PolyInterOper_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Person p = new Student();
            
            Person pt = new Teacher();

            Person[] peops = new Person[5];
            peops[0] = new Student() { FirstName = "Bob"};
            peops[1] = new Student() { FirstName = "Sushan"};
            peops[2] = new Student() { FirstName = "Meshari"};
            peops[3] = new Student() { FirstName = "Govinda"};
            peops[4] = new Teacher() { FirstName = "Jon"};


            //tbOut.Text = p.SayYourName();
            //tbOut.Text = pt.SayYourName();
            tbOut.Text = "";
            foreach(Person ps in peops)
            {
                if (ps.GetType() == typeof(Student)){
                    tbOut.Text += "s--";
                }
                else
                {
                    tbOut.Text += "T--";
                }
                     
              tbOut.Text += String.Format("{0} | {1}\r\n",
                   ps.SayYourName(), ps.GetType());

            }

            ISayTeacher st = new Student();
            ISayTeacher rm = new Room();
            //ISayTeacher th = new Teacher();
            //ISayTeacher pr = new Person();
            //ISayTeacher ob = new object();

            
            

        }
    }
}
