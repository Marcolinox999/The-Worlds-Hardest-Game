using UnityEngine;

public class DAY1 : MonoBehaviour
{
    [Header("My Stats")]
    [SerializeField] int numberA = 5;
   [SerializeField] string myName = "Marco";
   [SerializeField] char solutionForPuzzle = 'X';
   [SerializeField] float numberWithDecimals = 3.3f;
   [Header("AAA")]
   [SerializeField] bool poisoned = true;
   [SerializeField] int example = 3;
   private int randomNumber;
   private float floatRandomNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomNumber = Random.Range(0, 20); //50
        floatRandomNumber = Random.Range(0.5f, 50.8f);
        Debug.Log(randomNumber);
        Debug.Log(this.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
