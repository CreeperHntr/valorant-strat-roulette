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

        /// 
        /// TODO
        /// refactor weaponList to abilites/ shields


        List<String> weaponPool = new List<String>();
        List<String> heroPool = new List<String>();
        List<String> strats = new List<String>();

        List<String> sidearmPool = new List<String>();
        List<String> smgPool = new List<String>();
        List<String> shotgunPool = new List<String>();
        List<String> riflePool = new List<String>();
        List<String> sniperPool = new List<String>();
        List<String> heavyPool = new List<String>();


        List<String> outputList = new List<String>();

        List<String> shuffledHeroPool = new List<String>();
        List<String> shuffledWeaponPool = new List<String>();
        List<String> shuffledRoundOnePool = new List<String>();
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
            shuffledRoundOnePool.Clear();
            shuffledStratsPool.Clear();
            outputList.Clear();

            sidearmPool.Clear();
            smgPool.Clear();
            shotgunPool.Clear();
            riflePool.Clear();
            sniperPool.Clear();
            heavyPool.Clear();


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
            //weaponPool = GetSelectedItems(abilityShieldsList); /// this needs to be edited

            // Creation of the pools of weapons
            sidearmPool = GetSelectedItems(sidearmsList);
            smgPool = GetSelectedItems(smgsList);
            shotgunPool = GetSelectedItems(shotgunList);
            riflePool = GetSelectedItems(riflesList);
            sniperPool = GetSelectedItems(sniperList);
            heavyPool = GetSelectedItems(heavyList);

            if(sidearmPool.Count == 0)
            {
                sidearmPool.Add("Classic");
                weaponPool = BuildFullWeaponPool(sidearmPool, smgPool, shotgunPool, riflePool, sniperPool, heavyPool);
            }
            else
            {
                weaponPool = BuildFullWeaponPool(sidearmPool, smgPool, shotgunPool, riflePool, sniperPool, heavyPool);
            }

            

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
                //MessageBox.Show(f.ToString());
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
            shuffledHeroPool = Randomize(heroPool);
            shuffledWeaponPool = Randomize(weaponPool);
            shuffledRoundOnePool = Randomize(sidearmPool);
            shuffledStratsPool = Randomize(strats);

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
            int r1Index = 0;

            for(int i = 1; i < 26; i++)
            {
                
                if(weaponIndex > shuffledWeaponPool.Count - 1)
                {
                    weaponIndex = 0;
                }

                if (stratIndex > shuffledStratsPool.Count - 1)
                {
                    stratIndex = 0;
                }

                if(r1Index > shuffledRoundOnePool.Count - 1)
                {
                    r1Index = 0;
                }

                if(i == 1 || i == 13)
                {
                    outputList.Add("Round " + i + ": " + shuffledRoundOnePool[r1Index] + ", " + shuffledStratsPool[stratIndex]);
                } 
                else
                {
                    outputList.Add("Round " + i + ": " + shuffledWeaponPool[weaponIndex] + ", " + shuffledStratsPool[stratIndex]);
                }

                
                weaponIndex++;
                stratIndex++;
                r1Index++;
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


        /// -------------------------------------
        /// 
        /// BuildFullWeaponPool()
        /// 
        /// Returns a list of all selected weapons
        /// from all item pools
        /// 
        /// -------------------------------------
        
        private List<String> BuildFullWeaponPool(List<String> sidearms, List<String> smgs, List<String> shotguns, List<String> rifles, List<String> snipers, List<String> heavy)
        {
            List<String> list = new List<String>();

            for(int i = 0; i < sidearms.Count; i++)
            {
                list.Add(sidearms[i]);
            }

            for (int i = 0; i < smgs.Count; i++)
            {
                list.Add(smgs[i]);
            }

            for (int i = 0; i < shotguns.Count; i++)
            {
                list.Add(shotguns[i]);
            }

            for (int i = 0; i < rifles.Count; i++)
            {
                list.Add(rifles[i]);
            }

            for (int i = 0; i < heavy.Count; i++)
            {
                list.Add(heavy[i]);
            }

            return list;
        }


        /// -------------------------------------
        /// 
        /// Randomize()
        /// 
        /// Returns a list of all randomized 
        /// input weapon pools
        /// 
        /// -------------------------------------

        private List<String> Randomize(List<String> input)
        {
            List<String> list = new List<String>();
            list = input.OrderBy(x => random.Next()).ToList();
            return input;
        }
    }
}
