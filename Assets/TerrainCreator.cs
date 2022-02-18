using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class TerrainCreator : MonoBehaviour
{
    public SpriteShapeController shape;
    public int scale = 1000000000;
    public int numofPoints = 1000;


    private void Start()
    {
        shape = GetComponent<SpriteShapeController>();
        float distanceBwtnpoints = (float)scale / (float)numofPoints;
        shape.spline.SetPosition(2, shape.spline.GetPosition(2) + Vector3.right * 300);
        shape.spline.SetPosition(3, shape.spline.GetPosition(3) + Vector3.right * 300);

        for (int i = 0; i < 300; i++)
        {
            float xPos = shape.spline.GetPosition(i + 1).x + distanceBwtnpoints;
            shape.spline.InsertPointAt(i + 2, new Vector3(xPos, 25*Mathf.PerlinNoise(i* Random.Range(15.0f, 25.0f), 0)));
        }

        for (int i = 2; i < 300; i++)
        {
            shape.spline.SetTangentMode(i,ShapeTangentMode.Continuous);
            shape.spline.SetLeftTangent(i, new Vector3(-2, 0, 0));
            shape.spline.SetRightTangent(i, new Vector3(2, 0, 0));
        }

    }
}
