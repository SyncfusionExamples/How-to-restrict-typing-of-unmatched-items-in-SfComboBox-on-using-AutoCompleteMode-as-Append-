using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SfComboBoxEditable
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            List<USState> list = GetData();
            this.sfComboBox1.DataSource = list;
            this.sfComboBox1.DisplayMember = "LongName";
            this.sfComboBox1.ValueMember = "LongName";
            this.sfComboBox1.AutoCompleteMode = AutoCompleteMode.Append;
            this.sfComboBox1.ThemeName = "Office2016Colorful";
            this.sfComboBox1.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
           // Using the key press event
            this.sfComboBox1.TextBox.KeyPress += TextBox_KeyPress;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region GenerateData
        List<USState> GetData()
        {
            // DisplayMember is used to display just the long name of each state.
            List<USState> USStates = new List<USState>();
            USStates.Add(new USState("Alaska", "AK", 1));
            USStates.Add(new USState("Arizona", "AZ", 2));
            USStates.Add(new USState("Arkansas", "AK", 3));
            USStates.Add(new USState("California", "CA", 4));
            USStates.Add(new USState("Colorado", "CO", 5));
            USStates.Add(new USState("Connecticut", "CT", 6));
            USStates.Add(new USState("Delaware", "DE", 3));
            USStates.Add(new USState("Florida", "FL", 4));
            USStates.Add(new USState("Georgia", "GA", 1));
            USStates.Add(new USState("Hawaii", "HI", 0));
            USStates.Add(new USState("Idaho", "ID", 3));
            USStates.Add(new USState("Illinois", "IL", 2));
            USStates.Add(new USState("Indiana", "IN", 6));
            USStates.Add(new USState("Iowa", "IA", 5));
            USStates.Add(new USState("Kansas", "KA", 5));
            USStates.Add(new USState("Kentucky", "KY", 4));
            USStates.Add(new USState("Louisiana", "LA", 3));
            USStates.Add(new USState("Maine", "ME", 0));
            USStates.Add(new USState("Maryland", "MD", 0));
            USStates.Add(new USState("Massachusetts", "MA", 2));
            USStates.Add(new USState("Michigan", "MI", 1));
            USStates.Add(new USState("Minnesota", "MN", 6));
            USStates.Add(new USState("Mississippi", "MS", 5));
            USStates.Add(new USState("Missouri", "MO", 2));
            USStates.Add(new USState("Montana", "MT", 1));
            USStates.Add(new USState("Nebraska", "NE", 4));
            USStates.Add(new USState("Nevada", "NV", 0));
            USStates.Add(new USState("New Hampshire", "NH", 3));
            USStates.Add(new USState("New Jersey", "NJ", 3));
            USStates.Add(new USState("New Mexico", "NM", 2));
            USStates.Add(new USState("New York", "NY", 5));
            USStates.Add(new USState("North Carolina", "NC", 4));
            USStates.Add(new USState("North Dakota", "ND", 4));
            USStates.Add(new USState("Ohio", "OH", 1));
            USStates.Add(new USState("Oklahoma", "OK", 2));
            USStates.Add(new USState("Oregon", "OR", 5));
            USStates.Add(new USState("Pennsylvania", "PA", 0));
            USStates.Add(new USState("Rhode Island", "RI", 6));
            USStates.Add(new USState("South Carolina", "SC", 5));
            USStates.Add(new USState("South Dakota", "SD", 4));
            USStates.Add(new USState("Tennessee", "TN", 3));
            USStates.Add(new USState("Texas", "TX", 2));
            USStates.Add(new USState("Utah", "UT", 0));
            USStates.Add(new USState("Vermont", "VT", 1));
            USStates.Add(new USState("Virginia", "VA", 0));
            USStates.Add(new USState("Washington", "WA", 2));
            USStates.Add(new USState("West Virginia", "WV", 0));
            USStates.Add(new USState("Wisconsin", "WI", 3));
            USStates.Add(new USState("Wyoming", "WY", 5));

            return USStates;
        }
        #endregion

        //Invoke the KeyPress event to type unmatched item
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
            {
                //Restrict the non-char.
                if (Char.IsControl(e.KeyChar))
                {
                    return;
                }
                string nonSelectedText = sfComboBox1.Text.Substring(0, sfComboBox1.Text.Length - sfComboBox1.TextBox.SelectionLength);
                string searchText = nonSelectedText + e.KeyChar;
                bool ismatched = false;
                for (int i = 0; i < sfComboBox1.DropDownListView.View.Items.Count; i++)
                {
                    if ((sfComboBox1.DropDownListView.View.Items[i] as USState).LongName.ToString().StartsWith(searchText, true, null))
                    {
                        ismatched = true;
                        break;
                    }
                }
                e.Handled = !ismatched;
            }

        private void sfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


    #region "USState Class"
    /// <summary>
    /// Creating the class 
    /// </summary>
    public class USState
    {
        private string myShortName;
        private string myLongName;
        private int imgIndex;

        public USState(string strLongName, string strShortName, int imageIndex)
        {
            this.myShortName = strShortName;
            this.myLongName = strLongName;
            this.imgIndex = imageIndex;
        }

        public string ShortName
        {
            get
            {
                return myShortName;
            }
        }

        public string LongName
        {

            get
            {
                return myLongName;
            }
        }

        public int ImageIndex
        {
            get
            {
                return imgIndex;
            }
            set
            {
                imgIndex = value;
            }
        }


        public override string ToString()
        {
            return this.LongName + " - " + this.ShortName;
        }
    }
    #endregion
}
