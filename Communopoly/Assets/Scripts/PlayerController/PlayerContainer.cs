using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerContainer : MonoBehaviour
{
    public List<GameObject> Instances;
    public GameObject TemplateContainer;
    public GameObject InstanceContainer;
    public GameObject WaypointContainer;

    GameObject[] PlayerTemplates;
    Transform[] Waypoints;

    // Start is called before the first frame update
    public void Start()
    {
        PlayerTemplates = TemplateContainer.GetComponentsInChildren<Transform>(TemplateContainer).Select(t => { return t.gameObject; }).ToArray();

        List<Transform> Waypoints = WaypointContainer.GetComponentsInChildren<Transform>().ToList();
        Waypoints.RemoveAt(0);
        this.Waypoints = Waypoints.ToArray();
        CreatePlayer("a name");
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instances.First().GetComponent<PlayerInstanceController>().addSpace(1);
            Debug.Log($"moved to {Instances.First().GetComponent<PlayerInstanceController>().transform.position}");
        }
    }
    public void CreatePlayer(string Name)
    {
        GameObject newInstance = Instantiate(PlayerTemplates[1], InstanceContainer.transform);
        newInstance.GetComponent<PlayerInstanceController>().Instantiate(Waypoints,Name,0);

        Instances.Add(newInstance);
    }
}