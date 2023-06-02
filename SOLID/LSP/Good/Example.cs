namespace SOLID.LSP.Good
{
	public abstract class Shape
	{
		public abstract double CalculateArea();

		public double CalculateTotalArea(List<Shape> shapes)
		{
			double totalArea = 0;

			foreach (Shape shape in shapes)
			{
				totalArea += shape.CalculateArea();
			}

			return totalArea;
		}
	}

	public class Circle : Shape
	{
		public double Radius { get; set; }

		public override double CalculateArea()
		{
			return Math.PI * Radius * Radius;
		}
	}

	public class Rectangle : Shape
	{
		public double Width { get; set; }
		public double Height { get; set; }

		public override double CalculateArea()
		{
			return Width * Height;
		}
	}

	public class Triangle : Shape
	{
		public double Base { get; set; }
		public double Height { get; set; }

		public override double CalculateArea()
		{
			return (Base * Height) / 2;
		}
	}
}
