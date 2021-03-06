//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Spot
{
    [Serializable]
    public class FootStateMsg : Message
    {
        public const string k_RosMessageName = "spot_msgs/FootState";
        public override string RosMessageName => k_RosMessageName;

        //  Contact
        public const byte CONTACT_UNKNOWN = 0;
        public const byte CONTACT_MADE = 1;
        public const byte CONTACT_LOST = 2;
        public Geometry.PointMsg foot_position_rt_body;
        public byte contact;

        public FootStateMsg()
        {
            this.foot_position_rt_body = new Geometry.PointMsg();
            this.contact = 0;
        }

        public FootStateMsg(Geometry.PointMsg foot_position_rt_body, byte contact)
        {
            this.foot_position_rt_body = foot_position_rt_body;
            this.contact = contact;
        }

        public static FootStateMsg Deserialize(MessageDeserializer deserializer) => new FootStateMsg(deserializer);

        private FootStateMsg(MessageDeserializer deserializer)
        {
            this.foot_position_rt_body = Geometry.PointMsg.Deserialize(deserializer);
            deserializer.Read(out this.contact);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.foot_position_rt_body);
            serializer.Write(this.contact);
        }

        public override string ToString()
        {
            return "FootStateMsg: " +
            "\nfoot_position_rt_body: " + foot_position_rt_body.ToString() +
            "\ncontact: " + contact.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
