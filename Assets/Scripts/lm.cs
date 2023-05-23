using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lm : MonoBehaviour
{
    [SerializeField] GameObject k;
    public float r;
    
    
    // Start is called before the first frame update
    void Start()
    {
        sp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void sp()
    {
        float r = k.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        Vector2 lk = Camera.main.ScreenToWorldPoint(new Vector2(0,0));

        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                
                Instantiate(k, new Vector2(lk.x + r*x,lk.x+r*y) , Quaternion.identity);
            }
        }
    }
}
