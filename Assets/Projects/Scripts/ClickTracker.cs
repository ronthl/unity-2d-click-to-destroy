using UnityEngine;

public class ClickTracker : MonoBehaviour
{

    [SerializeField]
    private new Camera camera;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(camera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform is not null)
            {
                print(hit.transform.gameObject.name + " has been destroyed!");
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
