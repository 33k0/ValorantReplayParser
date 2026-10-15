using Replay.Models.Descriptors;
using Replay.Unreal.Parsing;
using Replay.Valorant.Combat;

namespace Replay.Valorant.GameState;

public sealed class MulticastReceivePlayerTemporaryDeathEventBaseParameters : DamageParameters<MulticastReceivePlayerTemporaryDeathEventBaseParameters>
{
    public override string Path => "/Script/ShooterGame.ShooterGameState:MulticastReceivePlayerTemporaryDeathEvent_Base";
    public override ExportCategory Categories => ExportCategory.GameState | ExportCategory.Gunplay;
    public uint? DamagerPlayer { get; set; }
    public uint? DownedPlayer { get; set; }
    public uint? TemporaryDeathEquippableUsed { get; set; }
    public bool? RecoversInstantly { get; set; }

    protected override void Configure()
    {
        AddPropertyHandle(0, x => x.DamagerPlayer).ObjectNetGuid();
        AddPropertyHandle(1, x => x.DownedPlayer).ObjectNetGuid();
        AddSharedFields(2);
        AddPropertyHandle(28, "EquippableUsed", x => x.TemporaryDeathEquippableUsed).ObjectNetGuid();
        AddPropertyHandle(29, "bRecoversInstantly", x => x.RecoversInstantly).Bool();
    }
}
