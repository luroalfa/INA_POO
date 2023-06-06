using System.Drawing;

namespace LogicaNegocio
{
    public class ClsPromedio
    {
        private string _condicion;
        private Color _color;
        private string _promedio;

        public Color getColor()
        {
            return _color;
        }
        public string getCondicion()
        {
            return _condicion;
        }

        public double calculoPromedio(double sumaNotas, double cantidaNotas) {
            return sumaNotas / cantidaNotas;
        }

        public void calculoCondicion(double promedio) {
            if(promedio > 70){
                _condicion = "Aprobado";
                _color = Color.FromName("Green"); 
            } else {
                _condicion = "Reprobado";
                _color = Color.FromName("Red");
            }
        }
    }
}