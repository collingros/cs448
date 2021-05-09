using MongoDB.Bson;


namespace PDFGen
{

    public partial class Assessment
    {
        [BsonElement("ReferredBy")]
        public ReferredBy ReferredBy { get; set; }

        [BsonElement("IdentifyingInformation")]
        public IdentifyingInformation IdentifyingInformation { get; set; }

        [BsonElement("LaCasaIncParticipation")]
        public LaCasaIncParticipation LaCasaIncParticipation { get; set; }

        [BsonElement("AbuserSInformation")]
        public AbuserSInformation AbuserSInformation { get; set; }

        [BsonElement("ChildrenSInformation")]
        public ChildrenSInformation ChildrenSInformation { get; set; }

        [BsonElement("DescribeDomesticViolenceSituation")]
        public DescribeDomesticViolenceSituation DescribeDomesticViolenceSituation { get; set; }

        [BsonElement("AbuseInYourCurrentRelationship")]
        public AbuseInYourCurrentRelationship AbuseInYourCurrentRelationship { get; set; }

    }

    public partial class AbuseInYourCurrentRelationship
    {
        [BsonElement("PhysicalAbuse")]
        public PhysicalAbuse PhysicalAbuse { get; set; }

        [BsonElement("Intimidation")]
        public Intimidation Intimidation { get; set; }

        [BsonElement("EmotionalAbuse")]
        public EmotionalAbuse EmotionalAbuse { get; set; }

        [BsonElement("Isolation")]
        public Isolation Isolation { get; set; }

        [BsonElement("MinimizingDenyingAndBlaming")]
        public MinimizingDenyingAndBlaming MinimizingDenyingAndBlaming { get; set; }

        [BsonElement("UsingChildren")]
        public UsingChildren UsingChildren { get; set; }

        [BsonElement("SexualAbuse")]
        public SexualAbuse SexualAbuse { get; set; }

        [BsonElement("GenderBasedPrivilege")]
        public GenderBasedPrivilege GenderBasedPrivilege { get; set; }

        [BsonElement("EconomicAbuse")]
        public EconomicAbuse EconomicAbuse { get; set; }

        [BsonElement("CoercionAndThreats")]
        public CoercionAndThreats CoercionAndThreats { get; set; }

        [BsonElement("TraffickingFromThePartnerOrAnyoneElse")]
        public TraffickingFromThePartnerOrAnyoneElse TraffickingFromThePartnerOrAnyoneElse { get; set; }

        [BsonElement("HowLongHaveYouBeenInYourCurrentRelationship")]
        public string HowLongHaveYouBeenInYourCurrentRelationship { get; set; }

        [BsonElement("MaritalStatus")]
        public MaritalStatus MaritalStatus { get; set; }

        [BsonElement("DateOfLastIncident")]
        public string DateOfLastIncident { get; set; }

        [BsonElement("WhenDidTheAbuseStart")]
        public string WhenDidTheAbuseStart { get; set; }

        [BsonElement("HowOftenDoesTheAbuseOccur")]
        public string HowOftenDoesTheAbuseOccur { get; set; }

        [BsonElement("HasTheAbuseBecomeMoreSevereOrFrequentInTheLastSizMonths")]
        public HasTheAbuseBecomeMoreSevereOrFrequentInTheLastSizMonths HasTheAbuseBecomeMoreSevereOrFrequentInTheLastSizMonths { get; set; }

        [BsonElement("IfYesPleaseDescribe")]
        public string IfYesPleaseDescribe { get; set; }

        [BsonElement("HasYouOrAnyoneElseCalledThePolice")]
        public HasTheAbuseBecomeMoreSevereOrFrequentInTheLastSizMonths HasYouOrAnyoneElseCalledThePolice { get; set; }

        [BsonElement("IfYesHowManyTimes")]
        public string IfYesHowManyTimes { get; set; }

        [BsonElement("HaveYouExpereincedDomesticViolenceInPastRelationships")]
        public HaveYouExpereincedDomesticViolenceInPastRelationships HaveYouExpereincedDomesticViolenceInPastRelationships { get; set; }

        [BsonElement("DomesticViolenceTargetPopulation")]
        public DomesticViolenceTargetPopulation DomesticViolenceTargetPopulation { get; set; }

        [BsonElement("DomesticViolenceTargetPopulationCharacteristicsChooseOnOrMoreIfApplicable")]
        public DomesticViolenceTargetPopulationCharacteristicsChooseOnOrMoreIfApplicable DomesticViolenceTargetPopulationCharacteristicsChooseOnOrMoreIfApplicable { get; set; }

        [BsonElement("NonDescriminationPolicy")]
        public NonDescriminationPolicy NonDescriminationPolicy { get; set; }

    }

    public partial class CoercionAndThreats
    {
        [BsonElement("ThreatenedToHarmYou")]
        public string ThreatenedToHarmYou { get; set; }

