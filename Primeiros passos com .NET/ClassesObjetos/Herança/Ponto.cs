using System;

namespace Classes.Herança{
    class Ponto{
        public int x, y;

        private int distancia;

        public Ponto(int x, int y){
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia(){
            // ...
        }

		protected void CalcularDistancia2(){
			// ...
		}

    }
}
