using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HelloServer
{
    [DataContract]
    public class TripleOfInt
    {
        //*WIP OnOnDeserializing i stedet for constructors

        //public TripleOfInt(int i, int y, int x)
        //{
        //    this.Initialize(i,y,x);
        //}

        //private void Initialize(int i, int y, int x)
        //{
        //    this.I1 = i;
        //    this.I2 = y;
        //    this.I3 = x;
        //}

        [DataMember]
        public int I1 { get; set; }
        [DataMember]
        public int I2 { get; set; }
        [DataMember]
        public int I3 { get; set; }

        //[OnDeserializing]
        //public void OnDeserializing(StreamingContext context)
        //{
        //    this.Initialize(I1,I2,I3);
        //}
    }
}
