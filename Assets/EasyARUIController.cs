using Common;
using easyar;
using UnityEngine;

namespace MotionTracking
{
    public class EasyARUIController : MonoBehaviour
    {
        public ARSession Session;
        public TouchController TouchControl;
        private VIOCameraDeviceUnion vioCamera;

        private void Awake()
        {
            vioCamera = Session.GetComponentInChildren<VIOCameraDeviceUnion>();
            TouchControl.TurnOn(TouchControl.gameObject.transform, Camera.main, true, true, true, true);
        }
    }
}
