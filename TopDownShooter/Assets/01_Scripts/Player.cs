using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1f;
    float x;
    float z;

    public Bullet bulletPrefab;
    public Transform firePosition;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        transform.position += new Vector3(x, 0, z) * speed * Time.deltaTime;
        if (Input.GetMouseButtonDown(0)) //0은 왼쪽 버튼을 눌렀을때라는 조건이 됨
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePosition.position, transform.rotation);
    }
}
