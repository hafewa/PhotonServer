﻿using UnityEngine;
using System.Collections;


namespace Net
{
    public abstract class HandlerBase : MonoBehaviour
    {


        public virtual void Awake()
        {
            AddListener();
        }


        public virtual void OnDestroy()
        {
            RemoveListener();
        }

        public abstract void AddListener();

        public abstract void RemoveListener();
    }
}

