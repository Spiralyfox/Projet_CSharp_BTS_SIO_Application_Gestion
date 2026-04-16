namespace Projet_CSharp_BTS_SIO_Application_Gestion;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        listBoxAppareils = new System.Windows.Forms.ListBox();
        label2 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        textBoxName = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        comboBoxAddName = new System.Windows.Forms.ComboBox();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        comboBoxAddPiece = new System.Windows.Forms.ComboBox();
        label8 = new System.Windows.Forms.Label();
        buttonsave = new System.Windows.Forms.Button();
        label9 = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        comboBoxDeleteID = new System.Windows.Forms.ComboBox();
        buttondelete = new System.Windows.Forms.Button();
        label11 = new System.Windows.Forms.Label();
        comboBoxEditID = new System.Windows.Forms.ComboBox();
        label12 = new System.Windows.Forms.Label();
        label13 = new System.Windows.Forms.Label();
        comboBoxEditPiece = new System.Windows.Forms.ComboBox();
        label14 = new System.Windows.Forms.Label();
        label15 = new System.Windows.Forms.Label();
        comboBoxEditName = new System.Windows.Forms.ComboBox();
        textBoxEditName = new System.Windows.Forms.TextBox();
        label16 = new System.Windows.Forms.Label();
        label17 = new System.Windows.Forms.Label();
        buttonEdit = new System.Windows.Forms.Button();
        buttonUpdate = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(12, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(194, 18);
        label1.TabIndex = 0;
        label1.Text = "Gestionaire d\'appareils connectés";
        // 
        // listBoxAppareils
        // 
        listBoxAppareils.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        listBoxAppareils.FormattingEnabled = true;
        listBoxAppareils.ItemHeight = 15;
        listBoxAppareils.Location = new System.Drawing.Point(402, 30);
        listBoxAppareils.Name = "listBoxAppareils";
        listBoxAppareils.Size = new System.Drawing.Size(386, 392);
        listBoxAppareils.TabIndex = 1;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(402, 9);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(109, 18);
        label2.TabIndex = 2;
        label2.Text = "Liste des appareils";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(12, 57);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(107, 16);
        label4.TabIndex = 4;
        label4.Text = "Nom de l\'appareil :";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(12, 30);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(194, 17);
        label3.TabIndex = 6;
        label3.Text = "Ajouter un appareil :";
        // 
        // textBoxName
        // 
        textBoxName.Location = new System.Drawing.Point(118, 54);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new System.Drawing.Size(100, 23);
        textBoxName.TabIndex = 7;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(12, 84);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(58, 16);
        label5.TabIndex = 5;
        label5.Text = "Appareil :";
        // 
        // comboBoxAddName
        // 
        comboBoxAddName.FormattingEnabled = true;
        comboBoxAddName.Items.AddRange(new object[] { "Assistant Home", "Caméra intérieure", "Caméra extérieure", "Caméra bébé", "Sonnette", "Porte vérouillée", "Prise", "Lumière", "Interrupteur/Bouton", "Capteur", "Aspirateur robot", "Télécommande IR" });
        comboBoxAddName.Location = new System.Drawing.Point(68, 81);
        comboBoxAddName.Name = "comboBoxAddName";
        comboBoxAddName.Size = new System.Drawing.Size(121, 23);
        comboBoxAddName.TabIndex = 8;
        comboBoxAddName.Text = "Choisissez..";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(195, 84);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(201, 16);
        label6.TabIndex = 9;
        label6.Text = "(Ou écrivez le nom de votre appareil)";
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(12, 114);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(44, 16);
        label7.TabIndex = 10;
        label7.Text = "Pièce :";
        // 
        // comboBoxAddPiece
        // 
        comboBoxAddPiece.FormattingEnabled = true;
        comboBoxAddPiece.Items.AddRange(new object[] { "Salon", "Salle à manger", "Cuisine", "Séjour", "Chambre", "Salle de bain", "WC", "Dressing", "Terrasse", "Jardin", "Patio", "Véranda", "Cave", "Grenier", "Couloir", "Escalier", "Hall d\'entrée", "Salle multimédia", "Salle de musique", "Salle de sport", "Biblihotèque", "Atelier" });
        comboBoxAddPiece.Location = new System.Drawing.Point(53, 110);
        comboBoxAddPiece.Name = "comboBoxAddPiece";
        comboBoxAddPiece.Size = new System.Drawing.Size(121, 23);
        comboBoxAddPiece.TabIndex = 11;
        comboBoxAddPiece.Text = "Choisissez..";
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(180, 114);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(216, 16);
        label8.TabIndex = 12;
        label8.Text = "(Ou écrivez le nom de la pièce / zone)";
        // 
        // buttonsave
        // 
        buttonsave.Location = new System.Drawing.Point(12, 139);
        buttonsave.Name = "buttonsave";
        buttonsave.Size = new System.Drawing.Size(107, 23);
        buttonsave.TabIndex = 13;
        buttonsave.Text = "Ajouter";
        buttonsave.UseVisualStyleBackColor = true;
        buttonsave.Click += buttonsave_Click;
        // 
        // label9
        // 
        label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label9.Location = new System.Drawing.Point(12, 179);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(194, 17);
        label9.TabIndex = 14;
        label9.Text = "Supprimer un appareil :";
        // 
        // label10
        // 
        label10.Location = new System.Drawing.Point(12, 205);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(92, 16);
        label10.TabIndex = 15;
        label10.Text = "ID de l\'appareil :";
        // 
        // comboBoxDeleteID
        // 
        comboBoxDeleteID.FormattingEnabled = true;
        comboBoxDeleteID.Location = new System.Drawing.Point(110, 202);
        comboBoxDeleteID.Name = "comboBoxDeleteID";
        comboBoxDeleteID.Size = new System.Drawing.Size(121, 23);
        comboBoxDeleteID.TabIndex = 16;
        comboBoxDeleteID.Text = "Choisissez l\'ID..";
        // 
        // buttondelete
        // 
        buttondelete.Location = new System.Drawing.Point(12, 234);
        buttondelete.Name = "buttondelete";
        buttondelete.Size = new System.Drawing.Size(107, 23);
        buttondelete.TabIndex = 17;
        buttondelete.Text = "Supprimer";
        buttondelete.UseVisualStyleBackColor = true;
        buttondelete.Click += buttondelete_Click;
        // 
        // label11
        // 
        label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label11.Location = new System.Drawing.Point(12, 269);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(194, 17);
        label11.TabIndex = 18;
        label11.Text = "Modifier un appareil :";
        // 
        // comboBoxEditID
        // 
        comboBoxEditID.FormattingEnabled = true;
        comboBoxEditID.Location = new System.Drawing.Point(110, 292);
        comboBoxEditID.Name = "comboBoxEditID";
        comboBoxEditID.Size = new System.Drawing.Size(121, 23);
        comboBoxEditID.TabIndex = 20;
        comboBoxEditID.Text = "Choisissez l\'ID..";
        // 
        // label12
        // 
        label12.Location = new System.Drawing.Point(12, 295);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(92, 16);
        label12.TabIndex = 19;
        label12.Text = "ID de l\'appareil :";
        // 
        // label13
        // 
        label13.Location = new System.Drawing.Point(180, 379);
        label13.Name = "label13";
        label13.Size = new System.Drawing.Size(216, 16);
        label13.TabIndex = 28;
        label13.Text = "(Ou écrivez le nom de la pièce / zone)";
        // 
        // comboBoxEditPiece
        // 
        comboBoxEditPiece.FormattingEnabled = true;
        comboBoxEditPiece.Items.AddRange(new object[] { "Salon", "Salle à manger", "Cuisine", "Séjour", "Chambre", "Salle de bain", "WC", "Dressing", "Terrasse", "Jardin", "Patio", "Véranda", "Cave", "Grenier", "Couloir", "Escalier", "Hall d\'entrée", "Salle multimédia", "Salle de musique", "Salle de sport", "Biblihotèque", "Atelier" });
        comboBoxEditPiece.Location = new System.Drawing.Point(53, 375);
        comboBoxEditPiece.Name = "comboBoxEditPiece";
        comboBoxEditPiece.Size = new System.Drawing.Size(121, 23);
        comboBoxEditPiece.TabIndex = 27;
        comboBoxEditPiece.Text = "Choisissez..";
        // 
        // label14
        // 
        label14.Location = new System.Drawing.Point(12, 379);
        label14.Name = "label14";
        label14.Size = new System.Drawing.Size(44, 16);
        label14.TabIndex = 26;
        label14.Text = "Pièce :";
        // 
        // label15
        // 
        label15.Location = new System.Drawing.Point(195, 349);
        label15.Name = "label15";
        label15.Size = new System.Drawing.Size(201, 16);
        label15.TabIndex = 25;
        label15.Text = "(Ou écrivez le nom de votre appareil)";
        // 
        // comboBoxEditName
        // 
        comboBoxEditName.FormattingEnabled = true;
        comboBoxEditName.Items.AddRange(new object[] { "Assistant Home", "Caméra intérieure", "Caméra extérieure", "Caméra bébé", "Sonnette", "Porte vérouillée", "Prise", "Lumière", "Interrupteur/Bouton", "Capteur", "Aspirateur robot", "Télécommande IR" });
        comboBoxEditName.Location = new System.Drawing.Point(68, 346);
        comboBoxEditName.Name = "comboBoxEditName";
        comboBoxEditName.Size = new System.Drawing.Size(121, 23);
        comboBoxEditName.TabIndex = 24;
        comboBoxEditName.Text = "Choisissez..";
        // 
        // textBoxEditName
        // 
        textBoxEditName.Location = new System.Drawing.Point(118, 319);
        textBoxEditName.Name = "textBoxEditName";
        textBoxEditName.Size = new System.Drawing.Size(100, 23);
        textBoxEditName.TabIndex = 23;
        // 
        // label16
        // 
        label16.Location = new System.Drawing.Point(12, 349);
        label16.Name = "label16";
        label16.Size = new System.Drawing.Size(58, 16);
        label16.TabIndex = 22;
        label16.Text = "Appareil :";
        // 
        // label17
        // 
        label17.Location = new System.Drawing.Point(12, 322);
        label17.Name = "label17";
        label17.Size = new System.Drawing.Size(107, 16);
        label17.TabIndex = 21;
        label17.Text = "Nom de l\'appareil :";
        // 
        // buttonEdit
        // 
        buttonEdit.Location = new System.Drawing.Point(12, 404);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new System.Drawing.Size(107, 23);
        buttonEdit.TabIndex = 29;
        buttonEdit.Text = "Modifier";
        buttonEdit.UseVisualStyleBackColor = true;
        buttonEdit.Click += buttonEdit_Click;
        // 
        // buttonUpdate
        // 
        buttonUpdate.Location = new System.Drawing.Point(537, 5);
        buttonUpdate.Name = "buttonUpdate";
        buttonUpdate.Size = new System.Drawing.Size(107, 23);
        buttonUpdate.TabIndex = 30;
        buttonUpdate.Text = "Update";
        buttonUpdate.UseVisualStyleBackColor = true;
        buttonUpdate.Click += buttonUpdate_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Azure;
        ClientSize = new System.Drawing.Size(800, 434);
        Controls.Add(buttonUpdate);
        Controls.Add(buttonEdit);
        Controls.Add(label13);
        Controls.Add(comboBoxEditPiece);
        Controls.Add(label14);
        Controls.Add(label15);
        Controls.Add(comboBoxEditName);
        Controls.Add(textBoxEditName);
        Controls.Add(label16);
        Controls.Add(label17);
        Controls.Add(comboBoxEditID);
        Controls.Add(label12);
        Controls.Add(label11);
        Controls.Add(buttondelete);
        Controls.Add(comboBoxDeleteID);
        Controls.Add(label10);
        Controls.Add(label9);
        Controls.Add(buttonsave);
        Controls.Add(label8);
        Controls.Add(comboBoxAddPiece);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(comboBoxAddName);
        Controls.Add(textBoxName);
        Controls.Add(label3);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label2);
        Controls.Add(listBoxAppareils);
        Controls.Add(label1);
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button buttonUpdate;

    private System.Windows.Forms.Button buttonEdit;

    private System.Windows.Forms.ComboBox comboBoxEditID;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.TextBox textBoxEditName;
    private System.Windows.Forms.ComboBox comboBoxEditPiece;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.ComboBox comboBoxEditName;
    private System.Windows.Forms.Label label17;

    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ComboBox comboBoxDeleteID;
    private System.Windows.Forms.Button buttondelete;
    private System.Windows.Forms.Label label11;

    private System.Windows.Forms.Button buttonsave;
    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox comboBoxAddPiece;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.ComboBox comboBoxAddName;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.ListBox listBoxAppareils;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}