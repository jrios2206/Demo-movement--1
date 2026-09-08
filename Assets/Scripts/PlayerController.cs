using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour

{
    public float StepDistance = 1f;

    public float Speed = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) == true)
        {
            transform.position += new Vector3(-1, 0, 1) * Time.deltaTime * Speed;
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.position += new Vector3(1, 0, 1) * Time.deltaTime * Speed;
        }
    }
}
