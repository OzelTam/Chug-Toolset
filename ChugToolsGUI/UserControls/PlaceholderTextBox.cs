using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChugToolsGUI.UserControls
{
    public partial class PlaceholderTextBox : UserControl
    {
        public PlaceholderTextBox()
        {
            InitializeComponent();
     
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (TextPlace.Text == placeHolder)
            {
                TextPlace.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextPlace.Text))
                TextPlace.Text = placeHolder;
        }


        public string placeHolder { get; set; }
        private void PlaceholderTextBox_Load(object sender, EventArgs e)
        {
            placeHolder = placeHolder;
            TextPlace.Text = placeHolder;
            TextPlace.GotFocus += RemoveText;
            TextPlace.LostFocus += AddText;
        }

        public void SetPlaceholder(string newPlaceholder)
        {
            placeHolder = newPlaceholder;
            TextPlace.Text = placeHolder;
        }

        public string GetText()
        {
            return TextPlace.Text;
        }

        public void SetText(string newText)
        {
            TextPlace.Text = newText;
        }

        public TextBox TextField()
        {
            return TextPlace;
        }


        private void TextPlace_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
