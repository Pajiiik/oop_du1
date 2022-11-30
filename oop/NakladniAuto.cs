using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop
{
    internal class NakladniAuto
    {
        private int nosnost_tuny;
        private int spz;
        public int hmostnost_nakladu = 0;
        int Hmostnost_nakladu
        {
            get
            {
                return hmostnost_nakladu;
            }
        }
        public NakladniAuto(int nosnost, int Spz)
        {
            nosnost_tuny = nosnost;
            spz = Spz;
        }
        public void naloz_naklad(int hmotnost, int nosnost)
        {
            if (hmotnost > nosnost)
            {
                MessageBox.Show("Byla přesáhnutá nosnost, zbytek nákladu: " + (hmotnost - nosnost).ToString(), "varování");
            }
            else
            {
                MessageBox.Show("Náklad byl úspěšně naložen.");
            }
        }

        public void vyloz_naklad(int hmostnost, int velikost_vylozeni)
        {
            if (velikost_vylozeni > hmostnost)
            {
                MessageBox.Show("Tolik nákladu nelze vyložit, bylo tedy vyloženo maximální množství", "varování");
            }
            else
            {
                hmostnost = hmostnost - velikost_vylozeni;
                MessageBox.Show("Bylo uspěšne vyloženo požadováné množství, zbytek po vyložení: " + hmostnost.ToString());
            }

        }

    }
}
