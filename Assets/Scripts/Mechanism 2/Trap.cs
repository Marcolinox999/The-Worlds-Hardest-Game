using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private float speed =3;

    [SerializeField] private Vector3 initDirection;
    [SerializeField] private float travelTime = 2;
    private Vector3 currentDirection;

    [SerializeField] float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentDirection = initDirection;
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer
        timer += Time.deltaTime;
        //if time exceeds travelTime
        if (timer >= travelTime)
        {
            //then we change direction to the opposite
            currentDirection *= -1;
            timer = 0;
        }
        //we are all the time moving depending on the currentDirection
        transform.Translate(currentDirection * speed * Time.deltaTime);
    }
}
