using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MonoBehaviour
{
    [SerializeField]
    private List<Vector3> pointsToGo;

    [SerializeField]
    private float speed = 2f;

    private Vector3 worldMousePos;
    private LineRenderer ln;

    private void Start()
    {
        ln = GetComponent<LineRenderer>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePos = Input.mousePosition;
            worldMousePos = Camera.main.ScreenToWorldPoint(mousePos);
            pointsToGo.Add(new Vector3(worldMousePos.x,worldMousePos.y,0));
        }

        ln.positionCount = pointsToGo.Count + 1;

        for (int i = 0; i < pointsToGo.Count; i++)
        {
            ln.SetPosition(i + 1, pointsToGo[i]);
        }

        ln.SetPosition(0, transform.position);

        if (pointsToGo.Count > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointsToGo[0], speed * Time.deltaTime);
            if(Vector3.Distance(transform.position, pointsToGo[0])<0.1f)
            {
                pointsToGo.RemoveAt(0);
            }
        }
    }
}
