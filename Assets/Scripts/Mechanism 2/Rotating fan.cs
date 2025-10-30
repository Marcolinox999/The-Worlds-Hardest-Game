using UnityEngine;

public class Rotatingfan : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float hInput = Input.GetAxis("Horizontal");
        //float vInput = Input.GetAxis("Vertical");
        
        //this.gameObject.transform.Rotate(vInput, hInput, 0);
        this.gameObject.transform.eulerAngles += new Vector3(0, 0, -30)* Time.deltaTime;
        
    }
}
