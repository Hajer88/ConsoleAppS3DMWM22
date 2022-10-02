using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppS3DMWM22
{
    //Exercice 4 et 6 atelier 2
    public class CompteBanque
    {
        private double solde;
        public CompteBanque()
        {
            solde = 0;
        }
        public CompteBanque(double solde)
        {
            this.solde = solde;
        }
        // exercice 6 atelier 2
        public static bool operator 
            ==(CompteBanque c1,CompteBanque c2)
        {
            if (c1.solde == c2.solde)   return true;
            return false;
        }
        public static bool operator
            !=(CompteBanque c1, CompteBanque c2)
        {
            return !(c1.solde == c2.solde);
        }
        public static CompteBanque operator
            +(CompteBanque c1, CompteBanque c2)
        {
            return new CompteBanque(c1.solde + c2.solde);
        }
        
        public void retirerArgent(double montant)
        {
            if(solde >= montant)
            {
                solde -= montant;
            }
        }
        public void deposerArgent(double montant)
        {
            solde += montant;
        }
        public int LireSolde()
        {
            return(int)solde;
        }
    }
}
