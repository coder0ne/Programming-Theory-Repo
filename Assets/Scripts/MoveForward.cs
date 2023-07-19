using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MovementBehavior
{
	[SerializeField] // ENCAPSULATION
    private float speed = 10.0f;
    
    public override void Move(Transform transform) // POLYMORPHISM
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

/*
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
*/
}
