namespace membrosEstaticos
{
    public class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double r){
            // r * Pi * r
            return 2 * Pi * r;
        }

        public static double Volume(double r){ // 
            // 4 / 3 * Pi * r³ 
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}