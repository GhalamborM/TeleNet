using System.IO;

namespace TeleNet.Models.TL
{
    [TLObject(1434820921)]
    public class TLStickerSet : TLAbsStickerSet
    {
        public override int Constructor
        {
            get
            {
                return 1434820921;
            }
        }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            Archived = (Flags & 2) != 0;
            Official = (Flags & 4) != 0;
            Masks = (Flags & 8) != 0;
            if ((Flags & 1) != 0)
                InstalledDate = br.ReadInt32();
            else
                InstalledDate = null;

            Id = br.ReadInt64();
            AccessHash = br.ReadInt64();
            Title = StringUtil.Deserialize(br);
            ShortName = StringUtil.Deserialize(br);
            Count = br.ReadInt32();
            Hash = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Flags);



            if ((Flags & 1) != 0)
                bw.Write(InstalledDate.Value);
            bw.Write(Id);
            bw.Write(AccessHash);
            StringUtil.Serialize(Title, bw);
            StringUtil.Serialize(ShortName, bw);
            bw.Write(Count);
            bw.Write(Hash);

        }
    }
}
