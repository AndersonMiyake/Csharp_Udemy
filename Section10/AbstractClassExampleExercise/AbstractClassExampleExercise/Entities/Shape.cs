using AbstractClassExampleExercise.Entities.Enums;

namespace AbstractClassExampleExercise.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