        [BsonElement("TriedToGetYouToDropCharges")]
        public string TriedToGetYouToDropCharges { get; set; }

        [BsonElement("ThreatenedToHarmFamilyOrFriends")]
        public string ThreatenedToHarmFamilyOrFriends { get; set; }

        [BsonElement("MadeYouDoSomethingIllegal")]
        public string MadeYouDoSomethingIllegal { get; set; }

        [BsonElement("ThreatenedToTakeChildrenAway")]
        public string ThreatenedToTakeChildrenAway { get; set; }

    }

    public partial class DomesticViolenceTargetPopulation
    {
        [BsonElement("AdultSurvivor")]
        public string AdultSurvivor { get; set; }

        [BsonElement("ChildSurvivorWitness")]
        public string ChildSurvivorWitness { get; set; }

    }

    public partial class DomesticViolenceTargetPopulationCharacteristicsChooseOnOrMoreIfApplicable
    {
        [BsonElement("Immigrant")]
        public string Immigrant { get; set; }

        [BsonElement("Elderly")]
        public string Elderly { get; set; }

        [BsonElement("PhysicallyChallenged")]
        public string PhysicallyChallenged { get; set; }

        [BsonElement("Gay")]
        public string Gay { get; set; }

        [BsonElement("Lesbian")]
        public string Lesbian { get; set; }

        [BsonElement("Bisexual")]
        public string Bisexual { get; set; }

        [BsonElement("Transgender")]
        public string Transgender { get; set; }

        [BsonElement("Other")]
        public string Other { get; set; }

    }

    public partial class EconomicAbuse
    {
        [BsonElement("PreventedYouFromWorkingOutsideHome")]
        public string PreventedYouFromWorkingOutsideHome { get; set; }

        [BsonElement("MadeYouAskOrBegForMoney")]
        public string MadeYouAskOrBegForMoney { get; set; }

        [BsonElement("WitheldInfoAboutFamilyIncomeHowMuchMoneyHeMakes")]
        public string WitheldInfoAboutFamilyIncomeHowMuchMoneyHeMakes { get; set; }

        [BsonElement("StealingYouTakingYourMoney")]
        public string StealingYouTakingYourMoney { get; set; }

        [BsonElement("RuinedYourCreditOrForbadeFromGettingCredit")]
        public string RuinedYourCreditOrForbadeFromGettingCredit { get; set; }

        [BsonElement("PreventsYouFromWorking")]
        public string PreventsYouFromWorking { get; set; }

        [BsonElement("RefusesToHelpWorkToSupportTheFamily")]
        public string RefusesToHelpWorkToSupportTheFamily { get; set; }

        [BsonElement("KeepsTheCheckbookFromYou")]
        public string KeepsTheCheckbookFromYou { get; set; }

        [BsonElement("MadeFinancialDecisionsWithoutConsultingYou")]
        public string MadeFinancialDecisionsWithoutConsultingYou { get; set; }

        [BsonElement("DoesNotPayChildSupport")]
        public string DoesNotPayChildSupport { get; set; }

    }

    public partial class EmotionalAbuse
    {
        [BsonElement("BelittlesYou")]
        public string BelittlesYou { get; set; }

        [BsonElement("MadeYouFellGuilty")]
        public string MadeYouFellGuilty { get; set; }

        [BsonElement("AccusedYouOfFlirtingOrCheatingOnHimHer")]
        public string AccusedYouOfFlirtingOrCheatingOnHimHer { get; set; }

        [BsonElement("ToldYouThatYouAreABadParentOrIrresponsibleParent")]
        public string ToldYouThatYouAreABadParentOrIrresponsibleParent { get; set; }

        [BsonElement("CalledYouNames")]
        public string CalledYouNames { get; set; }

        [BsonElement("HumiliatedYou")]
        public string HumiliatedYou { get; set; }

        [BsonElement("InterruptedYourSleepingOrEating")]
        public string InterruptedYourSleepingOrEating { get; set; }

        [BsonElement("ThreatenedOrHarmedAPet")]
        public string ThreatenedOrHarmedAPet { get; set; }

    }

    public partial class GenderBasedPrivilege
    {
        [BsonElement("TreatedYouLikeAServant")]
        public string TreatedYouLikeAServant { get; set; }

        [BsonElement("ActedLikeMasterOfTheCastle")]
        public string ActedLikeMasterOfTheCastle { get; set; }

        [BsonElement("ToldYouThatYourRoleJobWas")]
        public string ToldYouThatYourRoleJobWas { get; set; }

        [BsonElement("NotDoneFariShareOfHousework")]
        public string NotDoneFariShareOfHousework { get; set; }

        [BsonElement("NotSharedInChildcare")]
        public string NotSharedInChildcare { get; set; }

