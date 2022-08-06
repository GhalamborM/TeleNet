using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleNet.Models.TL;

namespace TeleNet.Models.TL133.Channels
{
    [TLObject(-1763259007)]
    public class TLRequestEditBanned : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -1763259007;
            }
        }

        public TLAbsInputChannel Channel { get; set; }
        public TLAbsInputPeer Participant { get; set; }
        public TLAbsChatBannedRights BannedRights { get; set; }
        public TLAbsUpdates Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Channel = (TLAbsInputChannel)ObjectUtils.DeserializeObject(br);
            Participant = (TLAbsInputPeer)ObjectUtils.DeserializeObject(br);
            BannedRights = (TLAbsChatBannedRights)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Channel, bw);
            ObjectUtils.SerializeObject(Participant, bw);
            ObjectUtils.SerializeObject(BannedRights, bw);

        }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TLAbsUpdates)ObjectUtils.DeserializeObject(br);

        }
    }
}
