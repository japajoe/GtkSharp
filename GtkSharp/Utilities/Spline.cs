using System.Collections.Generic;

namespace GtkSharp.Utilities
{
    public class Spline
    {
        public Vector2[] controlPoints = new Vector2[4];
        public List<Vector2> points = new List<Vector2>();

        public Spline(int numPoints)
        {
            for(int i = 0; i < controlPoints.Length; i++)
                controlPoints[i] = Vector2.zero;

            for(int i = 0; i < numPoints; i++)
                points.Add(new Vector2());
        }

        public void Generate()
        {
            float t = 1.0f / (points.Count - 1);

            for(int i = 0; i < points.Count; i++)
            {
                points[i] = Mathf.GetBezierPoint(controlPoints[0], controlPoints[1], controlPoints[2], controlPoints[3], t * i);
            }
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