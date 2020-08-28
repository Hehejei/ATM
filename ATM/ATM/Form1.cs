using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int limitScore = 10; // максимальное количество банкнот в банкомате 
        private int score = 0;// количество банкнот в банкомате
        private int sc=0;

        private int r = 0; // переменная для изменения суммы на форме


        // количество банкнот каждого номинала
        private int scorerub50, scorerub100, scorerub200, scorerub500, scorerub1000, scorerub2000, scorerub5000 = 0;
        private int sr5000, sr2000, sr1000, sr500, sr200, sr100, sr50 = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            panel4.Visible = true;
            panel3.Visible = true;
            
        } 
        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
        }


        private void ru50_Click(object sender, EventArgs e)
        {
           
            if (score <= limitScore)
            { 
                
                r = Int32.Parse(sum.Text);
                r += 50;

                sum.Text = r.ToString();
                sum1.Text = r.ToString();
                sum2.Text = r.ToString();

                scorerub50++;
                sc++;
                score++;

                r = Int32.Parse(countp50.Text);
                r++;

                countp50.Text = r.ToString();
                count50.Text = r.ToString();
                sr50 = Int32.Parse(count50.Text);
            }
            else MessageBox.Show("Банкомат переполнен");
        }

        private void ru100_Click(object sender, EventArgs e)
        {
           
            if (score <= limitScore)
            { 
                
                r = Int32.Parse(sum.Text);
                r += 100;

                sum.Text = r.ToString();
                sum1.Text = r.ToString();
                sum2.Text = r.ToString();

                scorerub100++;
                sc++;
                score++;

                r = Int32.Parse(countp100.Text);
                r++;

                countp100.Text = r.ToString();
                count100.Text = r.ToString();
                sr100 = Int32.Parse(count100.Text);
            }
            else MessageBox.Show("Банкомат переполнен");
        }

        private void ru200_Click(object sender, EventArgs e)
        {
            
            if (score <= limitScore)
            {
                
                r = Int32.Parse(sum.Text);
                r += 200;

                sum.Text = r.ToString();
                sum1.Text = r.ToString();
                sum2.Text = r.ToString();

                scorerub200++;
                sc++;
                score++;

                r = Int32.Parse(countp200.Text);
                r++;

                countp200.Text = r.ToString();
                count200.Text = r.ToString();
                sr200 = Int32.Parse(count200.Text);
            }
            else MessageBox.Show("Банкомат переполнен");
        }

        private void ru500_Click(object sender, EventArgs e)
        {
           
            if (score <= limitScore)
            { 
               
                r = Int32.Parse(sum.Text);
                r += 500;

                sum.Text = r.ToString();
                sum1.Text = r.ToString();
                sum2.Text = r.ToString(); ;

                scorerub500++;
                sc++;
                score++;

                r = Int32.Parse(countp500.Text);
                r++;

                countp500.Text = r.ToString();
                count500.Text = r.ToString();
                sr500 = Int32.Parse(count500.Text);
            }
            else MessageBox.Show("Банкомат переполнен");
        }

        private void ru1000_Click(object sender, EventArgs e)
        {
            
            if (score <= limitScore)
            {
                r = Int32.Parse(sum.Text);
                r += 1000;

                sum.Text = r.ToString();
                sum1.Text = r.ToString();
                sum2.Text = r.ToString();

                scorerub1000++;
                sc++;
                score++;

                r = Int32.Parse(countp1000.Text);
                r++;

                countp1000.Text = r.ToString();
                count1000.Text = r.ToString();

                sr1000 = Int32.Parse(count1000.Text);
            }
            else MessageBox.Show("Банкомат переполнен");
        }

        private void ru2000_Click(object sender, EventArgs e)
        {
            
            if (score <= limitScore)
            {
               
                r = Int32.Parse(sum.Text);
                r += 2000;

                sum.Text = r.ToString();
                sum1.Text = r.ToString();
                sum2.Text = r.ToString();

                scorerub2000++;
                sc++;
                score++;

                r = Int32.Parse(countp2000.Text);
                r++;

                countp2000.Text = r.ToString();
                count2000.Text = r.ToString(); 
                sr2000 = Int32.Parse(count2000.Text);
            }
            else MessageBox.Show("Банкомат переполнен");
        }

        private void ru5000_Click(object sender, EventArgs e)
        {
            
            if (score <= limitScore)
            {

                r = Int32.Parse(sum.Text);
                r += 5000;

                sum.Text = r.ToString();
                sum1.Text = r.ToString();
                sum2.Text = r.ToString();

                scorerub5000++;
                sc++;
                score++;

                r = Int32.Parse(countp5000.Text);
                r++;

                countp5000.Text = r.ToString();
                count5000.Text = r.ToString();

                sr5000 = Int32.Parse(count5000.Text);
            }
            else MessageBox.Show("Банкомат переполнен");
        }

        private void rub5000_Click(object sender, EventArgs e)
        {
            if (scorerub5000 > 0)
            {
                r = Int32.Parse(vydsum.Text);
                r += 5000;

                vydsum.Text = r.ToString();
                
                scorerub5000--;
                score--;

                r = Int32.Parse(count5000.Text);
                r--;

                countp5000.Text = r.ToString();
                count5000.Text = r.ToString();
            }
            else MessageBox.Show("Этих банкнот уже нет");
        }
        private void rub2000_Click(object sender, EventArgs e)
        {
            if (scorerub2000>0)
            { 
                r = Int32.Parse(vydsum.Text);
                r += 2000;

                vydsum.Text = r.ToString();

                scorerub2000--;
                score--;

                r = Int32.Parse(count2000.Text);
                r--;

                countp2000.Text = r.ToString();
                count2000.Text = r.ToString();
            }
            else MessageBox.Show("Этих банкнот уже нет");
        }
        private void rub1000_Click(object sender, EventArgs e)
        {
            if (scorerub1000>0)
            { 
                r = Int32.Parse(vydsum.Text);
                r += 1000;

                vydsum.Text = r.ToString();

                scorerub1000--;
                score--;

                r = Int32.Parse(countp1000.Text);
                r--;

               countp1000.Text = r.ToString();
                count1000.Text = r.ToString();
            }
            else MessageBox.Show("Этих банкнот уже нет");
        }
        private void rub500_Click(object sender, EventArgs e)
        {
            if (scorerub500>0)
            { 
                r = Int32.Parse(vydsum.Text);
                r += 500;

                vydsum.Text = r.ToString();

                scorerub500--;
                score--;

                r = Int32.Parse(countp500.Text);
                r--;

                countp500.Text = r.ToString();
                count500.Text = r.ToString();
            }
            else MessageBox.Show("Этих банкнот уже нет");
        }
        private void rub200_Click(object sender, EventArgs e)
        {
            if (scorerub200>0)
            { 
                r = Int32.Parse(vydsum.Text);
                r += 200;

                vydsum.Text = r.ToString();

                scorerub200--;
                score--;

                r = Int32.Parse(countp200.Text);
                r--;

                countp200.Text = r.ToString();
                count200.Text = r.ToString();
            }

            else MessageBox.Show("Этих банкнот уже нет");
        }
        private void rub100_Click(object sender, EventArgs e)
        {
            if (scorerub100>0)
            {
                r = Int32.Parse(vydsum.Text);
                r += 100;

                vydsum.Text = r.ToString();

                r = Int32.Parse(count100.Text);
                r--;

                scorerub100--;
                score--;

                countp100.Text = r.ToString();
                count100.Text = r.ToString();
            }
            else MessageBox.Show("Этих банкнот уже нет");
        }
        private void rub50_Click(object sender, EventArgs e)
        {
            if (scorerub50>0) 
            { 
                r = Int32.Parse(vydsum.Text);
                r += 50;

                vydsum.Text = r.ToString();

                r = Int32.Parse(count50.Text);
                r--;

                scorerub50--;
                score--;

                countp50.Text = r.ToString();
                count50.Text = r.ToString();
            }
            else MessageBox.Show("Этих банкнот уже нет");
        }

        private void giveout_Click(object sender, EventArgs e)
        {
            sc = score;
            int r1 = Int32.Parse(vydsum.Text);
            r = Int32.Parse(sum.Text);
            r -= r1;

            sum.Text = r.ToString();
            sum1.Text = r.ToString();
            sum2.Text = r.ToString();

            sr5000 = Int32.Parse(count5000.Text);
            scorerub5000 = sr5000;

            sr2000 = Int32.Parse(count2000.Text);
            scorerub2000 = sr2000;

            sr1000 = Int32.Parse(count1000.Text);
            scorerub1000 = sr1000;

            sr500 = Int32.Parse(count500.Text);
            scorerub500 = sr500;

            sr200 = Int32.Parse(count200.Text);
            scorerub200 = sr200;

            sr100 = Int32.Parse(count100.Text);
            scorerub100 = sr100;

            sr50 = Int32.Parse(count50.Text);
            scorerub50 = sr50;

            vydsum.Text = "0";
        }

        
        private void cancel_Click(object sender, EventArgs e)
        {
            score = sc;
            count5000.Text = sr5000.ToString();
            count2000.Text = sr2000.ToString();
            count1000.Text = sr1000.ToString();
            count500.Text = sr500.ToString();
            count200.Text = sr200.ToString();
            count100.Text = sr100.ToString();
            count50.Text = sr50.ToString();

            countp5000.Text = sr5000.ToString();
            countp2000.Text = sr2000.ToString();
            countp1000.Text = sr1000.ToString();
            countp500.Text = sr500.ToString();
            countp200.Text = sr200.ToString();
            countp100.Text = sr100.ToString();
            countp50.Text = sr50.ToString();

            
            scorerub5000 = sr5000;
            scorerub2000 = sr2000;
            scorerub1000 = sr1000;
            scorerub500 = sr500;
            scorerub200 = sr200;
            scorerub100 = sr100;
            scorerub50 = sr50;

            
            vydsum.Text = "0";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            {
                int sumB,sumU;
                    sumB = Int32.Parse(sum.Text); // Сумма в банкомате
                    sumU = Int32.Parse(textBox1.Text); // Вводимая сумма

                if (sumU > sumB || sumU < 50 || sumU % 50 != 0)
                {
                    MessageBox.Show("Невозможно выдать данную сумму");               
                }

                else 
                {
                    int[] counts = new int[7];
                    counts[0] = sr5000;
                    counts[1] = sr2000;
                    counts[2] = sr1000;
                    counts[3] = sr500;
                    counts[4] = sr200;
                    counts[5] = sr100;
                    counts[6] = sr50;
                    
                    r = Int32.Parse(sum.Text);

                    int[] mass = GetNominal.GetMoney(counts, sumU);
               
                    int massum = 0;
                    for (int i=0;i<7;i++)  massum += mass[i]; 
                    score = sc -= massum; // убираем счет банкнот в банкомате 


                    scorerub5000 = sr5000 -= mass[0];
                    scorerub2000 = sr2000 -= mass[1];
                    scorerub1000 = sr1000 -= mass[2];
                    scorerub500 = sr500 -= mass[3];
                    scorerub200 = sr200 -= mass[4];
                    scorerub100 = sr100 -= mass[5];
                    scorerub50 = sr50 -= mass[6];

                    // изменяем поля на форме
                    count5000.Text = sr5000.ToString();
                    count2000.Text = sr2000.ToString();
                    count1000.Text = sr1000.ToString();
                    count500.Text = sr500.ToString();
                    count200.Text = sr200.ToString();
                    count100.Text = sr100.ToString();
                    count50.Text = sr50.ToString();

                    countp5000.Text = sr5000.ToString();
                    countp2000.Text = sr2000.ToString();
                    countp1000.Text = sr1000.ToString();
                    countp500.Text = sr500.ToString();
                    countp200.Text = sr200.ToString();
                    countp100.Text = sr100.ToString();
                    countp50.Text = sr50.ToString();

                    r -= mass[7];
                    sum.Text = r.ToString();
                    sum1.Text = sum.Text;
                    sum2.Text = sum.Text;
                    //--------------------------------

                    textBox1.Text =""; // отчищаем поле ввода суммы

                    
                }
            }
            
            else MessageBox.Show("Введите сумму");
        }
    }
}
