using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorantStratRoulette
{
    public partial class Form1 : Form
    {

        List<String> weaponPool = new List<String>();
        List<String> heroPool = new List<String>();
        List<String> strats = new List<String>();

        List<String> outputList = new List<String>();

        List<String> shuffledHeroPool = new List<String>();
        List<String> shuffledWeaponPool = new List<String>();
        List<String> shuffledStratsPool = new List<String>();

        Random random = new Random();

        private int playerCount = 0;

        private String map = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void randomizeBtn_Click(object sender, EventArgs e)
        {
            // Reset vars to default to rerun algorithm
            heroPool.Clear();
            weaponPool.Clear();
            strats.Clear();
            shuffledHeroPool.Clear();
            shuffledWeaponPool.Clear();
            shuffledStratsPool.Clear();
            outputList.Clear();

            output.Text = "";

            playerCount = 0;

            map = null;

            // Alter vars for new values
            playerCount = numOfPlayers.SelectedIndex + 1;

            heroPool = GetSelectedItems(heroList);

            // checks the size of the selected heroes vs the player count
            if (playerCount > heroPool.Count)
            {
                MessageBox.Show("Please increase the number of heroes available");
                return;
            }

            // adds the selected weapons to the weapon pool
            weaponPool = GetSelectedItems(weaponsList);

            // sets the map to the selected map
            map = mapSelected.GetItemText(mapSelected.SelectedItem);

            // not sure if this works?
            if(map == null) { return; }

            // adds the strats based on the selected map
            strats = GetStrats(map);

            try
            {
                BuildOutput();
                PrintOutput();
            } 
            catch(Exception f)
            {
                MessageBox.Show("Some value was out of range.\nPlease try fixing your selection and randomize again.");
                return;
            }

            
        }

        private void creditsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by: CreeperHntr\n\n" +
                "Valorant name and assets are property of Riot Games.\n\n" +
                "My Social Links:\n" +
                "------------------------------------------------------\n" +
                "Twitch: https://twitch.tv/creeperhntr \n" +
                "Twitter: https://twitter.com/creeperhntr");
        }

        /// -------------------------------------
        /// 
        /// PrintOutput()
        /// 
        /// Prints the output of the of the 
        /// randomized strats
        /// 
        /// -------------------------------------

        private void PrintOutput()
        {
            foreach(String s in outputList)
            {
                output.Text += s;
                output.Text += "\r\n";
            }
        }

        /// -------------------------------------
        /// 
        /// BuildOutput()
        /// 
        /// Builds the list that will be shown 
        /// in the output text box
        /// 
        /// -------------------------------------

        private void BuildOutput()
        {
            for(int i = 0; i < 5; i++)
            {
                shuffledHeroPool = heroPool.OrderBy(x => random.Next()).ToList();
                shuffledWeaponPool = weaponPool.OrderBy(x => random.Next()).ToList();
                shuffledStratsPool = strats.OrderBy(x => random.Next()).ToList();
            }

            outputList.Add("Selected Map: " + map);

            outputList.Add("\r\n");

            if(!(shuffledHeroPool.Count == 0))
            {
                outputList.Add("Heroes:");

                for (int i = 1; i < playerCount + 1; i++)
                {
                    outputList.Add("Player " + i + ": " + shuffledHeroPool[i - 1].ToString());
                }
                outputList.Add("\r\n");
            }

            

            
            outputList.Add("Randomized Strats:");

            int weaponIndex = 0;
            int stratIndex = 0;

            for(int i = 1; i < 27; i++)
            {
                String weapon = "";
                String strat = "";
                
                if(weaponIndex > shuffledWeaponPool.Count - 1)
                {
                    weaponIndex = 0;
                }

                if (stratIndex > shuffledStratsPool.Count - 1)
                {
                    stratIndex = 0;
                }



                outputList.Add("Round " + i + ": " + shuffledWeaponPool[weaponIndex] + ", " + shuffledStratsPool[stratIndex]);
                weaponIndex++;
                stratIndex++;
            }
        }

        /// -------------------------------------
        /// 
        /// GetStrats()
        /// 
        /// Returns a list of strats based on 
        /// selected map
        /// 
        /// -------------------------------------

        private List<String> GetStrats(String map)
        {
            List<String> list = new List<String>();

            list.Add("A-Long");
            list.Add("A-Short");

            if (map.Equals("Haven"))
            {
                list.Add("C-Short");
                list.Add("C-Long");
                list.Add("Mid to C");
                list.Add("Mid to B");
            } 
            else if(map.Equals("Split") || map.Equals("Bind"))
            {
                list.Add("B-Short");
                list.Add("B-Long");
                list.Add("Mid to B");
                list.Add("Mid to A");
            }
            return list;
        }

        /// -------------------------------------
        /// 
        /// GetSelectedItems()
        /// 
        /// Returns a list of selected items from
        /// a checked list box
        /// 
        /// -------------------------------------

        private List<String> GetSelectedItems(CheckedListBox list)
        {
            List<String> selected = new List<String>();
            for(int i = 0; i < list.CheckedItems.Count; i++)
            {
                selected.Add(list.CheckedItems[i].ToString());
            }
            return selected;
        }

    }
}
