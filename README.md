# unity_Spot

Installation Instructions: Ubuntu 20.04 with ROS Noetic
-----

Installing Unity
-----
> STEP 1:
Install latest Unity engine version: https://unity.com/
-----
> STEP 2:
Download and unzip repository in the Unity Projects Folder under desired folder name
-----
> Step 3: 
Run Unity Hub and select project folder
-----

Installing Spot Kinematics and controllers
-----
Download, compile and source the following packages in your catkin workspace

> Step 1: Clone git clone https://github.com/Unity-Technologies/ROS-TCP-Endpoint.git
-----
> Step 2: Clone git clone -b spot_control https://github.com/SoftServeSAG/spot_simulation.git
-----
> Step 3: Clone git clone https://github.com/SoftServeSAG/teleop_legged_robots.git
-----

Running the simulation
-----

> Step 1: Export ROS IP parameters using the following: 
-----
>> export ROS_MASTER_URI=http://(IP Address):11311
-----
>> export ROS_IP=(IP Address)
-----  
> Step 2: Running the controller and spot kinematics:
-----
>> roslaunch rs_inverse inverse.launch robot_name:="spot1"
-----
>> roslaunch rs_base quadruped_controller.launch 
-----
> Step 3: Running the Teleop node
-----
>> roslaunch teleop_legged_robots teleop.launch robot_name:="spot1"
-----             

NOTE
-----
> If the export ROS_XX commands are not run, messages would not be passed between Unity and ROS.
-----
> If running endpoint.launch terminates in a error of "port alerady used", simply change the port, export ROS_XX again and restart your terminal. 
-----
> In Unity, on the top bar, Robotics > ROS Settings > ROS IP Address and ROS Port should be the same as the ROS_MASTER_URI as well as in 
the endpoint.launch file (tcp_ip and tcp_port)