        [BsonElement("BossedYouAround")]
        public string BossedYouAround { get; set; }

        [BsonElement("MadeHouseRulesWihtoutYourInput")]
        public string MadeHouseRulesWihtoutYourInput { get; set; }

        [BsonElement("ExpectedYouToBeSexualWheneverHeWants")]
        public string ExpectedYouToBeSexualWheneverHeWants { get; set; }

        [BsonElement("ThretenedToOutYouAsLgbtq")]
        public string ThretenedToOutYouAsLgbtq { get; set; }

    }

    public partial class HasTheAbuseBecomeMoreSevereOrFrequentInTheLastSizMonths
    {
        [BsonElement("Yes")]
        public string Yes { get; set; }

        [BsonElement("No")]
        public string No { get; set; }

    }

    public partial class HaveYouExpereincedDomesticViolenceInPastRelationships
    {
        [BsonElement("Yes26")]
        public string Yes26 { get; set; }

        [BsonElement("No28")]
        public string No28 { get; set; }

    }

    public partial class Intimidation
    {
        [BsonElement("FreightenedYouByCertainLooksGesturesOrActions")]
        public string FreightenedYouByCertainLooksGesturesOrActions { get; set; }

        [BsonElement("ScreamedAtYou")]
        public string ScreamedAtYou { get; set; }

        [BsonElement("SmashedThings")]
        public string SmashedThings { get; set; }

        [BsonElement("PunchedWalls")]
        public string PunchedWalls { get; set; }

        [BsonElement("DestroyedYourProperty")]
        public string DestroyedYourProperty { get; set; }

        [BsonElement("DisplayedWeapons")]
        public string DisplayedWeapons { get; set; }

        [BsonElement("HasThreatenedToCommitSuicide")]
        public string HasThreatenedToCommitSuicide { get; set; }

        [BsonElement("StalkedYou")]
        public string StalkedYou { get; set; }

    }

    public partial class Isolation
    {
        [BsonElement("KeptYouFromGoingPlacesYouChooseWorkSchoolSeeingFamilyOrFriends")]
        public string KeptYouFromGoingPlacesYouChooseWorkSchoolSeeingFamilyOrFriends { get; set; }

        [BsonElement("OpenedYourMail")]
        public string OpenedYourMail { get; set; }

        [BsonElement("ListedToYourPhoneConversations")]
        public string ListedToYourPhoneConversations { get; set; }

        [BsonElement("FollowedYouAround")]
        public string FollowedYouAround { get; set; }

        [BsonElement("QuestionedYourWhereabouts")]
        public string QuestionedYourWhereabouts { get; set; }

        [BsonElement("MonitorsSocialMedia")]
        public string MonitorsSocialMedia { get; set; }

        [BsonElement("HacksIntoYourEmail")]
        public string HacksIntoYourEmail { get; set; }

        [BsonElement("UsesGpsToTrackYourLocation")]
        public string UsesGpsToTrackYourLocation { get; set; }

        [BsonElement("MonitorsTextMessages")]
        public string MonitorsTextMessages { get; set; }

        [BsonElement("TakesYourPhoneWithoutPermission")]
        public string TakesYourPhoneWithoutPermission { get; set; }

    }

    public partial class MaritalStatus
    {
        [BsonElement("Married")]
        public string Married { get; set; }

        [BsonElement("Sperated")]
        public string Sperated { get; set; }

        [BsonElement("Divorced")]
        public string Divorced { get; set; }

        [BsonElement("Single")]
        public string Single { get; set; }

        [BsonElement("LivingTogether")]
        public string LivingTogether { get; set; }

    }

    public partial class MinimizingDenyingAndBlaming
    {
        [BsonElement("MadeLightOfTheAbuse")]
        public string MadeLightOfTheAbuse { get; set; }

        [BsonElement("SaidTheAbuseWasYourFault")]
        public string SaidTheAbuseWasYourFault { get; set; }

        [BsonElement("SaidTheAbuseDidntHappen")]
        public string SaidTheAbuseDidntHappen { get; set; }

        [BsonElement("BlamedSomeoneOrSomethingElseForTheAbuse")]
        public string BlamedSomeoneOrSomethingElseForTheAbuse { get; set; }

    }

    public partial class NonDescriminationPolicy
    {
        [BsonElement("PolicyShared")]
        public string PolicyShared { get; set; }

        [BsonElement("NotReceivingLaCasaServices")]
        public string NotReceivingLaCasaServices { get; set; }

    }

    public partial class PhysicalAbuse
    {
        [BsonElement("Slapped")]
        public string Slapped { get; set; }

        [BsonElement("Kicked")]
        public string Kicked { get; set; }

        [BsonElement("Strangled")]
        public string Strangled { get; set; }

        [BsonElement("Punched")]
        public string Punched { get; set; }

