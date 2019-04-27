using InfinityScript;

namespace CustomWeapon
{
    public class CustomWeapon : BaseScript
    {
        public CustomWeapon()
        {
            PlayerConnected += onPlayerConnected;
        }
        private static void onPlayerConnected(Entity player)
        {
            if (player.SessionTeam == "allies")
            {
                player.GiveWeapon("iw5_m60jugg_mp_thermal_silencer_camo07");
                player.SetPerk("specialty_lightweight", true, true);
                return;
            }
            player.SpawnedPlayer += () => onPlayerSpawned(player);
        }
        private static void onPlayerSpawned(Entity player)
        {
            if (player.SessionTeam == "allies")
            {
                player.GiveWeapon("iw5_m60jugg_mp_thermal_silencer_camo07");
                player.SetPerk("specialty_lightweight", true, true);
            }
        }
    }
}
