using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_LL_Dictionary
{
    public partial class Form1 : Form
    {
        LinkedList<int> ints = new LinkedList<int>();
        Random rand = new Random();

        //DICTIONARY stuff
        Dictionary<string,string> websters = new Dictionary<string,string>();
        public Form1()
        {
            InitializeComponent();

            //add new elements to the head of the linked list
            while (ints.Count < 10)
                ints.AddFirst(rand.Next(100));

            //can you put LinkedList into a List?
            List<int> list = new List<int>(ints);
            UpdateListBox();

            //experiment
            

            
        }

        public void UpdateListBox()
        {
            ShowLLInConsole();
            listBox1.DataSource = null;
            listBox1.DataSource = ints.ToList();
        }

        public void ShowLLInConsole()
        {
            foreach (int i in ints)
                Console.Write(i.ToString() + ", ");
            Console.WriteLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberToFind;
            int numberToAdd;

            if (!int.TryParse(txtNumberToAdd.Text, out numberToAdd))
            {
                Console.Write("Invalid Number");
                return;
            }
            if (!int.TryParse(txtNumberLookingFor.Text, out numberToFind))
            {
                Console.Write("Invalid Number");
                return;
            }

            //find the number we're looking for in the linked list
            //NODE TRAVERSAL
            LinkedListNode<int> scan = ints.First;

            while (scan != null)
            {
                if (scan.Value == numberToFind)
                {
                    //add a number to the next spot
                    ints.AddAfter(scan, numberToAdd);
                    break;
                }
                scan = scan.Next;
            }

            UpdateListBox();
        }

        private void btnAddDict_Click(object sender, EventArgs e)
        {
            //add the word and definition
            websters.Add(txtDict1.Text, txtDict2.Text);

            //add to word listbox
            List<string> words = new List<string>(websters.Keys);

            lbDictionaryWords.DataSource = null;
            lbDictionaryWords.DataSource = words;
        }

        private void lbDictionaryWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            //how do we get the selected index?
            string word = lbDictionaryWords?.SelectedValue?.ToString();

            //populate the label
            if (word != null)
                lblDefinition.Text = websters[word];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> pair in websters)
            {
                Console.WriteLine(pair.Key + ", " + pair.Value);
            }
        }
    }
}