        [BsonElement("PushedShovedYou")]
        public string PushedShovedYou { get; set; }

        [BsonElement("TornYourClothes")]
        public string TornYourClothes { get; set; }

        [BsonElement("GrabbedYouAroundYourNeck")]
        public string GrabbedYouAroundYourNeck { get; set; }

        [BsonElement("ThrownSomethingAtYou")]
        public string ThrownSomethingAtYou { get; set; }

        [BsonElement("SpitAtYouOrPulledYourHair")]
        public string SpitAtYouOrPulledYourHair { get; set; }

        [BsonElement("HarmedYouWhilePregnant")]
        public string HarmedYouWhilePregnant { get; set; }

        [BsonElement("RestrainedYou")]
        public string RestrainedYou { get; set; }

    }

    public partial class SexualAbuse
    {
        [BsonElement("UnwantedTouching")]
        public string UnwantedTouching { get; set; }

        [BsonElement("RapedYouOrForcedYouToHaveSex")]
        public string RapedYouOrForcedYouToHaveSex { get; set; }

        [BsonElement("DemandedSex")]
        public string DemandedSex { get; set; }

        [BsonElement("InsitedOnAnythingSexualThatHurtsOrScaresYou")]
        public string InsitedOnAnythingSexualThatHurtsOrScaresYou { get; set; }

        [BsonElement("RefusedSafeSexPractices")]
        public string RefusedSafeSexPractices { get; set; }

        [BsonElement("PreventedYouFromUsingBirthControl")]
        public string PreventedYouFromUsingBirthControl { get; set; }

        [BsonElement("WitheldSexAsAFormOfControl")]
        public string WitheldSexAsAFormOfControl { get; set; }

        [BsonElement("VideotapedSexualActsWithoutPermission")]
        public string VideotapedSexualActsWithoutPermission { get; set; }

    }

    public partial class TraffickingFromThePartnerOrAnyoneElse
    {
        [BsonElement("HaveYouBeenForcesToHaveSexOfAnyKindForMoney")]
        public HasTheAbuseBecomeMoreSevereOrFrequentInTheLastSizMonths HaveYouBeenForcesToHaveSexOfAnyKindForMoney { get; set; }

        [BsonElement("AnotherPersonHasForcedOrCoercedMeToWorkForLittleOrNoMoney")]
        public HasTheAbuseBecomeMoreSevereOrFrequentInTheLastSizMonths AnotherPersonHasForcedOrCoercedMeToWorkForLittleOrNoMoney { get; set; }

    }

    public partial class UsingChildren
    {
        [BsonElement("ToldYourChildrenThatYouAreNotAGoodParent")]
        public string ToldYourChildrenThatYouAreNotAGoodParent { get; set; }

        [BsonElement("ThreatenedToTakeAwayChildren")]
        public string ThreatenedToTakeAwayChildren { get; set; }

        [BsonElement("UsedChildrenToDeliverMessages")]
        public string UsedChildrenToDeliverMessages { get; set; }

        [BsonElement("UsedVisitationToHarassYou")]
        public string UsedVisitationToHarassYou { get; set; }

        [BsonElement("ToldChildrenThatTheyDidNotHaveToFollowMotherSRules")]
        public string ToldChildrenThatTheyDidNotHaveToFollowMotherSRules { get; set; }

        [BsonElement("ThreatenedToCallCps")]
        public string ThreatenedToCallCps { get; set; }

        [BsonElement("HurtYouInFronOfChildren")]
        public string HurtYouInFronOfChildren { get; set; }

        [BsonElement("AttemptedToBeSexualWithYouInFrontOfChildren")]
        public string AttemptedToBeSexualWithYouInFrontOfChildren { get; set; }

        [BsonElement("YourChildrenHaveTriedToStopViolence1")]
        public string YourChildrenHaveTriedToStopViolence1 { get; set; }

        [BsonElement("YourChildrenHaveTriedToStopViolence2")]
        public string YourChildrenHaveTriedToStopViolence2 { get; set; }

        [BsonElement("YourChildrenHaveBeenHurtDueToAbuse")]
        public string YourChildrenHaveBeenHurtDueToAbuse { get; set; }

    }

    public partial class AbuserSInformation
    {
        [BsonElement("AbuserSName")]
        public string AbuserSName { get; set; }

        [BsonElement("RelationshipToAbuser")]
        public string RelationshipToAbuser { get; set; }

        [BsonElement("IsYourPartnerAbuseACurrentClientOfLaCasaInc")]
        public IsYourPartnerAbuseACurrentClientOfLaCasaInc IsYourPartnerAbuseACurrentClientOfLaCasaInc { get; set; }

        [BsonElement("HasYouPartnerAbsuerAPastClientOfLaCasaInc")]
        public HasYouPartnerAbsuerAPastClientOfLaCasaInc HasYouPartnerAbsuerAPastClientOfLaCasaInc { get; set; }

