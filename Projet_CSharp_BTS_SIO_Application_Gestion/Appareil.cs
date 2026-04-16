using System;
using System.Collections.Generic;
using System.IO;

namespace Projet_CSharp_BTS_SIO_Application_Gestion
{
    // Définition des attributs
    public class Appareil
    {
        public int Id;
        public string Name;
        public string ItemName;
        public string Piece;

        private static string filePath = "..\\..\\..\\Appareils.txt"; // Path relatif

        
        // Constructeur
        public Appareil(string name, string itemName, string piece, int id)
        {
            Name = name;
            ItemName = itemName;
            Piece = piece;
            Id = id;
        }
        
        
        
        // Ecriture dans le fichier (lien relatif défini plus haut)
        // Syntaxe "Using" pour éviter les problèmes de fermeture de fichier
        public void Save()
        {
            using (StreamWriter bd = new StreamWriter(filePath, true))
            {
                bd.WriteLine(Id + "|" + Name + "|" + ItemName + "|" + Piece); // Ecrit en une seule ligne l'appareil
            }
        }
        
        
        
        // Récupère la liste des Appareils dans le fichier et les renvois là où la fonction est appelée
        public static List<Appareil> GetAll()
        {
            List<Appareil> appareils = new List<Appareil>();

            using (StreamReader bd = new StreamReader(filePath))
            {
                while (!bd.EndOfStream)
                {
                    string line = bd.ReadLine();
                    string[] parts = line.Split('|'); // Sépare la ligne de l'appareil pour récupérer les sections
                    // Ajoute l'appareil à la liste (En en faisant un nouvel objet)
                    Appareil a = new Appareil(parts[1], parts[2], parts[3], int.Parse(parts[0]));
                    // 0 = ID / 1 = Name / 2 = ItemName / 3 = Piece
                    appareils.Add(a);
                }
            }
            return appareils;
        }
        
        
        
        // Méthode pour la suppression
        public static void Delete(int id)
        {
            var appareils = GetAll();
            using (StreamWriter bd = new StreamWriter(filePath, false))
            
                foreach (var a in appareils)
                {
                    // Réécriture complète de la bd sans l'appareil que nous voulons supprimer
                    if (a.Id != id)
                        bd.WriteLine(a.Id + "|" + a.Name + "|" + a.ItemName + "|" + a.Piece);
                }
            
        }
        
        
        
        // Méthode pour éditer un appareil
        public static void Edit(int id, string name, string itemname, string piece)
        {
            var appareils = GetAll();
            using (StreamWriter bd = new StreamWriter(filePath, false)) 

                foreach (var a in appareils)
                {
                    // Réécriture complète de la bd avec edition de l'item à éditer
                    if (a.Id != id)
                        bd.WriteLine(a.Id + "|" + a.Name + "|" + a.ItemName + "|" + a.Piece);
                    else
                    {
                        bd.WriteLine(id + "|" + name + "|" + itemname + "|" + piece);
                    }
                    
                }
        }
    
    
    
    
    }
}