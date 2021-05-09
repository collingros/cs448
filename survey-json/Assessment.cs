using MongoDB.Bson;
using System.Collections.Generic;
using System;


namespace QuickType
{

    public partial class Assessment
    {
        public General General { get; set; }
        public IdentifyingInfo IdentifyingInfo { get; set; }
        public LaCasaParticipation LaCasaParticipation { get; set; }
        public AbuserInfo AbuserInfo { get; set; }
        public ChildrenInfo ChildrenInfo { get; set; }
        public DomesticVSituation DomesticVSituation { get; set; }
        public AbuseInCurrentRelationship AbuseInCurrentRelationship { get; set; }
        public SharedPolicy SharedPolicy { get; set; }
    }

    public partial class AbuseInCurrentRelationship
    {
        public Dictionary<string, long> PhysicalAbuseSec { get; set; }
        public IntimidationSec IntimidationSec { get; set; }
        public EmotionalAbuseSec EmotionalAbuseSec { get; set; }
        public IsolationSec IsolationSec { get; set; }
        public MinimizingSec MinimizingSec { get; set; }
        public UsingChildrenSec UsingChildrenSec { get; set; }
        public SexualAbuseSec SexualAbuseSec { get; set; }
        public GenderPrivSec GenderPrivSec { get; set; }
        public EconomicAbuseSec EconomicAbuseSec { get; set; }
        public CoercionThreatsSec CoercionThreatsSec { get; set; }
        public TraffickingSec TraffickingSec { get; set; }
        public string HowLongCurrentRelationship { get; set; }
        public MaritalStatusSec MaritalStatusSec { get; set; }
        public string DateLastIncident { get; set; }
        public string WhenAbuseStarted { get; set; }
        public string AbuseOccurence { get; set; }
        public AbuseSeveritySec AbuseSeveritySec { get; set; }
        public CalledPoliceSec CalledPoliceSec { get; set; }
        public long HasExperiencedDomesticPast { get; set; }
        public DomvTargetPopSec DomvTargetPopSec { get; set; }
    }

    public partial class AbuseSeveritySec
    {
        public long IsMoreSevere { get; set; }
        public string Desc { get; set; }
    }

    public partial class CalledPoliceSec
    {
        public long HasCalled { get; set; }
        public string NumTimes { get; set; }
    }

    public partial class CoercionThreatsSec
    {
        public long HasThreatenedHarm { get; set; }
        public long HasTriedDropCharges { get; set; }
        public long HasThreatenedFamily { get; set; }
        public long HasMadeIllegal { get; set; }
        public long HasThreatenedChildAway { get; set; }
    }

    public partial class DomvTargetPopSec
    {
        public long IsAdultSurvivor { get; set; }
        public long IsChildSurvivor { get; set; }
        public long IsImmigrant { get; set; }
        public long IsElderly { get; set; }
        public long IsPhysicallyChallenged { get; set; }
        public long IsGay { get; set; }
        public long IsLesbian { get; set; }
        public long IsBisexual { get; set; }
        public long IsTransgender { get; set; }
        public long IsOther { get; set; }
    }

    public partial class EconomicAbuseSec
    {
        public long HasPreventedWorkingOut { get; set; }
        public long HasMadeBeg { get; set; }
        public long HasWithheldInfoFamilyInc { get; set; }
        public long HasStolen { get; set; }
        public long HasRuinedCredit { get; set; }
        public long HasPreventedWork { get; set; }
        public long HasRefusedToSupport { get; set; }
        public long HasKeptCheckbook { get; set; }
        public long HasMajorFinancial { get; set; }
        public long HasNotPaidChildSupport { get; set; }
    }

    public partial class EmotionalAbuseSec
    {
        public long HasBelittled { get; set; }
        public long HasGuilty { get; set; }
        public long HasAccusedCheating { get; set; }
        public long HasInsultedParent { get; set; }
        public long HasCalledNames { get; set; }
        public long HasHumiliated { get; set; }
        public long HasInterruptedSleepEat { get; set; }
        public long HasThreatenedPet { get; set; }
    }

    public partial class GenderPrivSec
    {
        public long HasTreatedServant { get; set; }
        public long HasActedMaster { get; set; }
        public long HasToldRole { get; set; }
        public long HasNotDoneFairHousework { get; set; }
        public long HasNotSharedChildcare { get; set; }
        public long HasBossed { get; set; }
        public long HasMadeRulesNoinput { get; set; }
        public long HasExpectedSexual { get; set; }
        public long HasThreatenedLgbtq { get; set; }
    }

