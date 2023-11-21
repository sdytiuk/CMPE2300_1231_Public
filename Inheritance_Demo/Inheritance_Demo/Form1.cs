using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace Inheritance_Demo
{
    public partial class Form1 : Form
    {
        //create a CBallDrawer
        Aiden ballCanvas = new Aiden();
        CBallDrawer canvas1, canvas2;

        

        public Form1()
        {
            InitializeComponent();
            ballCanvas.DrawBall(new Point(20,20));

            //what if we want to draw a rectangle?
            ballCanvas.AddRectangle(50, 50, 100, 100, Color.Blue);
            //this uses the overrwitten clear
            ballCanvas.Clear();

            //what if we upcast?
            //because we upcasted, the CDrawer clear gets invoked
            ((CDrawer)ballCanvas).Clear();
            canvas1.AddSignature();
            ballCanvas.AddSignature();

            ballCanvas.Render();
            canvas1 = new CBallDrawer();
            canvas2 = new CBallDrawer();

            Console.WriteLine(((CDrawer)canvas1).Equals(((CDrawer)canvas2)));
        }
    }

    //let's create a child class of CDrawer called CBalls
    public class CBallDrawer : CDrawer
    {
        //constructor
        //we'll always create a canvas of 400x400
        //leverage the constructor of the parent
        public CBallDrawer() : base(400,400,false) 
        {
            //we always want our canvas to be white background
            BBColour = Color.White;

            //if I want a handle to THIS canvas...
            this.BBColour = Color.White;
        }

        public void DrawBall(Point where)
        {
            AddCenteredEllipse(where, 10, 10, Color.Red);
            Render();
        }

        //mischievious child will add an unknown shape type when trying to clear the canvas
        public new void Clear()
        {
            DrawBall(new Point(33, 33));
            Render();
        }

        public virtual void AddSignature()
        {
            AddText("I am only a child.", 14);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is CBallDrawer c)) return false;
            return c.ScaledWidth == ScaledWidth && c.ScaledHeight == ScaledHeight;
        }

        public override int GetHashCode()
        {
            return 1;
        }

    }

    //Brian wants to be a child class of the child class
    public class Brian : CBallDrawer
    {
        //get a constructor for free

        public override void AddSignature()
        {
            //base.AddSignature();
            AddText("I am still only a child.", 14);
        }
        
    }

    public class Aiden : Brian
    {
        //get a constructor for free


        public override void AddSignature()
        {
            base.AddSignature();
        }
    }


}
