using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyObjSerial
{
    [Serializable()]    //Set this attribute to all the classes that want to serialize
    public class Employee : ISerializable //derive your class from ISerializable
    {
        public int EmpId;
        public string EmpName;

        //Default constructor
        public Employee()
        {
            EmpId = 0;
            EmpName = null;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}