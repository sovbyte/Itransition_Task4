using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Itransition_Task4.Migrations
{
    /// <inheritdoc />
    public partial class SeedingWithBogus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConfirmationToken", "Email", "HashedPassword", "LastLoginTime", "Name", "RegistrationDate", "ResetToken", "Status" },
                values: new object[,]
                {
                    { 1, null, "Joyce72@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Marcel Connelly", new DateTime(2026, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 2, null, "Joaquin.Hammes@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Noemy Feest", new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 3, null, "Camylle_Borer53@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Rashad Mayert", new DateTime(2026, 3, 14, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 4, null, "Jorge30@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Caleb Ullrich", new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 5, null, "Nelda2@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Abel Leuschke", new DateTime(2026, 3, 21, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 6, null, "Olin.Green@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Lisandro Buckridge", new DateTime(2026, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 7, null, "Meghan1@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Jordyn Bechtelar", new DateTime(2026, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 8, null, "Jamaal.Anderson51@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Annette Raynor", new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 9, null, "Anika91@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Rhoda Ankunding", new DateTime(2026, 2, 17, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 10, null, "Gail_Conroy@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Garrett Morissette", new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 11, null, "Murray_Aufderhar33@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Eli Upton", new DateTime(2026, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 12, null, "Oral21@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Beatrice Klein", new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 13, null, "Michaela_Green@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Wyman Runolfsson", new DateTime(2026, 1, 4, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 14, null, "Daisha21@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Ezekiel Ward", new DateTime(2026, 2, 13, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 15, null, "Bennett75@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Augustus Zemlak", new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 16, null, "Davin.Walter54@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Allie Spencer", new DateTime(2026, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 17, null, "Aletha_Feeney78@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Claudine Gulgowski", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 18, null, "Kayley59@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Ciara Grimes", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 19, null, "Jalyn_Littel12@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Irving Heidenreich", new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 20, null, "Guido.McLaughlin@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Cheyenne Weimann", new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 21, null, "Karelle_Morissette74@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Sigmund D'Amore", new DateTime(2026, 2, 4, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 22, null, "Shyann27@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Jules Schneider", new DateTime(2026, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 23, null, "Quinten_Thompson94@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Lucie Bode", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 24, null, "Cory_Nicolas@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Vladimir Crist", new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 25, null, "Cole_Lehner19@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Fatima Lebsack", new DateTime(2026, 1, 7, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 26, null, "Celestine88@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Ana Emard", new DateTime(2026, 2, 7, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 27, null, "Zora.Hermiston18@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Jacey Runolfsdottir", new DateTime(2026, 3, 2, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 28, null, "Ariel.Kovacek91@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Lera Howell", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 29, null, "Aidan_Toy@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Agnes Gusikowski", new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 30, null, "Alexandra.Heaney@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Elenor Weimann", new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 31, null, "Lelah.Nolan@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Freda Heathcote", new DateTime(2026, 1, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 32, null, "Wilfred57@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Bridget Spinka", new DateTime(2026, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 33, null, "Tyrell.Davis@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Christa Nolan", new DateTime(2026, 3, 8, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 34, null, "Helena79@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Sabina Hermiston", new DateTime(2026, 2, 24, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 35, null, "Wellington31@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Margarett Jenkins", new DateTime(2026, 3, 24, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 36, null, "Neva_Klein85@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Matteo Hamill", new DateTime(2026, 2, 12, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 37, null, "Gust.Abbott30@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Hector Cruickshank", new DateTime(2026, 3, 14, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 38, null, "Philip_Kohler50@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Harold Boyer", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 39, null, "Rory6@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Sharon Nader", new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 40, null, "Cara37@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Linwood VonRueden", new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 41, null, "Terence.Shields59@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Macy Bahringer", new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 42, null, "Abbey53@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Edwin Little", new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 43, null, "Sienna_Herman@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Milo Turcotte", new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 44, null, "Asia_Schmeler18@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Trudie Schroeder", new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 45, null, "Sven82@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Rachel Schultz", new DateTime(2026, 2, 28, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 46, null, "Rosella.Heidenreich10@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Terrill VonRueden", new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 47, null, "Alexandra.Luettgen@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Sharon Langworth", new DateTime(2026, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 48, null, "Jamal_Homenick@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Neal Buckridge", new DateTime(2026, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 49, null, "Justus87@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Zane Kshlerin", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 50, null, "Hailee.Simonis82@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Violet Halvorson", new DateTime(2026, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 51, null, "Shad_Connelly@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Otis Towne", new DateTime(2026, 3, 19, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 52, null, "Frederique10@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Jacey Pagac", new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 53, null, "Candido.Murazik81@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Felipe Koss", new DateTime(2026, 2, 4, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 54, null, "Kay92@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Eddie Goyette", new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 55, null, "Hilma47@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Lee Kreiger", new DateTime(2026, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 56, null, "Miracle.Hodkiewicz@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Unique Boyle", new DateTime(2026, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 57, null, "Judson.Hansen@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Lois Gislason", new DateTime(2026, 2, 19, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 58, null, "Dandre.Emard89@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Alvah Casper", new DateTime(2026, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 59, null, "Cara_Marquardt86@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Alisa Stoltenberg", new DateTime(2026, 2, 27, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 60, null, "Bradly12@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Steve Stroman", new DateTime(2026, 1, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 61, null, "Lynn.Murazik@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Camille Friesen", new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 62, null, "Jedediah94@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Shayne Mante", new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 63, null, "Jaiden61@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Bernard Turner", new DateTime(2026, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 64, null, "Teresa81@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Alysha Beahan", new DateTime(2026, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 65, null, "Mohammad14@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Shaun Effertz", new DateTime(2026, 2, 18, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 66, null, "Alize_Daugherty1@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Corbin Johns", new DateTime(2026, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 67, null, "Alice3@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Maryjane Kirlin", new DateTime(2026, 2, 19, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 68, null, "Marguerite.Mueller7@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Viviane Windler", new DateTime(2026, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 69, null, "Reta.Roob@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Harmony Pollich", new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 70, null, "Ladarius.Renner@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Sarah Lind", new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 71, null, "Jacynthe.Prohaska@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Chandler Hills", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 72, null, "Bethany_Mosciski@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Name Ritchie", new DateTime(2026, 2, 24, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 73, null, "Lorena.Thompson@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Gardner Muller", new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 74, null, "Ashly10@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Noemi Hirthe", new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 75, null, "Makenna45@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Tabitha Wilkinson", new DateTime(2026, 1, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 76, null, "Marcella.Will82@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Rahul Roob", new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 77, null, "Hobart.Brown13@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Kane Kuhn", new DateTime(2026, 3, 8, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 78, null, "Michael_Rippin54@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Elta Boyle", new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 79, null, "Floyd.Emmerich9@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Tiara Dare", new DateTime(2026, 3, 18, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 80, null, "Elvie87@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Alfonso Mohr", new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 81, null, "Allen_Rutherford74@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Vicente Mante", new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 82, null, "Bernita.Hagenes3@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Darren Sawayn", new DateTime(2026, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 83, null, "Milford_OReilly@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Dorthy Ortiz", new DateTime(2026, 3, 12, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 84, null, "Jannie.OReilly82@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Felipa Kassulke", new DateTime(2026, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 85, null, "Richard96@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Larue Lakin", new DateTime(2026, 2, 20, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 86, null, "Doyle60@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Marco Kilback", new DateTime(2026, 2, 12, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 87, null, "Anissa85@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Germaine Hodkiewicz", new DateTime(2026, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 88, null, "Ansley35@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Elta Spinka", new DateTime(2026, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 89, null, "Kade20@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Chyna Spencer", new DateTime(2026, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 90, null, "Carolyne_Berge@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Ferne Corkery", new DateTime(2026, 3, 18, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 91, null, "Alphonso_Wolff@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Julien Lehner", new DateTime(2026, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 92, null, "Obie60@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Bridget Mills", new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 93, null, "Anissa79@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Haylee Stark", new DateTime(2026, 2, 7, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 94, null, "Stephany.Flatley@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Morgan Cormier", new DateTime(2026, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 95, null, "Evie40@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Peggie Conroy", new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 96, null, "Karen.Macejkovic@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Royal McGlynn", new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 },
                    { 97, null, "Nyasia.Fritsch@hotmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Arden Kohler", new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Utc), null, 0 },
                    { 98, null, "Pearl55@yahoo.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Stevie Feil", new DateTime(2026, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 99, null, "Lulu.Okuneva93@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Kylie Bins", new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, 2 },
                    { 100, null, "Sim39@gmail.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", null, "Cierra McLaughlin", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), null, 1 }
                });
            migrationBuilder.Sql("SELECT setval(pg_get_serial_sequence('\"Users\"', 'Id'), (SELECT MAX(Id) FROM Users));");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
