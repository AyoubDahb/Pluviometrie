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
            return 0;
        }

        public int[] PluviositeMois()
        {
            return ville1;
        }

        public int PluviositeRegion()
        {
            return 0;
        }
        
    }
}