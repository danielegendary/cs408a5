using System;
using UnityEngine;

namespace FluxySamples
{
    public class MoveAndRotate : MonoBehaviour
    {
        public Vector3andSpace moveUnitsPerSecond;//declare value to store the unit move variable
        public Vector3andSpace rotateDegreesPerSecond;//declare value to store unit rotation variable
        public Vector3andSpace DensityWeight;
        public bool ignoreTimescale;
        private float m_LastRealTime;

        private void Start()
        {
            m_LastRealTime = Time.realtimeSinceStartup;
        }

		// Update is called once per frame
        private void Update()
        {
            float deltaTime = Time.deltaTime;//set timer
            if (ignoreTimescale)
            {
                deltaTime = (Time.realtimeSinceStartup - m_LastRealTime);
                m_LastRealTime = Time.realtimeSinceStartup;
            }
            transform.Translate(moveUnitsPerSecond.value*deltaTime, moveUnitsPerSecond.space);//change unit position with time
            transform.Rotate(rotateDegreesPerSecond.value*deltaTime, rotateDegreesPerSecond.space);//change unit rotation value with time
        }


        [Serializable]
        public class Vector3andSpace
        {
            public Vector3 value;
            public Space space = Space.Self;
        }
    }
}
