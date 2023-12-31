using UnityEngine;
[RequireComponent(typeof(MoveCar))]
public class Acceleration : MonoBehaviour
{
    public GameObject exhaust;
    private bool accelerate = false;

     void OnMouseDown()
    {
        if (!accelerate)
        {
            GetComponent<MoveCar>().speed *= 2f;
            accelerate = true;

            GameObject ex = Instantiate(exhaust,
                new Vector3 (gameObject.transform.position.x, 0.2f, gameObject.transform.position.z),Quaternion.Euler (new Vector3(90, 0, 0))) as GameObject;
            Destroy(ex, 1f);
        }
    }
}
