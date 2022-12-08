using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class LakeOfMagicController : MonoBehaviour
{
    public GameObject lakeParticle;
    public int initialWait;
    public float effectTimer = 2f;

    private float randX;
    private float randZ;
    private bool IsPlayingEffect = false;

    // Start is called before the first frame update
    void Start()
    {
        initialWait = Random.Range(3, 8);
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsPlayingEffect)
        {
            IsPlayingEffect = true;
            randX = Random.Range(-37f, 37f);
            randZ = Random.Range(-60f, 50f);
            Instantiate(lakeParticle, new Vector3(transform.position.x + randX, 5, transform.position.z + randZ), transform.rotation);
            StartCoroutine(EffectTimer());
        }
    }

    IEnumerator EffectTimer()
    {
        yield return new WaitForSeconds(effectTimer);
        IsPlayingEffect = false;
    }
}
