///////////////////////////////////////////////////////////////////////////
//           Liquid XML Objects GENERATED CODE - DO NOT MODIFY           //
//            https://www.liquid-technologies.com/xml-objects            //
//=======================================================================//
// Dependencies                                                          //
//     Nuget : LiquidTechnologies.XmlObjects.Runtime                     //
//           : MUST BE VERSION 20.1.3                                    //
//=======================================================================//
// Online Help                                                           //
//     https://www.liquid-technologies.com/xml-objects-quick-start-guide //
//=======================================================================//
// Licensing Information                                                 //
//     https://www.liquid-technologies.com/eula                          //
///////////////////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Numerics;
using LiquidTechnologies.XmlObjects;
using LiquidTechnologies.XmlObjects.Attribution;

// ------------------------------------------------------
// |                      Settings                      |
// ------------------------------------------------------
// GenerateCommonBaseClass                  = False
// GenerateUnprocessedNodeHandlers          = True
// RaiseChangeEvents                        = False
// CollectionNaming                         = Pluralize
// Language                                 = CS
// OutputNamespace                          = Messages.ISO.CAMTx053x001x02
// WriteDefaultValuesForOptionalAttributes  = True
// WriteDefaultValuesForOptionalElements    = False
// GenerationModel                          = Conformant
// XSD Schema Files
//    C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd


namespace Messages.ISO.CAMTx053x001x02
{
    #region Global Settings
    /// <summary>Contains library level properties, and ensures the version of the runtime used matches the version used to generate it.</summary>
    [LxRuntimeRequirements("20.1.3.11717", "Graz Sweden AB ", "DQ7AH3TKRPMTCWTW", LiquidTechnologies.XmlObjects.LicenseTermsType.FullLicense)]
    public partial class LxRuntimeRequirementsWritten
    {
    }

    #endregion

    #region Global Base Class
    /// <summary>All generated Lx classes derive from this base class.</summary>
    /// <remarks>Notes to implementers. The class is declared partial, so additional members and properties can be added that will be available in all Lx generated classes.</remarks>
    public partial class LxBase
    {
        #region Unprocessed Node Handlers
        /// <summary>Any child elements that do not belong in this element are added to the UnprocessedElements collection.</summary>
        [LxElementUnprocessed()]
        public List<XElement> UnprocessedElements { get; } = new List<XElement>();

        /// <summary>Any attributes that do not belong in this element are added to the UnprocessedAttributes collection.</summary>
        [LxAttributeUnprocessed()]
        public List<XAttribute> UnprocessedAttributes { get; } = new List<XAttribute>();

        #endregion

    }

    #endregion

}