        [BsonElement("IfYesWhatProgram")]
        public IfYesWhatProgram IfYesWhatProgram { get; set; }

        [BsonElement("HasYourCurrentPartnerEverAttendedABattererSInterventionProgram")]
        public HasYourCurrentPartnerEverAttendedABattererSInterventionProgram HasYourCurrentPartnerEverAttendedABattererSInterventionProgram { get; set; }

    }

    public partial class HasYouPartnerAbsuerAPastClientOfLaCasaInc
    {
        [BsonElement("Yes12")]
        public string Yes12 { get; set; }

        [BsonElement("No13")]
        public string No13 { get; set; }

        [BsonElement("Unknown3")]
        public string Unknown3 { get; set; }

    }

    public partial class HasYourCurrentPartnerEverAttendedABattererSInterventionProgram
    {
        [BsonElement("Yes")]
        public string Yes { get; set; }

        [BsonElement("No")]
        public string No { get; set; }

        [BsonElement("Unknown")]
        public string Unknown { get; set; }

        [BsonElement("IfYesWhereAndWhen")]
        public IfYesWhereAndWhen IfYesWhereAndWhen { get; set; }

    }

    public partial class IfYesWhereAndWhen
    {
        [BsonElement("EnterText0")]
        public string EnterText0 { get; set; }

    }

    public partial class IfYesWhatProgram
    {
        [BsonElement("Shelter")]
        public string Shelter { get; set; }

        [BsonElement("NonRes")]
        public string NonRes { get; set; }

        [BsonElement("Bip")]
        public string Bip { get; set; }

        [BsonElement("Legal")]
        public string Legal { get; set; }

        [BsonElement("Immigration")]
        public string Immigration { get; set; }

    }

    public partial class IsYourPartnerAbuseACurrentClientOfLaCasaInc
    {
        [BsonElement("Yes13")]
        public string Yes13 { get; set; }

        [BsonElement("No14")]
        public string No14 { get; set; }

        [BsonElement("Unknown2")]
        public string Unknown2 { get; set; }

    }

    public partial class ChildrenSInformation
    {
        [BsonElement("DoYouHaveAnyChildren")]
        public DoYouHaveAnyChildren DoYouHaveAnyChildren { get; set; }

        [BsonElement("FamilySize")]
        public string FamilySize { get; set; }

        [BsonElement("NumberOfChildren")]
        public string NumberOfChildren { get; set; }

        [BsonElement("AreThereAnyIncidentsOfTeedDatingViolence")]
        public AreThereAnyIncidentsOfTeedDatingViolence AreThereAnyIncidentsOfTeedDatingViolence { get; set; }

        [BsonElement("Child1")]
        public Child1 Child1 { get; set; }

    }

    public partial class AreThereAnyIncidentsOfTeedDatingViolence
    {
        [BsonElement("Yes")]
        public string Yes { get; set; }

        [BsonElement("No")]
        public string No { get; set; }

        [BsonElement("IfYesPleaseExplain")]
        public string IfYesPleaseExplain { get; set; }

    }

    public partial class Child1
    {
        [BsonElement("FirstName")]
        public string FirstName { get; set; }

        [BsonElement("Middle")]
        public string Middle { get; set; }

        [BsonElement("LastName")]
        public string LastName { get; set; }

        [BsonElement("DateOfBirth")]
        public DateOfBirth DateOfBirth { get; set; }

        [BsonElement("Age")]
        public string Age { get; set; }

        [BsonElement("Gender")]
        public string Gender { get; set; }

        [BsonElement("TheChildWillBeInTheShelter")]
        public DoYouHaveAnyFoodAllergies TheChildWillBeInTheShelter { get; set; }

        [BsonElement("Custody")]
        public Custody Custody { get; set; }

        [BsonElement("Ethnicity")]
        public Child1_Ethnicity Ethnicity { get; set; }

        [BsonElement("Race")]
        public Child1_Race Race { get; set; }

        [BsonElement("RelationshipToVictim")]
        public RelationshipToVictim RelationshipToVictim { get; set; }

    }

    public partial class Custody
    {
        [BsonElement("PartTime")]
        public string PartTime { get; set; }

        [BsonElement("FullTime")]
        public string FullTime { get; set; }

        [BsonElement("NotInMyCustody")]
        public string NotInMyCustody { get; set; }

        [BsonElement("NoAgreement")]
        public string NoAgreement { get; set; }

    }

    public partial class DateOfBirth
    {
        [BsonElement("Month")]
        public string Month { get; set; }

        [BsonElement("Day")]
        public string Day { get; set; }

        [BsonElement("Year")]
        public string Year { get; set; }

    }

