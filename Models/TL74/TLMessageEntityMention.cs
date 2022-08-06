using System.IO;

namespace TeleNet.Models.TL
{
	[TLObject(-100378723)]
    public class TLMessageEntityMention : TLAbsMessageEntity
    {
        public override int Constructor
        {
            get
            {
                return -100378723;
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
