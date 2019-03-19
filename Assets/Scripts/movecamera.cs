using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : MonoBehaviour
{
    public GameObject mainCamera;
    public Camera camera;
    public float leftBound;
    public float rightBound;
    public float upBound;
    public float downBound;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
        camera = mainCamera.GetComponent<Camera>();
        leftBound = -20.5f;
        rightBound = 29.6f;
        upBound = 3.8f;
        downBound = -15.2f;

}

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.RightArrow)
                && camera.gameObject.transform.position.x <= rightBound)
            {
                transform.Translate(new Vector3(3 * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey(KeyCode.LeftArrow)
                && camera.gameObject.transform.position.x >= leftBound)
            {
                transform.Translate(new Vector3(-3 * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey(KeyCode.DownArrow)
                && camera.gameObject.transform.position.y >= downBound)
            {
                transform.Translate(new Vector3(0, -3 * Time.deltaTime, 0));
            }
            if (Input.GetKey(KeyCode.UpArrow)
                && camera.gameObject.transform.position.y <= upBound)
            {
                transform.Translate(new Vector3(0, 3 * Time.deltaTime, 0));
            }
        }
    }
}
