using System;
using System.Windows.Forms;

namespace ProjetStage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Text = "Fenêtre TopMost"; // Titre de la fenêtre
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Bordure de la fenêtre
            this.StartPosition = FormStartPosition.Manual; // Position manuelle
            this.Location = new System.Drawing.Point(50, 50); // Position de la fenêtre
            this.TopMost = true; // Définit la fenêtre comme TopMost

            // Label pour afficher "Hello World"
            Label label = new Label();
            label.Text = "Hello World";
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(20, 20);

            this.Controls.Add(label); // Ajout du label à la fenêtre
            this.Activate(); // Force la fenêtre à passer en premier plan
        }
    }
}
