using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace homecoming.webapp.Data.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BedRoomType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BedRoom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedRoomType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessUserViewModel",
                columns: table => new
                {
                    BusinessId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AspUser = table.Column<string>(nullable: true),
                    BusinessName = table.Column<string>(nullable: true),
                    CoverPhotoUrl = table.Column<string>(nullable: true),
                    Tel_No = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Zipcode = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUserViewModel", x => x.BusinessId);
                });

            migrationBuilder.CreateTable(
                name: "CaptureDetailsHelper",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckIn = table.Column<DateTime>(nullable: false),
                    CheckOut = table.Column<DateTime>(nullable: false),
                    RoomNumber = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaptureDetailsHelper", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationViewModel",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationViewModel", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "AccomodationViewModel",
                columns: table => new
                {
                    AccomodationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    CoverPhoto = table.Column<string>(nullable: true),
                    AccomodationName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Rating = table.Column<decimal>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    GeoLocationLocationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccomodationViewModel", x => x.AccomodationId);
                    table.ForeignKey(
                        name: "FK_AccomodationViewModel_BusinessUserViewModel_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "BusinessUserViewModel",
                        principalColumn: "BusinessId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccomodationViewModel_LocationViewModel_GeoLocationLocationId",
                        column: x => x.GeoLocationLocationId,
                        principalTable: "LocationViewModel",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccomodationPhotos",
                columns: table => new
                {
                    AccomodationPhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccomodationId = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    AccomodationViewModelAccomodationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccomodationPhotos", x => x.AccomodationPhotoId);
                    table.ForeignKey(
                        name: "FK_AccomodationPhotos_AccomodationViewModel_AccomodationViewModelAccomodationId",
                        column: x => x.AccomodationViewModelAccomodationId,
                        principalTable: "AccomodationViewModel",
                        principalColumn: "AccomodationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccomodationId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    IsBooked = table.Column<bool>(nullable: false),
                    HelperId = table.Column<int>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Rooms_AccomodationViewModel_AccomodationId",
                        column: x => x.AccomodationId,
                        principalTable: "AccomodationViewModel",
                        principalColumn: "AccomodationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_CaptureDetailsHelper_HelperId",
                        column: x => x.HelperId,
                        principalTable: "CaptureDetailsHelper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomDetails",
                columns: table => new
                {
                    RoomDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    NumberOfBeds = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Television = table.Column<bool>(nullable: false),
                    Wifi = table.Column<bool>(nullable: false),
                    Air_condition = table.Column<bool>(nullable: false),
                    Private_bathroom = table.Column<bool>(nullable: false),
                    BedRoomTypesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomDetails", x => x.RoomDetailId);
                    table.ForeignKey(
                        name: "FK_RoomDetails_BedRoomType_BedRoomTypesId",
                        column: x => x.BedRoomTypesId,
                        principalTable: "BedRoomType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomDetails_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomImagesViewModel",
                columns: table => new
                {
                    RoomImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomImagesViewModel", x => x.RoomImageId);
                    table.ForeignKey(
                        name: "FK_RoomImagesViewModel_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationPhotos_AccomodationViewModelAccomodationId",
                table: "AccomodationPhotos",
                column: "AccomodationViewModelAccomodationId");

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationViewModel_BusinessId",
                table: "AccomodationViewModel",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationViewModel_GeoLocationLocationId",
                table: "AccomodationViewModel",
                column: "GeoLocationLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomDetails_BedRoomTypesId",
                table: "RoomDetails",
                column: "BedRoomTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomDetails_RoomId",
                table: "RoomDetails",
                column: "RoomId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomImagesViewModel_RoomId",
                table: "RoomImagesViewModel",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_AccomodationId",
                table: "Rooms",
                column: "AccomodationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HelperId",
                table: "Rooms",
                column: "HelperId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccomodationPhotos");

            migrationBuilder.DropTable(
                name: "RoomDetails");

            migrationBuilder.DropTable(
                name: "RoomImagesViewModel");

            migrationBuilder.DropTable(
                name: "BedRoomType");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "AccomodationViewModel");

            migrationBuilder.DropTable(
                name: "CaptureDetailsHelper");

            migrationBuilder.DropTable(
                name: "BusinessUserViewModel");

            migrationBuilder.DropTable(
                name: "LocationViewModel");
        }
    }
}
