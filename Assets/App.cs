using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class App : MonoBehaviour {
    public GameObject Camera;
    private Transform _cameraTransform;
    private float _relativeDistance;
    public GameObject Factory;
    public List<GameObject> _factories;

	void Start () {
        _cameraTransform = Camera.transform;
	}
	
	void Update () {
        MoveCamera();
	}


    private void MoveCamera(){
        var speed = .1f;

        _relativeDistance += speed;
        
		_cameraTransform.position= new Vector3 (0,5,_cameraTransform.position.z+ speed);

        if (_relativeDistance>5){
            _relativeDistance = 0;
            CreateBuildings();
        }
    }

    private void CreateBuildings(){
        var go = Instantiate(Factory);
        go.transform.Rotate(new Vector3(0,25,0));
        go.transform.position = new Vector3(0, 0, _cameraTransform.position.z+30);

        _factories.Add(go);

       DestroyFactories();
    }

    private void DestroyFactories(){

        var toDestroy = _factories.Where(x => Vector3.Distance(x.transform.position, _cameraTransform.transform.position) > 31).ToList();

        foreach (var item in toDestroy)
        {
          
                Destroy(item);
				_factories.Remove(item);

        }
    }
}
