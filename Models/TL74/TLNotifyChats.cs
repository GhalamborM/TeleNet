using System.IO;

namespace TeleNet.Models.TL
{
    [TLObject(-1073230141)]
    public class TLNotifyChats : TLAbsNotifyPeer
    {
        public override int Constructor
        {
            get
            {
                return -1073230141;
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