using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceReview
{
    public partial class Form1 : Form
    {
        List<Canadian> canadianList = new List<Canadian>();
        public Form1()
        {
            InitializeComponent();
        }

        public interface Canadian
        {
           
            string SayBonjour();

            string SaySorry();

            string SayPlease();
        }

        public abstract class Albertan : Canadian
        {
            public abstract string SayBonjour();

            public abstract string SaySorry();
            public string SayPlease() { return "Please"; }
            public virtual string GoToWEM()
            {
                return "Visited WEM";
            }
            public string DriveTruck()
            {
                return "Had Tailgate Party";
            }
        }

        public class Edmontonian:Albertan
        {
            public bool hasUpass;
            //no constructor is defined Diego was created successfully

            //as soon as the custom constructor defined, error, because the "freebee" constructor goes away
            public Edmontonian(bool Upass)
            {
                hasUpass = Upass;
            }

            public Edmontonian()
            {

            }

            public override string SayBonjour()
            {
                return "Bonjour";
            }

            public override string SaySorry()
            {
                return "Sorry";
            }

            public new string SayPlease()
            {
                return "Edmonton Please";
            }


        }

        public class NAITStudent:Edmontonian,Canadian
        {
            public string first, last;
            public NAITStudent(string first, string last) { 
            this.first = first;
            this.last = last;}

            public override string SaySorry()
            {
                return "Lo siento";
            }

            public new string SayPlease()
            {
                return "NO!";
            }

            //public abstract void ForLiam();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canadianList.Add(new NAITStudent("Diego", "Uwannano"));
        }
    }
}