    public partial class Child1_Ethnicity
    {
        [BsonElement("Hispanic2")]
        public string Hispanic2 { get; set; }

        [BsonElement("NonHispanic")]
        public string NonHispanic { get; set; }

        [BsonElement("DontKnow")]
        public string DontKnow { get; set; }

        [BsonElement("Refused3")]
        public string Refused3 { get; set; }

    }

    public partial class Child1_Race
    {
        [BsonElement("AmericanIndianAlaskaNative")]
        public string AmericanIndianAlaskaNative { get; set; }

        [BsonElement("Asian")]
        public string Asian { get; set; }

        [BsonElement("AfricanAmerican")]
        public string AfricanAmerican { get; set; }

        [BsonElement("NativeHawaiianOrPacificIslander")]
        public string NativeHawaiianOrPacificIslander { get; set; }

        [BsonElement("White")]
        public string White { get; set; }

        [BsonElement("Multiracial")]
        public string Multiracial { get; set; }

        [BsonElement("Other")]
        public string Other { get; set; }

        [BsonElement("Other2")]
        public string Other2 { get; set; }

        [BsonElement("Refused")]
        public string Refused { get; set; }

    }

    public partial class RelationshipToVictim
    {
        [BsonElement("Son")]
        public string Son { get; set; }

        [BsonElement("Daughter")]
        public string Daughter { get; set; }

        [BsonElement("Granddaughter")]
        public string Granddaughter { get; set; }

        [BsonElement("Grandson")]
        public string Grandson { get; set; }

        [BsonElement("Brother")]
        public string Brother { get; set; }

        [BsonElement("Sister")]
        public string Sister { get; set; }

        [BsonElement("Stepdaughter")]
        public string Stepdaughter { get; set; }

        [BsonElement("Stepson")]
        public string Stepson { get; set; }

        [BsonElement("Other")]
        public string Other { get; set; }

        [BsonElement("Explain")]
        public string Explain { get; set; }

    }

    public partial class DoYouHaveAnyFoodAllergies
    {
        [BsonElement("Yes")]
        public string Yes { get; set; }

        [BsonElement("No")]
        public string No { get; set; }

    }

    public partial class DoYouHaveAnyChildren
    {
        [BsonElement("Yes15")]
        public string Yes15 { get; set; }

        [BsonElement("No16")]
        public string No16 { get; set; }

    }

    public partial class DescribeDomesticViolenceSituation
    {
        [BsonElement("HowCanWeHelpYouCanYouTellUsWhatBroghtYouHereToday")]
        public string HowCanWeHelpYouCanYouTellUsWhatBroghtYouHereToday { get; set; }

        [BsonElement("AreYouSeekingShelter")]
        public HasTheAbuseBecomeMoreSevereOrFrequentInTheLastSizMonths AreYouSeekingShelter { get; set; }

        [BsonElement("AreYouHomelessBecauseYouAreFleeingDomesticViolence")]
        public HasTheAbuseBecomeMoreSevereOrFrequentInTheLastSizMonths AreYouHomelessBecauseYouAreFleeingDomesticViolence { get; set; }

        [BsonElement("AreYouSeekingInformationAndEducationOnDomesticViolence")]
        public HasTheAbuseBecomeMoreSevereOrFrequentInTheLastSizMonths AreYouSeekingInformationAndEducationOnDomesticViolence { get; set; }

        [BsonElement("AreYouSeekingAnOrderOfProtection")]
        public HasTheAbuseBecomeMoreSevereOrFrequentInTheLastSizMonths AreYouSeekingAnOrderOfProtection { get; set; }

        [BsonElement("AreYouSeekingInformationRegardingImmigrationStatus")]
        public HasTheAbuseBecomeMoreSevereOrFrequentInTheLastSizMonths AreYouSeekingInformationRegardingImmigrationStatus { get; set; }

        [BsonElement("IfYouAreSeekingAssistanceInOtherAreasPleaseDescribe")]
        public string IfYouAreSeekingAssistanceInOtherAreasPleaseDescribe { get; set; }

    }

    public partial class IdentifyingInformation
    {
        [BsonElement("FullName")]
        public string FullName { get; set; }

        [BsonElement("CurrentAddress")]
        public string CurrentAddress { get; set; }

        [BsonElement("SafePhoneNumber")]
        public string SafePhoneNumber { get; set; }

        [BsonElement("DateOfBirth")]
        public string DateOfBirth { get; set; }

        [BsonElement("Age")]
        public string Age { get; set; }

        [BsonElement("Gender")]
        public string Gender { get; set; }

        [BsonElement("LanguageSpoken")]
        public LanguageSpoken LanguageSpoken { get; set; }

        [BsonElement("Ethnicity")]
        public IdentifyingInformationEthnicity Ethnicity { get; set; }

        [BsonElement("Race")]
        public IdentifyingInformationRace Race { get; set; }

