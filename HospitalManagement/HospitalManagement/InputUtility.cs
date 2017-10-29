//InputUtility.cs
//Skapad av Jan Zandstra 2012-03-11 M12K2531
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalManagement
{
    /// <summary>
    /// Denna klass innehåller två statiska metoder GetDouble samt GetInteger,
    /// Båda är överlagrade tre gånger med ett olika antal parametrar enligt:
    /// GetDouble(string, out double, double, double)
    /// GetDouble(string, out double, double)
    /// GetDouble(string, out double)
    /// GetInteger(string, out int, int, int)
    /// GetInteger(string, out int, int)
    /// GetInteger(string, out int)
    /// </summary>
    public class InputUtility
    {
        //----------------------------------------------------------------------
        /// <summary>
        /// Konverterar ett strängrepresenterat Double-värde till typen
        /// Double samt validerar att värdet är inom gränserna definierad av
        /// minLimit och maxLimit.
        /// </summary>
        /// <param name="stringToConvert">Strängrepresenterat Double-värde</param>
        /// <param name="dblOutValue">Output-parameter, det konverterade Double-värdet</param>
        /// <param name="minLimit">Output-värdet skall vara större eller lika med minLimit</param>
        /// <param name="maxLimit">Output-värdet skall vara mindre eller lika med maxLimit</param>
        /// <returns>Returnerar True om konverteringen är framgångsrik och det konverterade
        /// värdet är inom de angivna gränserna.</returns>
        public static bool GetDouble(string stringToConvert, out double dblOutValue, double minLimit, double maxLimit)
        {
            bool goodNumber = double.TryParse(stringToConvert, out dblOutValue);
            // gör en konvertering från string till double, om ok=true om ej ok=false , sparas i goodNumber
            if(goodNumber) // testar om konverteringen har gått bra då går vi vidare
            {
                if((dblOutValue>=minLimit)&&(dblOutValue<=maxLimit)) // testar om värdet ligger inom gränserna
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else  // hit om konverteringen inte gick bra
            {
                return false;
            }
        }
        //----------------------------------------------------------------------
        /// <summary>
        /// Konverterar ett strängrepresenterat Double-värde till typen
        /// Double samt validerar att värdet är inom gränsen definierad av
        /// minLimit.
        /// </summary>
        /// <param name="stringToConvert">Strängrepresenterat Double-värde</param>
        /// <param name="dblOutValue">Output-parameter, det konverterade Double-värdet</param>
        /// <param name="minLimit">Output-värdet skall vara större eller lika med minLimit</param>
        /// <returns>Returnerar True om konverteringen är framgångsrik och det konverterade
        /// värdet är inom den angivna gränsen.</returns>
        public static bool GetDouble(string stringToConvert, out double dblOutValue, double minLimit)
        {
            bool goodNumber = double.TryParse(stringToConvert, out dblOutValue);
            // gör en konvertering från string till double, om ok=true om ej ok=false , sparas i goodNumber
            if (goodNumber) // testar om konverteringen har gått bra då går vi vidare
            {
                if (dblOutValue >= minLimit) // testar om värdet ligger inom gränsen
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else  // hit om konverteringen inte gick bra
            {
                return false;
            }

        }
        //----------------------------------------------------------------------
        /// <summary>
        /// Konverterar ett strängrepresenterat Double-värde till typen Double
        /// </summary>
        /// <param name="stringToConvert">Strängrepresenterat Double-värde</param>
        /// <param name="dblOutValue">Output-parameter, det konverterade Double-värdet</param>
        /// <returns>Returnerar True om konverteringen är framgångsrik </returns>
        public static bool GetDouble(string stringToConvert, out double dblOutValue)
        {
            bool goodNumber = double.TryParse(stringToConvert, out dblOutValue);
            // gör en konvertering från string till double, om ok=true om ej ok=false , sparas i goodNumber
            if (goodNumber)
            {
                return true;
            }
            else // hit om konverteringen inte gick bra
            {
                return false;
            }
        }
        //----------------------------------------------------------------------
        /// <summary>
        /// Konverterar ett strängrepresenterat Integer-värde till typen
        /// Integer samt validerar att värdet är inom gränserna definierad av
        /// minLimit och maxLimit.
        /// </summary>
        /// <param name="stringToConvert">Strängrepresenterat Integer-värde</param>
        /// <param name="intOutValue">Output-parameter, det konverterade Integer-värdet</param>
        /// <param name="minLimit">Output-värdet skall vara större eller lika med minLimit</param>
        /// <param name="maxLimit">Output-värdet skall vara mindre eller lika med maxLimit</param>
        /// <returns>Returnerar True om konverteringen är framgångsrik och det konverterade
        /// värdet är inom de angivna gränserna.</returns>
        public static bool GetInteger(string stringToConvert, out int intOutValue, int minLimit, int maxLimit)
        {
            bool goodNumber = int.TryParse(stringToConvert, out intOutValue);
            // gör en konvertering från string till integer, om ok=true om ej ok=false , sparas i goodNumber
            if (goodNumber)  // testar om konverteringen har gått bra då går vi vidare
            {
                if ((intOutValue >= minLimit) && (intOutValue <= maxLimit)) // testar om värdet ligger inom gränserna 
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else  // hit om konverteringen inte gick bra
            {
                return false;
            }
        }
        //----------------------------------------------------------------------
        /// <summary>
        /// Konverterar ett strängrepresenterat Integer-värde till typen
        /// Integer samt validerar att värdet är inom gränsen definierad av
        /// minLimit.
        /// </summary>
        /// <param name="stringToConvert">Strängrepresenterat Integer-värde</param>
        /// <param name="intOutValue">Output-parameter, det konverterade Integer-värdet</param>
        /// <param name="minLimit">Output-värdet skall vara större eller lika med minLimit</param>
        /// <returns>Returnerar True om konverteringen är framgångsrik och det konverterade
        /// värdet är inom den angivna gränsen.</returns>
        public static bool GetInteger(string stringToConvert, out int intOutValue, int minLimit)
        {
            bool goodNumber = int.TryParse(stringToConvert, out intOutValue);
            // gör en konvertering från string till integer, om ok=true om ej ok=false , sparas i goodNumber
            if (goodNumber) // testar om konverteringen har gått bra då går vi vidare
            {
                if (intOutValue >= minLimit) // testar om värdet ligger inom gränsen
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else // hit om konverteringen inte gick bra
            {
                return false;
            }
        }
        //----------------------------------------------------------------------
        /// <summary>
        /// Konverterar ett strängrepresenterat Integer-värde till typen Integer 
        /// </summary>
        /// <param name="stringToConvert">Strängrepresenterat Integer-värde</param>
        /// <param name="intOutValue">Output-parameter, det konverterade Integer-värdet</param>
        /// <returns>Returnerar True om konverteringen är framgångsrik </returns>
        public static bool GetInteger(string stringToConvert, out int intOutValue)
        {
            bool goodNumber = int.TryParse(stringToConvert, out intOutValue);
            // gör en konvertering från string till integer, om ok=true om ej ok=false , sparas i goodNumber
            if (goodNumber)
            {
                return true;
            }
            else  // hit om konverteringen inte gick bra
            {
                return false;
            }
        }
        //----------------------------------------------------------------------

    }
}
