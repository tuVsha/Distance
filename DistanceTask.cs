using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
            var A = Math.Abs(ay - by);
            var B = Math.Abs(bx - ax);
            if (A + B != 0) return (Math.Abs(A * x + B * y + ax * by - bx * ay)) / Math.Sqrt(A * A + B * B);
            else return x * x + y * y;
		}
	}
}