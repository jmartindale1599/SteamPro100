// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_clientserver_uds.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientUDSP2PSessionStarted : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid_remote
        {
            get => __pbn__steamid_remote.GetValueOrDefault();
            set => __pbn__steamid_remote = value;
        }
        public bool ShouldSerializesteamid_remote() => __pbn__steamid_remote != null;
        public void Resetsteamid_remote() => __pbn__steamid_remote = null;
        private ulong? __pbn__steamid_remote;

        [global::ProtoBuf.ProtoMember(2)]
        public int appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private int? __pbn__appid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientUDSP2PSessionEnded : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid_remote
        {
            get => __pbn__steamid_remote.GetValueOrDefault();
            set => __pbn__steamid_remote = value;
        }
        public bool ShouldSerializesteamid_remote() => __pbn__steamid_remote != null;
        public void Resetsteamid_remote() => __pbn__steamid_remote = null;
        private ulong? __pbn__steamid_remote;

        [global::ProtoBuf.ProtoMember(2)]
        public int appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private int? __pbn__appid;

        [global::ProtoBuf.ProtoMember(3)]
        public int session_length_sec
        {
            get => __pbn__session_length_sec.GetValueOrDefault();
            set => __pbn__session_length_sec = value;
        }
        public bool ShouldSerializesession_length_sec() => __pbn__session_length_sec != null;
        public void Resetsession_length_sec() => __pbn__session_length_sec = null;
        private int? __pbn__session_length_sec;

        [global::ProtoBuf.ProtoMember(4)]
        public int session_error
        {
            get => __pbn__session_error.GetValueOrDefault();
            set => __pbn__session_error = value;
        }
        public bool ShouldSerializesession_error() => __pbn__session_error != null;
        public void Resetsession_error() => __pbn__session_error = null;
        private int? __pbn__session_error;

        [global::ProtoBuf.ProtoMember(5)]
        public int nattype
        {
            get => __pbn__nattype.GetValueOrDefault();
            set => __pbn__nattype = value;
        }
        public bool ShouldSerializenattype() => __pbn__nattype != null;
        public void Resetnattype() => __pbn__nattype = null;
        private int? __pbn__nattype;

        [global::ProtoBuf.ProtoMember(6)]
        public int bytes_recv
        {
            get => __pbn__bytes_recv.GetValueOrDefault();
            set => __pbn__bytes_recv = value;
        }
        public bool ShouldSerializebytes_recv() => __pbn__bytes_recv != null;
        public void Resetbytes_recv() => __pbn__bytes_recv = null;
        private int? __pbn__bytes_recv;

        [global::ProtoBuf.ProtoMember(7)]
        public int bytes_sent
        {
            get => __pbn__bytes_sent.GetValueOrDefault();
            set => __pbn__bytes_sent = value;
        }
        public bool ShouldSerializebytes_sent() => __pbn__bytes_sent != null;
        public void Resetbytes_sent() => __pbn__bytes_sent = null;
        private int? __pbn__bytes_sent;

        [global::ProtoBuf.ProtoMember(8)]
        public int bytes_sent_relay
        {
            get => __pbn__bytes_sent_relay.GetValueOrDefault();
            set => __pbn__bytes_sent_relay = value;
        }
        public bool ShouldSerializebytes_sent_relay() => __pbn__bytes_sent_relay != null;
        public void Resetbytes_sent_relay() => __pbn__bytes_sent_relay = null;
        private int? __pbn__bytes_sent_relay;

        [global::ProtoBuf.ProtoMember(9)]
        public int bytes_recv_relay
        {
            get => __pbn__bytes_recv_relay.GetValueOrDefault();
            set => __pbn__bytes_recv_relay = value;
        }
        public bool ShouldSerializebytes_recv_relay() => __pbn__bytes_recv_relay != null;
        public void Resetbytes_recv_relay() => __pbn__bytes_recv_relay = null;
        private int? __pbn__bytes_recv_relay;

        [global::ProtoBuf.ProtoMember(10)]
        public int time_to_connect_ms
        {
            get => __pbn__time_to_connect_ms.GetValueOrDefault();
            set => __pbn__time_to_connect_ms = value;
        }
        public bool ShouldSerializetime_to_connect_ms() => __pbn__time_to_connect_ms != null;
        public void Resettime_to_connect_ms() => __pbn__time_to_connect_ms = null;
        private int? __pbn__time_to_connect_ms;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientGetClientDetails : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientGetClientDetailsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint package_version
        {
            get => __pbn__package_version.GetValueOrDefault();
            set => __pbn__package_version = value;
        }
        public bool ShouldSerializepackage_version() => __pbn__package_version != null;
        public void Resetpackage_version() => __pbn__package_version = null;
        private uint? __pbn__package_version;

        [global::ProtoBuf.ProtoMember(8)]
        public uint protocol_version
        {
            get => __pbn__protocol_version.GetValueOrDefault();
            set => __pbn__protocol_version = value;
        }
        public bool ShouldSerializeprotocol_version() => __pbn__protocol_version != null;
        public void Resetprotocol_version() => __pbn__protocol_version = null;
        private uint? __pbn__protocol_version;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string os
        {
            get => __pbn__os ?? "";
            set => __pbn__os = value;
        }
        public bool ShouldSerializeos() => __pbn__os != null;
        public void Resetos() => __pbn__os = null;
        private string __pbn__os;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string machine_name
        {
            get => __pbn__machine_name ?? "";
            set => __pbn__machine_name = value;
        }
        public bool ShouldSerializemachine_name() => __pbn__machine_name != null;
        public void Resetmachine_name() => __pbn__machine_name = null;
        private string __pbn__machine_name;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ip_public
        {
            get => __pbn__ip_public ?? "";
            set => __pbn__ip_public = value;
        }
        public bool ShouldSerializeip_public() => __pbn__ip_public != null;
        public void Resetip_public() => __pbn__ip_public = null;
        private string __pbn__ip_public;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ip_private
        {
            get => __pbn__ip_private ?? "";
            set => __pbn__ip_private = value;
        }
        public bool ShouldSerializeip_private() => __pbn__ip_private != null;
        public void Resetip_private() => __pbn__ip_private = null;
        private string __pbn__ip_private;

        [global::ProtoBuf.ProtoMember(7)]
        public ulong bytes_available
        {
            get => __pbn__bytes_available.GetValueOrDefault();
            set => __pbn__bytes_available = value;
        }
        public bool ShouldSerializebytes_available() => __pbn__bytes_available != null;
        public void Resetbytes_available() => __pbn__bytes_available = null;
        private ulong? __pbn__bytes_available;

        [global::ProtoBuf.ProtoMember(6)]
        public global::System.Collections.Generic.List<Game> games_running { get; } = new global::System.Collections.Generic.List<Game>();

        [global::ProtoBuf.ProtoContract()]
        public partial class Game : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public uint appid
            {
                get => __pbn__appid.GetValueOrDefault();
                set => __pbn__appid = value;
            }
            public bool ShouldSerializeappid() => __pbn__appid != null;
            public void Resetappid() => __pbn__appid = null;
            private uint? __pbn__appid;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string extra_info
            {
                get => __pbn__extra_info ?? "";
                set => __pbn__extra_info = value;
            }
            public bool ShouldSerializeextra_info() => __pbn__extra_info != null;
            public void Resetextra_info() => __pbn__extra_info = null;
            private string __pbn__extra_info;

            [global::ProtoBuf.ProtoMember(3)]
            public uint time_running_sec
            {
                get => __pbn__time_running_sec.GetValueOrDefault();
                set => __pbn__time_running_sec = value;
            }
            public bool ShouldSerializetime_running_sec() => __pbn__time_running_sec != null;
            public void Resettime_running_sec() => __pbn__time_running_sec = null;
            private uint? __pbn__time_running_sec;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientGetClientAppList : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool media
        {
            get => __pbn__media.GetValueOrDefault();
            set => __pbn__media = value;
        }
        public bool ShouldSerializemedia() => __pbn__media != null;
        public void Resetmedia() => __pbn__media = null;
        private bool? __pbn__media;

        [global::ProtoBuf.ProtoMember(2)]
        public bool tools
        {
            get => __pbn__tools.GetValueOrDefault();
            set => __pbn__tools = value;
        }
        public bool ShouldSerializetools() => __pbn__tools != null;
        public void Resettools() => __pbn__tools = null;
        private bool? __pbn__tools;

        [global::ProtoBuf.ProtoMember(3)]
        public bool games
        {
            get => __pbn__games.GetValueOrDefault();
            set => __pbn__games = value;
        }
        public bool ShouldSerializegames() => __pbn__games != null;
        public void Resetgames() => __pbn__games = null;
        private bool? __pbn__games;

        [global::ProtoBuf.ProtoMember(4)]
        public bool only_installed
        {
            get => __pbn__only_installed.GetValueOrDefault();
            set => __pbn__only_installed = value;
        }
        public bool ShouldSerializeonly_installed() => __pbn__only_installed != null;
        public void Resetonly_installed() => __pbn__only_installed = null;
        private bool? __pbn__only_installed;

        [global::ProtoBuf.ProtoMember(5)]
        public bool only_changing
        {
            get => __pbn__only_changing.GetValueOrDefault();
            set => __pbn__only_changing = value;
        }
        public bool ShouldSerializeonly_changing() => __pbn__only_changing != null;
        public void Resetonly_changing() => __pbn__only_changing = null;
        private bool? __pbn__only_changing;

        [global::ProtoBuf.ProtoMember(6)]
        public bool comics
        {
            get => __pbn__comics.GetValueOrDefault();
            set => __pbn__comics = value;
        }
        public bool ShouldSerializecomics() => __pbn__comics != null;
        public void Resetcomics() => __pbn__comics = null;
        private bool? __pbn__comics;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientGetClientAppListResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<App> apps { get; } = new global::System.Collections.Generic.List<App>();

        [global::ProtoBuf.ProtoMember(2)]
        public ulong bytes_available
        {
            get => __pbn__bytes_available.GetValueOrDefault();
            set => __pbn__bytes_available = value;
        }
        public bool ShouldSerializebytes_available() => __pbn__bytes_available != null;
        public void Resetbytes_available() => __pbn__bytes_available = null;
        private ulong? __pbn__bytes_available;

        [global::ProtoBuf.ProtoContract()]
        public partial class App : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public uint appid
            {
                get => __pbn__appid.GetValueOrDefault();
                set => __pbn__appid = value;
            }
            public bool ShouldSerializeappid() => __pbn__appid != null;
            public void Resetappid() => __pbn__appid = null;
            private uint? __pbn__appid;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string category
            {
                get => __pbn__category ?? "";
                set => __pbn__category = value;
            }
            public bool ShouldSerializecategory() => __pbn__category != null;
            public void Resetcategory() => __pbn__category = null;
            private string __pbn__category;

            [global::ProtoBuf.ProtoMember(10)]
            [global::System.ComponentModel.DefaultValue("")]
            public string app_type
            {
                get => __pbn__app_type ?? "";
                set => __pbn__app_type = value;
            }
            public bool ShouldSerializeapp_type() => __pbn__app_type != null;
            public void Resetapp_type() => __pbn__app_type = null;
            private string __pbn__app_type;

            [global::ProtoBuf.ProtoMember(3)]
            public bool favorite
            {
                get => __pbn__favorite.GetValueOrDefault();
                set => __pbn__favorite = value;
            }
            public bool ShouldSerializefavorite() => __pbn__favorite != null;
            public void Resetfavorite() => __pbn__favorite = null;
            private bool? __pbn__favorite;

            [global::ProtoBuf.ProtoMember(4)]
            public bool installed
            {
                get => __pbn__installed.GetValueOrDefault();
                set => __pbn__installed = value;
            }
            public bool ShouldSerializeinstalled() => __pbn__installed != null;
            public void Resetinstalled() => __pbn__installed = null;
            private bool? __pbn__installed;

            [global::ProtoBuf.ProtoMember(5)]
            public bool auto_update
            {
                get => __pbn__auto_update.GetValueOrDefault();
                set => __pbn__auto_update = value;
            }
            public bool ShouldSerializeauto_update() => __pbn__auto_update != null;
            public void Resetauto_update() => __pbn__auto_update = null;
            private bool? __pbn__auto_update;

            [global::ProtoBuf.ProtoMember(6)]
            public ulong bytes_downloaded
            {
                get => __pbn__bytes_downloaded.GetValueOrDefault();
                set => __pbn__bytes_downloaded = value;
            }
            public bool ShouldSerializebytes_downloaded() => __pbn__bytes_downloaded != null;
            public void Resetbytes_downloaded() => __pbn__bytes_downloaded = null;
            private ulong? __pbn__bytes_downloaded;

            [global::ProtoBuf.ProtoMember(7)]
            public ulong bytes_needed
            {
                get => __pbn__bytes_needed.GetValueOrDefault();
                set => __pbn__bytes_needed = value;
            }
            public bool ShouldSerializebytes_needed() => __pbn__bytes_needed != null;
            public void Resetbytes_needed() => __pbn__bytes_needed = null;
            private ulong? __pbn__bytes_needed;

            [global::ProtoBuf.ProtoMember(8)]
            public uint bytes_download_rate
            {
                get => __pbn__bytes_download_rate.GetValueOrDefault();
                set => __pbn__bytes_download_rate = value;
            }
            public bool ShouldSerializebytes_download_rate() => __pbn__bytes_download_rate != null;
            public void Resetbytes_download_rate() => __pbn__bytes_download_rate = null;
            private uint? __pbn__bytes_download_rate;

            [global::ProtoBuf.ProtoMember(11)]
            public bool download_paused
            {
                get => __pbn__download_paused.GetValueOrDefault();
                set => __pbn__download_paused = value;
            }
            public bool ShouldSerializedownload_paused() => __pbn__download_paused != null;
            public void Resetdownload_paused() => __pbn__download_paused = null;
            private bool? __pbn__download_paused;

            [global::ProtoBuf.ProtoMember(12)]
            public uint num_downloading
            {
                get => __pbn__num_downloading.GetValueOrDefault();
                set => __pbn__num_downloading = value;
            }
            public bool ShouldSerializenum_downloading() => __pbn__num_downloading != null;
            public void Resetnum_downloading() => __pbn__num_downloading = null;
            private uint? __pbn__num_downloading;

            [global::ProtoBuf.ProtoMember(13)]
            public uint num_paused
            {
                get => __pbn__num_paused.GetValueOrDefault();
                set => __pbn__num_paused = value;
            }
            public bool ShouldSerializenum_paused() => __pbn__num_paused != null;
            public void Resetnum_paused() => __pbn__num_paused = null;
            private uint? __pbn__num_paused;

            [global::ProtoBuf.ProtoMember(14)]
            public bool changing
            {
                get => __pbn__changing.GetValueOrDefault();
                set => __pbn__changing = value;
            }
            public bool ShouldSerializechanging() => __pbn__changing != null;
            public void Resetchanging() => __pbn__changing = null;
            private bool? __pbn__changing;

            [global::ProtoBuf.ProtoMember(15)]
            public bool available_on_platform
            {
                get => __pbn__available_on_platform.GetValueOrDefault();
                set => __pbn__available_on_platform = value;
            }
            public bool ShouldSerializeavailable_on_platform() => __pbn__available_on_platform != null;
            public void Resetavailable_on_platform() => __pbn__available_on_platform = null;
            private bool? __pbn__available_on_platform;

            [global::ProtoBuf.ProtoMember(9)]
            public global::System.Collections.Generic.List<DLC> dlcs { get; } = new global::System.Collections.Generic.List<DLC>();

            [global::ProtoBuf.ProtoContract()]
            public partial class DLC : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1)]
                public uint appid
                {
                    get => __pbn__appid.GetValueOrDefault();
                    set => __pbn__appid = value;
                }
                public bool ShouldSerializeappid() => __pbn__appid != null;
                public void Resetappid() => __pbn__appid = null;
                private uint? __pbn__appid;

                [global::ProtoBuf.ProtoMember(2)]
                public bool installed
                {
                    get => __pbn__installed.GetValueOrDefault();
                    set => __pbn__installed = value;
                }
                public bool ShouldSerializeinstalled() => __pbn__installed != null;
                public void Resetinstalled() => __pbn__installed = null;
                private bool? __pbn__installed;

            }

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientInstallClientApp : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
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
    public partial class CMsgClientInstallClientAppResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint result
        {
            get => __pbn__result.GetValueOrDefault();
            set => __pbn__result = value;
        }
        public bool ShouldSerializeresult() => __pbn__result != null;
        public void Resetresult() => __pbn__result = null;
        private uint? __pbn__result;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientUninstallClientApp : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
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
    public partial class CMsgClientUninstallClientAppResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint result
        {
            get => __pbn__result.GetValueOrDefault();
            set => __pbn__result = value;
        }
        public bool ShouldSerializeresult() => __pbn__result != null;
        public void Resetresult() => __pbn__result = null;
        private uint? __pbn__result;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientSetClientAppUpdateState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public bool update
        {
            get => __pbn__update.GetValueOrDefault();
            set => __pbn__update = value;
        }
        public bool ShouldSerializeupdate() => __pbn__update != null;
        public void Resetupdate() => __pbn__update = null;
        private bool? __pbn__update;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientSetClientAppUpdateStateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint result
        {
            get => __pbn__result.GetValueOrDefault();
            set => __pbn__result = value;
        }
        public bool ShouldSerializeresult() => __pbn__result != null;
        public void Resetresult() => __pbn__result = null;
        private uint? __pbn__result;

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion