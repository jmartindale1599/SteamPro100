// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.GC.Dota.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgProtoBufHeader : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong client_steam_id
        {
            get => __pbn__client_steam_id.GetValueOrDefault();
            set => __pbn__client_steam_id = value;
        }
        public bool ShouldSerializeclient_steam_id() => __pbn__client_steam_id != null;
        public void Resetclient_steam_id() => __pbn__client_steam_id = null;
        private ulong? __pbn__client_steam_id;

        [global::ProtoBuf.ProtoMember(2)]
        public int client_session_id
        {
            get => __pbn__client_session_id.GetValueOrDefault();
            set => __pbn__client_session_id = value;
        }
        public bool ShouldSerializeclient_session_id() => __pbn__client_session_id != null;
        public void Resetclient_session_id() => __pbn__client_session_id = null;
        private int? __pbn__client_session_id;

        [global::ProtoBuf.ProtoMember(3)]
        public uint source_app_id
        {
            get => __pbn__source_app_id.GetValueOrDefault();
            set => __pbn__source_app_id = value;
        }
        public bool ShouldSerializesource_app_id() => __pbn__source_app_id != null;
        public void Resetsource_app_id() => __pbn__source_app_id = null;
        private uint? __pbn__source_app_id;

        [global::ProtoBuf.ProtoMember(10, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(typeof(ulong), "18446744073709551615")]
        public ulong job_id_source
        {
            get => __pbn__job_id_source ?? 18446744073709551615;
            set => __pbn__job_id_source = value;
        }
        public bool ShouldSerializejob_id_source() => __pbn__job_id_source != null;
        public void Resetjob_id_source() => __pbn__job_id_source = null;
        private ulong? __pbn__job_id_source;

        [global::ProtoBuf.ProtoMember(11, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(typeof(ulong), "18446744073709551615")]
        public ulong job_id_target
        {
            get => __pbn__job_id_target ?? 18446744073709551615;
            set => __pbn__job_id_target = value;
        }
        public bool ShouldSerializejob_id_target() => __pbn__job_id_target != null;
        public void Resetjob_id_target() => __pbn__job_id_target = null;
        private ulong? __pbn__job_id_target;

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue("")]
        public string target_job_name
        {
            get => __pbn__target_job_name ?? "";
            set => __pbn__target_job_name = value;
        }
        public bool ShouldSerializetarget_job_name() => __pbn__target_job_name != null;
        public void Resettarget_job_name() => __pbn__target_job_name = null;
        private string __pbn__target_job_name;

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue(2)]
        public int eresult
        {
            get => __pbn__eresult ?? 2;
            set => __pbn__eresult = value;
        }
        public bool ShouldSerializeeresult() => __pbn__eresult != null;
        public void Reseteresult() => __pbn__eresult = null;
        private int? __pbn__eresult;

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue("")]
        public string error_message
        {
            get => __pbn__error_message ?? "";
            set => __pbn__error_message = value;
        }
        public bool ShouldSerializeerror_message() => __pbn__error_message != null;
        public void Reseterror_message() => __pbn__error_message = null;
        private string __pbn__error_message;

        [global::ProtoBuf.ProtoMember(200)]
        [global::System.ComponentModel.DefaultValue(GCProtoBufMsgSrc.GCProtoBufMsgSrc_Unspecified)]
        public GCProtoBufMsgSrc gc_msg_src
        {
            get => __pbn__gc_msg_src ?? GCProtoBufMsgSrc.GCProtoBufMsgSrc_Unspecified;
            set => __pbn__gc_msg_src = value;
        }
        public bool ShouldSerializegc_msg_src() => __pbn__gc_msg_src != null;
        public void Resetgc_msg_src() => __pbn__gc_msg_src = null;
        private GCProtoBufMsgSrc? __pbn__gc_msg_src;

        [global::ProtoBuf.ProtoMember(201)]
        public int gc_dir_index_source
        {
            get => __pbn__gc_dir_index_source.GetValueOrDefault();
            set => __pbn__gc_dir_index_source = value;
        }
        public bool ShouldSerializegc_dir_index_source() => __pbn__gc_dir_index_source != null;
        public void Resetgc_dir_index_source() => __pbn__gc_dir_index_source = null;
        private int? __pbn__gc_dir_index_source;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGCSystemMsg_GetAccountDetails : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(2)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGCSystemMsg_GetAccountDetails_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(2)]
        public uint eresult_deprecated
        {
            get => __pbn__eresult_deprecated ?? 2;
            set => __pbn__eresult_deprecated = value;
        }
        public bool ShouldSerializeeresult_deprecated() => __pbn__eresult_deprecated != null;
        public void Reseteresult_deprecated() => __pbn__eresult_deprecated = null;
        private uint? __pbn__eresult_deprecated;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string account_name
        {
            get => __pbn__account_name ?? "";
            set => __pbn__account_name = value;
        }
        public bool ShouldSerializeaccount_name() => __pbn__account_name != null;
        public void Resetaccount_name() => __pbn__account_name = null;
        private string __pbn__account_name;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string persona_name
        {
            get => __pbn__persona_name ?? "";
            set => __pbn__persona_name = value;
        }
        public bool ShouldSerializepersona_name() => __pbn__persona_name != null;
        public void Resetpersona_name() => __pbn__persona_name = null;
        private string __pbn__persona_name;

        [global::ProtoBuf.ProtoMember(26)]
        public bool is_profile_created
        {
            get => __pbn__is_profile_created.GetValueOrDefault();
            set => __pbn__is_profile_created = value;
        }
        public bool ShouldSerializeis_profile_created() => __pbn__is_profile_created != null;
        public void Resetis_profile_created() => __pbn__is_profile_created = null;
        private bool? __pbn__is_profile_created;

        [global::ProtoBuf.ProtoMember(4)]
        public bool is_profile_public
        {
            get => __pbn__is_profile_public.GetValueOrDefault();
            set => __pbn__is_profile_public = value;
        }
        public bool ShouldSerializeis_profile_public() => __pbn__is_profile_public != null;
        public void Resetis_profile_public() => __pbn__is_profile_public = null;
        private bool? __pbn__is_profile_public;

        [global::ProtoBuf.ProtoMember(5)]
        public bool is_inventory_public
        {
            get => __pbn__is_inventory_public.GetValueOrDefault();
            set => __pbn__is_inventory_public = value;
        }
        public bool ShouldSerializeis_inventory_public() => __pbn__is_inventory_public != null;
        public void Resetis_inventory_public() => __pbn__is_inventory_public = null;
        private bool? __pbn__is_inventory_public;

        [global::ProtoBuf.ProtoMember(7)]
        public bool is_vac_banned
        {
            get => __pbn__is_vac_banned.GetValueOrDefault();
            set => __pbn__is_vac_banned = value;
        }
        public bool ShouldSerializeis_vac_banned() => __pbn__is_vac_banned != null;
        public void Resetis_vac_banned() => __pbn__is_vac_banned = null;
        private bool? __pbn__is_vac_banned;

        [global::ProtoBuf.ProtoMember(8)]
        public bool is_cyber_cafe
        {
            get => __pbn__is_cyber_cafe.GetValueOrDefault();
            set => __pbn__is_cyber_cafe = value;
        }
        public bool ShouldSerializeis_cyber_cafe() => __pbn__is_cyber_cafe != null;
        public void Resetis_cyber_cafe() => __pbn__is_cyber_cafe = null;
        private bool? __pbn__is_cyber_cafe;

        [global::ProtoBuf.ProtoMember(9)]
        public bool is_school_account
        {
            get => __pbn__is_school_account.GetValueOrDefault();
            set => __pbn__is_school_account = value;
        }
        public bool ShouldSerializeis_school_account() => __pbn__is_school_account != null;
        public void Resetis_school_account() => __pbn__is_school_account = null;
        private bool? __pbn__is_school_account;

        [global::ProtoBuf.ProtoMember(10)]
        public bool is_limited
        {
            get => __pbn__is_limited.GetValueOrDefault();
            set => __pbn__is_limited = value;
        }
        public bool ShouldSerializeis_limited() => __pbn__is_limited != null;
        public void Resetis_limited() => __pbn__is_limited = null;
        private bool? __pbn__is_limited;

        [global::ProtoBuf.ProtoMember(11)]
        public bool is_subscribed
        {
            get => __pbn__is_subscribed.GetValueOrDefault();
            set => __pbn__is_subscribed = value;
        }
        public bool ShouldSerializeis_subscribed() => __pbn__is_subscribed != null;
        public void Resetis_subscribed() => __pbn__is_subscribed = null;
        private bool? __pbn__is_subscribed;

        [global::ProtoBuf.ProtoMember(12)]
        public uint package
        {
            get => __pbn__package.GetValueOrDefault();
            set => __pbn__package = value;
        }
        public bool ShouldSerializepackage() => __pbn__package != null;
        public void Resetpackage() => __pbn__package = null;
        private uint? __pbn__package;

        [global::ProtoBuf.ProtoMember(13)]
        public bool is_free_trial_account
        {
            get => __pbn__is_free_trial_account.GetValueOrDefault();
            set => __pbn__is_free_trial_account = value;
        }
        public bool ShouldSerializeis_free_trial_account() => __pbn__is_free_trial_account != null;
        public void Resetis_free_trial_account() => __pbn__is_free_trial_account = null;
        private bool? __pbn__is_free_trial_account;

        [global::ProtoBuf.ProtoMember(14)]
        public uint free_trial_expiration
        {
            get => __pbn__free_trial_expiration.GetValueOrDefault();
            set => __pbn__free_trial_expiration = value;
        }
        public bool ShouldSerializefree_trial_expiration() => __pbn__free_trial_expiration != null;
        public void Resetfree_trial_expiration() => __pbn__free_trial_expiration = null;
        private uint? __pbn__free_trial_expiration;

        [global::ProtoBuf.ProtoMember(15)]
        public bool is_low_violence
        {
            get => __pbn__is_low_violence.GetValueOrDefault();
            set => __pbn__is_low_violence = value;
        }
        public bool ShouldSerializeis_low_violence() => __pbn__is_low_violence != null;
        public void Resetis_low_violence() => __pbn__is_low_violence = null;
        private bool? __pbn__is_low_violence;

        [global::ProtoBuf.ProtoMember(16)]
        public bool is_account_locked_down
        {
            get => __pbn__is_account_locked_down.GetValueOrDefault();
            set => __pbn__is_account_locked_down = value;
        }
        public bool ShouldSerializeis_account_locked_down() => __pbn__is_account_locked_down != null;
        public void Resetis_account_locked_down() => __pbn__is_account_locked_down = null;
        private bool? __pbn__is_account_locked_down;

        [global::ProtoBuf.ProtoMember(17)]
        public bool is_community_banned
        {
            get => __pbn__is_community_banned.GetValueOrDefault();
            set => __pbn__is_community_banned = value;
        }
        public bool ShouldSerializeis_community_banned() => __pbn__is_community_banned != null;
        public void Resetis_community_banned() => __pbn__is_community_banned = null;
        private bool? __pbn__is_community_banned;

        [global::ProtoBuf.ProtoMember(18)]
        public bool is_trade_banned
        {
            get => __pbn__is_trade_banned.GetValueOrDefault();
            set => __pbn__is_trade_banned = value;
        }
        public bool ShouldSerializeis_trade_banned() => __pbn__is_trade_banned != null;
        public void Resetis_trade_banned() => __pbn__is_trade_banned = null;
        private bool? __pbn__is_trade_banned;

        [global::ProtoBuf.ProtoMember(19)]
        public uint trade_ban_expiration
        {
            get => __pbn__trade_ban_expiration.GetValueOrDefault();
            set => __pbn__trade_ban_expiration = value;
        }
        public bool ShouldSerializetrade_ban_expiration() => __pbn__trade_ban_expiration != null;
        public void Resettrade_ban_expiration() => __pbn__trade_ban_expiration = null;
        private uint? __pbn__trade_ban_expiration;

        [global::ProtoBuf.ProtoMember(20)]
        public uint accountid
        {
            get => __pbn__accountid.GetValueOrDefault();
            set => __pbn__accountid = value;
        }
        public bool ShouldSerializeaccountid() => __pbn__accountid != null;
        public void Resetaccountid() => __pbn__accountid = null;
        private uint? __pbn__accountid;

        [global::ProtoBuf.ProtoMember(21)]
        public uint suspension_end_time
        {
            get => __pbn__suspension_end_time.GetValueOrDefault();
            set => __pbn__suspension_end_time = value;
        }
        public bool ShouldSerializesuspension_end_time() => __pbn__suspension_end_time != null;
        public void Resetsuspension_end_time() => __pbn__suspension_end_time = null;
        private uint? __pbn__suspension_end_time;

        [global::ProtoBuf.ProtoMember(22)]
        [global::System.ComponentModel.DefaultValue("")]
        public string currency
        {
            get => __pbn__currency ?? "";
            set => __pbn__currency = value;
        }
        public bool ShouldSerializecurrency() => __pbn__currency != null;
        public void Resetcurrency() => __pbn__currency = null;
        private string __pbn__currency;

        [global::ProtoBuf.ProtoMember(23)]
        public uint steam_level
        {
            get => __pbn__steam_level.GetValueOrDefault();
            set => __pbn__steam_level = value;
        }
        public bool ShouldSerializesteam_level() => __pbn__steam_level != null;
        public void Resetsteam_level() => __pbn__steam_level = null;
        private uint? __pbn__steam_level;

        [global::ProtoBuf.ProtoMember(24)]
        public uint friend_count
        {
            get => __pbn__friend_count.GetValueOrDefault();
            set => __pbn__friend_count = value;
        }
        public bool ShouldSerializefriend_count() => __pbn__friend_count != null;
        public void Resetfriend_count() => __pbn__friend_count = null;
        private uint? __pbn__friend_count;

        [global::ProtoBuf.ProtoMember(25)]
        public uint account_creation_time
        {
            get => __pbn__account_creation_time.GetValueOrDefault();
            set => __pbn__account_creation_time = value;
        }
        public bool ShouldSerializeaccount_creation_time() => __pbn__account_creation_time != null;
        public void Resetaccount_creation_time() => __pbn__account_creation_time = null;
        private uint? __pbn__account_creation_time;

        [global::ProtoBuf.ProtoMember(27)]
        public bool is_steamguard_enabled
        {
            get => __pbn__is_steamguard_enabled.GetValueOrDefault();
            set => __pbn__is_steamguard_enabled = value;
        }
        public bool ShouldSerializeis_steamguard_enabled() => __pbn__is_steamguard_enabled != null;
        public void Resetis_steamguard_enabled() => __pbn__is_steamguard_enabled = null;
        private bool? __pbn__is_steamguard_enabled;

        [global::ProtoBuf.ProtoMember(28)]
        public bool is_phone_verified
        {
            get => __pbn__is_phone_verified.GetValueOrDefault();
            set => __pbn__is_phone_verified = value;
        }
        public bool ShouldSerializeis_phone_verified() => __pbn__is_phone_verified != null;
        public void Resetis_phone_verified() => __pbn__is_phone_verified = null;
        private bool? __pbn__is_phone_verified;

        [global::ProtoBuf.ProtoMember(29)]
        public bool is_two_factor_auth_enabled
        {
            get => __pbn__is_two_factor_auth_enabled.GetValueOrDefault();
            set => __pbn__is_two_factor_auth_enabled = value;
        }
        public bool ShouldSerializeis_two_factor_auth_enabled() => __pbn__is_two_factor_auth_enabled != null;
        public void Resetis_two_factor_auth_enabled() => __pbn__is_two_factor_auth_enabled = null;
        private bool? __pbn__is_two_factor_auth_enabled;

        [global::ProtoBuf.ProtoMember(30)]
        public uint two_factor_enabled_time
        {
            get => __pbn__two_factor_enabled_time.GetValueOrDefault();
            set => __pbn__two_factor_enabled_time = value;
        }
        public bool ShouldSerializetwo_factor_enabled_time() => __pbn__two_factor_enabled_time != null;
        public void Resettwo_factor_enabled_time() => __pbn__two_factor_enabled_time = null;
        private uint? __pbn__two_factor_enabled_time;

        [global::ProtoBuf.ProtoMember(31)]
        public uint phone_verification_time
        {
            get => __pbn__phone_verification_time.GetValueOrDefault();
            set => __pbn__phone_verification_time = value;
        }
        public bool ShouldSerializephone_verification_time() => __pbn__phone_verification_time != null;
        public void Resetphone_verification_time() => __pbn__phone_verification_time = null;
        private uint? __pbn__phone_verification_time;

        [global::ProtoBuf.ProtoMember(33)]
        public ulong phone_id
        {
            get => __pbn__phone_id.GetValueOrDefault();
            set => __pbn__phone_id = value;
        }
        public bool ShouldSerializephone_id() => __pbn__phone_id != null;
        public void Resetphone_id() => __pbn__phone_id = null;
        private ulong? __pbn__phone_id;

        [global::ProtoBuf.ProtoMember(34)]
        public bool is_phone_identifying
        {
            get => __pbn__is_phone_identifying.GetValueOrDefault();
            set => __pbn__is_phone_identifying = value;
        }
        public bool ShouldSerializeis_phone_identifying() => __pbn__is_phone_identifying != null;
        public void Resetis_phone_identifying() => __pbn__is_phone_identifying = null;
        private bool? __pbn__is_phone_identifying;

        [global::ProtoBuf.ProtoMember(35)]
        public uint rt_identity_linked
        {
            get => __pbn__rt_identity_linked.GetValueOrDefault();
            set => __pbn__rt_identity_linked = value;
        }
        public bool ShouldSerializert_identity_linked() => __pbn__rt_identity_linked != null;
        public void Resetrt_identity_linked() => __pbn__rt_identity_linked = null;
        private uint? __pbn__rt_identity_linked;

        [global::ProtoBuf.ProtoMember(36)]
        public uint rt_birth_date
        {
            get => __pbn__rt_birth_date.GetValueOrDefault();
            set => __pbn__rt_birth_date = value;
        }
        public bool ShouldSerializert_birth_date() => __pbn__rt_birth_date != null;
        public void Resetrt_birth_date() => __pbn__rt_birth_date = null;
        private uint? __pbn__rt_birth_date;

        [global::ProtoBuf.ProtoMember(37)]
        [global::System.ComponentModel.DefaultValue("")]
        public string txn_country_code
        {
            get => __pbn__txn_country_code ?? "";
            set => __pbn__txn_country_code = value;
        }
        public bool ShouldSerializetxn_country_code() => __pbn__txn_country_code != null;
        public void Resettxn_country_code() => __pbn__txn_country_code = null;
        private string __pbn__txn_country_code;

        [global::ProtoBuf.ProtoMember(38)]
        public bool has_accepted_china_ssa
        {
            get => __pbn__has_accepted_china_ssa.GetValueOrDefault();
            set => __pbn__has_accepted_china_ssa = value;
        }
        public bool ShouldSerializehas_accepted_china_ssa() => __pbn__has_accepted_china_ssa != null;
        public void Resethas_accepted_china_ssa() => __pbn__has_accepted_china_ssa = null;
        private bool? __pbn__has_accepted_china_ssa;

        [global::ProtoBuf.ProtoMember(39)]
        public bool is_banned_steam_china
        {
            get => __pbn__is_banned_steam_china.GetValueOrDefault();
            set => __pbn__is_banned_steam_china = value;
        }
        public bool ShouldSerializeis_banned_steam_china() => __pbn__is_banned_steam_china != null;
        public void Resetis_banned_steam_china() => __pbn__is_banned_steam_china = null;
        private bool? __pbn__is_banned_steam_china;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CIPLocationInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint ip
        {
            get => __pbn__ip.GetValueOrDefault();
            set => __pbn__ip = value;
        }
        public bool ShouldSerializeip() => __pbn__ip != null;
        public void Resetip() => __pbn__ip = null;
        private uint? __pbn__ip;

        [global::ProtoBuf.ProtoMember(2)]
        public float latitude
        {
            get => __pbn__latitude.GetValueOrDefault();
            set => __pbn__latitude = value;
        }
        public bool ShouldSerializelatitude() => __pbn__latitude != null;
        public void Resetlatitude() => __pbn__latitude = null;
        private float? __pbn__latitude;

        [global::ProtoBuf.ProtoMember(3)]
        public float longitude
        {
            get => __pbn__longitude.GetValueOrDefault();
            set => __pbn__longitude = value;
        }
        public bool ShouldSerializelongitude() => __pbn__longitude != null;
        public void Resetlongitude() => __pbn__longitude = null;
        private float? __pbn__longitude;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string country
        {
            get => __pbn__country ?? "";
            set => __pbn__country = value;
        }
        public bool ShouldSerializecountry() => __pbn__country != null;
        public void Resetcountry() => __pbn__country = null;
        private string __pbn__country;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string state
        {
            get => __pbn__state ?? "";
            set => __pbn__state = value;
        }
        public bool ShouldSerializestate() => __pbn__state != null;
        public void Resetstate() => __pbn__state = null;
        private string __pbn__state;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string city
        {
            get => __pbn__city ?? "";
            set => __pbn__city = value;
        }
        public bool ShouldSerializecity() => __pbn__city != null;
        public void Resetcity() => __pbn__city = null;
        private string __pbn__city;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGCMsgGetIPLocationResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CIPLocationInfo> infos { get; } = new global::System.Collections.Generic.List<CIPLocationInfo>();

    }

    [global::ProtoBuf.ProtoContract()]
    public enum EGCPlatform
    {
        k_eGCPlatform_None = 0,
        k_eGCPlatform_PC = 1,
        k_eGCPlatform_Mac = 2,
        k_eGCPlatform_Linux = 3,
        k_eGCPlatform_Android = 4,
        k_eGCPlatform_iOS = 5,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum GCProtoBufMsgSrc
    {
        GCProtoBufMsgSrc_Unspecified = 0,
        GCProtoBufMsgSrc_FromSystem = 1,
        GCProtoBufMsgSrc_FromSteamID = 2,
        GCProtoBufMsgSrc_FromGC = 3,
        GCProtoBufMsgSrc_ReplySystem = 4,
        GCProtoBufMsgSrc_SpoofedSteamID = 5,
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