    public partial class IntimidationSec
    {
        public long HasFrightened { get; set; }
        public long HasScreamed { get; set; }
        public long HasSmashed { get; set; }
        public long HasPunchedWalls { get; set; }
        public long HasDestroyed { get; set; }
        public long HasDisplayedWeapons { get; set; }
        public long HasThreatenedSuicide { get; set; }
        public long HasStalked { get; set; }
    }

    public partial class IsolationSec
    {
        public long HasKeptFromGoing { get; set; }
        public long HasOpenedMail { get; set; }
        public long HasListenedPhone { get; set; }
        public long HasFollowed { get; set; }
        public long HasQuestioned { get; set; }
        public long HasMonitoredMedia { get; set; }
        public long HasHackedEmail { get; set; }
        public long HasUsedGpsTrack { get; set; }
        public long HasMonitoredText { get; set; }
        public long HasTakenPhone { get; set; }
    }

    public partial class MaritalStatusSec
    {
        public long IsMarried { get; set; }
        public long IsSeparated { get; set; }
        public long IsDivorced { get; set; }
        public long IsSingle { get; set; }
        public long IsLivingTogether { get; set; }
    }

    public partial class MinimizingSec
    {
        public long HasMadeLight { get; set; }
        public long HasBlamedYou { get; set; }
        public long HasDenial { get; set; }
        public long HasBlamedElse { get; set; }
    }

    public partial class SexualAbuseSec
    {
        public long HasUnwantedTouching { get; set; }
        public long HasRaped { get; set; }
        public long HasDemanded { get; set; }
        public long HasForcedOthers { get; set; }
        public long HasInsistedSexual { get; set; }
        public long HasRefusedSafe { get; set; }
        public long HasPreventedBc { get; set; }
        public long HasWithheld { get; set; }
        public long HasVideotaped { get; set; }
    }

    public partial class TraffickingSec
    {
        public long HasForcedSexForMoney { get; set; }
        public long HasBeenCoercedWorkMoney { get; set; }
    }

    public partial class UsingChildrenSec
    {
        public long HasToldChildrenParent { get; set; }
        public long HasThreatenedTakeaway { get; set; }
        public long HasUsedChildrenMessages { get; set; }
        public long HasVisitationHarassment { get; set; }
        public long HasToldChildrenNorules { get; set; }
        public long HasThreatenedCps { get; set; }
        public long HasHurtInfrontChild { get; set; }
        public long HasSexualInfrontChild { get; set; }
        public long HasChildrenAttempt { get; set; }
        public long HasChildrenHurt { get; set; }
    }

    public partial class AbuserInfo
    {
        public string Name { get; set; }
        public string Relationship { get; set; }
        public LaCasaClientSec LaCasaClientSec { get; set; }
        public BattererInterventionSec BattererInterventionSec { get; set; }
    }

    public partial class BattererInterventionSec
    {
        public string HasAttended { get; set; }
        public string ProgramLocDate { get; set; }
    }

    public partial class LaCasaClientSec
    {
        public string IsCurrentClient { get; set; }
        public string Program { get; set; }
        public string IsPastClient { get; set; }
    }

    public partial class ChildrenInfo
    {
        public long HasChildren { get; set; }
        public long FamilySize { get; set; }
        public long IsPregnant { get; set; }
        public TeenDatingSec TeenDatingSec { get; set; }
        public ChildSec Child1_Sec { get; set; }
        public ChildSec Child2_Sec { get; set; }
        public ChildSec Child3_Sec { get; set; }
        public ChildSec Child4_Sec { get; set; }
        public ChildSec Child5_Sec { get; set; }
        public ChildSec Child6_Sec { get; set; }
    }

    public partial class ChildSec
    {
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string DateOfBirth { get; set; }
        public long Age { get; set; }
        public string Gender { get; set; }
        public long IsChildWitness { get; set; }
        public EthnicitySec EthnicitySec { get; set; }
        public RaceSec RaceSec { get; set; }
        public RelationshipSec RelationshipSec { get; set; }
        public long WillBeSheltered { get; set; }
        public long WontBeSheltered { get; set; }
    }

    public partial class EthnicitySec
    {
        public long IsHispanic { get; set; }
        public long IsNonHispanic { get; set; }
        public long IsUnknown { get; set; }
        public long IsRefused { get; set; }
    }

    public partial class RaceSec
    {
        public long IsAmericanIndianAlaskaNative { get; set; }
        public long IsAsian { get; set; }
        public long IsBlackAfricanAmerican { get; set; }
        public long IsNativeHawaiianPacificIslander { get; set; }
        public long IsWhite { get; set; }
        public RaceSecIsOtherSec IsOtherSec { get; set; }
        public long IsMultiRacial { get; set; }
        public long IsRefused { get; set; }
    }

