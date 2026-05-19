using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float zMax;
    public float speed;
    public float zMin;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(transform.eulerAngles);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = currentRotation;

       

        if (currentRotation.z > zMax)
        {
            Debug.Log("Crossing the upper threshold currentZ["+currentRotation.z.ToString()+"] zMax["+zMax.ToString()+"]");
            speed = -speed;
        }

        if (currentRotation.z < zMin)
        {
            Debug.Log("Crossing the lower threshold currentZ["+currentRotation.z.ToString()+"] zMax["+zMax.ToString()+"]");
            speed = -speed;
        
        }
    }
}
