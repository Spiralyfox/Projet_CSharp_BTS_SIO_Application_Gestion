using System;
using System.Windows.Forms;

namespace Projet_CSharp_BTS_SIO_Application_Gestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // Sauvegarde d'un appareil
        private void buttonsave_Click(object sender, EventArgs e)
        {
            // Génération d'un id aléatoire (Doc : https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-integer-in-c)
            Random rnd = new Random();
            int id = rnd.Next(100000, 999999);

            // Création de l'instance temporaire qui servira de base pour l'enregistrement de l'appareil en BD avec "appareil.Save();"
            Appareil appareil = new Appareil(textBoxName.Text, comboBoxAddName.Text, comboBoxAddPiece.Text, id);

            appareil.Save();

            UpdateList();
        }
        

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateList();
        }


        // Update de la ListBox
        private void UpdateList()
        {
            listBoxAppareils.Items.Clear();
            comboBoxDeleteID.Items.Clear();
            comboBoxEditID.Items.Clear();

            // On ne définis pas le type de variable car "var" prend le résultat retourné et devine le type
            var appareils = Appareil.GetAll();

            foreach (var a in appareils)
            {
                listBoxAppareils.Items.Add(a.Id + " - " + a.Name + " - " + a.ItemName + " - " + a.Piece);
                
                // Update des comboBox pour contenir les ID de chaques appareils
                
                // (Petite fierté d'avoir trouvé sans l'aide d'internet, même si
                // en vrai c'était facile car c'est juste logique, j'ai copié la
                // manière de faire avec ListBox)
                comboBoxDeleteID.Items.Add(a.Id);
                
                comboBoxEditID.Items.Add(a.Id);
            }
        }




        // Suppression d'un appareil
        private void buttondelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxDeleteID.Text);

            // Appel de la méthode dans Appareil.cs
            Appareil.Delete(id);
            
            UpdateList();
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxEditID.Text);
            String name = textBoxEditName.Text;
            String itemname = comboBoxEditName.Text;
            String piece = comboBoxEditPiece.Text;
            

            // Appel de la méthode dans Appareil.cs
            Appareil.Edit(id, name, itemname, piece);
            
            UpdateList();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // CHargement des appareils au lancement
            UpdateList();
        }
    }
}