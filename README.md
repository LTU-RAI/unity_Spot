# unity_Spot

## Installation Instructions: Ubuntu 20.04 with ROS Noetic.

## Installing Unity

1. Install latest Unity engine version: https://unity.com/

2. Download and unzip repository in the Unity Projects Folder under desired folder name.

3. Run Unity Hub and select project folder.

## Installing Spot Kinematics and controllers.

Download, compile and source the following packages in your catkin workspace.

1. ```git clone https://github.com/Unity-Technologies/ROS-TCP-Endpoint.git```

2. Clone the ```spot_simulation``` branch of this repository to control Spot. <br>
 ```git clone -b spot_simulation https://github.com/LTU-RAI/unity_Spot.git```

3. ```git clone https://github.com/SoftServeSAG/teleop_legged_robots.git```

## Running the simulation

1. Export ROS IP parameters using the following: <br>
    ``` 
    export ROS_MASTER_URI=http://(IP Address):11311
    export ROS_IP=(IP Address)
    ```
2. Running the connection between ROS and Unity: <br>
 ``` roslaunch ros_tcp_endpoint endpoint.launch ```
3. Running the controller and spot kinematics: <br>
     ``` 
     roslaunch rs_inverse inverse.launch robot_name:="spot1"
     roslaunch rs_base quadruped_controller.launch mode:="walking"
     ```

- Note: change to ```mode:="stairs"``` for stair climbing parameters:
    ```roslaunch rs_base quadruped_controller.launch mode:="stairs"```

4. Running the Teleop node:
    ```roslaunch teleop_legged_robots teleop.launch robot_name:="spot1"```
             
5. To launch sensors: <br>
    Follow instructions listed in https://github.com/Field-Robotics-Japan/UnitySensorsROSAssets

## Notes

- If the ```export ROS_XX``` commands are not run, messages would not be passed between Unity and ROS.

- If running ```ros_tcp_endpoitn endpoint.launch``` terminates in an error of ```port alerady used```, simply change the port, ```export ROS_XX``` again and restart your terminal. 

- In Unity, on the top bar, ```Robotics > ROS Settings > ROS IP Address``` and ```ROS Port``` should be the same as the ```ROS_MASTER_URI``` as well as in 
the ```endpoint.launch``` file (tcp_ip and tcp_port)

- In event of ```No module found```, please check and update the shebang in the corresponding python file to ```python3```
