using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Spawnable {

    void loadResources(string folder);

    void calculateWeights();

    void spawn( Vector3 position, Quaternion rotation);

}
