using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_Manager.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    serial_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vehicle_identification_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    plate_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    door_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    year_of_make = table.Column<int>(type: "int", nullable: true),
                    seats_number = table.Column<int>(type: "int", nullable: true),
                    fuel_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    body_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    front_photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    back_photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    right_photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    left_photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    purchase_price = table.Column<double>(type: "float", nullable: true),
                    inspection_expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    hajri_inspection_expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    registration_license_expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    hajri_registration_license_expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    has_gps = table.Column<bool>(type: "bit", nullable: false),
                    has_fuel_chip = table.Column<bool>(type: "bit", nullable: false),
                    owner_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    owner_id = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    full_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    local_full_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telphone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    badge_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    job_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    join_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gov_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brith_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    profile_photo_url = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    is_employee = table.Column<bool>(type: "bit", nullable: false),
                    is_superuser = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cars_Insurances",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    policy_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    insurance_class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    insurance_area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    insured_value = table.Column<double>(type: "float", nullable: false),
                    repair_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    insure_accessories = table.Column<bool>(type: "bit", nullable: false),
                    excess_amount = table.Column<double>(type: "float", nullable: false),
                    insurance_cost = table.Column<double>(type: "float", nullable: false),
                    insurance_start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    insurance_end = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars_Insurances", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cars_Insurances_Cars_id",
                        column: x => x.id,
                        principalTable: "Cars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars_Services",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    odometer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    service_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    workshop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    service_cost = table.Column<double>(type: "float", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars_Services", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cars_Services_Cars_id",
                        column: x => x.id,
                        principalTable: "Cars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars_Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    received_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    odometer_before = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    handover_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    odometer_after = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    odometer_unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    authorize_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    authorize_start_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    authorize_end_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cars_Users_Cars_id",
                        column: x => x.id,
                        principalTable: "Cars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Users_Users_id",
                        column: x => x.id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars_Insurances");

            migrationBuilder.DropTable(
                name: "Cars_Services");

            migrationBuilder.DropTable(
                name: "Cars_Users");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
