using System.IO;
using TeleNet.Models.TL.Storage;

namespace TeleNet.Models.TL.Storage
{
    [TLObject(-1373745011)]
    public class TLFilePdf : TLAbsFileType
    {
        public override int Constructor
        {
            get
            {
                return -1373745011;
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
