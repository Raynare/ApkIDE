static class Globals
{
    public static short MAGIC_NUMBER_LENGTH    = 3;
    public static string MAGIC_NUMBER          = "dex";
    public static short COMMON_DEX_HEADER_SIZE = 4;
    public static uint CHECKSUM_OFFSET         = 8;
    public static short HEX_BASE               = 16;
    public static uint SIGNATURE_OFFSET        = 12;
    public static short SIGNATURE_LENGTH       = 20;
    public static short DEX_HEADERS_SIZE       = 112;
    public static uint FILE_SIZE_OFFSET        = 32;
    public static uint HEADER_SIZE_OFFSET      = 36;
    public static uint ENDIAN_TAG_OFFSET       = 40;
    public static uint LINK_SIZE_OFFSET        = 44;
    public static uint LINK_OFFSET             = 48;
    public static uint MAP_OFFSET              = 52; // not parsed
    public static uint STRING_ID_SIZE_OFFSET   = 56;
    public static uint STRING_ID_OFFSET        = 60;
    public static uint TYPE_ID_SIZE_OFFSET     = 64;
    public static uint TYPE_ID_OFFSET          = 68;
    public static uint PROTO_ID_SIZE_OFFSET    = 72;
    public static uint PROTO_ID_OFFSET         = 76;
    public static uint FIELD_ID_SIZE_OFFSET    = 80;
    public static uint FIELD_ID_OFFSET         = 84;
    public static uint METHOD_ID_SIZE_OFFSET   = 88;
    public static uint METHOD_ID_OFFSET        = 92;
    public static uint CLASS_DEFS_SIZE_OFFSET  = 96;
    public static uint CLASS_DEFS_OFFSET       = 100;
    public static uint DATA_SIZE_OFFSET        = 104;
    public static uint DATA_OFFSET             = 108;
}