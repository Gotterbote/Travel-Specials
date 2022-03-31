using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Program:     Travel Specials
// Developer:   Craig Shaw
// Date:        July 23, 2013
// Description: This program display travel special information for various
//              travel destinations.

namespace Travel_Specials
{
    public partial class travelSpecialsForm : Form
    {
        public travelSpecialsForm()
        {
            InitializeComponent();
        }  // end initialize component

        private void arubaButton_Click(object sender, EventArgs e)
        {
            // displays Aruba travel information
            destinationPictureBox.Image = Travel_Specials.Properties.Resources.aruba;
            destinationLabel.Text = "Aruba";
            destinationPriceLabel.Text = "4 nights 5 days package starting at $300 per night";
        } // end Aruba button click

        private void orlandoButton_Click(object sender, EventArgs e)
        {
             // displays Orlando travel information 
            destinationPictureBox.Image = Travel_Specials.Properties.Resources.orlando;
            destinationLabel.Text = "Orlando";
            destinationPriceLabel.Text = "5 nights 6 days package starting at $200 per night";

        } // end Orlando button click

        private void hawaiiButton_Click(object sender, EventArgs e)
        {
             // displays Hawaii travel information 

            destinationPictureBox.Image = Travel_Specials.Properties.Resources.Hawaii;
            destinationLabel.Text = "Hawaii";
            destinationPriceLabel.Text = "6 nights 7 days package starting at $400 per night";
        } // end Hawaii button click

        private void lasVegasButton_Click(object sender, EventArgs e)
        {

               // displays Las Vegas travel information 
          destinationPictureBox.Image = Travel_Specials.Properties.Resources.LasVegas;
            destinationLabel.Text = "Las Vegas";
            destinationPriceLabel.Text = "2 nights 3 days package starting at $100 per night";
        } // end Las Vegas button click

        private void newOrleansButton_Click(object sender, EventArgs e)
        {
             // displays New Orleans travel information 

            destinationPictureBox.Image = Travel_Specials.Properties.Resources.NewOrleans;
            destinationLabel.Text = "New Orleans";
            destinationPriceLabel.Text = "5 nights 6 days package starting at $200 per night";
        } //end New Oreleans button click

    } // end Travel Specials Form
} // end namespace
