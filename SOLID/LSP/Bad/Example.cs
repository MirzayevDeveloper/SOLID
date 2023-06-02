namespace SOLID.LSP.Bad
{
	public class Shape
	{
		public double CalculateTotalArea(List<Shape> shapes)
		{
			double totalArea = 0;

			foreach (Shape shape in shapes)
			{
				if (shape is Circle)
				{
					Circle circle = (Circle)shape;
					totalArea += circle.CalculateArea();
				}
				else if (shape is Rectangle)
				{
					Rectangle rectangle = (Rectangle)shape;
					totalArea += rectangle.CalculateArea();
				}
				else if (shape is Triangle)
				{
					Triangle triangle = (Triangle)shape;
					totalArea += triangle.CalculateArea();
				}
			}

			return totalArea;
		}
	}

	public class Circle : Shape
	{
		public double Radius { get; set; }

		public double CalculateArea()
		{
			return Math.PI * Radius * Radius;
		}
	}

	public class Rectangle : Shape
	{
		public double Width { get; set; }
		public double Height { get; set; }

		public double CalculateArea()
		{
			return Width * Height;
		}
	}

	public class Triangle : Shape
	{
		public double Base { get; set; }
		public double Height { get; set; }

		public double CalculateArea()
		{
			return (Base * Height) / 2;
		}
	}
}
