using System.Runtime.CompilerServices;

namespace libPluviometrie
{
    public class Pluviometrie
    {

        private int[] ville1;
        private int[] ville2;
        private int[] ville3;

        public Pluviometrie(int[] tab1, int[] tab2, int[] tab3)
        {
            this.ville1 = tab1;
            this.ville2 = tab2;
            this.ville3 = tab3;
        }

        public string Affiche(int[] tab)
        {
            return "";
        }

        public int PluviositeAnnee()
        {
            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            
            for(int i=0; i<ville1.Length;i++)
            {
                s1 += ville1[i];
                s2 += ville2[i];
                s3 += ville3[i];
            }

            int res = 0;
            int annemax = Max(s1, s3, s2);

            if (s1 == annemax) { res = 1; }
            else {
                if (s2 == annemax) { res = 2; }
                else { res = 3; }
                  }




            return res;
        }

        public int[] PluviositeMois()
        {
            int[] tabmax = new int[12];
            for (int i = 0; i < 11; i++)
            {
                tabmax[i] = Max(ville1[i], ville2[2], ville3[i]);
                
            }
            return tabmax;
        }

        public int PluviositeRegion()
        {

            int[] moismax = new int[12];
            for (int i = 0; i<11; i++)
            {
                moismax[i]= Somme(ville1[i], ville2[2], ville3[i]);


            }
            int maxm = moismax[0];
            int indmax = 0;
            for (int i = 0; i< 11; i++)
            {

                if (moismax[i] > maxm) 
                {
                    maxm = moismax[i];
                    indmax = i;

                }
               
            }


            return indmax;
        }
        public int Max(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }

            return max;


        }
        public int Somme(int a, int b, int c)
        {
            int s = a + b + c;
            return s;
        }

        
    }
}