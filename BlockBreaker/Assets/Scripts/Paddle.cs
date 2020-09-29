using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UIElements;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.mousePosition.x / Screen.width * screenWidthInUnits);

        float mousePos = Input.mousePosition.x / Screen.width * screenWidthInUnits;

        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);

        paddlePos.x = Mathf.Clamp(mousePos, minX, maxX);

        this.transform.position = paddlePos;
    }
}
