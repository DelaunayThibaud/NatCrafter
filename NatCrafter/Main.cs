using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatCrafter
{
    public partial class Main : Form
    {
        static System.Windows.Forms.Timer myTimerUpdate = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerChrono = new System.Windows.Forms.Timer();
        static int difficulte = 0;
        Jeu jeu = new Jeu(difficulte);
        private List<Material> material = new List<Material>();

        public Main()
        {
            InitializeComponent();
            InitializeObjects();
            InitializeInterface();
            InitializeTimers();
        }

        private void InitializeTimers()
        { 
            myTimerUpdate.Interval = 100;
            myTimerUpdate.Tick += new EventHandler(myTimerUpdate_Tick); 
            myTimerUpdate.Enabled = true;
            myTimerChrono.Interval = 1000;
            myTimerChrono.Tick += new EventHandler(myTimerChrono_Tick);
            if (difficulte != 0)
            {
            myTimerChrono.Enabled = true;
            }
        }

        private void InitializeObjects()
        {
            material.Add(new Material("Bois", material.Count, 0.5, 0.4));
            material.Add(new Material("Pierre", material.Count, 0.5, 0.4));
        }

        private void InitializeInterface()
        {
            foreach (Material matTemp in material)
            {
                Panel panel = new Panel();
                if (material.Count > 7)
                {
                    panel.Size = new Size(1010, 50);
                }
                else
                {
                    panel.Size = new Size(1020, 50);
                }

                panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                panel.Name = "pnlMat" + matTemp.Name;
                PictureBox picture = new PictureBox();
                picture.Location = new Point(2,-1);
                picture.Size = new Size(50, 50);
                picture.BackgroundImageLayout = ImageLayout.Stretch;
                switch(matTemp.Name)
                {
                    case "Bois":
                        picture.BackgroundImage = NatCrafter.Properties.Resources.Bois;
                        break;
                    case "Pierre":
                        picture.BackgroundImage = NatCrafter.Properties.Resources.Pierre;
                        break;
                    default:
                        picture.BackgroundImage = NatCrafter.Properties.Resources.Erreur;
                        break;
                }
                picture.Name = "picMat" + matTemp.Name;
                panel.Controls.Add(picture);
                Label label1 = new Label();
                label1.Location = new Point(60, 5);
                label1.Name = "lblMatName" + matTemp.Name;
                label1.Text = matTemp.Name;
                panel.Controls.Add(label1);
                flpMaterial.Controls.Add(panel);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (difficulte == 0)
            {
                lblTimer.Text = "Aucune limite de temps";
            }
            else
            {
                lblTimer.Text = "Temps Restant : " + jeu.TimerString();
            }

        }

        private void myTimerChrono_Tick(object Sender, EventArgs e)
        {
            jeu.majTimer();
            lblTimer.Text = "Temps Restant : " + jeu.TimerString();
        }

        private void myTimerUpdate_Tick(object Sender, EventArgs e)
        {
            
        }
    }
}
