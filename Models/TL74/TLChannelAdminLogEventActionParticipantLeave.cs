using System.IO;

namespace TeleNet.Models.TL
{
	[TLObject(-124291086)]
    public class TLChannelAdminLogEventActionParticipantLeave : TLAbsChannelAdminLogEventAction
    {
        public override int Constructor
        {
            get
            {
                return -124291086;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
