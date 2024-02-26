using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleObjectPool
{
    public class PoolItem : MonoBehaviour
    {
        public Action OnReturnToPool;

        public virtual void ToPool()
        {
            gameObject.SetActive(false);
            OnReturnToPool?.Invoke();
        }

        public virtual void FromPool(Vector3 position)
        {
            gameObject.SetActive(true);
            gameObject.transform.position = position;
        }
    }
}
