using UnityEngine;

public class gameManager : MonoBehaviour
{
    Pokemon Bulbasaur;
    Pokemon Charmander;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     Bulbasaur = new Pokemon();
     Charmander = new Pokemon();
    }

    // Update is called once per frame
    void Update()
    {
        Pokemon name = new Pokemon();
        if (Input.GetMouseButton(0)) 
        {
            Charmander.name="Charmander";
            Charmander.Talk();
        }
        if (Input.GetMouseButton(1)) 
        {
            Bulbasaur.name="Bulbasur";
            Bulbasaur.Talk();
        }
    }
}
