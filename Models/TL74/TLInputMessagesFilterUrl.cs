using System.IO;

namespace TeleNet.Models.TL
{
    [TLObject(2129714567)]
    public class TLInputMessagesFilterUrl : TLAbsMessagesFilter
    {
        public override int Constructor
        {
            get
            {
                return 2129714567;
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