        [BsonElement("SexualOrientation")]
        public SexualOrientation SexualOrientation { get; set; }

    }

    public partial class IdentifyingInformationEthnicity
    {
        [BsonElement("Hispanic")]
        public string Hispanic { get; set; }

        [BsonElement("NonHispanic")]
        public string NonHispanic { get; set; }

        [BsonElement("DonTKnow")]
        public string DonTKnow { get; set; }

        [BsonElement("Refused")]
        public string Refused { get; set; }

    }

    public partial class LanguageSpoken
    {
        [BsonElement("English")]
        public English English { get; set; }

    }

    public partial class English
    {
        [BsonElement("Yes")]
        public string Yes { get; set; }

        [BsonElement("No")]
        public string No { get; set; }

        [BsonElement("Other")]
        public string Other { get; set; }

    }

    public partial class IdentifyingInformationRace
    {
        [BsonElement("AmericanIndianAlaskanNative")]
        public string AmericanIndianAlaskanNative { get; set; }

        [BsonElement("Asian")]
        public string Asian { get; set; }

        [BsonElement("BlackOrAfricanAmerican")]
        public string BlackOrAfricanAmerican { get; set; }

        [BsonElement("NativeHawaiianOrPacificIslander")]
        public string NativeHawaiianOrPacificIslander { get; set; }

        [BsonElement("White")]
        public string White { get; set; }

        [BsonElement("Other")]
        public string Other { get; set; }

        [BsonElement("EnterHere")]
        public string EnterHere { get; set; }

        [BsonElement("Refused")]
        public string Refused { get; set; }

    }

    public partial class SexualOrientation
    {
        [BsonElement("Heterosexual")]
        public string Heterosexual { get; set; }

        [BsonElement("Lesbian")]
        public string Lesbian { get; set; }

        [BsonElement("Gay")]
        public string Gay { get; set; }

        [BsonElement("Bisexual")]
        public string Bisexual { get; set; }

        [BsonElement("Transgender")]
        public string Transgender { get; set; }

        [BsonElement("Queer")]
        public string Queer { get; set; }

        [BsonElement("Other")]
        public string Other { get; set; }

        [BsonElement("Refused")]
        public string Refused { get; set; }

    }

    public partial class LaCasaIncParticipation
    {
        [BsonElement("AreYouACurrentClientOfLaCasaInc")]
        public AreYouACurrentClientOfLaCasaInc AreYouACurrentClientOfLaCasaInc { get; set; }

        [BsonElement("AreYouAPastClientOfLaCasaInc")]
        public AreYouAPastClientOfLaCasaInc AreYouAPastClientOfLaCasaInc { get; set; }

        [BsonElement("VeteranStatus")]
        public DoYouHaveAnyFoodAllergies VeteranStatus { get; set; }

        [BsonElement("EnrolledInVocationalEducationalProgram")]
        public EnrolledInVocationalEducationalProgram EnrolledInVocationalEducationalProgram { get; set; }

        [BsonElement("EmployementStatus")]
        public EmployementStatus EmployementStatus { get; set; }

        [BsonElement("FamilyIncome")]
        public FamilyIncome FamilyIncome { get; set; }

        [BsonElement("DoYouIdentifyAsAPersonOfColor")]
        public DoYouHaveAnyFoodAllergies DoYouIdentifyAsAPersonOfColor { get; set; }

        [BsonElement("InvolvementWithCyfdCpsChildProtectiveServices")]
        public DoYouHaveAnyFoodAllergies InvolvementWithCyfdCpsChildProtectiveServices { get; set; }

        [BsonElement("InvolvementWithCyfdJuvenileJusticeDivision")]
        public DoYouHaveAnyFoodAllergies InvolvementWithCyfdJuvenileJusticeDivision { get; set; }

        [BsonElement("DoYouHaveAnyFoodDisabilities")]
        public DoYouHaveAnyFoodAllergies DoYouHaveAnyFoodDisabilities { get; set; }

        [BsonElement("DoYouHaveAnyFoodAllergies")]
        public DoYouHaveAnyFoodAllergies DoYouHaveAnyFoodAllergies { get; set; }

        [BsonElement("LivingStatus")]
        public LivingStatus LivingStatus { get; set; }

    }

    public partial class AreYouACurrentClientOfLaCasaInc
    {
        [BsonElement("Yes")]
        public string Yes { get; set; }

        [BsonElement("No")]
        public string No { get; set; }

        [BsonElement("IfYesWhatProgram")]
        public IfYesWhatProgramClass IfYesWhatProgram { get; set; }

    }

    public partial class IfYesWhatProgramClass
    {
        [BsonElement("Shelter")]
        public string Shelter { get; set; }

        [BsonElement("NonRes")]
        public string NonRes { get; set; }

