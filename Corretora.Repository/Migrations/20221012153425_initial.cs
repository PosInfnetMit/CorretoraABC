using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Corretora.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Sigla = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cotacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AcaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    Abertura = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Alta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Baixa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fechamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechamentoAjustado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cotacao_Acao_AcaoId",
                        column: x => x.AcaoId,
                        principalTable: "Acao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "Id", "Nome", "Sigla" },
                values: new object[] { new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), "Magazine Luiza S.A.", "MGLU3.SA" });

            migrationBuilder.InsertData(
                table: "Cotacao",
                columns: new[] { "Id", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("00fc5c0e-7e98-4fdf-bf2a-b72bf552b956"), 5.303125m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.318750m, 5.159687m, new DateTime(2019, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.210625m, 5.057674m, 77120000 },
                    { new Guid("01813858-0797-4ae0-a794-55388d284f18"), 5.439062m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.506875m, 5.398437m, new DateTime(2019, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.452500m, 5.292450m, 28726400 },
                    { new Guid("01cf9422-aa25-45c7-a71f-91c863cfe47f"), 5.429687m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.512500m, 5.330312m, new DateTime(2019, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.409687m, 5.250894m, 33091200 },
                    { new Guid("02c2ece2-302e-4b23-b493-b41853034cca"), 10.402500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.720000m, 10.242500m, new DateTime(2019, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.690000m, 10.419733m, 41211200 },
                    { new Guid("02f5e8a4-47cf-499e-93fb-7a8547045cd3"), 5.593750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.640000m, 5.503750m, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.587500m, 5.423487m, 20665600 },
                    { new Guid("0391430b-81d7-4535-8af0-cea65b820afb"), 9.225000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.837500m, 9.180000m, new DateTime(2020, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.000000m, 9.754498m, 125173600 },
                    { new Guid("04467bb5-4020-47f1-b110-6e5d44232a20"), 7.226562m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.371562m, 7.226562m, new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.296875m, 7.098762m, 35814400 },
                    { new Guid("04addb1f-ee5c-4226-88a8-70ee80e3efdb"), 9.870000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.187500m, 9.840000m, new DateTime(2019, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.125000m, 9.869020m, 43940800 },
                    { new Guid("05193d59-f8d1-4700-9cd7-f6977b3356ff"), 5.638125m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.812187m, 5.594687m, new DateTime(2019, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.812187m, 5.641579m, 27017600 },
                    { new Guid("06487b4a-1f58-43a1-9f8a-df9a04b42d30"), 11.330000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.570000m, 10.880000m, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.010000m, 10.731645m, 72748800 },
                    { new Guid("0ae8f5b0-0eb2-4238-bc85-f655e2c1afe0"), 5.562500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.578125m, 5.484687m, new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.537187m, 5.374651m, 25369600 },
                    { new Guid("0bc87afa-367b-4bd2-aae9-2e1871508077"), 13.420000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.590000m, 13.300000m, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.415000m, 13.085658m, 36965600 },
                    { new Guid("0bcd627b-0887-4e9c-900e-5c34ec722f71"), 5.656250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.687500m, 5.562500m, new DateTime(2019, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.562500m, 5.411476m, 15702400 },
                    { new Guid("0c98df00-cb8b-438a-b893-bfdc7ba12f5b"), 8.125000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.232500m, 7.390000m, new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.552500m, 7.367085m, 85826000 },
                    { new Guid("0cf894c9-c3bc-4f1e-b6cd-61bceb829360"), 5.078125m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.343437m, 5.000625m, new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.334062m, 5.177489m, 33744000 },
                    { new Guid("0d85965f-ecd6-48d0-9f90-6e3eee3ca4bc"), 14.400000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.490000m, 14.000000m, new DateTime(2020, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.082500m, 13.736772m, 36680000 },
                    { new Guid("0d8f1530-f00d-414d-9f63-a4846d160e52"), 8.625000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.800000m, 8.612500m, new DateTime(2019, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.765000m, 8.527027m, 25575200 },
                    { new Guid("0fa3891e-eb88-4457-b7ff-993f8b7ad003"), 5.553125m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.696562m, 5.472500m, new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.639062m, 5.485959m, 33337600 },
                    { new Guid("10a4627a-5c7f-4a1e-8c96-084ae7cdc8a4"), 5.529687m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.580312m, 5.486562m, new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.515625m, 5.353722m, 13638400 },
                    { new Guid("119ee18d-32a6-4796-9cc7-44cd4fde00c2"), 7.065312m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.225000m, 7.037500m, new DateTime(2019, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.168750m, 6.974115m, 30169600 },
                    { new Guid("1251c515-6835-4626-b1ba-b2d98630b696"), 9.412500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.420000m, 9.052500m, new DateTime(2019, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.132500m, 8.884548m, 41342400 },
                    { new Guid("13742ca0-10ce-4555-ac55-3ee403c6e0e9"), 6.509062m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.546562m, 6.420937m, new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.520312m, 6.343283m, 23817600 },
                    { new Guid("17d687b8-f909-4a9f-abca-75c29b0332e1"), 11.250000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.692500m, 9.975000m, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.770000m, 10.505594m, 80331600 },
                    { new Guid("1853b60a-8ef7-4e10-94b6-842968fbe8bd"), 13.265000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.512500m, 12.940000m, new DateTime(2020, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.220000m, 12.895447m, 53716400 },
                    { new Guid("187bc36f-253a-4459-9a8b-58ed94d6ef0d"), 8.005000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.405000m, 6.617500m, new DateTime(2020, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.202500m, 7.025677m, 121748400 },
                    { new Guid("192c4571-fed4-4265-aa6a-56c6f5a6c0a9"), 13.632500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.137500m, 13.562500m, new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.985000m, 13.641665m, 42104000 },
                    { new Guid("1b806b95-608f-42c5-9467-0f2fa78bfac1"), 5.473437m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.479687m, 5.348125m, new DateTime(2019, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.362812m, 5.205395m, 15523200 },
                    { new Guid("1c4c1d34-904c-4134-8324-b6cb13d3cfe1"), 8.812500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.812500m, 8.603437m, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.625000m, 8.390828m, 59516800 },
                    { new Guid("1ca1e00e-86d5-4047-861d-438e965d14b5"), 5.484375m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.526562m, 5.421875m, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.443750m, 5.283957m, 22496000 },
                    { new Guid("1d2e2600-71e4-4a0a-8519-f05f0d6204df"), 9.575000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.920000m, 9.570000m, new DateTime(2019, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.912500m, 9.661892m, 35893600 },
                    { new Guid("1ea8e578-fb79-47e5-9991-20743a607adb"), 10.837500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.160000m, 10.642500m, new DateTime(2019, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.160000m, 10.877851m, 95930400 },
                    { new Guid("20831235-78e0-4172-9c98-0de7980d4f83"), 9.175000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.225000m, 8.570000m, new DateTime(2019, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.607500m, 8.373804m, 52826400 },
                    { new Guid("2097918b-be6e-4949-9394-b244ca6dd9ce"), 5.406562m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.620937m, 5.350000m, new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.578125m, 5.414387m, 33779200 },
                    { new Guid("22a77604-a4ce-489a-b822-3aebf1198a1c"), 8.897500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.315000m, 8.837500m, new DateTime(2019, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.315000m, 9.062093m, 55866000 },
                    { new Guid("22b66680-a8f1-405e-8c8c-3a4e810d2675"), 5.751562m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.760937m, 5.573437m, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.575000m, 5.411354m, 27721600 },
                    { new Guid("22b8fed1-d5ec-4a9d-8cec-f55cc31c439a"), 9.165000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.300000m, 9.087500m, new DateTime(2019, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.300000m, 9.047503m, 31424800 },
                    { new Guid("22e20b7b-7be8-40c3-bd51-8164b3a303f3"), 8.712500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.750000m, 8.312500m, new DateTime(2019, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.425000m, 8.196259m, 38613600 },
                    { new Guid("233bbc7c-383e-4aa0-b514-65ea378df1c0"), 13.912500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.455000m, 13.850000m, new DateTime(2020, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.112500m, 13.766035m, 38342000 },
                    { new Guid("23efe25b-c2df-4f40-951a-9a1993e00166"), 5.253125m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.615625m, 5.250312m, new DateTime(2019, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.565625m, 5.402255m, 51174400 },
                    { new Guid("2447dbe3-9675-449e-8d65-3cb5a58d282d"), 9.137500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.217500m, 8.937500m, new DateTime(2019, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.180000m, 8.930758m, 22660800 },
                    { new Guid("24c08ffd-1ee9-47b8-956c-c256cc36b004"), 14.625000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.710000m, 14.257500m, new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.325000m, 13.973318m, 34484400 },
                    { new Guid("251eac52-4ad1-4754-bc09-e2caad31ee0f"), 5.098437m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.217187m, 5.020312m, new DateTime(2019, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.064062m, 4.915414m, 65046400 }
                });

            migrationBuilder.InsertData(
                table: "Cotacao",
                columns: new[] { "Id", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("252231bd-5af5-40e1-9d3e-2a77393b4814"), 6.062500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.062500m, 5.878125m, new DateTime(2019, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.937812m, 5.776597m, 22060800 },
                    { new Guid("254265a0-08e9-4cfb-aa3d-3fff71539665"), 13.600000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.615000m, 12.967500m, new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.112500m, 12.790586m, 45342400 },
                    { new Guid("2583f27a-8a21-4f17-863a-a07410af76eb"), 13.450000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.607500m, 13.275000m, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.587500m, 13.253923m, 24184000 },
                    { new Guid("25a72583-f881-41c2-9eae-180e6d8c4e8a"), 6.437500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.569687m, 6.421562m, new DateTime(2019, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.550312m, 6.372468m, 41241600 },
                    { new Guid("2a422aca-d388-47ba-9941-05a5d09015c4"), 11.297500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.302500m, 11.000000m, new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.147500m, 10.865669m, 34445600 },
                    { new Guid("2b3990c7-ce6f-4dcc-a6b4-422aa89f4b4f"), 9.517500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.550000m, 9.325000m, new DateTime(2019, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.457500m, 9.200726m, 23158000 },
                    { new Guid("2b5e3f3a-c4b7-48d9-b9fa-d16fdec35fb3"), 5.250000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.312500m, 5.142500m, new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.312500m, 5.156559m, 22025600 },
                    { new Guid("2d2b9c53-4375-445d-9401-db438a49cea8"), 5.437187m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.444375m, 5.218750m, new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.218750m, 5.065561m, 40012800 },
                    { new Guid("2e60e1f3-33b0-4005-ac6f-087e7f33baa9"), 14.500000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.980000m, 14.287500m, new DateTime(2020, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.712500m, 14.351304m, 73775200 },
                    { new Guid("30984200-7387-461e-8139-7d53fe591bc5"), 5.187187m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.265625m, 5.125312m, new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.230625m, 5.077088m, 25052800 },
                    { new Guid("319cb36e-938d-4845-99d8-8dafdae0f5f7"), 5.262500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.262500m, 5.125000m, new DateTime(2019, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.187500m, 5.035228m, 20828800 },
                    { new Guid("31d13f0d-6d99-475b-b6b8-3cc13fd387c6"), 9.030000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.420000m, 8.212500m, new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.892500m, 8.674187m, 108219600 },
                    { new Guid("3216dc26-a06f-4d7e-858e-ed150d3e2d3b"), 6.204062m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.387500m, 6.140625m, new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.328125m, 6.156314m, 37593600 },
                    { new Guid("32a9a23f-3277-4402-bf00-60e01320a0d0"), 12.132500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.182500m, 11.975000m, new DateTime(2019, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.155000m, 11.847696m, 30079600 },
                    { new Guid("3367140e-e6ea-41df-8724-853cf64ff3c5"), 6.581250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.643437m, 6.469687m, new DateTime(2019, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.503125m, 6.326562m, 35424000 },
                    { new Guid("356f3e35-40b7-4052-a9a6-87edf37472e8"), 6.026875m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.026875m, 5.809375m, new DateTime(2019, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.809375m, 5.651648m, 34588800 },
                    { new Guid("35e46db6-35f4-4239-968d-85193b1aef9a"), 10.837500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.887500m, 10.605000m, new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.775000m, 10.502585m, 24721600 },
                    { new Guid("35fb5e2e-e438-429b-b0dc-768e6c5d87ea"), 11.300000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.365000m, 10.767500m, new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.850000m, 10.575689m, 65437200 },
                    { new Guid("367eb3ea-5c47-46fe-ae7b-3f1b3c7b07b8"), 5.634375m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.906250m, 5.629062m, new DateTime(2019, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.906250m, 5.745892m, 66128000 },
                    { new Guid("37590efd-8444-4e9e-bca5-359e1f06b9c8"), 6.375000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.546875m, 6.364062m, new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.474687m, 6.298896m, 36195200 },
                    { new Guid("387cba85-362f-4f31-a9d9-962914acb4a8"), 5.594062m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.659375m, 5.556250m, new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.651562m, 5.485669m, 24432000 },
                    { new Guid("39b8b1bb-92e2-4f61-ac8b-83bcf9dfb545"), 7.875000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.263750m, 7.832812m, new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.243750m, 8.019929m, 46249600 },
                    { new Guid("3acdc1f6-1a53-41b0-8091-089b8d5adec6"), 5.436562m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.460625m, 5.352812m, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.352812m, 5.195687m, 16227200 },
                    { new Guid("3ae6f4ab-0b2a-4fb9-a684-bc7382c91ee4"), 5.673437m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.702812m, 5.593750m, new DateTime(2019, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.615937m, 5.451090m, 19398400 },
                    { new Guid("3ccc83b5-a5a6-4ea7-8661-270ad1db6d50"), 5.344375m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.468750m, 5.314375m, new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.468750m, 5.320271m, 24780800 },
                    { new Guid("3d2354dc-4d62-4b9c-a536-dc3e04548f75"), 13.920000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.180000m, 13.732500m, new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.145000m, 13.797739m, 32739600 },
                    { new Guid("3debf28b-b880-4740-8dc9-6d7ea2b1f04c"), 5.593750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.625000m, 5.540000m, new DateTime(2019, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.578437m, 5.426980m, 16448000 },
                    { new Guid("3e8f8fc7-e713-42fb-88ae-4866e53f44fd"), 9.342500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.562500m, 9.145000m, new DateTime(2019, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.237500m, 8.986698m, 52995600 },
                    { new Guid("3eb83348-300d-4ffd-a886-4876c57ef3bf"), 10.897500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.997500m, 10.730000m, new DateTime(2019, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.872500m, 10.597620m, 32365600 },
                    { new Guid("3fcf3312-91f5-4b0b-83d7-8a8238330921"), 8.425000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.662500m, 8.287500m, new DateTime(2019, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.650000m, 8.415149m, 65658000 },
                    { new Guid("40367048-57f0-4ba5-9bca-06fa21b0421d"), 9.245000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.265000m, 8.962500m, new DateTime(2019, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.000000m, 8.755645m, 31526400 },
                    { new Guid("41579fbc-e165-4f04-8d5a-0324da69b0b7"), 12.155000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.587500m, 12.125000m, new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.572500m, 12.263843m, 40007200 },
                    { new Guid("4224caf6-ea4c-4572-8ae1-070ef8042c8f"), 9.397500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.462500m, 9.100000m, new DateTime(2019, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.390000m, 9.135057m, 35834400 },
                    { new Guid("43a25245-ffe2-4c6f-bf7f-ebeefa51cf4f"), 9.287500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.322500m, 9.067500m, new DateTime(2019, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.125000m, 8.877253m, 35486800 },
                    { new Guid("44c580c1-6c58-4336-a452-4bbfd1e40007"), 11.175000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.437500m, 11.000000m, new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.017500m, 10.738955m, 58363600 },
                    { new Guid("472b4608-2e8a-4e91-b5f3-4eca2a7c993e"), 5.285000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.335000m, 5.236250m, new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.312187m, 5.156256m, 23593600 },
                    { new Guid("473b995b-9b25-421d-b3e5-6a61891a678f"), 11.255000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.397500m, 11.200000m, new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.350000m, 11.063050m, 30212800 },
                    { new Guid("4829896a-b182-44bb-9767-289f2249653a"), 6.500000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.564375m, 6.468750m, new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.514062m, 6.337202m, 22841600 },
                    { new Guid("482e456d-3d2f-4b2c-8bc6-d98e2f4c6ad6"), 10.875000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.370000m, 10.810000m, new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.255000m, 10.970451m, 44655600 },
                    { new Guid("4b124117-413b-4a73-8791-95695f24e2f7"), 9.660000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.742500m, 9.465000m, new DateTime(2019, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.500000m, 9.259819m, 42653200 },
                    { new Guid("4b946035-0a15-41dc-b776-2b22dca8c8bd"), 5.656250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.755937m, 5.562500m, new DateTime(2019, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.632812m, 5.479878m, 35641600 },
                    { new Guid("4cef6f7b-3d8c-4784-99e2-de398aeb6a08"), 12.675000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.360000m, 12.455000m, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.137500m, 12.814972m, 64611600 }
                });

            migrationBuilder.InsertData(
                table: "Cotacao",
                columns: new[] { "Id", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("4ef8db85-1250-4536-8f8f-7b7627d1cda6"), 14.587500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.725000m, 14.402500m, new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.465000m, 14.109880m, 36514000 },
                    { new Guid("4f87e851-bc0f-4af2-a5dd-4bc0c810f6da"), 11.250000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.297500m, 10.942500m, new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.245000m, 10.960704m, 110621200 },
                    { new Guid("4fcc886f-c0ca-440b-963c-b56e0a78eb4e"), 11.070000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.297500m, 11.017500m, new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.222500m, 10.938771m, 39038400 },
                    { new Guid("50d53c76-6204-4b11-ad96-7076b66ebe7d"), 8.430000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.447500m, 8.430000m, new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.170000m, 8.944876m, 82749200 },
                    { new Guid("514f0430-681b-4688-85ee-1164adc7743a"), 7.734687m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.826562m, 7.659687m, new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.718750m, 7.509182m, 39859200 },
                    { new Guid("51c8c65d-b577-47b7-8017-f14a536394a9"), 9.350000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.782500m, 9.017500m, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.370000m, 9.139965m, 73661200 },
                    { new Guid("51d4068a-bb6e-45eb-9b61-b014686eafe2"), 10.705000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.925000m, 10.315000m, new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.412500m, 10.156872m, 51879600 },
                    { new Guid("52763bd6-32cb-4064-8600-e9988bacf1b1"), 5.546875m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.567187m, 5.453437m, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.533437m, 5.371011m, 17363200 },
                    { new Guid("53487f23-c721-4db5-8a63-53ce05eb1c8d"), 5.174062m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.187500m, 4.944062m, new DateTime(2019, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.040625m, 4.892664m, 38464000 },
                    { new Guid("534dc36d-fb65-4a3f-91b1-60484895f4f0"), 7.781250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.793750m, 7.439062m, new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.439062m, 7.237089m, 48448000 },
                    { new Guid("537a46a1-dfff-4418-ac85-8008eb29f28e"), 10.675000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.115000m, 10.642500m, new DateTime(2019, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.062500m, 10.782818m, 72272400 },
                    { new Guid("539a6c7d-be71-4b31-b924-50ee9a7ec724"), 5.937500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.075000m, 5.925625m, new DateTime(2019, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.027812m, 5.864154m, 28982400 },
                    { new Guid("545369cb-ab94-4991-a4d4-4fa4788cba00"), 11.485000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.650000m, 11.325000m, new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.650000m, 11.355463m, 33751600 },
                    { new Guid("55bfac28-9a21-41ed-9a65-56ebed01f9f3"), 5.570312m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.611562m, 5.487500m, new DateTime(2019, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.540000m, 5.377381m, 22969600 },
                    { new Guid("58102047-650a-4f9f-b950-a7fe3ba7efd6"), 11.050000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.072500m, 10.627500m, new DateTime(2019, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.760000m, 10.487964m, 71944400 },
                    { new Guid("5909f762-7d39-41dd-a43f-ebf2e444b22d"), 5.559687m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.615312m, 5.500000m, new DateTime(2019, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.593750m, 5.429554m, 34128000 },
                    { new Guid("591db9f0-ac56-4026-91ca-a4091c24caa8"), 8.535000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.795000m, 8.457500m, new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.712500m, 8.475951m, 41455600 },
                    { new Guid("5921dee2-8e61-4322-b654-50b30ae52e7b"), 5.968750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.218750m, 5.968750m, new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.132812m, 5.966303m, 38476800 },
                    { new Guid("59c1d4a0-a5eb-40d4-be57-59382b9e1242"), 6.875000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.842500m, 6.250000m, new DateTime(2020, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.637500m, 7.449998m, 112723200 },
                    { new Guid("5a5a19f0-5103-4df7-8392-3c4a1324d10c"), 6.543750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.597500m, 6.480937m, new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.597500m, 6.418375m, 32460800 },
                    { new Guid("5f30c747-5107-4a8e-a0f1-ab326158683f"), 5.218750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.271875m, 5.172500m, new DateTime(2019, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.271875m, 5.117127m, 20364800 },
                    { new Guid("5f3b18b3-850e-41ec-86b0-1117844fb55f"), 8.835000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.912500m, 8.332500m, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.885000m, 8.666871m, 65810400 },
                    { new Guid("5f731ff7-9702-4d5f-a275-da31d69f3e25"), 13.550000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.680000m, 13.075000m, new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.365000m, 13.036887m, 33515200 },
                    { new Guid("5fead850-7a11-478d-b5d7-12fe727da566"), 8.750000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.977500m, 8.517500m, new DateTime(2020, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.517500m, 8.308393m, 92384800 },
                    { new Guid("60ba114b-484c-4203-a65f-8008def27c74"), 11.402500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.475000m, 11.040000m, new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.050000m, 10.770633m, 39114800 },
                    { new Guid("60bbf6bb-62d5-4a3e-9d60-8bd97310e2b2"), 10.725000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.850000m, 10.585000m, new DateTime(2020, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.725000m, 10.644061m, 45244400 },
                    { new Guid("6242e7b2-db21-44a1-8071-460364886f19"), 6.156250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.212500m, 6.047187m, new DateTime(2019, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.085625m, 5.920397m, 26694400 },
                    { new Guid("63df296c-59eb-4126-9f92-02a59f0026e5"), 6.437500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.441875m, 6.281250m, new DateTime(2019, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.347500m, 6.175162m, 42611200 },
                    { new Guid("649125ec-cf5c-49b2-8d9b-83fbf98a5e6e"), 6.125000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.162500m, 5.875937m, new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.974687m, 5.812472m, 40675200 },
                    { new Guid("665e5729-e847-4b35-bf32-24d2fdf6c4da"), 5.296875m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.312187m, 5.124062m, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.124062m, 4.973652m, 31440000 },
                    { new Guid("6760598f-7f63-46e9-aac7-8b1d7ee287c8"), 9.375000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.447500m, 9.162500m, new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.175000m, 8.925894m, 28631600 },
                    { new Guid("69f01d66-3d44-4dd2-8afc-ddfc2a44cf03"), 11.245000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.312500m, 10.882500m, new DateTime(2019, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.130000m, 10.848610m, 59731600 },
                    { new Guid("6a226367-984a-4844-9d28-99a3a302dd49"), 10.715000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.110000m, 10.562500m, new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.005000m, 10.726769m, 128373200 },
                    { new Guid("6a8e910c-32e2-4afb-9fd2-44d7da4a2cbb"), 12.347500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.347500m, 11.807500m, new DateTime(2019, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.970000m, 11.667374m, 48477200 },
                    { new Guid("6ae2595a-5cf5-4e35-b64d-82eea568faae"), 7.781875m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.799375m, 7.542187m, new DateTime(2019, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.562500m, 7.357175m, 36387200 },
                    { new Guid("6b535900-325a-4aaf-a745-773635a370c5"), 9.125000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.235000m, 9.020000m, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.152500m, 8.904007m, 27328800 },
                    { new Guid("6b960c78-11c2-49c3-afcf-ccf3b4198269"), 5.496875m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.530625m, 5.314687m, new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.420625m, 5.261511m, 32044800 },
                    { new Guid("6bab3e19-21c0-4af3-98e8-ad272544725a"), 5.468750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.468750m, 5.198750m, new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.250000m, 5.095894m, 51513600 },
                    { new Guid("6be0a8b0-b4bd-4b37-b6a7-3aacca4f0b97"), 9.672500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.185000m, 9.412500m, new DateTime(2020, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.750000m, 9.510635m, 68294000 },
                    { new Guid("6ca228f3-fa61-431f-b22c-f15697e41f70"), 5.127500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.270625m, 5.071875m, new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.150937m, 4.999739m, 26668800 },
                    { new Guid("6d21b1a4-8d1e-4087-925a-97dc8484575e"), 5.507500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.507500m, 5.365625m, new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.406250m, 5.259468m, 47628800 },
                    { new Guid("6defcbfb-2f61-43bd-b2d5-2491bd328d09"), 5.844687m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.897500m, 5.658125m, new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.828125m, 5.669889m, 28297600 }
                });

            migrationBuilder.InsertData(
                table: "Cotacao",
                columns: new[] { "Id", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("6dfc2871-5967-426a-8785-8ef339a1b8ee"), 5.546875m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.655625m, 5.427500m, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.595937m, 5.431677m, 30585600 },
                    { new Guid("703d774c-9d8b-438e-b628-722c23323f86"), 5.129062m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.140625m, 4.986562m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.034375m, 4.886599m, 40636800 },
                    { new Guid("70f0b7ed-62b6-465a-b972-4c5c2d910e3f"), 12.075000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.415000m, 12.000000m, new DateTime(2019, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.267500m, 11.957350m, 54632800 },
                    { new Guid("7105bc9d-4101-4dd7-9019-832bd0c4afb1"), 8.750000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.847500m, 8.470000m, new DateTime(2019, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.750000m, 8.512433m, 50517200 },
                    { new Guid("7124048a-c131-4cb2-b9fa-2754fb27b063"), 11.222500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.272500m, 11.062500m, new DateTime(2019, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.250000m, 10.965576m, 42849600 },
                    { new Guid("715e5ecf-dd2a-4ca6-a1e7-40bf448c0346"), 10.845000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.875000m, 10.500000m, new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.500000m, 10.234539m, 32608400 },
                    { new Guid("71f8d039-c166-4671-bd60-e9587be3379a"), 5.187500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.215000m, 5.075000m, new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.109375m, 4.959397m, 41980800 },
                    { new Guid("72279ccf-0367-4f96-bb2d-814b43830f87"), 9.192500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.305000m, 9.135000m, new DateTime(2019, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.135000m, 8.886981m, 25524400 },
                    { new Guid("7294c922-c4e0-4ab2-8762-f214e8dbf1d8"), 5.111250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.148125m, 4.953750m, new DateTime(2019, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.994375m, 4.858776m, 39385600 },
                    { new Guid("73ebb2bd-e62d-4b87-bdbb-0d89410853f6"), 9.400000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.482500m, 8.977500m, new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.072500m, 8.826178m, 44445600 },
                    { new Guid("74161d26-4cb7-46f1-acc9-aeb16e8c59b2"), 5.371250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.371250m, 5.070312m, new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.078125m, 4.929065m, 48358400 },
                    { new Guid("756e95b2-8b7f-4684-837d-123294fe152a"), 6.625000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.675000m, 6.536562m, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.568750m, 6.390405m, 22857600 },
                    { new Guid("770bc5ab-f62b-4087-a6e8-6d8c9a87e7be"), 5.281562m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.388750m, 5.161562m, new DateTime(2019, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.337187m, 5.180521m, 44809600 },
                    { new Guid("7786dcdb-1637-466b-8b9c-de2b957923a4"), 5.642187m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.695312m, 5.593750m, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.695312m, 5.528135m, 31497600 },
                    { new Guid("779bce68-b533-48f3-a256-1ab5b9af3dac"), 9.600000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.845000m, 9.305000m, new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.550000m, 9.315546m, 65006000 },
                    { new Guid("77c25a29-98b1-4a92-84a0-ddd3cb73f75a"), 5.496875m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.730625m, 5.431250m, new DateTime(2019, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.650625m, 5.484759m, 54208000 },
                    { new Guid("78898880-009e-4698-8668-25dc89220999"), 8.412500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.745000m, 8.245000m, new DateTime(2019, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.445000m, 8.215714m, 66399200 },
                    { new Guid("78ff116b-03c5-4b28-939b-4ba896f7e113"), 13.300000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.700000m, 12.932500m, new DateTime(2020, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.567500m, 13.234415m, 37954800 },
                    { new Guid("791cc519-3c4e-4374-919c-a52bbbd2ca42"), 12.250000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.630000m, 11.805000m, new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.630000m, 12.319931m, 78799200 },
                    { new Guid("7960d132-c3e2-4cb9-9809-c605533721c6"), 5.100000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.179062m, 5.050000m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.084375m, 4.946332m, 23929600 },
                    { new Guid("79df2d31-06bb-41d8-a890-04de7716dea2"), 5.312812m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.661250m, 5.185312m, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.559375m, 5.396187m, 122038400 },
                    { new Guid("7bd81948-cfc5-4bb9-8310-9048c3d4beae"), 8.768750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.899687m, 8.671875m, new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.860937m, 8.620358m, 45667200 },
                    { new Guid("7c5dcc1a-ecb2-49b7-8722-54ca4f0d9c0b"), 13.500000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.762500m, 13.400000m, new DateTime(2020, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.500000m, 13.168572m, 33180800 },
                    { new Guid("7d207388-f7e3-42a5-a876-f13516a184b4"), 8.985000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.140000m, 8.862500m, new DateTime(2019, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.140000m, 8.891845m, 42718400 },
                    { new Guid("7d357463-4c80-4895-ae10-ded43f64b823"), 5.309687m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.316875m, 5.190937m, new DateTime(2019, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.225000m, 5.083139m, 13920000 },
                    { new Guid("7dea9bd6-6162-48ed-9196-c4aad9427e84"), 10.862500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.400000m, 10.800000m, new DateTime(2019, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.400000m, 11.111783m, 65134000 },
                    { new Guid("80884ef8-aae4-472e-89af-cc3b305a81b6"), 11.175000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.422500m, 11.140000m, new DateTime(2019, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.372500m, 11.084981m, 47984000 },
                    { new Guid("815d242d-94c0-4d5c-802c-1fb8e10ee052"), 8.850000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.087500m, 8.850000m, new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.952500m, 8.709436m, 46304000 },
                    { new Guid("815fdf43-8824-46ec-aa12-cf5b55b64a85"), 9.925000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.995000m, 9.700000m, new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.735000m, 9.488878m, 30410400 },
                    { new Guid("83805ede-871e-41e0-adae-3b29e7b87ffa"), 7.531250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.733437m, 7.468750m, new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.729687m, 7.519824m, 47913600 },
                    { new Guid("83d59d5c-3519-4ff1-b9fd-f744251a7e9a"), 5.452500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.453125m, 5.265625m, new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.303125m, 5.147460m, 25846400 },
                    { new Guid("8571bf1b-bb46-4b41-927a-f24359f94da7"), 12.037500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.250000m, 11.915000m, new DateTime(2019, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.132500m, 11.825764m, 41210000 },
                    { new Guid("859ecfe0-4e98-4376-b68e-9d90cf6d0b99"), 14.562500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.775000m, 14.375000m, new DateTime(2020, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.555000m, 14.197673m, 38234000 },
                    { new Guid("85eb7263-2498-4ce8-9afc-aedfd1c75781"), 10.550000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.795000m, 10.512500m, new DateTime(2019, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.667500m, 10.397802m, 42348000 },
                    { new Guid("8632b713-fa22-4eeb-861a-18cfb0d36cf9"), 12.200000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.275000m, 12.157500m, new DateTime(2019, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.272500m, 11.962226m, 19397200 },
                    { new Guid("86cf32ae-93bb-4d04-be78-42b5dc7cdf95"), 11.990000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.092500m, 11.882500m, new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.957500m, 11.655189m, 36261600 },
                    { new Guid("87097c38-b8dc-46bd-b57c-75337c8d7fd8"), 13.500000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.882500m, 12.885000m, new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.095000m, 12.773516m, 51324800 },
                    { new Guid("890c17a4-638c-4982-ada0-5680e4548ff1"), 10.620000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.800000m, 9.702500m, new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.747500m, 9.508198m, 97161600 },
                    { new Guid("8a30c94e-3d73-4516-92e5-d299f5f64712"), 9.145000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.145000m, 8.935000m, new DateTime(2019, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.997500m, 8.753214m, 24673600 },
                    { new Guid("8a4c2b13-0551-43f0-9c7a-9f4506268bcd"), 5.158437m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.400625m, 5.158437m, new DateTime(2019, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.275625m, 5.132390m, 33945600 },
                    { new Guid("8a7c4aac-3ad8-460f-ad4e-759903a9f9f2"), 7.343750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.511250m, 7.250000m, new DateTime(2019, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.251562m, 7.054679m, 61776000 },
                    { new Guid("8bf3edaa-e79b-4b7e-a26d-ffb0c839a6e8"), 5.656250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.672187m, 5.560625m, new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.589062m, 5.425004m, 22624000 }
                });

            migrationBuilder.InsertData(
                table: "Cotacao",
                columns: new[] { "Id", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("8c126ecc-369c-4a58-9c3c-84d02c5997f7"), 12.287500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.352500m, 12.037500m, new DateTime(2019, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.182500m, 11.874501m, 23699600 },
                    { new Guid("8cb5675b-7a67-4f9c-a0f0-151b313143c2"), 6.619687m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.902187m, 6.601250m, new DateTime(2019, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.901562m, 6.714182m, 43267200 },
                    { new Guid("8d3f58b2-5aa5-4c62-9038-4a28ee132c67"), 5.648437m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.745000m, 5.570312m, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.705312m, 5.537841m, 39078400 },
                    { new Guid("8d4e7058-7ea0-42bc-9806-999acaa63a7b"), 9.442500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.442500m, 8.992500m, new DateTime(2019, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.105000m, 8.857795m, 38738800 },
                    { new Guid("8dd7a9a7-08d4-4055-88c4-338193df0b3a"), 14.482500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.532500m, 13.957500m, new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.135000m, 13.787984m, 44558000 },
                    { new Guid("8e29fb34-bf96-43cd-b23e-a8b1d6b07948"), 5.500000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.623437m, 5.479375m, new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.592187m, 5.440356m, 37011200 },
                    { new Guid("8f18b4d0-6f80-48b0-b456-6bde8e72c8e2"), 5.737500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.976875m, 5.718750m, new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.976875m, 5.814600m, 68633600 },
                    { new Guid("902f830b-25ad-40d4-9e90-8971d2ca715a"), 5.465312m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.593750m, 5.412812m, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.475625m, 5.314896m, 28412800 },
                    { new Guid("912b4ecb-a121-46df-be75-f138e558009a"), 11.125000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.325000m, 10.872500m, new DateTime(2019, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.300000m, 11.014312m, 47176000 },
                    { new Guid("91334857-ce53-4f10-9e06-09ef5decc30c"), 13.050000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.557500m, 13.037500m, new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.557500m, 13.224661m, 34307200 },
                    { new Guid("91a9aa0d-8fff-4137-ace0-b5ad4b121dda"), 10.625000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.690000m, 8.552500m, new DateTime(2020, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.500000m, 10.242224m, 120562800 },
                    { new Guid("91f00b94-ab4e-48b0-a990-329e3a8c9574"), 10.877500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.197500m, 10.737500m, new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.952500m, 10.675598m, 42558800 },
                    { new Guid("9208f3f1-1f22-41de-968b-2a21c663e378"), 10.000000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.542500m, 9.975000m, new DateTime(2019, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.542500m, 10.275963m, 44124800 },
                    { new Guid("94af8b37-568b-4e93-affd-5214c89d39a8"), 9.375000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.507500m, 9.027500m, new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.077500m, 8.831042m, 40306800 },
                    { new Guid("950802c6-f89e-491e-9b41-5e7e9c5bc7e9"), 5.702812m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.735000m, 5.500000m, new DateTime(2019, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.526562m, 5.376514m, 25910400 },
                    { new Guid("954be0ba-1c42-45bc-b46f-b6a0a69a7f85"), 6.585937m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.640625m, 6.531250m, new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.639375m, 6.459113m, 22755200 },
                    { new Guid("958d866f-d38d-40d8-b221-3a0af67b599e"), 10.860000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.987500m, 10.587500m, new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.750000m, 10.478217m, 28584400 },
                    { new Guid("9607660e-ea4e-4b11-acba-9de9a0c8d12e"), 7.409375m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.841875m, 7.409375m, new DateTime(2019, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.637187m, 7.429834m, 83689600 },
                    { new Guid("96b669f9-a1d3-46af-b100-1ebcc2936793"), 9.140000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.325000m, 9.012500m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.325000m, 9.071821m, 23190000 },
                    { new Guid("970405fc-e707-4d58-a115-5c4735866ba0"), 10.272500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.525000m, 10.167500m, new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.477500m, 10.220276m, 33824400 },
                    { new Guid("9727b8ab-1d04-4f0a-a672-acfe74ba4ea6"), 5.625000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.687500m, 5.410312m, new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.504687m, 5.343105m, 43971200 },
                    { new Guid("976fc61f-8b98-45fb-8291-1fa1a2d732c7"), 6.003125m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.109375m, 6.003125m, new DateTime(2019, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.046875m, 5.882699m, 29065600 },
                    { new Guid("97744e60-f519-4b9d-b9d9-3a5be0ee1779"), 8.897500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.265000m, 8.882500m, new DateTime(2019, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.150000m, 8.901573m, 69824400 },
                    { new Guid("9847559a-b419-4f01-af8f-8fe0f79e5e15"), 9.650000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.937500m, 9.540000m, new DateTime(2019, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.600000m, 9.339356m, 39637200 },
                    { new Guid("9a5a6325-9e13-4f93-9502-90e3a51183ce"), 14.500000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.537500m, 13.950000m, new DateTime(2020, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.957500m, 13.614841m, 41164000 },
                    { new Guid("9b0d495c-6946-475a-9d7f-73bb0c0f7790"), 14.192500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.262500m, 14.000000m, new DateTime(2020, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.037500m, 13.692876m, 30074800 },
                    { new Guid("9b55d4cd-ebb2-42f1-b588-f1275f98f5eb"), 10.872500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.987500m, 10.790000m, new DateTime(2019, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.812500m, 10.539137m, 23944400 },
                    { new Guid("9c17f6a5-f05c-421c-83fa-a342a542ffe2"), 11.375000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.377500m, 11.075000m, new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.075000m, 10.795001m, 36308000 },
                    { new Guid("9c2b332b-e94b-4e45-b6c8-4a743552d0a9"), 13.502500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.247500m, 13.502500m, new DateTime(2020, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.247500m, 13.897720m, 41425600 },
                    { new Guid("9c9fba0e-c4c0-417f-8f3c-1e67492472ea"), 9.400000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.575000m, 9.355000m, new DateTime(2019, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.462500m, 9.205588m, 64444400 },
                    { new Guid("9d368b76-ef5f-4180-8a1a-adffcd179390"), 14.127500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.275000m, 13.707500m, new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.922500m, 13.580700m, 36062400 },
                    { new Guid("9ec45baf-7821-4de0-8c87-150dbbd83745"), 5.333437m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.405625m, 5.265625m, new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.389375m, 5.243051m, 26000000 },
                    { new Guid("9f087f30-ada6-4cca-b44c-f8b6fc4284aa"), 9.755000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.590000m, 9.695000m, new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.090000m, 9.842289m, 97178400 },
                    { new Guid("a00460d8-027a-400f-b11b-ab4c1cd337d8"), 10.675000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.087500m, 10.650000m, new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.792500m, 10.519643m, 53416000 },
                    { new Guid("a05fe318-21cb-4be8-95eb-515f9bcca571"), 5.656250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.687500m, 5.554687m, new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.597187m, 5.432890m, 24796800 },
                    { new Guid("a163979b-d264-41b7-a253-30390177a733"), 5.531250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.670625m, 5.504687m, new DateTime(2019, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.638125m, 5.472626m, 43244800 },
                    { new Guid("a1915c13-2c4f-4aaf-98ac-45a1ad6d7b6e"), 12.035000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.197500m, 11.192500m, new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.242500m, 10.958266m, 125373600 },
                    { new Guid("a255e178-6644-4b1d-9e79-33bf2676ea00"), 5.328750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.353125m, 5.160937m, new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.233750m, 5.080121m, 36246400 },
                    { new Guid("a3074adc-f4da-414a-ad9e-8b70f48fd584"), 6.530937m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.718750m, 6.418750m, new DateTime(2019, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.611562m, 6.432055m, 47436800 },
                    { new Guid("a3e0246d-74a3-493d-9418-755d500e9220"), 5.248437m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.398750m, 5.212812m, new DateTime(2019, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.283437m, 5.128349m, 40563200 },
                    { new Guid("a45b3e21-e22d-43e1-aa91-96eccd8bc88f"), 5.656250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.673125m, 5.547187m, new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.550000m, 5.387088m, 37481600 },
                    { new Guid("a50513f3-5d4c-41ac-a2bf-0b7492fd246c"), 6.093750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.280000m, 6.063437m, new DateTime(2019, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.256562m, 6.086694m, 49232000 }
                });

            migrationBuilder.InsertData(
                table: "Cotacao",
                columns: new[] { "Id", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("a523237d-6ad4-4833-989d-6766a650fb82"), 13.530000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.000000m, 13.512500m, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.000000m, 13.656297m, 29623600 },
                    { new Guid("a7168cda-0b99-4c6a-957c-d0423599c8b3"), 6.630000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.684375m, 6.519375m, new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.561875m, 6.383717m, 27094400 },
                    { new Guid("a790696d-cd78-4826-bf47-7699d5490609"), 7.245312m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.318437m, 7.232812m, new DateTime(2019, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.312500m, 7.113962m, 22313600 },
                    { new Guid("a7937420-f8e8-4769-a57b-2b8f6538e04f"), 5.946875m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.106250m, 5.847187m, new DateTime(2019, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.914687m, 5.754100m, 45321600 },
                    { new Guid("a809a311-ddb4-4c79-b2ba-3270dfcdedee"), 5.250000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.374375m, 5.237812m, new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.301875m, 5.146246m, 30272000 },
                    { new Guid("ac98e7b1-0ed6-427f-ae56-1ac2e00bb391"), 12.200000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.247500m, 11.877500m, new DateTime(2019, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.925000m, 11.623511m, 32350400 },
                    { new Guid("acf93695-6cfd-4d83-92fd-39c73468aacb"), 9.202500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.317500m, 9.127500m, new DateTime(2019, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.142500m, 8.894277m, 27740400 },
                    { new Guid("ad689ac6-968f-4aa1-aa4c-586e8e8df1d8"), 11.720000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.975000m, 11.662500m, new DateTime(2019, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.895000m, 11.594270m, 45071600 },
                    { new Guid("afe0e867-689c-4e9a-813d-0ffcc752c224"), 5.586250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.621875m, 5.428125m, new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.428125m, 5.268791m, 41360000 },
                    { new Guid("b19ed336-d576-4026-b2dd-f65b2944ac65"), 7.694375m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.931250m, 7.653125m, new DateTime(2019, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.875000m, 7.661191m, 37884800 },
                    { new Guid("b30fb345-87cd-4a00-80e8-e153262d23da"), 13.930000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.185000m, 13.902500m, new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.977500m, 13.634349m, 32257200 },
                    { new Guid("b339d9e9-4f47-4b0a-8b9e-d09316b1e223"), 9.350000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.730000m, 9.325000m, new DateTime(2019, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.695000m, 9.431776m, 59760000 },
                    { new Guid("b5156bd2-d787-487a-b230-3c139d5db4e8"), 7.368750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.368750m, 7.160937m, new DateTime(2019, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.211562m, 7.015765m, 34518400 },
                    { new Guid("b61a77b8-d959-4452-8e7f-4ce5f86f2a93"), 10.360000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.650000m, 10.022500m, new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.022500m, 9.776446m, 78595200 },
                    { new Guid("b7b8ef45-c8b4-4c3d-bbe6-fcb9f26c998c"), 9.225000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.225000m, 8.810000m, new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.077500m, 8.831042m, 46431600 },
                    { new Guid("b83123c8-50f6-4818-92c6-a63eee65ee33"), 5.638125m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.812187m, 5.594687m, new DateTime(2019, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.812187m, 5.641579m, 27017600 },
                    { new Guid("b8e22254-ea21-406a-ba4a-ad169b5e78dd"), 9.287500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.665000m, 9.285000m, new DateTime(2019, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.445000m, 9.188563m, 48288400 },
                    { new Guid("b90e9e21-6ab6-481d-b2a7-6fd7ed7d1bb5"), 14.120000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.237500m, 13.915000m, new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.132500m, 13.785544m, 24566000 },
                    { new Guid("b9ec438e-fd94-478b-99db-f24a90eb6bd1"), 6.000000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.125000m, 5.989062m, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.125000m, 5.958704m, 27113600 },
                    { new Guid("ba79a341-641a-4436-a838-05d0e37f0348"), 6.468750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.593750m, 6.409062m, new DateTime(2019, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.562500m, 6.384326m, 83241600 },
                    { new Guid("bb97e3fe-18b4-4374-a55b-4f5b7f5b8cd7"), 5.534375m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.562500m, 5.411875m, new DateTime(2019, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.468750m, 5.308223m, 35452800 },
                    { new Guid("bd139593-f533-4e1d-92f9-636f8229fafe"), 9.287500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.362500m, 9.177500m, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.362500m, 9.108305m, 25854800 },
                    { new Guid("bd165aa5-adf7-41b3-a652-85c6968030eb"), 10.797500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.995000m, 10.792500m, new DateTime(2019, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.930000m, 10.653667m, 23985600 },
                    { new Guid("bf8e5e4f-ef91-48be-a02e-171be5e5e95d"), 13.925000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.982500m, 13.375000m, new DateTime(2020, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.557500m, 13.224661m, 39083200 },
                    { new Guid("bfd4b681-b913-423e-b22f-2172e8410fd5"), 5.121250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.266875m, 5.078125m, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.266875m, 5.112274m, 14982400 },
                    { new Guid("c1f37933-ae0a-4f15-9a05-81fc9e949c6a"), 9.187500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.305000m, 9.135000m, new DateTime(2019, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.260000m, 9.008588m, 20688400 },
                    { new Guid("c2164302-5b02-440d-9147-21bc62c079b9"), 10.160000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.100000m, 10.065000m, new DateTime(2020, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.280000m, 10.027623m, 91541200 },
                    { new Guid("c23bc4ba-4c18-4805-ad99-4b66a6512118"), 13.170000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.700000m, 12.917500m, new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.212500m, 12.888129m, 58392000 },
                    { new Guid("c270e9f9-fedd-42fe-9612-80274ba23303"), 8.421875m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.726250m, 8.384375m, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.640625m, 8.406029m, 79395200 },
                    { new Guid("c30bb1f4-bfc3-4316-9cde-d7ba691e7d47"), 8.450000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.717500m, 8.192500m, new DateTime(2019, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.717500m, 8.480815m, 42700800 },
                    { new Guid("c364afbf-c476-4bc2-b8b0-0870b8615c8f"), 12.075000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.332500m, 11.927500m, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.332500m, 12.029735m, 29600800 },
                    { new Guid("c3a1bcc3-e960-4544-b1bb-e9fce8e859c8"), 7.343750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.355937m, 7.188437m, new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.207812m, 7.012116m, 29961600 },
                    { new Guid("c4bf1169-dc22-4965-bc9d-aa8238436a64"), 5.219062m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.255937m, 5.103125m, new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.150000m, 4.998830m, 32627200 },
                    { new Guid("c666336a-a800-4c9c-b0bd-0b17a412de09"), 7.740625m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.758125m, 7.566562m, new DateTime(2019, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.640000m, 7.432570m, 35929600 },
                    { new Guid("c69d5ad0-6758-4e74-83b6-2a0129093f9e"), 9.140000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.210000m, 9.037500m, new DateTime(2019, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.200000m, 8.950214m, 16346400 },
                    { new Guid("c6b5bf44-4692-44ab-a5bc-e8b2575cd6e5"), 9.175000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.335000m, 9.137500m, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.285000m, 9.032908m, 39026400 },
                    { new Guid("c766c25a-e2e0-4239-9f22-39989e4b76de"), 11.350000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.625000m, 11.330000m, new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.462500m, 11.172703m, 51046000 },
                    { new Guid("c898d051-da9f-4354-aba1-008565699616"), 9.000000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.707500m, 7.642500m, new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.500000m, 8.291323m, 70036800 },
                    { new Guid("c8c6718a-19bf-4dbc-a554-9f3d770cd1f1"), 10.250000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.505000m, 9.950000m, new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.400000m, 10.144677m, 75768800 },
                    { new Guid("c99c80f3-b80a-4e4b-b161-43f428259adf"), 13.730000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.325000m, 13.525000m, new DateTime(2020, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.262500m, 13.912353m, 54978400 },
                    { new Guid("cb131743-b9aa-4e30-8f1b-f0ffe4999c9a"), 11.032500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.602500m, 10.762500m, new DateTime(2020, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.332500m, 11.054286m, 113371200 },
                    { new Guid("cc2c984c-998c-4eef-852d-8ec664d267a3"), 6.628125m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.749687m, 6.463125m, new DateTime(2019, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.484375m, 6.308321m, 44108800 }
                });

            migrationBuilder.InsertData(
                table: "Cotacao",
                columns: new[] { "Id", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("ccdfa5e8-781a-4c57-bcbc-98a41560be2f"), 5.192187m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.261250m, 5.109375m, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.197187m, 5.044631m, 33910400 },
                    { new Guid("cd4e2063-9a42-444e-92d8-1292ef9c044f"), 5.899062m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.017187m, 5.871875m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.960625m, 5.798791m, 43356800 },
                    { new Guid("ce5aa015-3367-4bf8-b15e-94601f30eeae"), 10.795000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.847500m, 10.157500m, new DateTime(2019, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.287500m, 10.027411m, 49930800 },
                    { new Guid("cf86a03b-0f89-4103-9f2c-6c488cd85bc1"), 5.465625m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.518437m, 5.430625m, new DateTime(2019, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.518437m, 5.356452m, 24489600 },
                    { new Guid("d004d1f3-a22d-4e20-ac34-a2076d8c7a25"), 5.381250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.400625m, 5.211562m, new DateTime(2019, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.218750m, 5.077058m, 56912000 },
                    { new Guid("d03fe7a0-ddfe-4c82-acf8-3edcb898381f"), 11.237500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.825000m, 11.227500m, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.797500m, 11.499234m, 92438400 },
                    { new Guid("d09a9ed2-4dc2-4f17-be39-9418b6ca5533"), 14.092500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.175000m, 13.755000m, new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.125000m, 13.778227m, 44303600 },
                    { new Guid("d0a30355-1019-49ec-b6dd-6176c6576c8e"), 13.910000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.287500m, 13.800000m, new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.950000m, 13.607524m, 38781200 },
                    { new Guid("d0af1b26-34e5-4222-aaa9-67718a48fb8f"), 10.067500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.550000m, 9.860000m, new DateTime(2020, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.490000m, 10.232468m, 63285200 },
                    { new Guid("d23752a2-67f6-45d9-a738-ae55fb7a63b7"), 8.565000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.732500m, 8.455000m, new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.552500m, 8.320294m, 52060400 },
                    { new Guid("d3d91fa0-b465-4a51-8805-0760e7c420d7"), 6.937500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.130312m, 6.889375m, new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.065000m, 6.873182m, 31500800 },
                    { new Guid("d49434b1-cd76-416b-9fc2-ac97e3176d2f"), 5.617187m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.712187m, 5.603437m, new DateTime(2019, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.646875m, 5.481119m, 21654400 },
                    { new Guid("d5fcbaa4-e8bf-4f51-9f8f-366b702ba360"), 8.250000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.327500m, 7.907500m, new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.125000m, 7.904402m, 96050400 },
                    { new Guid("d6c8404f-154c-4a23-bf80-ed1ec2cdf689"), 5.961562m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.201562m, 5.954062m, new DateTime(2019, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.201562m, 6.033187m, 31520000 },
                    { new Guid("d74bb964-0d94-4b04-bbdc-02a9a2b2b869"), 6.956875m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.000000m, 6.909375m, new DateTime(2019, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.909375m, 6.721782m, 36316800 },
                    { new Guid("d8c8630c-7456-417e-8998-4574f3e8587e"), 5.647187m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.696875m, 5.598750m, new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.675937m, 5.509328m, 23216000 },
                    { new Guid("d8f1f9c2-91af-4374-a976-f8e6adba57fc"), 11.250000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.752500m, 10.570000m, new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.747500m, 11.459097m, 82114000 },
                    { new Guid("d9359b21-5c8e-4bf6-a7e1-22794a79d77c"), 5.311875m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.475000m, 5.287812m, new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.406250m, 5.259468m, 32944000 },
                    { new Guid("d947dbdc-540e-42fa-9f2f-0e07c37867e3"), 12.235000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.300000m, 12.125000m, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.197500m, 11.898048m, 26818800 },
                    { new Guid("da26947d-611d-4b89-8e74-3f23d027ec19"), 9.025000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.250000m, 8.992500m, new DateTime(2019, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.192500m, 8.942920m, 37714800 },
                    { new Guid("dcd4cc53-e762-40c9-975e-15060e9baf7b"), 5.527812m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.542500m, 5.462500m, new DateTime(2019, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.484375m, 5.323390m, 14454400 },
                    { new Guid("dd516abe-1c9f-40d7-9c2c-011a5f383ada"), 5.496250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.677812m, 5.487812m, new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.606562m, 5.454341m, 37299200 },
                    { new Guid("dd7fe233-e758-4ad0-9174-992dbbf154f8"), 9.070000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.345000m, 8.945000m, new DateTime(2019, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.970000m, 8.726461m, 29592000 },
                    { new Guid("de4ad8f5-2fb7-4d00-ad94-5eca6d2bb016"), 14.377500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.522500m, 14.162500m, new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.322500m, 13.970881m, 39798000 },
                    { new Guid("df0b99bc-6b9c-40da-baaf-7f308e119fd4"), 10.550000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.700000m, 10.307500m, new DateTime(2019, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.450000m, 10.185802m, 38353200 },
                    { new Guid("e1f76b88-f2c6-45f4-8967-434b71d89391"), 12.100000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.327500m, 11.950000m, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.232500m, 11.932190m, 27359200 },
                    { new Guid("e2dadaaf-29bf-43f3-91dd-8f5b83040099"), 5.719062m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.781250m, 5.562500m, new DateTime(2019, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.570312m, 5.419076m, 32684800 },
                    { new Guid("e40cea07-de11-41ff-b405-f88c701ed983"), 5.250312m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.357500m, 5.250000m, new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.343750m, 5.198665m, 16678400 },
                    { new Guid("e540ec82-765d-435c-9dd7-a274b4865407"), 7.593750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 7.784375m, 7.593750m, new DateTime(2019, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.681562m, 7.473004m, 27779200 },
                    { new Guid("e5e7f121-5fca-457b-ad6d-7d2bc2aba737"), 6.593750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.686875m, 6.589687m, new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.645312m, 6.464888m, 39737600 },
                    { new Guid("e6de819d-393b-43e6-8b5e-f1756b10a1d8"), 5.780937m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.796562m, 5.605000m, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.750000m, 5.581217m, 26342400 },
                    { new Guid("e7e19e41-3ed5-4043-8112-b17289e054ef"), 13.000000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.000000m, 11.650000m, new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.947500m, 11.654186m, 84786000 },
                    { new Guid("e7f164cd-6756-43f6-b79c-51b64b2dc8c4"), 13.022500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.262500m, 12.762500m, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.950000m, 12.632074m, 37484400 },
                    { new Guid("e938ad7f-007a-484a-9a42-87716d4dd7ac"), 6.187500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.218437m, 6.000000m, new DateTime(2019, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.078750m, 5.913710m, 26220800 },
                    { new Guid("e9949a63-3b1e-4e6e-8afc-29fcaf20680a"), 9.022500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.040000m, 8.377500m, new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.550000m, 8.317863m, 57427200 },
                    { new Guid("ea4fbfee-9289-4297-a3e5-29e7d080adf4"), 8.371875m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.437500m, 8.135625m, new DateTime(2019, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.241250m, 8.017494m, 50419200 },
                    { new Guid("eb564dee-7b8c-4e0b-a386-707ad502933e"), 5.331562m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.481250m, 5.212500m, new DateTime(2019, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.212500m, 5.059494m, 37664000 },
                    { new Guid("ebb2160d-960a-4555-b209-c470d44cc41d"), 5.765625m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.789062m, 5.625000m, new DateTime(2019, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.625625m, 5.472887m, 29926400 },
                    { new Guid("ec4550f2-c8ae-4e5b-a093-bd4eaf5eee73"), 6.296875m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.322187m, 5.977500m, new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.004687m, 5.841657m, 54857600 },
                    { new Guid("ed830505-b4fd-44ea-aab6-953ea895a436"), 5.312500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.354687m, 5.235312m, new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.281250m, 5.126227m, 22780800 },
                    { new Guid("ee31c8eb-3101-4d13-8e67-516cc298207e"), 12.150000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.312500m, 12.100000m, new DateTime(2019, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.185000m, 11.876938m, 26009200 },
                    { new Guid("ee4bf571-7f76-4a3f-8d0b-dca51999cd32"), 11.450000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.477500m, 11.257500m, new DateTime(2019, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.257500m, 10.972886m, 45510400 }
                });

            migrationBuilder.InsertData(
                table: "Cotacao",
                columns: new[] { "Id", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("ee7089bd-0b93-4400-aefb-a9f6725f338e"), 5.124687m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.317500m, 5.087812m, new DateTime(2019, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.300000m, 5.144426m, 38249600 },
                    { new Guid("eeb9bd83-c0eb-49b8-82fa-c354d316380e"), 6.531250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 6.593437m, 6.453125m, new DateTime(2019, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.453437m, 6.278223m, 33401600 },
                    { new Guid("ef0007a3-79ef-4792-b173-42c345254328"), 12.625000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.057500m, 12.605000m, new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.020000m, 12.700356m, 44120000 },
                    { new Guid("ef514759-c7fb-43ad-9354-035e8052f900"), 5.389687m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.389687m, 5.171875m, new DateTime(2019, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.192187m, 5.039778m, 35606400 },
                    { new Guid("f0181d5a-b80e-43f5-8334-d3aa409c09c6"), 12.155000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.257500m, 11.990000m, new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.147500m, 11.840387m, 36742800 },
                    { new Guid("f04fe189-7f07-48f7-bf94-6607de70b480"), 8.502500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.745000m, 8.375000m, new DateTime(2019, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.727500m, 8.490545m, 44195600 },
                    { new Guid("f075f90b-9fca-4e48-b444-1913eb6dc536"), 11.362500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.412500m, 11.130000m, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.230000m, 10.946081m, 39413200 },
                    { new Guid("f0c2488e-3ae0-448d-a978-22859d443f46"), 5.024375m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.352187m, 5.010937m, new DateTime(2019, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.337500m, 5.192585m, 44016000 },
                    { new Guid("f10beef9-1ebd-4608-8100-21ca2fe7be47"), 5.359062m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.562187m, 5.328125m, new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.535937m, 5.373438m, 39683200 },
                    { new Guid("f1c1f7a5-3ddd-492d-ba33-091e273aaac1"), 5.578125m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.611875m, 5.462812m, new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.500000m, 5.338556m, 25504000 },
                    { new Guid("f1ef8072-4b91-47ea-8a74-0c481907bfc3"), 9.555000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.675000m, 8.777500m, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.972500m, 8.752222m, 82290000 },
                    { new Guid("f353cbdf-c147-4085-80cb-76e86d072804"), 5.621875m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.684062m, 5.397500m, new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.415625m, 5.256658m, 44316800 },
                    { new Guid("f5a1c593-55aa-4fbd-ad12-5c77370bb821"), 13.762500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.825000m, 13.437500m, new DateTime(2020, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.450000m, 13.119799m, 30095200 },
                    { new Guid("f6f3dcf4-ae0c-470e-9efa-5b94d299cd99"), 10.715000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 10.720000m, 10.425000m, new DateTime(2019, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.625000m, 10.356378m, 91291200 },
                    { new Guid("f8f41e46-945e-4ec4-af2a-c99a83d7c2d2"), 12.125000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.332500m, 12.075000m, new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.222500m, 11.922435m, 26737600 },
                    { new Guid("fa573dde-c79a-4454-9c3e-0349370514b6"), 5.562500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.702500m, 5.539687m, new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.661562m, 5.495375m, 21174400 },
                    { new Guid("fa9c1d9d-085d-48c0-93e4-e40afbb8fe61"), 13.000000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 13.350000m, 12.505000m, new DateTime(2020, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.562500m, 12.254089m, 58818800 },
                    { new Guid("fbdee089-ad5e-4c50-a84a-0734fed5ba61"), 8.805000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.817500m, 8.512500m, new DateTime(2019, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.525000m, 8.293542m, 31115200 },
                    { new Guid("fc7244c4-3ad0-43fc-b672-b4e23116bfc3"), 8.200000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 9.017500m, 7.662500m, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.662500m, 7.474384m, 113467200 },
                    { new Guid("fc89b0a9-c83a-46f4-82fe-12e7ec1900b6"), 5.311250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.311875m, 5.140937m, new DateTime(2019, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.166562m, 5.014905m, 21715200 },
                    { new Guid("fd4f51ab-6258-4fcf-b7a0-6570a5994c3f"), 14.400000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 14.667500m, 14.282500m, new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.415000m, 14.061110m, 32872800 },
                    { new Guid("fdbc82f9-bafb-4044-9072-9015ff91d192"), 8.243750m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 8.482500m, 8.219375m, new DateTime(2019, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.267187m, 8.042729m, 56502400 },
                    { new Guid("fe7214eb-df09-4e7b-bf49-7b7ae318a7a4"), 12.372500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 12.470000m, 12.165000m, new DateTime(2019, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.325000m, 12.013398m, 42746000 },
                    { new Guid("fe9be237-d18d-4e00-a4b3-842fc3424e53"), 5.625000m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.653125m, 5.486875m, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.530312m, 5.367978m, 32902400 },
                    { new Guid("ff9f18a6-38bb-49d1-be91-0e16ef3acbbf"), 5.381250m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 5.435937m, 5.343750m, new DateTime(2019, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.401562m, 5.243007m, 22960000 },
                    { new Guid("fffe684f-f452-43fc-8bd8-18372cc6fe65"), 11.332500m, new Guid("64f12654-5246-4d0c-8487-f0f71e197781"), 11.512500m, 11.207500m, new DateTime(2019, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.400000m, 11.111783m, 48190000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cotacao_AcaoId",
                table: "Cotacao",
                column: "AcaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cotacao");

            migrationBuilder.DropTable(
                name: "Acao");
        }
    }
}
