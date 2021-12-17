using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_stable : MonoBehaviour
{
    public GameObject TheCar;
    public float Car_y;
    public float Car_x;
    public float Car_z;
    
    void Update()
    {
        Car_x = TheCar.transform.eulerAngles.x;
        Car_y = TheCar.transform.eulerAngles.y;
        Car_z = TheCar.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(Car_x - Car_x, Car_y, Car_z - Car_z);
        
    }
}
