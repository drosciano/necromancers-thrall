using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float damage;
    Vector3 lastPosition;

    RaycastHit[] hit;

    public GameObject particleHit;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1f);
        hit = new RaycastHit[1];
    }

    // Update is called once per frame
    void Update()
    {
        lastPosition = transform.position;
        transform.position += transform.forward * speed * Time.deltaTime;
        checkHit();
    }

    void checkHit()
    {
        Ray ray = new Ray(lastPosition, transform.forward);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        RaycastHit rayhit;
        float dist = Vector3.Distance(lastPosition, transform.forward);
        if (Physics.RaycastNonAlloc(ray, hit, dist) > 0)
        {
            Instantiate(particleHit, hit[0].point, Quaternion.LookRotation(hit[0].normal));
            if (Physics.Raycast(transform.position, forward, out rayhit))
            {
                if (rayhit.collider.tag == "Enemy")
                {
                    Debug.Log("Hit " + rayhit.collider.gameObject.name);
                    rayhit.collider.gameObject.GetComponent<EnemyHealth>().AdjustCurrentHealth(-damage);
                }
                if (rayhit.collider.tag == "Target")
                {
                    Debug.Log("Hit " + rayhit.collider.gameObject.name + " Target");

                    string target = rayhit.collider.gameObject.name;

                    BarnTrigger.CheckTargetHit(target);
                }
            }
            Destroy(gameObject);
        }
    }

}
