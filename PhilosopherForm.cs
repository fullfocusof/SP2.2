using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SP2._2
{
    public partial class PhilosopherForm : Form
    {
        private static int limitMeals;

        private static Random rand = new Random();
        public enum State { Hunger, Eat, Think }
        class Philosopher
        {
            public State CurrentState { get; set; }
            public int Id { get; set; }
            public int CountMeals { get; set; }

            public Philosopher(int id, int count)
            {
                Id = id;
                CountMeals = count;
            }

            public void Run(object obj)
            {
                Philosophing((List<Fork>)obj);
            }

            public void Philosophing(List<Fork> forks)
            {
                while (CountMeals < limitMeals)
                {
                    CurrentState = State.Hunger;

                    int first = Id;
                    int second = (Id == forks.Count - 1) ? 0 : Id + 1;
                    forks[first].TakeFork();
                    forks[second].TakeFork();

                    CurrentState = State.Eat;
                    Thread.Sleep(rand.Next(3000, 8000));

                    CountMeals++;

                    forks[first].PutFork();
                    forks[second].PutFork();

                    CurrentState = State.Think;
                    Thread.Sleep(rand.Next(3000, 8000));
                }
            }
        }

        class Fork
        {
            Semaphore sem = new Semaphore(1, 1);
            public void TakeFork()
            {
                sem.WaitOne();           
            }
            public void PutFork()
            {
                sem.Release();
            }
        }

        static List<Fork> _forks = new List<Fork>();
        static List<Philosopher> _phs = new List<Philosopher>();

        private Thread[] threads = new Thread[5];

        private SolidBrush hungerColor = new SolidBrush(Color.FromArgb(255, 0, 0, 255));
        private SolidBrush eatColor = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
        private SolidBrush thinkColor = new SolidBrush(Color.FromArgb(255, 255, 255, 0));

        private (int, int)[] coords = new (int, int)[]
        {
            (130, 40),
            (220, 110),
            (190, 215),
            (70, 215), 
            (40, 110)
        };

        public PhilosopherForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (limitMeals == 0)
            {
                if (textBoxCntMeals.Text == string.Empty) return;
                limitMeals = int.Parse(textBoxCntMeals.Text);
                textBoxCntMeals.Clear();
            }

            for (int i = 0; i < 5; i++)
            {
                _forks.Add(new Fork());
                _phs.Add(new Philosopher(i, 0));
            }

            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(_phs[i].Run));
                threads[i].Start(_forks);
            }

            timerUp.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            for (int i = 0; i < _phs.Count; i++)
            {
                Rectangle rect = new Rectangle(coords[i].Item1, coords[i].Item2, 50, 50);
                switch (_phs[i].CurrentState)
                {
                    case State.Hunger:
                        g.FillRectangle(hungerColor, rect);
                        break;
                    case State.Eat:
                        g.FillRectangle(eatColor, rect);
                        break;
                    case State.Think:
                        g.FillRectangle(thinkColor, rect);
                        break;
                }

                string text = _phs[i].CountMeals.ToString();
                Font font = new Font("Arial", 25);
                SizeF textSize = g.MeasureString(text, font);
                g.DrawString(text, font, Brushes.Black, coords[i].Item1 - 30, coords[i].Item2);
            }
        }

        private void timerUp_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            foreach (var thread in threads)
            {
                thread.Abort();
            }
            timerUp.Stop();
        }

        private void textBoxCntMeals_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxCntMeals.Text != string.Empty)
            {
                limitMeals = int.Parse(textBoxCntMeals.Text);
                textBoxCntMeals.Clear();
            }
        }

        private void textBoxCntMeals_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == '0' && textBoxCntMeals.Text.Length == 0) e.Handled = true;
        }
    }
}