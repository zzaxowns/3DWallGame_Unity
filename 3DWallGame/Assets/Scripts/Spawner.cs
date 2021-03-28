﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject wallPrefab;
    public float interval;
    public float range = 3.0f;

    // Start is called before the first frame update
    IEnumerator Start()
    { // yield을 사용하기 위해 IEnumerator type으로 return
        while (true)
        {
            transform.position = new Vector3(transform.position.x, Random.Range(-range, range), transform.position.z);

            Instantiate(wallPrefab, transform.position, transform.rotation);
            // 컬렉션 데이터를 하나씩 return 후 다음 실행 위치 기억 (Unity의 coroutine 참조)
            yield return new WaitForSeconds(interval);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
