using System.IO;
using TeleNet.Models.TL;

namespace  TeleNet.Models.TL85
{
	[TLObject(1984755728)]
    public class TLBotInlineMessageMediaAuto : TLAbsBotInlineMessage
    {
        public override int Constructor
        {
            get
            {
                return 1984755728;
            }
        }

             public int Flags {get;set;}
     public string Message {get;set;}
     public TLVector<TLAbsMessageEntity> Entities {get;set;}
     public TLAbsReplyMarkup ReplyMarkup {get;set;}


		public void ComputeFlags()
		{
			Flags = 0;
Flags = Entities != null ? (Flags | 2) : (Flags & ~2);
Flags = ReplyMarkup != null ? (Flags | 4) : (Flags & ~4);

		}

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
Message = StringUtil.Deserialize(br);
if ((Flags & 2) != 0)
Entities = (TLVector<TLAbsMessageEntity>)ObjectUtils.DeserializeVector<TLAbsMessageEntity>(br);
else
Entities = null;

if ((Flags & 4) != 0)
ReplyMarkup = (TLAbsReplyMarkup)ObjectUtils.DeserializeObject(br);
else
ReplyMarkup = null;


        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ComputeFlags();
bw.Write(Flags);
StringUtil.Serialize(Message,bw);
if ((Flags & 2) != 0)
ObjectUtils.SerializeObject(Entities,bw);
if ((Flags & 4) != 0)
ObjectUtils.SerializeObject(ReplyMarkup,bw);

        }
    }
}
