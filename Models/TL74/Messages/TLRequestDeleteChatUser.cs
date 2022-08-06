using System.IO;

namespace TeleNet.Models.TL.Messages
{
    [TLObject(-530505962)]
    public class TLRequestDeleteChatUser : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -530505962;
            }
        }

        public int ChatId { get; set; }
        public TLAbsInputUser UserId { get; set; }
        public TLAbsUpdates Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            ChatId = br.ReadInt32();
            UserId = (TLAbsInputUser)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(ChatId);
            ObjectUtils.SerializeObject(UserId, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TLAbsUpdates)ObjectUtils.DeserializeObject(br);

        }
    }
}
