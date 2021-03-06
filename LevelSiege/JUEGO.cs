﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelSiege
{

    public partial class JUEGO : Form
    {
        public System.Media.SoundPlayer laser = new System.Media.SoundPlayer(Properties.Resources.laser);
        List<Label> disparos = new List<Label>();
        List<Label> monstruos = new List<Label>();
        List<ProgressBar> vidas = new List<ProgressBar>();
        Label disparo;
        Label monstruo;
        ProgressBar vida;
        int posicionx;
        int posiciony;
        int ultimo = 0;
        int x = 0;
        int y = 180;
        int xv = 0;
        int yv = 170;
        int municion = 100;
        int municionrest;
        int contador = 0;
        int monstrest;
        int monstruostotal=10;
        int velocidad=50;

        public JUEGO()
        {
            InitializeComponent();
            tiempom.Enabled = false;
            municionrest = municion;
            monstrest = monstruostotal;
            
        }


        private void bArma1_Click(object sender, EventArgs e)
        {

        }

        private void pbDisparo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void crearmonstruos()
        {
            if (monstruos.Capacity <= monstruostotal)
            {
                tiempom.Enabled = true;
                monstruo = new Label();
                monstruo.Image = Properties.Resources.monstruito;
                monstruo.BackColor = Color.Transparent;
                monstruo.SetBounds(x, y, 50, 50);
                monstruos.Add(monstruo);
                d.Controls.Add(monstruo);
                vida = new ProgressBar();
                vida.Value = 100;
                vida.SetBounds(xv, yv, 50, 3);
                vidas.Add(vida);
                d.Controls.Add(vida);
            }

        }



private void barma_Click(object sender, EventArgs e)
        {
            if (contador < municion)
            {
                contador++;
                laser.Play();
                disparo = new Label();
                posicionx = barma.Location.X;
                posiciony = barma.Location.Y;
                disparo.SetBounds(posicionx, posiciony - 50, 50, 55);
                disparo.Image = Properties.Resources.disparo;
                disparo.BackColor = Color.Transparent;
                disparos.Add(disparo);
                d.Controls.Add(disparo);
                tiempod.Enabled = true;
                ultimo++;
                municionrest--;
                lbmunicion.Text = "Municion "+municionrest;
                
            }
            else
            {
                foreach(Label m in monstruos)
                {
                    if (m.Visible)
                    {
                        MessageBox.Show("HAS PERDIDO");
                        pbjohn.Visible = false;
                        paneljohn.BackgroundImage = Properties.Resources.headstone_312540_960_720;
                        break;
                    }
                }
            }
        }

        private void tiempod_Tick(object sender, EventArgs e)
        {
            foreach (Label ab in disparos)
            {
                posiciony = ab.Location.Y - 20;
                ab.SetBounds(posicionx, posiciony, 50, 55);
            }
        }

        private void tiempom_Tick(object sender, EventArgs e)
        {
            tiempom.Interval = velocidad;
            recorrido(monstruos,vidas);
            comprobarjohn();
            
        }
        private void recorrido(List<Label> monstruos,List<ProgressBar> vidas)
        {
            int i = 0;
            foreach(Label ab in monstruos)
            {
                if (monstruos[i].Location.X != 130 && monstruos[i].Location.X < 312)
                {
                    monstruos[i].SetBounds((monstruos[i].Location.X + 2), monstruos[i].Location.Y, 50, 50);
                }
                if (monstruos[i].Location.X == 130 && monstruos[i].Location.Y != 52)
                {
                    monstruos[i].SetBounds(monstruos[i].Location.X, (monstruos[i].Location.Y - 2), 50, 50);

                }
                if (monstruos[i].Location.Y == 56)
                {
                    monstruos[i].SetBounds((monstruos[i].Location.X + 2), monstruos[i].Location.Y, 50, 50);


                }
                if (monstruos[i].Location.X == 314 && monstruos[i].Location.Y != 200)
                {
                    monstruos[i].SetBounds(monstruos[i].Location.X, (monstruos[i].Location.Y + 2), 50, 50);

                }
                if (monstruos[i].Location.Y == 200)
                {
                    monstruos[i].SetBounds(monstruos[i].Location.X + 2, monstruos[i].Location.Y, 50, 50);
                }
                if (monstruos[i].Location.X == 600 && monstruos[i].Location.Y != 136)
                {
                    monstruos[i].SetBounds(monstruos[i].Location.X, (monstruos[i].Location.Y - 2), 50, 50);
                }
                else
                if (monstruos[i].Location.Y < 138 && monstruos[i].Location.X >= 600 && monstruos[i].Location.X < 851)
                {
                    monstruos[i].SetBounds((monstruos[i].Location.X + 2), monstruos[i].Location.Y, 50, 50);

                }
                i++;
            }
            foreach (ProgressBar abc in vidas)
            {
                if (abc.Location.X != 130 && abc.Location.X < 312)
                {
                    abc.SetBounds((abc.Location.X + 2), abc.Location.Y, 50, 3);
                }
                if (abc.Location.X == 130 && abc.Location.Y != 46)
                {
                    abc.SetBounds(abc.Location.X, (abc.Location.Y - 2), 50, 3);

                }
                if (abc.Location.Y == 48)
                {
                    abc.SetBounds((abc.Location.X + 2), abc.Location.Y, 50, 3);
                }
                if (abc.Location.X == 314 && abc.Location.Y != 190)
                {
                    abc.SetBounds(abc.Location.X, (abc.Location.Y + 2), 50, 3);

                }
                if (abc.Location.Y == 190)
                {
                    abc.SetBounds(abc.Location.X + 2, abc.Location.Y, 50,3);
                }
                if (abc.Location.X == 600 && abc.Location.Y != 126)
                {
                    abc.SetBounds(abc.Location.X, (abc.Location.Y - 2), 50, 3);
                }
                else
                if (abc.Location.Y < 128 && abc.Location.X >= 600 && abc.Location.X < 851)
                {
                    abc.SetBounds((abc.Location.X + 2), abc.Location.Y, 50, 3);

                }
                
            }

        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            
            
        }

        private void crear_Tick(object sender, EventArgs e)
        {
            crear.Interval = 5000;
            crearmonstruos();
            crear.Stop();
            crear.Start();


        }
        public void comprobarcolision()
        {
            int i = 0;
            foreach(Label m in monstruos)
            {
                foreach (Label d in disparos)
                {
                    if (d.Location.Y >= (m.Location.Y - 50) && d.Location.Y <= m.Location.Y && (d.Location.X >= m.Location.X && d.Location.X <= (m.Location.X +50) || (d.Location.X+50) >= (m.Location.X) && (d.Location.X + 50) <= (m.Location.X+50) || d.Location.X >= m.Location.X && d.Location.X <= (m.Location.X + 50) &&(d.Location.X + 50) >= (m.Location.X) && (d.Location.X + 50) <= (m.Location.X + 50))&& d.Visible)
                    {
                        if (m.Visible == true)
                        {
                            d.Visible = false;
                        }
                        //para que no de errorrrrrrrrrr
                        if (vidas[i].Value >= 10)
                        {
                            vidas[i].Value = vidas[i].Value - 10;
                        }
                            if (vidas[i].Value == 0)
                            {
                            
                                vidas[i].Visible = false;
                                m.Visible = false;
                               
                            }
                        }
                                                          
                    }
                i++;
            }
                
            }
        
        public void comprobarjohn()
        {
            foreach(Label m in monstruos)
            {
                if (m.Location.X >= 849 && m.Visible)
                {
                    if (pbjohn.Value >= 2)
                    {
                        pbjohn.Value = pbjohn.Value - 2;
                    }
                        if (pbjohn.Value == 0)
                        {
                            pbjohn.Visible = false;
                        paneljohn.BackgroundImage = Properties.Resources.headstone_312540_960_720;
                        break;

                    }
                }
            }
        }

        private void compcoli_Tick(object sender, EventArgs e)
        {

            comprobarcolision();
        }

        private void d_MouseMove(object sender, MouseEventArgs e)
        {
            int mover = e.X;
            if (mover <= 926)
            {
                barma.Left = mover;
            }
        }

        private void lbmonstruos_Click(object sender, EventArgs e)
        {

        }
    }
}

