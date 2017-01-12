using Terraria.ModLoader;

namespace ThrowingTables {
    class ThrowingTables : Mod {
        public ThrowingTables() {
            Properties = new ModProperties() {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
    }
}
