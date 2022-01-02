namespace GtkSharp.Utilities
{
    public class Spline
    {
        public enum BezierType
        {
            Cubic,
            Quadratic
        }

        private Vector2[] controlPoints;
        private Vector2[] points;
        private BezierType type;
        private int numPoints;

        public Vector2[] ControlPoints
        {
            get
            {
                return controlPoints;
            }
            set
            {
                controlPoints = value;
            }
        }

        public Vector2[] Points
        {
            get
            {
                return points;
            }
        }

        public BezierType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                if(type == BezierType.Quadratic)
                {
                    controlPoints = new Vector2[3];
                }
                else
                {
                    controlPoints = new Vector2[4];
                }
            }
        }

        public int NumPoints
        {
            get
            {
                return numPoints;
            }
            set
            {
                numPoints = value;
                points = new Vector2[numPoints];
            }
        }

        public Spline(int numPoints, BezierType type)
        {
            Type = type;
            NumPoints = numPoints;
        }

        public void Generate()
        {
            float t = 1.0f / (points.Length - 1);

            for(int i = 0; i < points.Length; i++)
            {
                if(type == BezierType.Cubic)
                    points[i] = GetBezierPointCubic(controlPoints[0], controlPoints[1], controlPoints[2], controlPoints[3], t * i);
                else
                    points[i] = GetBezierPointQuadratic(controlPoints[0], controlPoints[1], controlPoints[2], t * i);
            }
        }

        public Vector2 GetBezierPointCubic(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, float t)
        {
            return (1 - t)*((1 - t)*(p0 + t*(p1 - p0)) + t*(p1 + t*(p2 - p1))) + t*((1 - t)*(p1 + t*(p2 - p1)) + t*(p2 + t*(p3 - p2)));
        }

        public Vector2 GetBezierPointQuadratic(Vector2 p0, Vector2 p1, Vector2 p2, float t)
        {
            return (1 - t)*(p0 + t*(p1 - p0)) + t*(p1 + t*(p2 - p1));
        }

        public void SetControlPointPosition(int index, Vector2 position)
        {
            if(index >= controlPoints.Length)
                return;
            
            controlPoints[index] = position;
        }

        public bool MouseNearControlPoint(Vector2 mousePosition, float distance, out int index)
        {
            index = 0;

            for(int i = 0; i < controlPoints.Length; i++)
            {
                if(Vector2.Distance(controlPoints[i], mousePosition) <= distance)
                {
                    index = i;
                    return true;
                }
            }

            return false;
        }
    }
}