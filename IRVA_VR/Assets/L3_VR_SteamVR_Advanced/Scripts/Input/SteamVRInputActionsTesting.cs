using UnityEngine;
using Valve.VR;

namespace L3_VR_SteamVR_Advanced.Scripts.Input
{
    public class SteamVRInputActionsTesting : MonoBehaviour
    {
        // TODO 1 : Setup input for the already-defined `GrabPinch` action.
        //          Write a message in the console which signifies this input is correctly read.
        //          Use either the polling method or an event-based mechanism.

        //private void Update()
        //{
        //    // Explanation:
        //    //  - From the `_default` mapping (action set), get the `GrabPinch` action's state via `GetState`.
        //    //  - `SteamVR_Input_Sources` can be used to set a specific device to read from. In this case any device which has this action.
        //    var grabPinchState = SteamVR_Actions._default.GrabPinch.GetState(SteamVR_Input_Sources.Any);
        //    Debug.Log($"[SteamVRInputActionsTesting] Polling: grabPinchState = {grabPinchState}");
        //}

        // Subscribe to event `onChange` from the `GrabPinch` contained in the `_default` action set
        // and call `OnGrabPinchChanged` on invocations.
        private void OnEnable()
        {
            SteamVR_Actions._default.GrabPinch.onChange += OnGrabPinchChanged;
            SteamVR_Actions._default.GrabGrip.onChange += OnGrabGripChanged;
            SteamVR_Actions._default.TouchTrigger.onChange += OnTouchedTrigger;
        }
        // Unsubscribe from event.
        private void OnDisable() {
            SteamVR_Actions._default.GrabPinch.onChange -= OnGrabPinchChanged;
            SteamVR_Actions._default.GrabGrip.onChange -= OnGrabGripChanged;
            SteamVR_Actions._default.TouchTrigger.onChange -= OnTouchedTrigger;
        }

        // Method called when `onChange` from the `GrabPinch` is invoked.
        private void OnGrabPinchChanged(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource, bool grabPinchState)
        {
            Debug.Log($"[SteamVRInputActionsTesting] Events: grabPinchState = {grabPinchState}");
        }
        private void OnGrabGripChanged(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource, bool grabGripState)
        {
            Debug.Log($"[SteamVRInputActionsTesting] Events: grabGripState = {grabGripState}");
        }

        // TODO 2 : Setup input for the `TouchTrigger` action (you'll have to first create it & bind it accordingly)
        //          Write a message in the console which signifies this input is correctly read.
        //          Use either the polling method or an event-based mechanism.
        private void OnTouchedTrigger(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource, bool touchedTriggereState)
        {
            Debug.Log($"[SteamVRInputActionsTesting] Events: touchedTriggereState = {touchedTriggereState}");
        }
    }
}