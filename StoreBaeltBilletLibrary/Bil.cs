using System;
using BilletLibrary;

namespace StoreBaeltBilletLibrary
{
    public class Bil : Køretøjer , IBroBizz
    {
        #region Constructors
        public Bil(string nummerPlade, DateTime dato) : base(nummerPlade, dato)
        {
        }

        public Bil()
        {
        }
        #endregion


        #region Methods

        

        public override decimal Pris()
        {
            return 240;
        }

        public override string Køretøj()
        {
            return "Bil";
        }
        /// <summary>
        /// Beregner prisen for kørsel over Storebælt med brobizz og giver rabat hvis det er lørdag eller søndag
        /// </summary>
        /// <returns></returns>
        public decimal BroBizz()
        {
            if (Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                return (Pris() * (0.8m)) * (0.95m);
            }
            else
            {
                return Pris() * (0.95m);
            }
            
        }

        #endregion

    }
}
