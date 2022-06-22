using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(
    fileName = "DataView",
    menuName = "ScriptableObjects/ViewScriptableObject",
    order = 1)]
class DataView : ScriptableObject
{
    [SerializeField] private GameObject _prefabView;

    public GameObject PrefabView => _prefabView;
}
