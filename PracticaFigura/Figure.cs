namespace PracticaFigura
{

    /*  Crear una aplicacion de escritorio que permita calcular el perimetro y el area de diferentes figuras geometricas: rectangulo, circulo y triangulo.
     *  Tendrá un botón para cada una de ellas y dos campos de entrada para poder introducir los valores correspondientes para poder calcular su area y su perimetro
     *  que se mostrarán una vez que se pulse cada boton.
     * 
     *  Crear una clase Figura que va a actuar como clase padre.
     *  Solo tendra 2 metodos virtuales:
     *      public virtual float Perimetro();
     *      public virtual float Area();
     *      
     *  Crear 3 clases hijas: Rectangulo, Circulo, Triangulo que hereden de Figura y que sobreescriban los metodos virtuales para obtener el perimetro y el area
     *  correspondiente a cada una de las figuras.
     *  
     *  -Comentar correctamente el codigo
     *  -Generar documentacion con doxygen
     *  -Subir a github
     * 
     */

    class Figure
    {

        public virtual float Perimetre(float side,float side2)
        {
            return 2*side + 2*side2;
        }

        public virtual float Area(float baseSide, float height)
        {
            return baseSide * height;
        }

    }
}
