using System.Collections.Generic;
using System.Xml.Serialization;

namespace DummyClient
{
    public class Components
    {

        [XmlRoot(ElementName = "realmCode", Namespace = "urn:hl7-org:v3")]
        public class RealmCode
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
        }

        [XmlRoot(ElementName = "typeId", Namespace = "urn:hl7-org:v3")]
        public class TypeId
        {
            [XmlAttribute(AttributeName = "extension")]
            public string Extension { get; set; }
            [XmlAttribute(AttributeName = "root")]
            public string Root { get; set; }
        }

        [XmlRoot(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
        public class TemplateId
        {
            [XmlAttribute(AttributeName = "root")]
            public string Root { get; set; }
            [XmlAttribute(AttributeName = "extension")]
            public string Extension { get; set; }
        }

        [XmlRoot(ElementName = "id", Namespace = "urn:hl7-org:v3")]
        public class Id
        {
            [XmlAttribute(AttributeName = "extension")]
            public string Extension { get; set; }
            [XmlAttribute(AttributeName = "root")]
            public string Root { get; set; }
        }

        [XmlRoot(ElementName = "code", Namespace = "urn:hl7-org:v3")]
        public class Code
        {
            [XmlAttribute(AttributeName = "code")]
            public string _code { get; set; }
            [XmlAttribute(AttributeName = "displayName")]
            public string DisplayName { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
            [XmlAttribute(AttributeName = "codeSystemName")]
            public string CodeSystemName { get; set; }
            [XmlElement(ElementName = "originalText", Namespace = "urn:hl7-org:v3")]
            public OriginalText OriginalText { get; set; }
            [XmlElement(ElementName = "translation", Namespace = "urn:hl7-org:v3")]
            public Translation Translation { get; set; }
            [XmlAttribute(AttributeName = "type", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "nullFlavor")]
            public string NullFlavor { get; set; }
        }

        [XmlRoot(ElementName = "effectiveTime", Namespace = "urn:hl7-org:v3")]
        public class EffectiveTime
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
            [XmlElement(ElementName = "low", Namespace = "urn:hl7-org:v3")]
            public Low Low { get; set; }
            [XmlElement(ElementName = "high", Namespace = "urn:hl7-org:v3")]
            public High High { get; set; }
            [XmlAttribute(AttributeName = "type", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string Type { get; set; }
            [XmlElement(ElementName = "period", Namespace = "urn:hl7-org:v3")]
            public Period Period { get; set; }
            [XmlAttribute(AttributeName = "institutionSpecified")]
            public string InstitutionSpecified { get; set; }
            [XmlAttribute(AttributeName = "operator")]
            public string Operator { get; set; }
        }

        [XmlRoot(ElementName = "confidentialityCode", Namespace = "urn:hl7-org:v3")]
        public class ConfidentialityCode
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "displayName")]
            public string DisplayName { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
            [XmlAttribute(AttributeName = "codeSystemName")]
            public string CodeSystemName { get; set; }
        }

        [XmlRoot(ElementName = "languageCode", Namespace = "urn:hl7-org:v3")]
        public class LanguageCode
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
        }

        [XmlRoot(ElementName = "setId", Namespace = "urn:hl7-org:v3")]
        public class SetId
        {
            [XmlAttribute(AttributeName = "extension")]
            public string Extension { get; set; }
            [XmlAttribute(AttributeName = "root")]
            public string Root { get; set; }
        }

        [XmlRoot(ElementName = "versionNumber", Namespace = "urn:hl7-org:v3")]
        public class VersionNumber
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }

        [XmlRoot(ElementName = "addr", Namespace = "urn:hl7-org:v3")]
        public class Addr
        {
            [XmlElement(ElementName = "streetAddressLine", Namespace = "urn:hl7-org:v3")]
            public string StreetAddressLine { get; set; }
            [XmlElement(ElementName = "city", Namespace = "urn:hl7-org:v3")]
            public string City { get; set; }
            [XmlElement(ElementName = "state", Namespace = "urn:hl7-org:v3")]
            public string State { get; set; }
            [XmlElement(ElementName = "postalCode", Namespace = "urn:hl7-org:v3")]
            public string PostalCode { get; set; }
            [XmlElement(ElementName = "country", Namespace = "urn:hl7-org:v3")]
            public string Country { get; set; }
            [XmlAttribute(AttributeName = "use")]
            public string Use { get; set; }
        }

