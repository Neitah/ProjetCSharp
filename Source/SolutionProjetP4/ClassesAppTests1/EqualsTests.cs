using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesApp;
using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace ClassesApp.Tests
{
    [TestClass()]
    public class EqualsTests
    {
        [TestMethod()]
        public void UtilisateurEqualsTest()
        {
            Utilisateur u1 = new Utilisateur("Nom", "motDePasse");
            Utilisateur u2 = new Utilisateur("Nom", "motDePasse");
            if (u1.Equals(u2))
                return;
            else
                throw new Exception("PB Equals Utilisateur");
        }

        [TestMethod()]
        public void CompétenceEqualsTest()
        {
            Compétence c1 = new Compétence("desc", "nom");
            Compétence c2 = new Compétence("desc", "nom");
            if (c1.Equals(c2))
                return;
            else
                throw new Exception("PB Equals Compétence");
        }

        [TestMethod()]
        public void VoieTestEquals()
        {
            Voie v1 = new Stub().Charger("").lesProfils[0].LesVoies[0];
            Voie v2 = new Stub().Charger("").lesProfils[0].LesVoies[0];
            if (v1.Equals(v2))
                return;
            else
                throw new Exception("PB Equals Voie");
        }

        [TestMethod()]
        public void ProfilTestEquals()
        {
            Profil p1 = new Stub().Charger("").lesProfils[0];
            Profil p2 = new Stub().Charger("").lesProfils[0];
            if (p1.Equals(p2))
                return;
            else
                throw new Exception("PB Equals Voie");
        }
    }
}