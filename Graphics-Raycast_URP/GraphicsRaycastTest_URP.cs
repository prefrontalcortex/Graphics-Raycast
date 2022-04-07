using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GraphicsRaycastTest_URP : MonoBehaviour
{
    public float maxDistance = 100f;
    public bool hitSomething;

    private RaycastHit hit;

    void Update()
    {
        hitSomething = GraphicsRaycast_URP.Raycast(this.transform.position, this.transform.forward, out hit, maxDistance);
    }

    private void OnDrawGizmos()
    {
#if UNITY_EDITOR
        GraphicsRaycast_URP.DrawGizmo(hitSomething, this.transform.position, this.transform.forward, hit, maxDistance, 1f);
#endif
    }
}
