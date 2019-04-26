using System;
using System.IO;
using System.Windows.Forms;

class DexReader
{
    public DexReader(string path)
    {
        byte[] bytes = File.ReadAllBytes(path);
        /*if (file.Substring(0, Globals.MAGIC_NUMBER_LENGTH) != Globals.MAGIC_NUMBER)
        {
            MessageBox.Show("Bad magic number");
            return;
        }*/
        if (bytes.Length < Globals.DEX_HEADERS_SIZE)
        {
            MessageBox.Show("Bad dex size");
            return;
        }

        checksum = CalcValue(bytes, Globals.COMMON_DEX_HEADER_SIZE, Globals.CHECKSUM_OFFSET);
        signature = GetBytesSubarray(bytes, (uint)Globals.SIGNATURE_LENGTH, Globals.SIGNATURE_OFFSET);
        fileSize = CalcValue(bytes, Globals.COMMON_DEX_HEADER_SIZE, Globals.FILE_SIZE_OFFSET);
        headerSize = CalcValue(bytes, Globals.COMMON_DEX_HEADER_SIZE, Globals.HEADER_SIZE_OFFSET);
        endianTag = CalcValue(bytes, Globals.COMMON_DEX_HEADER_SIZE, Globals.ENDIAN_TAG_OFFSET);

        links = GetDataBlock(bytes, Globals.LINK_SIZE_OFFSET, Globals.LINK_OFFSET);
        stringIds = GetDataBlock(bytes, Globals.STRING_ID_SIZE_OFFSET, Globals.STRING_ID_OFFSET);
        typeIds = GetDataBlock(bytes, Globals.TYPE_ID_SIZE_OFFSET, Globals.TYPE_ID_OFFSET);
        protoIds = GetDataBlock(bytes, Globals.PROTO_ID_SIZE_OFFSET, Globals.PROTO_ID_OFFSET);
        fieldIds = GetDataBlock(bytes, Globals.FIELD_ID_SIZE_OFFSET, Globals.FIELD_ID_OFFSET);
        methodIds = GetDataBlock(bytes, Globals.METHOD_ID_SIZE_OFFSET, Globals.METHOD_ID_OFFSET);
        classDefs = GetDataBlock(bytes, Globals.CLASS_DEFS_SIZE_OFFSET, Globals.CLASS_DEFS_OFFSET);
        data = GetDataBlock(bytes, Globals.DATA_SIZE_OFFSET, Globals.DATA_OFFSET);
    }

    public byte[] GetData()
    {
        return data;
    }

    private uint CalcHexValue(byte decValue, long pos)
    {
        uint firstPart = (uint)(decValue % Globals.HEX_BASE) * (uint)Math.Pow(Globals.HEX_BASE, 2 * pos);
        uint secondPart = (uint)(decValue / Globals.HEX_BASE) * (uint)Math.Pow(Globals.HEX_BASE, (2 * pos) + 1);
        return firstPart + secondPart;
    }

    private uint CalcValue(byte[] bytes, short size, uint offset)
    {
        uint value = 0;

        for (long i = offset; i <= offset + size; ++i)
        {
            value += CalcHexValue(bytes[i], i - offset);
        }
        return value;
    }

    private byte[] GetBytesSubarray(byte[] bytes, uint size, uint offset)
    {
        byte[] signatureBytes = new byte[size];
        Array.Copy(bytes, offset, signatureBytes, 0, size);
        return signatureBytes;
    }

    private byte[] GetDataBlock(byte[] bytes, uint sizeOffset, uint offset)
    {
        uint blockSize = CalcValue(bytes, Globals.COMMON_DEX_HEADER_SIZE, sizeOffset);
        uint blockOffset = CalcValue(bytes, Globals.COMMON_DEX_HEADER_SIZE, offset);
        return GetBytesSubarray(bytes, blockSize, blockOffset);
    }

    private uint checksum;
    private uint fileSize;
    private uint headerSize;
    private uint endianTag;
    private byte[] signature;

    private byte[] links;
    private byte[] stringIds;
    private byte[] typeIds;
    private byte[] protoIds;
    private byte[] fieldIds;
    private byte[] methodIds;
    private byte[] classDefs;
    private byte[] data;
}