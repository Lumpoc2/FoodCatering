using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catering
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1 && comboBox1.SelectedIndex != -1)
            {
                string selectedPackage = comboBox2.SelectedItem.ToString();
                string eventType = comboBox1.SelectedItem.ToString();


                int packagePrice = 0;
                if (selectedPackage.Contains("₱"))
                {
                    int index = selectedPackage.IndexOf("₱") + 1;
                    string priceString = selectedPackage.Substring(index).Replace(",", "");
                    int.TryParse(priceString, out packagePrice);
                }
                string cateringRecommendation = "";
                string url = "";
                if (eventType == "Wedding")
                {
                    if (packagePrice >= 14800)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT CMR Letchon and Packages Food Catering Service\n\n" + "Note:\n\n" + "(1-90 pax) 30kls whole letchon, Sweet 'n spicy garlic shirmp, Fried Chicken, Beefsteak, Chicken Afritada, Fish Fillet sweet'n sour, Beef Caldereta , Pork sari-sari , Swakto coke/sprite 1 case ";
                        url = "https://www.facebook.com/ChriziaSANTS";
                    }
                    else if (packagePrice >= 10500)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT CMR Letchon and Packages Food Catering Service\n\n" + "Note:\n\n" + "(1- 60 pax ) 30-32 kls letchon 1 tray of: Special Chicken Curry, Bihon Guisado, Southern Buttered Chicken, Pork Sari spicy, Chicken Afritada, Lumpia shanghai-65pcs, 1 case swakto";
                        url = "https://www.facebook.com/ChriziaSANTS";
                    }
                    else if (packagePrice >= 9500)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT CMR Letchon and Packages Food Catering Service\n\n" + "Notes:\n\n" + "(1-50 pax) 27kls letchon 1 tray of: Fried chicken, Bam-i / Sotanghun, Pork Humba, Pork Sari spicy or not, Creamy Spaghetti, Chopsuey , 1 case swakt";
                        url = "https://www.facebook.com/ChriziaSANTS";
                    }
                    else
                    {
                        MessageBox.Show("Please select a package and an event type.");
                        return;
                    }
                }
                else if (eventType == "Birthday")
                {
                    if (packagePrice >= 14500)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT Biyaheng Foodever Bistro\n\n" + "Notes:\n\n" + "(1 - 40 pax) 4 viands 2 main course(BEEF or CHICKEN), 1 fish, 1 Vegetable or Noodles, Dessert, Softdrinks.";
                        url = "https://www.facebook.com/BiyahengFoodeverBistro";
                    }
                    else if (packagePrice >= 17500)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT Biyaheng Foodever Bistro\n\n" + "Notes:\n\n" + "(1- 60 pax) 5 viands 3 main course (BEEF or CHICKEN or SEAFOOD), 1 fish, 1 Vegetable or Noodles, Dessert, Softdrink";

                        url = "https://www.facebook.com/BiyahengFoodeverBistro1";
                    }
                    else if (packagePrice >= 1000)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT Biyaheng Foodever Bistro" + "Notes:\n\n" + "(1-80 pax) 6 viands 4 main course (BEEF or CHICKEN or SEAFOOD) 1 fish 1 Vegetable or noodles Dessert Softdrink";
                        url = "https://www.facebook.com/BiyahengFoodeverBistro";
                    }
                    else
                    {
                        MessageBox.Show("Please select a package and an event type.");
                        return;
                    }
                }
                else if (eventType == "Seminar")
                {
                    if (packagePrice >= 9800)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT BEGE OCAMPO Food Cateringa\n\n" + "Note:\n\n" + "(1-50 pax) 25kl Letchon 6 main course (BEEF , CHICKEN ,FISH , or SEAFOODS) 2 Cases Softdrinks 3 kinds of Fruits";
                        url = "https://www.facebook.com/bege.deocampo";
                    }
                    else if (packagePrice >= 10500)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT BEGE OCAMPO Food Catering\n\n" + "Note:\n\n"
                     + "(1-60 pax) 30kl Letchon 6 main course (BEEF , CHICKEN ,FISH , or SEAFOODS) 3 Cases Softdrinks 3 kinds of Fruits";

                        url = "https://www.facebook.com/bege.deocampo";
                    }
                    else if (packagePrice >= 11800)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT BEGE OCAMPO Food Catering\n\n" + "Note:\n\n"
                         + "(1-70 pax) 30kl Letchon 8 main course (BEEF , CHICKEN , FISH , or SEAFOODS) 2 Cases Softdrinks 3 kinds of Fruits.";

                        url = "https://www.facebook.com/bege.deocampo";
                    }
                    else
                    {
                        MessageBox.Show("Please select a package and an event type.");
                        return;
                    }
                }

                else if (eventType == "Baby shower")
                {
                    if (packagePrice >= 7500)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT CMR Letchon and Packages Food Catering Service\n\n" + "Note:\n\n" + "(1-26pax) 1 22klsWHOLE LETCHON , 1 TRAY FRIED CHICKEN, 1 TRAY Lumpia Shanghae(50pcs), 1 TRAY PORK HUMBA, 1 TRAY SARI-SARI(SPICY / NOT)";
                        url = "https://www.facebook.com/ChriziaSANTS";
                    }
                    else if (packagePrice >= 8700)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT CMR Letchon and Packages Food Catering Service\n\n" + "Notes:\n\n"
                     + "(1-32 pax) 22kls WHOLE Lechon , Garlic Buttered Shrimp, Pork calderita, Fried Chicken, Lumpia 60pCs, Special Bihon Guisado, Pork Sare/ Dinuguan";

                        url = "https://www.facebook.com/ChriziaSANTS";
                    }
                    else if (packagePrice >= 11800)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT CMR Letchon and Packages Food Catering Service\n\n" + "Notes:\n\n"
                         + "(1-50 pax) 27kls letchon 1 tray of: Fried chicken, Bam-i / Sotanghun, Pork Humba, Pork Sari spicy or not, Creamy Spaghetti, Chopsuey , 1 case swakto";

                        url = "https://www.facebook.com/ChriziaSANTS";
                    }
                    else
                    {
                        MessageBox.Show("Please select a package and an event type.");
                        return;
                    }
                }
                else if (eventType == "Family Reunion")
                {
                    if (packagePrice >= 17500)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT Biyaheng Foodever Bistro\n\n" + "Note:\n\n" + "(1- 60 pax) 5 viands 3 main course (BEEF or CHICKEN or SEAFOOD), 1 fish, 1 Vegetable or Noodles, Dessert, Softdrink";
                        url = "https://www.facebook.com/BiyahengFoodeverBistro";
                    }
                    else if (packagePrice >= 19500)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT Biyaheng Foodever Bistro\n\n" + "Notes:\n\n"
                     + "(1-80 pax) 6 viands 4 main course (BEEF or CHICKEN or SEAFOOD), 1 fish, 1 Vegetable or noodles, Dessert, Softdrink";

                        url = "https://www.facebook.com/BiyahengFoodeverBistro";
                    }
                    else if (packagePrice >= 14500)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT Biyaheng Foodever Bistro\n\n" + "Notes:\n\n"
                         + "(1 - 40 pax) 4 viands , 2 main course(BEEF or CHICKEN), 1 fish, 1 Vegetable or Noodles, Dessert, Softdrinks";

                        url = "https://www.facebook.com/BiyahengFoodeverBistro";
                    }
                    else
                    {
                        MessageBox.Show("Please select a package and an event type.");
                        return;
                    }
                }
                else if (eventType == "Gender Reveal")
                {
                    if (packagePrice >= 9800)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT BEGE OCAMPO Food Catering\n\n" + "Note:\n\n" + "(1-50 pax) 25kl Letchon 6 main course (BEEF , CHICKEN , FISH , or SEAFOODS) 2 Cases Softdrinks 3 kinds of Fruits";
                        url = "https://www.facebook.com/bege.deocampo";
                    }
                    else if (packagePrice >= 7900)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT BEGE OCAMPO Food Catering\n\n" + "Note:\n\n"
                     + "(1-30 pax) 27kl Letchon 3 main course (BEEF , CHICKEN or FISH) 2 kinds Fruits";

                        url = "https://www.facebook.com/bege.deocampo";
                    }
                
                    else if (packagePrice >= 6500)
                    {
                        cateringRecommendation = "The Recommendation:\n\n PLEASE VISIT BEGE OCAMPO Food Catering\n\n" + "Notes:\n\n"
                         + "(1-20 pax) 20kl Letchon 3 main course (BEEF , CHICKEN or FISH)";

                        url = "https://www.facebook.com/bege.deocampo";
                    }
                
                    else
                    {
                        MessageBox.Show("Please select a package and an event type.");
                        return;
                    }
                }
                else
                {
                    cateringRecommendation = "We do not offer catering packages for this event type.";
                }


                    DialogResult result = MessageBox.Show(cateringRecommendation + "\n\nDo you want to view more details about this catering package, click the button yes to visit the site?", "Catering Recommendation", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("cmd", $"/c start {url}");
                    }
                }
                else
                {

                    MessageBox.Show("Please select a package and an event type.");
                }
                }
            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                string selectedEventType = comboBox1.SelectedItem.ToString();

                switch (selectedEventType)
                {
                    case "Wedding":
                        comboBox2.Items.Clear();
                        comboBox2.Items.Add("Package A - ₱14800");
                        comboBox2.Items.Add("Package B - ₱10500");
                        comboBox2.Items.Add("Package C - ₱9500");
                        break;

                    case "Birthday":
                        comboBox2.Items.Clear();
                        comboBox2.Items.Add("Package A - ₱14500");
                        comboBox2.Items.Add("Package B - ₱17500");
                        comboBox2.Items.Add("Package C - ₱19500");
                        break;

                    case "Seminar":
                        comboBox2.Items.Clear();
                        comboBox2.Items.Add("Package A - ₱9800");
                        comboBox2.Items.Add("Package B - ₱10500");
                        comboBox2.Items.Add("Package C - ₱11800");
                        break;

                 case "Baby Shower":
                        comboBox2.Items.Clear();
                        comboBox2.Items.Add("Package  A - ₱7500");
                        comboBox2.Items.Add("Package  B - ₱8700");
                        comboBox2.Items.Add("Package  C - ₱9800");
                        break;
                case "Family Reunion":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Package A - ₱17500");
                    comboBox2.Items.Add("Package B - ₱14500");
                    comboBox2.Items.Add("Package C - ₱19500");
                    break;
                case "Gender Reveal":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Package A - ₱6500");
                    comboBox2.Items.Add("Package B - ₱7900");
                    comboBox2.Items.Add("Package C - ₱9800");
                    break;

                default:
                        comboBox2.Items.Clear();
                        break;
                }
            }

        }
    }



