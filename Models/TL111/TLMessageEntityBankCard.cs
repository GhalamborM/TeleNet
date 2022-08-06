using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleNet.Models.TL;

namespace  TeleNet.Models.TL111
{
	[TLObject(1981704948)]
    public class TLMessageEntityBankCard : TLAbsMessageEntity
    {
        public override int Constructor
        {
            get
            {
                return 1981704948;
            }
        }

             public int Offset {get;set;}
     public int Length {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Offset = br.ReadInt32();
Length = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(Offset);
bw.Write(Length);

        }
    }
}
