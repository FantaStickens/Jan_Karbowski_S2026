using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zbiór : MonoBehaviour
{
    public List<GameObject> obiekty = new List<GameObject>();
    public Gradient gr;
    public int devide;
    public float angle;

    void Start()
    {

    }




    void Update()
    {

        SortObj();

    }


    void SortObj()
    {
        foreach (GameObject go in obiekty)
        {
            if (go.GetComponent<SpriteRenderer>() != null)
            {
                Sprite(go.GetComponent<SpriteRenderer>());
            }
            else if (go.GetComponent<MeshRenderer>() != null)
            {
                Cube(go.transform);
            }
        }
    }
    void Sprite(SpriteRenderer sprite)
    {
        sprite.color = gr.Evaluate(sprite.gameObject.transform.position.y / devide);

    }

    void Cube(Transform tran)
    {
        tran.Rotate(angle, 0, 0);
        tran.position = new Vector3(0, tran.position.y + 1 * Time.deltaTime, tran.position.z);
    }
    

}