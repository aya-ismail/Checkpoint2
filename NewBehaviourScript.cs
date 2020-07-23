using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float a, b;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Som(a, b));
        Debug.Log(Prod(a, b));
        if (b != 0)
        {
            Debug.Log(Div(a, b));

        }
        else Debug.Log("divide by zero ERROR");
    }

    // Update is called once per frame
    void Update()
    {

    }
    float Som(float a, float b) { return (a + b); }
    float Prod(float a, float b) { return (a * b); }

    float Div(float a, float b){ return (a/b) ; } //float Div(float a, float b) {  if (b != 0) { return (a/b) ; } } ---> ERREUR de compilation : les chemins de code ne retournent pas tous un valeur



}

