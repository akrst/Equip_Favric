#if PLAYMAKER

using UnityEngine;

namespace HutongGames.PlayMaker.Actions.STYLY
{
        [ActionCategory("MeshFilter")]
        public class SetMeshTopologyAction : FsmStateAction
        {
                [RequiredField]
                public FsmOwnerDefault gameObject;
                [RequiredField]
                MeshFilter meshFilter;
                [RequiredField]
                [UIHint(UIHint.Variable)]
                public MeshTopology topology;
                // Code that runs on entering the state.
                public override void OnEnter()
                {   
                        GameObject go = Fsm.GetOwnerDefaultTarget(gameObject);
                        meshFilter = go.GetComponent<MeshFilter>();
                        meshFilter.mesh.SetIndices(meshFilter.mesh.GetIndices(0), topology, 0);
                        Finish();
                }
        }
}
#endif