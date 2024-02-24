using System.Collections.Generic;
using UnityEngine;

namespace GI.UnityToolkit.Attributes.Test
{
    //[CreateAssetMenu(fileName = "NaughtyScriptableObject", menuName = "NaughtyAttributes/_NaughtyScriptableObject")]
    public class _NaughtyScriptableObject : ScriptableObject
    {
        [Expandable]
        public List<_TestScriptableObjectA> listA;
    }
}
