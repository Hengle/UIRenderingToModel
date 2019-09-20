using UnityEngine;

public class ObjRotate : MonoBehaviour
{
    public float Speed = -2;
    private void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, Speed);
    }
}