namespace Messages.ISO.CAMTx053x001x02.Tns
{
    #region Enumerations
    /// <summary>An enumeration representing XSD simple type AddressType2Code@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/simpleType:AddressType2Code</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>66:5-75:21</XsdLocation>
    [LxSimpleTypeDefinition("AddressType2Code", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public enum AddressType2CodeEnum
    {
        /// <summary>Represents the value 'ADDR' in the XML</summary>
        [LxEnumValue("ADDR")]
        ADDR,
        /// <summary>Represents the value 'PBOX' in the XML</summary>
        [LxEnumValue("PBOX")]
        PBOX,
        /// <summary>Represents the value 'HOME' in the XML</summary>
        [LxEnumValue("HOME")]
        HOME,
        /// <summary>Represents the value 'BIZZ' in the XML</summary>
        [LxEnumValue("BIZZ")]
        BIZZ,
        /// <summary>Represents the value 'MLTO' in the XML</summary>
        [LxEnumValue("MLTO")]
        MLTO,
        /// <summary>Represents the value 'DLVY' in the XML</summary>
        [LxEnumValue("DLVY")]
        DLVY,
    }
    /// <summary>An enumeration representing XSD simple type BalanceType12Code@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/simpleType:BalanceType12Code</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>134:5-147:21</XsdLocation>
    [LxSimpleTypeDefinition("BalanceType12Code", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public enum BalanceType12CodeEnum
    {
        /// <summary>Represents the value 'XPCD' in the XML</summary>
        [LxEnumValue("XPCD")]
        XPCD,
        /// <summary>Represents the value 'OPAV' in the XML</summary>
        [LxEnumValue("OPAV")]
        OPAV,
        /// <summary>Represents the value 'ITAV' in the XML</summary>
        [LxEnumValue("ITAV")]
        ITAV,
        /// <summary>Represents the value 'CLAV' in the XML</summary>
        [LxEnumValue("CLAV")]
        CLAV,
        /// <summary>Represents the value 'FWAV' in the XML</summary>
        [LxEnumValue("FWAV")]
        FWAV,
        /// <summary>Represents the value 'CLBD' in the XML</summary>
        [LxEnumValue("CLBD")]
        CLBD,
        /// <summary>Represents the value 'ITBD' in the XML</summary>
        [LxEnumValue("ITBD")]
        ITBD,
        /// <summary>Represents the value 'OPBD' in the XML</summary>
        [LxEnumValue("OPBD")]
        OPBD,
        /// <summary>Represents the value 'PRCD' in the XML</summary>
        [LxEnumValue("PRCD")]
        PRCD,
        /// <summary>Represents the value 'INFO' in the XML</summary>
        [LxEnumValue("INFO")]
        INFO,
    }
    /// <summary>An enumeration representing XSD simple type CashAccountType4Code@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/simpleType:CashAccountType4Code</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>234:5-253:21</XsdLocation>
    [LxSimpleTypeDefinition("CashAccountType4Code", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public enum CashAccountType4CodeEnum
    {
        /// <summary>Represents the value 'CASH' in the XML</summary>
        [LxEnumValue("CASH")]
        CASH,
        /// <summary>Represents the value 'CHAR' in the XML</summary>
        [LxEnumValue("CHAR")]
        CHAR_,
        /// <summary>Represents the value 'COMM' in the XML</summary>
        [LxEnumValue("COMM")]
        COMM,
        /// <summary>Represents the value 'TAXE' in the XML</summary>
        [LxEnumValue("TAXE")]
        TAXE,
        /// <summary>Represents the value 'CISH' in the XML</summary>
        [LxEnumValue("CISH")]
        CISH,
        /// <summary>Represents the value 'TRAS' in the XML</summary>
        [LxEnumValue("TRAS")]
        TRAS,
        /// <summary>Represents the value 'SACC' in the XML</summary>
        [LxEnumValue("SACC")]
        SACC,
        /// <summary>Represents the value 'CACC' in the XML</summary>
        [LxEnumValue("CACC")]
        CACC,
        /// <summary>Represents the value 'SVGS' in the XML</summary>
        [LxEnumValue("SVGS")]
        SVGS,
        /// <summary>Represents the value 'ONDP' in the XML</summary>
        [LxEnumValue("ONDP")]
        ONDP,
        /// <summary>Represents the value 'MGLD' in the XML</summary>
        [LxEnumValue("MGLD")]
        MGLD,
        /// <summary>Represents the value 'NREX' in the XML</summary>
        [LxEnumValue("NREX")]
        NREX,
        /// <summary>Represents the value 'MOMA' in the XML</summary>
        [LxEnumValue("MOMA")]
        MOMA,
        /// <summary>Represents the value 'LOAN' in the XML</summary>
        [LxEnumValue("LOAN")]
        LOAN,
        /// <summary>Represents the value 'SLRY' in the XML</summary>
        [LxEnumValue("SLRY")]
        SLRY,
        /// <summary>Represents the value 'ODFT' in the XML</summary>
        [LxEnumValue("ODFT")]
        ODFT,
    }
    /// <summary>An enumeration representing XSD simple type ChargeBearerType1Code@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/simpleType:ChargeBearerType1Code</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>279:5-286:21</XsdLocation>
    [LxSimpleTypeDefinition("ChargeBearerType1Code", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public enum ChargeBearerType1CodeEnum
    {
        /// <summary>Represents the value 'DEBT' in the XML</summary>
        [LxEnumValue("DEBT")]
        DEBT,
        /// <summary>Represents the value 'CRED' in the XML</summary>
        [LxEnumValue("CRED")]
        CRED,
        /// <summary>Represents the value 'SHAR' in the XML</summary>
        [LxEnumValue("SHAR")]
        SHAR,
        /// <summary>Represents the value 'SLEV' in the XML</summary>
        [LxEnumValue("SLEV")]
        SLEV,
    }
    /// <summary>An enumeration representing XSD simple type ChargeType1Code@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/simpleType:ChargeType1Code</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>287:5-292:21</XsdLocation>
    [LxSimpleTypeDefinition("ChargeType1Code", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public enum ChargeType1CodeEnum
    {
        /// <summary>Represents the value 'BRKF' in the XML</summary>
        [LxEnumValue("BRKF")]
        BRKF,
        /// <summary>Represents the value 'COMM' in the XML</summary>
        [LxEnumValue("COMM")]
        COMM,
    }
    /// <summary>An enumeration representing XSD simple type CopyDuplicate1Code@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/simpleType:CopyDuplicate1Code</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>338:5-344:21</XsdLocation>
    [LxSimpleTypeDefinition("CopyDuplicate1Code", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public enum CopyDuplicate1CodeEnum
    {
        /// <summary>Represents the value 'CODU' in the XML</summary>
        [LxEnumValue("CODU")]
        CODU,
        /// <summary>Represents the value 'COPY' in the XML</summary>
        [LxEnumValue("COPY")]
        COPY,
        /// <summary>Represents the value 'DUPL' in the XML</summary>
        [LxEnumValue("DUPL")]
        DUPL,
    }
    /// <summary>An enumeration representing XSD simple type CreditDebitCode@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/simpleType:CreditDebitCode</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>357:5-362:21</XsdLocation>
    [LxSimpleTypeDefinition("CreditDebitCode", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public enum CreditDebitCodeEnum
    {
        /// <summary>Represents the value 'CRDT' in the XML</summary>
        [LxEnumValue("CRDT")]
        CRDT,
        /// <summary>Represents the value 'DBIT' in the XML</summary>
        [LxEnumValue("DBIT")]
        DBIT,
    }
    /// <summary>An enumeration representing XSD simple type DocumentType3Code@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/simpleType:DocumentType3Code</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>453:5-462:21</XsdLocation>
    [LxSimpleTypeDefinition("DocumentType3Code", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public enum DocumentType3CodeEnum
    {
        /// <summary>Represents the value 'RADM' in the XML</summary>
        [LxEnumValue("RADM")]
        RADM,
        /// <summary>Represents the value 'RPIN' in the XML</summary>
        [LxEnumValue("RPIN")]
        RPIN,
        /// <summary>Represents the value 'FXDR' in the XML</summary>
        [LxEnumValue("FXDR")]
        FXDR,
        /// <summary>Represents the value 'DISP' in the XML</summary>
        [LxEnumValue("DISP")]
        DISP,
        /// <summary>Represents the value 'PUOR' in the XML</summary>
        [LxEnumValue("PUOR")]
        PUOR,
        /// <summary>Represents the value 'SCOR' in the XML</summary>
        [LxEnumValue("SCOR")]
        SCOR,
    }
    /// <summary>An enumeration representing XSD simple type DocumentType5Code@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/simpleType:DocumentType5Code</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>463:5-481:21</XsdLocation>
    [LxSimpleTypeDefinition("DocumentType5Code", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public enum DocumentType5CodeEnum
    {
        /// <summary>Represents the value 'MSIN' in the XML</summary>
        [LxEnumValue("MSIN")]
        MSIN,
        /// <summary>Represents the value 'CNFA' in the XML</summary>
        [LxEnumValue("CNFA")]
        CNFA,
        /// <summary>Represents the value 'DNFA' in the XML</summary>
        [LxEnumValue("DNFA")]
        DNFA,
        /// <summary>Represents the value 'CINV' in the XML</summary>
        [LxEnumValue("CINV")]
        CINV,
        /// <summary>Represents the value 'CREN' in the XML</summary>
        [LxEnumValue("CREN")]
        CREN,
        /// <summary>Represents the value 'DEBN' in the XML</summary>
        [LxEnumValue("DEBN")]
        DEBN,
        /// <summary>Represents the value 'HIRI' in the XML</summary>
        [LxEnumValue("HIRI")]
        HIRI,
        /// <summary>Represents the value 'SBIN' in the XML</summary>
        [LxEnumValue("SBIN")]
        SBIN,
        /// <summary>Represents the value 'CMCN' in the XML</summary>
        [LxEnumValue("CMCN")]
        CMCN,
        /// <summary>Represents the value 'SOAC' in the XML</summary>
        [LxEnumValue("SOAC")]
        SOAC,
        /// <summary>Represents the value 'DISP' in the XML</summary>
        [LxEnumValue("DISP")]
        DISP,
        /// <summary>Represents the value 'BOLD' in the XML</summary>
        [LxEnumValue("BOLD")]
        BOLD,
        /// <summary>Represents the value 'VCHR' in the XML</summary>
        [LxEnumValue("VCHR")]
        VCHR,
        /// <summary>Represents the value 'AROI' in the XML</summary>
        [LxEnumValue("AROI")]
        AROI,
        /// <summary>Represents the value 'TSUT' in the XML</summary>
        [LxEnumValue("TSUT")]
        TSUT,
    }
    /// <summary>An enumeration representing XSD simple type EntryStatus2Code@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/simpleType:EntryStatus2Code</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>488:5-494:21</XsdLocation>
    [LxSimpleTypeDefinition("EntryStatus2Code", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public enum EntryStatus2CodeEnum
    {
        /// <summary>Represents the value 'BOOK' in the XML</summary>
        [LxEnumValue("BOOK")]
        BOOK,
        /// <summary>Represents the value 'PDNG' in the XML</summary>
        [LxEnumValue("PDNG")]
        PDNG,
        /// <summary>Represents the value 'INFO' in the XML</summary>
        [LxEnumValue("INFO")]
        INFO,
    }
    /// <summary>An enumeration representing XSD simple type InterestType1Code@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/simpleType:InterestType1Code</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>714:5-719:21</XsdLocation>
    [LxSimpleTypeDefinition("InterestType1Code", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public enum InterestType1CodeEnum
    {
        /// <summary>Represents the value 'INDY' in the XML</summary>
        [LxEnumValue("INDY")]
        INDY,
        /// <summary>Represents the value 'OVRN' in the XML</summary>
        [LxEnumValue("OVRN")]
        OVRN,
    }
    /// <summary>An enumeration representing XSD simple type NamePrefix1Code@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/simpleType:NamePrefix1Code</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>801:5-808:21</XsdLocation>
    [LxSimpleTypeDefinition("NamePrefix1Code", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public enum NamePrefix1CodeEnum
    {
        /// <summary>Represents the value 'DOCT' in the XML</summary>
        [LxEnumValue("DOCT")]
        DOCT,
        /// <summary>Represents the value 'MIST' in the XML</summary>
        [LxEnumValue("MIST")]
        MIST,
        /// <summary>Represents the value 'MISS' in the XML</summary>
        [LxEnumValue("MISS")]
        MISS,
        /// <summary>Represents the value 'MADM' in the XML</summary>
        [LxEnumValue("MADM")]
        MADM,
    }
    /// <summary>An enumeration representing XSD simple type RemittanceLocationMethod2Code@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/simpleType:RemittanceLocationMethod2Code</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1014:5-1023:21</XsdLocation>
    [LxSimpleTypeDefinition("RemittanceLocationMethod2Code", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public enum RemittanceLocationMethod2CodeEnum
    {
        /// <summary>Represents the value 'FAXI' in the XML</summary>
        [LxEnumValue("FAXI")]
        FAXI,
        /// <summary>Represents the value 'EDIC' in the XML</summary>
        [LxEnumValue("EDIC")]
        EDIC,
        /// <summary>Represents the value 'URID' in the XML</summary>
        [LxEnumValue("URID")]
        URID,
        /// <summary>Represents the value 'EMAL' in the XML</summary>
        [LxEnumValue("EMAL")]
        EMAL,
        /// <summary>Represents the value 'POST' in the XML</summary>
        [LxEnumValue("POST")]
        POST,
        /// <summary>Represents the value 'SMSM' in the XML</summary>
        [LxEnumValue("SMSM")]
        SMSM,
    }
    /// <summary>An enumeration representing XSD simple type TaxRecordPeriod1Code@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/simpleType:TaxRecordPeriod1Code</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1164:5-1185:21</XsdLocation>
    [LxSimpleTypeDefinition("TaxRecordPeriod1Code", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public enum TaxRecordPeriod1CodeEnum
    {
        /// <summary>Represents the value 'MM01' in the XML</summary>
        [LxEnumValue("MM01")]
        MM01,
        /// <summary>Represents the value 'MM02' in the XML</summary>
        [LxEnumValue("MM02")]
        MM02,
        /// <summary>Represents the value 'MM03' in the XML</summary>
        [LxEnumValue("MM03")]
        MM03,
        /// <summary>Represents the value 'MM04' in the XML</summary>
        [LxEnumValue("MM04")]
        MM04,
        /// <summary>Represents the value 'MM05' in the XML</summary>
        [LxEnumValue("MM05")]
        MM05,
        /// <summary>Represents the value 'MM06' in the XML</summary>
        [LxEnumValue("MM06")]
        MM06,
        /// <summary>Represents the value 'MM07' in the XML</summary>
        [LxEnumValue("MM07")]
        MM07,
        /// <summary>Represents the value 'MM08' in the XML</summary>
        [LxEnumValue("MM08")]
        MM08,
        /// <summary>Represents the value 'MM09' in the XML</summary>
        [LxEnumValue("MM09")]
        MM09,
        /// <summary>Represents the value 'MM10' in the XML</summary>
        [LxEnumValue("MM10")]
        MM10,
        /// <summary>Represents the value 'MM11' in the XML</summary>
        [LxEnumValue("MM11")]
        MM11,
        /// <summary>Represents the value 'MM12' in the XML</summary>
        [LxEnumValue("MM12")]
        MM12,
        /// <summary>Represents the value 'QTR1' in the XML</summary>
        [LxEnumValue("QTR1")]
        QTR1,
        /// <summary>Represents the value 'QTR2' in the XML</summary>
        [LxEnumValue("QTR2")]
        QTR2,
        /// <summary>Represents the value 'QTR3' in the XML</summary>
        [LxEnumValue("QTR3")]
        QTR3,
        /// <summary>Represents the value 'QTR4' in the XML</summary>
        [LxEnumValue("QTR4")]
        QTR4,
        /// <summary>Represents the value 'HLF1' in the XML</summary>
        [LxEnumValue("HLF1")]
        HLF1,
        /// <summary>Represents the value 'HLF2' in the XML</summary>
        [LxEnumValue("HLF2")]
        HLF2,
    }
    #endregion

    #region Complex Types
    /// <summary>A class representing the root XSD complexType AccountIdentification4Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountIdentification4Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>5:5-12:22</XsdLocation>
    [LxComplexTypeDefinition("AccountIdentification4Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class AccountIdentification4ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountIdentification4Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>6:9-11:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.AccountIdentification4ChoiceCt.AccountIdentification4ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AccountIdentification4ChoiceCt.AccountIdentification4ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountIdentification4Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>7:13-10:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class AccountIdentification4ChoiceSeqChc
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("IBAN", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, Pattern = "[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}")]
            public System.String IBAN { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.GenericAccountIdentification1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.GenericAccountIdentification1Ct" />
            /// </summary>
            [LxElementCt("Othr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.GenericAccountIdentification1Ct Othr { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountIdentification4Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>6:9-11:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class AccountIdentification4ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountIdentification4Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>7:13-10:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.AccountIdentification4ChoiceCt.AccountIdentification4ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AccountIdentification4ChoiceCt.AccountIdentification4ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType AccountInterest2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountInterest2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>13:5-20:22</XsdLocation>
    [LxComplexTypeDefinition("AccountInterest2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class AccountInterest2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountInterest2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>14:9-19:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.AccountInterest2Ct.AccountInterest2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AccountInterest2Ct.AccountInterest2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountInterest2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>14:9-19:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class AccountInterest2Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.InterestType1ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.InterestType1ChoiceCt" />
            /// </summary>
            [LxElementCt("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.InterestType1ChoiceCt Tp { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.Rate3Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.Rate3Ct" />
            /// </summary>
            [LxElementCt("Rate", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.Rate3Ct> Rates { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.Rate3Ct>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateTimePeriodDetailsCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateTimePeriodDetailsCt" />
            /// </summary>
            [LxElementCt("FrToDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.DateTimePeriodDetailsCt FrToDt { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Rsn", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Rsn { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType AccountSchemeName1Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountSchemeName1Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>21:5-28:22</XsdLocation>
    [LxComplexTypeDefinition("AccountSchemeName1Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class AccountSchemeName1ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountSchemeName1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>22:9-27:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.AccountSchemeName1ChoiceCt.AccountSchemeName1ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AccountSchemeName1ChoiceCt.AccountSchemeName1ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountSchemeName1Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>23:13-26:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class AccountSchemeName1ChoiceSeqChc
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "4")]
            public System.String Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountSchemeName1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>22:9-27:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class AccountSchemeName1ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountSchemeName1Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>23:13-26:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.AccountSchemeName1ChoiceCt.AccountSchemeName1ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AccountSchemeName1ChoiceCt.AccountSchemeName1ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType AccountStatement2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountStatement2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>29:5-46:22</XsdLocation>
    [LxComplexTypeDefinition("AccountStatement2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class AccountStatement2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountStatement2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>30:9-45:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.AccountStatement2Ct.AccountStatement2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AccountStatement2Ct.AccountStatement2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AccountStatement2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>30:9-45:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class AccountStatement2Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Id", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Id { get; set; } = "";

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("ElctrncSeqNb", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, TotalDigits = "18", FractionDigits = "0")]
            public LiquidTechnologies.XmlObjects.BigDecimal? ElctrncSeqNb { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("LglSeqNb", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, TotalDigits = "18", FractionDigits = "0")]
            public LiquidTechnologies.XmlObjects.BigDecimal? LglSeqNb { get; set; }

            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
            [LxElementValue("CreDtTm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDateTime)]
            public LiquidTechnologies.XmlObjects.LxDateTime CreDtTm { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateTimePeriodDetailsCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateTimePeriodDetailsCt" />
            /// </summary>
            [LxElementCt("FrToDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.DateTimePeriodDetailsCt FrToDt { get; set; }

            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.CopyDuplicate1CodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("CpyDplctInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.CopyDuplicate1CodeEnum? CpyDplctInd { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ReportingSource1ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ReportingSource1ChoiceCt" />
            /// </summary>
            [LxElementCt("RptgSrc", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ReportingSource1ChoiceCt RptgSrc { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccount20Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccount20Ct" />
            /// </summary>
            [LxElementCt("Acct", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.CashAccount20Ct Acct { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CashAccount20Ct();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccount16Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccount16Ct" />
            /// </summary>
            [LxElementCt("RltdAcct", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.CashAccount16Ct RltdAcct { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AccountInterest2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AccountInterest2Ct" />
            /// </summary>
            [LxElementCt("Intrst", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.AccountInterest2Ct> Intrsts { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.AccountInterest2Ct>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashBalance3Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashBalance3Ct" />
            /// </summary>
            [LxElementCt("Bal", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.CashBalance3Ct> Bals { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.CashBalance3Ct>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TotalTransactions2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TotalTransactions2Ct" />
            /// </summary>
            [LxElementCt("TxsSummry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TotalTransactions2Ct TxsSummry { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ReportEntry2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ReportEntry2Ct" />
            /// </summary>
            [LxElementCt("Ntry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.ReportEntry2Ct> Ntrys { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.ReportEntry2Ct>();

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("AddtlStmtInf", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "500")]
            public System.String AddtlStmtInf { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType ActiveOrHistoricCurrencyAndAmount@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ActiveOrHistoricCurrencyAndAmount</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>54:5-60:22</XsdLocation>
    [LxComplexTypeDefinition("ActiveOrHistoricCurrencyAndAmount", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ActiveOrHistoricCurrencyAndAmountCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>The value for the attribute Ccy</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ActiveOrHistoricCurrencyAndAmount/attribute:Ccy</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>57:17-57:94</XsdLocation>
        [LxAttribute("Ccy", "", LxValueType.Value, XsdType.XsdString, Required = true, Pattern = "[A-Z]{3,3}")]
        public System.String Ccy { get; set; } = "";

        /// <summary>Holds the <see cref="LiquidTechnologies.XmlObjects.BigDecimal" /> value of the element</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ActiveOrHistoricCurrencyAndAmount</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>54:5-60:22</XsdLocation>
        [LxValue(LxValueType.Value, XsdType.XsdDecimal, MinInclusive = "0", TotalDigits = "18", FractionDigits = "5")]
        public LiquidTechnologies.XmlObjects.BigDecimal Value { get; set; }

    }

    /// <summary>A class representing the root XSD complexType AlternateSecurityIdentification2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AlternateSecurityIdentification2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>76:5-81:22</XsdLocation>
    [LxComplexTypeDefinition("AlternateSecurityIdentification2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class AlternateSecurityIdentification2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AlternateSecurityIdentification2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>77:9-80:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.AlternateSecurityIdentification2Ct.AlternateSecurityIdentification2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AlternateSecurityIdentification2Ct.AlternateSecurityIdentification2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AlternateSecurityIdentification2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>77:9-80:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class AlternateSecurityIdentification2Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Tp { get; set; } = "";

            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Id", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Id { get; set; } = "";

        }

    }

    /// <summary>A class representing the root XSD complexType AmountAndCurrencyExchange3@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AmountAndCurrencyExchange3</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>82:5-90:22</XsdLocation>
    [LxComplexTypeDefinition("AmountAndCurrencyExchange3", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class AmountAndCurrencyExchange3Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AmountAndCurrencyExchange3/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>83:9-89:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchange3Ct.AmountAndCurrencyExchange3Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchange3Ct.AmountAndCurrencyExchange3Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AmountAndCurrencyExchange3/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>83:9-89:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class AmountAndCurrencyExchange3Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails3Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails3Ct" />
            /// </summary>
            [LxElementCt("InstdAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails3Ct InstdAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails3Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails3Ct" />
            /// </summary>
            [LxElementCt("TxAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails3Ct TxAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails3Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails3Ct" />
            /// </summary>
            [LxElementCt("CntrValAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails3Ct CntrValAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails3Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails3Ct" />
            /// </summary>
            [LxElementCt("AnncdPstngAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails3Ct AnncdPstngAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails4Ct" />
            /// </summary>
            [LxElementCt("PrtryAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails4Ct> PrtryAmts { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails4Ct>();

        }

    }

    /// <summary>A class representing the root XSD complexType AmountAndCurrencyExchangeDetails3@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AmountAndCurrencyExchangeDetails3</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>91:5-96:22</XsdLocation>
    [LxComplexTypeDefinition("AmountAndCurrencyExchangeDetails3", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class AmountAndCurrencyExchangeDetails3Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AmountAndCurrencyExchangeDetails3/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>92:9-95:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails3Ct.AmountAndCurrencyExchangeDetails3Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails3Ct.AmountAndCurrencyExchangeDetails3Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AmountAndCurrencyExchangeDetails3/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>92:9-95:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class AmountAndCurrencyExchangeDetails3Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("Amt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt Amt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CurrencyExchange5Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CurrencyExchange5Ct" />
            /// </summary>
            [LxElementCt("CcyXchg", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.CurrencyExchange5Ct CcyXchg { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType AmountAndCurrencyExchangeDetails4@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AmountAndCurrencyExchangeDetails4</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>97:5-103:22</XsdLocation>
    [LxComplexTypeDefinition("AmountAndCurrencyExchangeDetails4", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class AmountAndCurrencyExchangeDetails4Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AmountAndCurrencyExchangeDetails4/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>98:9-102:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails4Ct.AmountAndCurrencyExchangeDetails4Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchangeDetails4Ct.AmountAndCurrencyExchangeDetails4Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AmountAndCurrencyExchangeDetails4/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>98:9-102:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class AmountAndCurrencyExchangeDetails4Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Tp { get; set; } = "";

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("Amt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt Amt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CurrencyExchange5Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CurrencyExchange5Ct" />
            /// </summary>
            [LxElementCt("CcyXchg", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.CurrencyExchange5Ct CcyXchg { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType AmountRangeBoundary1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AmountRangeBoundary1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>104:5-109:22</XsdLocation>
    [LxComplexTypeDefinition("AmountRangeBoundary1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class AmountRangeBoundary1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AmountRangeBoundary1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>105:9-108:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct.AmountRangeBoundary1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct.AmountRangeBoundary1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:AmountRangeBoundary1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>105:9-108:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class AmountRangeBoundary1Seq
        {
            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
            [LxElementValue("BdryAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinInclusive = "0", TotalDigits = "18", FractionDigits = "5")]
            public LiquidTechnologies.XmlObjects.BigDecimal BdryAmt { get; set; }

            /// <summary>A <see cref="System.Boolean" />, Required</summary>
            [LxElementValue("Incl", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdBoolean)]
            public System.Boolean Incl { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType BalanceSubType1Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BalanceSubType1Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>120:5-127:22</XsdLocation>
    [LxComplexTypeDefinition("BalanceSubType1Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class BalanceSubType1ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BalanceSubType1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>121:9-126:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.BalanceSubType1ChoiceCt.BalanceSubType1ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BalanceSubType1ChoiceCt.BalanceSubType1ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BalanceSubType1Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>122:13-125:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class BalanceSubType1ChoiceSeqChc
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "4")]
            public System.String Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BalanceSubType1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>121:9-126:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class BalanceSubType1ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BalanceSubType1Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>122:13-125:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.BalanceSubType1ChoiceCt.BalanceSubType1ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BalanceSubType1ChoiceCt.BalanceSubType1ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType BalanceType12@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BalanceType12</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>128:5-133:22</XsdLocation>
    [LxComplexTypeDefinition("BalanceType12", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class BalanceType12Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BalanceType12/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>129:9-132:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.BalanceType12Ct.BalanceType12Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BalanceType12Ct.BalanceType12Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BalanceType12/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>129:9-132:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class BalanceType12Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BalanceType5ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BalanceType5ChoiceCt" />
            /// </summary>
            [LxElementCt("CdOrPrtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.BalanceType5ChoiceCt CdOrPrtry { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BalanceType5ChoiceCt();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BalanceSubType1ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BalanceSubType1ChoiceCt" />
            /// </summary>
            [LxElementCt("SubTp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BalanceSubType1ChoiceCt SubTp { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType BalanceType5Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BalanceType5Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>148:5-155:22</XsdLocation>
    [LxComplexTypeDefinition("BalanceType5Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class BalanceType5ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BalanceType5Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>149:9-154:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.BalanceType5ChoiceCt.BalanceType5ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BalanceType5ChoiceCt.BalanceType5ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BalanceType5Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>150:13-153:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class BalanceType5ChoiceSeqChc
        {
            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.BalanceType12CodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.BalanceType12CodeEnum? Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BalanceType5Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>149:9-154:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class BalanceType5ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BalanceType5Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>150:13-153:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.BalanceType5ChoiceCt.BalanceType5ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BalanceType5ChoiceCt.BalanceType5ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType BankToCustomerStatementV02@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BankToCustomerStatementV02</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>156:5-161:22</XsdLocation>
    [LxComplexTypeDefinition("BankToCustomerStatementV02", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class BankToCustomerStatementV02Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BankToCustomerStatementV02/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>157:9-160:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.BankToCustomerStatementV02Ct.BankToCustomerStatementV02Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BankToCustomerStatementV02Ct.BankToCustomerStatementV02Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BankToCustomerStatementV02/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>157:9-160:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class BankToCustomerStatementV02Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.GroupHeader42Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.GroupHeader42Ct" />
            /// </summary>
            [LxElementCt("GrpHdr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.GroupHeader42Ct GrpHdr { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.GroupHeader42Ct();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AccountStatement2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AccountStatement2Ct" />
            /// </summary>
            [LxElementCt("Stmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.AccountStatement2Ct> Stmts { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.AccountStatement2Ct>();

        }

    }

    /// <summary>A class representing the root XSD complexType BankTransactionCodeStructure4@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BankTransactionCodeStructure4</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>162:5-167:22</XsdLocation>
    [LxComplexTypeDefinition("BankTransactionCodeStructure4", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class BankTransactionCodeStructure4Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BankTransactionCodeStructure4/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>163:9-166:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct.BankTransactionCodeStructure4Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct.BankTransactionCodeStructure4Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BankTransactionCodeStructure4/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>163:9-166:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class BankTransactionCodeStructure4Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure5Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure5Ct" />
            /// </summary>
            [LxElementCt("Domn", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure5Ct Domn { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ProprietaryBankTransactionCodeStructure1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ProprietaryBankTransactionCodeStructure1Ct" />
            /// </summary>
            [LxElementCt("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ProprietaryBankTransactionCodeStructure1Ct Prtry { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType BankTransactionCodeStructure5@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BankTransactionCodeStructure5</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>168:5-173:22</XsdLocation>
    [LxComplexTypeDefinition("BankTransactionCodeStructure5", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class BankTransactionCodeStructure5Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BankTransactionCodeStructure5/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>169:9-172:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure5Ct.BankTransactionCodeStructure5Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure5Ct.BankTransactionCodeStructure5Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BankTransactionCodeStructure5/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>169:9-172:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class BankTransactionCodeStructure5Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "4")]
            public System.String Cd { get; set; } = "";

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure6Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure6Ct" />
            /// </summary>
            [LxElementCt("Fmly", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure6Ct Fmly { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure6Ct();

        }

    }

    /// <summary>A class representing the root XSD complexType BankTransactionCodeStructure6@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BankTransactionCodeStructure6</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>174:5-179:22</XsdLocation>
    [LxComplexTypeDefinition("BankTransactionCodeStructure6", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class BankTransactionCodeStructure6Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BankTransactionCodeStructure6/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>175:9-178:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure6Ct.BankTransactionCodeStructure6Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure6Ct.BankTransactionCodeStructure6Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BankTransactionCodeStructure6/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>175:9-178:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class BankTransactionCodeStructure6Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "4")]
            public System.String Cd { get; set; } = "";

            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("SubFmlyCd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "4")]
            public System.String SubFmlyCd { get; set; } = "";

        }

    }

    /// <summary>A class representing the root XSD complexType BatchInformation2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BatchInformation2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>186:5-194:22</XsdLocation>
    [LxComplexTypeDefinition("BatchInformation2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class BatchInformation2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BatchInformation2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>187:9-193:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.BatchInformation2Ct.BatchInformation2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BatchInformation2Ct.BatchInformation2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BatchInformation2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>187:9-193:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class BatchInformation2Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("MsgId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String MsgId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("PmtInfId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String PmtInfId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("NbOfTxs", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "[0-9]{1,15}")]
            public System.String NbOfTxs { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("TtlAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt TtlAmt { get; set; }

            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("CdtDbtInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum? CdtDbtInd { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType BranchAndFinancialInstitutionIdentification4@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BranchAndFinancialInstitutionIdentification4</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>195:5-200:22</XsdLocation>
    [LxComplexTypeDefinition("BranchAndFinancialInstitutionIdentification4", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class BranchAndFinancialInstitutionIdentification4Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BranchAndFinancialInstitutionIdentification4/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>196:9-199:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct.BranchAndFinancialInstitutionIdentification4Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct.BranchAndFinancialInstitutionIdentification4Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BranchAndFinancialInstitutionIdentification4/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>196:9-199:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class BranchAndFinancialInstitutionIdentification4Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.FinancialInstitutionIdentification7Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.FinancialInstitutionIdentification7Ct" />
            /// </summary>
            [LxElementCt("FinInstnId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.FinancialInstitutionIdentification7Ct FinInstnId { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.FinancialInstitutionIdentification7Ct();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchData2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchData2Ct" />
            /// </summary>
            [LxElementCt("BrnchId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BranchData2Ct BrnchId { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType BranchData2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BranchData2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>201:5-207:22</XsdLocation>
    [LxComplexTypeDefinition("BranchData2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class BranchData2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BranchData2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>202:9-206:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.BranchData2Ct.BranchData2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BranchData2Ct.BranchData2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:BranchData2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>202:9-206:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class BranchData2Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Id", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Id { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Nm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "140")]
            public System.String Nm { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct" />
            /// </summary>
            [LxElementCt("PstlAdr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct PstlAdr { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType CashAccount16@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashAccount16</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>208:5-215:22</XsdLocation>
    [LxComplexTypeDefinition("CashAccount16", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class CashAccount16Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashAccount16/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>209:9-214:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.CashAccount16Ct.CashAccount16Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CashAccount16Ct.CashAccount16Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashAccount16/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>209:9-214:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class CashAccount16Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AccountIdentification4ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AccountIdentification4ChoiceCt" />
            /// </summary>
            [LxElementCt("Id", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.AccountIdentification4ChoiceCt Id { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AccountIdentification4ChoiceCt();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccountType2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccountType2Ct" />
            /// </summary>
            [LxElementCt("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.CashAccountType2Ct Tp { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Ccy", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "[A-Z]{3,3}")]
            public System.String Ccy { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Nm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "70")]
            public System.String Nm { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType CashAccount20@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashAccount20</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>216:5-225:22</XsdLocation>
    [LxComplexTypeDefinition("CashAccount20", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class CashAccount20Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashAccount20/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>217:9-224:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.CashAccount20Ct.CashAccount20Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CashAccount20Ct.CashAccount20Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashAccount20/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>217:9-224:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class CashAccount20Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AccountIdentification4ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AccountIdentification4ChoiceCt" />
            /// </summary>
            [LxElementCt("Id", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.AccountIdentification4ChoiceCt Id { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AccountIdentification4ChoiceCt();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccountType2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccountType2Ct" />
            /// </summary>
            [LxElementCt("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.CashAccountType2Ct Tp { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Ccy", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "[A-Z]{3,3}")]
            public System.String Ccy { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Nm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "70")]
            public System.String Nm { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />
            /// </summary>
            [LxElementCt("Ownr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct Ownr { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />
            /// </summary>
            [LxElementCt("Svcr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct Svcr { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType CashAccountType2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashAccountType2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>226:5-233:22</XsdLocation>
    [LxComplexTypeDefinition("CashAccountType2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class CashAccountType2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashAccountType2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>227:9-232:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.CashAccountType2Ct.CashAccountType2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CashAccountType2Ct.CashAccountType2Seq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashAccountType2/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>228:13-231:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class CashAccountType2SeqChc
        {
            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccountType4CodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.CashAccountType4CodeEnum? Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashAccountType2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>227:9-232:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class CashAccountType2Seq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashAccountType2/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>228:13-231:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.CashAccountType2Ct.CashAccountType2SeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CashAccountType2Ct.CashAccountType2SeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType CashBalance3@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashBalance3</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>254:5-263:22</XsdLocation>
    [LxComplexTypeDefinition("CashBalance3", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class CashBalance3Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashBalance3/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>255:9-262:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.CashBalance3Ct.CashBalance3Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CashBalance3Ct.CashBalance3Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashBalance3/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>255:9-262:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class CashBalance3Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BalanceType12Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BalanceType12Ct" />
            /// </summary>
            [LxElementCt("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.BalanceType12Ct Tp { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BalanceType12Ct();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditLine2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditLine2Ct" />
            /// </summary>
            [LxElementCt("CdtLine", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditLine2Ct CdtLine { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("Amt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt Amt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt();

            /// <summary>A <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum" />, Required</summary>
            [LxElementValue("CdtDbtInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum CdtDbtInd { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt" />
            /// </summary>
            [LxElementCt("Dt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt Dt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct" />
            /// </summary>
            [LxElementCt("Avlbty", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct> Avlbtys { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct>();

        }

    }

    /// <summary>A class representing the root XSD complexType CashBalanceAvailability2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashBalanceAvailability2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>264:5-270:22</XsdLocation>
    [LxComplexTypeDefinition("CashBalanceAvailability2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class CashBalanceAvailability2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashBalanceAvailability2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>265:9-269:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct.CashBalanceAvailability2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct.CashBalanceAvailability2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashBalanceAvailability2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>265:9-269:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class CashBalanceAvailability2Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailabilityDate1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailabilityDate1Ct" />
            /// </summary>
            [LxElementCt("Dt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailabilityDate1Ct Dt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailabilityDate1Ct();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("Amt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt Amt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt();

            /// <summary>A <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum" />, Required</summary>
            [LxElementValue("CdtDbtInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum CdtDbtInd { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType CashBalanceAvailabilityDate1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashBalanceAvailabilityDate1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>271:5-278:22</XsdLocation>
    [LxComplexTypeDefinition("CashBalanceAvailabilityDate1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class CashBalanceAvailabilityDate1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashBalanceAvailabilityDate1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>272:9-277:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailabilityDate1Ct.CashBalanceAvailabilityDate1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailabilityDate1Ct.CashBalanceAvailabilityDate1Seq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashBalanceAvailabilityDate1/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>273:13-276:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class CashBalanceAvailabilityDate1SeqChc
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("NbOfDays", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, Pattern = "[+]{0,1}[0-9]{1,15}")]
            public System.String NbOfDays { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("ActlDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDate)]
            public LiquidTechnologies.XmlObjects.LxDateTime? ActlDt { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashBalanceAvailabilityDate1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>272:9-277:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class CashBalanceAvailabilityDate1Seq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CashBalanceAvailabilityDate1/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>273:13-276:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailabilityDate1Ct.CashBalanceAvailabilityDate1SeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailabilityDate1Ct.CashBalanceAvailabilityDate1SeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType ChargesInformation6@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ChargesInformation6</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>301:5-312:22</XsdLocation>
    [LxComplexTypeDefinition("ChargesInformation6", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ChargesInformation6Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ChargesInformation6/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>302:9-311:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ChargesInformation6Ct.ChargesInformation6Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ChargesInformation6Ct.ChargesInformation6Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ChargesInformation6/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>302:9-311:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ChargesInformation6Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("TtlChrgsAndTaxAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt TtlChrgsAndTaxAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("Amt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt Amt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt();

            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("CdtDbtInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum? CdtDbtInd { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ChargeType2ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ChargeType2ChoiceCt" />
            /// </summary>
            [LxElementCt("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ChargeType2ChoiceCt Tp { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("Rate", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, TotalDigits = "11", FractionDigits = "10")]
            public LiquidTechnologies.XmlObjects.BigDecimal? Rate { get; set; }

            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.ChargeBearerType1CodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("Br", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.ChargeBearerType1CodeEnum? Br { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />
            /// </summary>
            [LxElementCt("Pty", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct Pty { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxCharges2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxCharges2Ct" />
            /// </summary>
            [LxElementCt("Tax", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TaxCharges2Ct Tax { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType ChargeType2Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ChargeType2Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>293:5-300:22</XsdLocation>
    [LxComplexTypeDefinition("ChargeType2Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ChargeType2ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ChargeType2Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>294:9-299:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ChargeType2ChoiceCt.ChargeType2ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ChargeType2ChoiceCt.ChargeType2ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ChargeType2Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>295:13-298:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class ChargeType2ChoiceSeqChc
        {
            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.ChargeType1CodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.ChargeType1CodeEnum? Cd { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.GenericIdentification3Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.GenericIdentification3Ct" />
            /// </summary>
            [LxElementCt("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.GenericIdentification3Ct Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ChargeType2Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>294:9-299:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ChargeType2ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ChargeType2Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>295:13-298:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.ChargeType2ChoiceCt.ChargeType2ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ChargeType2ChoiceCt.ChargeType2ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType ClearingSystemIdentification2Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ClearingSystemIdentification2Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>313:5-320:22</XsdLocation>
    [LxComplexTypeDefinition("ClearingSystemIdentification2Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ClearingSystemIdentification2ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ClearingSystemIdentification2Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>314:9-319:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ClearingSystemIdentification2ChoiceCt.ClearingSystemIdentification2ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ClearingSystemIdentification2ChoiceCt.ClearingSystemIdentification2ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ClearingSystemIdentification2Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>315:13-318:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class ClearingSystemIdentification2ChoiceSeqChc
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "5")]
            public System.String Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ClearingSystemIdentification2Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>314:9-319:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ClearingSystemIdentification2ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ClearingSystemIdentification2Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>315:13-318:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.ClearingSystemIdentification2ChoiceCt.ClearingSystemIdentification2ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ClearingSystemIdentification2ChoiceCt.ClearingSystemIdentification2ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType ClearingSystemMemberIdentification2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ClearingSystemMemberIdentification2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>321:5-326:22</XsdLocation>
    [LxComplexTypeDefinition("ClearingSystemMemberIdentification2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ClearingSystemMemberIdentification2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ClearingSystemMemberIdentification2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>322:9-325:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ClearingSystemMemberIdentification2Ct.ClearingSystemMemberIdentification2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ClearingSystemMemberIdentification2Ct.ClearingSystemMemberIdentification2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ClearingSystemMemberIdentification2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>322:9-325:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ClearingSystemMemberIdentification2Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ClearingSystemIdentification2ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ClearingSystemIdentification2ChoiceCt" />
            /// </summary>
            [LxElementCt("ClrSysId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ClearingSystemIdentification2ChoiceCt ClrSysId { get; set; }

            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("MmbId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String MmbId { get; set; } = "";

        }

    }

    /// <summary>A class representing the root XSD complexType ContactDetails2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ContactDetails2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>327:5-337:22</XsdLocation>
    [LxComplexTypeDefinition("ContactDetails2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ContactDetails2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ContactDetails2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>328:9-336:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ContactDetails2Ct.ContactDetails2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ContactDetails2Ct.ContactDetails2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ContactDetails2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>328:9-336:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ContactDetails2Seq
        {
            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.NamePrefix1CodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("NmPrfx", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.NamePrefix1CodeEnum? NmPrfx { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Nm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "140")]
            public System.String Nm { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("PhneNb", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "\\+[0-9]{1,3}-[0-9()+\\-]{1,30}")]
            public System.String PhneNb { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("MobNb", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "\\+[0-9]{1,3}-[0-9()+\\-]{1,30}")]
            public System.String MobNb { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("FaxNb", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "\\+[0-9]{1,3}-[0-9()+\\-]{1,30}")]
            public System.String FaxNb { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("EmailAdr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "2048")]
            public System.String EmailAdr { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Othr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Othr { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType CorporateAction1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CorporateAction1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>345:5-351:22</XsdLocation>
    [LxComplexTypeDefinition("CorporateAction1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class CorporateAction1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CorporateAction1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>346:9-350:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.CorporateAction1Ct.CorporateAction1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CorporateAction1Ct.CorporateAction1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CorporateAction1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>346:9-350:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class CorporateAction1Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Nb", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Nb { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType CreditLine2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CreditLine2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>363:5-368:22</XsdLocation>
    [LxComplexTypeDefinition("CreditLine2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class CreditLine2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CreditLine2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>364:9-367:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.CreditLine2Ct.CreditLine2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CreditLine2Ct.CreditLine2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CreditLine2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>364:9-367:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class CreditLine2Seq
        {
            /// <summary>A <see cref="System.Boolean" />, Required</summary>
            [LxElementValue("Incl", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdBoolean)]
            public System.Boolean Incl { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("Amt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt Amt { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType CreditorReferenceInformation2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CreditorReferenceInformation2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>369:5-374:22</XsdLocation>
    [LxComplexTypeDefinition("CreditorReferenceInformation2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class CreditorReferenceInformation2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CreditorReferenceInformation2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>370:9-373:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceInformation2Ct.CreditorReferenceInformation2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceInformation2Ct.CreditorReferenceInformation2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CreditorReferenceInformation2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>370:9-373:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class CreditorReferenceInformation2Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceType2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceType2Ct" />
            /// </summary>
            [LxElementCt("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceType2Ct Tp { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Ref", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Ref_ { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType CreditorReferenceType1Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CreditorReferenceType1Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>375:5-382:22</XsdLocation>
    [LxComplexTypeDefinition("CreditorReferenceType1Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class CreditorReferenceType1ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CreditorReferenceType1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>376:9-381:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceType1ChoiceCt.CreditorReferenceType1ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceType1ChoiceCt.CreditorReferenceType1ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CreditorReferenceType1Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>377:13-380:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class CreditorReferenceType1ChoiceSeqChc
        {
            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.DocumentType3CodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.DocumentType3CodeEnum? Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CreditorReferenceType1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>376:9-381:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class CreditorReferenceType1ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CreditorReferenceType1Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>377:13-380:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceType1ChoiceCt.CreditorReferenceType1ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceType1ChoiceCt.CreditorReferenceType1ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType CreditorReferenceType2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CreditorReferenceType2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>383:5-388:22</XsdLocation>
    [LxComplexTypeDefinition("CreditorReferenceType2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class CreditorReferenceType2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CreditorReferenceType2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>384:9-387:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceType2Ct.CreditorReferenceType2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceType2Ct.CreditorReferenceType2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CreditorReferenceType2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>384:9-387:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class CreditorReferenceType2Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceType1ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceType1ChoiceCt" />
            /// </summary>
            [LxElementCt("CdOrPrtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceType1ChoiceCt CdOrPrtry { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceType1ChoiceCt();

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Issr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Issr { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType CurrencyAndAmountRange2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CurrencyAndAmountRange2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>389:5-395:22</XsdLocation>
    [LxComplexTypeDefinition("CurrencyAndAmountRange2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class CurrencyAndAmountRange2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CurrencyAndAmountRange2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>390:9-394:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.CurrencyAndAmountRange2Ct.CurrencyAndAmountRange2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CurrencyAndAmountRange2Ct.CurrencyAndAmountRange2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CurrencyAndAmountRange2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>390:9-394:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class CurrencyAndAmountRange2Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ImpliedCurrencyAmountRangeChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ImpliedCurrencyAmountRangeChoiceCt" />
            /// </summary>
            [LxElementCt("Amt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.ImpliedCurrencyAmountRangeChoiceCt Amt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ImpliedCurrencyAmountRangeChoiceCt();

            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("CdtDbtInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum? CdtDbtInd { get; set; }

            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Ccy", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, Pattern = "[A-Z]{3,3}")]
            public System.String Ccy { get; set; } = "";

        }

    }

    /// <summary>A class representing the root XSD complexType CurrencyExchange5@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CurrencyExchange5</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>396:5-405:22</XsdLocation>
    [LxComplexTypeDefinition("CurrencyExchange5", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class CurrencyExchange5Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CurrencyExchange5/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>397:9-404:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.CurrencyExchange5Ct.CurrencyExchange5Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.CurrencyExchange5Ct.CurrencyExchange5Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:CurrencyExchange5/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>397:9-404:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class CurrencyExchange5Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("SrcCcy", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, Pattern = "[A-Z]{3,3}")]
            public System.String SrcCcy { get; set; } = "";

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("TrgtCcy", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "[A-Z]{3,3}")]
            public System.String TrgtCcy { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("UnitCcy", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "[A-Z]{3,3}")]
            public System.String UnitCcy { get; set; }

            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
            [LxElementValue("XchgRate", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, TotalDigits = "11", FractionDigits = "10")]
            public LiquidTechnologies.XmlObjects.BigDecimal XchgRate { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("CtrctId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String CtrctId { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("QtnDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDateTime, MinOccurs = 0)]
            public LiquidTechnologies.XmlObjects.LxDateTime? QtnDt { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType DateAndDateTimeChoice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DateAndDateTimeChoice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>406:5-413:22</XsdLocation>
    [LxComplexTypeDefinition("DateAndDateTimeChoice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DateAndDateTimeChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DateAndDateTimeChoice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>407:9-412:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt.DateAndDateTimeChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt.DateAndDateTimeChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DateAndDateTimeChoice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>408:13-411:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class DateAndDateTimeChoiceSeqChc
        {
            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("Dt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDate)]
            public LiquidTechnologies.XmlObjects.LxDateTime? Dt { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("DtTm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDateTime)]
            public LiquidTechnologies.XmlObjects.LxDateTime? DtTm { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DateAndDateTimeChoice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>407:9-412:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class DateAndDateTimeChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DateAndDateTimeChoice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>408:13-411:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt.DateAndDateTimeChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt.DateAndDateTimeChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType DateAndPlaceOfBirth@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DateAndPlaceOfBirth</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>414:5-421:22</XsdLocation>
    [LxComplexTypeDefinition("DateAndPlaceOfBirth", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DateAndPlaceOfBirthCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DateAndPlaceOfBirth/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>415:9-420:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.DateAndPlaceOfBirthCt.DateAndPlaceOfBirthSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.DateAndPlaceOfBirthCt.DateAndPlaceOfBirthSeq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DateAndPlaceOfBirth/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>415:9-420:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class DateAndPlaceOfBirthSeq
        {
            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
            [LxElementValue("BirthDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDate)]
            public LiquidTechnologies.XmlObjects.LxDateTime BirthDt { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("PrvcOfBirth", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String PrvcOfBirth { get; set; }

            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("CityOfBirth", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String CityOfBirth { get; set; } = "";

            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("CtryOfBirth", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, Pattern = "[A-Z]{2,2}")]
            public System.String CtryOfBirth { get; set; } = "";

        }

    }

    /// <summary>A class representing the root XSD complexType DatePeriodDetails@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DatePeriodDetails</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>422:5-427:22</XsdLocation>
    [LxComplexTypeDefinition("DatePeriodDetails", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DatePeriodDetailsCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DatePeriodDetails/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>423:9-426:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.DatePeriodDetailsCt.DatePeriodDetailsSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.DatePeriodDetailsCt.DatePeriodDetailsSeq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DatePeriodDetails/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>423:9-426:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class DatePeriodDetailsSeq
        {
            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
            [LxElementValue("FrDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDate)]
            public LiquidTechnologies.XmlObjects.LxDateTime FrDt { get; set; }

            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
            [LxElementValue("ToDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDate)]
            public LiquidTechnologies.XmlObjects.LxDateTime ToDt { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType DateTimePeriodDetails@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DateTimePeriodDetails</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>428:5-433:22</XsdLocation>
    [LxComplexTypeDefinition("DateTimePeriodDetails", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DateTimePeriodDetailsCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DateTimePeriodDetails/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>429:9-432:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.DateTimePeriodDetailsCt.DateTimePeriodDetailsSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.DateTimePeriodDetailsCt.DateTimePeriodDetailsSeq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DateTimePeriodDetails/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>429:9-432:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class DateTimePeriodDetailsSeq
        {
            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
            [LxElementValue("FrDtTm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDateTime)]
            public LiquidTechnologies.XmlObjects.LxDateTime FrDtTm { get; set; }

            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
            [LxElementValue("ToDtTm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDateTime)]
            public LiquidTechnologies.XmlObjects.LxDateTime ToDtTm { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType DocumentAdjustment1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DocumentAdjustment1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>445:5-452:22</XsdLocation>
    [LxComplexTypeDefinition("DocumentAdjustment1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentAdjustment1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DocumentAdjustment1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>446:9-451:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.DocumentAdjustment1Ct.DocumentAdjustment1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.DocumentAdjustment1Ct.DocumentAdjustment1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:DocumentAdjustment1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>446:9-451:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class DocumentAdjustment1Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("Amt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt Amt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt();

            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("CdtDbtInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum? CdtDbtInd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Rsn", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "4")]
            public System.String Rsn { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("AddtlInf", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "140")]
            public System.String AddtlInf { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType Document@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Document</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>440:5-444:22</XsdLocation>
    [LxComplexTypeDefinition("Document", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Document/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>441:9-443:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.DocumentCt.DocumentSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.DocumentCt.DocumentSeq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Document/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>441:9-443:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class DocumentSeq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BankToCustomerStatementV02Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BankToCustomerStatementV02Ct" />
            /// </summary>
            [LxElementCt("BkToCstmrStmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.BankToCustomerStatementV02Ct BkToCstmrStmt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BankToCustomerStatementV02Ct();

        }

    }

    /// <summary>A class representing the root XSD complexType EntryDetails1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:EntryDetails1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>482:5-487:22</XsdLocation>
    [LxComplexTypeDefinition("EntryDetails1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class EntryDetails1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:EntryDetails1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>483:9-486:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.EntryDetails1Ct.EntryDetails1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.EntryDetails1Ct.EntryDetails1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:EntryDetails1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>483:9-486:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class EntryDetails1Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BatchInformation2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BatchInformation2Ct" />
            /// </summary>
            [LxElementCt("Btch", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BatchInformation2Ct Btch { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.EntryTransaction2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.EntryTransaction2Ct" />
            /// </summary>
            [LxElementCt("TxDtls", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.EntryTransaction2Ct> TxDtlss { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.EntryTransaction2Ct>();

        }

    }

    /// <summary>A class representing the root XSD complexType EntryTransaction2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:EntryTransaction2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>495:5-518:22</XsdLocation>
    [LxComplexTypeDefinition("EntryTransaction2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class EntryTransaction2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:EntryTransaction2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>496:9-517:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.EntryTransaction2Ct.EntryTransaction2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.EntryTransaction2Ct.EntryTransaction2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:EntryTransaction2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>496:9-517:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class EntryTransaction2Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionReferences2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionReferences2Ct" />
            /// </summary>
            [LxElementCt("Refs", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TransactionReferences2Ct Refs { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchange3Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchange3Ct" />
            /// </summary>
            [LxElementCt("AmtDtls", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchange3Ct AmtDtls { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct" />
            /// </summary>
            [LxElementCt("Avlbty", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct> Avlbtys { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct" />
            /// </summary>
            [LxElementCt("BkTxCd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct BkTxCd { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ChargesInformation6Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ChargesInformation6Ct" />
            /// </summary>
            [LxElementCt("Chrgs", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.ChargesInformation6Ct> Chrgss { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.ChargesInformation6Ct>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionInterest2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionInterest2Ct" />
            /// </summary>
            [LxElementCt("Intrst", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.TransactionInterest2Ct> Intrsts { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.TransactionInterest2Ct>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionParty2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionParty2Ct" />
            /// </summary>
            [LxElementCt("RltdPties", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TransactionParty2Ct RltdPties { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionAgents2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionAgents2Ct" />
            /// </summary>
            [LxElementCt("RltdAgts", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TransactionAgents2Ct RltdAgts { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.Purpose2ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.Purpose2ChoiceCt" />
            /// </summary>
            [LxElementCt("Purp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.Purpose2ChoiceCt Purp { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.RemittanceLocation2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.RemittanceLocation2Ct" />
            /// </summary>
            [LxElementCt("RltdRmtInf", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = 10)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.RemittanceLocation2Ct> RltdRmtInfs { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.RemittanceLocation2Ct>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.RemittanceInformation5Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.RemittanceInformation5Ct" />
            /// </summary>
            [LxElementCt("RmtInf", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.RemittanceInformation5Ct RmtInf { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionDates2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionDates2Ct" />
            /// </summary>
            [LxElementCt("RltdDts", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TransactionDates2Ct RltdDts { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionPrice2ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionPrice2ChoiceCt" />
            /// </summary>
            [LxElementCt("RltdPric", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TransactionPrice2ChoiceCt RltdPric { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionQuantities1ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionQuantities1ChoiceCt" />
            /// </summary>
            [LxElementCt("RltdQties", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.TransactionQuantities1ChoiceCt> RltdQtiess { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.TransactionQuantities1ChoiceCt>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.SecurityIdentification4ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.SecurityIdentification4ChoiceCt" />
            /// </summary>
            [LxElementCt("FinInstrmId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.SecurityIdentification4ChoiceCt FinInstrmId { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxInformation3Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxInformation3Ct" />
            /// </summary>
            [LxElementCt("Tax", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TaxInformation3Ct Tax { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ReturnReasonInformation10Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ReturnReasonInformation10Ct" />
            /// </summary>
            [LxElementCt("RtrInf", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ReturnReasonInformation10Ct RtrInf { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CorporateAction1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CorporateAction1Ct" />
            /// </summary>
            [LxElementCt("CorpActn", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.CorporateAction1Ct CorpActn { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccount16Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccount16Ct" />
            /// </summary>
            [LxElementCt("SfkpgAcct", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.CashAccount16Ct SfkpgAcct { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("AddtlTxInf", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "500")]
            public System.String AddtlTxInf { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType FinancialIdentificationSchemeName1Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FinancialIdentificationSchemeName1Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>597:5-604:22</XsdLocation>
    [LxComplexTypeDefinition("FinancialIdentificationSchemeName1Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class FinancialIdentificationSchemeName1ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FinancialIdentificationSchemeName1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>598:9-603:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.FinancialIdentificationSchemeName1ChoiceCt.FinancialIdentificationSchemeName1ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.FinancialIdentificationSchemeName1ChoiceCt.FinancialIdentificationSchemeName1ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FinancialIdentificationSchemeName1Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>599:13-602:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class FinancialIdentificationSchemeName1ChoiceSeqChc
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "4")]
            public System.String Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FinancialIdentificationSchemeName1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>598:9-603:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class FinancialIdentificationSchemeName1ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FinancialIdentificationSchemeName1Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>599:13-602:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.FinancialIdentificationSchemeName1ChoiceCt.FinancialIdentificationSchemeName1ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.FinancialIdentificationSchemeName1ChoiceCt.FinancialIdentificationSchemeName1ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType FinancialInstitutionIdentification7@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FinancialInstitutionIdentification7</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>605:5-613:22</XsdLocation>
    [LxComplexTypeDefinition("FinancialInstitutionIdentification7", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class FinancialInstitutionIdentification7Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FinancialInstitutionIdentification7/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>606:9-612:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.FinancialInstitutionIdentification7Ct.FinancialInstitutionIdentification7Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.FinancialInstitutionIdentification7Ct.FinancialInstitutionIdentification7Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FinancialInstitutionIdentification7/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>606:9-612:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class FinancialInstitutionIdentification7Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("BIC", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")]
            public System.String BIC { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ClearingSystemMemberIdentification2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ClearingSystemMemberIdentification2Ct" />
            /// </summary>
            [LxElementCt("ClrSysMmbId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ClearingSystemMemberIdentification2Ct ClrSysMmbId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Nm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "140")]
            public System.String Nm { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct" />
            /// </summary>
            [LxElementCt("PstlAdr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct PstlAdr { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.GenericFinancialIdentification1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.GenericFinancialIdentification1Ct" />
            /// </summary>
            [LxElementCt("Othr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.GenericFinancialIdentification1Ct Othr { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType FinancialInstrumentQuantityChoice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FinancialInstrumentQuantityChoice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>614:5-622:22</XsdLocation>
    [LxComplexTypeDefinition("FinancialInstrumentQuantityChoice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class FinancialInstrumentQuantityChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FinancialInstrumentQuantityChoice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>615:9-621:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.FinancialInstrumentQuantityChoiceCt.FinancialInstrumentQuantityChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.FinancialInstrumentQuantityChoiceCt.FinancialInstrumentQuantityChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FinancialInstrumentQuantityChoice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>616:13-620:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class FinancialInstrumentQuantityChoiceSeqChc
        {
            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("Unit", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, TotalDigits = "18", FractionDigits = "17")]
            public LiquidTechnologies.XmlObjects.BigDecimal? Unit { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("FaceAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinInclusive = "0", TotalDigits = "18", FractionDigits = "5")]
            public LiquidTechnologies.XmlObjects.BigDecimal? FaceAmt { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("AmtsdVal", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinInclusive = "0", TotalDigits = "18", FractionDigits = "5")]
            public LiquidTechnologies.XmlObjects.BigDecimal? AmtsdVal { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FinancialInstrumentQuantityChoice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>615:9-621:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class FinancialInstrumentQuantityChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FinancialInstrumentQuantityChoice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>616:13-620:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.FinancialInstrumentQuantityChoiceCt.FinancialInstrumentQuantityChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.FinancialInstrumentQuantityChoiceCt.FinancialInstrumentQuantityChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType FromToAmountRange@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FromToAmountRange</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>623:5-628:22</XsdLocation>
    [LxComplexTypeDefinition("FromToAmountRange", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class FromToAmountRangeCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FromToAmountRange/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>624:9-627:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.FromToAmountRangeCt.FromToAmountRangeSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.FromToAmountRangeCt.FromToAmountRangeSeq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:FromToAmountRange/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>624:9-627:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class FromToAmountRangeSeq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct" />
            /// </summary>
            [LxElementCt("FrAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct FrAmt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct" />
            /// </summary>
            [LxElementCt("ToAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct ToAmt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct();

        }

    }

    /// <summary>A class representing the root XSD complexType GenericAccountIdentification1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericAccountIdentification1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>629:5-635:22</XsdLocation>
    [LxComplexTypeDefinition("GenericAccountIdentification1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class GenericAccountIdentification1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericAccountIdentification1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>630:9-634:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.GenericAccountIdentification1Ct.GenericAccountIdentification1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.GenericAccountIdentification1Ct.GenericAccountIdentification1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericAccountIdentification1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>630:9-634:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class GenericAccountIdentification1Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Id", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "34")]
            public System.String Id { get; set; } = "";

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AccountSchemeName1ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AccountSchemeName1ChoiceCt" />
            /// </summary>
            [LxElementCt("SchmeNm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.AccountSchemeName1ChoiceCt SchmeNm { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Issr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Issr { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType GenericFinancialIdentification1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericFinancialIdentification1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>636:5-642:22</XsdLocation>
    [LxComplexTypeDefinition("GenericFinancialIdentification1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class GenericFinancialIdentification1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericFinancialIdentification1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>637:9-641:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.GenericFinancialIdentification1Ct.GenericFinancialIdentification1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.GenericFinancialIdentification1Ct.GenericFinancialIdentification1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericFinancialIdentification1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>637:9-641:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class GenericFinancialIdentification1Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Id", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Id { get; set; } = "";

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.FinancialIdentificationSchemeName1ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.FinancialIdentificationSchemeName1ChoiceCt" />
            /// </summary>
            [LxElementCt("SchmeNm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.FinancialIdentificationSchemeName1ChoiceCt SchmeNm { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Issr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Issr { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType GenericIdentification3@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericIdentification3</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>643:5-648:22</XsdLocation>
    [LxComplexTypeDefinition("GenericIdentification3", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class GenericIdentification3Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericIdentification3/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>644:9-647:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.GenericIdentification3Ct.GenericIdentification3Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.GenericIdentification3Ct.GenericIdentification3Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericIdentification3/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>644:9-647:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class GenericIdentification3Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Id", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Id { get; set; } = "";

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Issr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Issr { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType GenericOrganisationIdentification1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericOrganisationIdentification1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>649:5-655:22</XsdLocation>
    [LxComplexTypeDefinition("GenericOrganisationIdentification1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class GenericOrganisationIdentification1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericOrganisationIdentification1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>650:9-654:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.GenericOrganisationIdentification1Ct.GenericOrganisationIdentification1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.GenericOrganisationIdentification1Ct.GenericOrganisationIdentification1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericOrganisationIdentification1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>650:9-654:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class GenericOrganisationIdentification1Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Id", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Id { get; set; } = "";

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.OrganisationIdentificationSchemeName1ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.OrganisationIdentificationSchemeName1ChoiceCt" />
            /// </summary>
            [LxElementCt("SchmeNm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.OrganisationIdentificationSchemeName1ChoiceCt SchmeNm { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Issr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Issr { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType GenericPersonIdentification1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericPersonIdentification1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>656:5-662:22</XsdLocation>
    [LxComplexTypeDefinition("GenericPersonIdentification1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class GenericPersonIdentification1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericPersonIdentification1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>657:9-661:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.GenericPersonIdentification1Ct.GenericPersonIdentification1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.GenericPersonIdentification1Ct.GenericPersonIdentification1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GenericPersonIdentification1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>657:9-661:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class GenericPersonIdentification1Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Id", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Id { get; set; } = "";

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PersonIdentificationSchemeName1ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PersonIdentificationSchemeName1ChoiceCt" />
            /// </summary>
            [LxElementCt("SchmeNm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PersonIdentificationSchemeName1ChoiceCt SchmeNm { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Issr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Issr { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType GroupHeader42@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GroupHeader42</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>663:5-671:22</XsdLocation>
    [LxComplexTypeDefinition("GroupHeader42", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class GroupHeader42Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GroupHeader42/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>664:9-670:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.GroupHeader42Ct.GroupHeader42Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.GroupHeader42Ct.GroupHeader42Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:GroupHeader42/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>664:9-670:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class GroupHeader42Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("MsgId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String MsgId { get; set; } = "";

            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
            [LxElementValue("CreDtTm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDateTime)]
            public LiquidTechnologies.XmlObjects.LxDateTime CreDtTm { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />
            /// </summary>
            [LxElementCt("MsgRcpt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct MsgRcpt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PaginationCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PaginationCt" />
            /// </summary>
            [LxElementCt("MsgPgntn", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PaginationCt MsgPgntn { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("AddtlInf", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "500")]
            public System.String AddtlInf { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType ImpliedCurrencyAmountRangeChoice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ImpliedCurrencyAmountRangeChoice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>688:5-698:22</XsdLocation>
    [LxComplexTypeDefinition("ImpliedCurrencyAmountRangeChoice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ImpliedCurrencyAmountRangeChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ImpliedCurrencyAmountRangeChoice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>689:9-697:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ImpliedCurrencyAmountRangeChoiceCt.ImpliedCurrencyAmountRangeChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ImpliedCurrencyAmountRangeChoiceCt.ImpliedCurrencyAmountRangeChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ImpliedCurrencyAmountRangeChoice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>690:13-696:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class ImpliedCurrencyAmountRangeChoiceSeqChc
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct" />
            /// </summary>
            [LxElementCt("FrAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct FrAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct" />
            /// </summary>
            [LxElementCt("ToAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.AmountRangeBoundary1Ct ToAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.FromToAmountRangeCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.FromToAmountRangeCt" />
            /// </summary>
            [LxElementCt("FrToAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.FromToAmountRangeCt FrToAmt { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("EQAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinInclusive = "0", TotalDigits = "18", FractionDigits = "5")]
            public LiquidTechnologies.XmlObjects.BigDecimal? EQAmt { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("NEQAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinInclusive = "0", TotalDigits = "18", FractionDigits = "5")]
            public LiquidTechnologies.XmlObjects.BigDecimal? NEQAmt { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ImpliedCurrencyAmountRangeChoice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>689:9-697:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ImpliedCurrencyAmountRangeChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ImpliedCurrencyAmountRangeChoice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>690:13-696:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.ImpliedCurrencyAmountRangeChoiceCt.ImpliedCurrencyAmountRangeChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ImpliedCurrencyAmountRangeChoiceCt.ImpliedCurrencyAmountRangeChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType InterestType1Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:InterestType1Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>706:5-713:22</XsdLocation>
    [LxComplexTypeDefinition("InterestType1Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class InterestType1ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:InterestType1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>707:9-712:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.InterestType1ChoiceCt.InterestType1ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.InterestType1ChoiceCt.InterestType1ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:InterestType1Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>708:13-711:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class InterestType1ChoiceSeqChc
        {
            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.InterestType1CodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.InterestType1CodeEnum? Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:InterestType1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>707:9-712:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class InterestType1ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:InterestType1Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>708:13-711:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.InterestType1ChoiceCt.InterestType1ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.InterestType1ChoiceCt.InterestType1ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType MessageIdentification2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:MessageIdentification2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>789:5-794:22</XsdLocation>
    [LxComplexTypeDefinition("MessageIdentification2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class MessageIdentification2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:MessageIdentification2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>790:9-793:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.MessageIdentification2Ct.MessageIdentification2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.MessageIdentification2Ct.MessageIdentification2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:MessageIdentification2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>790:9-793:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class MessageIdentification2Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("MsgNmId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String MsgNmId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("MsgId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String MsgId { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType NameAndAddress10@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:NameAndAddress10</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>795:5-800:22</XsdLocation>
    [LxComplexTypeDefinition("NameAndAddress10", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class NameAndAddress10Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:NameAndAddress10/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>796:9-799:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.NameAndAddress10Ct.NameAndAddress10Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.NameAndAddress10Ct.NameAndAddress10Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:NameAndAddress10/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>796:9-799:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class NameAndAddress10Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Nm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "140")]
            public System.String Nm { get; set; } = "";

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct" />
            /// </summary>
            [LxElementCt("Adr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct Adr { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct();

        }

    }

    /// <summary>A class representing the root XSD complexType NumberAndSumOfTransactions1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:NumberAndSumOfTransactions1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>815:5-820:22</XsdLocation>
    [LxComplexTypeDefinition("NumberAndSumOfTransactions1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class NumberAndSumOfTransactions1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:NumberAndSumOfTransactions1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>816:9-819:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.NumberAndSumOfTransactions1Ct.NumberAndSumOfTransactions1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.NumberAndSumOfTransactions1Ct.NumberAndSumOfTransactions1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:NumberAndSumOfTransactions1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>816:9-819:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class NumberAndSumOfTransactions1Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("NbOfNtries", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "[0-9]{1,15}")]
            public System.String NbOfNtries { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("Sum", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, TotalDigits = "18", FractionDigits = "17")]
            public LiquidTechnologies.XmlObjects.BigDecimal? Sum { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType NumberAndSumOfTransactions2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:NumberAndSumOfTransactions2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>821:5-828:22</XsdLocation>
    [LxComplexTypeDefinition("NumberAndSumOfTransactions2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class NumberAndSumOfTransactions2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:NumberAndSumOfTransactions2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>822:9-827:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.NumberAndSumOfTransactions2Ct.NumberAndSumOfTransactions2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.NumberAndSumOfTransactions2Ct.NumberAndSumOfTransactions2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:NumberAndSumOfTransactions2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>822:9-827:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class NumberAndSumOfTransactions2Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("NbOfNtries", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "[0-9]{1,15}")]
            public System.String NbOfNtries { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("Sum", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, TotalDigits = "18", FractionDigits = "17")]
            public LiquidTechnologies.XmlObjects.BigDecimal? Sum { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("TtlNetNtryAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, TotalDigits = "18", FractionDigits = "17")]
            public LiquidTechnologies.XmlObjects.BigDecimal? TtlNetNtryAmt { get; set; }

            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("CdtDbtInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum? CdtDbtInd { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType OrganisationIdentification4@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:OrganisationIdentification4</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>829:5-834:22</XsdLocation>
    [LxComplexTypeDefinition("OrganisationIdentification4", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class OrganisationIdentification4Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:OrganisationIdentification4/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>830:9-833:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.OrganisationIdentification4Ct.OrganisationIdentification4Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.OrganisationIdentification4Ct.OrganisationIdentification4Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:OrganisationIdentification4/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>830:9-833:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class OrganisationIdentification4Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("BICOrBEI", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")]
            public System.String BICOrBEI { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.GenericOrganisationIdentification1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.GenericOrganisationIdentification1Ct" />
            /// </summary>
            [LxElementCt("Othr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.GenericOrganisationIdentification1Ct> Othrs { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.GenericOrganisationIdentification1Ct>();

        }

    }

    /// <summary>A class representing the root XSD complexType OrganisationIdentificationSchemeName1Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:OrganisationIdentificationSchemeName1Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>835:5-842:22</XsdLocation>
    [LxComplexTypeDefinition("OrganisationIdentificationSchemeName1Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class OrganisationIdentificationSchemeName1ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:OrganisationIdentificationSchemeName1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>836:9-841:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.OrganisationIdentificationSchemeName1ChoiceCt.OrganisationIdentificationSchemeName1ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.OrganisationIdentificationSchemeName1ChoiceCt.OrganisationIdentificationSchemeName1ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:OrganisationIdentificationSchemeName1Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>837:13-840:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class OrganisationIdentificationSchemeName1ChoiceSeqChc
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "4")]
            public System.String Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:OrganisationIdentificationSchemeName1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>836:9-841:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class OrganisationIdentificationSchemeName1ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:OrganisationIdentificationSchemeName1Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>837:13-840:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.OrganisationIdentificationSchemeName1ChoiceCt.OrganisationIdentificationSchemeName1ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.OrganisationIdentificationSchemeName1ChoiceCt.OrganisationIdentificationSchemeName1ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType Pagination@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Pagination</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>843:5-848:22</XsdLocation>
    [LxComplexTypeDefinition("Pagination", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class PaginationCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Pagination/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>844:9-847:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.PaginationCt.PaginationSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.PaginationCt.PaginationSeq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Pagination/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>844:9-847:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class PaginationSeq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("PgNb", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, Pattern = "[0-9]{1,5}")]
            public System.String PgNb { get; set; } = "";

            /// <summary>A <see cref="System.Boolean" />, Required</summary>
            [LxElementValue("LastPgInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdBoolean)]
            public System.Boolean LastPgInd { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType Party6Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Party6Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>849:5-856:22</XsdLocation>
    [LxComplexTypeDefinition("Party6Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class Party6ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Party6Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>850:9-855:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.Party6ChoiceCt.Party6ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.Party6ChoiceCt.Party6ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Party6Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>851:13-854:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class Party6ChoiceSeqChc
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.OrganisationIdentification4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.OrganisationIdentification4Ct" />
            /// </summary>
            [LxElementCt("OrgId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.OrganisationIdentification4Ct OrgId { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PersonIdentification5Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PersonIdentification5Ct" />
            /// </summary>
            [LxElementCt("PrvtId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.PersonIdentification5Ct PrvtId { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Party6Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>850:9-855:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class Party6ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Party6Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>851:13-854:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.Party6ChoiceCt.Party6ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.Party6ChoiceCt.Party6ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType PartyIdentification32@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:PartyIdentification32</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>857:5-865:22</XsdLocation>
    [LxComplexTypeDefinition("PartyIdentification32", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class PartyIdentification32Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:PartyIdentification32/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>858:9-864:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct.PartyIdentification32Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct.PartyIdentification32Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:PartyIdentification32/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>858:9-864:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class PartyIdentification32Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Nm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "140")]
            public System.String Nm { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct" />
            /// </summary>
            [LxElementCt("PstlAdr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct PstlAdr { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.Party6ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.Party6ChoiceCt" />
            /// </summary>
            [LxElementCt("Id", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.Party6ChoiceCt Id { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("CtryOfRes", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "[A-Z]{2,2}")]
            public System.String CtryOfRes { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ContactDetails2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ContactDetails2Ct" />
            /// </summary>
            [LxElementCt("CtctDtls", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ContactDetails2Ct CtctDtls { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType PersonIdentification5@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:PersonIdentification5</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>872:5-877:22</XsdLocation>
    [LxComplexTypeDefinition("PersonIdentification5", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class PersonIdentification5Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:PersonIdentification5/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>873:9-876:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.PersonIdentification5Ct.PersonIdentification5Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.PersonIdentification5Ct.PersonIdentification5Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:PersonIdentification5/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>873:9-876:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class PersonIdentification5Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateAndPlaceOfBirthCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateAndPlaceOfBirthCt" />
            /// </summary>
            [LxElementCt("DtAndPlcOfBirth", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.DateAndPlaceOfBirthCt DtAndPlcOfBirth { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.GenericPersonIdentification1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.GenericPersonIdentification1Ct" />
            /// </summary>
            [LxElementCt("Othr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.GenericPersonIdentification1Ct> Othrs { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.GenericPersonIdentification1Ct>();

        }

    }

    /// <summary>A class representing the root XSD complexType PersonIdentificationSchemeName1Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:PersonIdentificationSchemeName1Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>878:5-885:22</XsdLocation>
    [LxComplexTypeDefinition("PersonIdentificationSchemeName1Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class PersonIdentificationSchemeName1ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:PersonIdentificationSchemeName1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>879:9-884:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.PersonIdentificationSchemeName1ChoiceCt.PersonIdentificationSchemeName1ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.PersonIdentificationSchemeName1ChoiceCt.PersonIdentificationSchemeName1ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:PersonIdentificationSchemeName1Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>880:13-883:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class PersonIdentificationSchemeName1ChoiceSeqChc
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "4")]
            public System.String Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:PersonIdentificationSchemeName1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>879:9-884:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class PersonIdentificationSchemeName1ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:PersonIdentificationSchemeName1Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>880:13-883:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.PersonIdentificationSchemeName1ChoiceCt.PersonIdentificationSchemeName1ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.PersonIdentificationSchemeName1ChoiceCt.PersonIdentificationSchemeName1ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType PostalAddress6@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:PostalAddress6</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>891:5-904:22</XsdLocation>
    [LxComplexTypeDefinition("PostalAddress6", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class PostalAddress6Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:PostalAddress6/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>892:9-903:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct.PostalAddress6Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.PostalAddress6Ct.PostalAddress6Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:PostalAddress6/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>892:9-903:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class PostalAddress6Seq
        {
            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.AddressType2CodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("AdrTp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.AddressType2CodeEnum? AdrTp { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Dept", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "70")]
            public System.String Dept { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("SubDept", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "70")]
            public System.String SubDept { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("StrtNm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "70")]
            public System.String StrtNm { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("BldgNb", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "16")]
            public System.String BldgNb { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("PstCd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "16")]
            public System.String PstCd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("TwnNm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String TwnNm { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("CtrySubDvsn", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String CtrySubDvsn { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Ctry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "[A-Z]{2,2}")]
            public System.String Ctry { get; set; }

            /// <summary>A collection of <see cref="System.String" /></summary>
            [LxElementValue("AdrLine", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 7, MinLength = "1", MaxLength = "70")]
            public List<System.String> AdrLines { get; } = new List<System.String>();

        }

    }

    /// <summary>A class representing the root XSD complexType ProprietaryAgent2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryAgent2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>905:5-910:22</XsdLocation>
    [LxComplexTypeDefinition("ProprietaryAgent2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ProprietaryAgent2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryAgent2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>906:9-909:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ProprietaryAgent2Ct.ProprietaryAgent2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ProprietaryAgent2Ct.ProprietaryAgent2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryAgent2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>906:9-909:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ProprietaryAgent2Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Tp { get; set; } = "";

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />
            /// </summary>
            [LxElementCt("Agt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct Agt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct();

        }

    }

    /// <summary>A class representing the root XSD complexType ProprietaryBankTransactionCodeStructure1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryBankTransactionCodeStructure1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>911:5-916:22</XsdLocation>
    [LxComplexTypeDefinition("ProprietaryBankTransactionCodeStructure1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ProprietaryBankTransactionCodeStructure1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryBankTransactionCodeStructure1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>912:9-915:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ProprietaryBankTransactionCodeStructure1Ct.ProprietaryBankTransactionCodeStructure1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ProprietaryBankTransactionCodeStructure1Ct.ProprietaryBankTransactionCodeStructure1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryBankTransactionCodeStructure1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>912:9-915:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ProprietaryBankTransactionCodeStructure1Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Cd { get; set; } = "";

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Issr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Issr { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType ProprietaryDate2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryDate2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>917:5-922:22</XsdLocation>
    [LxComplexTypeDefinition("ProprietaryDate2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ProprietaryDate2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryDate2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>918:9-921:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ProprietaryDate2Ct.ProprietaryDate2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ProprietaryDate2Ct.ProprietaryDate2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryDate2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>918:9-921:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ProprietaryDate2Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Tp { get; set; } = "";

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt" />
            /// </summary>
            [LxElementCt("Dt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt Dt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt();

        }

    }

    /// <summary>A class representing the root XSD complexType ProprietaryParty2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryParty2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>923:5-928:22</XsdLocation>
    [LxComplexTypeDefinition("ProprietaryParty2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ProprietaryParty2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryParty2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>924:9-927:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ProprietaryParty2Ct.ProprietaryParty2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ProprietaryParty2Ct.ProprietaryParty2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryParty2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>924:9-927:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ProprietaryParty2Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Tp { get; set; } = "";

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />
            /// </summary>
            [LxElementCt("Pty", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct Pty { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct();

        }

    }

    /// <summary>A class representing the root XSD complexType ProprietaryPrice2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryPrice2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>929:5-934:22</XsdLocation>
    [LxComplexTypeDefinition("ProprietaryPrice2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ProprietaryPrice2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryPrice2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>930:9-933:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ProprietaryPrice2Ct.ProprietaryPrice2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ProprietaryPrice2Ct.ProprietaryPrice2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryPrice2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>930:9-933:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ProprietaryPrice2Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Tp { get; set; } = "";

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("Pric", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt Pric { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt();

        }

    }

    /// <summary>A class representing the root XSD complexType ProprietaryQuantity1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryQuantity1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>935:5-940:22</XsdLocation>
    [LxComplexTypeDefinition("ProprietaryQuantity1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ProprietaryQuantity1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryQuantity1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>936:9-939:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ProprietaryQuantity1Ct.ProprietaryQuantity1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ProprietaryQuantity1Ct.ProprietaryQuantity1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryQuantity1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>936:9-939:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ProprietaryQuantity1Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Tp { get; set; } = "";

            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Qty", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Qty { get; set; } = "";

        }

    }

    /// <summary>A class representing the root XSD complexType ProprietaryReference1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryReference1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>941:5-946:22</XsdLocation>
    [LxComplexTypeDefinition("ProprietaryReference1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ProprietaryReference1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryReference1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>942:9-945:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ProprietaryReference1Ct.ProprietaryReference1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ProprietaryReference1Ct.ProprietaryReference1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ProprietaryReference1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>942:9-945:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ProprietaryReference1Seq
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Tp { get; set; } = "";

            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("Ref", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Ref_ { get; set; } = "";

        }

    }

    /// <summary>A class representing the root XSD complexType Purpose2Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Purpose2Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>947:5-954:22</XsdLocation>
    [LxComplexTypeDefinition("Purpose2Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class Purpose2ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Purpose2Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>948:9-953:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.Purpose2ChoiceCt.Purpose2ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.Purpose2ChoiceCt.Purpose2ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Purpose2Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>949:13-952:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class Purpose2ChoiceSeqChc
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "4")]
            public System.String Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Purpose2Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>948:9-953:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class Purpose2ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Purpose2Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>949:13-952:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.Purpose2ChoiceCt.Purpose2ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.Purpose2ChoiceCt.Purpose2ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType Rate3@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Rate3</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>955:5-960:22</XsdLocation>
    [LxComplexTypeDefinition("Rate3", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class Rate3Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Rate3/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>956:9-959:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.Rate3Ct.Rate3Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.Rate3Ct.Rate3Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:Rate3/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>956:9-959:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class Rate3Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.RateType4ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.RateType4ChoiceCt" />
            /// </summary>
            [LxElementCt("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.RateType4ChoiceCt Tp { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.RateType4ChoiceCt();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CurrencyAndAmountRange2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CurrencyAndAmountRange2Ct" />
            /// </summary>
            [LxElementCt("VldtyRg", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.CurrencyAndAmountRange2Ct VldtyRg { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType RateType4Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:RateType4Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>961:5-968:22</XsdLocation>
    [LxComplexTypeDefinition("RateType4Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class RateType4ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:RateType4Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>962:9-967:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.RateType4ChoiceCt.RateType4ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.RateType4ChoiceCt.RateType4ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:RateType4Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>963:13-966:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class RateType4ChoiceSeqChc
        {
            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("Pctg", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, TotalDigits = "11", FractionDigits = "10")]
            public LiquidTechnologies.XmlObjects.BigDecimal? Pctg { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Othr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Othr { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:RateType4Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>962:9-967:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class RateType4ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:RateType4Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>963:13-966:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.RateType4ChoiceCt.RateType4ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.RateType4ChoiceCt.RateType4ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType ReferredDocumentInformation3@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReferredDocumentInformation3</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>969:5-975:22</XsdLocation>
    [LxComplexTypeDefinition("ReferredDocumentInformation3", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ReferredDocumentInformation3Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReferredDocumentInformation3/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>970:9-974:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentInformation3Ct.ReferredDocumentInformation3Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentInformation3Ct.ReferredDocumentInformation3Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReferredDocumentInformation3/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>970:9-974:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ReferredDocumentInformation3Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentType2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentType2Ct" />
            /// </summary>
            [LxElementCt("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentType2Ct Tp { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Nb", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Nb { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("RltdDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0)]
            public LiquidTechnologies.XmlObjects.LxDateTime? RltdDt { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType ReferredDocumentType1Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReferredDocumentType1Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>976:5-983:22</XsdLocation>
    [LxComplexTypeDefinition("ReferredDocumentType1Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ReferredDocumentType1ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReferredDocumentType1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>977:9-982:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentType1ChoiceCt.ReferredDocumentType1ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentType1ChoiceCt.ReferredDocumentType1ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReferredDocumentType1Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>978:13-981:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class ReferredDocumentType1ChoiceSeqChc
        {
            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.DocumentType5CodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.DocumentType5CodeEnum? Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReferredDocumentType1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>977:9-982:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ReferredDocumentType1ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReferredDocumentType1Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>978:13-981:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentType1ChoiceCt.ReferredDocumentType1ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentType1ChoiceCt.ReferredDocumentType1ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType ReferredDocumentType2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReferredDocumentType2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>984:5-989:22</XsdLocation>
    [LxComplexTypeDefinition("ReferredDocumentType2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ReferredDocumentType2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReferredDocumentType2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>985:9-988:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentType2Ct.ReferredDocumentType2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentType2Ct.ReferredDocumentType2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReferredDocumentType2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>985:9-988:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ReferredDocumentType2Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentType1ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentType1ChoiceCt" />
            /// </summary>
            [LxElementCt("CdOrPrtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentType1ChoiceCt CdOrPrtry { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentType1ChoiceCt();

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Issr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Issr { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType RemittanceAmount1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:RemittanceAmount1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>990:5-999:22</XsdLocation>
    [LxComplexTypeDefinition("RemittanceAmount1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class RemittanceAmount1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:RemittanceAmount1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>991:9-998:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.RemittanceAmount1Ct.RemittanceAmount1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.RemittanceAmount1Ct.RemittanceAmount1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:RemittanceAmount1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>991:9-998:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class RemittanceAmount1Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("DuePyblAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt DuePyblAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("DscntApldAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt DscntApldAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("CdtNoteAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt CdtNoteAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("TaxAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt TaxAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.DocumentAdjustment1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.DocumentAdjustment1Ct" />
            /// </summary>
            [LxElementCt("AdjstmntAmtAndRsn", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.DocumentAdjustment1Ct> AdjstmntAmtAndRsns { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.DocumentAdjustment1Ct>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("RmtdAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt RmtdAmt { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType RemittanceInformation5@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:RemittanceInformation5</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1000:5-1005:22</XsdLocation>
    [LxComplexTypeDefinition("RemittanceInformation5", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class RemittanceInformation5Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:RemittanceInformation5/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1001:9-1004:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.RemittanceInformation5Ct.RemittanceInformation5Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.RemittanceInformation5Ct.RemittanceInformation5Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:RemittanceInformation5/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1001:9-1004:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class RemittanceInformation5Seq
        {
            /// <summary>A collection of <see cref="System.String" /></summary>
            [LxElementValue("Ustrd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "140")]
            public List<System.String> Ustrds { get; } = new List<System.String>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.StructuredRemittanceInformation7Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.StructuredRemittanceInformation7Ct" />
            /// </summary>
            [LxElementCt("Strd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.StructuredRemittanceInformation7Ct> Strds { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.StructuredRemittanceInformation7Ct>();

        }

    }

    /// <summary>A class representing the root XSD complexType RemittanceLocation2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:RemittanceLocation2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1006:5-1013:22</XsdLocation>
    [LxComplexTypeDefinition("RemittanceLocation2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class RemittanceLocation2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:RemittanceLocation2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1007:9-1012:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.RemittanceLocation2Ct.RemittanceLocation2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.RemittanceLocation2Ct.RemittanceLocation2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:RemittanceLocation2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1007:9-1012:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class RemittanceLocation2Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("RmtId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String RmtId { get; set; }

            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.RemittanceLocationMethod2CodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("RmtLctnMtd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.RemittanceLocationMethod2CodeEnum? RmtLctnMtd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("RmtLctnElctrncAdr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "2048")]
            public System.String RmtLctnElctrncAdr { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.NameAndAddress10Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.NameAndAddress10Ct" />
            /// </summary>
            [LxElementCt("RmtLctnPstlAdr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.NameAndAddress10Ct RmtLctnPstlAdr { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType ReportEntry2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReportEntry2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1024:5-1045:22</XsdLocation>
    [LxComplexTypeDefinition("ReportEntry2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ReportEntry2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReportEntry2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1025:9-1044:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ReportEntry2Ct.ReportEntry2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ReportEntry2Ct.ReportEntry2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReportEntry2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1025:9-1044:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ReportEntry2Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("NtryRef", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String NtryRef { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("Amt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt Amt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt();

            /// <summary>A <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum" />, Required</summary>
            [LxElementValue("CdtDbtInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum CdtDbtInd { get; set; }

            /// <summary>A nullable <see cref="System.Boolean" />, Optional : null when not set</summary>
            [LxElementValue("RvslInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 0)]
            public System.Boolean? RvslInd { get; set; }

            /// <summary>A <see cref="Messages.ISO.CAMTx053x001x02.Tns.EntryStatus2CodeEnum" />, Required</summary>
            [LxElementValue("Sts", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.EntryStatus2CodeEnum Sts { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt" />
            /// </summary>
            [LxElementCt("BookgDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt BookgDt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt" />
            /// </summary>
            [LxElementCt("ValDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.DateAndDateTimeChoiceCt ValDt { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("AcctSvcrRef", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String AcctSvcrRef { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct" />
            /// </summary>
            [LxElementCt("Avlbty", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct> Avlbtys { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct" />
            /// </summary>
            [LxElementCt("BkTxCd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct BkTxCd { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct();

            /// <summary>A nullable <see cref="System.Boolean" />, Optional : null when not set</summary>
            [LxElementValue("ComssnWvrInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 0)]
            public System.Boolean? ComssnWvrInd { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.MessageIdentification2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.MessageIdentification2Ct" />
            /// </summary>
            [LxElementCt("AddtlInfInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.MessageIdentification2Ct AddtlInfInd { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchange3Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchange3Ct" />
            /// </summary>
            [LxElementCt("AmtDtls", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.AmountAndCurrencyExchange3Ct AmtDtls { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ChargesInformation6Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ChargesInformation6Ct" />
            /// </summary>
            [LxElementCt("Chrgs", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.ChargesInformation6Ct> Chrgss { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.ChargesInformation6Ct>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TechnicalInputChannel1ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TechnicalInputChannel1ChoiceCt" />
            /// </summary>
            [LxElementCt("TechInptChanl", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TechnicalInputChannel1ChoiceCt TechInptChanl { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionInterest2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TransactionInterest2Ct" />
            /// </summary>
            [LxElementCt("Intrst", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.TransactionInterest2Ct> Intrsts { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.TransactionInterest2Ct>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.EntryDetails1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.EntryDetails1Ct" />
            /// </summary>
            [LxElementCt("NtryDtls", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.EntryDetails1Ct> NtryDtlss { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.EntryDetails1Ct>();

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("AddtlNtryInf", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "500")]
            public System.String AddtlNtryInf { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType ReportingSource1Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReportingSource1Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1046:5-1053:22</XsdLocation>
    [LxComplexTypeDefinition("ReportingSource1Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ReportingSource1ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReportingSource1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1047:9-1052:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ReportingSource1ChoiceCt.ReportingSource1ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ReportingSource1ChoiceCt.ReportingSource1ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReportingSource1Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1048:13-1051:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class ReportingSource1ChoiceSeqChc
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "4")]
            public System.String Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReportingSource1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1047:9-1052:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ReportingSource1ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReportingSource1Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>1048:13-1051:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.ReportingSource1ChoiceCt.ReportingSource1ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ReportingSource1ChoiceCt.ReportingSource1ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType ReturnReason5Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReturnReason5Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1054:5-1061:22</XsdLocation>
    [LxComplexTypeDefinition("ReturnReason5Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ReturnReason5ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReturnReason5Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1055:9-1060:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ReturnReason5ChoiceCt.ReturnReason5ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ReturnReason5ChoiceCt.ReturnReason5ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReturnReason5Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1056:13-1059:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class ReturnReason5ChoiceSeqChc
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "4")]
            public System.String Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReturnReason5Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1055:9-1060:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ReturnReason5ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReturnReason5Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>1056:13-1059:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.ReturnReason5ChoiceCt.ReturnReason5ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ReturnReason5ChoiceCt.ReturnReason5ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType ReturnReasonInformation10@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReturnReasonInformation10</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1062:5-1069:22</XsdLocation>
    [LxComplexTypeDefinition("ReturnReasonInformation10", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class ReturnReasonInformation10Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReturnReasonInformation10/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1063:9-1068:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.ReturnReasonInformation10Ct.ReturnReasonInformation10Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ReturnReasonInformation10Ct.ReturnReasonInformation10Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:ReturnReasonInformation10/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1063:9-1068:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class ReturnReasonInformation10Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct" />
            /// </summary>
            [LxElementCt("OrgnlBkTxCd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct OrgnlBkTxCd { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />
            /// </summary>
            [LxElementCt("Orgtr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct Orgtr { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ReturnReason5ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ReturnReason5ChoiceCt" />
            /// </summary>
            [LxElementCt("Rsn", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ReturnReason5ChoiceCt Rsn { get; set; }

            /// <summary>A collection of <see cref="System.String" /></summary>
            [LxElementValue("AddtlInf", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "105")]
            public List<System.String> AddtlInfs { get; } = new List<System.String>();

        }

    }

    /// <summary>A class representing the root XSD complexType SecurityIdentification4Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:SecurityIdentification4Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1070:5-1077:22</XsdLocation>
    [LxComplexTypeDefinition("SecurityIdentification4Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class SecurityIdentification4ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:SecurityIdentification4Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1071:9-1076:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.SecurityIdentification4ChoiceCt.SecurityIdentification4ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.SecurityIdentification4ChoiceCt.SecurityIdentification4ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:SecurityIdentification4Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1072:13-1075:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class SecurityIdentification4ChoiceSeqChc
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("ISIN", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, Pattern = "[A-Z0-9]{12,12}")]
            public System.String ISIN { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.AlternateSecurityIdentification2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.AlternateSecurityIdentification2Ct" />
            /// </summary>
            [LxElementCt("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.AlternateSecurityIdentification2Ct Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:SecurityIdentification4Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1071:9-1076:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class SecurityIdentification4ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:SecurityIdentification4Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>1072:13-1075:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.SecurityIdentification4ChoiceCt.SecurityIdentification4ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.SecurityIdentification4ChoiceCt.SecurityIdentification4ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType StructuredRemittanceInformation7@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:StructuredRemittanceInformation7</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1078:5-1087:22</XsdLocation>
    [LxComplexTypeDefinition("StructuredRemittanceInformation7", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class StructuredRemittanceInformation7Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:StructuredRemittanceInformation7/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1079:9-1086:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.StructuredRemittanceInformation7Ct.StructuredRemittanceInformation7Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.StructuredRemittanceInformation7Ct.StructuredRemittanceInformation7Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:StructuredRemittanceInformation7/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1079:9-1086:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class StructuredRemittanceInformation7Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentInformation3Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentInformation3Ct" />
            /// </summary>
            [LxElementCt("RfrdDocInf", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentInformation3Ct> RfrdDocInfs { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.ReferredDocumentInformation3Ct>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.RemittanceAmount1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.RemittanceAmount1Ct" />
            /// </summary>
            [LxElementCt("RfrdDocAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.RemittanceAmount1Ct RfrdDocAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceInformation2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceInformation2Ct" />
            /// </summary>
            [LxElementCt("CdtrRefInf", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditorReferenceInformation2Ct CdtrRefInf { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />
            /// </summary>
            [LxElementCt("Invcr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct Invcr { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />
            /// </summary>
            [LxElementCt("Invcee", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct Invcee { get; set; }

            /// <summary>A collection of <see cref="System.String" /></summary>
            [LxElementValue("AddtlRmtInf", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 3, MinLength = "1", MaxLength = "140")]
            public List<System.String> AddtlRmtInfs { get; } = new List<System.String>();

        }

    }

    /// <summary>A class representing the root XSD complexType TaxAmount1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxAmount1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1088:5-1095:22</XsdLocation>
    [LxComplexTypeDefinition("TaxAmount1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TaxAmount1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxAmount1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1089:9-1094:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TaxAmount1Ct.TaxAmount1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TaxAmount1Ct.TaxAmount1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxAmount1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1089:9-1094:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TaxAmount1Seq
        {
            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("Rate", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, TotalDigits = "11", FractionDigits = "10")]
            public LiquidTechnologies.XmlObjects.BigDecimal? Rate { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("TaxblBaseAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt TaxblBaseAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("TtlAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt TtlAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxRecordDetails1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxRecordDetails1Ct" />
            /// </summary>
            [LxElementCt("Dtls", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.TaxRecordDetails1Ct> Dtlss { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.TaxRecordDetails1Ct>();

        }

    }

    /// <summary>A class representing the root XSD complexType TaxAuthorisation1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxAuthorisation1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1096:5-1101:22</XsdLocation>
    [LxComplexTypeDefinition("TaxAuthorisation1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TaxAuthorisation1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxAuthorisation1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1097:9-1100:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TaxAuthorisation1Ct.TaxAuthorisation1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TaxAuthorisation1Ct.TaxAuthorisation1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxAuthorisation1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1097:9-1100:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TaxAuthorisation1Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Titl", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Titl { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Nm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "140")]
            public System.String Nm { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType TaxCharges2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxCharges2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1102:5-1108:22</XsdLocation>
    [LxComplexTypeDefinition("TaxCharges2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TaxCharges2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxCharges2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1103:9-1107:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TaxCharges2Ct.TaxCharges2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TaxCharges2Ct.TaxCharges2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxCharges2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1103:9-1107:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TaxCharges2Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Id", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Id { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("Rate", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, TotalDigits = "11", FractionDigits = "10")]
            public LiquidTechnologies.XmlObjects.BigDecimal? Rate { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("Amt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt Amt { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType TaxInformation3@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxInformation3</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1109:5-1122:22</XsdLocation>
    [LxComplexTypeDefinition("TaxInformation3", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TaxInformation3Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxInformation3/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1110:9-1121:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TaxInformation3Ct.TaxInformation3Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TaxInformation3Ct.TaxInformation3Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxInformation3/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1110:9-1121:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TaxInformation3Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxParty1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxParty1Ct" />
            /// </summary>
            [LxElementCt("Cdtr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TaxParty1Ct Cdtr { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxParty2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxParty2Ct" />
            /// </summary>
            [LxElementCt("Dbtr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TaxParty2Ct Dbtr { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("AdmstnZn", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String AdmstnZn { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("RefNb", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "140")]
            public System.String RefNb { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Mtd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Mtd { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("TtlTaxblBaseAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt TtlTaxblBaseAmt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("TtlTaxAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt TtlTaxAmt { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("Dt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0)]
            public LiquidTechnologies.XmlObjects.LxDateTime? Dt { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("SeqNb", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, TotalDigits = "18", FractionDigits = "0")]
            public LiquidTechnologies.XmlObjects.BigDecimal? SeqNb { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxRecord1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxRecord1Ct" />
            /// </summary>
            [LxElementCt("Rcrd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.TaxRecord1Ct> Rcrds { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.TaxRecord1Ct>();

        }

    }

    /// <summary>A class representing the root XSD complexType TaxParty1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxParty1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1123:5-1129:22</XsdLocation>
    [LxComplexTypeDefinition("TaxParty1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TaxParty1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxParty1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1124:9-1128:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TaxParty1Ct.TaxParty1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TaxParty1Ct.TaxParty1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxParty1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1124:9-1128:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TaxParty1Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("TaxId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String TaxId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("RegnId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String RegnId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("TaxTp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String TaxTp { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType TaxParty2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxParty2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1130:5-1137:22</XsdLocation>
    [LxComplexTypeDefinition("TaxParty2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TaxParty2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxParty2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1131:9-1136:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TaxParty2Ct.TaxParty2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TaxParty2Ct.TaxParty2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxParty2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1131:9-1136:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TaxParty2Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("TaxId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String TaxId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("RegnId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String RegnId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("TaxTp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String TaxTp { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxAuthorisation1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxAuthorisation1Ct" />
            /// </summary>
            [LxElementCt("Authstn", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TaxAuthorisation1Ct Authstn { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType TaxPeriod1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxPeriod1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1138:5-1144:22</XsdLocation>
    [LxComplexTypeDefinition("TaxPeriod1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TaxPeriod1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxPeriod1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1139:9-1143:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TaxPeriod1Ct.TaxPeriod1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TaxPeriod1Ct.TaxPeriod1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxPeriod1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1139:9-1143:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TaxPeriod1Seq
        {
            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("Yr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0)]
            public LiquidTechnologies.XmlObjects.LxDateTime? Yr { get; set; }

            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxRecordPeriod1CodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.TaxRecordPeriod1CodeEnum? Tp { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.DatePeriodDetailsCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.DatePeriodDetailsCt" />
            /// </summary>
            [LxElementCt("FrToDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.DatePeriodDetailsCt FrToDt { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType TaxRecord1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxRecord1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1145:5-1157:22</XsdLocation>
    [LxComplexTypeDefinition("TaxRecord1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TaxRecord1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxRecord1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1146:9-1156:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TaxRecord1Ct.TaxRecord1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TaxRecord1Ct.TaxRecord1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxRecord1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1146:9-1156:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TaxRecord1Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Tp { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Ctgy", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Ctgy { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("CtgyDtls", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String CtgyDtls { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("DbtrSts", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String DbtrSts { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("CertId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String CertId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("FrmsCd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String FrmsCd { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxPeriod1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxPeriod1Ct" />
            /// </summary>
            [LxElementCt("Prd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TaxPeriod1Ct Prd { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxAmount1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxAmount1Ct" />
            /// </summary>
            [LxElementCt("TaxAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TaxAmount1Ct TaxAmt { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("AddtlInf", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "140")]
            public System.String AddtlInf { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType TaxRecordDetails1@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxRecordDetails1</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1158:5-1163:22</XsdLocation>
    [LxComplexTypeDefinition("TaxRecordDetails1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TaxRecordDetails1Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxRecordDetails1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1159:9-1162:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TaxRecordDetails1Ct.TaxRecordDetails1Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TaxRecordDetails1Ct.TaxRecordDetails1Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TaxRecordDetails1/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1159:9-1162:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TaxRecordDetails1Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxPeriod1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TaxPeriod1Ct" />
            /// </summary>
            [LxElementCt("Prd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.TaxPeriod1Ct Prd { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("Amt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt Amt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt();

        }

    }

    /// <summary>A class representing the root XSD complexType TechnicalInputChannel1Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TechnicalInputChannel1Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1186:5-1193:22</XsdLocation>
    [LxComplexTypeDefinition("TechnicalInputChannel1Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TechnicalInputChannel1ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TechnicalInputChannel1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1187:9-1192:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TechnicalInputChannel1ChoiceCt.TechnicalInputChannel1ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TechnicalInputChannel1ChoiceCt.TechnicalInputChannel1ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TechnicalInputChannel1Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1188:13-1191:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class TechnicalInputChannel1ChoiceSeqChc
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Cd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "4")]
            public System.String Cd { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinLength = "1", MaxLength = "35")]
            public System.String Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TechnicalInputChannel1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1187:9-1192:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TechnicalInputChannel1ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TechnicalInputChannel1Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>1188:13-1191:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.TechnicalInputChannel1ChoiceCt.TechnicalInputChannel1ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TechnicalInputChannel1ChoiceCt.TechnicalInputChannel1ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType TotalsPerBankTransactionCode2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TotalsPerBankTransactionCode2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1202:5-1212:22</XsdLocation>
    [LxComplexTypeDefinition("TotalsPerBankTransactionCode2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TotalsPerBankTransactionCode2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TotalsPerBankTransactionCode2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1203:9-1211:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TotalsPerBankTransactionCode2Ct.TotalsPerBankTransactionCode2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TotalsPerBankTransactionCode2Ct.TotalsPerBankTransactionCode2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TotalsPerBankTransactionCode2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1203:9-1211:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TotalsPerBankTransactionCode2Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("NbOfNtries", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, Pattern = "[0-9]{1,15}")]
            public System.String NbOfNtries { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("Sum", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, TotalDigits = "18", FractionDigits = "17")]
            public LiquidTechnologies.XmlObjects.BigDecimal? Sum { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            [LxElementValue("TtlNetNtryAmt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, TotalDigits = "18", FractionDigits = "17")]
            public LiquidTechnologies.XmlObjects.BigDecimal? TtlNetNtryAmt { get; set; }

            /// <summary>A nullable <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum" />, Optional : null when not set</summary>
            [LxElementValue("CdtDbtInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum? CdtDbtInd { get; set; }

            /// <summary>A nullable <see cref="System.Boolean" />, Optional : null when not set</summary>
            [LxElementValue("FcstInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 0)]
            public System.Boolean? FcstInd { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct" />
            /// </summary>
            [LxElementCt("BkTxCd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct BkTxCd { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.BankTransactionCodeStructure4Ct();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct" />
            /// </summary>
            [LxElementCt("Avlbty", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct> Avlbtys { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.CashBalanceAvailability2Ct>();

        }

    }

    /// <summary>A class representing the root XSD complexType TotalTransactions2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TotalTransactions2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1194:5-1201:22</XsdLocation>
    [LxComplexTypeDefinition("TotalTransactions2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TotalTransactions2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TotalTransactions2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1195:9-1200:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TotalTransactions2Ct.TotalTransactions2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TotalTransactions2Ct.TotalTransactions2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TotalTransactions2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1195:9-1200:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TotalTransactions2Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.NumberAndSumOfTransactions2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.NumberAndSumOfTransactions2Ct" />
            /// </summary>
            [LxElementCt("TtlNtries", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.NumberAndSumOfTransactions2Ct TtlNtries { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.NumberAndSumOfTransactions1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.NumberAndSumOfTransactions1Ct" />
            /// </summary>
            [LxElementCt("TtlCdtNtries", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.NumberAndSumOfTransactions1Ct TtlCdtNtries { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.NumberAndSumOfTransactions1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.NumberAndSumOfTransactions1Ct" />
            /// </summary>
            [LxElementCt("TtlDbtNtries", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.NumberAndSumOfTransactions1Ct TtlDbtNtries { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.TotalsPerBankTransactionCode2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.TotalsPerBankTransactionCode2Ct" />
            /// </summary>
            [LxElementCt("TtlNtriesPerBkTxCd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.TotalsPerBankTransactionCode2Ct> TtlNtriesPerBkTxCds { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.TotalsPerBankTransactionCode2Ct>();

        }

    }

    /// <summary>A class representing the root XSD complexType TransactionAgents2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionAgents2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1213:5-1226:22</XsdLocation>
    [LxComplexTypeDefinition("TransactionAgents2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TransactionAgents2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionAgents2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1214:9-1225:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TransactionAgents2Ct.TransactionAgents2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TransactionAgents2Ct.TransactionAgents2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionAgents2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1214:9-1225:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TransactionAgents2Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />
            /// </summary>
            [LxElementCt("DbtrAgt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct DbtrAgt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />
            /// </summary>
            [LxElementCt("CdtrAgt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct CdtrAgt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />
            /// </summary>
            [LxElementCt("IntrmyAgt1", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct IntrmyAgt1 { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />
            /// </summary>
            [LxElementCt("IntrmyAgt2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct IntrmyAgt2 { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />
            /// </summary>
            [LxElementCt("IntrmyAgt3", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct IntrmyAgt3 { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />
            /// </summary>
            [LxElementCt("RcvgAgt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct RcvgAgt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />
            /// </summary>
            [LxElementCt("DlvrgAgt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct DlvrgAgt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />
            /// </summary>
            [LxElementCt("IssgAgt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct IssgAgt { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct" />
            /// </summary>
            [LxElementCt("SttlmPlc", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.BranchAndFinancialInstitutionIdentification4Ct SttlmPlc { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ProprietaryAgent2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ProprietaryAgent2Ct" />
            /// </summary>
            [LxElementCt("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.ProprietaryAgent2Ct> Prtrys { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.ProprietaryAgent2Ct>();

        }

    }

    /// <summary>A class representing the root XSD complexType TransactionDates2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionDates2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1227:5-1238:22</XsdLocation>
    [LxComplexTypeDefinition("TransactionDates2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TransactionDates2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionDates2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1228:9-1237:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TransactionDates2Ct.TransactionDates2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TransactionDates2Ct.TransactionDates2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionDates2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1228:9-1237:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TransactionDates2Seq
        {
            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("AccptncDtTm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDateTime, MinOccurs = 0)]
            public LiquidTechnologies.XmlObjects.LxDateTime? AccptncDtTm { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("TradActvtyCtrctlSttlmDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0)]
            public LiquidTechnologies.XmlObjects.LxDateTime? TradActvtyCtrctlSttlmDt { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("TradDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0)]
            public LiquidTechnologies.XmlObjects.LxDateTime? TradDt { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("IntrBkSttlmDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0)]
            public LiquidTechnologies.XmlObjects.LxDateTime? IntrBkSttlmDt { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("StartDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0)]
            public LiquidTechnologies.XmlObjects.LxDateTime? StartDt { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("EndDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0)]
            public LiquidTechnologies.XmlObjects.LxDateTime? EndDt { get; set; }

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            [LxElementValue("TxDtTm", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdDateTime, MinOccurs = 0)]
            public LiquidTechnologies.XmlObjects.LxDateTime? TxDtTm { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ProprietaryDate2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ProprietaryDate2Ct" />
            /// </summary>
            [LxElementCt("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.ProprietaryDate2Ct> Prtrys { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.ProprietaryDate2Ct>();

        }

    }

    /// <summary>A class representing the root XSD complexType TransactionInterest2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionInterest2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1239:5-1248:22</XsdLocation>
    [LxComplexTypeDefinition("TransactionInterest2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TransactionInterest2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionInterest2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1240:9-1247:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TransactionInterest2Ct.TransactionInterest2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TransactionInterest2Ct.TransactionInterest2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionInterest2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1240:9-1247:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TransactionInterest2Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("Amt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt Amt { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt();

            /// <summary>A <see cref="Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum" />, Required</summary>
            [LxElementValue("CdtDbtInd", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Enum, XsdType.Enum, WhiteSpace = WhiteSpaceType.Preserve)]
            public Messages.ISO.CAMTx053x001x02.Tns.CreditDebitCodeEnum CdtDbtInd { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.InterestType1ChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.InterestType1ChoiceCt" />
            /// </summary>
            [LxElementCt("Tp", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.InterestType1ChoiceCt Tp { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.Rate3Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.Rate3Ct" />
            /// </summary>
            [LxElementCt("Rate", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.Rate3Ct> Rates { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.Rate3Ct>();

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateTimePeriodDetailsCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.DateTimePeriodDetailsCt" />
            /// </summary>
            [LxElementCt("FrToDt", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.DateTimePeriodDetailsCt FrToDt { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("Rsn", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String Rsn { get; set; }

        }

    }

    /// <summary>A class representing the root XSD complexType TransactionParty2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionParty2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1249:5-1261:22</XsdLocation>
    [LxComplexTypeDefinition("TransactionParty2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TransactionParty2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionParty2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1250:9-1260:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TransactionParty2Ct.TransactionParty2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TransactionParty2Ct.TransactionParty2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionParty2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1250:9-1260:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TransactionParty2Seq
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />
            /// </summary>
            [LxElementCt("InitgPty", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct InitgPty { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />
            /// </summary>
            [LxElementCt("Dbtr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct Dbtr { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccount16Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccount16Ct" />
            /// </summary>
            [LxElementCt("DbtrAcct", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.CashAccount16Ct DbtrAcct { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />
            /// </summary>
            [LxElementCt("UltmtDbtr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct UltmtDbtr { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />
            /// </summary>
            [LxElementCt("Cdtr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct Cdtr { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccount16Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.CashAccount16Ct" />
            /// </summary>
            [LxElementCt("CdtrAcct", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.CashAccount16Ct CdtrAcct { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />
            /// </summary>
            [LxElementCt("UltmtCdtr", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct UltmtCdtr { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct" />
            /// </summary>
            [LxElementCt("TradgPty", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.PartyIdentification32Ct TradgPty { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ProprietaryParty2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ProprietaryParty2Ct" />
            /// </summary>
            [LxElementCt("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.ProprietaryParty2Ct> Prtrys { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.ProprietaryParty2Ct>();

        }

    }

    /// <summary>A class representing the root XSD complexType TransactionPrice2Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionPrice2Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1262:5-1269:22</XsdLocation>
    [LxComplexTypeDefinition("TransactionPrice2Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TransactionPrice2ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionPrice2Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1263:9-1268:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TransactionPrice2ChoiceCt.TransactionPrice2ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TransactionPrice2ChoiceCt.TransactionPrice2ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionPrice2Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1264:13-1267:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class TransactionPrice2ChoiceSeqChc
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt" />
            /// </summary>
            [LxElementCt("DealPric", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.ActiveOrHistoricCurrencyAndAmountCt DealPric { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ProprietaryPrice2Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ProprietaryPrice2Ct" />
            /// </summary>
            [LxElementCt("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MaxOccurs = LxConstants.Unbounded)]
            public List<Messages.ISO.CAMTx053x001x02.Tns.ProprietaryPrice2Ct> Prtrys { get; } = new List<Messages.ISO.CAMTx053x001x02.Tns.ProprietaryPrice2Ct>();

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionPrice2Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1263:9-1268:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TransactionPrice2ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionPrice2Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>1264:13-1267:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.TransactionPrice2ChoiceCt.TransactionPrice2ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TransactionPrice2ChoiceCt.TransactionPrice2ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType TransactionQuantities1Choice@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionQuantities1Choice</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1270:5-1277:22</XsdLocation>
    [LxComplexTypeDefinition("TransactionQuantities1Choice", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TransactionQuantities1ChoiceCt : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionQuantities1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1271:9-1276:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TransactionQuantities1ChoiceCt.TransactionQuantities1ChoiceSeq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TransactionQuantities1ChoiceCt.TransactionQuantities1ChoiceSeq();

        /// <summary>A class representing an xs:choice.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionQuantities1Choice/sequence/choice</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1272:13-1275:25</XsdLocation>
        [LxCompositorDefinition(CompositorType.Choice)]
        public partial class TransactionQuantities1ChoiceSeqChc
        {
            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.FinancialInstrumentQuantityChoiceCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.FinancialInstrumentQuantityChoiceCt" />
            /// </summary>
            [LxElementCt("Qty", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.FinancialInstrumentQuantityChoiceCt Qty { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ProprietaryQuantity1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ProprietaryQuantity1Ct" />
            /// </summary>
            [LxElementCt("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
            public Messages.ISO.CAMTx053x001x02.Tns.ProprietaryQuantity1Ct Prtry { get; set; }

        }

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionQuantities1Choice/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1271:9-1276:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TransactionQuantities1ChoiceSeq
        {
            /// <summary>A class representing an xs:choice.</summary>
            /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionQuantities1Choice/sequence/choice</XsdPath>
            /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
            /// <XsdLocation>1272:13-1275:25</XsdLocation>
            [LxElementCompositor()]
            public Messages.ISO.CAMTx053x001x02.Tns.TransactionQuantities1ChoiceCt.TransactionQuantities1ChoiceSeqChc Chc { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TransactionQuantities1ChoiceCt.TransactionQuantities1ChoiceSeqChc();

        }

    }

    /// <summary>A class representing the root XSD complexType TransactionReferences2@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionReferences2</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>1278:5-1291:22</XsdLocation>
    [LxComplexTypeDefinition("TransactionReferences2", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class TransactionReferences2Ct : Messages.ISO.CAMTx053x001x02.LxBase
    {
        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionReferences2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1279:9-1290:23</XsdLocation>
        [LxElementCompositor()]
        public Messages.ISO.CAMTx053x001x02.Tns.TransactionReferences2Ct.TransactionReferences2Seq Seq { get; set; } = new Messages.ISO.CAMTx053x001x02.Tns.TransactionReferences2Ct.TransactionReferences2Seq();

        /// <summary>A class representing an xs:sequence.</summary>
        /// <XsdPath>schema:camt.053.001.02.xsd/complexType:TransactionReferences2/sequence</XsdPath>
        /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
        /// <XsdLocation>1279:9-1290:23</XsdLocation>
        [LxCompositorDefinition(CompositorType.Sequence)]
        public partial class TransactionReferences2Seq
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("MsgId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String MsgId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("AcctSvcrRef", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String AcctSvcrRef { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("PmtInfId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String PmtInfId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("InstrId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String InstrId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("EndToEndId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String EndToEndId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("TxId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String TxId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("MndtId", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String MndtId { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("ChqNb", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String ChqNb { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue("ClrSysRef", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MinLength = "1", MaxLength = "35")]
            public System.String ClrSysRef { get; set; }

            /// <summary>
            ///   A class derived from <see cref="Messages.ISO.CAMTx053x001x02.Tns.ProprietaryReference1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="Messages.ISO.CAMTx053x001x02.Tns.ProprietaryReference1Ct" />
            /// </summary>
            [LxElementCt("Prtry", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", MinOccurs = 0)]
            public Messages.ISO.CAMTx053x001x02.Tns.ProprietaryReference1Ct Prtry { get; set; }

        }

    }

    #endregion

    #region Elements
    /// <summary>A class representing the root XSD element Document@urn:iso:std:iso:20022:tech:xsd:camt.053.001.02</summary>
    /// <XsdPath>schema:camt.053.001.02.xsd/element:Document</XsdPath>
    /// <XsdFile>C:\Dev\SAP\ISO20022\code\Iso20022\XmlReflect\Data\camt.053.001.02.xsd</XsdFile>
    /// <XsdLocation>4:5-4:50</XsdLocation>
    [LxElementDefinition("Document", "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", ElementScopeType.GlobalElement)]
    public partial class DocumentElm : Messages.ISO.CAMTx053x001x02.Tns.DocumentCt
    {
    }

    #endregion

}

namespace Messages.ISO.CAMTx053x001x02.Xs
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType anyType@http://www.w3.org/2001/XMLSchema</summary>
    /// <XsdPath>schema:.../www.w3.org/2001/XMLSchema/complexType:anyType</XsdPath>
    /// <XsdFile>http://www.w3.org/2001/XMLSchema</XsdFile>
    /// <XsdLocation>Empty</XsdLocation>
    [LxComplexTypeDefinition("anyType", "http://www.w3.org/2001/XMLSchema")]
    public partial class AnyTypeCt : XElement
    {
        /// <summary>Constructor : create a <see cref="AnyTypeCt" /> element &lt;anyType xmlns='http://www.w3.org/2001/XMLSchema'&gt;</summary>
        public AnyTypeCt()  : base(XName.Get("anyType", "http://www.w3.org/2001/XMLSchema")) { }

    }

    #endregion

}

