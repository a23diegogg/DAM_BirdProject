using UnityEngine;

public class Pipes : MonoBehaviour
{
    public Transform top;
    public Transform bottom;
    public float speed = 5f;
    [SerializeField] private GameObject lowButton;
    [SerializeField] private GameObject midButton;
    [SerializeField] private GameObject fastButton;


    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;

        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }

    public void SetLowSpeed()
    {
        speed = 5f;
    }

    public void SetMidSpeed() 
    {
        speed = 10f;
    }

    public void SetFastSpeed()
    {
        speed = 15f;
    }


}
