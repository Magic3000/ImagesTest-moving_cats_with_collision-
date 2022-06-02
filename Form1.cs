using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagesTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitImages();
        }

        private PictureBox kotik1;
        private PictureBox kotik2;
        public void InitImages()
        {

            kotik1 = new System.Windows.Forms.PictureBox();
            kotik2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(kotik1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(kotik2)).BeginInit();

            SuspendLayout();
            // 
            // kotik1
            // 
            kotik1.Image = global::ImagesTest.Resource1.kotik1;
            kotik1.Location = new System.Drawing.Point(50, 50);
            kotik1.Name = "kotik1";
            kotik1.Size = new System.Drawing.Size(500, 350);
            kotik1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            kotik1.TabIndex = 0;
            kotik1.TabStop = false;
            // 
            // kotik2
            // 
            kotik2.Image = global::ImagesTest.Resource1.kotik2;
            kotik2.Location = new System.Drawing.Point(850, 50);
            kotik2.Name = "kotik2";
            kotik2.Size = new System.Drawing.Size(500, 350);
            kotik2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            kotik2.TabIndex = 1;
            kotik2.TabStop = false;
            Controls.Add(kotik1);
            Controls.Add(kotik2);
            ((System.ComponentModel.ISupportInitialize)(kotik1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(kotik2)).EndInit();
            ResumeLayout(false);
            int kotik1State = 0;
            int kotik2State = 0;
            var kotik1Upd = new Thread(() =>
            {
                Thread.Sleep(1000);
                while (true)
                {
                    var kotik1Loc = kotik1.Location;
                    switch (kotik1State)
                    {
                        case 0:
                            if (kotik1Loc.Y >= 500)
                            {
                                kotik1State = 1;
                                break;
                            }
                            kotik1Loc.Y += 1 * speed;
                            try { Invoke(new Action(() => { kotik1.Location = kotik1Loc; })); }
                            catch { }
                            break;
                        case 1:
                            if (kotik1Loc.X >= 350)
                            {
                                kotik1State = 2;
                                break;
                            }
                            kotik1Loc.X += 1 * speed;
                            try { Invoke(new Action(() => { kotik1.Location = kotik1Loc; })); }
                            catch { }
                            break;
                        case 2:
                            if (kotik1Loc.Y <= 50)
                            {
                                kotik1State = 3;
                                break;
                            }
                            kotik1Loc.Y -= 1 * speed;
                            try { Invoke(new Action(() => { kotik1.Location = kotik1Loc; })); }
                            catch { }
                            break;
                        case 3:
                            if (kotik1Loc.X <= 50)
                            {
                                kotik1State = 0;
                                break;
                            }
                            kotik1Loc.X -= 1 * speed;
                            try { Invoke(new Action(() => { kotik1.Location = kotik1Loc; })); }
                            catch { }
                            break;
                        default:
                            break;
                    }
                    
                    var kotik2Loc = kotik2.Location;
                    switch (kotik2State)
                    {
                        case 0:
                            if (kotik2Loc.Y >= 500)
                            {
                                kotik2State = 1;
                                break;
                            }
                            kotik2Loc.Y += 1 * speed;
                            try { Invoke(new Action(() => { kotik2.Location = kotik2Loc; })); }
                            catch { }
                            break;
                        case 1:
                            if (kotik2Loc.X <= 350)
                            {
                                kotik2State = 2;
                                break;
                            }
                            kotik2Loc.X -= 1 * speed;
                            try { Invoke(new Action(() => { kotik2.Location = kotik2Loc; })); }
                            catch { }
                            break;
                        case 2:
                            if (kotik2Loc.Y <= 50)
                            {
                                kotik2State = 3;
                                break;
                            }
                            kotik2Loc.Y -= 1 * speed;
                            try { Invoke(new Action(() => { kotik2.Location = kotik2Loc; })); }
                            catch { }
                            break;
                        case 3:
                            if (kotik2Loc.X >= 850)
                            {
                                kotik2State = 0;
                                break;
                            }
                            kotik2Loc.X += 1 * speed;
                            try { Invoke(new Action(() => { kotik2.Location = kotik2Loc; })); }
                            catch { }
                            break;
                        default:
                            break;
                    }

                    try { Invoke(new Action(() => {
                        var isCollision = kotik1.Bounds.IntersectsWith(kotik2.Bounds);
                        collisionCheckLabel.Text = $"Collision: {(isCollision ? "True" : "False")}";
                        collisionCheckLabel.ForeColor = isCollision ? Color.Green : Color.Red;
                    }));
                    }
                    catch { }
                    Thread.Sleep(5);
                }
            });
            kotik1Upd.IsBackground = true;
            kotik1Upd.Start();
        }

        private int speed = 3;
    }
}
