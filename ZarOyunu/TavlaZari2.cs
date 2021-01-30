using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarOyunu
{
    class TavlaZari2
    {
        /// <summary>
        /// Zarın alabileceği maksimum değer değişkeni
        /// </summary>
        int maksimumZarDegeri;

        Random random2 = new Random();

        /// <summary>
        /// Zarın alabilecği maksimum değeri giriniz
        /// </summary>
        /// <param name="maksimumZarDegeri"></param>
        public TavlaZari2(int maksimumZarDegeri)
        {
            this.maksimumZarDegeri = maksimumZarDegeri;
        }

        /// <summary>
        /// Rastgele bir sayı için zar at
        /// </summary>
        /// <returns></returns>
        public int ZarAt()
        {
            //Rastgele sayı üretilecek
            return random2.Next(1, maksimumZarDegeri + 1);
        }
    }
}