        [XmlRoot(ElementName = "telecom", Namespace = "urn:hl7-org:v3")]
        public class Telecom
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
            [XmlAttribute(AttributeName = "use")]
            public string Use { get; set; }
        }

        [XmlRoot(ElementName = "name", Namespace = "urn:hl7-org:v3")]
        public class Name
        {
            [XmlElement(ElementName = "family", Namespace = "urn:hl7-org:v3")]
            public string Family { get; set; }
            [XmlAttribute(AttributeName = "use")]
            public string Use { get; set; }
            [XmlElement(ElementName = "given", Namespace = "urn:hl7-org:v3")]
            public Given Given { get; set; }
            [XmlElement(ElementName = "prefix", Namespace = "urn:hl7-org:v3")]
            public Prefix Prefix { get; set; }
            [XmlElement(ElementName = "suffix", Namespace = "urn:hl7-org:v3")]
            public string Suffix { get; set; }
        }

        [XmlRoot(ElementName = "given", Namespace = "urn:hl7-org:v3")]
        public class Given
        {
            [XmlAttribute(AttributeName = "qualifier")]
            public string Qualifier { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "administrativeGenderCode", Namespace = "urn:hl7-org:v3")]
        public class AdministrativeGenderCode
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "displayName")]
            public string DisplayName { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
            [XmlAttribute(AttributeName = "codeSystemName")]
            public string CodeSystemName { get; set; }
        }

        [XmlRoot(ElementName = "birthTime", Namespace = "urn:hl7-org:v3")]
        public class BirthTime
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }

        [XmlRoot(ElementName = "maritalStatusCode", Namespace = "urn:hl7-org:v3")]
        public class MaritalStatusCode
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "displayName")]
            public string DisplayName { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
            [XmlAttribute(AttributeName = "codeSystemName")]
            public string CodeSystemName { get; set; }
        }

        [XmlRoot(ElementName = "religiousAffiliationCode", Namespace = "urn:hl7-org:v3")]
        public class ReligiousAffiliationCode
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "displayName")]
            public string DisplayName { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
            [XmlAttribute(AttributeName = "codeSystemName")]
            public string CodeSystemName { get; set; }
        }

        [XmlRoot(ElementName = "raceCode", Namespace = "urn:hl7-org:v3")]
        public class RaceCode
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "displayName")]
            public string DisplayName { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
            [XmlAttribute(AttributeName = "codeSystemName")]
            public string CodeSystemName { get; set; }
        }

        [XmlRoot(ElementName = "raceCode", Namespace = "urn:hl7-org:sdtc")]
        public class RaceCode2
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "displayName")]
            public string DisplayName { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
            [XmlAttribute(AttributeName = "codeSystemName")]
            public string CodeSystemName { get; set; }
            [XmlAttribute(AttributeName = "xmlns")]
            public string Xmlns { get; set; }
        }

        [XmlRoot(ElementName = "ethnicGroupCode", Namespace = "urn:hl7-org:v3")]
        public class EthnicGroupCode
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "displayName")]
            public string DisplayName { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
            [XmlAttribute(AttributeName = "codeSystemName")]
            public string CodeSystemName { get; set; }
        }

        [XmlRoot(ElementName = "modeCode", Namespace = "urn:hl7-org:v3")]
        public class ModeCode
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "displayName")]
            public string DisplayName { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
            [XmlAttribute(AttributeName = "codeSystemName")]
            public string CodeSystemName { get; set; }
        }

        [XmlRoot(ElementName = "preferenceInd", Namespace = "urn:hl7-org:v3")]
        public class PreferenceInd
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }

        [XmlRoot(ElementName = "languageCommunication", Namespace = "urn:hl7-org:v3")]
        public class LanguageCommunication
        {
            [XmlElement(ElementName = "languageCode", Namespace = "urn:hl7-org:v3")]
            public LanguageCode LanguageCode { get; set; }
            [XmlElement(ElementName = "modeCode", Namespace = "urn:hl7-org:v3")]
            public ModeCode ModeCode { get; set; }
            [XmlElement(ElementName = "preferenceInd", Namespace = "urn:hl7-org:v3")]
            public PreferenceInd PreferenceInd { get; set; }
        }

        [XmlRoot(ElementName = "patient", Namespace = "urn:hl7-org:v3")]
        public class Patient
        {
            [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
            public List<Name> Name { get; set; }
            [XmlElement(ElementName = "administrativeGenderCode", Namespace = "urn:hl7-org:v3")]
            public AdministrativeGenderCode AdministrativeGenderCode { get; set; }
            [XmlElement(ElementName = "birthTime", Namespace = "urn:hl7-org:v3")]
            public BirthTime BirthTime { get; set; }
            [XmlElement(ElementName = "maritalStatusCode", Namespace = "urn:hl7-org:v3")]
            public MaritalStatusCode MaritalStatusCode { get; set; }
            [XmlElement(ElementName = "religiousAffiliationCode", Namespace = "urn:hl7-org:v3")]
            public ReligiousAffiliationCode ReligiousAffiliationCode { get; set; }
            [XmlElement(ElementName = "raceCode", Namespace = "urn:hl7-org:v3")]
            public RaceCode RaceCode { get; set; }
            [XmlElement(ElementName = "raceCode", Namespace = "urn:hl7-org:sdtc")]
            public RaceCode2 RaceCode2 { get; set; }
            [XmlElement(ElementName = "ethnicGroupCode", Namespace = "urn:hl7-org:v3")]
            public EthnicGroupCode EthnicGroupCode { get; set; }
            [XmlElement(ElementName = "languageCommunication", Namespace = "urn:hl7-org:v3")]
            public LanguageCommunication LanguageCommunication { get; set; }
        }

        [XmlRoot(ElementName = "providerOrganization", Namespace = "urn:hl7-org:v3")]
        public class ProviderOrganization
        {
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
            public string Name { get; set; }
            [XmlElement(ElementName = "telecom", Namespace = "urn:hl7-org:v3")]
            public Telecom Telecom { get; set; }
            [XmlElement(ElementName = "addr", Namespace = "urn:hl7-org:v3")]
            public Addr Addr { get; set; }
        }

        [XmlRoot(ElementName = "patientRole", Namespace = "urn:hl7-org:v3")]
        public class PatientRole
        {
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "addr", Namespace = "urn:hl7-org:v3")]
            public Addr Addr { get; set; }
            [XmlElement(ElementName = "telecom", Namespace = "urn:hl7-org:v3")]
            public List<Telecom> Telecom { get; set; }
            [XmlElement(ElementName = "patient", Namespace = "urn:hl7-org:v3")]
            public Patient Patient { get; set; }
            [XmlElement(ElementName = "providerOrganization", Namespace = "urn:hl7-org:v3")]
            public ProviderOrganization ProviderOrganization { get; set; }
        }

        [XmlRoot(ElementName = "recordTarget", Namespace = "urn:hl7-org:v3")]
        public class RecordTarget
        {
            [XmlElement(ElementName = "patientRole", Namespace = "urn:hl7-org:v3")]
            public PatientRole PatientRole { get; set; }
        }

        [XmlRoot(ElementName = "time", Namespace = "urn:hl7-org:v3")]
        public class Time
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
            [XmlElement(ElementName = "low", Namespace = "urn:hl7-org:v3")]
            public Low Low { get; set; }
        }

        [XmlRoot(ElementName = "assignedAuthoringDevice", Namespace = "urn:hl7-org:v3")]
        public class AssignedAuthoringDevice
        {
            [XmlElement(ElementName = "manufacturerModelName", Namespace = "urn:hl7-org:v3")]
            public string ManufacturerModelName { get; set; }
            [XmlElement(ElementName = "softwareName", Namespace = "urn:hl7-org:v3")]
            public string SoftwareName { get; set; }
        }

        [XmlRoot(ElementName = "representedOrganization", Namespace = "urn:hl7-org:v3")]
        public class RepresentedOrganization
        {
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
            public string Name { get; set; }
            [XmlElement(ElementName = "telecom", Namespace = "urn:hl7-org:v3")]
            public Telecom Telecom { get; set; }
            [XmlElement(ElementName = "addr", Namespace = "urn:hl7-org:v3")]
            public Addr Addr { get; set; }
        }

        [XmlRoot(ElementName = "assignedAuthor", Namespace = "urn:hl7-org:v3")]
        public class AssignedAuthor
        {
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlElement(ElementName = "addr", Namespace = "urn:hl7-org:v3")]
            public Addr Addr { get; set; }
            [XmlElement(ElementName = "telecom", Namespace = "urn:hl7-org:v3")]
            public Telecom Telecom { get; set; }
            [XmlElement(ElementName = "assignedAuthoringDevice", Namespace = "urn:hl7-org:v3")]
            public AssignedAuthoringDevice AssignedAuthoringDevice { get; set; }
            [XmlElement(ElementName = "representedOrganization", Namespace = "urn:hl7-org:v3")]
            public RepresentedOrganization RepresentedOrganization { get; set; }
            [XmlElement(ElementName = "assignedPerson", Namespace = "urn:hl7-org:v3")]
            public AssignedPerson AssignedPerson { get; set; }
        }

        [XmlRoot(ElementName = "author", Namespace = "urn:hl7-org:v3")]
        public class Author
        {
            [XmlElement(ElementName = "time", Namespace = "urn:hl7-org:v3")]
            public Time Time { get; set; }
            [XmlElement(ElementName = "assignedAuthor", Namespace = "urn:hl7-org:v3")]
            public AssignedAuthor AssignedAuthor { get; set; }
            [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
            public TemplateId TemplateId { get; set; }
            [XmlAttribute(AttributeName = "typeCode")]
            public string TypeCode { get; set; }
        }

        [XmlRoot(ElementName = "assignedPerson", Namespace = "urn:hl7-org:v3")]
        public class AssignedPerson
        {
            [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
            public Name Name { get; set; }
        }

        [XmlRoot(ElementName = "assignedEntity", Namespace = "urn:hl7-org:v3")]
        public class AssignedEntity
        {
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "addr", Namespace = "urn:hl7-org:v3")]
            public Addr Addr { get; set; }
            [XmlElement(ElementName = "telecom", Namespace = "urn:hl7-org:v3")]
            public Telecom Telecom { get; set; }
            [XmlElement(ElementName = "assignedPerson", Namespace = "urn:hl7-org:v3")]
            public AssignedPerson AssignedPerson { get; set; }
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlElement(ElementName = "representedOrganization", Namespace = "urn:hl7-org:v3")]
            public RepresentedOrganization RepresentedOrganization { get; set; }
        }

        [XmlRoot(ElementName = "dataEnterer", Namespace = "urn:hl7-org:v3")]
        public class DataEnterer
        {
            [XmlElement(ElementName = "assignedEntity", Namespace = "urn:hl7-org:v3")]
            public AssignedEntity AssignedEntity { get; set; }
        }

        [XmlRoot(ElementName = "informant", Namespace = "urn:hl7-org:v3")]
        public class Informant
        {
            [XmlElement(ElementName = "assignedEntity", Namespace = "urn:hl7-org:v3")]
            public AssignedEntity AssignedEntity { get; set; }
            [XmlElement(ElementName = "relatedEntity", Namespace = "urn:hl7-org:v3")]
            public RelatedEntity RelatedEntity { get; set; }
        }

        [XmlRoot(ElementName = "relatedPerson", Namespace = "urn:hl7-org:v3")]
        public class RelatedPerson
        {
            [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
            public Name Name { get; set; }
        }

        [XmlRoot(ElementName = "relatedEntity", Namespace = "urn:hl7-org:v3")]
        public class RelatedEntity
        {
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlElement(ElementName = "relatedPerson", Namespace = "urn:hl7-org:v3")]
            public RelatedPerson RelatedPerson { get; set; }
            [XmlAttribute(AttributeName = "classCode")]
            public string ClassCode { get; set; }
        }

        [XmlRoot(ElementName = "representedCustodianOrganization", Namespace = "urn:hl7-org:v3")]
        public class RepresentedCustodianOrganization
        {
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
            public string Name { get; set; }
            [XmlElement(ElementName = "telecom", Namespace = "urn:hl7-org:v3")]
            public Telecom Telecom { get; set; }
            [XmlElement(ElementName = "addr", Namespace = "urn:hl7-org:v3")]
            public Addr Addr { get; set; }
        }

        [XmlRoot(ElementName = "assignedCustodian", Namespace = "urn:hl7-org:v3")]
        public class AssignedCustodian
        {
            [XmlElement(ElementName = "representedCustodianOrganization", Namespace = "urn:hl7-org:v3")]
            public RepresentedCustodianOrganization RepresentedCustodianOrganization { get; set; }
        }

        [XmlRoot(ElementName = "custodian", Namespace = "urn:hl7-org:v3")]
        public class Custodian
        {
            [XmlElement(ElementName = "assignedCustodian", Namespace = "urn:hl7-org:v3")]
            public AssignedCustodian AssignedCustodian { get; set; }
        }

        [XmlRoot(ElementName = "informationRecipient", Namespace = "urn:hl7-org:v3")]
        public class InformationRecipient
        {
            [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
            public Name Name { get; set; }
        }

        [XmlRoot(ElementName = "receivedOrganization", Namespace = "urn:hl7-org:v3")]
        public class ReceivedOrganization
        {
            [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
            public string Name { get; set; }
        }

        [XmlRoot(ElementName = "intendedRecipient", Namespace = "urn:hl7-org:v3")]
        public class IntendedRecipient
        {
            [XmlElement(ElementName = "informationRecipient", Namespace = "urn:hl7-org:v3")]
            public InformationRecipient InformationRecipient { get; set; }
            [XmlElement(ElementName = "receivedOrganization", Namespace = "urn:hl7-org:v3")]
            public ReceivedOrganization ReceivedOrganization { get; set; }
        }

        [XmlRoot(ElementName = "signatureCode", Namespace = "urn:hl7-org:v3")]
        public class SignatureCode
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
        }

        [XmlRoot(ElementName = "legalAuthenticator", Namespace = "urn:hl7-org:v3")]
        public class LegalAuthenticator
        {
            [XmlElement(ElementName = "time", Namespace = "urn:hl7-org:v3")]
            public Time Time { get; set; }
            [XmlElement(ElementName = "signatureCode", Namespace = "urn:hl7-org:v3")]
            public SignatureCode SignatureCode { get; set; }
            [XmlElement(ElementName = "assignedEntity", Namespace = "urn:hl7-org:v3")]
            public AssignedEntity AssignedEntity { get; set; }
        }

        [XmlRoot(ElementName = "authenticator", Namespace = "urn:hl7-org:v3")]
        public class Authenticator
        {
            [XmlElement(ElementName = "time", Namespace = "urn:hl7-org:v3")]
            public Time Time { get; set; }
            [XmlElement(ElementName = "signatureCode", Namespace = "urn:hl7-org:v3")]
            public SignatureCode SignatureCode { get; set; }
            [XmlElement(ElementName = "assignedEntity", Namespace = "urn:hl7-org:v3")]
            public AssignedEntity AssignedEntity { get; set; }
        }

        [XmlRoot(ElementName = "associatedPerson", Namespace = "urn:hl7-org:v3")]
        public class AssociatedPerson
        {
            [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
            public Name Name { get; set; }
        }

        [XmlRoot(ElementName = "associatedEntity", Namespace = "urn:hl7-org:v3")]
        public class AssociatedEntity
        {
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlElement(ElementName = "addr", Namespace = "urn:hl7-org:v3")]
            public Addr Addr { get; set; }
            [XmlElement(ElementName = "telecom", Namespace = "urn:hl7-org:v3")]
            public Telecom Telecom { get; set; }
            [XmlElement(ElementName = "associatedPerson", Namespace = "urn:hl7-org:v3")]
            public AssociatedPerson AssociatedPerson { get; set; }
            [XmlAttribute(AttributeName = "classCode")]
            public string ClassCode { get; set; }
        }

        [XmlRoot(ElementName = "participant", Namespace = "urn:hl7-org:v3")]
        public class Participant
        {
            [XmlElement(ElementName = "associatedEntity", Namespace = "urn:hl7-org:v3")]
            public AssociatedEntity AssociatedEntity { get; set; }
            [XmlAttribute(AttributeName = "typeCode")]
            public string TypeCode { get; set; }
            [XmlElement(ElementName = "participantRole", Namespace = "urn:hl7-org:v3")]
            public ParticipantRole ParticipantRole { get; set; }
        }

        [XmlRoot(ElementName = "low", Namespace = "urn:hl7-org:v3")]
        public class Low
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
            [XmlAttribute(AttributeName = "nullFlavor")]
            public string NullFlavor { get; set; }
            [XmlAttribute(AttributeName = "unit")]
            public string Unit { get; set; }
        }

        [XmlRoot(ElementName = "high", Namespace = "urn:hl7-org:v3")]
        public class High
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
            [XmlAttribute(AttributeName = "nullFlavor")]
            public string NullFlavor { get; set; }
            [XmlAttribute(AttributeName = "unit")]
            public string Unit { get; set; }
        }

        [XmlRoot(ElementName = "functionCode", Namespace = "urn:hl7-org:v3")]
        public class FunctionCode
        {
            [XmlElement(ElementName = "originalText", Namespace = "urn:hl7-org:v3")]
            public string OriginalText { get; set; }
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
            [XmlAttribute(AttributeName = "codeSystemName")]
            public string CodeSystemName { get; set; }
            [XmlAttribute(AttributeName = "displayName")]
            public string DisplayName { get; set; }
        }

        [XmlRoot(ElementName = "prefix", Namespace = "urn:hl7-org:v3")]
        public class Prefix
        {
            [XmlAttribute(AttributeName = "qualifier")]
            public string Qualifier { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "performer", Namespace = "urn:hl7-org:v3")]
        public class Performer
        {
            [XmlElement(ElementName = "functionCode", Namespace = "urn:hl7-org:v3")]
            public FunctionCode FunctionCode { get; set; }
            [XmlElement(ElementName = "assignedEntity", Namespace = "urn:hl7-org:v3")]
            public AssignedEntity AssignedEntity { get; set; }
            [XmlAttribute(AttributeName = "typeCode")]
            public string TypeCode { get; set; }
            [XmlElement(ElementName = "time", Namespace = "urn:hl7-org:v3")]
            public Time Time { get; set; }
        }

        [XmlRoot(ElementName = "serviceEvent", Namespace = "urn:hl7-org:v3")]
        public class ServiceEvent
        {
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlElement(ElementName = "effectiveTime", Namespace = "urn:hl7-org:v3")]
            public EffectiveTime EffectiveTime { get; set; }
            [XmlElement(ElementName = "performer", Namespace = "urn:hl7-org:v3")]
            public List<Performer> Performer { get; set; }
            [XmlAttribute(AttributeName = "classCode")]
            public string ClassCode { get; set; }
        }

        [XmlRoot(ElementName = "documentationOf", Namespace = "urn:hl7-org:v3")]
        public class DocumentationOf
        {
            [XmlElement(ElementName = "serviceEvent", Namespace = "urn:hl7-org:v3")]
            public ServiceEvent ServiceEvent { get; set; }
        }

        [XmlRoot(ElementName = "encompassingEncounter", Namespace = "urn:hl7-org:v3")]
        public class EncompassingEncounter
        {
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "effectiveTime", Namespace = "urn:hl7-org:v3")]
            public EffectiveTime EffectiveTime { get; set; }
        }

        [XmlRoot(ElementName = "componentOf", Namespace = "urn:hl7-org:v3")]
        public class ComponentOf
        {
            [XmlElement(ElementName = "encompassingEncounter", Namespace = "urn:hl7-org:v3")]
            public EncompassingEncounter EncompassingEncounter { get; set; }
        }

        [XmlRoot(ElementName = "tr", Namespace = "urn:hl7-org:v3")]
        public class Tr
        {
            [XmlElement(ElementName = "td", Namespace = "urn:hl7-org:v3")]
            public List<Td> Td { get; set; }
            [XmlElement(ElementName = "th", Namespace = "urn:hl7-org:v3")]
            public Th Th { get; set; }
            [XmlAttribute(AttributeName = "ID")]
            public string ID { get; set; }
        }

        [XmlRoot(ElementName = "thead", Namespace = "urn:hl7-org:v3")]
        public class Thead
        {
            [XmlElement(ElementName = "tr", Namespace = "urn:hl7-org:v3")]
            public Tr Tr { get; set; }
        }

        [XmlRoot(ElementName = "content", Namespace = "urn:hl7-org:v3")]
        public class Content
        {
            [XmlAttribute(AttributeName = "ID")]
            public string ID { get; set; }
            [XmlText]
            public string Text { get; set; }
            [XmlAttribute(AttributeName = "styleCode")]
            public string StyleCode { get; set; }
        }

        [XmlRoot(ElementName = "td", Namespace = "urn:hl7-org:v3")]
        public class Td
        {
            [XmlElement(ElementName = "content", Namespace = "urn:hl7-org:v3")]
            public Content Content { get; set; }
            [XmlAttribute(AttributeName = "ID")]
            public string ID { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "tbody", Namespace = "urn:hl7-org:v3")]
        public class Tbody
        {
            [XmlElement(ElementName = "tr", Namespace = "urn:hl7-org:v3")]
            public List<Tr> Tr { get; set; }
        }

        [XmlRoot(ElementName = "table", Namespace = "urn:hl7-org:v3")]
        public class Table
        {
            [XmlElement(ElementName = "thead", Namespace = "urn:hl7-org:v3")]
            public Thead Thead { get; set; }
            [XmlElement(ElementName = "tbody", Namespace = "urn:hl7-org:v3")]
            public Tbody Tbody { get; set; }
            [XmlAttribute(AttributeName = "border")]
            public string Border { get; set; }
            [XmlAttribute(AttributeName = "width")]
            public string Width { get; set; }
        }

        [XmlRoot(ElementName = "text", Namespace = "urn:hl7-org:v3")]
        public class Text
        {
            [XmlElement(ElementName = "table", Namespace = "urn:hl7-org:v3")]
            public List<Table> Table { get; set; }
            [XmlElement(ElementName = "reference", Namespace = "urn:hl7-org:v3")]
            public Reference Reference { get; set; }
            [XmlElement(ElementName = "paragraph", Namespace = "urn:hl7-org:v3")]
            public List<string> Paragraph { get; set; }
            [XmlElement(ElementName = "list", Namespace = "urn:hl7-org:v3")]
            public List<List> List { get; set; }
            [XmlElement(ElementName = "content", Namespace = "urn:hl7-org:v3")]
            public Content Content { get; set; }
            [XmlElement(ElementName = "br", Namespace = "urn:hl7-org:v3")]
            public List<string> Br { get; set; }
        }

        [XmlRoot(ElementName = "statusCode", Namespace = "urn:hl7-org:v3")]
        public class StatusCode
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
        }

        [XmlRoot(ElementName = "value", Namespace = "urn:hl7-org:v3")]
        public class Value
        {
            [XmlAttribute(AttributeName = "type", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "displayName")]
            public string DisplayName { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
            [XmlAttribute(AttributeName = "codeSystemName")]
            public string CodeSystemName { get; set; }
            [XmlAttribute(AttributeName = "value")]
            public string _value { get; set; }
            [XmlAttribute(AttributeName = "unit")]
            public string Unit { get; set; }
            [XmlText]
            public string Text { get; set; }
            [XmlElement(ElementName = "low", Namespace = "urn:hl7-org:v3")]
            public Low Low { get; set; }
            [XmlElement(ElementName = "high", Namespace = "urn:hl7-org:v3")]
            public High High { get; set; }
        }

        [XmlRoot(ElementName = "reference", Namespace = "urn:hl7-org:v3")]
        public class Reference
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }

        [XmlRoot(ElementName = "originalText", Namespace = "urn:hl7-org:v3")]
        public class OriginalText
        {
            [XmlElement(ElementName = "reference", Namespace = "urn:hl7-org:v3")]
            public Reference Reference { get; set; }
        }

        [XmlRoot(ElementName = "playingEntity", Namespace = "urn:hl7-org:v3")]
        public class PlayingEntity
        {
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlAttribute(AttributeName = "classCode")]
            public string ClassCode { get; set; }
            [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
            public string Name { get; set; }
        }

        [XmlRoot(ElementName = "participantRole", Namespace = "urn:hl7-org:v3")]
        public class ParticipantRole
        {
            [XmlElement(ElementName = "playingEntity", Namespace = "urn:hl7-org:v3")]
            public PlayingEntity PlayingEntity { get; set; }
            [XmlAttribute(AttributeName = "classCode")]
            public string ClassCode { get; set; }
            [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
            public TemplateId TemplateId { get; set; }
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlElement(ElementName = "addr", Namespace = "urn:hl7-org:v3")]
            public Addr Addr { get; set; }
            [XmlElement(ElementName = "telecom", Namespace = "urn:hl7-org:v3")]
            public Telecom Telecom { get; set; }
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "playingDevice", Namespace = "urn:hl7-org:v3")]
            public PlayingDevice PlayingDevice { get; set; }
            [XmlElement(ElementName = "scopingEntity", Namespace = "urn:hl7-org:v3")]
            public ScopingEntity ScopingEntity { get; set; }
        }

        [XmlRoot(ElementName = "observation", Namespace = "urn:hl7-org:v3")]
        public class Observation
        {
            [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
            public List<TemplateId> TemplateId { get; set; }
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlElement(ElementName = "text", Namespace = "urn:hl7-org:v3")]
            public Text Text { get; set; }
            [XmlElement(ElementName = "statusCode", Namespace = "urn:hl7-org:v3")]
            public StatusCode StatusCode { get; set; }
            [XmlElement(ElementName = "value", Namespace = "urn:hl7-org:v3")]
            public Value Value { get; set; }
            [XmlAttribute(AttributeName = "classCode")]
            public string ClassCode { get; set; }
            [XmlAttribute(AttributeName = "moodCode")]
            public string MoodCode { get; set; }
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "effectiveTime", Namespace = "urn:hl7-org:v3")]
            public EffectiveTime EffectiveTime { get; set; }
            [XmlElement(ElementName = "participant", Namespace = "urn:hl7-org:v3")]
            public Participant Participant { get; set; }
            [XmlElement(ElementName = "entryRelationship", Namespace = "urn:hl7-org:v3")]
            public EntryRelationship EntryRelationship { get; set; }
            [XmlElement(ElementName = "interpretationCode", Namespace = "urn:hl7-org:v3")]
            public InterpretationCode InterpretationCode { get; set; }
            [XmlElement(ElementName = "referenceRange", Namespace = "urn:hl7-org:v3")]
            public ReferenceRange ReferenceRange { get; set; }
            [XmlElement(ElementName = "targetSiteCode", Namespace = "urn:hl7-org:v3")]
            public TargetSiteCode TargetSiteCode { get; set; }
            [XmlElement(ElementName = "author", Namespace = "urn:hl7-org:v3")]
            public List<Author> Author { get; set; }
        }

        [XmlRoot(ElementName = "entryRelationship", Namespace = "urn:hl7-org:v3")]
        public class EntryRelationship
        {
            [XmlElement(ElementName = "observation", Namespace = "urn:hl7-org:v3")]
            public Observation Observation { get; set; }
            [XmlAttribute(AttributeName = "typeCode")]
            public string TypeCode { get; set; }
            [XmlAttribute(AttributeName = "inversionInd")]
            public string InversionInd { get; set; }
            [XmlElement(ElementName = "act", Namespace = "urn:hl7-org:v3")]
            public Act Act { get; set; }
        }

        [XmlRoot(ElementName = "act", Namespace = "urn:hl7-org:v3")]
        public class Act
        {
            [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
            public List<TemplateId> TemplateId { get; set; }
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlElement(ElementName = "statusCode", Namespace = "urn:hl7-org:v3")]
            public StatusCode StatusCode { get; set; }
            [XmlElement(ElementName = "effectiveTime", Namespace = "urn:hl7-org:v3")]
            public EffectiveTime EffectiveTime { get; set; }
            [XmlElement(ElementName = "entryRelationship", Namespace = "urn:hl7-org:v3")]
            public List<EntryRelationship> EntryRelationship { get; set; }
            [XmlAttribute(AttributeName = "classCode")]
            public string ClassCode { get; set; }
            [XmlAttribute(AttributeName = "moodCode")]
            public string MoodCode { get; set; }
        }

        [XmlRoot(ElementName = "entry", Namespace = "urn:hl7-org:v3")]
        public class Entry
        {
            [XmlElement(ElementName = "act", Namespace = "urn:hl7-org:v3")]
            public Act Act { get; set; }
            [XmlAttribute(AttributeName = "typeCode")]
            public string TypeCode { get; set; }
            [XmlElement(ElementName = "substanceAdministration", Namespace = "urn:hl7-org:v3")]
            public SubstanceAdministration SubstanceAdministration { get; set; }
            [XmlElement(ElementName = "encounter", Namespace = "urn:hl7-org:v3")]
            public Encounter Encounter { get; set; }
            [XmlElement(ElementName = "organizer", Namespace = "urn:hl7-org:v3")]
            public Organizer Organizer { get; set; }
            [XmlElement(ElementName = "observation", Namespace = "urn:hl7-org:v3")]
            public Observation Observation { get; set; }
            [XmlElement(ElementName = "procedure", Namespace = "urn:hl7-org:v3")]
            public Procedure Procedure { get; set; }
        }

        [XmlRoot(ElementName = "section", Namespace = "urn:hl7-org:v3")]
        public class Section
        {
            [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
            public List<TemplateId> TemplateId { get; set; }
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlElement(ElementName = "title", Namespace = "urn:hl7-org:v3")]
            public string Title { get; set; }
            [XmlElement(ElementName = "text", Namespace = "urn:hl7-org:v3")]
            public Text Text { get; set; }
            [XmlElement(ElementName = "entry", Namespace = "urn:hl7-org:v3")]
            public List<Entry> Entry { get; set; }
        }

        [XmlRoot(ElementName = "component", Namespace = "urn:hl7-org:v3")]
        public class Component
        {
            [XmlElement(ElementName = "section", Namespace = "urn:hl7-org:v3")]
            public Section Section { get; set; }
        }

        [XmlRoot(ElementName = "period", Namespace = "urn:hl7-org:v3")]
        public class Period
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
            [XmlAttribute(AttributeName = "unit")]
            public string Unit { get; set; }
        }

        [XmlRoot(ElementName = "routeCode", Namespace = "urn:hl7-org:v3")]
        public class RouteCode
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
            [XmlAttribute(AttributeName = "codeSystemName")]
            public string CodeSystemName { get; set; }
            [XmlAttribute(AttributeName = "displayName")]
            public string DisplayName { get; set; }
        }

        [XmlRoot(ElementName = "doseQuantity", Namespace = "urn:hl7-org:v3")]
        public class DoseQuantity
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }

        [XmlRoot(ElementName = "manufacturedMaterial", Namespace = "urn:hl7-org:v3")]
        public class ManufacturedMaterial
        {
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlElement(ElementName = "lotNumberText", Namespace = "urn:hl7-org:v3")]
            public string LotNumberText { get; set; }
        }

        [XmlRoot(ElementName = "manufacturedProduct", Namespace = "urn:hl7-org:v3")]
        public class ManufacturedProduct
        {
            [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
            public List<TemplateId> TemplateId { get; set; }
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "manufacturedMaterial", Namespace = "urn:hl7-org:v3")]
            public ManufacturedMaterial ManufacturedMaterial { get; set; }
            [XmlAttribute(AttributeName = "classCode")]
            public string ClassCode { get; set; }
            [XmlElement(ElementName = "manufacturerOrganization", Namespace = "urn:hl7-org:v3")]
            public ManufacturerOrganization ManufacturerOrganization { get; set; }
        }

        [XmlRoot(ElementName = "consumable", Namespace = "urn:hl7-org:v3")]
        public class Consumable
        {
            [XmlElement(ElementName = "manufacturedProduct", Namespace = "urn:hl7-org:v3")]
            public ManufacturedProduct ManufacturedProduct { get; set; }
        }

        [XmlRoot(ElementName = "substanceAdministration", Namespace = "urn:hl7-org:v3")]
        public class SubstanceAdministration
        {
            [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
            public List<TemplateId> TemplateId { get; set; }
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "statusCode", Namespace = "urn:hl7-org:v3")]
            public StatusCode StatusCode { get; set; }
            [XmlElement(ElementName = "effectiveTime", Namespace = "urn:hl7-org:v3")]
            public List<EffectiveTime> EffectiveTime { get; set; }
            [XmlElement(ElementName = "routeCode", Namespace = "urn:hl7-org:v3")]
            public RouteCode RouteCode { get; set; }
            [XmlElement(ElementName = "doseQuantity", Namespace = "urn:hl7-org:v3")]
            public DoseQuantity DoseQuantity { get; set; }
            [XmlElement(ElementName = "consumable", Namespace = "urn:hl7-org:v3")]
            public Consumable Consumable { get; set; }
            [XmlAttribute(AttributeName = "classCode")]
            public string ClassCode { get; set; }
            [XmlAttribute(AttributeName = "moodCode")]
            public string MoodCode { get; set; }
            [XmlElement(ElementName = "text", Namespace = "urn:hl7-org:v3")]
            public Text Text { get; set; }
            [XmlAttribute(AttributeName = "negationInd")]
            public string NegationInd { get; set; }
            [XmlElement(ElementName = "entryRelationship", Namespace = "urn:hl7-org:v3")]
            public EntryRelationship EntryRelationship { get; set; }
        }

        [XmlRoot(ElementName = "list", Namespace = "urn:hl7-org:v3")]
        public class List
        {
            [XmlElement(ElementName = "item", Namespace = "urn:hl7-org:v3")]
            public Item Item { get; set; }
        }

        [XmlRoot(ElementName = "item", Namespace = "urn:hl7-org:v3")]
        public class Item
        {
            [XmlElement(ElementName = "list", Namespace = "urn:hl7-org:v3")]
            public List List { get; set; }
        }

        [XmlRoot(ElementName = "translation", Namespace = "urn:hl7-org:v3")]
        public class Translation
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
            [XmlAttribute(AttributeName = "codeSystemName")]
            public string CodeSystemName { get; set; }
            [XmlAttribute(AttributeName = "displayName")]
            public string DisplayName { get; set; }
        }

        [XmlRoot(ElementName = "encounter", Namespace = "urn:hl7-org:v3")]
        public class Encounter
        {
            [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
            public List<TemplateId> TemplateId { get; set; }
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlElement(ElementName = "effectiveTime", Namespace = "urn:hl7-org:v3")]
            public EffectiveTime EffectiveTime { get; set; }
            [XmlElement(ElementName = "performer", Namespace = "urn:hl7-org:v3")]
            public Performer Performer { get; set; }
            [XmlElement(ElementName = "participant", Namespace = "urn:hl7-org:v3")]
            public Participant Participant { get; set; }
            [XmlElement(ElementName = "entryRelationship", Namespace = "urn:hl7-org:v3")]
            public EntryRelationship EntryRelationship { get; set; }
            [XmlAttribute(AttributeName = "classCode")]
            public string ClassCode { get; set; }
            [XmlAttribute(AttributeName = "moodCode")]
            public string MoodCode { get; set; }
            [XmlElement(ElementName = "statusCode", Namespace = "urn:hl7-org:v3")]
            public StatusCode StatusCode { get; set; }
        }

        [XmlRoot(ElementName = "manufacturerOrganization", Namespace = "urn:hl7-org:v3")]
        public class ManufacturerOrganization
        {
            [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
            public string Name { get; set; }
        }

        [XmlRoot(ElementName = "th", Namespace = "urn:hl7-org:v3")]
        public class Th
        {
            [XmlAttribute(AttributeName = "align")]
            public string Align { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "interpretationCode", Namespace = "urn:hl7-org:v3")]
        public class InterpretationCode
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
        }

        [XmlRoot(ElementName = "organizer", Namespace = "urn:hl7-org:v3")]
        public class Organizer
        {
            [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
            public List<TemplateId> TemplateId { get; set; }
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlElement(ElementName = "statusCode", Namespace = "urn:hl7-org:v3")]
            public StatusCode StatusCode { get; set; }
            [XmlElement(ElementName = "effectiveTime", Namespace = "urn:hl7-org:v3")]
            public EffectiveTime EffectiveTime { get; set; }
            [XmlElement(ElementName = "component", Namespace = "urn:hl7-org:v3")]
            public List<Component> Component { get; set; }
            [XmlAttribute(AttributeName = "classCode")]
            public string ClassCode { get; set; }
            [XmlAttribute(AttributeName = "moodCode")]
            public string MoodCode { get; set; }
        }

        [XmlRoot(ElementName = "methodCode", Namespace = "urn:hl7-org:v3")]
        public class MethodCode
        {
            [XmlAttribute(AttributeName = "nullFlavor")]
            public string NullFlavor { get; set; }
        }

        [XmlRoot(ElementName = "targetSiteCode", Namespace = "urn:hl7-org:v3")]
        public class TargetSiteCode
        {
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "displayName")]
            public string DisplayName { get; set; }
            [XmlAttribute(AttributeName = "codeSystem")]
            public string CodeSystem { get; set; }
            [XmlAttribute(AttributeName = "codeSystemName")]
            public string CodeSystemName { get; set; }
        }

        [XmlRoot(ElementName = "procedure", Namespace = "urn:hl7-org:v3")]
        public class Procedure
        {
            [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
            public List<TemplateId> TemplateId { get; set; }
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlElement(ElementName = "statusCode", Namespace = "urn:hl7-org:v3")]
            public StatusCode StatusCode { get; set; }
            [XmlElement(ElementName = "effectiveTime", Namespace = "urn:hl7-org:v3")]
            public EffectiveTime EffectiveTime { get; set; }
            [XmlElement(ElementName = "methodCode", Namespace = "urn:hl7-org:v3")]
            public MethodCode MethodCode { get; set; }
            [XmlElement(ElementName = "targetSiteCode", Namespace = "urn:hl7-org:v3")]
            public TargetSiteCode TargetSiteCode { get; set; }
            [XmlAttribute(AttributeName = "classCode")]
            public string ClassCode { get; set; }
            [XmlAttribute(AttributeName = "moodCode")]
            public string MoodCode { get; set; }
            [XmlElement(ElementName = "participant", Namespace = "urn:hl7-org:v3")]
            public Participant Participant { get; set; }
        }

        [XmlRoot(ElementName = "playingDevice", Namespace = "urn:hl7-org:v3")]
        public class PlayingDevice
        {
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
        }

        [XmlRoot(ElementName = "scopingEntity", Namespace = "urn:hl7-org:v3")]
        public class ScopingEntity
        {
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
        }

        [XmlRoot(ElementName = "observationRange", Namespace = "urn:hl7-org:v3")]
        public class ObservationRange
        {
            [XmlElement(ElementName = "value", Namespace = "urn:hl7-org:v3")]
            public Value Value { get; set; }
        }

        [XmlRoot(ElementName = "referenceRange", Namespace = "urn:hl7-org:v3")]
        public class ReferenceRange
        {
            [XmlElement(ElementName = "observationRange", Namespace = "urn:hl7-org:v3")]
            public ObservationRange ObservationRange { get; set; }
        }

        [XmlRoot(ElementName = "structuredBody", Namespace = "urn:hl7-org:v3")]
        public class StructuredBody
        {
            [XmlElement(ElementName = "component", Namespace = "urn:hl7-org:v3")]
            public List<Component> Component { get; set; }
        }

        [XmlRoot(ElementName = "ClinicalDocument", Namespace = "urn:hl7-org:v3")]
        public class ClinicalDocument
        {
            [XmlElement(ElementName = "realmCode", Namespace = "urn:hl7-org:v3")]
            public RealmCode RealmCode { get; set; }
            [XmlElement(ElementName = "typeId", Namespace = "urn:hl7-org:v3")]
            public TypeId TypeId { get; set; }
            [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
            public List<TemplateId> TemplateId { get; set; }
            [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
            public Code Code { get; set; }
            [XmlElement(ElementName = "title", Namespace = "urn:hl7-org:v3")]
            public string Title { get; set; }
            [XmlElement(ElementName = "effectiveTime", Namespace = "urn:hl7-org:v3")]
            public EffectiveTime EffectiveTime { get; set; }
            [XmlElement(ElementName = "confidentialityCode", Namespace = "urn:hl7-org:v3")]
            public ConfidentialityCode ConfidentialityCode { get; set; }
            [XmlElement(ElementName = "languageCode", Namespace = "urn:hl7-org:v3")]
            public LanguageCode LanguageCode { get; set; }
            [XmlElement(ElementName = "setId", Namespace = "urn:hl7-org:v3")]
            public SetId SetId { get; set; }
            [XmlElement(ElementName = "versionNumber", Namespace = "urn:hl7-org:v3")]
            public VersionNumber VersionNumber { get; set; }
            [XmlElement(ElementName = "recordTarget", Namespace = "urn:hl7-org:v3")]
            public RecordTarget RecordTarget { get; set; }
            [XmlElement(ElementName = "author", Namespace = "urn:hl7-org:v3")]
            public Author Author { get; set; }
            [XmlElement(ElementName = "dataEnterer", Namespace = "urn:hl7-org:v3")]
            public DataEnterer DataEnterer { get; set; }
            [XmlElement(ElementName = "informant", Namespace = "urn:hl7-org:v3")]
            public List<Informant> Informant { get; set; }
            [XmlElement(ElementName = "custodian", Namespace = "urn:hl7-org:v3")]
            public Custodian Custodian { get; set; }
            [XmlElement(ElementName = "informationRecipient", Namespace = "urn:hl7-org:v3")]
            public InformationRecipient InformationRecipient { get; set; }
            [XmlElement(ElementName = "legalAuthenticator", Namespace = "urn:hl7-org:v3")]
            public LegalAuthenticator LegalAuthenticator { get; set; }
            [XmlElement(ElementName = "authenticator", Namespace = "urn:hl7-org:v3")]
            public Authenticator Authenticator { get; set; }
            [XmlElement(ElementName = "participant", Namespace = "urn:hl7-org:v3")]
            public List<Participant> Participant { get; set; }
            [XmlElement(ElementName = "documentationOf", Namespace = "urn:hl7-org:v3")]
            public DocumentationOf DocumentationOf { get; set; }
            [XmlElement(ElementName = "componentOf", Namespace = "urn:hl7-org:v3")]
            public ComponentOf ComponentOf { get; set; }
            [XmlElement(ElementName = "component", Namespace = "urn:hl7-org:v3")]
            public Component Component { get; set; }
            [XmlAttribute(AttributeName = "xmlns")]
            public string Xmlns { get; set; }
            [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xsi { get; set; }
            [XmlAttribute(AttributeName = "voc", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Voc { get; set; }
            [XmlAttribute(AttributeName = "sdtc", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Sdtc { get; set; }
        }

    }
}

