using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Program:      Travel Specials
//Developer:    Timmy Bell
//Date:         January 24, 2021
//Purpose:      This program displays the travel special information for various
//              travel destinations.
namespace Travel_Specials
{
    public partial class travelSpecials : Form
    {
        public travelSpecials()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void travelSpecials_Load(object sender, EventArgs e)
        {

        }

        private void destinationPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void destinationPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void hawaiiButton_Click(object sender, EventArgs e)
        {
            //diplay Hawaii travel information
            destinationPictureBox.Image = Travel_Specials.Properties.Resources.Hawaii;
            destinationLabel.Text = "Hawaii";
            destinationPriceLabel.Text = "6 nights 7 days package starting at $400 per night";
        } //end Hawaii Click

        private void orlandoButton_Click(object sender, EventArgs e)
        {
            //display Orlando travel information
            destinationPictureBox.Image = Travel_Specials.Properties.Resources.orlando;
            destinationLabel.Text = "Orlando";
            destinationPriceLabel.Text = "5 nights 6 days package starting at $300 per night";
        } //end Orlando Click

        private void lasVegasButton_Click(object sender, EventArgs e)
        {
            //display Las Vegas travel information
            destinationPictureBox.Image = Travel_Specials.Properties.Resources.LasVegas;
            destinationLabel.Text = "Las Vegas";
            destinationPriceLabel.Text = "2 nights 3 days package starting at $100 per night";
        } //end Las Vegas Click

        private void newOrleansButton_Click(object sender, EventArgs e)
        {
            //display New Orleans travel information
            destinationPictureBox.Image = Travel_Specials.Properties.Resources.NewOrleans;
            destinationLabel.Text = "New Orleans";
            destinationPriceLabel.Text = "5 nights 6 days package starting at $200 per night";
        } //end New Orleans Click

        private void arubaButton_Click(object sender, EventArgs e)
        {
            //display Aruba travel information
            destinationPictureBox.Image = Travel_Specials.Properties.Resources.aruba;
            destinationLabel.Text = "Aruba";
            destinationPriceLabel.Text = "4 nights 5 days package starting at $300 per night";
        } //end Aruba Click
    }
}
