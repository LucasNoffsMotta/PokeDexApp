namespace PokeDexApp
{
    partial class PokeDex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblTypeOne = new Label();
            lblTypeTwo = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            lblNumber = new Label();
            lblLbl = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblHP = new Label();
            lblATK = new Label();
            lblSPATK = new Label();
            lblDEF = new Label();
            lblSPDEF = new Label();
            lblSPD = new Label();
            button1 = new Button();
            txtSearch = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblTotal = new Label();
            btnLogOut = new Button();
            btnAdd = new Button();
            btnMyPokes = new Button();
            label11 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnNextTop = new Button();
            btnPrevTop = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            btnFirstTop = new Button();
            btnSecondTop = new Button();
            btnThirdTop = new Button();
            btnFourthTop = new Button();
            btnFifithTop = new Button();
            lblCurrentTop = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(513, 14);
            lblName.Name = "lblName";
            lblName.Size = new Size(113, 42);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblTypeOne
            // 
            lblTypeOne.AutoSize = true;
            lblTypeOne.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTypeOne.Location = new Point(502, 201);
            lblTypeOne.Name = "lblTypeOne";
            lblTypeOne.Size = new Size(90, 23);
            lblTypeOne.TabIndex = 1;
            lblTypeOne.Text = "TypeOne";
            // 
            // lblTypeTwo
            // 
            lblTypeTwo.AutoSize = true;
            lblTypeTwo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTypeTwo.Location = new Point(623, 201);
            lblTypeTwo.Name = "lblTypeTwo";
            lblTypeTwo.Size = new Size(90, 23);
            lblTypeTwo.TabIndex = 2;
            lblTypeTwo.Text = "TypeTwo";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(648, 702);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(195, 39);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrev.Location = new Point(116, 699);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(203, 39);
            btnPrev.TabIndex = 4;
            btnPrev.Text = "Previous";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.FlatStyle = FlatStyle.System;
            lblNumber.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(424, 19);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(83, 35);
            lblNumber.TabIndex = 5;
            lblNumber.Text = "1000";
            // 
            // lblLbl
            // 
            lblLbl.AutoSize = true;
            lblLbl.FlatStyle = FlatStyle.System;
            lblLbl.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLbl.Location = new Point(386, 19);
            lblLbl.Name = "lblLbl";
            lblLbl.Size = new Size(32, 35);
            lblLbl.TabIndex = 6;
            lblLbl.Text = "#";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(544, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 245);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 8;
            label1.Text = "Base Stats:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(426, 304);
            label2.Name = "label2";
            label2.Size = new Size(39, 28);
            label2.TabIndex = 9;
            label2.Text = "HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(415, 357);
            label3.Name = "label3";
            label3.Size = new Size(50, 28);
            label3.TabIndex = 10;
            label3.Text = "ATK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(386, 407);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 11;
            label4.Text = "SP ATK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(417, 453);
            label5.Name = "label5";
            label5.Size = new Size(48, 28);
            label5.TabIndex = 12;
            label5.Text = "DEF";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(388, 504);
            label6.Name = "label6";
            label6.Size = new Size(77, 28);
            label6.TabIndex = 13;
            label6.Text = "SP DEF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(415, 558);
            label7.Name = "label7";
            label7.Size = new Size(50, 28);
            label7.TabIndex = 14;
            label7.Text = "SPD";
            // 
            // lblHP
            // 
            lblHP.AutoSize = true;
            lblHP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHP.Location = new Point(530, 304);
            lblHP.Name = "lblHP";
            lblHP.Size = new Size(21, 28);
            lblHP.TabIndex = 15;
            lblHP.Text = "*";
            lblHP.Click += lblHP_Click;
            // 
            // lblATK
            // 
            lblATK.AutoSize = true;
            lblATK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblATK.Location = new Point(530, 357);
            lblATK.Name = "lblATK";
            lblATK.Size = new Size(21, 28);
            lblATK.TabIndex = 16;
            lblATK.Text = "*";
            // 
            // lblSPATK
            // 
            lblSPATK.AutoSize = true;
            lblSPATK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSPATK.Location = new Point(530, 407);
            lblSPATK.Name = "lblSPATK";
            lblSPATK.Size = new Size(21, 28);
            lblSPATK.TabIndex = 17;
            lblSPATK.Text = "*";
            // 
            // lblDEF
            // 
            lblDEF.AutoSize = true;
            lblDEF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDEF.Location = new Point(530, 453);
            lblDEF.Name = "lblDEF";
            lblDEF.Size = new Size(21, 28);
            lblDEF.TabIndex = 18;
            lblDEF.Text = "*";
            // 
            // lblSPDEF
            // 
            lblSPDEF.AutoSize = true;
            lblSPDEF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSPDEF.Location = new Point(530, 504);
            lblSPDEF.Name = "lblSPDEF";
            lblSPDEF.Size = new Size(21, 28);
            lblSPDEF.TabIndex = 19;
            lblSPDEF.Text = "*";
            // 
            // lblSPD
            // 
            lblSPD.AutoSize = true;
            lblSPD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSPD.Location = new Point(530, 558);
            lblSPD.Name = "lblSPD";
            lblSPD.Size = new Size(21, 28);
            lblSPD.TabIndex = 20;
            lblSPD.Text = "*";
            // 
            // button1
            // 
            button1.Location = new Point(37, 102);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSearch
            // 
            txtSearch.FormattingEnabled = true;
            txtSearch.Items.AddRange(new object[] { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran?", "Nidorina", "Nidoqueen", "Nidoran?", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetchd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew", "Chikorita", "Bayleef", "Meganium", "Cyndaquil", "Quilava", "Typhlosion", "Totodile", "Croconaw", "Feraligatr", "Sentret", "Furret", "Hoothoot", "Noctowl", "Ledyba", "Ledian", "Spinarak", "Ariados", "Crobat", "Chinchou", "Lanturn", "Pichu", "Cleffa", "Igglybuff", "Togepi", "Togetic", "Natu", "Xatu", "Mareep", "Flaaffy", "Ampharos", "Bellossom", "Marill", "Azumarill", "Sudowoodo", "Politoed", "Hoppip", "Skiploom", "Jumpluff", "Aipom", "Sunkern", "Sunflora", "Yanma", "Wooper", "Quagsire", "Espeon", "Umbreon", "Murkrow", "Slowking", "Misdreavus", "Unown", "Wobbuffet", "Girafarig", "Pineco", "Forretress", "Dunsparce", "Gligar", "Steelix", "Snubbull", "Granbull", "Qwilfish", "Scizor", "Shuckle", "Heracross", "Sneasel", "Teddiursa", "Ursaring", "Slugma", "Magcargo", "Swinub", "Piloswine", "Corsola", "Remoraid", "Octillery", "Delibird", "Mantine", "Skarmory", "Houndour", "Houndoom", "Kingdra", "Phanpy", "Donphan", "Porygon2", "Stantler", "Smeargle", "Tyrogue", "Hitmontop", "Smoochum", "Elekid", "Magby", "Miltank", "Blissey", "Raikou", "Entei", "Suicune", "Larvitar", "Pupitar", "Tyranitar", "Lugia", "Ho-oh", "Celebi", "Treecko", "Grovyle", "Sceptile", "Torchic", "Combusken", "Blaziken", "Mudkip", "Marshtomp", "Swampert", "Poochyena", "Mightyena", "Zigzagoon", "Linoone", "Wurmple", "Silcoon", "Beautifly", "Cascoon", "Dustox", "Lotad", "Lombre", "Ludicolo", "Seedot", "Nuzleaf", "Shiftry", "Taillow", "Swellow", "Wingull", "Pelipper", "Ralts", "Kirlia", "Gardevoir", "Surskit", "Masquerain", "Shroomish", "Breloom", "Slakoth", "Vigoroth", "Slaking", "Nincada", "Ninjask", "Shedinja", "Whismur", "Loudred", "Exploud", "Makuhita", "Hariyama", "Azurill", "Nosepass", "Skitty", "Delcatty", "Sableye", "Mawile", "Aron", "Lairon", "Aggron", "Meditite", "Medicham", "Electrike", "Manectric", "Plusle", "Minun", "Volbeat", "Illumise", "Roselia", "Gulpin", "Swalot", "Carvanha", "Sharpedo", "Wailmer", "Wailord", "Numel", "Camerupt", "Torkoal", "Spoink", "Grumpig", "Spinda", "Trapinch", "Vibrava", "Flygon", "Cacnea", "Cacturne", "Swablu", "Altaria", "Zangoose", "Seviper", "Lunatone", "Solrock", "Barboach", "Whiscash", "Corphish", "Crawdaunt", "Baltoy", "Claydol", "Lileep", "Cradily", "Anorith", "Armaldo", "Feebas", "Milotic", "Castform", "Kecleon", "Shuppet", "Banette", "Duskull", "Dusclops", "Tropius", "Chimecho", "Absol", "Wynaut", "Snorunt", "Glalie", "Spheal", "Sealeo", "Walrein", "Clamperl", "Huntail", "Gorebyss", "Relicanth", "Luvdisc", "Bagon", "Shelgon", "Salamence", "Beldum", "Metang", "Metagross", "Regirock", "Regice", "Registeel", "Latias", "Latios", "Kyogre", "Groudon", "Rayquaza", "Jirachi", "Deoxys Normal Forme", "Turtwig", "Grotle", "Torterra", "Chimchar", "Monferno", "Infernape", "Piplup", "Prinplup", "Empoleon", "Starly", "Staravia", "Staraptor", "Bidoof", "Bibarel", "Kricketot", "Kricketune", "Shinx", "Luxio", "Luxray", "Budew", "Roserade", "Cranidos", "Rampardos", "Shieldon", "Bastiodon", "Burmy Plant Cloak", "Wormadam Plant Cloak", "Mothim", "Combee", "Vespiquen", "Pachirisu", "Buizel", "Floatzel", "Cherubi", "Cherrim", "Shellos", "Gastrodon", "Ambipom", "Drifloon", "Drifblim", "Buneary", "Lopunny", "Mismagius", "Honchkrow", "Glameow", "Purugly", "Chingling", "Stunky", "Skuntank", "Bronzor", "Bronzong", "Bonsly", "Mime Jr.", "Happiny", "Chatot", "Spiritomb", "Gible", "Gabite", "Garchomp", "Munchlax", "Riolu", "Lucario", "Hippopotas", "Hippowdon", "Skorupi", "Drapion", "Croagunk", "Toxicroak", "Carnivine", "Finneon", "Lumineon", "Mantyke", "Snover", "Abomasnow", "Weavile", "Magnezone", "Lickilicky", "Rhyperior", "Tangrowth", "Electivire", "Magmortar", "Togekiss", "Yanmega", "Leafeon", "Glaceon", "Gliscor", "Mamoswine", "Porygon-Z", "Gallade", "Probopass", "Dusknoir", "Froslass", "Rotom", "Uxie", "Mesprit", "Azelf", "Dialga", "Palkia", "Heatran", "Regigigas", "Giratina Altered Forme", "Cresselia", "Phione", "Manaphy", "Darkrai", "Shaymin Land Forme", "Arceus", "Victini", "Snivy", "Servine", "Serperior", "Tepig", "Pignite", "Emboar", "Oshawott", "Dewott", "Samurott", "Patrat", "Watchog", "Lillipup", "Herdier", "Stoutland", "Purrloin", "Liepard", "Pansage", "Simisage", "Pansear", "Simisear", "Panpour", "Simipour", "Munna", "Musharna", "Pidove", "Tranquill", "Unfezant", "Blitzle", "Zebstrika", "Roggenrola", "Boldore", "Gigalith", "Woobat", "Swoobat", "Drilbur", "Excadrill", "Audino", "Timburr", "Gurdurr", "Conkeldurr", "Tympole", "Palpitoad", "Seismitoad", "Throh", "Sawk", "Sewaddle", "Swadloon", "Leavanny", "Venipede", "Whirlipede", "Scolipede", "Cottonee", "Whimsicott", "Petilil", "Lilligant", "Basculin Red-Striped Form", "Sandile", "Krokorok", "Krookodile", "Darumaka", "Darmanitan Standard Mode", "Maractus", "Dwebble", "Crustle", "Scraggy", "Scrafty", "Sigilyph", "Yamask", "Cofagrigus", "Tirtouga", "Carracosta", "Archen", "Archeops", "Trubbish", "Garbodor", "Zorua", "Zoroark", "Minccino", "Cinccino", "Gothita", "Gothorita", "Gothitelle", "Solosis", "Duosion", "Reuniclus", "Ducklett", "Swanna", "Vanillite", "Vanillish", "Vanilluxe", "Deerling", "Sawsbuck", "Emolga", "Karrablast", "Escavalier", "Foongus", "Amoonguss", "Frillish", "Jellicent", "Alomomola", "Joltik", "Galvantula", "Ferroseed", "Ferrothorn", "Klink", "Klang", "Klinklang", "Tynamo", "Eelektrik", "Eelektross", "Elgyem", "Beheeyem", "Litwick", "Lampent", "Chandelure", "Axew", "Fraxure", "Haxorus", "Cubchoo", "Beartic", "Cryogonal", "Shelmet", "Accelgor", "Stunfisk", "Mienfoo", "Mienshao", "Druddigon", "Golett", "Golurk", "Pawniard", "Bisharp", "Bouffalant", "Rufflet", "Braviary", "Vullaby", "Mandibuzz", "Heatmor", "Durant", "Deino", "Zweilous", "Hydreigon", "Larvesta", "Volcarona", "Cobalion", "Terrakion", "Virizion", "Tornadus Incarnate Forme", "Thundurus Incarnate Forme", "Reshiram", "Zekrom", "Landorus Incarnate Forme", "Kyurem", "Keldeo Ordinary Form", "Meloetta Aria Forme", "Genesect", "Chespin", "Quilladin", "Chesnaught", "Fennekin", "Braixen", "Delphox", "Froakie", "Frogadier", "Greninja", "Bunnelby", "Diggersby", "Fletchling", "Fletchinder", "Talonflame", "Scatterbug", "Spewpa", "Vivillon", "Litleo", "Pyroar", "Flabébé", "Floette", "Florges", "Skiddo", "Gogoat", "Pancham", "Pangoro", "Furfrou", "Espurr", "Meowstic Male", "Honedge", "Doublade", "Aegislash Shield Forme", "Spritzee", "Aromatisse", "Swirlix", "Slurpuff", "Inkay", "Malamar", "Binacle", "Barbaracle", "Skrelp", "Dragalge", "Clauncher", "Clawitzer", "Helioptile", "Heliolisk", "Tyrunt", "Tyrantrum", "Amaura", "Aurorus", "Sylveon", "Hawlucha", "Dedenne", "Carbink", "Goomy", "Sliggoo", "Goodra", "Klefki", "Phantump", "Trevenant", "Pumpkaboo Average Size", "Gourgeist Average Size", "Bergmite", "Avalugg", "Noibat", "Noivern", "Xerneas", "Yveltal", "Zygarde 50% Forme", "Diancie", "Hoopa Hoopa Confined", "Volcanion", "Rowlet", "Dartrix", "Decidueye", "Litten", "Torracat", "Incineroar", "Popplio", "Brionne", "Primarina", "Pikipek", "Trumbeak", "Toucannon", "Yungoos", "Gumshoos", "Grubbin", "Charjabug", "Vikavolt", "Crabrawler", "Crabominable", "Oricorio Baile Style", "Cutiefly", "Ribombee", "Rockruff", "Lycanroc Midday Form", "Wishiwashi Solo Form", "Mareanie", "Toxapex", "Mudbray", "Mudsdale", "Dewpider", "Araquanid", "Fomantis", "Lurantis", "Morelull", "Shiinotic", "Salandit", "Salazzle", "Stufful", "Bewear", "Bounsweet", "Steenee", "Tsareena", "Comfey", "Oranguru", "Passimian", "Wimpod", "Golisopod", "Sandygast", "Palossand", "Pyukumuku", "Type: Null", "Silvally", "Minior Meteor Form", "Komala", "Turtonator", "Togedemaru", "Mimikyu", "Bruxish", "Drampa", "Dhelmise", "Jangmo-o", "Hakamo-o", "Kommo-o", "Tapu Koko", "Tapu Lele", "Tapu Bulu", "Tapu Fini", "Cosmog", "Cosmoem", "Solgaleo", "Lunala", "Nihilego", "Buzzwole", "Pheromosa", "Xurkitree", "Celesteela", "Kartana", "Guzzlord", "Necrozma", "Magearna", "Marshadow", "Poipole", "Naganadel", "Stakataka", "Blacephalon", "Zeraora", "Meltan", "Melmetal", "Grookey", "Thwackey", "Rillaboom", "Scorbunny", "Raboot", "Cinderace", "Sobble", "Drizzile", "Inteleon", "Skwovet", "Greedent", "Rookidee", "Corvisquire", "Corviknight", "Blipbug", "Dottler", "Orbeetle", "Nickit", "Thievul", "Gossifleur", "Eldegoss", "Wooloo", "Dubwool", "Chewtle", "Drednaw", "Yamper", "Boltund", "Rolycoly", "Carkol", "Coalossal", "Applin", "Flapple", "Appletun", "Silicobra", "Sandaconda", "Cramorant", "Arrokuda", "Barraskewda", "Toxel", "Toxtricity Amped Form", "Sizzlipede", "Centiskorch", "Clobbopus", "Grapploct", "Sinistea", "Polteageist", "Hatenna", "Hattrem", "Hatterene", "Impidimp", "Morgrem", "Grimmsnarl", "Obstagoon", "Perrserker", "Cursola", "Sirfetchd", "Mr. Rime", "Runerigus", "Milcery", "Alcremie", "Falinks", "Pincurchin", "Snom", "Frosmoth", "Stonjourner", "Eiscue Ice Face", "Indeedee Male", "Morpeko Full Belly Mode", "Cufant", "Copperajah", "Dracozolt", "Arctozolt", "Dracovish", "Arctovish", "Duraludon", "Dreepy", "Drakloak", "Dragapult", "Zacian Hero of Many Battles", "Zamazenta Hero of Many Battles", "Eternatus", "Kubfu", "Urshifu Single Strike Style", "Zarude", "Regieleki", "Regidrago", "Glastrier", "Spectrier", "Calyrex", "Wyrdeer", "Kleavor", "Ursaluna", "Basculegion Male", "Sneasler", "Overqwil", "Enamorus Incarnate Forme", "Sprigatito", "Floragato", "Meowscarada", "Fuecoco", "Crocalor", "Skeledirge", "Quaxly", "Quaxwell", "Quaquaval", "Lechonk", "Oinkologne Male", "Tarountula", "Spidops", "Nymble", "Lokix", "Pawmi", "Pawmo", "Pawmot", "Tandemaus", "Maushold Family of Four", "Fidough", "Dachsbun", "Smoliv", "Dolliv", "Arboliva", "Squawkabilly Green Plumage", "Nacli", "Naclstack", "Garganacl", "Charcadet", "Armarouge", "Ceruledge", "Tadbulb", "Bellibolt", "Wattrel", "Kilowattrel", "Maschiff", "Mabosstiff", "Shroodle", "Grafaiai", "Bramblin", "Brambleghast", "Toedscool", "Toedscruel", "Klawf", "Capsakid", "Scovillain", "Rellor", "Rabsca", "Flittle", "Espathra", "Tinkatink", "Tinkatuff", "Tinkaton", "Wiglett", "Wugtrio", "Bombirdier", "Finizen", "Palafin Zero Form", "Varoom", "Revavroom", "Cyclizar", "Orthworm", "Glimmet", "Glimmora", "Greavard", "Houndstone", "Flamigo", "Cetoddle", "Cetitan", "Veluza", "Dondozo", "Tatsugiri Curly Form", "Annihilape", "Clodsire", "Farigiraf", "Dudunsparce Two-Segment Form", "Kingambit", "Great Tusk", "Scream Tail", "Brute Bonnet", "Flutter Mane", "Slither Wing", "Sandy Shocks", "Iron Treads", "Iron Bundle", "Iron Hands", "Iron Jugulis", "Iron Moth", "Iron Thorns", "Frigibax", "Arctibax", "Baxcalibur", "Gimmighoul Chest Form", "Gholdengo" });
            txtSearch.Location = new Point(37, 68);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(236, 28);
            txtSearch.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(408, 196);
            label8.Name = "label8";
            label8.Size = new Size(57, 28);
            label8.TabIndex = 24;
            label8.Text = "Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(37, 26);
            label9.Name = "label9";
            label9.Size = new Size(73, 28);
            label9.TabIndex = 25;
            label9.Text = "Name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(406, 612);
            label10.Name = "label10";
            label10.Size = new Size(59, 28);
            label10.TabIndex = 26;
            label10.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(530, 612);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(21, 28);
            lblTotal.TabIndex = 27;
            lblTotal.Text = "*";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(877, 764);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(134, 38);
            btnLogOut.TabIndex = 28;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(739, 59);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 62);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMyPokes
            // 
            btnMyPokes.Location = new Point(877, 703);
            btnMyPokes.Name = "btnMyPokes";
            btnMyPokes.Size = new Size(134, 38);
            btnMyPokes.TabIndex = 30;
            btnMyPokes.Text = "My Pokemons";
            btnMyPokes.UseVisualStyleBackColor = true;
            btnMyPokes.Click += btnMyPokes_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(138, 196);
            label11.Name = "label11";
            label11.Size = new Size(64, 28);
            label11.TabIndex = 31;
            label11.Text = "Top 5";
            // 
            // btnNextTop
            // 
            btnNextTop.Location = new Point(238, 243);
            btnNextTop.Name = "btnNextTop";
            btnNextTop.Size = new Size(35, 29);
            btnNextTop.TabIndex = 33;
            btnNextTop.Text = ">";
            btnNextTop.UseVisualStyleBackColor = true;
            btnNextTop.Click += btnNextTop_Click;
            // 
            // btnPrevTop
            // 
            btnPrevTop.Location = new Point(37, 244);
            btnPrevTop.Name = "btnPrevTop";
            btnPrevTop.Size = new Size(35, 29);
            btnPrevTop.TabIndex = 34;
            btnPrevTop.Text = "<";
            btnPrevTop.UseVisualStyleBackColor = true;
            btnPrevTop.Click += btnPrevTop_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(37, 322);
            label12.Name = "label12";
            label12.Size = new Size(27, 20);
            label12.TabIndex = 35;
            label12.Text = "1#";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(37, 386);
            label13.Name = "label13";
            label13.Size = new Size(27, 20);
            label13.TabIndex = 36;
            label13.Text = "2#";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(37, 453);
            label14.Name = "label14";
            label14.Size = new Size(27, 20);
            label14.TabIndex = 37;
            label14.Text = "3#";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.Location = new Point(37, 521);
            label15.Name = "label15";
            label15.Size = new Size(27, 20);
            label15.TabIndex = 38;
            label15.Text = "4#";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.Location = new Point(37, 595);
            label16.Name = "label16";
            label16.Size = new Size(27, 20);
            label16.TabIndex = 39;
            label16.Text = "5#";
            // 
            // btnFirstTop
            // 
            btnFirstTop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFirstTop.Location = new Point(87, 318);
            btnFirstTop.Name = "btnFirstTop";
            btnFirstTop.Size = new Size(172, 29);
            btnFirstTop.TabIndex = 45;
            btnFirstTop.Text = "name";
            btnFirstTop.UseVisualStyleBackColor = true;
            btnFirstTop.Click += btnFirstTop_Click;
            // 
            // btnSecondTop
            // 
            btnSecondTop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSecondTop.Location = new Point(87, 386);
            btnSecondTop.Name = "btnSecondTop";
            btnSecondTop.Size = new Size(172, 29);
            btnSecondTop.TabIndex = 46;
            btnSecondTop.Text = "name";
            btnSecondTop.UseVisualStyleBackColor = true;
            btnSecondTop.Click += btnSecondTop_Click;
            // 
            // btnThirdTop
            // 
            btnThirdTop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThirdTop.Location = new Point(87, 456);
            btnThirdTop.Name = "btnThirdTop";
            btnThirdTop.Size = new Size(172, 29);
            btnThirdTop.TabIndex = 47;
            btnThirdTop.Text = "name";
            btnThirdTop.UseVisualStyleBackColor = true;
            btnThirdTop.Click += btnThirdTop_Click;
            // 
            // btnFourthTop
            // 
            btnFourthTop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFourthTop.Location = new Point(87, 521);
            btnFourthTop.Name = "btnFourthTop";
            btnFourthTop.Size = new Size(172, 29);
            btnFourthTop.TabIndex = 48;
            btnFourthTop.Text = "name";
            btnFourthTop.UseVisualStyleBackColor = true;
            btnFourthTop.Click += btnFourthTop_Click;
            // 
            // btnFifithTop
            // 
            btnFifithTop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFifithTop.Location = new Point(87, 586);
            btnFifithTop.Name = "btnFifithTop";
            btnFifithTop.Size = new Size(172, 29);
            btnFifithTop.TabIndex = 49;
            btnFifithTop.Text = "name";
            btnFifithTop.UseVisualStyleBackColor = true;
            btnFifithTop.Click += btnFifithTop_Click;
            // 
            // lblCurrentTop
            // 
            lblCurrentTop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCurrentTop.Location = new Point(78, 242);
            lblCurrentTop.Name = "lblCurrentTop";
            lblCurrentTop.Size = new Size(154, 30);
            lblCurrentTop.TabIndex = 50;
            lblCurrentTop.Text = "*";
            lblCurrentTop.UseVisualStyleBackColor = true;
            lblCurrentTop.Click += lblCurrentTop_Click;
            // 
            // PokeDex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 814);
            Controls.Add(lblCurrentTop);
            Controls.Add(btnFifithTop);
            Controls.Add(btnFourthTop);
            Controls.Add(btnThirdTop);
            Controls.Add(btnSecondTop);
            Controls.Add(btnFirstTop);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(btnPrevTop);
            Controls.Add(btnNextTop);
            Controls.Add(label11);
            Controls.Add(btnMyPokes);
            Controls.Add(btnAdd);
            Controls.Add(btnLogOut);
            Controls.Add(lblTotal);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Controls.Add(lblSPD);
            Controls.Add(lblSPDEF);
            Controls.Add(lblDEF);
            Controls.Add(lblSPATK);
            Controls.Add(lblATK);
            Controls.Add(lblHP);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblLbl);
            Controls.Add(lblNumber);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(lblTypeTwo);
            Controls.Add(lblTypeOne);
            Controls.Add(lblName);
            Name = "PokeDex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseClick += PokeDex_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblTypeOne;
        private Label lblTypeTwo;
        private Button btnNext;
        private Button btnPrev;
        private Label lblNumber;
        private Label lblLbl;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblHP;
        private Label lblATK;
        private Label lblSPATK;
        private Label lblDEF;
        private Label lblSPDEF;
        private Label lblSPD;
        private Button button1;
        private ComboBox txtSearch;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblTotal;
        private Button btnLogOut;
        private Button btnAdd;
        private Button btnMyPokes;
        private Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnNextTop;
        private Button btnPrevTop;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button btnFirstTop;
        private Button btnSecondTop;
        private Button btnThirdTop;
        private Button btnFourthTop;
        private Button btnFifithTop;
        private Button lblCurrentTop;
    }
}
