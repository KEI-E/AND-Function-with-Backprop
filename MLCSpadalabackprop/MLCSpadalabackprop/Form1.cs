using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace MLCSpadalabackprop
{
    public partial class Form1 : Form
    {
        NeuralNet bp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bp = new NeuralNet(2, 1, 1);    //2 input, 1 hidden, 1 output
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // inputs 1 or 1, 1 or 0, 0 or 1, 0 or o
            
            // setInputs are the features
            // this is an example of supervised network

            for (int x = 0; x < 1000; x++)  //1000 epochs
            {
                /* OR function
                //1 or 1
                bp.setInputs(0, 1.0);
                bp.setInputs(1, 1.0);
                bp.setDesiredOutput(0, 1.0);
                bp.learn();

                //1 or 0
                bp.setInputs(0, 1.0);
                bp.setInputs(1, 0.0);
                bp.setDesiredOutput(0, 1.0);
                bp.learn();

                //0 or 1
                bp.setInputs(0, 0.0);
                bp.setInputs(1, 1.0);
                bp.setDesiredOutput(0, 1.0);
                bp.learn();

                //0 or 0
                bp.setInputs(0, 0.0);
                bp.setInputs(1, 0.0);
                bp.setDesiredOutput(0, 0.0);
                bp.learn();*/

                //AND function
                //1 or 1
                bp.setInputs(0, 1.0);
                bp.setInputs(1, 1.0);
                bp.setDesiredOutput(0, 1.0);
                bp.learn();

                //1 or 0
                bp.setInputs(0, 1.0);
                bp.setInputs(1, 0.0);
                bp.setDesiredOutput(0, 0.0);
                bp.learn();

                //0 or 1
                bp.setInputs(0, 0.0);
                bp.setInputs(1, 1.0);
                bp.setDesiredOutput(0, 0.0);
                bp.learn();

                //0 or 0
                bp.setInputs(0, 0.0);
                bp.setInputs(1, 0.0);
                bp.setDesiredOutput(0, 0.0);
                bp.learn();
            }
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            bp.setInputs(0, Convert.ToDouble(input1.Text));
            bp.setInputs(1, Convert.ToDouble(input2.Text));
            bp.run();

            output.Text = "" + bp.getOuputData(0);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            bp.saveWeights(saveFileDialog1.FileName);   
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openWeights_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            bp.loadWeights(openFileDialog1.FileName);
        }
    }
}
