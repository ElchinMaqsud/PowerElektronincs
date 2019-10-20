using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Bc04040404 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 70, nullable: false),
                    PhotoUrl = table.Column<string>(nullable: true),
                    Info = table.Column<string>(maxLength: 370, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OperatorNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marks_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(maxLength: 100, nullable: true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    PhotoUrl = table.Column<string>(nullable: true),
                    OperatorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Operators_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Operators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    MarkId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Marks_MarkId",
                        column: x => x.MarkId,
                        principalTable: "Marks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    PhotoUrl = table.Column<string>(nullable: true),
                    IsVip = table.Column<bool>(nullable: false),
                    IsConfirmed = table.Column<bool>(nullable: false),
                    AnnouncementCount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false),
                    Info = table.Column<string>(maxLength: 370, nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    ModelId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcements_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Announcements_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Announcements_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnsImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdsPhotoUrl = table.Column<string>(nullable: true),
                    AnnouncementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnsImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnsImages_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Telefon" },
                    { 2, "Planşet" },
                    { 3, "Notbuk" },
                    { 4, "Televizor" },
                    { 5, "SmartWatch" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 49, "Salyan" },
                    { 48, "Sabirabad" },
                    { 47, "Saatlı" },
                    { 46, "Oğuz" },
                    { 45, "Neftçala" },
                    { 44, "Naftalan" },
                    { 41, "Lənkəran" },
                    { 42, "Masallı" },
                    { 50, "Samux" },
                    { 40, "Lerik" },
                    { 39, "Laçın" },
                    { 38, "Qusar" },
                    { 37, "Qubadlı" },
                    { 43, "Mingəçevir" },
                    { 51, "Siyəzən" },
                    { 53, "Şabran" },
                    { 36, "Quba" },
                    { 54, "Şamaxı" },
                    { 55, "Şirvan" },
                    { 56, "Şəki" },
                    { 57, "Şəmkir" },
                    { 58, "Şuşa" },
                    { 59, "Tərtər" },
                    { 60, "Tovuz" },
                    { 61, "Ucar" },
                    { 62, "Yardımlı" },
                    { 63, "Yevlax" },
                    { 64, "Zaqatala" },
                    { 65, "Zəngilan" },
                    { 66, "Zərdab" },
                    { 52, "Sumqayıt" },
                    { 34, "Qəbələ" },
                    { 35, "Qobustan" },
                    { 32, "Qax" },
                    { 14, "Cəlilabad" },
                    { 33, "Qazax" },
                    { 12, "Biləsuvar" },
                    { 11, "Bərdə" },
                    { 10, "Beyləqan" },
                    { 9, "Balakən" },
                    { 15, "Daşkəsən" },
                    { 8, "Bakı" },
                    { 6, "Ağsu" },
                    { 5, "Ağstafa" },
                    { 4, "Ağdaş" },
                    { 3, "Ağdam" },
                    { 2, "Ağcabədi" },
                    { 1, "Abşeron" },
                    { 7, "Astara" },
                    { 16, "Füzuli" },
                    { 13, "Cəbrayıl" },
                    { 18, "Gəncə" },
                    { 31, "Kürdəmir" },
                    { 30, "Kəlbəcər" },
                    { 17, "Gədəbəy" },
                    { 28, "İmişli" },
                    { 27, "Xocavənd" },
                    { 26, "Xocalı" },
                    { 29, "İsmayıllı" },
                    { 24, "Xankəndi" },
                    { 23, "Xaçmaz" },
                    { 22, "Hacıqabul" },
                    { 21, "Göygöl" },
                    { 20, "Göyçay" },
                    { 19, "Goranboy" },
                    { 25, "Xızı" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Info", "PhotoUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Sürətli enerji yığma illərdir Android istifadəçiləri üçün daha əlçatan olsa da, artıq iphone 11 Pro və Pro Max istifadəçiləri", "iphone11pro.jpg", "Iphone 11PRO MAX" },
                    { 2, "Galaxy Note 10 modelləri böyük həcmli batareyalara sahib olacaqlar. ", "samsungNote10.jpg", "Samsung Galaxy Note10" },
                    { 3, "Beləliklə hər iki smartfon modeli (P30 və P30 Pro) ön kamera üçün nəzərdə tutulmuş damcı formalı çıxıntı hissə ilə təchiz olunacaq.", "huaweiP30pro.jpg", "Huawei P30 Pro" }
                });

            migrationBuilder.InsertData(
                table: "Operators",
                columns: new[] { "Id", "OperatorNumber" },
                values: new object[,]
                {
                    { 4, "070" },
                    { 1, "050" },
                    { 2, "051" },
                    { 3, "055" },
                    { 5, "077" }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Apple" },
                    { 27, 5, "Xiaomi" },
                    { 26, 5, "Samsung" },
                    { 25, 5, "Apple" },
                    { 24, 4, "Sony" },
                    { 23, 4, "Samsung" },
                    { 22, 4, "Panasonic" },
                    { 21, 4, "Lg" },
                    { 20, 4, "Hoffmann" },
                    { 19, 3, "Hp" },
                    { 18, 3, "Dell" },
                    { 17, 3, "Asus" },
                    { 16, 3, "Lenovo" },
                    { 28, 5, "Huawei" },
                    { 15, 3, "Acer" },
                    { 13, 3, "Apple" },
                    { 12, 2, "Acer" },
                    { 11, 2, "Huawei" },
                    { 10, 2, "Lenovo" },
                    { 9, 2, "Samsung" },
                    { 8, 2, "Apple" },
                    { 7, 1, "Sony" },
                    { 6, 1, "Htc" },
                    { 5, 1, "Honor" },
                    { 4, 1, "Huawei" },
                    { 3, 1, "Xiaomi" },
                    { 2, 1, "Samsung" },
                    { 14, 3, "Microsoft" },
                    { 29, 5, "Honor" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "MarkId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "X" },
                    { 98, 19, "15-ra047ur" },
                    { 99, 19, "15-ra059ur-3qu42ea" },
                    { 100, 19, "15-ra047ur" },
                    { 101, 19, "250-G6" },
                    { 102, 19, "250-G7" },
                    { 103, 20, "LED 40A3500" },
                    { 104, 20, "LED 32A3500" },
                    { 105, 20, "LED 65R7" },
                    { 106, 20, "LED 55A3500" },
                    { 107, 20, "LED 49E3400" },
                    { 108, 21, "LED 43LM6500" },
                    { 109, 21, "LED 32LM6350" },
                    { 110, 21, "OLED 65B9" },
                    { 111, 21, "OLED 55B9PLA" },
                    { 112, 21, "LED 55UM7450" },
                    { 97, 18, "3579-8973" },
                    { 113, 22, "LED TX-65GXR900" },
                    { 96, 18, "5587-6588" },
                    { 94, 18, "G3" },
                    { 79, 15, "Swift 3 SF-315" },
                    { 80, 15, "Predator Helios 300" },
                    { 81, 15, "Predator Helios 700" },
                    { 82, 15, "Swift 5 SF-314ur" },
                    { 83, 16, "IdeaPad 110" },
                    { 84, 16, "IP330" },
                    { 85, 16, "IdeaPad 320" },
                    { 86, 16, "IP 340" },
                    { 87, 16, "Lenovo ThinkPad" },
                    { 88, 17, "Zenbook 13.3" },
                    { 89, 17, "Zenbook 14" },
                    { 90, 17, "Zenbook 15" },
                    { 91, 17, "Vivobook 13.3" },
                    { 92, 17, "Vivobook 14" },
                    { 93, 18, "AlianWare" },
                    { 95, 18, "G3 Pro" },
                    { 78, 15, "Swift 3 SF-314" },
                    { 114, 22, "LED TX-40FSR500" },
                    { 116, 22, "LED TX-55FXR740" },
                    { 136, 26, "Galaxy Watch Active SM-R500" },
                    { 137, 26, "Galaxy Watch SM-R810" },
                    { 138, 27, "Amazfit GTR" },
                    { 139, 27, "Mi Band 4" },
                    { 140, 27, "Amazfit Verge" },
                    { 141, 27, "Amazfit Stratos" },
                    { 142, 27, "Amazfit Bip" },
                    { 143, 28, "Band 3e" },
                    { 144, 28, "Watch GT" },
                    { 145, 28, "Band 3" },
                    { 146, 28, "Watch GT2" },
                    { 147, 28, "Band 4e" },
                    { 148, 29, "Watch Magic" },
                    { 149, 29, "5 CRS" },
                    { 150, 29, "Band 5" },
                    { 135, 26, "Galaxy Watch SM-R800" },
                    { 115, 22, "LED TX-32DR400" },
                    { 134, 26, "Galaxy Fit e" },
                    { 132, 25, "Watch 4 40mm" },
                    { 117, 22, "LED TX-49FXR740" },
                    { 118, 23, "LED UE55RU7300UXRU" },
                    { 119, 23, "LED QE55Q67RAUXRU" },
                    { 120, 23, "LED UE55RU7140UXRU" },
                    { 121, 23, "LED UE43RU7470UXRU" },
                    { 122, 23, "LED QE65Q9FNAUXRU" },
                    { 123, 24, "KD-85XF8596 RU3" },
                    { 124, 24, "KD-65XF7096 RU3" },
                    { 125, 24, "KD-49XF7596" },
                    { 126, 24, "KD-43XF7096" },
                    { 127, 24, "KDL-43WF665" },
                    { 128, 25, "Watch 3 42mm" },
                    { 129, 25, "Watch 3 44mm" },
                    { 130, 25, "Watch 4 42mm" },
                    { 131, 25, "Watch 4 44mm" },
                    { 133, 26, "Galaxy Fit" },
                    { 77, 14, "Surface Pro Book" },
                    { 76, 14, "Surface Book" },
                    { 75, 14, "Surface 6 Pro" },
                    { 21, 4, "Mate 20 Pro " },
                    { 22, 4, "P20 Pro" },
                    { 23, 4, "P30 Lite" },
                    { 24, 4, "P30 Pro" },
                    { 25, 5, "7A" },
                    { 26, 5, "8S" },
                    { 27, 5, "9 Lite " },
                    { 28, 5, "10 Lite" },
                    { 29, 5, "8X" },
                    { 30, 5, "10" },
                    { 31, 6, "Desire 630 Dual" },
                    { 32, 6, "U Play" },
                    { 33, 6, "Desire 530 " },
                    { 34, 6, "One M8" },
                    { 35, 6, "One M9" },
                    { 20, 4, "Mate 20" },
                    { 36, 6, "One M10" },
                    { 19, 4, "Mate 20 Lite" },
                    { 17, 3, "Redmi Note 5" },
                    { 2, 1, "XS" },
                    { 3, 1, "XS Max" },
                    { 4, 1, "11" },
                    { 5, 1, "11 Pro" },
                    { 6, 1, "11 Pro Max " },
                    { 7, 2, "Galaxy Note 5" },
                    { 8, 2, "Galaxy Note 7" },
                    { 9, 2, "Galaxy Note 8" },
                    { 10, 2, "Galaxy Note 9" },
                    { 11, 2, "Galaxy S6" },
                    { 12, 2, "Galaxy S7" },
                    { 13, 3, "Mi A2 Lite" },
                    { 14, 3, "Mi A2" },
                    { 15, 3, "Mi A3" },
                    { 16, 3, "Redmi Note 4" },
                    { 18, 3, "Redmi Note 7" },
                    { 37, 7, "Xperia Z" },
                    { 38, 7, "Xperia Z1" },
                    { 39, 7, "Xperia Z2 " },
                    { 60, 11, "Tab 4" },
                    { 61, 11, "Tab TB 7104" },
                    { 62, 11, "Tab E10 TB" },
                    { 63, 12, "M5 Lite 32Gb" },
                    { 64, 12, "M5 64gb" },
                    { 65, 12, "MediaPad T5 2+16gb" },
                    { 66, 12, "MediaPad T5 3+32gb" },
                    { 67, 12, "MediaPad T5 4+64gb" },
                    { 68, 13, "MacBook Air 13″ MRE82" },
                    { 69, 13, "Macbook Pro 13″ MR9Q2" },
                    { 70, 13, "MacBook Air 13″ MREE2" },
                    { 71, 13, "Macbook Pro 13″ MV962" },
                    { 72, 13, "MacBook Pro 15″ MR932" },
                    { 73, 14, "Surface 4 Pro" },
                    { 74, 14, "Surface 5 Pro" },
                    { 59, 11, "Tab 10" },
                    { 58, 11, "Tab E 10" },
                    { 57, 10, "Tab E10 TB" },
                    { 56, 10, "Tab TB 7104" },
                    { 40, 7, "Xperia Z3" },
                    { 41, 7, "Xperira Z5" },
                    { 42, 7, "Xpeira XZ" },
                    { 43, 8, "iPad 6" },
                    { 44, 8, "iPad Pro 2018" },
                    { 45, 8, "iPad Air 2019" },
                    { 46, 8, "iPad Mini 2019" },
                    { 151, 29, "Band 3" },
                    { 47, 8, "iPad Pro 2019" },
                    { 49, 9, "Tab E 10.1" },
                    { 50, 9, "Tab A 7.1" },
                    { 51, 9, "Tab A 8.1" },
                    { 52, 9, "Tab A 10.1" },
                    { 53, 10, "Tab E 10" },
                    { 54, 10, "Tab 10" },
                    { 55, 10, "Tab 4" },
                    { 48, 9, "Tab E 8.1" },
                    { 152, 29, "Band 4" }
                });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "AddDate", "AnnouncementCount", "ApplicationUserId", "CityId", "Info", "IsConfirmed", "IsVip", "ModelId", "Name", "PhotoUrl", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 1, " 64gb  Yaxshi veziyyetdedir", true, false, 3, "Satilir Xiaomi Mi A2", "adsMain.jpg", 1200m },
                    { 2, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 8, "Satilir samsung galaxy s10 128 gb yasil reng.", false, false, 10, "Satilir Samsung Galaxy S10", "s10.jpg", 1400m },
                    { 3, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 52, "Huawei P30 pro. Ideal veziyyetdedir...", false, false, 24, "Satilir Huawei P30 Pro", "huaweiP30Proo.jpg", 1350m },
                    { 5, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 8, "Ipad pro 2018 her bir aksesuari var..", false, false, 44, "Satilir Ipad Pro 2018", "ipadPro.jpg", 960m },
                    { 4, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 1, "Ela veziyyetdir 32gb, Qiymetde Cuzi Endirim Olacaq", true, false, 48, "Satilir Samsung Tab E", "samsungTabE.jpg", 450m },
                    { 6, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 52, "Keyfiyyetli plansetdir nomre(4g) destekleyir", false, false, 55, "Satilir Lenovo Tab 4", "lenovoTab.jpg", 1350m },
                    { 7, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 1, "Acer swift 3 14 ekran ram 8 videokarti intel uhd620 1.8Ghz up to 4.0 Ghz", true, false, 78, "Satilir Acer Swift 3", "swift3.jpg", 2100m },
                    { 9, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 52, "G3 ram 16gb ssd 256 videocarti 6gb geforce gtx 1060", false, false, 94, "Satilir Dell G3", "dellG3.jpg", 1750m },
                    { 8, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 8, "Ram 16gb videocarti geforce gtx 1050ti 4gb", false, false, 98, "Satilir Hp Omen", "hpOmen.jpg", 2300m },
                    { 12, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 52, "Lg 104 ekran, Qhd, yeni nesil televizor, Yenidir! qiymet sondur", false, false, 112, "Satilir Lg UHD ", "lgTv.jpg", 1750m },
                    { 11, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 8, "120 ekran,Uhd, qiymetde razilawmaq olar", false, false, 114, "Satilir Sony QHD", "panasonicTv.jpg", 2300m },
                    { 10, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 1, "104 ekran, Uhd,yeni kimidir", true, false, 127, "Satilir Panasonic 4k", "sonyTv.jpg", 2100m },
                    { 13, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 1, "", false, false, 128, "Satilir Apple Watch 4", "appleWatch.jpg", 2100m },
                    { 14, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 8, "", false, false, 135, "Satilir Samsung Watch Active", "samsungWatch.jpg", 2300m },
                    { 15, new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local), 0, null, 52, "", false, false, 139, "Satilir Xiaomi Mi Band 4 ", "XiaomiWatch.jpg", 1750m }
                });

            migrationBuilder.InsertData(
                table: "AnsImages",
                columns: new[] { "Id", "AdsPhotoUrl", "AnnouncementId" },
                values: new object[,]
                {
                    { 1, "ads4.jpg", 1 },
                    { 29, "hpOmen.jpg", 8 },
                    { 30, "hpOmen.jpg", 8 },
                    { 31, "hpOmen.jpg", 8 },
                    { 32, "hpOmen.jpg", 8 },
                    { 45, "lgTv.jpg", 12 },
                    { 46, "lgTv.jpg", 12 },
                    { 47, "lgTv.jpg", 12 },
                    { 48, "lgTv.jpg", 12 },
                    { 41, "panasonicTv.jpg", 11 },
                    { 42, "panasonicTv.jpg", 11 },
                    { 43, "panasonicTv.jpg", 11 },
                    { 44, "panasonicTv.jpg", 11 },
                    { 36, "dellG3.jpg", 9 },
                    { 37, "sonyTv.jpg", 10 },
                    { 39, "sonyTv.jpg", 10 },
                    { 40, "sonyTv.jpg", 10 },
                    { 49, "appleWatch.jpg", 13 },
                    { 50, "appleWatch.jpg", 13 },
                    { 51, "appleWatch.jpg", 13 },
                    { 52, "appleWatch.jpg", 13 },
                    { 53, "samsungWatch.jpg", 14 },
                    { 54, "samsungWatch.jpg", 14 },
                    { 55, "samsungWatch.jpg", 14 },
                    { 56, "samsungWatch.jpg", 14 },
                    { 57, "XiaomiWatch.jpg", 15 },
                    { 58, "XiaomiWatch.jpg", 15 },
                    { 38, "sonyTv.jpg", 10 },
                    { 35, "dellG3.jpg", 9 },
                    { 34, "dellG3.jpg", 9 },
                    { 33, "dellG3.jpg", 9 },
                    { 2, "ads3.jpg", 1 },
                    { 3, "ads2.jpg", 1 },
                    { 4, "ads1.jpg", 1 },
                    { 5, "s10.jpg", 2 },
                    { 6, "s10.jpg", 2 },
                    { 7, "s10.jpg", 2 },
                    { 8, "s10.jpg", 2 },
                    { 9, "huaweiP30Proo.jpg", 3 },
                    { 10, "huaweiP30Proo.jpg", 3 },
                    { 11, "huaweiP30Proo.jpg", 3 },
                    { 12, "huaweiP30Proo.jpg", 3 },
                    { 17, "ipadPro.jpg", 5 },
                    { 18, "ipadPro.jpg", 5 },
                    { 19, "ipadPro.jpg", 5 },
                    { 20, "ipadPro.jpg", 5 },
                    { 13, "samsungTabE.jpg", 4 },
                    { 14, "samsungTabE.jpg", 4 },
                    { 15, "samsungTabE.jpg", 4 },
                    { 16, "samsungTabE.jpg", 4 },
                    { 21, "lenovoTab.jpg", 6 },
                    { 22, "lenovoTab.jpg", 6 },
                    { 23, "lenovoTab.jpg", 6 },
                    { 24, "lenovoTab.jpg", 6 },
                    { 25, "swift3.jpg", 7 },
                    { 26, "swift3.jpg", 7 },
                    { 27, "swift3.jpg", 7 },
                    { 28, "swift3.jpg", 7 },
                    { 59, "XiaomiWatch.jpg", 15 },
                    { 60, "XiaomiWatch.jpg", 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_ApplicationUserId",
                table: "Announcements",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_CityId",
                table: "Announcements",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_ModelId",
                table: "Announcements",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AnsImages_AnnouncementId",
                table: "AnsImages",
                column: "AnnouncementId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_OperatorId",
                table: "AspNetUsers",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_CategoryId",
                table: "Marks",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_MarkId",
                table: "Models",
                column: "MarkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnsImages");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Operators");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
