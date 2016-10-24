using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Maddalena
{
    public enum CountryCodeISO3
    {
        World,
        ABW,
        AFG,
        AGO,
        AIA,
        ALA,
        ALB,
        AND,
        ARE,
        ARG,
        ARM,
        ASM,
        ATA,
        ATF,
        ATG,
        AUS,
        AUT,
        AZE,
        BDI,
        BEL,
        BEN,
        BFA,
        BGD,
        BGR,
        BHR,
        BHS,
        BIH,
        BLM,
        BLR,
        BLZ,
        BMU,
        BOL,
        BRA,
        BRB,
        BRN,
        BTN,
        BVT,
        BWA,
        CAF,
        CAN,
        CCK,
        CHE,
        CHL,
        CHN,
        CIV,
        CMR,
        COD,
        COG,
        COK,
        COL,
        COM,
        CPV,
        CRI,
        CUB,
        CUW,
        CXR,
        CYM,
        CYP,
        CZE,
        DEU,
        DJI,
        DMA,
        DNK,
        DOM,
        DZA,
        ECU,
        EGY,
        ERI,
        ESH,
        ESP,
        EST,
        ETH,
        FIN,
        FJI,
        FLK,
        FRA,
        FRO,
        FSM,
        GAB,
        GBR,
        GEO,
        GGY,
        GHA,
        GIB,
        GIN,
        GLP,
        GMB,
        GNB,
        GNQ,
        GRC,
        GRD,
        GRL,
        GTM,
        GUF,
        GUM,
        GUY,
        HKG,
        HMD,
        HND,
        HRV,
        HTI,
        HUN,
        IDN,
        IMN,
        IND,
        IOT,
        IRL,
        IRN,
        IRQ,
        ISL,
        ISR,
        ITA,
        JAM,
        JEY,
        JOR,
        JPN,
        KAZ,
        KEN,
        KGZ,
        KHM,
        KIR,
        KNA,
        KOR,
        KOS,
        KWT,
        LAO,
        LBN,
        LBR,
        LBY,
        LCA,
        LIE,
        LKA,
        LSO,
        LTU,
        LUX,
        LVA,
        MAC,
        MAF,
        MAR,
        MCO,
        MDA,
        MDG,
        MDV,
        MEX,
        MHL,
        MKD,
        MLI,
        MLT,
        MMR,
        MNE,
        MNG,
        MNP,
        MOZ,
        MRT,
        MSR,
        MTQ,
        MUS,
        MWI,
        MYS,
        MYT,
        NAM,
        NCL,
        NER,
        NFK,
        NGA,
        NIC,
        NIU,
        NLD,
        NOR,
        NPL,
        NRU,
        NZL,
        OMN,
        PAK,
        PAN,
        PCN,
        PER,
        PHL,
        PLW,
        PNG,
        POL,
        PRI,
        PRK,
        PRT,
        PRY,
        PSE,
        PYF,
        QAT,
        REU,
        ROU,
        RUS,
        RWA,
        SAU,
        SDN,
        SEN,
        SGP,
        SGS,
        SJM,
        SLB,
        SLE,
        SLV,
        SMR,
        SOM,
        SPM,
        SRB,
        SSD,
        STP,
        SUR,
        SVK,
        SVN,
        SWE,
        SWZ,
        SXM,
        SYC,
        SYR,
        TCA,
        TCD,
        TGO,
        THA,
        TJK,
        TKL,
        TKM,
        TLS,
        TON,
        TTO,
        TUN,
        TUR,
        TUV,
        TWN,
        TZA,
        UGA,
        UKR,
        UMI,
        URY,
        USA,
        UZB,
        VAT,
        VCT,
        VEN,
        VGB,
        VIR,
        VNM,
        VUT,
        WLF,
        WSM,
        YEM,
        ZAF,
        ZMB,
        ZWE,
    }
    public enum CountryCode
    {
        World,
        AW,
        AF,
        AO,
        AI,
        AX,
        AL,
        AD,
        AE,
        AR,
        AM,
        AS,
        AQ,
        TF,
        AG,
        AU,
        AT,
        AZ,
        BI,
        BE,
        BJ,
        BF,
        BD,
        BG,
        BH,
        BS,
        BA,
        BL,
        BY,
        BZ,
        BM,
        BO,
        BR,
        BB,
        BN,
        BT,
        BV,
        BW,
        CF,
        CA,
        CC,
        CH,
        CL,
        CN,
        CI,
        CM,
        CD,
        CG,
        CK,
        CO,
        KM,
        CV,
        CR,
        CU,
        CW,
        CX,
        KY,
        CY,
        CZ,
        DE,
        DJ,
        DM,
        DK,
        DO,
        DZ,
        EC,
        EG,
        ER,
        EH,
        ES,
        EE,
        ET,
        FI,
        FJ,
        FK,
        FR,
        FO,
        FM,
        GA,
        UK,
        GE,
        GG,
        GH,
        GI,
        GN,
        GP,
        GM,
        GW,
        GQ,
        GR,
        GD,
        GL,
        GT,
        GF,
        GU,
        GY,
        HK,
        HM,
        HN,
        HR,
        HT,
        HU,
        ID,
        IM,
        IN,
        IO,
        IE,
        IR,
        IQ,
        IS,
        IL,
        IT,
        JM,
        JE,
        JO,
        JP,
        KZ,
        KE,
        KG,
        KH,
        KI,
        KN,
        KR,
        XK,
        KW,
        LA,
        LB,
        LR,
        LY,
        LC,
        LI,
        LK,
        LS,
        LT,
        LU,
        LV,
        MO,
        MF,
        MA,
        MC,
        MD,
        MG,
        MV,
        MX,
        MH,
        MK,
        ML,
        MT,
        MM,
        ME,
        MN,
        MP,
        MZ,
        MR,
        MS,
        MQ,
        MU,
        MW,
        MY,
        YT,
        NA,
        NC,
        NE,
        NF,
        NG,
        NI,
        NU,
        NL,
        NO,
        NP,
        NR,
        NZ,
        OM,
        PK,
        PA,
        PN,
        PE,
        PH,
        PW,
        PG,
        PL,
        PR,
        KP,
        PT,
        PY,
        PS,
        PF,
        QA,
        RE,
        RO,
        RU,
        RW,
        SA,
        SD,
        SN,
        SG,
        GS,
        SJ,
        SB,
        SL,
        SV,
        SM,
        SO,
        PM,
        RS,
        SS,
        ST,
        SR,
        SK,
        SI,
        SE,
        SZ,
        SX,
        SC,
        SY,
        TC,
        TD,
        TG,
        TH,
        TJ,
        TK,
        TM,
        TL,
        TO,
        TT,
        TN,
        TR,
        TV,
        TW,
        TZ,
        UG,
        UA,
        UM,
        UY,
        US,
        UZ,
        VA,
        VC,
        VE,
        VG,
        VI,
        VN,
        VU,
        WF,
        WS,
        YE,
        ZA,
        ZM,
        ZW,
    }

    public partial class Country
    {
        public string CommonName { get; private set; }
        public string OfficialName { get; private set; }
        public string[] TLD { get; private set; }
        public CountryCode CountryCode { get; private set; }
        public string ISONumeric { get; private set; }
        public CountryCodeISO3 ISO3 { get; private set; }
        public string CIOC { get; private set; }
        public string[] Currencies { get; private set; }
        public string[] CallingCodes { get; private set; }
        public string Capital { get; private set; }
        public string[] AlternativeSpellings { get; private set; }
        public string Region { get; private set; }
        public string SubRegion { get; private set; }
        public CountryCodeISO3[] Borders { get; private set; }
        public bool Landlocked { get; private set; }
        public double Area { get; private set; }

        public override bool Equals(object obj)
        {
            var item = obj as Country;

            if (item == null) return false;

            return this.CountryCode == item.CountryCode;
        }

        public override int GetHashCode()
        {
            return (int)this.CountryCode;
        }

        public override string ToString()
        {
            return CommonName;
        }

        public static Country Parse(string value)
        {
            CountryCode code;
            if (Enum.TryParse(value, true, out code)) return FromCode(code);

            CountryCodeISO3 isoCode;
            if (Enum.TryParse(value, true, out isoCode)) return FromCode(isoCode);

            return null;
        }

        public static Country FromCode(CountryCode cc)
        {
            return All.FirstOrDefault(x => x.CountryCode == cc) ?? World;
        }

        public static Country FromCode(CountryCodeISO3 cc)
        {
            return All.FirstOrDefault(x => x.ISO3 == cc) ?? World;
        }

        public static IEnumerable<Country> All
        {
            get
            {
                foreach (var k in typeof(Country).GetRuntimeProperties().Where(x => x.PropertyType == typeof(Country)))
                {
                    yield return k.GetValue(null) as Country;
                }
            }
        }

        public static Country World
        {
            get
            {
                return new Country
                {
                    CommonName = "World",
                    OfficialName = "World",
                    TLD = new[] { ".com" },
                    CountryCode = CountryCode.World,
                    ISONumeric = "",
                    ISO3 = CountryCodeISO3.ABW,
                    CIOC = "",
                    Currencies = new string[0],
                    CallingCodes = new string[0],
                    Capital = "",
                    AlternativeSpellings = new string[0],
                    Region = "",
                    SubRegion = "",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 510072000,
                };
            }
        }

        public static Country Aruba
        {
            get
            {
                return new Country
                {
                    CommonName = "Aruba",
                    OfficialName = "Aruba",
                    TLD = new[] { ".aw" },
                    CountryCode = CountryCode.AW,
                    ISONumeric = "533",
                    ISO3 = CountryCodeISO3.ABW,
                    CIOC = "ARU",
                    Currencies = new[] { "AWG" },
                    CallingCodes = new[] { "297" },
                    Capital = "Oranjestad",
                    AlternativeSpellings = new[] { "AW" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 180,
                };
            }
        }
        public static Country Afghanistan
        {
            get
            {
                return new Country
                {
                    CommonName = "Afghanistan",
                    OfficialName = "Islamic Republic of Afghanistan",
                    TLD = new[] { ".af" },
                    CountryCode = CountryCode.AF,
                    ISONumeric = "004",
                    ISO3 = CountryCodeISO3.AFG,
                    CIOC = "AFG",
                    Currencies = new[] { "AFN" },
                    CallingCodes = new[] { "93" },
                    Capital = "Kabul",
                    AlternativeSpellings = new[] { "AF", "Afġānistān" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.IRN, CountryCodeISO3.PAK, CountryCodeISO3.TKM, CountryCodeISO3.UZB, CountryCodeISO3.TJK, CountryCodeISO3.CHN },
                    Landlocked = true,
                    Area = 652230,
                };
            }
        }
        public static Country Angola
        {
            get
            {
                return new Country
                {
                    CommonName = "Angola",
                    OfficialName = "Republic of Angola",
                    TLD = new[] { ".ao" },
                    CountryCode = CountryCode.AO,
                    ISONumeric = "024",
                    ISO3 = CountryCodeISO3.AGO,
                    CIOC = "ANG",
                    Currencies = new[] { "AOA" },
                    CallingCodes = new[] { "244" },
                    Capital = "Luanda",
                    AlternativeSpellings = new[] { "AO", "República de Angola", "ʁɛpublika de an'ɡɔla" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.COG, CountryCodeISO3.COD, CountryCodeISO3.ZMB, CountryCodeISO3.NAM },
                    Landlocked = false,
                    Area = 1246700,
                };
            }
        }
        public static Country Anguilla
        {
            get
            {
                return new Country
                {
                    CommonName = "Anguilla",
                    OfficialName = "Anguilla",
                    TLD = new[] { ".ai" },
                    CountryCode = CountryCode.AI,
                    ISONumeric = "660",
                    ISO3 = CountryCodeISO3.AIA,
                    CIOC = "",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1264" },
                    Capital = "The Valley",
                    AlternativeSpellings = new[] { "AI" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 91,
                };
            }
        }
        public static Country ÅlandIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Åland Islands",
                    OfficialName = "Åland Islands",
                    TLD = new[] { ".ax" },
                    CountryCode = CountryCode.AX,
                    ISONumeric = "248",
                    ISO3 = CountryCodeISO3.ALA,
                    CIOC = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "358" },
                    Capital = "Mariehamn",
                    AlternativeSpellings = new[] { "AX", "Aaland", "Aland", "Ahvenanmaa" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 1580,
                };
            }
        }
        public static Country Albania
        {
            get
            {
                return new Country
                {
                    CommonName = "Albania",
                    OfficialName = "Republic of Albania",
                    TLD = new[] { ".al" },
                    CountryCode = CountryCode.AL,
                    ISONumeric = "008",
                    ISO3 = CountryCodeISO3.ALB,
                    CIOC = "ALB",
                    Currencies = new[] { "ALL" },
                    CallingCodes = new[] { "355" },
                    Capital = "Tirana",
                    AlternativeSpellings = new[] { "AL", "Shqipëri", "Shqipëria", "Shqipnia" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.MNE, CountryCodeISO3.GRC, CountryCodeISO3.MKD, CountryCodeISO3.KOS },
                    Landlocked = false,
                    Area = 28748,
                };
            }
        }
        public static Country Andorra
        {
            get
            {
                return new Country
                {
                    CommonName = "Andorra",
                    OfficialName = "Principality of Andorra",
                    TLD = new[] { ".ad" },
                    CountryCode = CountryCode.AD,
                    ISONumeric = "020",
                    ISO3 = CountryCodeISO3.AND,
                    CIOC = "AND",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "376" },
                    Capital = "Andorra la Vella",
                    AlternativeSpellings = new[] { "AD", "Principality of Andorra", "Principat d'Andorra" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.FRA, CountryCodeISO3.ESP },
                    Landlocked = true,
                    Area = 468,
                };
            }
        }
        public static Country UnitedArabEmirates
        {
            get
            {
                return new Country
                {
                    CommonName = "United Arab Emirates",
                    OfficialName = "United Arab Emirates",
                    TLD = new[] { ".ae", "امارات." },
                    CountryCode = CountryCode.AE,
                    ISONumeric = "784",
                    ISO3 = CountryCodeISO3.ARE,
                    CIOC = "UAE",
                    Currencies = new[] { "AED" },
                    CallingCodes = new[] { "971" },
                    Capital = "Abu Dhabi",
                    AlternativeSpellings = new[] { "AE", "UAE", "Emirates" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.OMN, CountryCodeISO3.SAU },
                    Landlocked = false,
                    Area = 83600,
                };
            }
        }
        public static Country Argentina
        {
            get
            {
                return new Country
                {
                    CommonName = "Argentina",
                    OfficialName = "Argentine Republic",
                    TLD = new[] { ".ar" },
                    CountryCode = CountryCode.AR,
                    ISONumeric = "032",
                    ISO3 = CountryCodeISO3.ARG,
                    CIOC = "ARG",
                    Currencies = new[] { "ARS" },
                    CallingCodes = new[] { "54" },
                    Capital = "Buenos Aires",
                    AlternativeSpellings = new[] { "AR", "Argentine Republic", "República Argentina" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BOL, CountryCodeISO3.BRA, CountryCodeISO3.CHL, CountryCodeISO3.PRY, CountryCodeISO3.URY },
                    Landlocked = false,
                    Area = 2780400,
                };
            }
        }
        public static Country Armenia
        {
            get
            {
                return new Country
                {
                    CommonName = "Armenia",
                    OfficialName = "Republic of Armenia",
                    TLD = new[] { ".am" },
                    CountryCode = CountryCode.AM,
                    ISONumeric = "051",
                    ISO3 = CountryCodeISO3.ARM,
                    CIOC = "ARM",
                    Currencies = new[] { "AMD" },
                    CallingCodes = new[] { "374" },
                    Capital = "Yerevan",
                    AlternativeSpellings = new[] { "AM", "Hayastan", "Republic of Armenia", "Հայաստանի Հանրապետություն" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AZE, CountryCodeISO3.GEO, CountryCodeISO3.IRN, CountryCodeISO3.TUR },
                    Landlocked = true,
                    Area = 29743,
                };
            }
        }
        public static Country AmericanSamoa
        {
            get
            {
                return new Country
                {
                    CommonName = "American Samoa",
                    OfficialName = "American Samoa",
                    TLD = new[] { ".as" },
                    CountryCode = CountryCode.AS,
                    ISONumeric = "016",
                    ISO3 = CountryCodeISO3.ASM,
                    CIOC = "ASA",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "1684" },
                    Capital = "Pago Pago",
                    AlternativeSpellings = new[] { "AS", "Amerika Sāmoa", "Amelika Sāmoa", "Sāmoa Amelika" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 199,
                };
            }
        }
        public static Country Antarctica
        {
            get
            {
                return new Country
                {
                    CommonName = "Antarctica",
                    OfficialName = "Antarctica",
                    TLD = new[] { ".aq" },
                    CountryCode = CountryCode.AQ,
                    ISONumeric = "010",
                    ISO3 = CountryCodeISO3.ATA,
                    CIOC = "",
                    Currencies = new string[] { },
                    Capital = "",
                    AlternativeSpellings = new[] { "AQ" },
                    Region = "",
                    SubRegion = "",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 14000000,
                };
            }
        }
        public static Country FrenchSouthernandAntarcticLands
        {
            get
            {
                return new Country
                {
                    CommonName = "French Southern and Antarctic Lands",
                    OfficialName = "Territory of the French Southern and Antarctic Lands",
                    TLD = new[] { ".tf" },
                    CountryCode = CountryCode.TF,
                    ISONumeric = "260",
                    ISO3 = CountryCodeISO3.ATF,
                    CIOC = "",
                    Currencies = new[] { "EUR" },
                    Capital = "Port-aux-Français",
                    AlternativeSpellings = new[] { "TF", "French Southern Territories" },
                    Region = "",
                    SubRegion = "",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 7747,
                };
            }
        }
        public static Country AntiguaandBarbuda
        {
            get
            {
                return new Country
                {
                    CommonName = "Antigua and Barbuda",
                    OfficialName = "Antigua and Barbuda",
                    TLD = new[] { ".ag" },
                    CountryCode = CountryCode.AG,
                    ISONumeric = "028",
                    ISO3 = CountryCodeISO3.ATG,
                    CIOC = "ANT",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1268" },
                    Capital = "Saint John's",
                    AlternativeSpellings = new[] { "AG" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 442,
                };
            }
        }
        public static Country Australia
        {
            get
            {
                return new Country
                {
                    CommonName = "Australia",
                    OfficialName = "Commonwealth of Australia",
                    TLD = new[] { ".au" },
                    CountryCode = CountryCode.AU,
                    ISONumeric = "036",
                    ISO3 = CountryCodeISO3.AUS,
                    CIOC = "AUS",
                    Currencies = new[] { "AUD" },
                    CallingCodes = new[] { "61" },
                    Capital = "Canberra",
                    AlternativeSpellings = new[] { "AU" },
                    Region = "Oceania",
                    SubRegion = "Australia and New Zealand",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 7692024,
                };
            }
        }
        public static Country Austria
        {
            get
            {
                return new Country
                {
                    CommonName = "Austria",
                    OfficialName = "Republic of Austria",
                    TLD = new[] { ".at" },
                    CountryCode = CountryCode.AT,
                    ISONumeric = "040",
                    ISO3 = CountryCodeISO3.AUT,
                    CIOC = "AUT",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "43" },
                    Capital = "Vienna",
                    AlternativeSpellings = new[] { "AT", "Osterreich", "Oesterreich" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CZE, CountryCodeISO3.DEU, CountryCodeISO3.HUN, CountryCodeISO3.ITA, CountryCodeISO3.LIE, CountryCodeISO3.SVK, CountryCodeISO3.SVN, CountryCodeISO3.CHE },
                    Landlocked = true,
                    Area = 83871,
                };
            }
        }
        public static Country Azerbaijan
        {
            get
            {
                return new Country
                {
                    CommonName = "Azerbaijan",
                    OfficialName = "Republic of Azerbaijan",
                    TLD = new[] { ".az" },
                    CountryCode = CountryCode.AZ,
                    ISONumeric = "031",
                    ISO3 = CountryCodeISO3.AZE,
                    CIOC = "AZE",
                    Currencies = new[] { "AZN" },
                    CallingCodes = new[] { "994" },
                    Capital = "Baku",
                    AlternativeSpellings = new[] { "AZ", "Republic of Azerbaijan", "Azərbaycan Respublikası" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ARM, CountryCodeISO3.GEO, CountryCodeISO3.IRN, CountryCodeISO3.RUS, CountryCodeISO3.TUR },
                    Landlocked = true,
                    Area = 86600,
                };
            }
        }
        public static Country Burundi
        {
            get
            {
                return new Country
                {
                    CommonName = "Burundi",
                    OfficialName = "Republic of Burundi",
                    TLD = new[] { ".bi" },
                    CountryCode = CountryCode.BI,
                    ISONumeric = "108",
                    ISO3 = CountryCodeISO3.BDI,
                    CIOC = "BDI",
                    Currencies = new[] { "BIF" },
                    CallingCodes = new[] { "257" },
                    Capital = "Bujumbura",
                    AlternativeSpellings = new[] { "BI", "Republic of Burundi", "Republika y'Uburundi", "République du Burundi" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.COD, CountryCodeISO3.RWA, CountryCodeISO3.TZA },
                    Landlocked = true,
                    Area = 27834,
                };
            }
        }
        public static Country Belgium
        {
            get
            {
                return new Country
                {
                    CommonName = "Belgium",
                    OfficialName = "Kingdom of Belgium",
                    TLD = new[] { ".be" },
                    CountryCode = CountryCode.BE,
                    ISONumeric = "056",
                    ISO3 = CountryCodeISO3.BEL,
                    CIOC = "BEL",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "32" },
                    Capital = "Brussels",
                    AlternativeSpellings = new[] { "BE", "België", "Belgie", "Belgien", "Belgique", "Kingdom of Belgium", "Koninkrijk België", "Royaume de Belgique", "Königreich Belgien" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.FRA, CountryCodeISO3.DEU, CountryCodeISO3.LUX, CountryCodeISO3.NLD },
                    Landlocked = false,
                    Area = 30528,
                };
            }
        }
        public static Country Benin
        {
            get
            {
                return new Country
                {
                    CommonName = "Benin",
                    OfficialName = "Republic of Benin",
                    TLD = new[] { ".bj" },
                    CountryCode = CountryCode.BJ,
                    ISONumeric = "204",
                    ISO3 = CountryCodeISO3.BEN,
                    CIOC = "BEN",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "229" },
                    Capital = "Porto-Novo",
                    AlternativeSpellings = new[] { "BJ", "Republic of Benin", "République du Bénin" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BFA, CountryCodeISO3.NER, CountryCodeISO3.NGA, CountryCodeISO3.TGO },
                    Landlocked = false,
                    Area = 112622,
                };
            }
        }
        public static Country BurkinaFaso
        {
            get
            {
                return new Country
                {
                    CommonName = "Burkina Faso",
                    OfficialName = "Burkina Faso",
                    TLD = new[] { ".bf" },
                    CountryCode = CountryCode.BF,
                    ISONumeric = "854",
                    ISO3 = CountryCodeISO3.BFA,
                    CIOC = "BUR",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "226" },
                    Capital = "Ouagadougou",
                    AlternativeSpellings = new[] { "BF" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BEN, CountryCodeISO3.CIV, CountryCodeISO3.GHA, CountryCodeISO3.MLI, CountryCodeISO3.NER, CountryCodeISO3.TGO },
                    Landlocked = true,
                    Area = 272967,
                };
            }
        }
        public static Country Bangladesh
        {
            get
            {
                return new Country
                {
                    CommonName = "Bangladesh",
                    OfficialName = "People's Republic of Bangladesh",
                    TLD = new[] { ".bd" },
                    CountryCode = CountryCode.BD,
                    ISONumeric = "050",
                    ISO3 = CountryCodeISO3.BGD,
                    CIOC = "BAN",
                    Currencies = new[] { "BDT" },
                    CallingCodes = new[] { "880" },
                    Capital = "Dhaka",
                    AlternativeSpellings = new[] { "BD", "People's Republic of Bangladesh", "Gônôprôjatôntri Bangladesh" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.MMR, CountryCodeISO3.IND },
                    Landlocked = false,
                    Area = 147570,
                };
            }
        }
        public static Country Bulgaria
        {
            get
            {
                return new Country
                {
                    CommonName = "Bulgaria",
                    OfficialName = "Republic of Bulgaria",
                    TLD = new[] { ".bg" },
                    CountryCode = CountryCode.BG,
                    ISONumeric = "100",
                    ISO3 = CountryCodeISO3.BGR,
                    CIOC = "BUL",
                    Currencies = new[] { "BGN" },
                    CallingCodes = new[] { "359" },
                    Capital = "Sofia",
                    AlternativeSpellings = new[] { "BG", "Republic of Bulgaria", "Република България" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.GRC, CountryCodeISO3.MKD, CountryCodeISO3.ROU, CountryCodeISO3.SRB, CountryCodeISO3.TUR },
                    Landlocked = false,
                    Area = 110879,
                };
            }
        }
        public static Country Bahrain
        {
            get
            {
                return new Country
                {
                    CommonName = "Bahrain",
                    OfficialName = "Kingdom of Bahrain",
                    TLD = new[] { ".bh" },
                    CountryCode = CountryCode.BH,
                    ISONumeric = "048",
                    ISO3 = CountryCodeISO3.BHR,
                    CIOC = "BRN",
                    Currencies = new[] { "BHD" },
                    CallingCodes = new[] { "973" },
                    Capital = "Manama",
                    AlternativeSpellings = new[] { "BH", "Kingdom of Bahrain", "Mamlakat al-Baḥrayn" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 765,
                };
            }
        }
        public static Country Bahamas
        {
            get
            {
                return new Country
                {
                    CommonName = "Bahamas",
                    OfficialName = "Commonwealth of the Bahamas",
                    TLD = new[] { ".bs" },
                    CountryCode = CountryCode.BS,
                    ISONumeric = "044",
                    ISO3 = CountryCodeISO3.BHS,
                    CIOC = "BAH",
                    Currencies = new[] { "BSD" },
                    CallingCodes = new[] { "1242" },
                    Capital = "Nassau",
                    AlternativeSpellings = new[] { "BS", "Commonwealth of the Bahamas" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 13943,
                };
            }
        }
        public static Country BosniaandHerzegovina
        {
            get
            {
                return new Country
                {
                    CommonName = "Bosnia and Herzegovina",
                    OfficialName = "Bosnia and Herzegovina",
                    TLD = new[] { ".ba" },
                    CountryCode = CountryCode.BA,
                    ISONumeric = "070",
                    ISO3 = CountryCodeISO3.BIH,
                    CIOC = "BIH",
                    Currencies = new[] { "BAM" },
                    CallingCodes = new[] { "387" },
                    Capital = "Sarajevo",
                    AlternativeSpellings = new[] { "BA", "Bosnia-Herzegovina", "Босна и Херцеговина" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.HRV, CountryCodeISO3.MNE, CountryCodeISO3.SRB },
                    Landlocked = false,
                    Area = 51209,
                };
            }
        }
        public static Country SaintBarthélemy
        {
            get
            {
                return new Country
                {
                    CommonName = "Saint Barthélemy",
                    OfficialName = "Collectivity of Saint BarthélemySaint Barthélemy",
                    TLD = new[] { ".bl" },
                    CountryCode = CountryCode.BL,
                    ISONumeric = "652",
                    ISO3 = CountryCodeISO3.BLM,
                    CIOC = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "590" },
                    Capital = "Gustavia",
                    AlternativeSpellings = new[] { "BL", "St. Barthelemy", "Collectivity of Saint Barthélemy", "Collectivité de Saint-Barthélemy" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 21,
                };
            }
        }
        public static Country Belarus
        {
            get
            {
                return new Country
                {
                    CommonName = "Belarus",
                    OfficialName = "Republic of Belarus",
                    TLD = new[] { ".by" },
                    CountryCode = CountryCode.BY,
                    ISONumeric = "112",
                    ISO3 = CountryCodeISO3.BLR,
                    CIOC = "BLR",
                    Currencies = new[] { "BYR" },
                    CallingCodes = new[] { "375" },
                    Capital = "Minsk",
                    AlternativeSpellings = new[] { "BY", "Bielaruś", "Republic of Belarus", "Белоруссия", "Республика Беларусь", "Belorussiya", "Respublika Belarus’" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.LVA, CountryCodeISO3.LTU, CountryCodeISO3.POL, CountryCodeISO3.RUS, CountryCodeISO3.UKR },
                    Landlocked = true,
                    Area = 207600,
                };
            }
        }
        public static Country Belize
        {
            get
            {
                return new Country
                {
                    CommonName = "Belize",
                    OfficialName = "Belize",
                    TLD = new[] { ".bz" },
                    CountryCode = CountryCode.BZ,
                    ISONumeric = "084",
                    ISO3 = CountryCodeISO3.BLZ,
                    CIOC = "BIZ",
                    Currencies = new[] { "BZD" },
                    CallingCodes = new[] { "501" },
                    Capital = "Belmopan",
                    AlternativeSpellings = new[] { "BZ" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.GTM, CountryCodeISO3.MEX },
                    Landlocked = false,
                    Area = 22966,
                };
            }
        }
        public static Country Bermuda
        {
            get
            {
                return new Country
                {
                    CommonName = "Bermuda",
                    OfficialName = "Bermuda",
                    TLD = new[] { ".bm" },
                    CountryCode = CountryCode.BM,
                    ISONumeric = "060",
                    ISO3 = CountryCodeISO3.BMU,
                    CIOC = "BER",
                    Currencies = new[] { "BMD" },
                    CallingCodes = new[] { "1441" },
                    Capital = "Hamilton",
                    AlternativeSpellings = new[] { "BM", "The Islands of Bermuda", "The Bermudas", "Somers Isles" },
                    Region = "Americas",
                    SubRegion = "Northern America",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 54,
                };
            }
        }
        public static Country Bolivia
        {
            get
            {
                return new Country
                {
                    CommonName = "Bolivia",
                    OfficialName = "Plurinational State of Bolivia",
                    TLD = new[] { ".bo" },
                    CountryCode = CountryCode.BO,
                    ISONumeric = "068",
                    ISO3 = CountryCodeISO3.BOL,
                    CIOC = "BOL",
                    Currencies = new[] { "BOB", "BOV" },
                    CallingCodes = new[] { "591" },
                    Capital = "Sucre",
                    AlternativeSpellings = new[] { "BO", "Buliwya", "Wuliwya", "Bolivia, Plurinational State of", "Plurinational State of Bolivia", "Estado Plurinacional de Bolivia", "Buliwya Mamallaqta", "Wuliwya Suyu", "Tetã Volívia" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ARG, CountryCodeISO3.BRA, CountryCodeISO3.CHL, CountryCodeISO3.PRY, CountryCodeISO3.PER },
                    Landlocked = true,
                    Area = 1098581,
                };
            }
        }
        public static Country Brazil
        {
            get
            {
                return new Country
                {
                    CommonName = "Brazil",
                    OfficialName = "Federative Republic of Brazil",
                    TLD = new[] { ".br" },
                    CountryCode = CountryCode.BR,
                    ISONumeric = "076",
                    ISO3 = CountryCodeISO3.BRA,
                    CIOC = "BRA",
                    Currencies = new[] { "BRL" },
                    CallingCodes = new[] { "55" },
                    Capital = "Brasília",
                    AlternativeSpellings = new[] { "BR", "Brasil", "Federative Republic of Brazil", "República Federativa do Brasil" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ARG, CountryCodeISO3.BOL, CountryCodeISO3.COL, CountryCodeISO3.GUF, CountryCodeISO3.GUY, CountryCodeISO3.PRY, CountryCodeISO3.PER, CountryCodeISO3.SUR, CountryCodeISO3.URY, CountryCodeISO3.VEN },
                    Landlocked = false,
                    Area = 8515767,
                };
            }
        }
        public static Country Barbados
        {
            get
            {
                return new Country
                {
                    CommonName = "Barbados",
                    OfficialName = "Barbados",
                    TLD = new[] { ".bb" },
                    CountryCode = CountryCode.BB,
                    ISONumeric = "052",
                    ISO3 = CountryCodeISO3.BRB,
                    CIOC = "BAR",
                    Currencies = new[] { "BBD" },
                    CallingCodes = new[] { "1246" },
                    Capital = "Bridgetown",
                    AlternativeSpellings = new[] { "BB" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 430,
                };
            }
        }
        public static Country Brunei
        {
            get
            {
                return new Country
                {
                    CommonName = "Brunei",
                    OfficialName = "Nation of Brunei, Abode of Peace",
                    TLD = new[] { ".bn" },
                    CountryCode = CountryCode.BN,
                    ISONumeric = "096",
                    ISO3 = CountryCodeISO3.BRN,
                    CIOC = "BRU",
                    Currencies = new[] { "BND" },
                    CallingCodes = new[] { "673" },
                    Capital = "Bandar Seri Begawan",
                    AlternativeSpellings = new[] { "BN", "Brunei Darussalam", "Nation of Brunei", "the Abode of Peace" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.MYS },
                    Landlocked = false,
                    Area = 5765,
                };
            }
        }
        public static Country Bhutan
        {
            get
            {
                return new Country
                {
                    CommonName = "Bhutan",
                    OfficialName = "Kingdom of Bhutan",
                    TLD = new[] { ".bt" },
                    CountryCode = CountryCode.BT,
                    ISONumeric = "064",
                    ISO3 = CountryCodeISO3.BTN,
                    CIOC = "BHU",
                    Currencies = new[] { "BTN", "INR" },
                    CallingCodes = new[] { "975" },
                    Capital = "Thimphu",
                    AlternativeSpellings = new[] { "BT", "Kingdom of Bhutan" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CHN, CountryCodeISO3.IND },
                    Landlocked = true,
                    Area = 38394,
                };
            }
        }
        public static Country BouvetIsland
        {
            get
            {
                return new Country
                {
                    CommonName = "Bouvet Island",
                    OfficialName = "Bouvet Island",
                    TLD = new[] { ".bv" },
                    CountryCode = CountryCode.BV,
                    ISONumeric = "074",
                    ISO3 = CountryCodeISO3.BVT,
                    CIOC = "",
                    Currencies = new[] { "NOK" },
                    Capital = "",
                    AlternativeSpellings = new[] { "BV", "Bouvetøya", "Bouvet-øya" },
                    Region = "",
                    SubRegion = "",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 49,
                };
            }
        }
        public static Country Botswana
        {
            get
            {
                return new Country
                {
                    CommonName = "Botswana",
                    OfficialName = "Republic of Botswana",
                    TLD = new[] { ".bw" },
                    CountryCode = CountryCode.BW,
                    ISONumeric = "072",
                    ISO3 = CountryCodeISO3.BWA,
                    CIOC = "BOT",
                    Currencies = new[] { "BWP" },
                    CallingCodes = new[] { "267" },
                    Capital = "Gaborone",
                    AlternativeSpellings = new[] { "BW", "Republic of Botswana", "Lefatshe la Botswana" },
                    Region = "Africa",
                    SubRegion = "Southern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.NAM, CountryCodeISO3.ZAF, CountryCodeISO3.ZMB, CountryCodeISO3.ZWE },
                    Landlocked = true,
                    Area = 582000,
                };
            }
        }
        public static Country CentralAfricanRepublic
        {
            get
            {
                return new Country
                {
                    CommonName = "Central African Republic",
                    OfficialName = "Central African Republic",
                    TLD = new[] { ".cf" },
                    CountryCode = CountryCode.CF,
                    ISONumeric = "140",
                    ISO3 = CountryCodeISO3.CAF,
                    CIOC = "CAF",
                    Currencies = new[] { "XAF" },
                    CallingCodes = new[] { "236" },
                    Capital = "Bangui",
                    AlternativeSpellings = new[] { "CF", "Central African Republic", "République centrafricaine" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CMR, CountryCodeISO3.TCD, CountryCodeISO3.COD, CountryCodeISO3.COG, CountryCodeISO3.SSD, CountryCodeISO3.SDN },
                    Landlocked = true,
                    Area = 622984,
                };
            }
        }
        public static Country Canada
        {
            get
            {
                return new Country
                {
                    CommonName = "Canada",
                    OfficialName = "Canada",
                    TLD = new[] { ".ca" },
                    CountryCode = CountryCode.CA,
                    ISONumeric = "124",
                    ISO3 = CountryCodeISO3.CAN,
                    CIOC = "CAN",
                    Currencies = new[] { "CAD" },
                    CallingCodes = new[] { "1" },
                    Capital = "Ottawa",
                    AlternativeSpellings = new[] { "CA" },
                    Region = "Americas",
                    SubRegion = "Northern America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.USA },
                    Landlocked = false,
                    Area = 9984670,
                };
            }
        }
        public static Country CocosKeelingIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Cocos (Keeling) Islands",
                    OfficialName = "Territory of the Cocos (Keeling) Islands",
                    TLD = new[] { ".cc" },
                    CountryCode = CountryCode.CC,
                    ISONumeric = "166",
                    ISO3 = CountryCodeISO3.CCK,
                    CIOC = "",
                    Currencies = new[] { "AUD" },
                    CallingCodes = new[] { "61" },
                    Capital = "West Island",
                    AlternativeSpellings = new[] { "CC", "Territory of the Cocos (Keeling) Islands", "Keeling Islands" },
                    Region = "Oceania",
                    SubRegion = "Australia and New Zealand",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 14,
                };
            }
        }
        public static Country Switzerland
        {
            get
            {
                return new Country
                {
                    CommonName = "Switzerland",
                    OfficialName = "Swiss Confederation",
                    TLD = new[] { ".ch" },
                    CountryCode = CountryCode.CH,
                    ISONumeric = "756",
                    ISO3 = CountryCodeISO3.CHE,
                    CIOC = "SUI",
                    Currencies = new[] { "CHE", "CHF", "CHW" },
                    CallingCodes = new[] { "41" },
                    Capital = "Bern",
                    AlternativeSpellings = new[] { "CH", "Swiss Confederation", "Schweiz", "Suisse", "Svizzera", "Svizra" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AUT, CountryCodeISO3.FRA, CountryCodeISO3.ITA, CountryCodeISO3.LIE, CountryCodeISO3.DEU },
                    Landlocked = true,
                    Area = 41284,
                };
            }
        }
        public static Country Chile
        {
            get
            {
                return new Country
                {
                    CommonName = "Chile",
                    OfficialName = "Republic of Chile",
                    TLD = new[] { ".cl" },
                    CountryCode = CountryCode.CL,
                    ISONumeric = "152",
                    ISO3 = CountryCodeISO3.CHL,
                    CIOC = "CHI",
                    Currencies = new[] { "CLF", "CLP" },
                    CallingCodes = new[] { "56" },
                    Capital = "Santiago",
                    AlternativeSpellings = new[] { "CL", "Republic of Chile", "República de Chile" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ARG, CountryCodeISO3.BOL, CountryCodeISO3.PER },
                    Landlocked = false,
                    Area = 756102,
                };
            }
        }
        public static Country China
        {
            get
            {
                return new Country
                {
                    CommonName = "China",
                    OfficialName = "People's Republic of China",
                    TLD = new[] { ".cn", ".中国", ".中國", ".公司", ".网络" },
                    CountryCode = CountryCode.CN,
                    ISONumeric = "156",
                    ISO3 = CountryCodeISO3.CHN,
                    CIOC = "CHN",
                    Currencies = new[] { "CNY" },
                    CallingCodes = new[] { "86" },
                    Capital = "Beijing",
                    AlternativeSpellings = new[] { "CN", "Zhōngguó", "Zhongguo", "Zhonghua", "People's Republic of China", "中华人民共和国", "Zhōnghuá Rénmín Gònghéguó" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AFG, CountryCodeISO3.BTN, CountryCodeISO3.MMR, CountryCodeISO3.HKG, CountryCodeISO3.IND, CountryCodeISO3.KAZ, CountryCodeISO3.PRK, CountryCodeISO3.KGZ, CountryCodeISO3.LAO, CountryCodeISO3.MAC, CountryCodeISO3.MNG, CountryCodeISO3.PAK, CountryCodeISO3.RUS, CountryCodeISO3.TJK, CountryCodeISO3.VNM },
                    Landlocked = false,
                    Area = 9706961,
                };
            }
        }
        public static Country IvoryCoast
        {
            get
            {
                return new Country
                {
                    CommonName = "Ivory Coast",
                    OfficialName = "Republic of Côte d'Ivoire",
                    TLD = new[] { ".ci" },
                    CountryCode = CountryCode.CI,
                    ISONumeric = "384",
                    ISO3 = CountryCodeISO3.CIV,
                    CIOC = "CIV",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "225" },
                    Capital = "Yamoussoukro",
                    AlternativeSpellings = new[] { "CI", "Côte d'Ivoire", "Ivory Coast", "Republic of Côte d'Ivoire", "République de Côte d'Ivoire" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BFA, CountryCodeISO3.GHA, CountryCodeISO3.GIN, CountryCodeISO3.LBR, CountryCodeISO3.MLI },
                    Landlocked = false,
                    Area = 322463,
                };
            }
        }
        public static Country Cameroon
        {
            get
            {
                return new Country
                {
                    CommonName = "Cameroon",
                    OfficialName = "Republic of Cameroon",
                    TLD = new[] { ".cm" },
                    CountryCode = CountryCode.CM,
                    ISONumeric = "120",
                    ISO3 = CountryCodeISO3.CMR,
                    CIOC = "CMR",
                    Currencies = new[] { "XAF" },
                    CallingCodes = new[] { "237" },
                    Capital = "Yaoundé",
                    AlternativeSpellings = new[] { "CM", "Republic of Cameroon", "République du Cameroun" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CAF, CountryCodeISO3.TCD, CountryCodeISO3.COG, CountryCodeISO3.GNQ, CountryCodeISO3.GAB, CountryCodeISO3.NGA },
                    Landlocked = false,
                    Area = 475442,
                };
            }
        }
        public static Country DRCongo
        {
            get
            {
                return new Country
                {
                    CommonName = "DR Congo",
                    OfficialName = "Democratic Republic of the Congo",
                    TLD = new[] { ".cd" },
                    CountryCode = CountryCode.CD,
                    ISONumeric = "180",
                    ISO3 = CountryCodeISO3.COD,
                    CIOC = "COD",
                    Currencies = new[] { "CDF" },
                    CallingCodes = new[] { "243" },
                    Capital = "Kinshasa",
                    AlternativeSpellings = new[] { "CD", "DR Congo", "Congo-Kinshasa", "Congo, the Democratic Republic of the", "DRC" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AGO, CountryCodeISO3.BDI, CountryCodeISO3.CAF, CountryCodeISO3.COG, CountryCodeISO3.RWA, CountryCodeISO3.SSD, CountryCodeISO3.TZA, CountryCodeISO3.UGA, CountryCodeISO3.ZMB },
                    Landlocked = false,
                    Area = 2344858,
                };
            }
        }
        public static Country RepublicoftheCongo
        {
            get
            {
                return new Country
                {
                    CommonName = "Republic of the Congo",
                    OfficialName = "Republic of the Congo",
                    TLD = new[] { ".cg" },
                    CountryCode = CountryCode.CG,
                    ISONumeric = "178",
                    ISO3 = CountryCodeISO3.COG,
                    CIOC = "CGO",
                    Currencies = new[] { "XAF" },
                    CallingCodes = new[] { "242" },
                    Capital = "Brazzaville",
                    AlternativeSpellings = new[] { "CG", "Congo", "Congo-Brazzaville" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AGO, CountryCodeISO3.CMR, CountryCodeISO3.CAF, CountryCodeISO3.COD, CountryCodeISO3.GAB },
                    Landlocked = false,
                    Area = 342000,
                };
            }
        }
        public static Country CookIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Cook Islands",
                    OfficialName = "Cook Islands",
                    TLD = new[] { ".ck" },
                    CountryCode = CountryCode.CK,
                    ISONumeric = "184",
                    ISO3 = CountryCodeISO3.COK,
                    CIOC = "COK",
                    Currencies = new[] { "NZD" },
                    CallingCodes = new[] { "682" },
                    Capital = "Avarua",
                    AlternativeSpellings = new[] { "CK", "Kūki 'Āirani" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 236,
                };
            }
        }
        public static Country Colombia
        {
            get
            {
                return new Country
                {
                    CommonName = "Colombia",
                    OfficialName = "Republic of Colombia",
                    TLD = new[] { ".co" },
                    CountryCode = CountryCode.CO,
                    ISONumeric = "170",
                    ISO3 = CountryCodeISO3.COL,
                    CIOC = "COL",
                    Currencies = new[] { "COP" },
                    CallingCodes = new[] { "57" },
                    Capital = "Bogotá",
                    AlternativeSpellings = new[] { "CO", "Republic of Colombia", "República de Colombia" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BRA, CountryCodeISO3.ECU, CountryCodeISO3.PAN, CountryCodeISO3.PER, CountryCodeISO3.VEN },
                    Landlocked = false,
                    Area = 1141748,
                };
            }
        }
        public static Country Comoros
        {
            get
            {
                return new Country
                {
                    CommonName = "Comoros",
                    OfficialName = "Union of the Comoros",
                    TLD = new[] { ".km" },
                    CountryCode = CountryCode.KM,
                    ISONumeric = "174",
                    ISO3 = CountryCodeISO3.COM,
                    CIOC = "COM",
                    Currencies = new[] { "KMF" },
                    CallingCodes = new[] { "269" },
                    Capital = "Moroni",
                    AlternativeSpellings = new[] { "KM", "Union of the Comoros", "Union des Comores", "Udzima wa Komori", "al-Ittiḥād al-Qumurī" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 1862,
                };
            }
        }
        public static Country CapeVerde
        {
            get
            {
                return new Country
                {
                    CommonName = "Cape Verde",
                    OfficialName = "Republic of Cabo Verde",
                    TLD = new[] { ".cv" },
                    CountryCode = CountryCode.CV,
                    ISONumeric = "132",
                    ISO3 = CountryCodeISO3.CPV,
                    CIOC = "CPV",
                    Currencies = new[] { "CVE" },
                    CallingCodes = new[] { "238" },
                    Capital = "Praia",
                    AlternativeSpellings = new[] { "CV", "Republic of Cabo Verde", "República de Cabo Verde" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 4033,
                };
            }
        }
        public static Country CostaRica
        {
            get
            {
                return new Country
                {
                    CommonName = "Costa Rica",
                    OfficialName = "Republic of Costa Rica",
                    TLD = new[] { ".cr" },
                    CountryCode = CountryCode.CR,
                    ISONumeric = "188",
                    ISO3 = CountryCodeISO3.CRI,
                    CIOC = "CRC",
                    Currencies = new[] { "CRC" },
                    CallingCodes = new[] { "506" },
                    Capital = "San José",
                    AlternativeSpellings = new[] { "CR", "Republic of Costa Rica", "República de Costa Rica" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.NIC, CountryCodeISO3.PAN },
                    Landlocked = false,
                    Area = 51100,
                };
            }
        }
        public static Country Cuba
        {
            get
            {
                return new Country
                {
                    CommonName = "Cuba",
                    OfficialName = "Republic of Cuba",
                    TLD = new[] { ".cu" },
                    CountryCode = CountryCode.CU,
                    ISONumeric = "192",
                    ISO3 = CountryCodeISO3.CUB,
                    CIOC = "CUB",
                    Currencies = new[] { "CUC", "CUP" },
                    CallingCodes = new[] { "53" },
                    Capital = "Havana",
                    AlternativeSpellings = new[] { "CU", "Republic of Cuba", "República de Cuba" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 109884,
                };
            }
        }
        public static Country Curaçao
        {
            get
            {
                return new Country
                {
                    CommonName = "Curaçao",
                    OfficialName = "Country of Curaçao",
                    TLD = new[] { ".cw" },
                    CountryCode = CountryCode.CW,
                    ISONumeric = "531",
                    ISO3 = CountryCodeISO3.CUW,
                    CIOC = "",
                    Currencies = new[] { "ANG" },
                    CallingCodes = new[] { "5999" },
                    Capital = "Willemstad",
                    AlternativeSpellings = new[] { "CW", "Curacao", "Kòrsou", "Country of Curaçao", "Land Curaçao", "Pais Kòrsou" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 444,
                };
            }
        }
        public static Country ChristmasIsland
        {
            get
            {
                return new Country
                {
                    CommonName = "Christmas Island",
                    OfficialName = "Territory of Christmas Island",
                    TLD = new[] { ".cx" },
                    CountryCode = CountryCode.CX,
                    ISONumeric = "162",
                    ISO3 = CountryCodeISO3.CXR,
                    CIOC = "",
                    Currencies = new[] { "AUD" },
                    CallingCodes = new[] { "61" },
                    Capital = "Flying Fish Cove",
                    AlternativeSpellings = new[] { "CX", "Territory of Christmas Island" },
                    Region = "Oceania",
                    SubRegion = "Australia and New Zealand",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 135,
                };
            }
        }
        public static Country CaymanIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Cayman Islands",
                    OfficialName = "Cayman Islands",
                    TLD = new[] { ".ky" },
                    CountryCode = CountryCode.KY,
                    ISONumeric = "136",
                    ISO3 = CountryCodeISO3.CYM,
                    CIOC = "CAY",
                    Currencies = new[] { "KYD" },
                    CallingCodes = new[] { "1345" },
                    Capital = "George Town",
                    AlternativeSpellings = new[] { "KY" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 264,
                };
            }
        }
        public static Country Cyprus
        {
            get
            {
                return new Country
                {
                    CommonName = "Cyprus",
                    OfficialName = "Republic of Cyprus",
                    TLD = new[] { ".cy" },
                    CountryCode = CountryCode.CY,
                    ISONumeric = "196",
                    ISO3 = CountryCodeISO3.CYP,
                    CIOC = "CYP",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "357" },
                    Capital = "Nicosia",
                    AlternativeSpellings = new[] { "CY", "Kýpros", "Kıbrıs", "Republic of Cyprus", "Κυπριακή Δημοκρατία", "Kıbrıs Cumhuriyeti" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.GBR },
                    Landlocked = false,
                    Area = 9251,
                };
            }
        }
        public static Country CzechRepublic
        {
            get
            {
                return new Country
                {
                    CommonName = "Czech Republic",
                    OfficialName = "Czech Republic",
                    TLD = new[] { ".cz" },
                    CountryCode = CountryCode.CZ,
                    ISONumeric = "203",
                    ISO3 = CountryCodeISO3.CZE,
                    CIOC = "CZE",
                    Currencies = new[] { "CZK" },
                    CallingCodes = new[] { "420" },
                    Capital = "Prague",
                    AlternativeSpellings = new[] { "CZ", "Česká republika", "Česko" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AUT, CountryCodeISO3.DEU, CountryCodeISO3.POL, CountryCodeISO3.SVK },
                    Landlocked = true,
                    Area = 78865,
                };
            }
        }
        public static Country Germany
        {
            get
            {
                return new Country
                {
                    CommonName = "Germany",
                    OfficialName = "Federal Republic of Germany",
                    TLD = new[] { ".de" },
                    CountryCode = CountryCode.DE,
                    ISONumeric = "276",
                    ISO3 = CountryCodeISO3.DEU,
                    CIOC = "GER",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "49" },
                    Capital = "Berlin",
                    AlternativeSpellings = new[] { "DE", "Federal Republic of Germany", "Bundesrepublik Deutschland" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AUT, CountryCodeISO3.BEL, CountryCodeISO3.CZE, CountryCodeISO3.DNK, CountryCodeISO3.FRA, CountryCodeISO3.LUX, CountryCodeISO3.NLD, CountryCodeISO3.POL, CountryCodeISO3.CHE },
                    Landlocked = false,
                    Area = 357114,
                };
            }
        }
        public static Country Djibouti
        {
            get
            {
                return new Country
                {
                    CommonName = "Djibouti",
                    OfficialName = "Republic of Djibouti",
                    TLD = new[] { ".dj" },
                    CountryCode = CountryCode.DJ,
                    ISONumeric = "262",
                    ISO3 = CountryCodeISO3.DJI,
                    CIOC = "DJI",
                    Currencies = new[] { "DJF" },
                    CallingCodes = new[] { "253" },
                    Capital = "Djibouti",
                    AlternativeSpellings = new[] { "DJ", "Jabuuti", "Gabuuti", "Republic of Djibouti", "République de Djibouti", "Gabuutih Ummuuno", "Jamhuuriyadda Jabuuti" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ERI, CountryCodeISO3.ETH, CountryCodeISO3.SOM },
                    Landlocked = false,
                    Area = 23200,
                };
            }
        }
        public static Country Dominica
        {
            get
            {
                return new Country
                {
                    CommonName = "Dominica",
                    OfficialName = "Commonwealth of Dominica",
                    TLD = new[] { ".dm" },
                    CountryCode = CountryCode.DM,
                    ISONumeric = "212",
                    ISO3 = CountryCodeISO3.DMA,
                    CIOC = "DMA",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1767" },
                    Capital = "Roseau",
                    AlternativeSpellings = new[] { "DM", "Dominique", "Wai‘tu kubuli", "Commonwealth of Dominica" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 751,
                };
            }
        }
        public static Country Denmark
        {
            get
            {
                return new Country
                {
                    CommonName = "Denmark",
                    OfficialName = "Kingdom of Denmark",
                    TLD = new[] { ".dk" },
                    CountryCode = CountryCode.DK,
                    ISONumeric = "208",
                    ISO3 = CountryCodeISO3.DNK,
                    CIOC = "DEN",
                    Currencies = new[] { "DKK" },
                    CallingCodes = new[] { "45" },
                    Capital = "Copenhagen",
                    AlternativeSpellings = new[] { "DK", "Danmark", "Kingdom of Denmark", "Kongeriget Danmark" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.DEU },
                    Landlocked = false,
                    Area = 43094,
                };
            }
        }
        public static Country DominicanRepublic
        {
            get
            {
                return new Country
                {
                    CommonName = "Dominican Republic",
                    OfficialName = "Dominican Republic",
                    TLD = new[] { ".do" },
                    CountryCode = CountryCode.DO,
                    ISONumeric = "214",
                    ISO3 = CountryCodeISO3.DOM,
                    CIOC = "DOM",
                    Currencies = new[] { "DOP" },
                    CallingCodes = new[] { "1809", "1829", "1849" },
                    Capital = "Santo Domingo",
                    AlternativeSpellings = new[] { "DO" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.HTI },
                    Landlocked = false,
                    Area = 48671,
                };
            }
        }
        public static Country Algeria
        {
            get
            {
                return new Country
                {
                    CommonName = "Algeria",
                    OfficialName = "People's Democratic Republic of Algeria",
                    TLD = new[] { ".dz", "الجزائر." },
                    CountryCode = CountryCode.DZ,
                    ISONumeric = "012",
                    ISO3 = CountryCodeISO3.DZA,
                    CIOC = "ALG",
                    Currencies = new[] { "DZD" },
                    CallingCodes = new[] { "213" },
                    Capital = "Algiers",
                    AlternativeSpellings = new[] { "DZ", "Dzayer", "Algérie" },
                    Region = "Africa",
                    SubRegion = "Northern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.TUN, CountryCodeISO3.LBY, CountryCodeISO3.NER, CountryCodeISO3.ESH, CountryCodeISO3.MRT, CountryCodeISO3.MLI, CountryCodeISO3.MAR },
                    Landlocked = false,
                    Area = 2381741,
                };
            }
        }
        public static Country Ecuador
        {
            get
            {
                return new Country
                {
                    CommonName = "Ecuador",
                    OfficialName = "Republic of Ecuador",
                    TLD = new[] { ".ec" },
                    CountryCode = CountryCode.EC,
                    ISONumeric = "218",
                    ISO3 = CountryCodeISO3.ECU,
                    CIOC = "ECU",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "593" },
                    Capital = "Quito",
                    AlternativeSpellings = new[] { "EC", "Republic of Ecuador", "República del Ecuador" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.COL, CountryCodeISO3.PER },
                    Landlocked = false,
                    Area = 276841,
                };
            }
        }
        public static Country Egypt
        {
            get
            {
                return new Country
                {
                    CommonName = "Egypt",
                    OfficialName = "Arab Republic of Egypt",
                    TLD = new[] { ".eg", ".مصر" },
                    CountryCode = CountryCode.EG,
                    ISONumeric = "818",
                    ISO3 = CountryCodeISO3.EGY,
                    CIOC = "EGY",
                    Currencies = new[] { "EGP" },
                    CallingCodes = new[] { "20" },
                    Capital = "Cairo",
                    AlternativeSpellings = new[] { "EG", "Arab Republic of Egypt" },
                    Region = "Africa",
                    SubRegion = "Northern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ISR, CountryCodeISO3.LBY, CountryCodeISO3.SDN },
                    Landlocked = false,
                    Area = 1002450,
                };
            }
        }
        public static Country Eritrea
        {
            get
            {
                return new Country
                {
                    CommonName = "Eritrea",
                    OfficialName = "State of Eritrea",
                    TLD = new[] { ".er" },
                    CountryCode = CountryCode.ER,
                    ISONumeric = "232",
                    ISO3 = CountryCodeISO3.ERI,
                    CIOC = "ERI",
                    Currencies = new[] { "ERN" },
                    CallingCodes = new[] { "291" },
                    Capital = "Asmara",
                    AlternativeSpellings = new[] { "ER", "State of Eritrea", "ሃገረ ኤርትራ", "Dawlat Iritriyá", "ʾErtrā", "Iritriyā", "" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.DJI, CountryCodeISO3.ETH, CountryCodeISO3.SDN },
                    Landlocked = false,
                    Area = 117600,
                };
            }
        }
        public static Country WesternSahara
        {
            get
            {
                return new Country
                {
                    CommonName = "Western Sahara",
                    OfficialName = "Sahrawi Arab Democratic Republic",
                    TLD = new[] { ".eh" },
                    CountryCode = CountryCode.EH,
                    ISONumeric = "732",
                    ISO3 = CountryCodeISO3.ESH,
                    CIOC = "",
                    Currencies = new[] { "MAD", "DZD", "MRO" },
                    CallingCodes = new[] { "212" },
                    Capital = "El Aaiún",
                    AlternativeSpellings = new[] { "EH", "Taneẓroft Tutrimt" },
                    Region = "Africa",
                    SubRegion = "Northern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.DZA, CountryCodeISO3.MRT, CountryCodeISO3.MAR },
                    Landlocked = false,
                    Area = 266000,
                };
            }
        }
        public static Country Spain
        {
            get
            {
                return new Country
                {
                    CommonName = "Spain",
                    OfficialName = "Kingdom of Spain",
                    TLD = new[] { ".es" },
                    CountryCode = CountryCode.ES,
                    ISONumeric = "724",
                    ISO3 = CountryCodeISO3.ESP,
                    CIOC = "ESP",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "34" },
                    Capital = "Madrid",
                    AlternativeSpellings = new[] { "ES", "Kingdom of Spain", "Reino de España" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AND, CountryCodeISO3.FRA, CountryCodeISO3.GIB, CountryCodeISO3.PRT, CountryCodeISO3.MAR },
                    Landlocked = false,
                    Area = 505992,
                };
            }
        }
        public static Country Estonia
        {
            get
            {
                return new Country
                {
                    CommonName = "Estonia",
                    OfficialName = "Republic of Estonia",
                    TLD = new[] { ".ee" },
                    CountryCode = CountryCode.EE,
                    ISONumeric = "233",
                    ISO3 = CountryCodeISO3.EST,
                    CIOC = "EST",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "372" },
                    Capital = "Tallinn",
                    AlternativeSpellings = new[] { "EE", "Eesti", "Republic of Estonia", "Eesti Vabariik" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.LVA, CountryCodeISO3.RUS },
                    Landlocked = false,
                    Area = 45227,
                };
            }
        }
        public static Country Ethiopia
        {
            get
            {
                return new Country
                {
                    CommonName = "Ethiopia",
                    OfficialName = "Federal Democratic Republic of Ethiopia",
                    TLD = new[] { ".et" },
                    CountryCode = CountryCode.ET,
                    ISONumeric = "231",
                    ISO3 = CountryCodeISO3.ETH,
                    CIOC = "ETH",
                    Currencies = new[] { "ETB" },
                    CallingCodes = new[] { "251" },
                    Capital = "Addis Ababa",
                    AlternativeSpellings = new[] { "ET", "ʾĪtyōṗṗyā", "Federal Democratic Republic of Ethiopia", "የኢትዮጵያ ፌዴራላዊ ዲሞክራሲያዊ ሪፐብሊክ" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.DJI, CountryCodeISO3.ERI, CountryCodeISO3.KEN, CountryCodeISO3.SOM, CountryCodeISO3.SSD, CountryCodeISO3.SDN },
                    Landlocked = true,
                    Area = 1104300,
                };
            }
        }
        public static Country Finland
        {
            get
            {
                return new Country
                {
                    CommonName = "Finland",
                    OfficialName = "Republic of Finland",
                    TLD = new[] { ".fi" },
                    CountryCode = CountryCode.FI,
                    ISONumeric = "246",
                    ISO3 = CountryCodeISO3.FIN,
                    CIOC = "FIN",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "358" },
                    Capital = "Helsinki",
                    AlternativeSpellings = new[] { "FI", "Suomi", "Republic of Finland", "Suomen tasavalta", "Republiken Finland" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.NOR, CountryCodeISO3.SWE, CountryCodeISO3.RUS },
                    Landlocked = false,
                    Area = 338424,
                };
            }
        }
        public static Country Fiji
        {
            get
            {
                return new Country
                {
                    CommonName = "Fiji",
                    OfficialName = "Republic of Fiji",
                    TLD = new[] { ".fj" },
                    CountryCode = CountryCode.FJ,
                    ISONumeric = "242",
                    ISO3 = CountryCodeISO3.FJI,
                    CIOC = "FIJ",
                    Currencies = new[] { "FJD" },
                    CallingCodes = new[] { "679" },
                    Capital = "Suva",
                    AlternativeSpellings = new[] { "FJ", "Viti", "Republic of Fiji", "Matanitu ko Viti", "Fijī Gaṇarājya" },
                    Region = "Oceania",
                    SubRegion = "Melanesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 18272,
                };
            }
        }
        public static Country FalklandIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Falkland Islands",
                    OfficialName = "Falkland Islands",
                    TLD = new[] { ".fk" },
                    CountryCode = CountryCode.FK,
                    ISONumeric = "238",
                    ISO3 = CountryCodeISO3.FLK,
                    CIOC = "",
                    Currencies = new[] { "FKP" },
                    CallingCodes = new[] { "500" },
                    Capital = "Stanley",
                    AlternativeSpellings = new[] { "FK", "Islas Malvinas", "Falkland Islands (Malvinas)" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 12173,
                };
            }
        }
        public static Country France
        {
            get
            {
                return new Country
                {
                    CommonName = "France",
                    OfficialName = "French Republic",
                    TLD = new[] { ".fr" },
                    CountryCode = CountryCode.FR,
                    ISONumeric = "250",
                    ISO3 = CountryCodeISO3.FRA,
                    CIOC = "FRA",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "33" },
                    Capital = "Paris",
                    AlternativeSpellings = new[] { "FR", "French Republic", "République française" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AND, CountryCodeISO3.BEL, CountryCodeISO3.DEU, CountryCodeISO3.ITA, CountryCodeISO3.LUX, CountryCodeISO3.MCO, CountryCodeISO3.ESP, CountryCodeISO3.CHE },
                    Landlocked = false,
                    Area = 551695,
                };
            }
        }
        public static Country FaroeIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Faroe Islands",
                    OfficialName = "Faroe Islands",
                    TLD = new[] { ".fo" },
                    CountryCode = CountryCode.FO,
                    ISONumeric = "234",
                    ISO3 = CountryCodeISO3.FRO,
                    CIOC = "",
                    Currencies = new[] { "DKK" },
                    CallingCodes = new[] { "298" },
                    Capital = "Tórshavn",
                    AlternativeSpellings = new[] { "FO", "Føroyar", "Færøerne" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 1393,
                };
            }
        }
        public static Country Micronesia
        {
            get
            {
                return new Country
                {
                    CommonName = "Micronesia",
                    OfficialName = "Federated States of Micronesia",
                    TLD = new[] { ".fm" },
                    CountryCode = CountryCode.FM,
                    ISONumeric = "583",
                    ISO3 = CountryCodeISO3.FSM,
                    CIOC = "FSM",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "691" },
                    Capital = "Palikir",
                    AlternativeSpellings = new[] { "FM", "Federated States of Micronesia", "Micronesia, Federated States of" },
                    Region = "Oceania",
                    SubRegion = "Micronesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 702,
                };
            }
        }
        public static Country Gabon
        {
            get
            {
                return new Country
                {
                    CommonName = "Gabon",
                    OfficialName = "Gabonese Republic",
                    TLD = new[] { ".ga" },
                    CountryCode = CountryCode.GA,
                    ISONumeric = "266",
                    ISO3 = CountryCodeISO3.GAB,
                    CIOC = "GAB",
                    Currencies = new[] { "XAF" },
                    CallingCodes = new[] { "241" },
                    Capital = "Libreville",
                    AlternativeSpellings = new[] { "GA", "Gabonese Republic", "République Gabonaise" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CMR, CountryCodeISO3.COG, CountryCodeISO3.GNQ },
                    Landlocked = false,
                    Area = 267668,
                };
            }
        }
        public static Country UnitedKingdom
        {
            get
            {
                return new Country
                {
                    CommonName = "United Kingdom",
                    OfficialName = "United Kingdom of Great Britain and Northern Ireland",
                    TLD = new[] { ".uk" },
                    CountryCode = CountryCode.UK,
                    ISONumeric = "826",
                    ISO3 = CountryCodeISO3.GBR,
                    CIOC = "GBR",
                    Currencies = new[] { "GBP" },
                    CallingCodes = new[] { "44" },
                    Capital = "London",
                    AlternativeSpellings = new[] { "GB", "UK", "Great Britain" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.IRL },
                    Landlocked = false,
                    Area = 242900,
                };
            }
        }
        public static Country Georgia
        {
            get
            {
                return new Country
                {
                    CommonName = "Georgia",
                    OfficialName = "Georgia",
                    TLD = new[] { ".ge" },
                    CountryCode = CountryCode.GE,
                    ISONumeric = "268",
                    ISO3 = CountryCodeISO3.GEO,
                    CIOC = "GEO",
                    Currencies = new[] { "GEL" },
                    CallingCodes = new[] { "995" },
                    Capital = "Tbilisi",
                    AlternativeSpellings = new[] { "GE", "Sakartvelo" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ARM, CountryCodeISO3.AZE, CountryCodeISO3.RUS, CountryCodeISO3.TUR },
                    Landlocked = false,
                    Area = 69700,
                };
            }
        }
        public static Country Guernsey
        {
            get
            {
                return new Country
                {
                    CommonName = "Guernsey",
                    OfficialName = "Bailiwick of Guernsey",
                    TLD = new[] { ".gg" },
                    CountryCode = CountryCode.GG,
                    ISONumeric = "831",
                    ISO3 = CountryCodeISO3.GGY,
                    CIOC = "",
                    Currencies = new[] { "GBP" },
                    CallingCodes = new[] { "44" },
                    Capital = "St. Peter Port",
                    AlternativeSpellings = new[] { "GG", "Bailiwick of Guernsey", "Bailliage de Guernesey" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 78,
                };
            }
        }
        public static Country Ghana
        {
            get
            {
                return new Country
                {
                    CommonName = "Ghana",
                    OfficialName = "Republic of Ghana",
                    TLD = new[] { ".gh" },
                    CountryCode = CountryCode.GH,
                    ISONumeric = "288",
                    ISO3 = CountryCodeISO3.GHA,
                    CIOC = "GHA",
                    Currencies = new[] { "GHS" },
                    CallingCodes = new[] { "233" },
                    Capital = "Accra",
                    AlternativeSpellings = new[] { "GH" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BFA, CountryCodeISO3.CIV, CountryCodeISO3.TGO },
                    Landlocked = false,
                    Area = 238533,
                };
            }
        }
        public static Country Gibraltar
        {
            get
            {
                return new Country
                {
                    CommonName = "Gibraltar",
                    OfficialName = "Gibraltar",
                    TLD = new[] { ".gi" },
                    CountryCode = CountryCode.GI,
                    ISONumeric = "292",
                    ISO3 = CountryCodeISO3.GIB,
                    CIOC = "",
                    Currencies = new[] { "GIP" },
                    CallingCodes = new[] { "350" },
                    Capital = "Gibraltar",
                    AlternativeSpellings = new[] { "GI" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ESP },
                    Landlocked = false,
                    Area = 6,
                };
            }
        }
        public static Country Guinea
        {
            get
            {
                return new Country
                {
                    CommonName = "Guinea",
                    OfficialName = "Republic of Guinea",
                    TLD = new[] { ".gn" },
                    CountryCode = CountryCode.GN,
                    ISONumeric = "324",
                    ISO3 = CountryCodeISO3.GIN,
                    CIOC = "GUI",
                    Currencies = new[] { "GNF" },
                    CallingCodes = new[] { "224" },
                    Capital = "Conakry",
                    AlternativeSpellings = new[] { "GN", "Republic of Guinea", "République de Guinée" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CIV, CountryCodeISO3.GNB, CountryCodeISO3.LBR, CountryCodeISO3.MLI, CountryCodeISO3.SEN, CountryCodeISO3.SLE },
                    Landlocked = false,
                    Area = 245857,
                };
            }
        }
        public static Country Guadeloupe
        {
            get
            {
                return new Country
                {
                    CommonName = "Guadeloupe",
                    OfficialName = "Guadeloupe",
                    TLD = new[] { ".gp" },
                    CountryCode = CountryCode.GP,
                    ISONumeric = "312",
                    ISO3 = CountryCodeISO3.GLP,
                    CIOC = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "590" },
                    Capital = "Basse-Terre",
                    AlternativeSpellings = new[] { "GP", "Gwadloup" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 1628,
                };
            }
        }
        public static Country Gambia
        {
            get
            {
                return new Country
                {
                    CommonName = "Gambia",
                    OfficialName = "Republic of the Gambia",
                    TLD = new[] { ".gm" },
                    CountryCode = CountryCode.GM,
                    ISONumeric = "270",
                    ISO3 = CountryCodeISO3.GMB,
                    CIOC = "GAM",
                    Currencies = new[] { "GMD" },
                    CallingCodes = new[] { "220" },
                    Capital = "Banjul",
                    AlternativeSpellings = new[] { "GM", "Republic of the Gambia" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.SEN },
                    Landlocked = false,
                    Area = 10689,
                };
            }
        }
        public static Country GuineaBissau
        {
            get
            {
                return new Country
                {
                    CommonName = "Guinea-Bissau",
                    OfficialName = "Republic of Guinea-Bissau",
                    TLD = new[] { ".gw" },
                    CountryCode = CountryCode.GW,
                    ISONumeric = "624",
                    ISO3 = CountryCodeISO3.GNB,
                    CIOC = "GBS",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "245" },
                    Capital = "Bissau",
                    AlternativeSpellings = new[] { "GW", "Republic of Guinea-Bissau", "República da Guiné-Bissau" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.GIN, CountryCodeISO3.SEN },
                    Landlocked = false,
                    Area = 36125,
                };
            }
        }
        public static Country EquatorialGuinea
        {
            get
            {
                return new Country
                {
                    CommonName = "Equatorial Guinea",
                    OfficialName = "Republic of Equatorial Guinea",
                    TLD = new[] { ".gq" },
                    CountryCode = CountryCode.GQ,
                    ISONumeric = "226",
                    ISO3 = CountryCodeISO3.GNQ,
                    CIOC = "GEQ",
                    Currencies = new[] { "XAF" },
                    CallingCodes = new[] { "240" },
                    Capital = "Malabo",
                    AlternativeSpellings = new[] { "GQ", "Republic of Equatorial Guinea", "República de Guinea Ecuatorial", "République de Guinée équatoriale", "República da Guiné Equatorial" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CMR, CountryCodeISO3.GAB },
                    Landlocked = false,
                    Area = 28051,
                };
            }
        }
        public static Country Greece
        {
            get
            {
                return new Country
                {
                    CommonName = "Greece",
                    OfficialName = "Hellenic Republic",
                    TLD = new[] { ".gr" },
                    CountryCode = CountryCode.GR,
                    ISONumeric = "300",
                    ISO3 = CountryCodeISO3.GRC,
                    CIOC = "GRE",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "30" },
                    Capital = "Athens",
                    AlternativeSpellings = new[] { "GR", "Elláda", "Hellenic Republic", "Ελληνική Δημοκρατία" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ALB, CountryCodeISO3.BGR, CountryCodeISO3.TUR, CountryCodeISO3.MKD },
                    Landlocked = false,
                    Area = 131990,
                };
            }
        }
        public static Country Grenada
        {
            get
            {
                return new Country
                {
                    CommonName = "Grenada",
                    OfficialName = "Grenada",
                    TLD = new[] { ".gd" },
                    CountryCode = CountryCode.GD,
                    ISONumeric = "308",
                    ISO3 = CountryCodeISO3.GRD,
                    CIOC = "GRN",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1473" },
                    Capital = "St. George's",
                    AlternativeSpellings = new[] { "GD" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 344,
                };
            }
        }
        public static Country Greenland
        {
            get
            {
                return new Country
                {
                    CommonName = "Greenland",
                    OfficialName = "Greenland",
                    TLD = new[] { ".gl" },
                    CountryCode = CountryCode.GL,
                    ISONumeric = "304",
                    ISO3 = CountryCodeISO3.GRL,
                    CIOC = "",
                    Currencies = new[] { "DKK" },
                    CallingCodes = new[] { "299" },
                    Capital = "Nuuk",
                    AlternativeSpellings = new[] { "GL", "Grønland" },
                    Region = "Americas",
                    SubRegion = "Northern America",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 2166086,
                };
            }
        }
        public static Country Guatemala
        {
            get
            {
                return new Country
                {
                    CommonName = "Guatemala",
                    OfficialName = "Republic of Guatemala",
                    TLD = new[] { ".gt" },
                    CountryCode = CountryCode.GT,
                    ISONumeric = "320",
                    ISO3 = CountryCodeISO3.GTM,
                    CIOC = "GUA",
                    Currencies = new[] { "GTQ" },
                    CallingCodes = new[] { "502" },
                    Capital = "Guatemala City",
                    AlternativeSpellings = new[] { "GT" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BLZ, CountryCodeISO3.SLV, CountryCodeISO3.HND, CountryCodeISO3.MEX },
                    Landlocked = false,
                    Area = 108889,
                };
            }
        }
        public static Country FrenchGuiana
        {
            get
            {
                return new Country
                {
                    CommonName = "French Guiana",
                    OfficialName = "Guiana",
                    TLD = new[] { ".gf" },
                    CountryCode = CountryCode.GF,
                    ISONumeric = "254",
                    ISO3 = CountryCodeISO3.GUF,
                    CIOC = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "594" },
                    Capital = "Cayenne",
                    AlternativeSpellings = new[] { "GF", "Guiana", "Guyane" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BRA, CountryCodeISO3.SUR },
                    Landlocked = false,
                    Area = 83534,
                };
            }
        }
        public static Country Guam
        {
            get
            {
                return new Country
                {
                    CommonName = "Guam",
                    OfficialName = "Guam",
                    TLD = new[] { ".gu" },
                    CountryCode = CountryCode.GU,
                    ISONumeric = "316",
                    ISO3 = CountryCodeISO3.GUM,
                    CIOC = "GUM",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "1671" },
                    Capital = "Hagåtña",
                    AlternativeSpellings = new[] { "GU", "Guåhån" },
                    Region = "Oceania",
                    SubRegion = "Micronesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 549,
                };
            }
        }
        public static Country Guyana
        {
            get
            {
                return new Country
                {
                    CommonName = "Guyana",
                    OfficialName = "Co-operative Republic of Guyana",
                    TLD = new[] { ".gy" },
                    CountryCode = CountryCode.GY,
                    ISONumeric = "328",
                    ISO3 = CountryCodeISO3.GUY,
                    CIOC = "GUY",
                    Currencies = new[] { "GYD" },
                    CallingCodes = new[] { "592" },
                    Capital = "Georgetown",
                    AlternativeSpellings = new[] { "GY", "Co-operative Republic of Guyana" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BRA, CountryCodeISO3.SUR, CountryCodeISO3.VEN },
                    Landlocked = false,
                    Area = 214969,
                };
            }
        }
        public static Country HongKong
        {
            get
            {
                return new Country
                {
                    CommonName = "Hong Kong",
                    OfficialName = "Hong Kong Special Administrative Region of the People's Republic of China",
                    TLD = new[] { ".hk", ".香港" },
                    CountryCode = CountryCode.HK,
                    ISONumeric = "344",
                    ISO3 = CountryCodeISO3.HKG,
                    CIOC = "HKG",
                    Currencies = new[] { "HKD" },
                    CallingCodes = new[] { "852" },
                    Capital = "City of Victoria",
                    AlternativeSpellings = new[] { "HK" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CHN },
                    Landlocked = false,
                    Area = 1104,
                };
            }
        }
        public static Country HeardIslandandMcDonaldIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Heard Island and McDonald Islands",
                    OfficialName = "Heard Island and McDonald Islands",
                    TLD = new[] { ".hm", ".aq" },
                    CountryCode = CountryCode.HM,
                    ISONumeric = "334",
                    ISO3 = CountryCodeISO3.HMD,
                    CIOC = "",
                    Currencies = new[] { "AUD" },
                    Capital = "",
                    AlternativeSpellings = new[] { "HM", "Heard Island and McDonald Mcdonald Islands" },
                    Region = "",
                    SubRegion = "",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 412,
                };
            }
        }
        public static Country Honduras
        {
            get
            {
                return new Country
                {
                    CommonName = "Honduras",
                    OfficialName = "Republic of Honduras",
                    TLD = new[] { ".hn" },
                    CountryCode = CountryCode.HN,
                    ISONumeric = "340",
                    ISO3 = CountryCodeISO3.HND,
                    CIOC = "HON",
                    Currencies = new[] { "HNL" },
                    CallingCodes = new[] { "504" },
                    Capital = "Tegucigalpa",
                    AlternativeSpellings = new[] { "HN", "Republic of Honduras", "República de Honduras" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.GTM, CountryCodeISO3.SLV, CountryCodeISO3.NIC },
                    Landlocked = false,
                    Area = 112492,
                };
            }
        }
        public static Country Croatia
        {
            get
            {
                return new Country
                {
                    CommonName = "Croatia",
                    OfficialName = "Republic of Croatia",
                    TLD = new[] { ".hr" },
                    CountryCode = CountryCode.HR,
                    ISONumeric = "191",
                    ISO3 = CountryCodeISO3.HRV,
                    CIOC = "CRO",
                    Currencies = new[] { "HRK" },
                    CallingCodes = new[] { "385" },
                    Capital = "Zagreb",
                    AlternativeSpellings = new[] { "HR", "Hrvatska", "Republic of Croatia", "Republika Hrvatska" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BIH, CountryCodeISO3.HUN, CountryCodeISO3.MNE, CountryCodeISO3.SRB, CountryCodeISO3.SVN },
                    Landlocked = false,
                    Area = 56594,
                };
            }
        }
        public static Country Haiti
        {
            get
            {
                return new Country
                {
                    CommonName = "Haiti",
                    OfficialName = "Republic of Haiti",
                    TLD = new[] { ".ht" },
                    CountryCode = CountryCode.HT,
                    ISONumeric = "332",
                    ISO3 = CountryCodeISO3.HTI,
                    CIOC = "HAI",
                    Currencies = new[] { "HTG", "USD" },
                    CallingCodes = new[] { "509" },
                    Capital = "Port-au-Prince",
                    AlternativeSpellings = new[] { "HT", "Republic of Haiti", "République d'Haïti", "Repiblik Ayiti" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.DOM },
                    Landlocked = false,
                    Area = 27750,
                };
            }
        }
        public static Country Hungary
        {
            get
            {
                return new Country
                {
                    CommonName = "Hungary",
                    OfficialName = "Hungary",
                    TLD = new[] { ".hu" },
                    CountryCode = CountryCode.HU,
                    ISONumeric = "348",
                    ISO3 = CountryCodeISO3.HUN,
                    CIOC = "HUN",
                    Currencies = new[] { "HUF" },
                    CallingCodes = new[] { "36" },
                    Capital = "Budapest",
                    AlternativeSpellings = new[] { "HU" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AUT, CountryCodeISO3.HRV, CountryCodeISO3.ROU, CountryCodeISO3.SRB, CountryCodeISO3.SVK, CountryCodeISO3.SVN, CountryCodeISO3.UKR },
                    Landlocked = true,
                    Area = 93028,
                };
            }
        }
        public static Country Indonesia
        {
            get
            {
                return new Country
                {
                    CommonName = "Indonesia",
                    OfficialName = "Republic of Indonesia",
                    TLD = new[] { ".id" },
                    CountryCode = CountryCode.ID,
                    ISONumeric = "360",
                    ISO3 = CountryCodeISO3.IDN,
                    CIOC = "INA",
                    Currencies = new[] { "IDR" },
                    CallingCodes = new[] { "62" },
                    Capital = "Jakarta",
                    AlternativeSpellings = new[] { "ID", "Republic of Indonesia", "Republik Indonesia" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.TLS, CountryCodeISO3.MYS, CountryCodeISO3.PNG },
                    Landlocked = false,
                    Area = 1904569,
                };
            }
        }
        public static Country IsleofMan
        {
            get
            {
                return new Country
                {
                    CommonName = "Isle of Man",
                    OfficialName = "Isle of Man",
                    TLD = new[] { ".im" },
                    CountryCode = CountryCode.IM,
                    ISONumeric = "833",
                    ISO3 = CountryCodeISO3.IMN,
                    CIOC = "",
                    Currencies = new[] { "GBP" },
                    CallingCodes = new[] { "44" },
                    Capital = "Douglas",
                    AlternativeSpellings = new[] { "IM", "Ellan Vannin", "Mann", "Mannin" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 572,
                };
            }
        }
        public static Country India
        {
            get
            {
                return new Country
                {
                    CommonName = "India",
                    OfficialName = "Republic of India",
                    TLD = new[] { ".in" },
                    CountryCode = CountryCode.IN,
                    ISONumeric = "356",
                    ISO3 = CountryCodeISO3.IND,
                    CIOC = "IND",
                    Currencies = new[] { "INR" },
                    CallingCodes = new[] { "91" },
                    Capital = "New Delhi",
                    AlternativeSpellings = new[] { "IN", "Bhārat", "Republic of India", "Bharat Ganrajya", "இந்தியா" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AFG, CountryCodeISO3.BGD, CountryCodeISO3.BTN, CountryCodeISO3.MMR, CountryCodeISO3.CHN, CountryCodeISO3.NPL, CountryCodeISO3.PAK, CountryCodeISO3.LKA },
                    Landlocked = false,
                    Area = 3287590,
                };
            }
        }
        public static Country BritishIndianOceanTerritory
        {
            get
            {
                return new Country
                {
                    CommonName = "British Indian Ocean Territory",
                    OfficialName = "British Indian Ocean Territory",
                    TLD = new[] { ".io" },
                    CountryCode = CountryCode.IO,
                    ISONumeric = "086",
                    ISO3 = CountryCodeISO3.IOT,
                    CIOC = "",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "246" },
                    Capital = "Diego Garcia",
                    AlternativeSpellings = new[] { "IO" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 60,
                };
            }
        }
        public static Country Ireland
        {
            get
            {
                return new Country
                {
                    CommonName = "Ireland",
                    OfficialName = "Republic of Ireland",
                    TLD = new[] { ".ie" },
                    CountryCode = CountryCode.IE,
                    ISONumeric = "372",
                    ISO3 = CountryCodeISO3.IRL,
                    CIOC = "IRL",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "353" },
                    Capital = "Dublin",
                    AlternativeSpellings = new[] { "IE", "Éire", "Republic of Ireland", "Poblacht na hÉireann" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.GBR },
                    Landlocked = false,
                    Area = 70273,
                };
            }
        }
        public static Country Iran
        {
            get
            {
                return new Country
                {
                    CommonName = "Iran",
                    OfficialName = "Islamic Republic of Iran",
                    TLD = new[] { ".ir", "ایران." },
                    CountryCode = CountryCode.IR,
                    ISONumeric = "364",
                    ISO3 = CountryCodeISO3.IRN,
                    CIOC = "IRI",
                    Currencies = new[] { "IRR" },
                    CallingCodes = new[] { "98" },
                    Capital = "Tehran",
                    AlternativeSpellings = new[] { "IR", "Islamic Republic of Iran", "Iran, Islamic Republic of", "Jomhuri-ye Eslāmi-ye Irān" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AFG, CountryCodeISO3.ARM, CountryCodeISO3.AZE, CountryCodeISO3.IRQ, CountryCodeISO3.PAK, CountryCodeISO3.TUR, CountryCodeISO3.TKM },
                    Landlocked = false,
                    Area = 1648195,
                };
            }
        }
        public static Country Iraq
        {
            get
            {
                return new Country
                {
                    CommonName = "Iraq",
                    OfficialName = "Republic of Iraq",
                    TLD = new[] { ".iq" },
                    CountryCode = CountryCode.IQ,
                    ISONumeric = "368",
                    ISO3 = CountryCodeISO3.IRQ,
                    CIOC = "IRQ",
                    Currencies = new[] { "IQD" },
                    CallingCodes = new[] { "964" },
                    Capital = "Baghdad",
                    AlternativeSpellings = new[] { "IQ", "Republic of Iraq", "Jumhūriyyat al-‘Irāq" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.IRN, CountryCodeISO3.JOR, CountryCodeISO3.KWT, CountryCodeISO3.SAU, CountryCodeISO3.SYR, CountryCodeISO3.TUR },
                    Landlocked = false,
                    Area = 438317,
                };
            }
        }
        public static Country Iceland
        {
            get
            {
                return new Country
                {
                    CommonName = "Iceland",
                    OfficialName = "Iceland",
                    TLD = new[] { ".is" },
                    CountryCode = CountryCode.IS,
                    ISONumeric = "352",
                    ISO3 = CountryCodeISO3.ISL,
                    CIOC = "ISL",
                    Currencies = new[] { "ISK" },
                    CallingCodes = new[] { "354" },
                    Capital = "Reykjavik",
                    AlternativeSpellings = new[] { "IS", "Island", "Republic of Iceland", "Lýðveldið Ísland" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 103000,
                };
            }
        }
        public static Country Israel
        {
            get
            {
                return new Country
                {
                    CommonName = "Israel",
                    OfficialName = "State of Israel",
                    TLD = new[] { ".il" },
                    CountryCode = CountryCode.IL,
                    ISONumeric = "376",
                    ISO3 = CountryCodeISO3.ISR,
                    CIOC = "ISR",
                    Currencies = new[] { "ILS" },
                    CallingCodes = new[] { "972" },
                    Capital = "Jerusalem",
                    AlternativeSpellings = new[] { "IL", "State of Israel", "Medīnat Yisrā'el" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.EGY, CountryCodeISO3.JOR, CountryCodeISO3.LBN, CountryCodeISO3.SYR },
                    Landlocked = false,
                    Area = 20770,
                };
            }
        }
        public static Country Italy
        {
            get
            {
                return new Country
                {
                    CommonName = "Italy",
                    OfficialName = "Italian Republic",
                    TLD = new[] { ".it" },
                    CountryCode = CountryCode.IT,
                    ISONumeric = "380",
                    ISO3 = CountryCodeISO3.ITA,
                    CIOC = "ITA",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "39" },
                    Capital = "Rome",
                    AlternativeSpellings = new[] { "IT", "Italian Republic", "Repubblica italiana" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AUT, CountryCodeISO3.FRA, CountryCodeISO3.SMR, CountryCodeISO3.SVN, CountryCodeISO3.CHE, CountryCodeISO3.VAT },
                    Landlocked = false,
                    Area = 301336,
                };
            }
        }
        public static Country Jamaica
        {
            get
            {
                return new Country
                {
                    CommonName = "Jamaica",
                    OfficialName = "Jamaica",
                    TLD = new[] { ".jm" },
                    CountryCode = CountryCode.JM,
                    ISONumeric = "388",
                    ISO3 = CountryCodeISO3.JAM,
                    CIOC = "JAM",
                    Currencies = new[] { "JMD" },
                    CallingCodes = new[] { "1876" },
                    Capital = "Kingston",
                    AlternativeSpellings = new[] { "JM" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 10991,
                };
            }
        }
        public static Country Jersey
        {
            get
            {
                return new Country
                {
                    CommonName = "Jersey",
                    OfficialName = "Bailiwick of Jersey",
                    TLD = new[] { ".je" },
                    CountryCode = CountryCode.JE,
                    ISONumeric = "832",
                    ISO3 = CountryCodeISO3.JEY,
                    CIOC = "",
                    Currencies = new[] { "GBP" },
                    CallingCodes = new[] { "44" },
                    Capital = "Saint Helier",
                    AlternativeSpellings = new[] { "JE", "Bailiwick of Jersey", "Bailliage de Jersey", "Bailliage dé Jèrri" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 116,
                };
            }
        }
        public static Country Jordan
        {
            get
            {
                return new Country
                {
                    CommonName = "Jordan",
                    OfficialName = "Hashemite Kingdom of Jordan",
                    TLD = new[] { ".jo", "الاردن." },
                    CountryCode = CountryCode.JO,
                    ISONumeric = "400",
                    ISO3 = CountryCodeISO3.JOR,
                    CIOC = "JOR",
                    Currencies = new[] { "JOD" },
                    CallingCodes = new[] { "962" },
                    Capital = "Amman",
                    AlternativeSpellings = new[] { "JO", "Hashemite Kingdom of Jordan", "al-Mamlakah al-Urdunīyah al-Hāshimīyah" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.IRQ, CountryCodeISO3.ISR, CountryCodeISO3.SAU, CountryCodeISO3.SYR },
                    Landlocked = false,
                    Area = 89342,
                };
            }
        }
        public static Country Japan
        {
            get
            {
                return new Country
                {
                    CommonName = "Japan",
                    OfficialName = "Japan",
                    TLD = new[] { ".jp", ".みんな" },
                    CountryCode = CountryCode.JP,
                    ISONumeric = "392",
                    ISO3 = CountryCodeISO3.JPN,
                    CIOC = "JPN",
                    Currencies = new[] { "JPY" },
                    CallingCodes = new[] { "81" },
                    Capital = "Tokyo",
                    AlternativeSpellings = new[] { "JP", "Nippon", "Nihon" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 377930,
                };
            }
        }
        public static Country Kazakhstan
        {
            get
            {
                return new Country
                {
                    CommonName = "Kazakhstan",
                    OfficialName = "Republic of Kazakhstan",
                    TLD = new[] { ".kz", ".қаз" },
                    CountryCode = CountryCode.KZ,
                    ISONumeric = "398",
                    ISO3 = CountryCodeISO3.KAZ,
                    CIOC = "KAZ",
                    Currencies = new[] { "KZT" },
                    CallingCodes = new[] { "76", "77" },
                    Capital = "Astana",
                    AlternativeSpellings = new[] { "KZ", "Qazaqstan", "Казахстан", "Republic of Kazakhstan", "Қазақстан Республикасы", "Qazaqstan Respublïkası", "Республика Казахстан", "Respublika Kazakhstan" },
                    Region = "Asia",
                    SubRegion = "Central Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CHN, CountryCodeISO3.KGZ, CountryCodeISO3.RUS, CountryCodeISO3.TKM, CountryCodeISO3.UZB },
                    Landlocked = true,
                    Area = 2724900,
                };
            }
        }
        public static Country Kenya
        {
            get
            {
                return new Country
                {
                    CommonName = "Kenya",
                    OfficialName = "Republic of Kenya",
                    TLD = new[] { ".ke" },
                    CountryCode = CountryCode.KE,
                    ISONumeric = "404",
                    ISO3 = CountryCodeISO3.KEN,
                    CIOC = "KEN",
                    Currencies = new[] { "KES" },
                    CallingCodes = new[] { "254" },
                    Capital = "Nairobi",
                    AlternativeSpellings = new[] { "KE", "Republic of Kenya", "Jamhuri ya Kenya" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ETH, CountryCodeISO3.SOM, CountryCodeISO3.SSD, CountryCodeISO3.TZA, CountryCodeISO3.UGA },
                    Landlocked = false,
                    Area = 580367,
                };
            }
        }
        public static Country Kyrgyzstan
        {
            get
            {
                return new Country
                {
                    CommonName = "Kyrgyzstan",
                    OfficialName = "Kyrgyz Republic",
                    TLD = new[] { ".kg" },
                    CountryCode = CountryCode.KG,
                    ISONumeric = "417",
                    ISO3 = CountryCodeISO3.KGZ,
                    CIOC = "KGZ",
                    Currencies = new[] { "KGS" },
                    CallingCodes = new[] { "996" },
                    Capital = "Bishkek",
                    AlternativeSpellings = new[] { "KG", "Киргизия", "Kyrgyz Republic", "Кыргыз Республикасы", "Kyrgyz Respublikasy" },
                    Region = "Asia",
                    SubRegion = "Central Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CHN, CountryCodeISO3.KAZ, CountryCodeISO3.TJK, CountryCodeISO3.UZB },
                    Landlocked = true,
                    Area = 199951,
                };
            }
        }
        public static Country Cambodia
        {
            get
            {
                return new Country
                {
                    CommonName = "Cambodia",
                    OfficialName = "Kingdom of Cambodia",
                    TLD = new[] { ".kh" },
                    CountryCode = CountryCode.KH,
                    ISONumeric = "116",
                    ISO3 = CountryCodeISO3.KHM,
                    CIOC = "CAM",
                    Currencies = new[] { "KHR" },
                    CallingCodes = new[] { "855" },
                    Capital = "Phnom Penh",
                    AlternativeSpellings = new[] { "KH", "Kingdom of Cambodia" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.LAO, CountryCodeISO3.THA, CountryCodeISO3.VNM },
                    Landlocked = false,
                    Area = 181035,
                };
            }
        }
        public static Country Kiribati
        {
            get
            {
                return new Country
                {
                    CommonName = "Kiribati",
                    OfficialName = "Independent and Sovereign Republic of Kiribati",
                    TLD = new[] { ".ki" },
                    CountryCode = CountryCode.KI,
                    ISONumeric = "296",
                    ISO3 = CountryCodeISO3.KIR,
                    CIOC = "KIR",
                    Currencies = new[] { "AUD" },
                    CallingCodes = new[] { "686" },
                    Capital = "South Tarawa",
                    AlternativeSpellings = new[] { "KI", "Republic of Kiribati", "Ribaberiki Kiribati" },
                    Region = "Oceania",
                    SubRegion = "Micronesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 811,
                };
            }
        }
        public static Country SaintKittsandNevis
        {
            get
            {
                return new Country
                {
                    CommonName = "Saint Kitts and Nevis",
                    OfficialName = "Federation of Saint Christopher and Nevisa",
                    TLD = new[] { ".kn" },
                    CountryCode = CountryCode.KN,
                    ISONumeric = "659",
                    ISO3 = CountryCodeISO3.KNA,
                    CIOC = "SKN",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1869" },
                    Capital = "Basseterre",
                    AlternativeSpellings = new[] { "KN", "Federation of Saint Christopher and Nevis" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 261,
                };
            }
        }
        public static Country SouthKorea
        {
            get
            {
                return new Country
                {
                    CommonName = "South Korea",
                    OfficialName = "Republic of Korea",
                    TLD = new[] { ".kr", ".한국" },
                    CountryCode = CountryCode.KR,
                    ISONumeric = "410",
                    ISO3 = CountryCodeISO3.KOR,
                    CIOC = "KOR",
                    Currencies = new[] { "KRW" },
                    CallingCodes = new[] { "82" },
                    Capital = "Seoul",
                    AlternativeSpellings = new[] { "KR", "Korea, Republic of", "Republic of Korea" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.PRK },
                    Landlocked = false,
                    Area = 100210,
                };
            }
        }
        public static Country Kosovo
        {
            get
            {
                return new Country
                {
                    CommonName = "Kosovo",
                    OfficialName = "Republic of Kosovo",
                    TLD = new string[] { },
                    CountryCode = CountryCode.XK,
                    ISONumeric = "",
                    ISO3 = CountryCodeISO3.KOS,
                    CIOC = "KOS",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "383" },
                    Capital = "Pristina",
                    AlternativeSpellings = new[] { "XK", "Република Косово" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ALB, CountryCodeISO3.MKD, CountryCodeISO3.MNE, CountryCodeISO3.SRB },
                    Landlocked = true,
                    Area = 10908,
                };
            }
        }
        public static Country Kuwait
        {
            get
            {
                return new Country
                {
                    CommonName = "Kuwait",
                    OfficialName = "State of Kuwait",
                    TLD = new[] { ".kw" },
                    CountryCode = CountryCode.KW,
                    ISONumeric = "414",
                    ISO3 = CountryCodeISO3.KWT,
                    CIOC = "KUW",
                    Currencies = new[] { "KWD" },
                    CallingCodes = new[] { "965" },
                    Capital = "Kuwait City",
                    AlternativeSpellings = new[] { "KW", "State of Kuwait", "Dawlat al-Kuwait" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.IRQ, CountryCodeISO3.SAU },
                    Landlocked = false,
                    Area = 17818,
                };
            }
        }
        public static Country Laos
        {
            get
            {
                return new Country
                {
                    CommonName = "Laos",
                    OfficialName = "Lao People's Democratic Republic",
                    TLD = new[] { ".la" },
                    CountryCode = CountryCode.LA,
                    ISONumeric = "418",
                    ISO3 = CountryCodeISO3.LAO,
                    CIOC = "LAO",
                    Currencies = new[] { "LAK" },
                    CallingCodes = new[] { "856" },
                    Capital = "Vientiane",
                    AlternativeSpellings = new[] { "LA", "Lao", "Lao People's Democratic Republic", "Sathalanalat Paxathipatai Paxaxon Lao" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.MMR, CountryCodeISO3.KHM, CountryCodeISO3.CHN, CountryCodeISO3.THA, CountryCodeISO3.VNM },
                    Landlocked = true,
                    Area = 236800,
                };
            }
        }
        public static Country Lebanon
        {
            get
            {
                return new Country
                {
                    CommonName = "Lebanon",
                    OfficialName = "Lebanese Republic",
                    TLD = new[] { ".lb" },
                    CountryCode = CountryCode.LB,
                    ISONumeric = "422",
                    ISO3 = CountryCodeISO3.LBN,
                    CIOC = "LIB",
                    Currencies = new[] { "LBP" },
                    CallingCodes = new[] { "961" },
                    Capital = "Beirut",
                    AlternativeSpellings = new[] { "LB", "Lebanese Republic", "Al-Jumhūrīyah Al-Libnānīyah" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ISR, CountryCodeISO3.SYR },
                    Landlocked = false,
                    Area = 10452,
                };
            }
        }
        public static Country Liberia
        {
            get
            {
                return new Country
                {
                    CommonName = "Liberia",
                    OfficialName = "Republic of Liberia",
                    TLD = new[] { ".lr" },
                    CountryCode = CountryCode.LR,
                    ISONumeric = "430",
                    ISO3 = CountryCodeISO3.LBR,
                    CIOC = "LBR",
                    Currencies = new[] { "LRD" },
                    CallingCodes = new[] { "231" },
                    Capital = "Monrovia",
                    AlternativeSpellings = new[] { "LR", "Republic of Liberia" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.GIN, CountryCodeISO3.CIV, CountryCodeISO3.SLE },
                    Landlocked = false,
                    Area = 111369,
                };
            }
        }
        public static Country Libya
        {
            get
            {
                return new Country
                {
                    CommonName = "Libya",
                    OfficialName = "State of Libya",
                    TLD = new[] { ".ly" },
                    CountryCode = CountryCode.LY,
                    ISONumeric = "434",
                    ISO3 = CountryCodeISO3.LBY,
                    CIOC = "LBA",
                    Currencies = new[] { "LYD" },
                    CallingCodes = new[] { "218" },
                    Capital = "Tripoli",
                    AlternativeSpellings = new[] { "LY", "State of Libya", "Dawlat Libya" },
                    Region = "Africa",
                    SubRegion = "Northern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.DZA, CountryCodeISO3.TCD, CountryCodeISO3.EGY, CountryCodeISO3.NER, CountryCodeISO3.SDN, CountryCodeISO3.TUN },
                    Landlocked = false,
                    Area = 1759540,
                };
            }
        }
        public static Country SaintLucia
        {
            get
            {
                return new Country
                {
                    CommonName = "Saint Lucia",
                    OfficialName = "Saint Lucia",
                    TLD = new[] { ".lc" },
                    CountryCode = CountryCode.LC,
                    ISONumeric = "662",
                    ISO3 = CountryCodeISO3.LCA,
                    CIOC = "LCA",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1758" },
                    Capital = "Castries",
                    AlternativeSpellings = new[] { "LC" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 616,
                };
            }
        }
        public static Country Liechtenstein
        {
            get
            {
                return new Country
                {
                    CommonName = "Liechtenstein",
                    OfficialName = "Principality of Liechtenstein",
                    TLD = new[] { ".li" },
                    CountryCode = CountryCode.LI,
                    ISONumeric = "438",
                    ISO3 = CountryCodeISO3.LIE,
                    CIOC = "LIE",
                    Currencies = new[] { "CHF" },
                    CallingCodes = new[] { "423" },
                    Capital = "Vaduz",
                    AlternativeSpellings = new[] { "LI", "Principality of Liechtenstein", "Fürstentum Liechtenstein" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AUT, CountryCodeISO3.CHE },
                    Landlocked = true,
                    Area = 160,
                };
            }
        }
        public static Country SriLanka
        {
            get
            {
                return new Country
                {
                    CommonName = "Sri Lanka",
                    OfficialName = "Democratic Socialist Republic of Sri Lanka",
                    TLD = new[] { ".lk", ".இலங்கை", ".ලංකා" },
                    CountryCode = CountryCode.LK,
                    ISONumeric = "144",
                    ISO3 = CountryCodeISO3.LKA,
                    CIOC = "SRI",
                    Currencies = new[] { "LKR" },
                    CallingCodes = new[] { "94" },
                    Capital = "Colombo",
                    AlternativeSpellings = new[] { "LK", "ilaṅkai", "Democratic Socialist Republic of Sri Lanka" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.IND },
                    Landlocked = false,
                    Area = 65610,
                };
            }
        }
        public static Country Lesotho
        {
            get
            {
                return new Country
                {
                    CommonName = "Lesotho",
                    OfficialName = "Kingdom of Lesotho",
                    TLD = new[] { ".ls" },
                    CountryCode = CountryCode.LS,
                    ISONumeric = "426",
                    ISO3 = CountryCodeISO3.LSO,
                    CIOC = "LES",
                    Currencies = new[] { "LSL", "ZAR" },
                    CallingCodes = new[] { "266" },
                    Capital = "Maseru",
                    AlternativeSpellings = new[] { "LS", "Kingdom of Lesotho", "Muso oa Lesotho" },
                    Region = "Africa",
                    SubRegion = "Southern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ZAF },
                    Landlocked = true,
                    Area = 30355,
                };
            }
        }
        public static Country Lithuania
        {
            get
            {
                return new Country
                {
                    CommonName = "Lithuania",
                    OfficialName = "Republic of Lithuania",
                    TLD = new[] { ".lt" },
                    CountryCode = CountryCode.LT,
                    ISONumeric = "440",
                    ISO3 = CountryCodeISO3.LTU,
                    CIOC = "LTU",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "370" },
                    Capital = "Vilnius",
                    AlternativeSpellings = new[] { "LT", "Republic of Lithuania", "Lietuvos Respublika" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BLR, CountryCodeISO3.LVA, CountryCodeISO3.POL, CountryCodeISO3.RUS },
                    Landlocked = false,
                    Area = 65300,
                };
            }
        }
        public static Country Luxembourg
        {
            get
            {
                return new Country
                {
                    CommonName = "Luxembourg",
                    OfficialName = "Grand Duchy of Luxembourg",
                    TLD = new[] { ".lu" },
                    CountryCode = CountryCode.LU,
                    ISONumeric = "442",
                    ISO3 = CountryCodeISO3.LUX,
                    CIOC = "LUX",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "352" },
                    Capital = "Luxembourg",
                    AlternativeSpellings = new[] { "LU", "Grand Duchy of Luxembourg", "Grand-Duché de Luxembourg", "Großherzogtum Luxemburg", "Groussherzogtum Lëtzebuerg" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BEL, CountryCodeISO3.FRA, CountryCodeISO3.DEU },
                    Landlocked = true,
                    Area = 2586,
                };
            }
        }
        public static Country Latvia
        {
            get
            {
                return new Country
                {
                    CommonName = "Latvia",
                    OfficialName = "Republic of Latvia",
                    TLD = new[] { ".lv" },
                    CountryCode = CountryCode.LV,
                    ISONumeric = "428",
                    ISO3 = CountryCodeISO3.LVA,
                    CIOC = "LAT",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "371" },
                    Capital = "Riga",
                    AlternativeSpellings = new[] { "LV", "Republic of Latvia", "Latvijas Republika" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BLR, CountryCodeISO3.EST, CountryCodeISO3.LTU, CountryCodeISO3.RUS },
                    Landlocked = false,
                    Area = 64559,
                };
            }
        }
        public static Country Macau
        {
            get
            {
                return new Country
                {
                    CommonName = "Macau",
                    OfficialName = "Macao Special Administrative Region of the People's Republic of China",
                    TLD = new[] { ".mo" },
                    CountryCode = CountryCode.MO,
                    ISONumeric = "446",
                    ISO3 = CountryCodeISO3.MAC,
                    CIOC = "",
                    Currencies = new[] { "MOP" },
                    CallingCodes = new[] { "853" },
                    Capital = "",
                    AlternativeSpellings = new[] { "MO", "澳门", "Macao", "Macao Special Administrative Region of the People's Republic of China", "中華人民共和國澳門特別行政區", "Região Administrativa Especial de Macau da República Popular da China" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CHN },
                    Landlocked = false,
                    Area = 30,
                };
            }
        }
        public static Country SaintMartin
        {
            get
            {
                return new Country
                {
                    CommonName = "Saint Martin",
                    OfficialName = "Saint Martin",
                    TLD = new[] { ".fr", ".gp" },
                    CountryCode = CountryCode.MF,
                    ISONumeric = "663",
                    ISO3 = CountryCodeISO3.MAF,
                    CIOC = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "590" },
                    Capital = "Marigot",
                    AlternativeSpellings = new[] { "MF", "Collectivity of Saint Martin", "Collectivité de Saint-Martin", "Saint Martin (French part)" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.SXM },
                    Landlocked = false,
                    Area = 53,
                };
            }
        }
        public static Country Morocco
        {
            get
            {
                return new Country
                {
                    CommonName = "Morocco",
                    OfficialName = "Kingdom of Morocco",
                    TLD = new[] { ".ma", "المغرب." },
                    CountryCode = CountryCode.MA,
                    ISONumeric = "504",
                    ISO3 = CountryCodeISO3.MAR,
                    CIOC = "MAR",
                    Currencies = new[] { "MAD" },
                    CallingCodes = new[] { "212" },
                    Capital = "Rabat",
                    AlternativeSpellings = new[] { "MA", "Kingdom of Morocco", "Al-Mamlakah al-Maġribiyah" },
                    Region = "Africa",
                    SubRegion = "Northern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.DZA, CountryCodeISO3.ESH, CountryCodeISO3.ESP },
                    Landlocked = false,
                    Area = 446550,
                };
            }
        }
        public static Country Monaco
        {
            get
            {
                return new Country
                {
                    CommonName = "Monaco",
                    OfficialName = "Principality of Monaco",
                    TLD = new[] { ".mc" },
                    CountryCode = CountryCode.MC,
                    ISONumeric = "492",
                    ISO3 = CountryCodeISO3.MCO,
                    CIOC = "MON",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "377" },
                    Capital = "Monaco",
                    AlternativeSpellings = new[] { "MC", "Principality of Monaco", "Principauté de Monaco" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.FRA },
                    Landlocked = false,
                    Area = 2,
                };
            }
        }
        public static Country Moldova
        {
            get
            {
                return new Country
                {
                    CommonName = "Moldova",
                    OfficialName = "Republic of Moldova",
                    TLD = new[] { ".md" },
                    CountryCode = CountryCode.MD,
                    ISONumeric = "498",
                    ISO3 = CountryCodeISO3.MDA,
                    CIOC = "MDA",
                    Currencies = new[] { "MDL" },
                    CallingCodes = new[] { "373" },
                    Capital = "Chișinău",
                    AlternativeSpellings = new[] { "MD", "Moldova, Republic of", "Republic of Moldova", "Republica Moldova" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ROU, CountryCodeISO3.UKR },
                    Landlocked = true,
                    Area = 33846,
                };
            }
        }
        public static Country Madagascar
        {
            get
            {
                return new Country
                {
                    CommonName = "Madagascar",
                    OfficialName = "Republic of Madagascar",
                    TLD = new[] { ".mg" },
                    CountryCode = CountryCode.MG,
                    ISONumeric = "450",
                    ISO3 = CountryCodeISO3.MDG,
                    CIOC = "MAD",
                    Currencies = new[] { "MGA" },
                    CallingCodes = new[] { "261" },
                    Capital = "Antananarivo",
                    AlternativeSpellings = new[] { "MG", "Republic of Madagascar", "Repoblikan'i Madagasikara", "République de Madagascar" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 587041,
                };
            }
        }
        public static Country Maldives
        {
            get
            {
                return new Country
                {
                    CommonName = "Maldives",
                    OfficialName = "Republic of the Maldives",
                    TLD = new[] { ".mv" },
                    CountryCode = CountryCode.MV,
                    ISONumeric = "462",
                    ISO3 = CountryCodeISO3.MDV,
                    CIOC = "MDV",
                    Currencies = new[] { "MVR" },
                    CallingCodes = new[] { "960" },
                    Capital = "Malé",
                    AlternativeSpellings = new[] { "MV", "Maldive Islands", "Republic of the Maldives", "Dhivehi Raajjeyge Jumhooriyya" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 300,
                };
            }
        }
        public static Country Mexico
        {
            get
            {
                return new Country
                {
                    CommonName = "Mexico",
                    OfficialName = "United Mexican States",
                    TLD = new[] { ".mx" },
                    CountryCode = CountryCode.MX,
                    ISONumeric = "484",
                    ISO3 = CountryCodeISO3.MEX,
                    CIOC = "MEX",
                    Currencies = new[] { "MXN" },
                    CallingCodes = new[] { "52" },
                    Capital = "Mexico City",
                    AlternativeSpellings = new[] { "MX", "Mexicanos", "United Mexican States", "Estados Unidos Mexicanos" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BLZ, CountryCodeISO3.GTM, CountryCodeISO3.USA },
                    Landlocked = false,
                    Area = 1964375,
                };
            }
        }
        public static Country MarshallIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Marshall Islands",
                    OfficialName = "Republic of the Marshall Islands",
                    TLD = new[] { ".mh" },
                    CountryCode = CountryCode.MH,
                    ISONumeric = "584",
                    ISO3 = CountryCodeISO3.MHL,
                    CIOC = "MHL",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "692" },
                    Capital = "Majuro",
                    AlternativeSpellings = new[] { "MH", "Republic of the Marshall Islands", "Aolepān Aorōkin M̧ajeļ" },
                    Region = "Oceania",
                    SubRegion = "Micronesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 181,
                };
            }
        }
        public static Country Macedonia
        {
            get
            {
                return new Country
                {
                    CommonName = "Macedonia",
                    OfficialName = "Republic of Macedonia",
                    TLD = new[] { ".mk" },
                    CountryCode = CountryCode.MK,
                    ISONumeric = "807",
                    ISO3 = CountryCodeISO3.MKD,
                    CIOC = "MKD",
                    Currencies = new[] { "MKD" },
                    CallingCodes = new[] { "389" },
                    Capital = "Skopje",
                    AlternativeSpellings = new[] { "MK", "Macedonia, the Former Yugoslav Republic of", "Republic of Macedonia", "Република Македонија" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ALB, CountryCodeISO3.BGR, CountryCodeISO3.GRC, CountryCodeISO3.KOS, CountryCodeISO3.SRB },
                    Landlocked = true,
                    Area = 25713,
                };
            }
        }
        public static Country Mali
        {
            get
            {
                return new Country
                {
                    CommonName = "Mali",
                    OfficialName = "Republic of Mali",
                    TLD = new[] { ".ml" },
                    CountryCode = CountryCode.ML,
                    ISONumeric = "466",
                    ISO3 = CountryCodeISO3.MLI,
                    CIOC = "MLI",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "223" },
                    Capital = "Bamako",
                    AlternativeSpellings = new[] { "ML", "Republic of Mali", "République du Mali" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.DZA, CountryCodeISO3.BFA, CountryCodeISO3.GIN, CountryCodeISO3.CIV, CountryCodeISO3.MRT, CountryCodeISO3.NER, CountryCodeISO3.SEN },
                    Landlocked = true,
                    Area = 1240192,
                };
            }
        }
        public static Country Malta
        {
            get
            {
                return new Country
                {
                    CommonName = "Malta",
                    OfficialName = "Republic of Malta",
                    TLD = new[] { ".mt" },
                    CountryCode = CountryCode.MT,
                    ISONumeric = "470",
                    ISO3 = CountryCodeISO3.MLT,
                    CIOC = "MLT",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "356" },
                    Capital = "Valletta",
                    AlternativeSpellings = new[] { "MT", "Republic of Malta", "Repubblika ta' Malta" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 316,
                };
            }
        }
        public static Country Myanmar
        {
            get
            {
                return new Country
                {
                    CommonName = "Myanmar",
                    OfficialName = "Republic of the Union of Myanmar",
                    TLD = new[] { ".mm" },
                    CountryCode = CountryCode.MM,
                    ISONumeric = "104",
                    ISO3 = CountryCodeISO3.MMR,
                    CIOC = "MYA",
                    Currencies = new[] { "MMK" },
                    CallingCodes = new[] { "95" },
                    Capital = "Naypyidaw",
                    AlternativeSpellings = new[] { "MM", "Burma", "Republic of the Union of Myanmar", "Pyidaunzu Thanmăda Myăma Nainngandaw" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BGD, CountryCodeISO3.CHN, CountryCodeISO3.IND, CountryCodeISO3.LAO, CountryCodeISO3.THA },
                    Landlocked = false,
                    Area = 676578,
                };
            }
        }
        public static Country Montenegro
        {
            get
            {
                return new Country
                {
                    CommonName = "Montenegro",
                    OfficialName = "Montenegro",
                    TLD = new[] { ".me" },
                    CountryCode = CountryCode.ME,
                    ISONumeric = "499",
                    ISO3 = CountryCodeISO3.MNE,
                    CIOC = "MNE",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "382" },
                    Capital = "Podgorica",
                    AlternativeSpellings = new[] { "ME", "Crna Gora" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ALB, CountryCodeISO3.BIH, CountryCodeISO3.HRV, CountryCodeISO3.KOS, CountryCodeISO3.SRB },
                    Landlocked = false,
                    Area = 13812,
                };
            }
        }
        public static Country Mongolia
        {
            get
            {
                return new Country
                {
                    CommonName = "Mongolia",
                    OfficialName = "Mongolia",
                    TLD = new[] { ".mn" },
                    CountryCode = CountryCode.MN,
                    ISONumeric = "496",
                    ISO3 = CountryCodeISO3.MNG,
                    CIOC = "MGL",
                    Currencies = new[] { "MNT" },
                    CallingCodes = new[] { "976" },
                    Capital = "Ulan Bator",
                    AlternativeSpellings = new[] { "MN" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CHN, CountryCodeISO3.RUS },
                    Landlocked = true,
                    Area = 1564110,
                };
            }
        }
        public static Country NorthernMarianaIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Northern Mariana Islands",
                    OfficialName = "Commonwealth of the Northern Mariana Islands",
                    TLD = new[] { ".mp" },
                    CountryCode = CountryCode.MP,
                    ISONumeric = "580",
                    ISO3 = CountryCodeISO3.MNP,
                    CIOC = "",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "1670" },
                    Capital = "Saipan",
                    AlternativeSpellings = new[] { "MP", "Commonwealth of the Northern Mariana Islands", "Sankattan Siha Na Islas Mariånas" },
                    Region = "Oceania",
                    SubRegion = "Micronesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 464,
                };
            }
        }
        public static Country Mozambique
        {
            get
            {
                return new Country
                {
                    CommonName = "Mozambique",
                    OfficialName = "Republic of Mozambique",
                    TLD = new[] { ".mz" },
                    CountryCode = CountryCode.MZ,
                    ISONumeric = "508",
                    ISO3 = CountryCodeISO3.MOZ,
                    CIOC = "MOZ",
                    Currencies = new[] { "MZN" },
                    CallingCodes = new[] { "258" },
                    Capital = "Maputo",
                    AlternativeSpellings = new[] { "MZ", "Republic of Mozambique", "República de Moçambique" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.MWI, CountryCodeISO3.ZAF, CountryCodeISO3.SWZ, CountryCodeISO3.TZA, CountryCodeISO3.ZMB, CountryCodeISO3.ZWE },
                    Landlocked = false,
                    Area = 801590,
                };
            }
        }
        public static Country Mauritania
        {
            get
            {
                return new Country
                {
                    CommonName = "Mauritania",
                    OfficialName = "Islamic Republic of Mauritania",
                    TLD = new[] { ".mr" },
                    CountryCode = CountryCode.MR,
                    ISONumeric = "478",
                    ISO3 = CountryCodeISO3.MRT,
                    CIOC = "MTN",
                    Currencies = new[] { "MRO" },
                    CallingCodes = new[] { "222" },
                    Capital = "Nouakchott",
                    AlternativeSpellings = new[] { "MR", "Islamic Republic of Mauritania", "al-Jumhūriyyah al-ʾIslāmiyyah al-Mūrītāniyyah" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.DZA, CountryCodeISO3.MLI, CountryCodeISO3.SEN, CountryCodeISO3.ESH },
                    Landlocked = false,
                    Area = 1030700,
                };
            }
        }
        public static Country Montserrat
        {
            get
            {
                return new Country
                {
                    CommonName = "Montserrat",
                    OfficialName = "Montserrat",
                    TLD = new[] { ".ms" },
                    CountryCode = CountryCode.MS,
                    ISONumeric = "500",
                    ISO3 = CountryCodeISO3.MSR,
                    CIOC = "",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1664" },
                    Capital = "Plymouth",
                    AlternativeSpellings = new[] { "MS" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 102,
                };
            }
        }
        public static Country Martinique
        {
            get
            {
                return new Country
                {
                    CommonName = "Martinique",
                    OfficialName = "Martinique",
                    TLD = new[] { ".mq" },
                    CountryCode = CountryCode.MQ,
                    ISONumeric = "474",
                    ISO3 = CountryCodeISO3.MTQ,
                    CIOC = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "596" },
                    Capital = "Fort-de-France",
                    AlternativeSpellings = new[] { "MQ" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 1128,
                };
            }
        }
        public static Country Mauritius
        {
            get
            {
                return new Country
                {
                    CommonName = "Mauritius",
                    OfficialName = "Republic of Mauritius",
                    TLD = new[] { ".mu" },
                    CountryCode = CountryCode.MU,
                    ISONumeric = "480",
                    ISO3 = CountryCodeISO3.MUS,
                    CIOC = "MRI",
                    Currencies = new[] { "MUR" },
                    CallingCodes = new[] { "230" },
                    Capital = "Port Louis",
                    AlternativeSpellings = new[] { "MU", "Republic of Mauritius", "République de Maurice" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 2040,
                };
            }
        }
        public static Country Malawi
        {
            get
            {
                return new Country
                {
                    CommonName = "Malawi",
                    OfficialName = "Republic of Malawi",
                    TLD = new[] { ".mw" },
                    CountryCode = CountryCode.MW,
                    ISONumeric = "454",
                    ISO3 = CountryCodeISO3.MWI,
                    CIOC = "MAW",
                    Currencies = new[] { "MWK" },
                    CallingCodes = new[] { "265" },
                    Capital = "Lilongwe",
                    AlternativeSpellings = new[] { "MW", "Republic of Malawi" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.MOZ, CountryCodeISO3.TZA, CountryCodeISO3.ZMB },
                    Landlocked = true,
                    Area = 118484,
                };
            }
        }
        public static Country Malaysia
        {
            get
            {
                return new Country
                {
                    CommonName = "Malaysia",
                    OfficialName = "Malaysia",
                    TLD = new[] { ".my" },
                    CountryCode = CountryCode.MY,
                    ISONumeric = "458",
                    ISO3 = CountryCodeISO3.MYS,
                    CIOC = "MAS",
                    Currencies = new[] { "MYR" },
                    CallingCodes = new[] { "60" },
                    Capital = "Kuala Lumpur",
                    AlternativeSpellings = new[] { "MY" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BRN, CountryCodeISO3.IDN, CountryCodeISO3.THA },
                    Landlocked = false,
                    Area = 330803,
                };
            }
        }
        public static Country Mayotte
        {
            get
            {
                return new Country
                {
                    CommonName = "Mayotte",
                    OfficialName = "Department of Mayotte",
                    TLD = new[] { ".yt" },
                    CountryCode = CountryCode.YT,
                    ISONumeric = "175",
                    ISO3 = CountryCodeISO3.MYT,
                    CIOC = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "262" },
                    Capital = "Mamoudzou",
                    AlternativeSpellings = new[] { "YT", "Department of Mayotte", "Département de Mayotte" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 374,
                };
            }
        }
        public static Country Namibia
        {
            get
            {
                return new Country
                {
                    CommonName = "Namibia",
                    OfficialName = "Republic of Namibia",
                    TLD = new[] { ".na" },
                    CountryCode = CountryCode.NA,
                    ISONumeric = "516",
                    ISO3 = CountryCodeISO3.NAM,
                    CIOC = "NAM",
                    Currencies = new[] { "NAD", "ZAR" },
                    CallingCodes = new[] { "264" },
                    Capital = "Windhoek",
                    AlternativeSpellings = new[] { "NA", "Namibië", "Republic of Namibia" },
                    Region = "Africa",
                    SubRegion = "Southern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AGO, CountryCodeISO3.BWA, CountryCodeISO3.ZAF, CountryCodeISO3.ZMB },
                    Landlocked = false,
                    Area = 825615,
                };
            }
        }
        public static Country NewCaledonia
        {
            get
            {
                return new Country
                {
                    CommonName = "New Caledonia",
                    OfficialName = "New Caledonia",
                    TLD = new[] { ".nc" },
                    CountryCode = CountryCode.NC,
                    ISONumeric = "540",
                    ISO3 = CountryCodeISO3.NCL,
                    CIOC = "",
                    Currencies = new[] { "XPF" },
                    CallingCodes = new[] { "687" },
                    Capital = "Nouméa",
                    AlternativeSpellings = new[] { "NC" },
                    Region = "Oceania",
                    SubRegion = "Melanesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 18575,
                };
            }
        }
        public static Country Niger
        {
            get
            {
                return new Country
                {
                    CommonName = "Niger",
                    OfficialName = "Republic of Niger",
                    TLD = new[] { ".ne" },
                    CountryCode = CountryCode.NE,
                    ISONumeric = "562",
                    ISO3 = CountryCodeISO3.NER,
                    CIOC = "NIG",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "227" },
                    Capital = "Niamey",
                    AlternativeSpellings = new[] { "NE", "Nijar" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.DZA, CountryCodeISO3.BEN, CountryCodeISO3.BFA, CountryCodeISO3.TCD, CountryCodeISO3.LBY, CountryCodeISO3.MLI, CountryCodeISO3.NGA },
                    Landlocked = true,
                    Area = 1267000,
                };
            }
        }
        public static Country NorfolkIsland
        {
            get
            {
                return new Country
                {
                    CommonName = "Norfolk Island",
                    OfficialName = "Territory of Norfolk Island",
                    TLD = new[] { ".nf" },
                    CountryCode = CountryCode.NF,
                    ISONumeric = "574",
                    ISO3 = CountryCodeISO3.NFK,
                    CIOC = "",
                    Currencies = new[] { "AUD" },
                    CallingCodes = new[] { "672" },
                    Capital = "Kingston",
                    AlternativeSpellings = new[] { "NF", "Territory of Norfolk Island", "Teratri of Norf'k Ailen" },
                    Region = "Oceania",
                    SubRegion = "Australia and New Zealand",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 36,
                };
            }
        }
        public static Country Nigeria
        {
            get
            {
                return new Country
                {
                    CommonName = "Nigeria",
                    OfficialName = "Federal Republic of Nigeria",
                    TLD = new[] { ".ng" },
                    CountryCode = CountryCode.NG,
                    ISONumeric = "566",
                    ISO3 = CountryCodeISO3.NGA,
                    CIOC = "NGR",
                    Currencies = new[] { "NGN" },
                    CallingCodes = new[] { "234" },
                    Capital = "Abuja",
                    AlternativeSpellings = new[] { "NG", "Nijeriya", "Naíjíríà", "Federal Republic of Nigeria" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BEN, CountryCodeISO3.CMR, CountryCodeISO3.TCD, CountryCodeISO3.NER },
                    Landlocked = false,
                    Area = 923768,
                };
            }
        }
        public static Country Nicaragua
        {
            get
            {
                return new Country
                {
                    CommonName = "Nicaragua",
                    OfficialName = "Republic of Nicaragua",
                    TLD = new[] { ".ni" },
                    CountryCode = CountryCode.NI,
                    ISONumeric = "558",
                    ISO3 = CountryCodeISO3.NIC,
                    CIOC = "NCA",
                    Currencies = new[] { "NIO" },
                    CallingCodes = new[] { "505" },
                    Capital = "Managua",
                    AlternativeSpellings = new[] { "NI", "Republic of Nicaragua", "República de Nicaragua" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CRI, CountryCodeISO3.HND },
                    Landlocked = false,
                    Area = 130373,
                };
            }
        }
        public static Country Niue
        {
            get
            {
                return new Country
                {
                    CommonName = "Niue",
                    OfficialName = "Niue",
                    TLD = new[] { ".nu" },
                    CountryCode = CountryCode.NU,
                    ISONumeric = "570",
                    ISO3 = CountryCodeISO3.NIU,
                    CIOC = "",
                    Currencies = new[] { "NZD" },
                    CallingCodes = new[] { "683" },
                    Capital = "Alofi",
                    AlternativeSpellings = new[] { "NU" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 260,
                };
            }
        }
        public static Country Netherlands
        {
            get
            {
                return new Country
                {
                    CommonName = "Netherlands",
                    OfficialName = "Netherlands",
                    TLD = new[] { ".nl" },
                    CountryCode = CountryCode.NL,
                    ISONumeric = "528",
                    ISO3 = CountryCodeISO3.NLD,
                    CIOC = "NED",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "31" },
                    Capital = "Amsterdam",
                    AlternativeSpellings = new[] { "NL", "Holland", "Nederland" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BEL, CountryCodeISO3.DEU },
                    Landlocked = false,
                    Area = 41850,
                };
            }
        }
        public static Country Norway
        {
            get
            {
                return new Country
                {
                    CommonName = "Norway",
                    OfficialName = "Kingdom of Norway",
                    TLD = new[] { ".no" },
                    CountryCode = CountryCode.NO,
                    ISONumeric = "578",
                    ISO3 = CountryCodeISO3.NOR,
                    CIOC = "NOR",
                    Currencies = new[] { "NOK" },
                    CallingCodes = new[] { "47" },
                    Capital = "Oslo",
                    AlternativeSpellings = new[] { "NO", "Norge", "Noreg", "Kingdom of Norway", "Kongeriket Norge", "Kongeriket Noreg" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.FIN, CountryCodeISO3.SWE, CountryCodeISO3.RUS },
                    Landlocked = false,
                    Area = 323802,
                };
            }
        }
        public static Country Nepal
        {
            get
            {
                return new Country
                {
                    CommonName = "Nepal",
                    OfficialName = "Federal Democratic Republic of Nepal",
                    TLD = new[] { ".np" },
                    CountryCode = CountryCode.NP,
                    ISONumeric = "524",
                    ISO3 = CountryCodeISO3.NPL,
                    CIOC = "NEP",
                    Currencies = new[] { "NPR" },
                    CallingCodes = new[] { "977" },
                    Capital = "Kathmandu",
                    AlternativeSpellings = new[] { "NP", "Federal Democratic Republic of Nepal", "Loktāntrik Ganatantra Nepāl" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CHN, CountryCodeISO3.IND },
                    Landlocked = true,
                    Area = 147181,
                };
            }
        }
        public static Country Nauru
        {
            get
            {
                return new Country
                {
                    CommonName = "Nauru",
                    OfficialName = "Republic of Nauru",
                    TLD = new[] { ".nr" },
                    CountryCode = CountryCode.NR,
                    ISONumeric = "520",
                    ISO3 = CountryCodeISO3.NRU,
                    CIOC = "NRU",
                    Currencies = new[] { "AUD" },
                    CallingCodes = new[] { "674" },
                    Capital = "Yaren",
                    AlternativeSpellings = new[] { "NR", "Naoero", "Pleasant Island", "Republic of Nauru", "Ripublik Naoero" },
                    Region = "Oceania",
                    SubRegion = "Micronesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 21,
                };
            }
        }
        public static Country NewZealand
        {
            get
            {
                return new Country
                {
                    CommonName = "New Zealand",
                    OfficialName = "New Zealand",
                    TLD = new[] { ".nz" },
                    CountryCode = CountryCode.NZ,
                    ISONumeric = "554",
                    ISO3 = CountryCodeISO3.NZL,
                    CIOC = "NZL",
                    Currencies = new[] { "NZD" },
                    CallingCodes = new[] { "64" },
                    Capital = "Wellington",
                    AlternativeSpellings = new[] { "NZ", "Aotearoa" },
                    Region = "Oceania",
                    SubRegion = "Australia and New Zealand",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 270467,
                };
            }
        }
        public static Country Oman
        {
            get
            {
                return new Country
                {
                    CommonName = "Oman",
                    OfficialName = "Sultanate of Oman",
                    TLD = new[] { ".om" },
                    CountryCode = CountryCode.OM,
                    ISONumeric = "512",
                    ISO3 = CountryCodeISO3.OMN,
                    CIOC = "OMA",
                    Currencies = new[] { "OMR" },
                    CallingCodes = new[] { "968" },
                    Capital = "Muscat",
                    AlternativeSpellings = new[] { "OM", "Sultanate of Oman", "Salṭanat ʻUmān" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.SAU, CountryCodeISO3.ARE, CountryCodeISO3.YEM },
                    Landlocked = false,
                    Area = 309500,
                };
            }
        }
        public static Country Pakistan
        {
            get
            {
                return new Country
                {
                    CommonName = "Pakistan",
                    OfficialName = "Islamic Republic of Pakistan",
                    TLD = new[] { ".pk" },
                    CountryCode = CountryCode.PK,
                    ISONumeric = "586",
                    ISO3 = CountryCodeISO3.PAK,
                    CIOC = "PAK",
                    Currencies = new[] { "PKR" },
                    CallingCodes = new[] { "92" },
                    Capital = "Islamabad",
                    AlternativeSpellings = new[] { "PK", "Pākistān", "Islamic Republic of Pakistan", "Islāmī Jumhūriya'eh Pākistān" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AFG, CountryCodeISO3.CHN, CountryCodeISO3.IND, CountryCodeISO3.IRN },
                    Landlocked = false,
                    Area = 881912,
                };
            }
        }
        public static Country Panama
        {
            get
            {
                return new Country
                {
                    CommonName = "Panama",
                    OfficialName = "Republic of Panama",
                    TLD = new[] { ".pa" },
                    CountryCode = CountryCode.PA,
                    ISONumeric = "591",
                    ISO3 = CountryCodeISO3.PAN,
                    CIOC = "PAN",
                    Currencies = new[] { "PAB", "USD" },
                    CallingCodes = new[] { "507" },
                    Capital = "Panama City",
                    AlternativeSpellings = new[] { "PA", "Republic of Panama", "República de Panamá" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.COL, CountryCodeISO3.CRI },
                    Landlocked = false,
                    Area = 75417,
                };
            }
        }
        public static Country PitcairnIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Pitcairn Islands",
                    OfficialName = "Pitcairn Group of Islands",
                    TLD = new[] { ".pn" },
                    CountryCode = CountryCode.PN,
                    ISONumeric = "612",
                    ISO3 = CountryCodeISO3.PCN,
                    CIOC = "",
                    Currencies = new[] { "NZD" },
                    CallingCodes = new[] { "64" },
                    Capital = "Adamstown",
                    AlternativeSpellings = new[] { "PN", "Pitcairn", "Pitcairn Henderson Ducie and Oeno Islands" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 47,
                };
            }
        }
        public static Country Peru
        {
            get
            {
                return new Country
                {
                    CommonName = "Peru",
                    OfficialName = "Republic of Peru",
                    TLD = new[] { ".pe" },
                    CountryCode = CountryCode.PE,
                    ISONumeric = "604",
                    ISO3 = CountryCodeISO3.PER,
                    CIOC = "PER",
                    Currencies = new[] { "PEN" },
                    CallingCodes = new[] { "51" },
                    Capital = "Lima",
                    AlternativeSpellings = new[] { "PE", "Republic of Peru", "República del Perú" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BOL, CountryCodeISO3.BRA, CountryCodeISO3.CHL, CountryCodeISO3.COL, CountryCodeISO3.ECU },
                    Landlocked = false,
                    Area = 1285216,
                };
            }
        }
        public static Country Philippines
        {
            get
            {
                return new Country
                {
                    CommonName = "Philippines",
                    OfficialName = "Republic of the Philippines",
                    TLD = new[] { ".ph" },
                    CountryCode = CountryCode.PH,
                    ISONumeric = "608",
                    ISO3 = CountryCodeISO3.PHL,
                    CIOC = "PHI",
                    Currencies = new[] { "PHP" },
                    CallingCodes = new[] { "63" },
                    Capital = "Manila",
                    AlternativeSpellings = new[] { "PH", "Republic of the Philippines", "Repúblika ng Pilipinas" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 342353,
                };
            }
        }
        public static Country Palau
        {
            get
            {
                return new Country
                {
                    CommonName = "Palau",
                    OfficialName = "Republic of Palau",
                    TLD = new[] { ".pw" },
                    CountryCode = CountryCode.PW,
                    ISONumeric = "585",
                    ISO3 = CountryCodeISO3.PLW,
                    CIOC = "PLW",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "680" },
                    Capital = "Ngerulmud",
                    AlternativeSpellings = new[] { "PW", "Republic of Palau", "Beluu er a Belau" },
                    Region = "Oceania",
                    SubRegion = "Micronesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 459,
                };
            }
        }
        public static Country PapuaNewGuinea
        {
            get
            {
                return new Country
                {
                    CommonName = "Papua New Guinea",
                    OfficialName = "Independent State of Papua New Guinea",
                    TLD = new[] { ".pg" },
                    CountryCode = CountryCode.PG,
                    ISONumeric = "598",
                    ISO3 = CountryCodeISO3.PNG,
                    CIOC = "PNG",
                    Currencies = new[] { "PGK" },
                    CallingCodes = new[] { "675" },
                    Capital = "Port Moresby",
                    AlternativeSpellings = new[] { "PG", "Independent State of Papua New Guinea", "Independen Stet bilong Papua Niugini" },
                    Region = "Oceania",
                    SubRegion = "Melanesia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.IDN },
                    Landlocked = false,
                    Area = 462840,
                };
            }
        }
        public static Country Poland
        {
            get
            {
                return new Country
                {
                    CommonName = "Poland",
                    OfficialName = "Republic of Poland",
                    TLD = new[] { ".pl" },
                    CountryCode = CountryCode.PL,
                    ISONumeric = "616",
                    ISO3 = CountryCodeISO3.POL,
                    CIOC = "POL",
                    Currencies = new[] { "PLN" },
                    CallingCodes = new[] { "48" },
                    Capital = "Warsaw",
                    AlternativeSpellings = new[] { "PL", "Republic of Poland", "Rzeczpospolita Polska" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BLR, CountryCodeISO3.CZE, CountryCodeISO3.DEU, CountryCodeISO3.LTU, CountryCodeISO3.RUS, CountryCodeISO3.SVK, CountryCodeISO3.UKR },
                    Landlocked = false,
                    Area = 312679,
                };
            }
        }
        public static Country PuertoRico
        {
            get
            {
                return new Country
                {
                    CommonName = "Puerto Rico",
                    OfficialName = "Commonwealth of Puerto Rico",
                    TLD = new[] { ".pr" },
                    CountryCode = CountryCode.PR,
                    ISONumeric = "630",
                    ISO3 = CountryCodeISO3.PRI,
                    CIOC = "PUR",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "1787", "1939" },
                    Capital = "San Juan",
                    AlternativeSpellings = new[] { "PR", "Commonwealth of Puerto Rico", "Estado Libre Asociado de Puerto Rico" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 8870,
                };
            }
        }
        public static Country NorthKorea
        {
            get
            {
                return new Country
                {
                    CommonName = "North Korea",
                    OfficialName = "Democratic People's Republic of Korea",
                    TLD = new[] { ".kp" },
                    CountryCode = CountryCode.KP,
                    ISONumeric = "408",
                    ISO3 = CountryCodeISO3.PRK,
                    CIOC = "PRK",
                    Currencies = new[] { "KPW" },
                    CallingCodes = new[] { "850" },
                    Capital = "Pyongyang",
                    AlternativeSpellings = new[] { "KP", "Democratic People's Republic of Korea", "조선민주주의인민공화국", "Chosŏn Minjujuŭi Inmin Konghwaguk", "Korea, Democratic People's Republic of" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CHN, CountryCodeISO3.KOR, CountryCodeISO3.RUS },
                    Landlocked = false,
                    Area = 120538,
                };
            }
        }
        public static Country Portugal
        {
            get
            {
                return new Country
                {
                    CommonName = "Portugal",
                    OfficialName = "Portuguese Republic",
                    TLD = new[] { ".pt" },
                    CountryCode = CountryCode.PT,
                    ISONumeric = "620",
                    ISO3 = CountryCodeISO3.PRT,
                    CIOC = "POR",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "351" },
                    Capital = "Lisbon",
                    AlternativeSpellings = new[] { "PT", "Portuguesa", "Portuguese Republic", "República Portuguesa" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ESP },
                    Landlocked = false,
                    Area = 92090,
                };
            }
        }
        public static Country Paraguay
        {
            get
            {
                return new Country
                {
                    CommonName = "Paraguay",
                    OfficialName = "Republic of Paraguay",
                    TLD = new[] { ".py" },
                    CountryCode = CountryCode.PY,
                    ISONumeric = "600",
                    ISO3 = CountryCodeISO3.PRY,
                    CIOC = "PAR",
                    Currencies = new[] { "PYG" },
                    CallingCodes = new[] { "595" },
                    Capital = "Asunción",
                    AlternativeSpellings = new[] { "PY", "Republic of Paraguay", "República del Paraguay", "Tetã Paraguái" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ARG, CountryCodeISO3.BOL, CountryCodeISO3.BRA },
                    Landlocked = true,
                    Area = 406752,
                };
            }
        }
        public static Country Palestine
        {
            get
            {
                return new Country
                {
                    CommonName = "Palestine",
                    OfficialName = "State of Palestine",
                    TLD = new[] { ".ps", "فلسطين." },
                    CountryCode = CountryCode.PS,
                    ISONumeric = "275",
                    ISO3 = CountryCodeISO3.PSE,
                    CIOC = "PLE",
                    Currencies = new[] { "ILS" },
                    CallingCodes = new[] { "970" },
                    Capital = "Ramallah",
                    AlternativeSpellings = new[] { "PS", "Palestine, State of", "State of Palestine", "Dawlat Filasṭin" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ISR, CountryCodeISO3.EGY, CountryCodeISO3.JOR },
                    Landlocked = false,
                    Area = 6220,
                };
            }
        }
        public static Country FrenchPolynesia
        {
            get
            {
                return new Country
                {
                    CommonName = "French Polynesia",
                    OfficialName = "French Polynesia",
                    TLD = new[] { ".pf" },
                    CountryCode = CountryCode.PF,
                    ISONumeric = "258",
                    ISO3 = CountryCodeISO3.PYF,
                    CIOC = "",
                    Currencies = new[] { "XPF" },
                    CallingCodes = new[] { "689" },
                    Capital = "Papeetē",
                    AlternativeSpellings = new[] { "PF", "Polynésie française", "French Polynesia", "Pōrīnetia Farāni" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 4167,
                };
            }
        }
        public static Country Qatar
        {
            get
            {
                return new Country
                {
                    CommonName = "Qatar",
                    OfficialName = "State of Qatar",
                    TLD = new[] { ".qa", "قطر." },
                    CountryCode = CountryCode.QA,
                    ISONumeric = "634",
                    ISO3 = CountryCodeISO3.QAT,
                    CIOC = "QAT",
                    Currencies = new[] { "QAR" },
                    CallingCodes = new[] { "974" },
                    Capital = "Doha",
                    AlternativeSpellings = new[] { "QA", "State of Qatar", "Dawlat Qaṭar" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.SAU },
                    Landlocked = false,
                    Area = 11586,
                };
            }
        }
        public static Country Réunion
        {
            get
            {
                return new Country
                {
                    CommonName = "Réunion",
                    OfficialName = "Réunion Island",
                    TLD = new[] { ".re" },
                    CountryCode = CountryCode.RE,
                    ISONumeric = "638",
                    ISO3 = CountryCodeISO3.REU,
                    CIOC = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "262" },
                    Capital = "Saint-Denis",
                    AlternativeSpellings = new[] { "RE", "Reunion" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 2511,
                };
            }
        }
        public static Country Romania
        {
            get
            {
                return new Country
                {
                    CommonName = "Romania",
                    OfficialName = "Romania",
                    TLD = new[] { ".ro" },
                    CountryCode = CountryCode.RO,
                    ISONumeric = "642",
                    ISO3 = CountryCodeISO3.ROU,
                    CIOC = "ROU",
                    Currencies = new[] { "RON" },
                    CallingCodes = new[] { "40" },
                    Capital = "Bucharest",
                    AlternativeSpellings = new[] { "RO", "Rumania", "Roumania", "România" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BGR, CountryCodeISO3.HUN, CountryCodeISO3.MDA, CountryCodeISO3.SRB, CountryCodeISO3.UKR },
                    Landlocked = false,
                    Area = 238391,
                };
            }
        }
        public static Country Russia
        {
            get
            {
                return new Country
                {
                    CommonName = "Russia",
                    OfficialName = "Russian Federation",
                    TLD = new[] { ".ru", ".su", ".рф" },
                    CountryCode = CountryCode.RU,
                    ISONumeric = "643",
                    ISO3 = CountryCodeISO3.RUS,
                    CIOC = "RUS",
                    Currencies = new[] { "RUB" },
                    CallingCodes = new[] { "7" },
                    Capital = "Moscow",
                    AlternativeSpellings = new[] { "RU", "Rossiya", "Russian Federation", "Российская Федерация", "Rossiyskaya Federatsiya" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AZE, CountryCodeISO3.BLR, CountryCodeISO3.CHN, CountryCodeISO3.EST, CountryCodeISO3.FIN, CountryCodeISO3.GEO, CountryCodeISO3.KAZ, CountryCodeISO3.PRK, CountryCodeISO3.LVA, CountryCodeISO3.LTU, CountryCodeISO3.MNG, CountryCodeISO3.NOR, CountryCodeISO3.POL, CountryCodeISO3.UKR },
                    Landlocked = false,
                    Area = 17098242,
                };
            }
        }
        public static Country Rwanda
        {
            get
            {
                return new Country
                {
                    CommonName = "Rwanda",
                    OfficialName = "Republic of Rwanda",
                    TLD = new[] { ".rw" },
                    CountryCode = CountryCode.RW,
                    ISONumeric = "646",
                    ISO3 = CountryCodeISO3.RWA,
                    CIOC = "RWA",
                    Currencies = new[] { "RWF" },
                    CallingCodes = new[] { "250" },
                    Capital = "Kigali",
                    AlternativeSpellings = new[] { "RW", "Republic of Rwanda", "Repubulika y'u Rwanda", "République du Rwanda" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BDI, CountryCodeISO3.COD, CountryCodeISO3.TZA, CountryCodeISO3.UGA },
                    Landlocked = true,
                    Area = 26338,
                };
            }
        }
        public static Country SaudiArabia
        {
            get
            {
                return new Country
                {
                    CommonName = "Saudi Arabia",
                    OfficialName = "Kingdom of Saudi Arabia",
                    TLD = new[] { ".sa", ".السعودية" },
                    CountryCode = CountryCode.SA,
                    ISONumeric = "682",
                    ISO3 = CountryCodeISO3.SAU,
                    CIOC = "KSA",
                    Currencies = new[] { "SAR" },
                    CallingCodes = new[] { "966" },
                    Capital = "Riyadh",
                    AlternativeSpellings = new[] { "Saudi", "SA", "Kingdom of Saudi Arabia", "Al-Mamlakah al-‘Arabiyyah as-Su‘ūdiyyah" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.IRQ, CountryCodeISO3.JOR, CountryCodeISO3.KWT, CountryCodeISO3.OMN, CountryCodeISO3.QAT, CountryCodeISO3.ARE, CountryCodeISO3.YEM },
                    Landlocked = false,
                    Area = 2149690,
                };
            }
        }
        public static Country Sudan
        {
            get
            {
                return new Country
                {
                    CommonName = "Sudan",
                    OfficialName = "Republic of the Sudan",
                    TLD = new[] { ".sd" },
                    CountryCode = CountryCode.SD,
                    ISONumeric = "729",
                    ISO3 = CountryCodeISO3.SDN,
                    CIOC = "SUD",
                    Currencies = new[] { "SDG" },
                    CallingCodes = new[] { "249" },
                    Capital = "Khartoum",
                    AlternativeSpellings = new[] { "SD", "Republic of the Sudan", "Jumhūrīyat as-Sūdān" },
                    Region = "Africa",
                    SubRegion = "Northern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CAF, CountryCodeISO3.TCD, CountryCodeISO3.EGY, CountryCodeISO3.ERI, CountryCodeISO3.ETH, CountryCodeISO3.LBY, CountryCodeISO3.SSD },
                    Landlocked = false,
                    Area = 1886068,
                };
            }
        }
        public static Country Senegal
        {
            get
            {
                return new Country
                {
                    CommonName = "Senegal",
                    OfficialName = "Republic of Senegal",
                    TLD = new[] { ".sn" },
                    CountryCode = CountryCode.SN,
                    ISONumeric = "686",
                    ISO3 = CountryCodeISO3.SEN,
                    CIOC = "SEN",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "221" },
                    Capital = "Dakar",
                    AlternativeSpellings = new[] { "SN", "Republic of Senegal", "République du Sénégal" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.GMB, CountryCodeISO3.GIN, CountryCodeISO3.GNB, CountryCodeISO3.MLI, CountryCodeISO3.MRT },
                    Landlocked = false,
                    Area = 196722,
                };
            }
        }
        public static Country Singapore
        {
            get
            {
                return new Country
                {
                    CommonName = "Singapore",
                    OfficialName = "Republic of Singapore",
                    TLD = new[] { ".sg", ".新加坡", ".சிங்கப்பூர்" },
                    CountryCode = CountryCode.SG,
                    ISONumeric = "702",
                    ISO3 = CountryCodeISO3.SGP,
                    CIOC = "SIN",
                    Currencies = new[] { "SGD" },
                    CallingCodes = new[] { "65" },
                    Capital = "Singapore",
                    AlternativeSpellings = new[] { "SG", "Singapura", "Republik Singapura", "新加坡共和国" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 710,
                };
            }
        }
        public static Country SouthGeorgia
        {
            get
            {
                return new Country
                {
                    CommonName = "South Georgia",
                    OfficialName = "South Georgia and the South Sandwich Islands",
                    TLD = new[] { ".gs" },
                    CountryCode = CountryCode.GS,
                    ISONumeric = "239",
                    ISO3 = CountryCodeISO3.SGS,
                    CIOC = "",
                    Currencies = new[] { "GBP" },
                    CallingCodes = new[] { "500" },
                    Capital = "King Edward Point",
                    AlternativeSpellings = new[] { "GS", "South Georgia and the South Sandwich Islands" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 3903,
                };
            }
        }
        public static Country SvalbardandJanMayen
        {
            get
            {
                return new Country
                {
                    CommonName = "Svalbard and Jan Mayen",
                    OfficialName = "Svalbard og Jan Mayen",
                    TLD = new[] { ".sj" },
                    CountryCode = CountryCode.SJ,
                    ISONumeric = "744",
                    ISO3 = CountryCodeISO3.SJM,
                    CIOC = "",
                    Currencies = new[] { "NOK" },
                    CallingCodes = new[] { "4779" },
                    Capital = "Longyearbyen",
                    AlternativeSpellings = new[] { "SJ", "Svalbard and Jan Mayen Islands" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = -1,
                };
            }
        }
        public static Country SolomonIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Solomon Islands",
                    OfficialName = "Solomon Islands",
                    TLD = new[] { ".sb" },
                    CountryCode = CountryCode.SB,
                    ISONumeric = "090",
                    ISO3 = CountryCodeISO3.SLB,
                    CIOC = "SOL",
                    Currencies = new[] { "SDB" },
                    CallingCodes = new[] { "677" },
                    Capital = "Honiara",
                    AlternativeSpellings = new[] { "SB" },
                    Region = "Oceania",
                    SubRegion = "Melanesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 28896,
                };
            }
        }
        public static Country SierraLeone
        {
            get
            {
                return new Country
                {
                    CommonName = "Sierra Leone",
                    OfficialName = "Republic of Sierra Leone",
                    TLD = new[] { ".sl" },
                    CountryCode = CountryCode.SL,
                    ISONumeric = "694",
                    ISO3 = CountryCodeISO3.SLE,
                    CIOC = "SLE",
                    Currencies = new[] { "SLL" },
                    CallingCodes = new[] { "232" },
                    Capital = "Freetown",
                    AlternativeSpellings = new[] { "SL", "Republic of Sierra Leone" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.GIN, CountryCodeISO3.LBR },
                    Landlocked = false,
                    Area = 71740,
                };
            }
        }
        public static Country ElSalvador
        {
            get
            {
                return new Country
                {
                    CommonName = "El Salvador",
                    OfficialName = "Republic of El Salvador",
                    TLD = new[] { ".sv" },
                    CountryCode = CountryCode.SV,
                    ISONumeric = "222",
                    ISO3 = CountryCodeISO3.SLV,
                    CIOC = "ESA",
                    Currencies = new[] { "SVC", "USD" },
                    CallingCodes = new[] { "503" },
                    Capital = "San Salvador",
                    AlternativeSpellings = new[] { "SV", "Republic of El Salvador", "República de El Salvador" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.GTM, CountryCodeISO3.HND },
                    Landlocked = false,
                    Area = 21041,
                };
            }
        }
        public static Country SanMarino
        {
            get
            {
                return new Country
                {
                    CommonName = "San Marino",
                    OfficialName = "Most Serene Republic of San Marino",
                    TLD = new[] { ".sm" },
                    CountryCode = CountryCode.SM,
                    ISONumeric = "674",
                    ISO3 = CountryCodeISO3.SMR,
                    CIOC = "SMR",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "378" },
                    Capital = "City of San Marino",
                    AlternativeSpellings = new[] { "SM", "Republic of San Marino", "Repubblica di San Marino" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ITA },
                    Landlocked = true,
                    Area = 61,
                };
            }
        }
        public static Country Somalia
        {
            get
            {
                return new Country
                {
                    CommonName = "Somalia",
                    OfficialName = "Federal Republic of Somalia",
                    TLD = new[] { ".so" },
                    CountryCode = CountryCode.SO,
                    ISONumeric = "706",
                    ISO3 = CountryCodeISO3.SOM,
                    CIOC = "SOM",
                    Currencies = new[] { "SOS" },
                    CallingCodes = new[] { "252" },
                    Capital = "Mogadishu",
                    AlternativeSpellings = new[] { "SO", "aṣ-Ṣūmāl", "Federal Republic of Somalia", "Jamhuuriyadda Federaalka Soomaaliya", "Jumhūriyyat aṣ-Ṣūmāl al-Fiderāliyya" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.DJI, CountryCodeISO3.ETH, CountryCodeISO3.KEN },
                    Landlocked = false,
                    Area = 637657,
                };
            }
        }
        public static Country SaintPierreandMiquelon
        {
            get
            {
                return new Country
                {
                    CommonName = "Saint Pierre and Miquelon",
                    OfficialName = "Saint Pierre and Miquelon",
                    TLD = new[] { ".pm" },
                    CountryCode = CountryCode.PM,
                    ISONumeric = "666",
                    ISO3 = CountryCodeISO3.SPM,
                    CIOC = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "508" },
                    Capital = "Saint-Pierre",
                    AlternativeSpellings = new[] { "PM", "Collectivité territoriale de Saint-Pierre-et-Miquelon" },
                    Region = "Americas",
                    SubRegion = "Northern America",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 242,
                };
            }
        }
        public static Country Serbia
        {
            get
            {
                return new Country
                {
                    CommonName = "Serbia",
                    OfficialName = "Republic of Serbia",
                    TLD = new[] { ".rs", ".срб" },
                    CountryCode = CountryCode.RS,
                    ISONumeric = "688",
                    ISO3 = CountryCodeISO3.SRB,
                    CIOC = "SRB",
                    Currencies = new[] { "RSD" },
                    CallingCodes = new[] { "381" },
                    Capital = "Belgrade",
                    AlternativeSpellings = new[] { "RS", "Srbija", "Republic of Serbia", "Република Србија", "Republika Srbija" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BIH, CountryCodeISO3.BGR, CountryCodeISO3.HRV, CountryCodeISO3.HUN, CountryCodeISO3.KOS, CountryCodeISO3.MKD, CountryCodeISO3.MNE, CountryCodeISO3.ROU },
                    Landlocked = true,
                    Area = 88361,
                };
            }
        }
        public static Country SouthSudan
        {
            get
            {
                return new Country
                {
                    CommonName = "South Sudan",
                    OfficialName = "Republic of South Sudan",
                    TLD = new[] { ".ss" },
                    CountryCode = CountryCode.SS,
                    ISONumeric = "728",
                    ISO3 = CountryCodeISO3.SSD,
                    CIOC = "",
                    Currencies = new[] { "SSP" },
                    CallingCodes = new[] { "211" },
                    Capital = "Juba",
                    AlternativeSpellings = new[] { "SS" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CAF, CountryCodeISO3.COD, CountryCodeISO3.ETH, CountryCodeISO3.KEN, CountryCodeISO3.SDN, CountryCodeISO3.UGA },
                    Landlocked = true,
                    Area = 619745,
                };
            }
        }
        public static Country SãoToméandPríncipe
        {
            get
            {
                return new Country
                {
                    CommonName = "São Tomé and Príncipe",
                    OfficialName = "Democratic Republic of São Tomé and Príncipe",
                    TLD = new[] { ".st" },
                    CountryCode = CountryCode.ST,
                    ISONumeric = "678",
                    ISO3 = CountryCodeISO3.STP,
                    CIOC = "STP",
                    Currencies = new[] { "STD" },
                    CallingCodes = new[] { "239" },
                    Capital = "São Tomé",
                    AlternativeSpellings = new[] { "ST", "Democratic Republic of São Tomé and Príncipe", "Sao Tome and Principe", "República Democrática de São Tomé e Príncipe" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 964,
                };
            }
        }
        public static Country Suriname
        {
            get
            {
                return new Country
                {
                    CommonName = "Suriname",
                    OfficialName = "Republic of Suriname",
                    TLD = new[] { ".sr" },
                    CountryCode = CountryCode.SR,
                    ISONumeric = "740",
                    ISO3 = CountryCodeISO3.SUR,
                    CIOC = "SUR",
                    Currencies = new[] { "SRD" },
                    CallingCodes = new[] { "597" },
                    Capital = "Paramaribo",
                    AlternativeSpellings = new[] { "SR", "Sarnam", "Sranangron", "Republic of Suriname", "Republiek Suriname" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BRA, CountryCodeISO3.GUF, CountryCodeISO3.GUY },
                    Landlocked = false,
                    Area = 163820,
                };
            }
        }
        public static Country Slovakia
        {
            get
            {
                return new Country
                {
                    CommonName = "Slovakia",
                    OfficialName = "Slovak Republic",
                    TLD = new[] { ".sk" },
                    CountryCode = CountryCode.SK,
                    ISONumeric = "703",
                    ISO3 = CountryCodeISO3.SVK,
                    CIOC = "SVK",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "421" },
                    Capital = "Bratislava",
                    AlternativeSpellings = new[] { "SK", "Slovak Republic", "Slovenská republika" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AUT, CountryCodeISO3.CZE, CountryCodeISO3.HUN, CountryCodeISO3.POL, CountryCodeISO3.UKR },
                    Landlocked = true,
                    Area = 49037,
                };
            }
        }
        public static Country Slovenia
        {
            get
            {
                return new Country
                {
                    CommonName = "Slovenia",
                    OfficialName = "Republic of Slovenia",
                    TLD = new[] { ".si" },
                    CountryCode = CountryCode.SI,
                    ISONumeric = "705",
                    ISO3 = CountryCodeISO3.SVN,
                    CIOC = "SLO",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "386" },
                    Capital = "Ljubljana",
                    AlternativeSpellings = new[] { "SI", "Republic of Slovenia", "Republika Slovenija" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AUT, CountryCodeISO3.HRV, CountryCodeISO3.ITA, CountryCodeISO3.HUN },
                    Landlocked = false,
                    Area = 20273,
                };
            }
        }
        public static Country Sweden
        {
            get
            {
                return new Country
                {
                    CommonName = "Sweden",
                    OfficialName = "Kingdom of Sweden",
                    TLD = new[] { ".se" },
                    CountryCode = CountryCode.SE,
                    ISONumeric = "752",
                    ISO3 = CountryCodeISO3.SWE,
                    CIOC = "SWE",
                    Currencies = new[] { "SEK" },
                    CallingCodes = new[] { "46" },
                    Capital = "Stockholm",
                    AlternativeSpellings = new[] { "SE", "Kingdom of Sweden", "Konungariket Sverige" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.FIN, CountryCodeISO3.NOR },
                    Landlocked = false,
                    Area = 450295,
                };
            }
        }
        public static Country Swaziland
        {
            get
            {
                return new Country
                {
                    CommonName = "Swaziland",
                    OfficialName = "Kingdom of Swaziland",
                    TLD = new[] { ".sz" },
                    CountryCode = CountryCode.SZ,
                    ISONumeric = "748",
                    ISO3 = CountryCodeISO3.SWZ,
                    CIOC = "SWZ",
                    Currencies = new[] { "SZL" },
                    CallingCodes = new[] { "268" },
                    Capital = "Lobamba",
                    AlternativeSpellings = new[] { "SZ", "weSwatini", "Swatini", "Ngwane", "Kingdom of Swaziland", "Umbuso waseSwatini" },
                    Region = "Africa",
                    SubRegion = "Southern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.MOZ, CountryCodeISO3.ZAF },
                    Landlocked = true,
                    Area = 17364,
                };
            }
        }
        public static Country SintMaarten
        {
            get
            {
                return new Country
                {
                    CommonName = "Sint Maarten",
                    OfficialName = "Sint Maarten",
                    TLD = new[] { ".sx" },
                    CountryCode = CountryCode.SX,
                    ISONumeric = "534",
                    ISO3 = CountryCodeISO3.SXM,
                    CIOC = "",
                    Currencies = new[] { "ANG" },
                    CallingCodes = new[] { "1721" },
                    Capital = "Philipsburg",
                    AlternativeSpellings = new[] { "SX", "Sint Maarten (Dutch part)" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.MAF },
                    Landlocked = false,
                    Area = 34,
                };
            }
        }
        public static Country Seychelles
        {
            get
            {
                return new Country
                {
                    CommonName = "Seychelles",
                    OfficialName = "Republic of Seychelles",
                    TLD = new[] { ".sc" },
                    CountryCode = CountryCode.SC,
                    ISONumeric = "690",
                    ISO3 = CountryCodeISO3.SYC,
                    CIOC = "SEY",
                    Currencies = new[] { "SCR" },
                    CallingCodes = new[] { "248" },
                    Capital = "Victoria",
                    AlternativeSpellings = new[] { "SC", "Republic of Seychelles", "Repiblik Sesel", "République des Seychelles" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 452,
                };
            }
        }
        public static Country Syria
        {
            get
            {
                return new Country
                {
                    CommonName = "Syria",
                    OfficialName = "Syrian Arab Republic",
                    TLD = new[] { ".sy", "سوريا." },
                    CountryCode = CountryCode.SY,
                    ISONumeric = "760",
                    ISO3 = CountryCodeISO3.SYR,
                    CIOC = "SYR",
                    Currencies = new[] { "SYP" },
                    CallingCodes = new[] { "963" },
                    Capital = "Damascus",
                    AlternativeSpellings = new[] { "SY", "Syrian Arab Republic", "Al-Jumhūrīyah Al-ʻArabīyah As-Sūrīyah" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.IRQ, CountryCodeISO3.ISR, CountryCodeISO3.JOR, CountryCodeISO3.LBN, CountryCodeISO3.TUR },
                    Landlocked = false,
                    Area = 185180,
                };
            }
        }
        public static Country TurksandCaicosIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Turks and Caicos Islands",
                    OfficialName = "Turks and Caicos Islands",
                    TLD = new[] { ".tc" },
                    CountryCode = CountryCode.TC,
                    ISONumeric = "796",
                    ISO3 = CountryCodeISO3.TCA,
                    CIOC = "",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "1649" },
                    Capital = "Cockburn Town",
                    AlternativeSpellings = new[] { "TC" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 948,
                };
            }
        }
        public static Country Chad
        {
            get
            {
                return new Country
                {
                    CommonName = "Chad",
                    OfficialName = "Republic of Chad",
                    TLD = new[] { ".td" },
                    CountryCode = CountryCode.TD,
                    ISONumeric = "148",
                    ISO3 = CountryCodeISO3.TCD,
                    CIOC = "CHA",
                    Currencies = new[] { "XAF" },
                    CallingCodes = new[] { "235" },
                    Capital = "N'Djamena",
                    AlternativeSpellings = new[] { "TD", "Tchad", "Republic of Chad", "République du Tchad" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CMR, CountryCodeISO3.CAF, CountryCodeISO3.LBY, CountryCodeISO3.NER, CountryCodeISO3.NGA, CountryCodeISO3.SSD },
                    Landlocked = true,
                    Area = 1284000,
                };
            }
        }
        public static Country Togo
        {
            get
            {
                return new Country
                {
                    CommonName = "Togo",
                    OfficialName = "Togolese Republic",
                    TLD = new[] { ".tg" },
                    CountryCode = CountryCode.TG,
                    ISONumeric = "768",
                    ISO3 = CountryCodeISO3.TGO,
                    CIOC = "TOG",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "228" },
                    Capital = "Lomé",
                    AlternativeSpellings = new[] { "TG", "Togolese", "Togolese Republic", "République Togolaise" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BEN, CountryCodeISO3.BFA, CountryCodeISO3.GHA },
                    Landlocked = false,
                    Area = 56785,
                };
            }
        }
        public static Country Thailand
        {
            get
            {
                return new Country
                {
                    CommonName = "Thailand",
                    OfficialName = "Kingdom of Thailand",
                    TLD = new[] { ".th", ".ไทย" },
                    CountryCode = CountryCode.TH,
                    ISONumeric = "764",
                    ISO3 = CountryCodeISO3.THA,
                    CIOC = "THA",
                    Currencies = new[] { "THB" },
                    CallingCodes = new[] { "66" },
                    Capital = "Bangkok",
                    AlternativeSpellings = new[] { "TH", "Prathet", "Thai", "Kingdom of Thailand", "ราชอาณาจักรไทย", "Ratcha Anachak Thai" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.MMR, CountryCodeISO3.KHM, CountryCodeISO3.LAO, CountryCodeISO3.MYS },
                    Landlocked = false,
                    Area = 513120,
                };
            }
        }
        public static Country Tajikistan
        {
            get
            {
                return new Country
                {
                    CommonName = "Tajikistan",
                    OfficialName = "Republic of Tajikistan",
                    TLD = new[] { ".tj" },
                    CountryCode = CountryCode.TJ,
                    ISONumeric = "762",
                    ISO3 = CountryCodeISO3.TJK,
                    CIOC = "TJK",
                    Currencies = new[] { "TJS" },
                    CallingCodes = new[] { "992" },
                    Capital = "Dushanbe",
                    AlternativeSpellings = new[] { "TJ", "Toçikiston", "Republic of Tajikistan", "Ҷумҳурии Тоҷикистон", "Çumhuriyi Toçikiston" },
                    Region = "Asia",
                    SubRegion = "Central Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AFG, CountryCodeISO3.CHN, CountryCodeISO3.KGZ, CountryCodeISO3.UZB },
                    Landlocked = true,
                    Area = 143100,
                };
            }
        }
        public static Country Tokelau
        {
            get
            {
                return new Country
                {
                    CommonName = "Tokelau",
                    OfficialName = "Tokelau",
                    TLD = new[] { ".tk" },
                    CountryCode = CountryCode.TK,
                    ISONumeric = "772",
                    ISO3 = CountryCodeISO3.TKL,
                    CIOC = "",
                    Currencies = new[] { "NZD" },
                    CallingCodes = new[] { "690" },
                    Capital = "Fakaofo",
                    AlternativeSpellings = new[] { "TK" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 12,
                };
            }
        }
        public static Country Turkmenistan
        {
            get
            {
                return new Country
                {
                    CommonName = "Turkmenistan",
                    OfficialName = "Turkmenistan",
                    TLD = new[] { ".tm" },
                    CountryCode = CountryCode.TM,
                    ISONumeric = "795",
                    ISO3 = CountryCodeISO3.TKM,
                    CIOC = "TKM",
                    Currencies = new[] { "TMT" },
                    CallingCodes = new[] { "993" },
                    Capital = "Ashgabat",
                    AlternativeSpellings = new[] { "TM" },
                    Region = "Asia",
                    SubRegion = "Central Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AFG, CountryCodeISO3.IRN, CountryCodeISO3.KAZ, CountryCodeISO3.UZB },
                    Landlocked = true,
                    Area = 488100,
                };
            }
        }
        public static Country TimorLeste
        {
            get
            {
                return new Country
                {
                    CommonName = "Timor-Leste",
                    OfficialName = "Democratic Republic of Timor-Leste",
                    TLD = new[] { ".tl" },
                    CountryCode = CountryCode.TL,
                    ISONumeric = "626",
                    ISO3 = CountryCodeISO3.TLS,
                    CIOC = "TLS",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "670" },
                    Capital = "Dili",
                    AlternativeSpellings = new[] { "TL", "East Timor", "Democratic Republic of Timor-Leste", "República Democrática de Timor-Leste", "Repúblika Demokrátika Timór-Leste", "Timór Lorosa'e", "Timor Lorosae" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.IDN },
                    Landlocked = false,
                    Area = 14874,
                };
            }
        }
        public static Country Tonga
        {
            get
            {
                return new Country
                {
                    CommonName = "Tonga",
                    OfficialName = "Kingdom of Tonga",
                    TLD = new[] { ".to" },
                    CountryCode = CountryCode.TO,
                    ISONumeric = "776",
                    ISO3 = CountryCodeISO3.TON,
                    CIOC = "TGA",
                    Currencies = new[] { "TOP" },
                    CallingCodes = new[] { "676" },
                    Capital = "Nuku'alofa",
                    AlternativeSpellings = new[] { "TO" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 747,
                };
            }
        }
        public static Country TrinidadandTobago
        {
            get
            {
                return new Country
                {
                    CommonName = "Trinidad and Tobago",
                    OfficialName = "Republic of Trinidad and Tobago",
                    TLD = new[] { ".tt" },
                    CountryCode = CountryCode.TT,
                    ISONumeric = "780",
                    ISO3 = CountryCodeISO3.TTO,
                    CIOC = "TTO",
                    Currencies = new[] { "TTD" },
                    CallingCodes = new[] { "1868" },
                    Capital = "Port of Spain",
                    AlternativeSpellings = new[] { "TT", "Republic of Trinidad and Tobago" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 5130,
                };
            }
        }
        public static Country Tunisia
        {
            get
            {
                return new Country
                {
                    CommonName = "Tunisia",
                    OfficialName = "Tunisian Republic",
                    TLD = new[] { ".tn" },
                    CountryCode = CountryCode.TN,
                    ISONumeric = "788",
                    ISO3 = CountryCodeISO3.TUN,
                    CIOC = "TUN",
                    Currencies = new[] { "TND" },
                    CallingCodes = new[] { "216" },
                    Capital = "Tunis",
                    AlternativeSpellings = new[] { "TN", "Republic of Tunisia", "al-Jumhūriyyah at-Tūnisiyyah" },
                    Region = "Africa",
                    SubRegion = "Northern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.DZA, CountryCodeISO3.LBY },
                    Landlocked = false,
                    Area = 163610,
                };
            }
        }
        public static Country Turkey
        {
            get
            {
                return new Country
                {
                    CommonName = "Turkey",
                    OfficialName = "Republic of Turkey",
                    TLD = new[] { ".tr" },
                    CountryCode = CountryCode.TR,
                    ISONumeric = "792",
                    ISO3 = CountryCodeISO3.TUR,
                    CIOC = "TUR",
                    Currencies = new[] { "TRY" },
                    CallingCodes = new[] { "90" },
                    Capital = "Ankara",
                    AlternativeSpellings = new[] { "TR", "Turkiye", "Republic of Turkey", "Türkiye Cumhuriyeti" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ARM, CountryCodeISO3.AZE, CountryCodeISO3.BGR, CountryCodeISO3.GEO, CountryCodeISO3.GRC, CountryCodeISO3.IRN, CountryCodeISO3.IRQ, CountryCodeISO3.SYR },
                    Landlocked = false,
                    Area = 783562,
                };
            }
        }
        public static Country Tuvalu
        {
            get
            {
                return new Country
                {
                    CommonName = "Tuvalu",
                    OfficialName = "Tuvalu",
                    TLD = new[] { ".tv" },
                    CountryCode = CountryCode.TV,
                    ISONumeric = "798",
                    ISO3 = CountryCodeISO3.TUV,
                    CIOC = "TUV",
                    Currencies = new[] { "AUD" },
                    CallingCodes = new[] { "688" },
                    Capital = "Funafuti",
                    AlternativeSpellings = new[] { "TV" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 26,
                };
            }
        }
        public static Country Taiwan
        {
            get
            {
                return new Country
                {
                    CommonName = "Taiwan",
                    OfficialName = "Republic of China",
                    TLD = new[] { ".tw", ".台湾", ".台灣" },
                    CountryCode = CountryCode.TW,
                    ISONumeric = "158",
                    ISO3 = CountryCodeISO3.TWN,
                    CIOC = "TPE",
                    Currencies = new[] { "TWD" },
                    CallingCodes = new[] { "886" },
                    Capital = "Taipei",
                    AlternativeSpellings = new[] { "TW", "Táiwān", "Republic of China", "中華民國", "Zhōnghuá Mínguó", "Chinese Taipei for IOC", "Taiwan, Province of China" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 36193,
                };
            }
        }
        public static Country Tanzania
        {
            get
            {
                return new Country
                {
                    CommonName = "Tanzania",
                    OfficialName = "United Republic of Tanzania",
                    TLD = new[] { ".tz" },
                    CountryCode = CountryCode.TZ,
                    ISONumeric = "834",
                    ISO3 = CountryCodeISO3.TZA,
                    CIOC = "TAN",
                    Currencies = new[] { "TZS" },
                    CallingCodes = new[] { "255" },
                    Capital = "Dodoma",
                    AlternativeSpellings = new[] { "TZ", "Tanzania, United Republic of", "United Republic of Tanzania", "Jamhuri ya Muungano wa Tanzania" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BDI, CountryCodeISO3.COD, CountryCodeISO3.KEN, CountryCodeISO3.MWI, CountryCodeISO3.MOZ, CountryCodeISO3.RWA, CountryCodeISO3.UGA, CountryCodeISO3.ZMB },
                    Landlocked = false,
                    Area = 945087,
                };
            }
        }
        public static Country Uganda
        {
            get
            {
                return new Country
                {
                    CommonName = "Uganda",
                    OfficialName = "Republic of Uganda",
                    TLD = new[] { ".ug" },
                    CountryCode = CountryCode.UG,
                    ISONumeric = "800",
                    ISO3 = CountryCodeISO3.UGA,
                    CIOC = "UGA",
                    Currencies = new[] { "UGX" },
                    CallingCodes = new[] { "256" },
                    Capital = "Kampala",
                    AlternativeSpellings = new[] { "UG", "Republic of Uganda", "Jamhuri ya Uganda" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.COD, CountryCodeISO3.KEN, CountryCodeISO3.RWA, CountryCodeISO3.SSD, CountryCodeISO3.TZA },
                    Landlocked = true,
                    Area = 241550,
                };
            }
        }
        public static Country Ukraine
        {
            get
            {
                return new Country
                {
                    CommonName = "Ukraine",
                    OfficialName = "Ukraine",
                    TLD = new[] { ".ua", ".укр" },
                    CountryCode = CountryCode.UA,
                    ISONumeric = "804",
                    ISO3 = CountryCodeISO3.UKR,
                    CIOC = "UKR",
                    Currencies = new[] { "UAH" },
                    CallingCodes = new[] { "380" },
                    Capital = "Kiev",
                    AlternativeSpellings = new[] { "UA", "Ukrayina" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BLR, CountryCodeISO3.HUN, CountryCodeISO3.MDA, CountryCodeISO3.POL, CountryCodeISO3.ROU, CountryCodeISO3.RUS, CountryCodeISO3.SVK },
                    Landlocked = false,
                    Area = 603500,
                };
            }
        }
        public static Country UnitedStatesMinorOutlyingIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "United States Minor Outlying Islands",
                    OfficialName = "United States Minor Outlying Islands",
                    TLD = new[] { ".us" },
                    CountryCode = CountryCode.UM,
                    ISONumeric = "581",
                    ISO3 = CountryCodeISO3.UMI,
                    CIOC = "",
                    Currencies = new[] { "USD" },
                    Capital = "",
                    AlternativeSpellings = new[] { "UM" },
                    Region = "Americas",
                    SubRegion = "Northern America",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 34,
                };
            }
        }
        public static Country Uruguay
        {
            get
            {
                return new Country
                {
                    CommonName = "Uruguay",
                    OfficialName = "Oriental Republic of Uruguay",
                    TLD = new[] { ".uy" },
                    CountryCode = CountryCode.UY,
                    ISONumeric = "858",
                    ISO3 = CountryCodeISO3.URY,
                    CIOC = "URU",
                    Currencies = new[] { "UYI", "UYU" },
                    CallingCodes = new[] { "598" },
                    Capital = "Montevideo",
                    AlternativeSpellings = new[] { "UY", "Oriental Republic of Uruguay", "República Oriental del Uruguay" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ARG, CountryCodeISO3.BRA },
                    Landlocked = false,
                    Area = 181034,
                };
            }
        }
        public static Country UnitedStates
        {
            get
            {
                return new Country
                {
                    CommonName = "United States",
                    OfficialName = "United States of America",
                    TLD = new[] { ".us" },
                    CountryCode = CountryCode.US,
                    ISONumeric = "840",
                    ISO3 = CountryCodeISO3.USA,
                    CIOC = "USA",
                    Currencies = new[] { "USD", "USN", "USS" },
                    CallingCodes = new[] { "1" },
                    Capital = "Washington D.C.",
                    AlternativeSpellings = new[] { "US", "USA", "United States of America" },
                    Region = "Americas",
                    SubRegion = "Northern America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.CAN, CountryCodeISO3.MEX },
                    Landlocked = false,
                    Area = 9372610,
                };
            }
        }
        public static Country Uzbekistan
        {
            get
            {
                return new Country
                {
                    CommonName = "Uzbekistan",
                    OfficialName = "Republic of Uzbekistan",
                    TLD = new[] { ".uz" },
                    CountryCode = CountryCode.UZ,
                    ISONumeric = "860",
                    ISO3 = CountryCodeISO3.UZB,
                    CIOC = "UZB",
                    Currencies = new[] { "UZS" },
                    CallingCodes = new[] { "998" },
                    Capital = "Tashkent",
                    AlternativeSpellings = new[] { "UZ", "Republic of Uzbekistan", "O‘zbekiston Respublikasi", "Ўзбекистон Республикаси" },
                    Region = "Asia",
                    SubRegion = "Central Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AFG, CountryCodeISO3.KAZ, CountryCodeISO3.KGZ, CountryCodeISO3.TJK, CountryCodeISO3.TKM },
                    Landlocked = true,
                    Area = 447400,
                };
            }
        }
        public static Country VaticanCity
        {
            get
            {
                return new Country
                {
                    CommonName = "Vatican City",
                    OfficialName = "Vatican City State",
                    TLD = new[] { ".va" },
                    CountryCode = CountryCode.VA,
                    ISONumeric = "336",
                    ISO3 = CountryCodeISO3.VAT,
                    CIOC = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "3906698", "379" },
                    Capital = "Vatican City",
                    AlternativeSpellings = new[] { "VA", "Holy See (Vatican City State)", "Vatican City State", "Stato della Città del Vaticano" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.ITA },
                    Landlocked = true,
                    Area = 0,
                };
            }
        }
        public static Country SaintVincentandtheGrenadines
        {
            get
            {
                return new Country
                {
                    CommonName = "Saint Vincent and the Grenadines",
                    OfficialName = "Saint Vincent and the Grenadines",
                    TLD = new[] { ".vc" },
                    CountryCode = CountryCode.VC,
                    ISONumeric = "670",
                    ISO3 = CountryCodeISO3.VCT,
                    CIOC = "VIN",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1784" },
                    Capital = "Kingstown",
                    AlternativeSpellings = new[] { "VC" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 389,
                };
            }
        }
        public static Country Venezuela
        {
            get
            {
                return new Country
                {
                    CommonName = "Venezuela",
                    OfficialName = "Bolivarian Republic of Venezuela",
                    TLD = new[] { ".ve" },
                    CountryCode = CountryCode.VE,
                    ISONumeric = "862",
                    ISO3 = CountryCodeISO3.VEN,
                    CIOC = "VEN",
                    Currencies = new[] { "VEF" },
                    CallingCodes = new[] { "58" },
                    Capital = "Caracas",
                    AlternativeSpellings = new[] { "VE", "Bolivarian Republic of Venezuela", "Venezuela, Bolivarian Republic of", "República Bolivariana de Venezuela" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BRA, CountryCodeISO3.COL, CountryCodeISO3.GUY },
                    Landlocked = false,
                    Area = 916445,
                };
            }
        }
        public static Country BritishVirginIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "British Virgin Islands",
                    OfficialName = "Virgin Islands",
                    TLD = new[] { ".vg" },
                    CountryCode = CountryCode.VG,
                    ISONumeric = "092",
                    ISO3 = CountryCodeISO3.VGB,
                    CIOC = "IVB",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "1284" },
                    Capital = "Road Town",
                    AlternativeSpellings = new[] { "VG", "Virgin Islands, British" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 151,
                };
            }
        }
        public static Country UnitedStatesVirginIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "United States Virgin Islands",
                    OfficialName = "Virgin Islands of the United States",
                    TLD = new[] { ".vi" },
                    CountryCode = CountryCode.VI,
                    ISONumeric = "850",
                    ISO3 = CountryCodeISO3.VIR,
                    CIOC = "ISV",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "1340" },
                    Capital = "Charlotte Amalie",
                    AlternativeSpellings = new[] { "VI", "Virgin Islands, U.S." },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 347,
                };
            }
        }
        public static Country Vietnam
        {
            get
            {
                return new Country
                {
                    CommonName = "Vietnam",
                    OfficialName = "Socialist Republic of Vietnam",
                    TLD = new[] { ".vn" },
                    CountryCode = CountryCode.VN,
                    ISONumeric = "704",
                    ISO3 = CountryCodeISO3.VNM,
                    CIOC = "VIE",
                    Currencies = new[] { "VND" },
                    CallingCodes = new[] { "84" },
                    Capital = "Hanoi",
                    AlternativeSpellings = new[] { "VN", "Socialist Republic of Vietnam", "Cộng hòa Xã hội chủ nghĩa Việt Nam", "Viet Nam" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.KHM, CountryCodeISO3.CHN, CountryCodeISO3.LAO },
                    Landlocked = false,
                    Area = 331212,
                };
            }
        }
        public static Country Vanuatu
        {
            get
            {
                return new Country
                {
                    CommonName = "Vanuatu",
                    OfficialName = "Republic of Vanuatu",
                    TLD = new[] { ".vu" },
                    CountryCode = CountryCode.VU,
                    ISONumeric = "548",
                    ISO3 = CountryCodeISO3.VUT,
                    CIOC = "VAN",
                    Currencies = new[] { "VUV" },
                    CallingCodes = new[] { "678" },
                    Capital = "Port Vila",
                    AlternativeSpellings = new[] { "VU", "Republic of Vanuatu", "Ripablik blong Vanuatu", "République de Vanuatu" },
                    Region = "Oceania",
                    SubRegion = "Melanesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 12189,
                };
            }
        }
        public static Country WallisandFutuna
        {
            get
            {
                return new Country
                {
                    CommonName = "Wallis and Futuna",
                    OfficialName = "Territory of the Wallis and Futuna Islands",
                    TLD = new[] { ".wf" },
                    CountryCode = CountryCode.WF,
                    ISONumeric = "876",
                    ISO3 = CountryCodeISO3.WLF,
                    CIOC = "",
                    Currencies = new[] { "XPF" },
                    CallingCodes = new[] { "681" },
                    Capital = "Mata-Utu",
                    AlternativeSpellings = new[] { "WF", "Territory of the Wallis and Futuna Islands", "Territoire des îles Wallis et Futuna" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 142,
                };
            }
        }
        public static Country Samoa
        {
            get
            {
                return new Country
                {
                    CommonName = "Samoa",
                    OfficialName = "Independent State of Samoa",
                    TLD = new[] { ".ws" },
                    CountryCode = CountryCode.WS,
                    ISONumeric = "882",
                    ISO3 = CountryCodeISO3.WSM,
                    CIOC = "SAM",
                    Currencies = new[] { "WST" },
                    CallingCodes = new[] { "685" },
                    Capital = "Apia",
                    AlternativeSpellings = new[] { "WS", "Independent State of Samoa", "Malo Saʻoloto Tutoʻatasi o Sāmoa" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeISO3[] { },
                    Landlocked = false,
                    Area = 2842,
                };
            }
        }
        public static Country Yemen
        {
            get
            {
                return new Country
                {
                    CommonName = "Yemen",
                    OfficialName = "Republic of Yemen",
                    TLD = new[] { ".ye" },
                    CountryCode = CountryCode.YE,
                    ISONumeric = "887",
                    ISO3 = CountryCodeISO3.YEM,
                    CIOC = "YEM",
                    Currencies = new[] { "YER" },
                    CallingCodes = new[] { "967" },
                    Capital = "Sana'a",
                    AlternativeSpellings = new[] { "YE", "Yemeni Republic", "al-Jumhūriyyah al-Yamaniyyah" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.OMN, CountryCodeISO3.SAU },
                    Landlocked = false,
                    Area = 527968,
                };
            }
        }
        public static Country SouthAfrica
        {
            get
            {
                return new Country
                {
                    CommonName = "South Africa",
                    OfficialName = "Republic of South Africa",
                    TLD = new[] { ".za" },
                    CountryCode = CountryCode.ZA,
                    ISONumeric = "710",
                    ISO3 = CountryCodeISO3.ZAF,
                    CIOC = "RSA",
                    Currencies = new[] { "ZAR" },
                    CallingCodes = new[] { "27" },
                    Capital = "Pretoria",
                    AlternativeSpellings = new[] { "ZA", "RSA", "Suid-Afrika", "Republic of South Africa" },
                    Region = "Africa",
                    SubRegion = "Southern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BWA, CountryCodeISO3.LSO, CountryCodeISO3.MOZ, CountryCodeISO3.NAM, CountryCodeISO3.SWZ, CountryCodeISO3.ZWE },
                    Landlocked = false,
                    Area = 1221037,
                };
            }
        }
        public static Country Zambia
        {
            get
            {
                return new Country
                {
                    CommonName = "Zambia",
                    OfficialName = "Republic of Zambia",
                    TLD = new[] { ".zm" },
                    CountryCode = CountryCode.ZM,
                    ISONumeric = "894",
                    ISO3 = CountryCodeISO3.ZMB,
                    CIOC = "ZAM",
                    Currencies = new[] { "ZMW" },
                    CallingCodes = new[] { "260" },
                    Capital = "Lusaka",
                    AlternativeSpellings = new[] { "ZM", "Republic of Zambia" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.AGO, CountryCodeISO3.BWA, CountryCodeISO3.COD, CountryCodeISO3.MWI, CountryCodeISO3.MOZ, CountryCodeISO3.NAM, CountryCodeISO3.TZA, CountryCodeISO3.ZWE },
                    Landlocked = true,
                    Area = 752612,
                };
            }
        }
        public static Country Zimbabwe
        {
            get
            {
                return new Country
                {
                    CommonName = "Zimbabwe",
                    OfficialName = "Republic of Zimbabwe",
                    TLD = new[] { ".zw" },
                    CountryCode = CountryCode.ZW,
                    ISONumeric = "716",
                    ISO3 = CountryCodeISO3.ZWE,
                    CIOC = "ZIM",
                    Currencies = new[] { "ZWL" },
                    CallingCodes = new[] { "263" },
                    Capital = "Harare",
                    AlternativeSpellings = new[] { "ZW", "Republic of Zimbabwe" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeISO3[] { CountryCodeISO3.BWA, CountryCodeISO3.MOZ, CountryCodeISO3.ZAF, CountryCodeISO3.ZMB },
                    Landlocked = true,
                    Area = 390757,
                };
            }
        }
    }
}