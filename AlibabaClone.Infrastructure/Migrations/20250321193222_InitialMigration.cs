using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlibabaClone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationType",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketStatus",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleType",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(63)", unicode: false, maxLength: 63, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: false),
                    IdNumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    GenderId = table.Column<short>(type: "smallint", nullable: false),
                    PassportNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EnglishFirstName = table.Column<string>(type: "varchar(63)", unicode: false, maxLength: 63, nullable: true),
                    EnglishLastName = table.Column<string>(type: "varchar(63)", unicode: false, maxLength: 63, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationTypeId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Location_LocationType_LocationTypeId",
                        column: x => x.LocationTypeId,
                        principalTable: "LocationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false),
                    VehicleTypeId = table.Column<short>(type: "smallint", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    PlateNumber = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Row = table.Column<int>(type: "int", nullable: false),
                    Column = table.Column<int>(type: "int", nullable: false),
                    IsVIP = table.Column<bool>(type: "bit", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seat_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transportation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SerialNumber = table.Column<string>(type: "varchar(63)", unicode: false, maxLength: 63, nullable: false),
                    RemainingCapacity = table.Column<int>(type: "int", nullable: false),
                    BasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VIPPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transportation_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transportation_Location_FromLocationId",
                        column: x => x.FromLocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transportation_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transportation_Location_ToLocationId",
                        column: x => x.ToLocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transportation_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountRole",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<short>(type: "smallint", nullable: false),
                    AccountId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId1 = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRole", x => new { x.AccountId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AccountRole_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountRole_Account_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountRole_Role_RoleId1",
                        column: x => x.RoleId1,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coupon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Percentage = table.Column<short>(type: "smallint", nullable: false),
                    MaxDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinBaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coupon_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Coupon_Account_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Account",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransportationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TravelerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TicketStatusId = table.Column<short>(type: "smallint", nullable: false),
                    SerialNumber = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Account_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Person_CompanionId",
                        column: x => x.CompanionId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Person_TravelerId",
                        column: x => x.TravelerId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Seat_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_TicketStatus_TicketStatusId",
                        column: x => x.TicketStatusId,
                        principalTable: "TicketStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Transportation_TransportationId",
                        column: x => x.TransportationId,
                        principalTable: "Transportation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FinalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CouponId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_Coupon_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transaction_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_PersonId",
                table: "Account",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountRole_AccountId1",
                table: "AccountRole",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_AccountRole_RoleId",
                table: "AccountRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountRole_RoleId1",
                table: "AccountRole",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_City_Title",
                table: "City",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_Title",
                table: "Company",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Coupon_AccountId",
                table: "Coupon",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupon_AccountId1",
                table: "Coupon",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_Gender_Title",
                table: "Gender",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Location_CityId",
                table: "Location",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_LocationTypeId",
                table: "Location",
                column: "LocationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationType_Title",
                table: "LocationType",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_GenderId",
                table: "Person",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_IdNumber",
                table: "Person",
                column: "IdNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Role_Title",
                table: "Role",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seat_VehicleId",
                table: "Seat",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_BuyerId",
                table: "Ticket",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CompanionId",
                table: "Ticket",
                column: "CompanionId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_SeatId",
                table: "Ticket",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TicketStatusId",
                table: "Ticket",
                column: "TicketStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TransportationId",
                table: "Ticket",
                column: "TransportationId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TravelerId",
                table: "Ticket",
                column: "TravelerId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketStatus_Title",
                table: "TicketStatus",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CouponId",
                table: "Transaction",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_TicketId",
                table: "Transaction",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Transportation_CompanyId",
                table: "Transportation",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Transportation_FromLocationId",
                table: "Transportation",
                column: "FromLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Transportation_LocationId",
                table: "Transportation",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Transportation_ToLocationId",
                table: "Transportation",
                column: "ToLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Transportation_VehicleId",
                table: "Transportation",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_PlateNumber",
                table: "Vehicle",
                column: "PlateNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleTypeId",
                table: "Vehicle",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleType_Id",
                table: "VehicleType",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountRole");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Coupon");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "TicketStatus");

            migrationBuilder.DropTable(
                name: "Transportation");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "LocationType");

            migrationBuilder.DropTable(
                name: "VehicleType");
        }
    }
}
