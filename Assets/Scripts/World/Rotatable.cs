using UnityEngine;

public class Rotatable : MonoBehaviour
{
    [Range(.1f, 100f)]
    public float m_rotateSpeed = .3f;

    void Update()
    {
        this.transform.Rotate(Vector3.up, this.m_rotateSpeed * Time.deltaTime);
    }
}
