using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_game_project
{
    class ActorS
    {
        public int X, Y, W, H;
        public Bitmap img;
        public Color loon;
        public int dx = 0;
        public int dy = 0;
        public int SpeedR = 0;
        public int SpeedL = 0;
        public int f = 0;
       
    }
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        Bitmap off;
        List<ActorS> Lminu = new List<ActorS>();
        ActorS minu = new ActorS();
        //List<ActorS> Lgameover = new List<ActorS>();
        //ActorS gameover = new ActorS();
        List<ActorS> Ltre2 = new List<ActorS>();
        ActorS tre2 = new ActorS();
        List<ActorS> Lkhtot = new List<ActorS>();
        ActorS khtot = new ActorS();
        List<ActorS> LkhtotBakasa = new List<ActorS>();
        ActorS khtotBakasa = new ActorS();
        List<ActorS> Ldesert = new List<ActorS>();
        ActorS desert = new ActorS();
        List<ActorS> Lhero = new List<ActorS>();
        ActorS hero = new ActorS();
        List<ActorS> Lenemy1 = new List<ActorS>();
        ActorS enemy1 = new ActorS();
        List<ActorS> Lenemy2 = new List<ActorS>();
        ActorS enemy2 = new ActorS();
        List<ActorS> Lenemy3 = new List<ActorS>();
        ActorS enemy3 = new ActorS();
        List<ActorS> Lcoin = new List<ActorS>();
        ActorS coin = new ActorS();
        int CountTicks = 0;
        int CountTicks1 = 0;
        int CountTicks2 = 0;
        int CountTicks3 = 0;
        int CountTicks4 = 0;
        int v = 0;
        int vv = 0;
        int vvv = 0;
        int vvvv = 0;
        int flagKber = 0;
        int flag = 0;
        int score;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Paint += Form1_Paint;
            this.Load += new EventHandler(Form1_Load);
            t.Tick += T_Tick;
            //t.Interval = 50;
            t.Start();
            KeyDown += Form1_KeyDown;
            MouseDown += Form1_MouseDown;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X >= this.ClientSize.Width / 2 - 100 && e.X < this.ClientSize.Width / 2 - 100 + 200 && e.Y >= 200 && e.Y < 300)
            {
                Lminu = new List<ActorS>();
                flagKber = 1;
                CreateTre2();
                CreateKhtot();
                CreateDesert();
                CreateHero();
            }
        }

        void CreateMinu()
        {
            minu = new ActorS();
            minu.img = new Bitmap("8.bmp");
            minu.X = 0;
            minu.Y = 0;
            minu.W = 1700;
            minu.H = 800;
            Lminu.Add(minu);

            minu = new ActorS();
            minu.img = new Bitmap("9.bmp");
            minu.X = this.ClientSize.Width / 2-100;
            minu.Y = 200;
            minu.W = 200;
            minu.H = 100;
            minu.img.MakeTransparent(minu.img.GetPixel(minu.img.Width - 1, 0));
            Lminu.Add(minu);
        }
        /*
        void CreateGameOver()
        {
            gameover = new ActorS();
            gameover.img = new Bitmap("10.bmp");
            gameover.X = 0;
            gameover.Y = 0;
            gameover.W = 1700;
            gameover.H = 800;
            Lgameover.Add(gameover);

            gameover = new ActorS();
            gameover.img = new Bitmap("9.bmp");
            gameover.X = 0;
            gameover.Y = 0;
            gameover.W = 1700;
            gameover.H = 800;
            Lgameover.Add(gameover);
        }
        */
        void CreateTre2()
        {
            tre2 = new ActorS();
            tre2.X = this.ClientSize.Width / 3;
            tre2.Y = Location.Y;
            tre2.W = 10;
            tre2.H = 1000;
            tre2.loon = Color.Black;
            Ltre2.Add(tre2);

            tre2 = new ActorS();
            tre2.X = this.ClientSize.Width * 2 / 3;
            tre2.Y = Location.Y;
            tre2.W = 10;
            tre2.H = 1000;
            tre2.loon = Color.Black;
            Ltre2.Add(tre2);
        }

        void CreateKhtotBakasa()
        {
            //awl shmal
            khtotBakasa = new ActorS();
            khtotBakasa.X = 670;
            khtotBakasa.Y = 50;
            khtotBakasa.W = 10;
            khtotBakasa.H = 100;
            khtotBakasa.dy = 20;
            khtotBakasa.loon = Color.White;
            LkhtotBakasa.Add(khtotBakasa);

            //awl ymen
            khtotBakasa = new ActorS();
            khtotBakasa.X = 860;
            khtotBakasa.Y = 50;
            khtotBakasa.W = 10;
            khtotBakasa.H = 100;
            khtotBakasa.dy = 20;
            khtotBakasa.loon = Color.White;
            LkhtotBakasa.Add(khtotBakasa);
        }
        void CreateKhtot()
        {
            //awl shmal
            khtot = new ActorS();
            khtot.X = 670;
            khtot.Y = 50;
            khtot.W = 10;
            khtot.H = 100;
            khtot.dy = 20;
            khtot.loon = Color.White;
            Lkhtot.Add(khtot);

            //awl ymen
            khtot = new ActorS();
            khtot.X = 860;
            khtot.Y = 50;
            khtot.W = 10;
            khtot.H = 100;
            khtot.dy = 20;
            khtot.loon = Color.White;
            Lkhtot.Add(khtot);

            //tany shmal
            khtot = new ActorS();
            khtot.X = 670;
            khtot.Y = 200;
            khtot.W = 10;
            khtot.H = 100;
            khtot.dy = 20;
            khtot.loon = Color.White;
            Lkhtot.Add(khtot);

            //tany ymen
            khtot = new ActorS();
            khtot.X = 860;
            khtot.Y = 200;
            khtot.W = 10;
            khtot.H = 100;
            khtot.dy = 20;
            khtot.loon = Color.White;
            Lkhtot.Add(khtot);

            //talt shmal
            khtot = new ActorS();
            khtot.X = 670;
            khtot.Y = 350;
            khtot.W = 10;
            khtot.H = 100;
            khtot.dy = 20;
            khtot.loon = Color.White;
            Lkhtot.Add(khtot);

            //talt ymen
            khtot = new ActorS();
            khtot.X = 860;
            khtot.Y = 350;
            khtot.W = 10;
            khtot.H = 100;
            khtot.dy = 20;
            khtot.loon = Color.White;
            Lkhtot.Add(khtot);

            //rab3 shmal
            khtot = new ActorS();
            khtot.X = 670;
            khtot.Y = 500;
            khtot.W = 10;
            khtot.H = 100;
            khtot.dy = 20;
            khtot.loon = Color.White;
            Lkhtot.Add(khtot);

            //rab3 ymen
            khtot = new ActorS();
            khtot.X = 860;
            khtot.Y = 500;
            khtot.W = 10;
            khtot.H = 100;
            khtot.dy = 20;
            khtot.loon = Color.White;
            Lkhtot.Add(khtot);

            //khames shmal
            khtot = new ActorS();
            khtot.X = 670;
            khtot.Y = 650;
            khtot.W = 10;
            khtot.H = 100;
            khtot.dy = 20;
            khtot.loon = Color.White;
            Lkhtot.Add(khtot);

            //khames ymen
            khtot = new ActorS();
            khtot.X = 860;
            khtot.Y = 650;
            khtot.W = 10;
            khtot.H = 100;
            khtot.dy = 20;
            khtot.loon = Color.White;
            Lkhtot.Add(khtot);
        }
        void CreateDesert()
        {
            desert = new ActorS();
            desert.img = new Bitmap("1.bmp");
            desert.X = 0;
            desert.Y = 0;
            desert.W = 512;
            desert.H = 800;
            
            Ldesert.Add(desert);

            desert = new ActorS();
            desert.img = new Bitmap("2.bmp");
            desert.X = this.ClientSize.Width * 2 / 3 + 10;
            desert.Y = 0;
            desert.W = 500;
            desert.H = 800;
           
            Ldesert.Add(desert);
        }
        void CreateHero()
        {
            hero = new ActorS();
            hero.img = new Bitmap("11.bmp");
            hero.X = this.ClientSize.Width / 2 - 70;
            hero.Y = 600;
            hero.W = 65;
            hero.H = 150;
            hero.dx = 10;
            hero.dy = 10;
            hero.img.MakeTransparent(hero.img.GetPixel(hero.img.Width - 1, 0));
            Lhero.Add(hero);
        }
        void CreateEnemy1(int v)
        {
            enemy1 = new ActorS();
            enemy1.img = new Bitmap("4.bmp");
            enemy1.X = v;
            enemy1.Y = 0;
            enemy1.W = 70;
            enemy1.H = 100;
            enemy1.dx = 5;
            enemy1.dy = 10;
            enemy1.img.MakeTransparent(enemy1.img.GetPixel(enemy1.img.Width - 1, 0));
            Lenemy1.Add(enemy1);
        }

        void CreateEnemy2(int vv)
        {
            enemy2 = new ActorS();
            enemy2.img = new Bitmap("5.bmp");
            enemy2.X = vv;
            enemy2.Y = 0;
            enemy2.W = 70;
            enemy2.H = 100;
            enemy2.dx = 10;
            enemy2.dy = 15;
            enemy2.img.MakeTransparent(enemy2.img.GetPixel(enemy2.img.Width - 1, 0));
            Lenemy2.Add(enemy2);
        }
        void CreateEnemy3(int vvv)
        {
            enemy3 = new ActorS();
            enemy3.img = new Bitmap("3.bmp");
            enemy3.X = vvv;
            enemy3.Y = 0;
            enemy3.W = 150;
            enemy3.H = 120;
            enemy3.dx = 15;
            enemy3.dy = 20;
            enemy3.img.MakeTransparent(enemy3.img.GetPixel(enemy3.img.Width - 1, 0));
            Lenemy3.Add(enemy3);
        }
        void CreateCoin(int vvvv)
        {
            coin = new ActorS();
            coin.img = new Bitmap("7.bmp");
            coin.X = vvvv;
            coin.Y = 0;
            coin.W = 70;
            coin.H = 50;
            coin.dx = 20;
            coin.dy = 30; 
            coin.img.MakeTransparent(coin.img.GetPixel(coin.img.Width - 1, 0));
            Lcoin.Add(coin);
        }

        void DrawScene(Graphics g2)
        {
            g2.Clear(Color.Gray);

            for (int i = 0; i < Lminu.Count; i++)
            {
                g2.DrawImage(Lminu[i].img, Lminu[i].X, Lminu[i].Y, Lminu[i].W, Lminu[i].H);

            }
            /*
            for (int i = 0; i < Lgameover.Count; i++)
            {
                g2.DrawImage(Lgameover[i].img, Lgameover[i].X, Lgameover[i].Y, Lgameover[i].W, Lgameover[i].H);

            }
            */
            for (int i = 0; i < Ltre2.Count; i++)
            {
                SolidBrush brsh = new SolidBrush(Ltre2[i].loon);
                g2.FillRectangle(brsh, Ltre2[i].X, Ltre2[i].Y, Ltre2[i].W, Ltre2[i].H);
            }

            for (int i = 0; i < Lkhtot.Count; i++)
            {
                SolidBrush brsh = new SolidBrush(Lkhtot[i].loon);
                g2.FillRectangle(brsh, Lkhtot[i].X, Lkhtot[i].Y, Lkhtot[i].W, Lkhtot[i].H);
            }

            for (int i = 0; i < LkhtotBakasa.Count; i++)
            {
                SolidBrush brsh = new SolidBrush(LkhtotBakasa[i].loon);
                g2.FillRectangle(brsh, LkhtotBakasa[i].X, LkhtotBakasa[i].Y, LkhtotBakasa[i].W, LkhtotBakasa[i].H);
            }

            for (int i = 0; i < Ldesert.Count; i++)
            {
                g2.DrawImage(Ldesert[i].img, Ldesert[i].X, Ldesert[i].Y, Ldesert[i].W, Ldesert[i].H);

            }

            for (int i = 0; i < Lhero.Count; i++)
            {
                g2.DrawImage(Lhero[i].img, Lhero[i].X, Lhero[i].Y, Lhero[i].W, Lhero[i].H);

            }

            for (int i = 0; i < Lenemy1.Count; i++)
            {
                g2.DrawImage(Lenemy1[i].img, Lenemy1[i].X, Lenemy1[i].Y, Lenemy1[i].W, Lenemy1[i].H);

            }

            for (int i = 0; i < Lenemy2.Count; i++)
            {
                g2.DrawImage(Lenemy2[i].img, Lenemy2[i].X, Lenemy2[i].Y, Lenemy2[i].W, Lenemy2[i].H);

            }

            for (int i = 0; i < Lenemy3.Count; i++)
            {
                g2.DrawImage(Lenemy3[i].img, Lenemy3[i].X, Lenemy3[i].Y, Lenemy3[i].W, Lenemy3[i].H);

            }

            for (int i = 0; i < Lcoin.Count; i++)
            {
                g2.DrawImage(Lcoin[i].img, Lcoin[i].X, Lcoin[i].Y, Lcoin[i].W, Lcoin[i].H);

            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                if (Lhero[0].X > Ltre2[0].X + Ltre2[0].W && Lhero[0].X + Lhero[0].W < Ltre2[1].X)
                {
                    hero.X += hero.dx;
                    
                }
                else
                {
                    flag = 1;
                    MessageBox.Show("GAME OVER");
                    MessageBox.Show("Your Score is " + Text);
                    flag = 0;

                    Lhero = new List<ActorS>();
                    CreateHero();
                    Lenemy1 = new List<ActorS>();
                    CreateEnemy1(v);
                    Lenemy2 = new List<ActorS>();
                    CreateEnemy2(vv);
                    Lenemy3 = new List<ActorS>();
                    CreateEnemy3(vvv);
                    Lcoin = new List<ActorS>();
                    CreateCoin(vvvv);

                    score = 0;
                }
            }
            if (e.KeyCode == Keys.Left)
            {

                if (Lhero[0].X > Ltre2[0].X + Ltre2[0].W && Lhero[0].X + Lhero[0].W < Ltre2[1].X)
                {
                    hero.X -= hero.dx;
                }
                else
                {
                    flag = 1;
                    MessageBox.Show("GAME OVER");
                    MessageBox.Show("Your Score is " + Text);
                    flag = 0;

                    Lhero = new List<ActorS>();
                    CreateHero();
                    Lenemy1 = new List<ActorS>();
                    CreateEnemy1(v);
                    Lenemy2 = new List<ActorS>();
                    CreateEnemy2(vv);
                    Lenemy3 = new List<ActorS>();
                    CreateEnemy3(vvv);
                    Lcoin = new List<ActorS>();
                    CreateCoin(vvvv);

                    score = 0;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                hero.Y -= hero.dy;
            }
            if (e.KeyCode == Keys.Down)
            {
                hero.Y += hero.dy;
            }
            //DrawDubb(this.CreateGraphics());
        }
        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubb(e.Graphics);
        }

        private void T_Tick(object sender, EventArgs e)
        {
            if (flagKber == 1)
            {
                if (flag == 0)
                {
                    Random R1 = new Random();
                    v = R1.Next(Ltre2[0].X + 50, Lkhtot[0].X - 50);
                    vv = R1.Next(Lkhtot[0].X + 50, Lkhtot[1].X - 50);
                    vvv = R1.Next(Lkhtot[1].X + 50, Ltre2[1].X - 100);
                    vvvv = R1.Next(Ltre2[0].X + 50, Ltre2[1].X - 50);
                    if (CountTicks % 1 == 0)
                    {
                        for (int i = 0; i < Lenemy1.Count; i++)
                        {
                            Lenemy1[i].Y += Lenemy1[i].dy;
                        }
                        for (int i = 0; i < Lenemy2.Count; i++)
                        {
                            Lenemy2[i].Y += Lenemy2[i].dy;
                        }
                        for (int i = 0; i < Lenemy3.Count; i++)
                        {
                            Lenemy3[i].Y += Lenemy3[i].dy;
                        }
                        for (int i = 0; i < Lcoin.Count; i++)
                        {
                            Lcoin[i].Y += Lcoin[i].dy;
                        }
                        for (int i = 0; i < Lkhtot.Count; i++)
                        {
                            Lkhtot[i].Y += Lkhtot[i].dy;
                        }
                        for (int i = 0; i < LkhtotBakasa.Count; i++)
                        {
                            LkhtotBakasa[i].Y += LkhtotBakasa[i].dy;
                        }



                    }

                    if (CountTicks % 7 == 0)
                    {
                        CreateKhtotBakasa();

                    }

                    if (CountTicks1 % 20 == 0)
                    {
                        CreateEnemy1(v);



                    }

                    if (CountTicks2 % 40 == 0)
                    {

                        CreateEnemy2(vv);

                    }

                    if (CountTicks3 % 60 == 0)
                    {

                        CreateEnemy3(vvv);

                    }

                    if (CountTicks4 % 80 == 0)
                    {

                        CreateCoin(vvvv);

                    }



                    for (int i = 0; i < Lenemy1.Count; i++)
                    {
                        if (Lhero[0].X >= Lenemy1[i].X && Lhero[0].X < Lenemy1[i].X + Lenemy1[i].W && Lhero[0].Y > Lenemy1[i].Y && Lhero[0].Y <= Lenemy1[i].Y + Lenemy1[i].H)
                        {
                            flag = 1;
                            if (flag == 1)
                            {
                                //CreateGameOver();
                                MessageBox.Show("GAME OVER");
                                MessageBox.Show("Your Score is " + Text);
                                flag = 0;
                                
                                Lhero = new List<ActorS>();
                                CreateHero();
                                Lenemy1 = new List<ActorS>();
                                CreateEnemy1(v);
                                Lenemy2 = new List<ActorS>();
                                CreateEnemy2(vv);
                                Lenemy3 = new List<ActorS>();
                                CreateEnemy3(vvv);
                                Lcoin = new List<ActorS>();
                                CreateCoin(vvvv);

                                score = 0;

                            }
                        }



                        if (Lhero[0].X + Lhero[0].W >= Lenemy1[i].X && Lhero[0].X + Lhero[0].W < Lenemy1[i].X + Lenemy1[i].W && Lhero[0].Y > Lenemy1[i].Y && Lhero[0].Y <= Lenemy1[i].Y + Lenemy1[i].H)
                        {
                            flag = 1;
                            if (flag == 1)
                            {
                                //CreateGameOver();
                                MessageBox.Show("GAME OVER");
                                MessageBox.Show("Your Score is " + Text);
                                flag = 0;

                                Lhero = new List<ActorS>();
                                CreateHero();
                                Lenemy1 = new List<ActorS>();
                                CreateEnemy1(v);
                                Lenemy2 = new List<ActorS>();
                                CreateEnemy2(vv);
                                Lenemy3 = new List<ActorS>();
                                CreateEnemy3(vvv);
                                Lcoin = new List<ActorS>();
                                CreateCoin(vvvv);

                                score = 0;

                            }
                        }


                    }

                    for (int i = 0; i < Lenemy2.Count; i++)
                    {
                        if (Lhero[0].X >= Lenemy2[i].X && Lhero[0].X < Lenemy2[i].X + Lenemy2[i].W && Lhero[0].Y > Lenemy2[i].Y && Lhero[0].Y <= Lenemy2[i].Y + Lenemy2[i].H)
                        {
                            flag = 1;
                            if (flag == 1)
                            {
                                //CreateGameOver();
                                MessageBox.Show("GAME OVER");
                                MessageBox.Show("Your Score is " + Text);
                                flag = 0;

                                Lhero = new List<ActorS>();
                                CreateHero();
                                Lenemy1 = new List<ActorS>();
                                CreateEnemy1(v);
                                Lenemy2 = new List<ActorS>();
                                CreateEnemy2(vv);
                                Lenemy3 = new List<ActorS>();
                                CreateEnemy3(vvv);
                                Lcoin = new List<ActorS>();
                                CreateCoin(vvvv);

                                score = 0;

                            }
                        }


                        if (Lhero[0].X + Lhero[0].W >= Lenemy2[i].X && Lhero[0].X + Lhero[0].W < Lenemy2[i].X + Lenemy2[i].W && Lhero[0].Y > Lenemy2[i].Y && Lhero[0].Y <= Lenemy2[i].Y + Lenemy2[i].H)
                        {
                            flag = 1;
                            if (flag == 1)
                            {
                                //CreateGameOver();
                                MessageBox.Show("GAME OVER");
                                MessageBox.Show("Your Score is " + Text);
                                flag = 0;

                                Lhero = new List<ActorS>();
                                CreateHero();
                                Lenemy1 = new List<ActorS>();
                                CreateEnemy1(v);
                                Lenemy2 = new List<ActorS>();
                                CreateEnemy2(vv);
                                Lenemy3 = new List<ActorS>();
                                CreateEnemy3(vvv);
                                Lcoin = new List<ActorS>();
                                CreateCoin(vvvv);

                                score = 0;

                            }
                        }


                    }

                    for (int i = 0; i < Lenemy3.Count; i++)
                    {
                        if (Lhero[0].X >= Lenemy3[i].X && Lhero[0].X < Lenemy3[i].X + Lenemy3[i].W && Lhero[0].Y > Lenemy3[i].Y && Lhero[0].Y <= Lenemy3[i].Y + Lenemy3[i].H)
                        {
                            flag = 1;
                            if (flag == 1)
                            {
                                //CreateGameOver();
                                MessageBox.Show("GAME OVER");
                                MessageBox.Show("Your Score is " + Text);
                                flag = 0;

                                Lhero = new List<ActorS>();
                                CreateHero();
                                Lenemy1 = new List<ActorS>();
                                CreateEnemy1(v);
                                Lenemy2 = new List<ActorS>();
                                CreateEnemy2(vv);
                                Lenemy3 = new List<ActorS>();
                                CreateEnemy3(vvv);
                                Lcoin = new List<ActorS>();
                                CreateCoin(vvvv);

                                score = 0;

                            }
                        }


                        if (Lhero[0].X + Lhero[0].W >= Lenemy3[i].X && Lhero[0].X + Lhero[0].W < Lenemy3[i].X + Lenemy3[i].W && Lhero[0].Y > Lenemy3[i].Y && Lhero[0].Y <= Lenemy3[i].Y + Lenemy3[i].H)
                        {
                            flag = 1;
                            if (flag == 1)
                            {
                                //CreateGameOver();
                                MessageBox.Show("GAME OVER");
                                MessageBox.Show("Your Score is " + Text);
                                flag = 0;

                                Lhero = new List<ActorS>();
                                CreateHero();
                                Lenemy1 = new List<ActorS>();
                                CreateEnemy1(v);
                                Lenemy2 = new List<ActorS>();
                                CreateEnemy2(vv);
                                Lenemy3 = new List<ActorS>();
                                CreateEnemy3(vvv);
                                Lcoin = new List<ActorS>();
                                CreateCoin(vvvv);

                                score = 0;

                            }
                        }

                    }
                    for (int i = 0; i < Lcoin.Count; i++)
                    {
                        if (Lhero[0].X >= Lcoin[i].X && Lhero[0].X < Lcoin[i].X + Lcoin[i].W && Lhero[0].Y > Lcoin[i].Y && Lhero[0].Y <= Lcoin[i].Y + Lcoin[i].H)
                        {
                            Lcoin[i].X = 1000000;
                            Lcoin[i].Y = 1000000;
                            score += 100;
                        }

                        if (Lhero[0].X + Lhero[0].W >= Lcoin[i].X && Lhero[0].X + Lhero[0].W < Lcoin[i].X + Lcoin[i].W && Lhero[0].Y > Lcoin[i].Y && Lhero[0].Y <= Lcoin[i].Y + Lcoin[i].H)
                        {
                            Lcoin[i].X = 1000000;
                            Lcoin[i].Y = 1000000;
                            score += 100;
                        }
                    }
                    this.Text = score + "";
                    score++;
                    CountTicks++;
                    CountTicks1++;
                    CountTicks2++;
                    CountTicks3++;
                    CountTicks4++;
                    DrawDubb(this.CreateGraphics());
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            
            CreateMinu();
        }
    }
}
