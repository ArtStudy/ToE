using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameСreator.ToePac
{
    public class Item
    {


        Stream stream;




  //      UInt16 _FileType = 0;
        public Item()
        {

        }
        public Item(Stream data)
        {
            Deserialization(data);
        }

        public void Serialization(Stream st)
        {
            stream = st;
           // stream.Position = positionitem;
            var bw = new BinaryWriter(stream);

            bw.Write(this.Identifier);
            bw.Write(this.Name.PadRight(65).Remove(64).ToCharArray());
            bw.Write((long)this.FileType);
            bw.Write(this.Length);
            this.Position = st.Length;
            bw.Write(this.Position);

            BinaryReader br = new BinaryReader(this.Data);
           
                var b = br.ReadBytes((int)this.Data.Length);

                stream.Position = this.Position;
                stream.Write(b, 0, b.Length);
            
           


     
        }
        public Item Deserialization(Stream data)
        {

            BinaryReader br = new BinaryReader(data);


            this.Identifier = br.ReadUInt64();
            this.Name = new string(br.ReadChars(64));
            this.FileType = (FileTypes) br.ReadInt64() ;
            var length = br.ReadInt64();
            this.Position = br.ReadInt64();

            byte[] bytedata = new byte[length];

            data.Position = this.Position;
            data.Read(bytedata, 0, (int)length);

            this.Data = new MemoryStream(bytedata);
          


            return null;
        }


        /// <summary>
        /// Идентификатор файла
        /// </summary>
        public UInt64 Identifier { get; set; } = 0;

        public string Name { get; set; } = string.Empty;


        /// <summary>
        /// Тип файла
        /// </summary>
        public FileTypes FileType { get; set; } = FileTypes.Unknown;
         
        /// <summary>
        /// Длинна файла
        /// </summary>
        public long Length { get => Data.Length; }
        /// <summary>
        /// Данные
        /// </summary>
        public Stream Data { get; set; } = Stream.Null;

        /// <summary>
        /// Позиция файла
        /// </summary>
        private long Position { get; set; }

    }
    public enum FileTypes : long
    {
        Unknown = 0,
        Json = 1
    }
}