    public partial class RaceSecIsOtherSec
    {
        public long IsOther { get; set; }
        public string Other { get; set; }
    }

    public partial class RelationshipSec
    {
        public long IsSon { get; set; }
        public long IsDaughter { get; set; }
        public long IsGranddaughter { get; set; }
        public long IsGrandson { get; set; }
        public long IsBrother { get; set; }
        public long IsSister { get; set; }
        public long IsStepdaughter { get; set; }
        public long IsStepson { get; set; }
        public RelationshipSecIsOtherSec IsOtherSec { get; set; }
    }

    public partial class RelationshipSecIsOtherSec
    {
        public long IsOther { get; set; }
        public string Explain { get; set; }
    }

    public partial class TeenDatingSec
    {
        public long IsTeenDatingViolence { get; set; }
        public string Explain { get; set; }
    }

    public partial class DomesticVSituation
    {
        public string Description { get; set; }
        public long IsSeekingShelter { get; set; }
        public long IsHomelessFleeing { get; set; }
        public long IsSeekingDomvInfo { get; set; }
        public long IsSeekingOop { get; set; }
        public long IsSeekingImmigrationInfo { get; set; }
        public string SeekingOtherDesc { get; set; }
    }

    public partial class General
    {
        public string Date { get; set; }
        public string Staff { get; set; }
        public string StartT { get; set; }
        public string EndT { get; set; }
        public Dictionary<string, long> ReferredBySec { get; set; }
    }

    public partial class IdentifyingInfo
    {
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public long SafePhone { get; set; }
        public string DateOfBirth { get; set; }
        public long Age { get; set; }
        public string Gender { get; set; }
        public LanguageSpokenSec LanguageSpokenSec { get; set; }
        public EthnicitySec EthnicitySec { get; set; }
        public RaceSec RaceSec { get; set; }
        public SexualOrientSec SexualOrientSec { get; set; }
    }

    public partial class LanguageSpokenSec
    {
        public long IsEnglish { get; set; }
        public string Other { get; set; }
    }

    public partial class SexualOrientSec
    {
        public long IsHetero { get; set; }
        public long IsLesbian { get; set; }
        public long IsGay { get; set; }
        public long IsBisexual { get; set; }
        public long IsTrans { get; set; }
        public long IsQueer { get; set; }
        public long IsOther { get; set; }
        public long IsRefused { get; set; }
    }

    public partial class LaCasaParticipation
    {
        public IsClientSec IsCurrClientSec { get; set; }
        public IsClientSec IsPastClientSec { get; set; }
        public string DateLastSvc { get; set; }
        public long IsVet { get; set; }
        public long IsEnrolledVocationalEduc { get; set; }
        public string HighestEducLvl { get; set; }
        public EmploymentStatusSec EmploymentStatusSec { get; set; }
        public long IsRecvTanf { get; set; }
        public long IsMedicaid { get; set; }
        public Dictionary<string, long> FamilyIncomeSec { get; set; }
        public long Income { get; set; }
        public long IsColor { get; set; }
        public long IsCyfdInvolvement { get; set; }
        public long IsCyfdJuvenileJustice { get; set; }
        public string Disabilities { get; set; }
        public string FoodAllergies { get; set; }
        public LivingStatusSec LivingStatusSec { get; set; }
    }

    public partial class EmploymentStatusSec
    {
        public long IsEmployed { get; set; }
        public long IsUnemployed { get; set; }
        public long IsActivelySeeking { get; set; }
        public long IsRetired { get; set; }
    }

    public partial class IsClientSec
    {
        public long IsClient { get; set; }
        public string Program { get; set; }
        public TypeSec TypeSec { get; set; }
    }

    public partial class TypeSec
    {
        public long IsShelter { get; set; }
        public long IsNonRes { get; set; }
        public long IsBip { get; set; }
        public long IsLegal { get; set; }
        public long IsImmigration { get; set; }
        public long IsCyp { get; set; }
        public long IsSouthValley { get; set; }
        public long IsHousing { get; set; }
    }

    public partial class LivingStatusSec
    {
        public long IsWithPerpetratorPrev { get; set; }
        public long IsHome { get; set; }
        public long IsWithFriend { get; set; }
        public long IsTransitional { get; set; }
        public long IsShelter { get; set; }
        public long IsHomeless { get; set; }
        public long IsJail { get; set; }
        public long IsUnknown { get; set; }
    }

    public partial class SharedPolicy
    {
        public long IsShared { get; set; }
        public long NotReceiving { get; set; }
    }
}
