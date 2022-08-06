using System.IO;

namespace TeleNet.Models.TL
{
    [TLObject(332848423)]
    public class TLEncryptedChatDiscarded : TLAbsEncryptedChat
    {
        public override int Constructor
        {
            get
            {
                return 332848423;
            }
        }

        public int Id { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Id = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Id);

        }
    }
}