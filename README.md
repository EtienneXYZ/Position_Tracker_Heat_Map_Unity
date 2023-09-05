# Position_Tracker_Heat_Map_Unity
This is a tutorial for Unity to create an psoition tracker to then use  it for a heatmap.


**Step 1: 
**
![Screenshot 2023-09-05 172209](https://github.com/EtienneXYZ/Position_Tracker_Heat_Map_Unity/assets/115432494/c0733987-eee5-407b-b0dc-71842b193014)
Attach the PlayerTracker script to your player's VR camera or controller.  This script will log the player's position, rotation, and room design number every second and store it in a CSV file in the "Assets" folder of your project. Note: You do not need  do not set any RoomDesignNumber level the " 0".
Add a capsule collider
Add a Rigidbody: "use gravity "and "Is kinematic" must be checked




**Step 2: 
**
![Screenshot 2023-09-05 172613](https://github.com/EtienneXYZ/Position_Tracker_Heat_Map_Unity/assets/115432494/970e8a1e-29d4-4e49-bf82-05e30d322057)

Attach the RoomTrigger script to an empty object, call it for example "RoomTrigger1", don't forget to put the room design as "1" in the inspector. Add a box collider and "is trigger" must be selected.
Scale the empty object to the size of your space exploration.


**Step 3: 
**

![Screenshot 2023-09-05 172850](https://github.com/EtienneXYZ/Position_Tracker_Heat_Map_Unity/assets/115432494/6fb7695f-cbb6-4fee-950c-1b04393efb44)

Repeat the previous procedure for the next design variations:  "RoomTrigger2", "RoomTrigger3"



**Nota:
**
If we want to do this for several floors the then need to create another empty for RoomTriggerFloor1" and rename our previous one "RoomTriggerfloor0"

In case you are having difficulties: check that the tag  is corresponding to the one called in the script "RoomTrigger",  here layer is set to Main camera, as our default tag is   "main camera" and it works.


**Step 4: 
**
Player data file is just an example of the output you get with thanks to the player tracker c# script


Thanks for reading this tutorial


