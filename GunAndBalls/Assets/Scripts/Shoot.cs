using UnityEngine;

public class Shoot : MonoBehaviour {

    public int shootCount;
    public GameObject gun;
    public GameObject bullefPrefab;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && shootCount != 0)
        {
            shootCount--;
            ShootAction();
        }

        if (shootCount == 0)
        {
            Destroy(gun);
        }
    }

    void ShootAction()
    {
        var bullet = (GameObject)Instantiate(bullefPrefab, transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 30;
    }
}
