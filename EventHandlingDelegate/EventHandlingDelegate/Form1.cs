//demo based on MS site: https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler?view=net-7.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandlingDelegate
{
    public partial class Form1 : Form
    {
        Counter c;

        public Form1()
        {
            InitializeComponent();
            c = new Counter(new Random().Next(10)); //pass in random threshold
            c.ThresholdReached += C_ThresholdReached;

        }

        private void C_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            label1.Text = $"Threshold of {e.Threshold} reached at {e.TimeReached}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Add(1);
        }

        //counter event handler

    }

    class Counter
    {
        private int threshold;
        private int total;

        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold) 
            {
                //fire the Threshold reached event
                //populate the event arguments
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.Threshold = threshold;
                args.TimeReached = DateTime.Now;

                //fire the event
                OnThresholdReached(args);
            }
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        //publishing the event that this class offers
        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
    }

    //add event arguments that you want to use like this:
    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }

    
}
