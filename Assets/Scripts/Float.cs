using UnityEngine;

public class Float : MonoBehaviour
{
    public float amplitude = 0.01f;

    void Update()
    {
        transform.position += new Vector3(0, amplitude * Mathf.Sin(Time.time),0);
    }
}
