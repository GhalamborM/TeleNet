using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleNet.Models.TL;

namespace TeleNet.Models.TL123
{
	[TLObject(-659913713)]
    public class TLInputGroupCall : TLObject
    {
        public override int Constructor
        {
            get
            {
                return -659913713;
            }
        }

             public long Id {get;set;}
     public long AccessHash {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Id = br.ReadInt64();
AccessHash = br.ReadInt64();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(Id);
bw.Write(AccessHash);

        }
    }
}
