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

        /// <summary>
        /// Beregner kørsel over Storebælt i weekenden med BroBizz
        /// </summary>
        /// <returns></returns>
        public decimal WeekendRabatMedBroBizz()
        {
            return (Pris() * (0.8m)) * (0.95m);
        }


        /// <summary>
        /// Beregner kørsel over Storebælt i weekenden uden BroBizz
        /// </summary>
        /// <returns></returns>
        public decimal WeekendRabatUdenBroBizz()
        {
            return (Pris() * (0.8m));
        }

        public override decimal Pris()
        {
            return 240;
        }

        public override string Køretøj()
        {
            return "Bil";
        }

        public decimal BroBizz()
        {
            return Pris() * (0.95m);
        }

        #endregion

    }
}
