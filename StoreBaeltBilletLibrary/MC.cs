using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace StoreBaeltBilletLibrary
{
    public class MC : Køretøjer, IBroBizz
    {
        #region Constructors

        public MC(string nummerPlade, DateTime dato) : base(nummerPlade, dato)
        {
        }

        public MC()
        {
        }
        #endregion

        
        #region Methods

        /// <summary>
        /// Beregner kørsel over Storebælt i weekenden med BroBizz
        /// </summary>
        /// <returns></returns>
       
        public override decimal Pris()
        {
            return 125;
        }

        public override string Køretøj()
        {
            return "MC";
        }

        public decimal BroBizz()
        {
            return Pris() * (0.95m);
        }

        #endregion
        
    }
}
