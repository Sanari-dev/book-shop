using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixDefaultProductSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1cb8e2b6-4bd2-4c50-9ecd-3e945510dd9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35452e29-df65-4ac6-b41a-faf04fdbfc98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cf1238d-33be-434a-bc79-99255d73eef9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f9c4a55-a4c5-4c81-b417-9eb105722952"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3ecee5a-11b3-44a1-a784-6f5c763fdc69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c174d420-c98c-493d-a0fa-e01375b53eac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1be874e6-f930-42a9-b7ff-2957318eaac7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("890cd36f-df26-4eac-a403-4ef841c950b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a503cb7e-6974-434f-a1cf-2ba0ffa0439f"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("1a2eb1b7-902a-4bc1-929a-fccb6519abe9"), 1, "Scifi" },
                    { new Guid("700de39e-a124-4240-ae02-a551818533ae"), 3, "History" },
                    { new Guid("d91ff484-726a-423b-8cf9-d65b1980ead2"), 2, "Action" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { new Guid("0cf2a92d-2568-4d0b-a42d-5b8e856a4979"), "Corey, James S. A.", new Guid("1a2eb1b7-902a-4bc1-929a-fccb6519abe9"), "<p>We are not alone. On Ganymede, breadbasket of the outer planets, a Martian marine watches as her platoon is slaughtered by a monstrous supersoldier. On Earth, a high-level politician struggles to prevent interplanetary war from reigniting. And on Venus, an alien protomolecule has overrun the planet, wreaking massive, mysterious changes and threatening to spread out into the solar system.<br><br>In the vast wilderness of space, James Holden and the crew of the&nbsp;<em>Rocinante</em> have been keeping the peace for the Outer Planets Alliance. When they agree to help a scientist search war-torn Ganymede for a missing child, the future of humanity rests on whether a single ship can prevent an alien invasion that may have already begun.</p>", "978-0-316-12906-0", "\\images\\product\\CalibansWar.jpg", 310000.0, 295000.0, 265000.0, 285000.0, "Caliban's War" },
                    { new Guid("1a6e1736-43b5-48b7-b72f-aff4e1ff5cb5"), "Corey, James S. A.", new Guid("1a2eb1b7-902a-4bc1-929a-fccb6519abe9"), "<p>The fifth novel in Corey's New York Times bestselling Expanse series--now being produced for television by the SyFy Channel!<br><br>A thousand worlds have opened, and the greatest land rush in human history has begun. As wave after wave of colonists leave, the power structures of the old solar system begin to buckle.<br><br>Ships are disappearing without a trace. Private armies are being secretly formed. The sole remaining protomolecule sample is stolen. Terrorist attacks previously considered impossible bring the inner planets to their knees. The sins of the past are returning to exact a terrible price.<br><br>And as a new human order is struggling to be born in blood and fire, James Holden and the crew of the Rocinante must struggle to survive and get back to the only home they have left.</p>", "978-0-316-21758-3", "\\images\\product\\NemesisGames.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Nemesis Games" },
                    { new Guid("4d0e22c5-9a93-46e6-afba-120071de35d8"), "Corey, James S. A.", new Guid("1a2eb1b7-902a-4bc1-929a-fccb6519abe9"), "<p>In the thousand-sun network of humanity's expansion, new colony worlds are struggling to find their way. Every new planet lives on a knife edge between collapse and wonder, and the crew of the aging gunship Rocinante have their hands more than full keeping the fragile peace.<br><br>In the vast space between Earth and Jupiter, the inner planets and belt have formed a tentative and uncertain alliance still haunted by a history of wars and prejudices. On the lost colony world of Laconia, a hidden enemy has a new vision for all of humanity and the power to enforce it.<br><br>New technologies clash with old as the history of human conflict returns to its ancient patterns of war and subjugation. But human nature is not the only enemy, and the forces being unleashed have their own price. A price that will change the shape of humanity -- and of the Rocinante -- unexpectedly and forever...</p>", "978-0-316-33283-5", "\\images\\product\\PersepolisRising.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Persepolis Rising	" },
                    { new Guid("53ab9566-115a-4f5d-914b-329a27fe7db6"), "Corey, James S. A.", new Guid("1a2eb1b7-902a-4bc1-929a-fccb6519abe9"), "<p>Thirteen hundred gates have opened to solar systems around the galaxy. But as humanity builds its interstellar empire in the alien ruins, the mysteries and threats grow deeper.<br><br>In the dead systems where gates lead to stranger things than alien planets, Elvi Okoye begins a desperate search to discover the nature of a genocide that happened before the first human beings existed, and to find weapons to fight a war against forces at the edge of the imaginable. But the price of that knowledge may be higher than she can pay.<br><br>At the heart of the empire, Teresa Duarte prepares to take on the burden of her father's godlike ambition. The sociopathic scientist Paolo Cort&aacute;zar and the Mephistophelian prisoner James Holden are only two of the dangers in a palace thick with intrigue, but Teresa has a mind of her own and secrets even her father the emperor doesn't guess.<br><br>And throughout the wide human empire, the scattered crew of the Rocinante fights a brave rear-guard action against Duarte's authoritarian regime. Memory of the old order falls away, and a future under Laconia's eternal rule -- and with it, a battle that humanity can only lose - seems more and more certain. Because against the terrors that lie between worlds, courage and ambition will not be enough...</p>", "978-0-316-33286-6", "\\images\\product\\TiamatsWrath.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Tiamat's Wrath" },
                    { new Guid("62fa40c8-ff17-4893-8c09-7ece6db8900b"), "Corey, James S. A.", new Guid("1a2eb1b7-902a-4bc1-929a-fccb6519abe9"), "<p>The gates have opened the way to thousands of habitable planets, and the land rush has begun. Settlers stream out from humanity's home planets in a vast, poorly controlled flood, landing on a new world. Among them, the Rocinante, haunted by the vast, posthuman network of the protomolecule as they investigate what destroyed the great intergalactic society that built the gates and the protomolecule.<br><br>But Holden and his crew must also contend with the growing tensions between the settlers and the company which owns the official claim to the planet. Both sides will stop at nothing to defend what's theirs, but soon a terrible disease strikes and only Holden - with help from the ghostly Detective Miller - can find the cure.</p>", "978-0-316-21762-0", "\\images\\product\\CibolaBurn.jpg", 270000.0, 260000.0, 240000.0, 250000.0, "Cibola Burn" },
                    { new Guid("aceacd8e-afbe-4535-97ae-96fabb6f7097"), "Corey, James S. A.", new Guid("1a2eb1b7-902a-4bc1-929a-fccb6519abe9"), "<p>A revolution brewing for generations has begun in fire. It will end in blood.</p>\r\n<p>The Free Navy - a violent group of Belters in black-market military ships - has crippled the Earth and begun a campaign of piracy and violence among the outer planets. The colony ships heading for the thousand new worlds on the far side of the alien ring gates are easy prey, and no single navy remains strong enough to protect them.</p>\r\n<p>James Holden and his crew know the strengths and weaknesses of this new force better than anyone. Outnumbered and outgunned, the embattled remnants of the old political powers call on the&nbsp;<em>Rocinante&nbsp;</em>for a desperate mission to reach Medina Station at the heart of the gate network.</p>\r\n<p>But the new alliances are as flawed as the old, and the struggle for power has only just begun. As the chaos grows, an alien mystery deepens. Pirate fleets, mutiny and betrayal may be the least of the&nbsp;<em>Rocinante</em>'s problems. And in the uncanny spaces past the ring gates, the choices of a few damaged and desperate people may determine the fate of more than just humanity.</p>", "978-0-316-33474-7", "\\images\\product\\BabylonsAshes.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Babylon's Ashes" },
                    { new Guid("ad501bb9-7651-417c-8acb-dafd9cc4a0a1"), "Corey, James S. A.", new Guid("1a2eb1b7-902a-4bc1-929a-fccb6519abe9"), "<p>Abaddon's Gate is the third book in the New York Times bestselling Expanse series.<br><br>For generations, the solar system - Mars, the Moon, the Asteroid Belt - was humanity's great frontier. Until now. The alien artefact working through its program under the clouds of Venus has emerged to build a massive structure outside the orbit of Uranus: a gate that leads into a starless dark.<br><br>Jim Holden and the crew of the Rocinante are part of a vast flotilla of scientific and military ships going out to examine the artefact. But behind the scenes, a complex plot is unfolding, with the destruction of Holden at its core. As the emissaries of the human race try to find whether the gate is an opportunity or a threat, the greatest danger is the one they brought with them.</p>", "978-0-316-12907-7", "\\images\\product\\AbaddonsGate.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Abaddon's Gate" },
                    { new Guid("e062b10d-e68f-44fe-97e1-a45f973247e3"), "Corey, James S. A.", new Guid("1a2eb1b7-902a-4bc1-929a-fccb6519abe9"), "<p>The Laconian Empire has fallen, setting the thirteen hundred solar systems free from the rule of Winston Duarte. But the ancient enemy that killed the gate builders is awake, and the war against our universe has begun again.<br><br>In the dead system of Adro, Elvi Okoye leads a desperate scientific mission to understand what the gate builders were and what destroyed them, even if it means compromising herself and the half-alien children who bear the weight of her investigation. Through the wide-flung systems of humanity, Colonel Aliana Tanaka hunts for Duarte&rsquo;s missing daughter. . . and the shattered emperor himself. And on the Rocinante, James Holden and his crew struggle to build a future for humanity out of the shards and ruins of all that has come before.<br><br>As nearly unimaginable forces prepare to annihilate all human life, Holden and a group of unlikely allies discover a last, desperate chance to unite all of humanity, with the promise of a vast galactic civilization free from wars, factions, lies, and secrets if they win.<br><br>But the price of victory may be worse than the cost of defeat.</p>", "978-0-316-33291-0", "\\images\\product\\LeviathanFalls.jpg", 330000.0, 320000.0, 300000.0, 310000.0, "Leviathan Falls" },
                    { new Guid("e99ac33f-0ee7-4f1e-b6d3-a0e06c2e7821"), "Corey, James S. A.", new Guid("1a2eb1b7-902a-4bc1-929a-fccb6519abe9"), "<p>Humanity has colonized the solar system&mdash;Mars, the Moon, the Asteroid Belt and beyond&mdash;but the stars are still out of our reach.<br><br>Jim Holden is XO of an ice miner making runs from the rings of Saturn to the mining stations of the Belt. When he and his crew stumble upon a derelict ship, the&nbsp;<em>Scopuli</em>, they find themselves in possession of a secret they never wanted. A secret that someone is willing to kill for&mdash;and kill on a scale unfathomable to Jim and his crew. War is brewing in the system unless he can find out who left the ship and why.<br><br>Detective Miller is looking for a girl. One girl in a system of billions, but her parents have money and money talks. When the trail leads him to the&nbsp;<em>Scopuli</em>&nbsp;and rebel sympathizer Holden, he realizes that this girl may be the key to everything.<br><br>Holden and Miller must thread the needle between the Earth government, the Outer Planet revolutionaries, and secretive corporations&mdash;and the odds are against them. But out in the Belt, the rules are different, and one small ship can change the fate of the universe.</p>", "978-0-316-12908-4", "\\images\\product\\LeviathanWakes.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Leviathan Wakes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("700de39e-a124-4240-ae02-a551818533ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d91ff484-726a-423b-8cf9-d65b1980ead2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0cf2a92d-2568-4d0b-a42d-5b8e856a4979"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a6e1736-43b5-48b7-b72f-aff4e1ff5cb5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d0e22c5-9a93-46e6-afba-120071de35d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53ab9566-115a-4f5d-914b-329a27fe7db6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62fa40c8-ff17-4893-8c09-7ece6db8900b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aceacd8e-afbe-4535-97ae-96fabb6f7097"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad501bb9-7651-417c-8acb-dafd9cc4a0a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e062b10d-e68f-44fe-97e1-a45f973247e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e99ac33f-0ee7-4f1e-b6d3-a0e06c2e7821"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a2eb1b7-902a-4bc1-929a-fccb6519abe9"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("1be874e6-f930-42a9-b7ff-2957318eaac7"), 1, "Scifi" },
                    { new Guid("890cd36f-df26-4eac-a403-4ef841c950b2"), 3, "History" },
                    { new Guid("a503cb7e-6974-434f-a1cf-2ba0ffa0439f"), 2, "Action" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { new Guid("1cb8e2b6-4bd2-4c50-9ecd-3e945510dd9f"), "Nancy Hoover", new Guid("a503cb7e-6974-434f-a1cf-2ba0ffa0439f"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", "", 40000.0, 30000.0, 20000.0, 25000.0, "Dark Skies" },
                    { new Guid("35452e29-df65-4ac6-b41a-faf04fdbfc98"), "Laura Phantom", new Guid("1be874e6-f930-42a9-b7ff-2957318eaac7"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", "", 25000.0, 23000.0, 20000.0, 22000.0, "Leaves and Wonders" },
                    { new Guid("4cf1238d-33be-434a-bc79-99255d73eef9"), "Ron Parker", new Guid("890cd36f-df26-4eac-a403-4ef841c950b2"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SOTJ1111111101", "", 30000.0, 27000.0, 20000.0, 25000.0, "Rock in the Ocean" },
                    { new Guid("6f9c4a55-a4c5-4c81-b417-9eb105722952"), "Abby Muscles", new Guid("1be874e6-f930-42a9-b7ff-2957318eaac7"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "WS3333333301", "", 70000.0, 65000.0, 55000.0, 60000.0, "Cotton Candy" },
                    { new Guid("a3ecee5a-11b3-44a1-a784-6f5c763fdc69"), "Julian Button", new Guid("a503cb7e-6974-434f-a1cf-2ba0ffa0439f"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "RITO5555501", "", 55000.0, 50000.0, 35000.0, 40000.0, "Vanish in the Sunset" },
                    { new Guid("c174d420-c98c-493d-a0fa-e01375b53eac"), "Billy Spark", new Guid("1be874e6-f930-42a9-b7ff-2957318eaac7"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", "", 99000.0, 90000.0, 80000.0, 85000.0, "Fortune of Time" }
                });
        }
    }
}