        [BsonElement("Bip")]
        public string Bip { get; set; }

        [BsonElement("Legal")]
        public string Legal { get; set; }

        [BsonElement("Immigration")]
        public string Immigration { get; set; }

        [BsonElement("Cyp")]
        public string Cyp { get; set; }

        [BsonElement("SouthValley")]
        public string SouthValley { get; set; }

        [BsonElement("Housing")]
        public string Housing { get; set; }

        [BsonElement("IfYesWhatProgramNonRes")]
        public string IfYesWhatProgramNonRes { get; set; }

    }

    public partial class AreYouAPastClientOfLaCasaInc
    {
        [BsonElement("Yes")]
        public string Yes { get; set; }

        [BsonElement("No")]
        public string No { get; set; }

        [BsonElement("IfYesDateOfLastService")]
        public string IfYesDateOfLastService { get; set; }

        [BsonElement("IfYesWhatProgram")]
        public IfYesWhatProgramClass IfYesWhatProgram { get; set; }

    }

    public partial class EmployementStatus
    {
        [BsonElement("Employed")]
        public string Employed { get; set; }

        [BsonElement("Unemployed")]
        public string Unemployed { get; set; }

        [BsonElement("ActivelySeekingEmployment")]
        public string ActivelySeekingEmployment { get; set; }

        [BsonElement("Retired")]
        public string Retired { get; set; }

        [BsonElement("ReceivingTanfCashAssistance")]
        public MedicaidEnrolled ReceivingTanfCashAssistance { get; set; }

        [BsonElement("MedicaidEnrolled")]
        public MedicaidEnrolled MedicaidEnrolled { get; set; }

    }

    public partial class MedicaidEnrolled
    {
        [BsonElement("Yes")]
        public string Yes { get; set; }

        [BsonElement("No")]
        public string No { get; set; }

    }

    public partial class EnrolledInVocationalEducationalProgram
    {
        [BsonElement("Yes")]
        public string Yes { get; set; }

        [BsonElement("No")]
        public string No { get; set; }

        [BsonElement("HighestLevelOfEducation")]
        public string HighestLevelOfEducation { get; set; }

    }

    public partial class FamilyIncome
    {
        [BsonElement("The0To19623")]
        public string The0To19623 { get; set; }

        [BsonElement("The19624To26438")]
        public string The19624To26438 { get; set; }

        [BsonElement("The26439To33253")]
        public string The26439To33253 { get; set; }

        [BsonElement("The33254To40068")]
        public string The33254To40068 { get; set; }

        [BsonElement("The40069To46883")]
        public string The40069To46883 { get; set; }

        [BsonElement("The46884To53698")]
        public string The46884To53698 { get; set; }

        [BsonElement("The53699To60531")]
        public string The53699To60531 { get; set; }

        [BsonElement("The60532To67328")]
        public string The60532To67328 { get; set; }

        [BsonElement("The67329To74143")]
        public string The67329To74143 { get; set; }

        [BsonElement("The74144To80958")]
        public string The74144To80958 { get; set; }

        [BsonElement("EnterIncome")]
        public string EnterIncome { get; set; }

    }

    public partial class LivingStatus
    {
        [BsonElement("LivesWithPerpetratorIsInPreviousSituationRelationship")]
        public string LivesWithPerpetratorIsInPreviousSituationRelationship { get; set; }

        [BsonElement("RentOrOwnHome")]
        public string RentOrOwnHome { get; set; }

        [BsonElement("LivingWithFriendRelative")]
        public string LivingWithFriendRelative { get; set; }

        [BsonElement("TransitionalLiving")]
        public string TransitionalLiving { get; set; }

        [BsonElement("InShelter")]
        public string InShelter { get; set; }

        [BsonElement("OnTheStreetHomeless")]
        public string OnTheStreetHomeless { get; set; }

        [BsonElement("JailCorrectinoalFacility")]
        public string JailCorrectinoalFacility { get; set; }

        [BsonElement("WhereaboutsUnknownNeutral")]
        public string WhereaboutsUnknownNeutral { get; set; }

    }

    public partial class ReferredBy
    {
        [BsonElement("Self")]
        public string Self { get; set; }

        [BsonElement("CommunityPartner")]
        public string CommunityPartner { get; set; }

        [BsonElement("FriendFamilyMemberAdvertisement")]
        public string FriendFamilyMemberAdvertisement { get; set; }

        [BsonElement("CyfdProtectiveServices")]
        public string CyfdProtectiveServices { get; set; }

        [BsonElement("OnlineInternet")]
        public string OnlineInternet { get; set; }

        [BsonElement("CourtProbationParole")]
        public string CourtProbationParole { get; set; }

        [BsonElement("LawEnforcement")]
        public string LawEnforcement { get; set; }

        [BsonElement("Other")]
        public string Other { get; set; }

    }
}

