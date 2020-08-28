using System.Windows.Forms;

namespace ATM
{
    class GetNominal
    {
        public static int[] GetMoney( int[] counts, int sumU)
        {
            int[]  nom = new int[]{ 5000, 2000, 1000, 500, 200, 100, 50 };
            int[] counts1 = new int[] { 0, 0, 0, 0, 0, 0, 0};

            int i = 0;
            int buf = sumU;

            int sum1 = 0;
            i = 0;

            while (buf>0)
            {
                for ( i = 0; i < 7; i++)
                {
                    while (nom[i] <= buf)
                    {
                        if (counts[i] > 0)
                        {
                            buf -= nom[i];
                            sum1 += nom[i];
                            counts[i]--;
                            counts1[i]++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                break;
            }

            int[] mass = new int[8] {0,0,0,0,0,0,0,0 };
            if (sum1 == sumU)
            {
                i = 0;
                while (i < 7)
                {
                    mass[i] = counts1[i];
                    i++;
                }    

                mass[7] = sumU;
                string outs="";

                if (mass[0] != 0) outs += mass[0].ToString() + " шт по 5000 рублей" + (char)13 + (char)10;
                if (mass[1] != 0) outs += mass[1].ToString() + " шт по 2000 рублей" + (char)13 + (char)10;
                if (mass[2] != 0) outs += mass[2].ToString() + " шт по 1000 рублей" + (char)13 + (char)10;
                if (mass[3] != 0) outs += mass[3].ToString() + " шт по 500 рублей" + (char)13 + (char)10;
                if (mass[4] != 0) outs += mass[4].ToString() + " шт по 200 рублей" + (char)13 + (char)10;
                if (mass[5] != 0) outs += mass[5].ToString() + " шт по 100 рублей" + (char)13 + (char)10;
                if (mass[6] != 0) outs += mass[6].ToString() + " шт по 50 рублей" + (char)13 + (char)10;

                MessageBox.Show(outs + (char)13 + (char)10 + "Итого:" + sumU, "Деньги выданы");
            }
            else
            {
                MessageBox.Show("Невозможно выдать деньги");
            }
            return mass;
        }
    }
}
