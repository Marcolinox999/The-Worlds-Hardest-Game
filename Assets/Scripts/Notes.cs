using UnityEngine;

public class Notes : MonoBehaviour
{
    private Vector3 initPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 30;
        initPosition = new Vector3(3, 5, 0);
        this.gameObject.transform.position = initPosition;
        Debug.Log(initPosition);
       // this.gameObject.transform.position = new Vector3(9,5,0);
        //this.gameObject.transform.eulerAngles = new Vector3(1,0,0);
       // this.gameObject.transform.localScale = new Vector3(1,1,1);
    }

    // Update is called once per frame
    void Update()
    {
        //time.deltatime = "Per Second"
        //this.gameObject.transform.position += new Vector3(0,0.25f,0)*Time.deltaTime;;
        inputExamples();
    }

    void inputExamples()
    {
        //first time pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("HEY YOU PRESSED ME");
        }
        //hold it pressed
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("STOP IT, IT HURTS");
        }
        //last frame of holding the key
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("THANK YOU");
        }
    }
}
