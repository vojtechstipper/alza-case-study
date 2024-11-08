using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlzaProduct.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(18)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImgUri", "Name", "Price" },
                values: new object[,]
                {
                    { "0081d8f6-c794-4cd6-b5d5-146eddfe2fa1", "Description 59", "https://via.placeholder.com/150", "Product 59", 775.66m },
                    { "04f331fc-2f88-4c20-a9a4-3bfae1421557", "Description 87", "https://via.placeholder.com/150", "Product 87", 671.95m },
                    { "08de68db-5596-49ea-b5cf-70489f4ffdb8", "Description 1", "https://via.placeholder.com/150", "Product 1", 129.59m },
                    { "0a55445d-2f8f-4173-bf30-8b2239fa1529", "Description 38", "https://via.placeholder.com/150", "Product 38", 656.32m },
                    { "0b3880bb-9a91-40bc-8ef0-6dc897126e70", "Description 64", "https://via.placeholder.com/150", "Product 64", 244.31m },
                    { "101349ef-0c5a-475b-a9a1-0c29967bf74f", "Description 98", "https://via.placeholder.com/150", "Product 98", 981.28m },
                    { "1728b057-7e69-4b99-8898-349d7db98932", "Description 92", "https://via.placeholder.com/150", "Product 92", 140.69m },
                    { "17469621-4a74-4c3b-8ccb-662c0cac87e8", "Description 3", "https://via.placeholder.com/150", "Product 3", 363.80m },
                    { "19a8e425-d37b-434e-804e-27eafa5fbaeb", "Description 10", "https://via.placeholder.com/150", "Product 10", 336.29m },
                    { "19daa9ed-0d56-4e2d-a718-4d3bf8491444", "Description 22", "https://via.placeholder.com/150", "Product 22", 238.89m },
                    { "205f0044-73c7-44dd-8c7e-44423149b9fd", "Description 60", "https://via.placeholder.com/150", "Product 60", 677.13m },
                    { "21a9bbc6-8215-42e2-864a-f9c635dc6907", "Description 65", "https://via.placeholder.com/150", "Product 65", 811.07m },
                    { "22606302-aeaa-4339-8397-8c2a176bbf63", "Description 63", "https://via.placeholder.com/150", "Product 63", 816.87m },
                    { "228e2437-1a7d-4a08-829d-3d519cb89441", "Description 94", "https://via.placeholder.com/150", "Product 94", 820.07m },
                    { "23752181-8071-4b2a-936a-e9479acbb139", "Description 95", "https://via.placeholder.com/150", "Product 95", 225.65m },
                    { "26be1feb-e4ab-4cf6-85f4-48471c66926b", "Description 49", "https://via.placeholder.com/150", "Product 49", 753.75m },
                    { "28d47b67-ddca-4c2f-a11c-74c0ec8f31b0", "Description 79", "https://via.placeholder.com/150", "Product 79", 958.50m },
                    { "2d8a9129-60ce-4f4d-ab30-91ad51aa2f41", "Description 28", "https://via.placeholder.com/150", "Product 28", 245.39m },
                    { "2ec1bf5c-d11a-4fd4-9073-9c280f6a20bd", "Description 8", "https://via.placeholder.com/150", "Product 8", 475.95m },
                    { "2f331b91-8564-44a4-9786-8123620415dc", "Description 55", "https://via.placeholder.com/150", "Product 55", 421.20m },
                    { "37dd476b-9f66-40b0-b74b-061c75de8453", "Description 70", "https://via.placeholder.com/150", "Product 70", 846.51m },
                    { "3acd5902-ff03-4264-a065-b8f47b520a34", "Description 19", "https://via.placeholder.com/150", "Product 19", 848.56m },
                    { "3be33575-bd9b-4b12-adfd-40c45deb5095", "Description 52", "https://via.placeholder.com/150", "Product 52", 393.30m },
                    { "3d351912-c96b-4156-b4e3-118746530eb4", "Description 43", "https://via.placeholder.com/150", "Product 43", 637.23m },
                    { "3eca1561-b9c8-4169-a4ad-5ca052e320ae", "Description 97", "https://via.placeholder.com/150", "Product 97", 887.56m },
                    { "4196950e-5ff8-45ce-81f9-d343cfb1c55d", "Description 57", "https://via.placeholder.com/150", "Product 57", 739.97m },
                    { "449798b6-6045-44a6-a417-0ea129487eeb", "Description 81", "https://via.placeholder.com/150", "Product 81", 297.43m },
                    { "45223532-5313-49ad-b991-6a54e30638ce", "Description 96", "https://via.placeholder.com/150", "Product 96", 278.92m },
                    { "483cd807-e136-43f7-9285-d199591d05ea", "Description 39", "https://via.placeholder.com/150", "Product 39", 505.28m },
                    { "4a21f55f-8183-4847-b99f-f254f4bb7d59", "Description 17", "https://via.placeholder.com/150", "Product 17", 302.10m },
                    { "4a9bb231-f772-4010-b682-eb08edcb7db2", "Description 18", "https://via.placeholder.com/150", "Product 18", 513.67m },
                    { "4b1015d8-9177-4e2b-8f85-e9b91403350d", "Description 51", "https://via.placeholder.com/150", "Product 51", 564.88m },
                    { "4db44798-0143-4a5e-8ce9-50218bfae1ee", "Description 73", "https://via.placeholder.com/150", "Product 73", 712.76m },
                    { "4e4fdd5c-3dae-48a5-ba98-b4455120346d", "Description 4", "https://via.placeholder.com/150", "Product 4", 113.40m },
                    { "51c9da66-0892-4683-ba8d-951daea7166a", "Description 5", "https://via.placeholder.com/150", "Product 5", 899.00m },
                    { "526195e8-de6e-4aa7-9bee-211d225c1e49", "Description 62", "https://via.placeholder.com/150", "Product 62", 877.65m },
                    { "55a91ef7-1985-4c96-8d8e-a5b26956ff4a", "Description 88", "https://via.placeholder.com/150", "Product 88", 758.88m },
                    { "586f5266-b304-40dc-94b0-c0ad2350be97", "Description 37", "https://via.placeholder.com/150", "Product 37", 243.74m },
                    { "5b223af9-c031-4ee7-8ad0-3d04a7624cdb", "Description 6", "https://via.placeholder.com/150", "Product 6", 612.20m },
                    { "5c63c4ae-15fc-49d6-ab9c-b551cf1773fb", "Description 45", "https://via.placeholder.com/150", "Product 45", 191.21m },
                    { "5d6a0a14-83bf-4cba-ae8e-67c0502b4f69", "Description 78", "https://via.placeholder.com/150", "Product 78", 549.59m },
                    { "66251bb4-0d58-4d6c-9cc4-5db609904616", "Description 77", "https://via.placeholder.com/150", "Product 77", 479.08m },
                    { "666c3594-112b-45f4-a53b-5028533452e6", "Description 80", "https://via.placeholder.com/150", "Product 80", 131.57m },
                    { "66a50667-33aa-4014-b427-48a0c5b6eeec", "Description 71", "https://via.placeholder.com/150", "Product 71", 370.54m },
                    { "6d6d74b7-8eae-4ad8-bd24-d3640450734f", "Description 82", "https://via.placeholder.com/150", "Product 82", 262.10m },
                    { "6fc20ff2-1fe9-457f-b1e8-0a4074b3bd1d", "Description 68", "https://via.placeholder.com/150", "Product 68", 405.24m },
                    { "76552437-df18-4fa6-824a-679c2f24c73a", "Description 86", "https://via.placeholder.com/150", "Product 86", 365.37m },
                    { "767d60f8-b344-455b-9011-d36eeda7d6e2", "Description 26", "https://via.placeholder.com/150", "Product 26", 372.20m },
                    { "77a328ed-ea45-4942-9427-4af5c33690c7", "Description 14", "https://via.placeholder.com/150", "Product 14", 907.78m },
                    { "77fc32b3-2e9c-4295-b49d-df7fafd9e1da", "Description 16", "https://via.placeholder.com/150", "Product 16", 461.67m },
                    { "802b533b-b113-44d3-8626-aa8e47bd059e", "Description 54", "https://via.placeholder.com/150", "Product 54", 960.18m },
                    { "84a0259b-7433-472a-8b3f-97a811cc9f8b", "Description 44", "https://via.placeholder.com/150", "Product 44", 929.58m },
                    { "87b25e8f-3cbf-4a31-a805-a1aa031dea75", "Description 7", "https://via.placeholder.com/150", "Product 7", 636.05m },
                    { "91534f77-cc29-49d6-a8ae-dcc0d750cc44", "Description 11", "https://via.placeholder.com/150", "Product 11", 347.68m },
                    { "93c8ebe5-fe3e-44e0-95ba-c3903c51307b", "Description 91", "https://via.placeholder.com/150", "Product 91", 776.22m },
                    { "942792b2-ca4e-4768-a978-409e45f156d1", "Description 61", "https://via.placeholder.com/150", "Product 61", 969.91m },
                    { "969b2c8c-b3f1-4617-b24e-e1579e53d5f1", "Description 53", "https://via.placeholder.com/150", "Product 53", 868.35m },
                    { "96ef1478-e86f-49da-89ce-1037795ad5fd", "Description 85", "https://via.placeholder.com/150", "Product 85", 519.58m },
                    { "97270f45-6245-47d6-b2ef-0006eb7cadb3", "Description 32", "https://via.placeholder.com/150", "Product 32", 210.94m },
                    { "9770ba20-4bd2-4248-9b0a-c0eb214d3c92", "Description 41", "https://via.placeholder.com/150", "Product 41", 830.81m },
                    { "989c28d5-df87-4e49-80a5-83ce75ab2ce5", "Description 83", "https://via.placeholder.com/150", "Product 83", 574.42m },
                    { "98df81db-a485-4ba6-8816-571a4d085705", "Description 24", "https://via.placeholder.com/150", "Product 24", 115.46m },
                    { "993120dd-3662-46f3-a983-9f4a1df98807", "Description 66", "https://via.placeholder.com/150", "Product 66", 643.78m },
                    { "9afa0506-a7b7-47a6-9728-f7cc07bbcd2f", "Description 33", "https://via.placeholder.com/150", "Product 33", 110.00m },
                    { "a2a55d0f-8227-4dc8-a054-75a452e9e67e", "Description 48", "https://via.placeholder.com/150", "Product 48", 453.36m },
                    { "a38a2fa5-d40c-4334-b343-d31b8ba4855e", "Description 15", "https://via.placeholder.com/150", "Product 15", 202.92m },
                    { "aa80333c-934d-485e-903e-2a9dc1c943c3", "Description 30", "https://via.placeholder.com/150", "Product 30", 744.94m },
                    { "abb85792-9429-4d7b-a677-68cea45ab51d", "Description 89", "https://via.placeholder.com/150", "Product 89", 783.94m },
                    { "abd1c427-68fa-463f-a71a-dd2d528d031d", "Description 42", "https://via.placeholder.com/150", "Product 42", 855.21m },
                    { "ad7d6f36-e5d5-4c22-92b0-f1449ea4efe1", "Description 50", "https://via.placeholder.com/150", "Product 50", 425.01m },
                    { "af448915-dfe6-44ff-8ec0-eb99e36ea99c", "Description 31", "https://via.placeholder.com/150", "Product 31", 171.46m },
                    { "b2a0ba16-59f9-480a-b21f-350a1a9a71d6", "Description 72", "https://via.placeholder.com/150", "Product 72", 697.57m },
                    { "b3671c85-3577-4ddc-b709-3945b4c52881", "Description 90", "https://via.placeholder.com/150", "Product 90", 511.73m },
                    { "b824f56c-49c6-4c26-bfb4-2092c50225e2", "Description 84", "https://via.placeholder.com/150", "Product 84", 726.21m },
                    { "b99044fa-55fb-4195-a551-329b47a024cb", "Description 46", "https://via.placeholder.com/150", "Product 46", 275.82m },
                    { "b9a37e11-8141-460d-8408-3161da1553d7", "Description 93", "https://via.placeholder.com/150", "Product 93", 263.89m },
                    { "bf4faf3d-ed5f-4d75-8e10-e3bdf752bb6c", "Description 25", "https://via.placeholder.com/150", "Product 25", 881.72m },
                    { "c6c0e9fb-a7b1-4035-be3f-6531f706bc0a", "Description 99", "https://via.placeholder.com/150", "Product 99", 543.44m },
                    { "c930188a-acb2-4f09-8f11-de4be1079e5c", "Description 35", "https://via.placeholder.com/150", "Product 35", 856.37m },
                    { "cc938155-9463-4beb-9ba0-c2d2b9392827", "Description 76", "https://via.placeholder.com/150", "Product 76", 221.31m },
                    { "ccbf609d-b8d5-454f-a3e9-7fe7158f3f5a", "Description 56", "https://via.placeholder.com/150", "Product 56", 291.57m },
                    { "cfbe6b4e-2744-4f61-8e9d-feaa4459734c", "Description 67", "https://via.placeholder.com/150", "Product 67", 439.77m },
                    { "cfffca43-3c9a-42f6-a1a5-804977ea51e2", "Description 47", "https://via.placeholder.com/150", "Product 47", 780.48m },
                    { "d2760762-4630-4459-ab06-1b122791e6ad", "Description 58", "https://via.placeholder.com/150", "Product 58", 426.62m },
                    { "d67c5e30-cbdc-423e-824c-e61b4df631e1", "Description 74", "https://via.placeholder.com/150", "Product 74", 309.64m },
                    { "d9564451-c9d3-4cf3-8a16-275a4024bba9", "Description 23", "https://via.placeholder.com/150", "Product 23", 756.66m },
                    { "db84e74c-a5fa-4390-9a4f-0e4e71633c8d", "Description 2", "https://via.placeholder.com/150", "Product 2", 345.81m },
                    { "dd397ddd-7fd6-4898-93b5-fdf630d02a80", "Description 69", "https://via.placeholder.com/150", "Product 69", 912.96m },
                    { "df189d0b-9416-4eee-8673-a4fff2498f2d", "Description 29", "https://via.placeholder.com/150", "Product 29", 871.61m },
                    { "e224d429-689d-446c-ba89-857448f87db0", "Description 20", "https://via.placeholder.com/150", "Product 20", 868.10m },
                    { "e5487736-bb13-42ba-9905-542280637bbf", "Description 27", "https://via.placeholder.com/150", "Product 27", 178.41m },
                    { "e80afaae-55f1-4afc-93b4-6c022d9eab41", "Description 12", "https://via.placeholder.com/150", "Product 12", 597.52m },
                    { "e87fc434-a426-49e2-8b19-e1cd0aa484dc", "Description 34", "https://via.placeholder.com/150", "Product 34", 649.93m },
                    { "e9932a4b-c1d3-4734-a401-65759d4289a9", "Description 9", "https://via.placeholder.com/150", "Product 9", 216.82m },
                    { "edebae29-2650-4d1e-a2ae-4bc607e01509", "Description 75", "https://via.placeholder.com/150", "Product 75", 414.94m },
                    { "f0b56a97-4d9d-4376-bca3-00a61dcee4e7", "Description 40", "https://via.placeholder.com/150", "Product 40", 223.34m },
                    { "f12d77c8-0777-4d0b-bfcc-c9c79d4a1c90", "Description 36", "https://via.placeholder.com/150", "Product 36", 141.72m },
                    { "f43e33d7-a7b9-494e-ad87-8f925820d9ab", "Description 13", "https://via.placeholder.com/150", "Product 13", 981.08m },
                    { "ffb56498-846b-43f5-954d-cdbbc546f4dd", "Description 21", "https://via.placeholder.com/150", "Product 21", 136.91m },
                    { "ffef38b0-6de2-4e4a-9748-57458c00e672", "Description 100", "https://via.placeholder.com/150", "Product 100", 975.77m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0081d8f6-c794-4cd6-b5d5-146eddfe2fa1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04f331fc-2f88-4c20-a9a4-3bfae1421557");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "08de68db-5596-49ea-b5cf-70489f4ffdb8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a55445d-2f8f-4173-bf30-8b2239fa1529");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0b3880bb-9a91-40bc-8ef0-6dc897126e70");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "101349ef-0c5a-475b-a9a1-0c29967bf74f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1728b057-7e69-4b99-8898-349d7db98932");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "17469621-4a74-4c3b-8ccb-662c0cac87e8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "19a8e425-d37b-434e-804e-27eafa5fbaeb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "19daa9ed-0d56-4e2d-a718-4d3bf8491444");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "205f0044-73c7-44dd-8c7e-44423149b9fd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "21a9bbc6-8215-42e2-864a-f9c635dc6907");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "22606302-aeaa-4339-8397-8c2a176bbf63");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "228e2437-1a7d-4a08-829d-3d519cb89441");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "23752181-8071-4b2a-936a-e9479acbb139");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "26be1feb-e4ab-4cf6-85f4-48471c66926b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "28d47b67-ddca-4c2f-a11c-74c0ec8f31b0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2d8a9129-60ce-4f4d-ab30-91ad51aa2f41");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2ec1bf5c-d11a-4fd4-9073-9c280f6a20bd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2f331b91-8564-44a4-9786-8123620415dc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "37dd476b-9f66-40b0-b74b-061c75de8453");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3acd5902-ff03-4264-a065-b8f47b520a34");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3be33575-bd9b-4b12-adfd-40c45deb5095");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d351912-c96b-4156-b4e3-118746530eb4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3eca1561-b9c8-4169-a4ad-5ca052e320ae");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4196950e-5ff8-45ce-81f9-d343cfb1c55d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "449798b6-6045-44a6-a417-0ea129487eeb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "45223532-5313-49ad-b991-6a54e30638ce");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "483cd807-e136-43f7-9285-d199591d05ea");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a21f55f-8183-4847-b99f-f254f4bb7d59");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a9bb231-f772-4010-b682-eb08edcb7db2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b1015d8-9177-4e2b-8f85-e9b91403350d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4db44798-0143-4a5e-8ce9-50218bfae1ee");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4e4fdd5c-3dae-48a5-ba98-b4455120346d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "51c9da66-0892-4683-ba8d-951daea7166a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "526195e8-de6e-4aa7-9bee-211d225c1e49");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "55a91ef7-1985-4c96-8d8e-a5b26956ff4a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "586f5266-b304-40dc-94b0-c0ad2350be97");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b223af9-c031-4ee7-8ad0-3d04a7624cdb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5c63c4ae-15fc-49d6-ab9c-b551cf1773fb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5d6a0a14-83bf-4cba-ae8e-67c0502b4f69");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "66251bb4-0d58-4d6c-9cc4-5db609904616");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "666c3594-112b-45f4-a53b-5028533452e6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "66a50667-33aa-4014-b427-48a0c5b6eeec");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6d6d74b7-8eae-4ad8-bd24-d3640450734f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fc20ff2-1fe9-457f-b1e8-0a4074b3bd1d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "76552437-df18-4fa6-824a-679c2f24c73a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "767d60f8-b344-455b-9011-d36eeda7d6e2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "77a328ed-ea45-4942-9427-4af5c33690c7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "77fc32b3-2e9c-4295-b49d-df7fafd9e1da");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "802b533b-b113-44d3-8626-aa8e47bd059e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "84a0259b-7433-472a-8b3f-97a811cc9f8b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "87b25e8f-3cbf-4a31-a805-a1aa031dea75");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "91534f77-cc29-49d6-a8ae-dcc0d750cc44");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "93c8ebe5-fe3e-44e0-95ba-c3903c51307b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "942792b2-ca4e-4768-a978-409e45f156d1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "969b2c8c-b3f1-4617-b24e-e1579e53d5f1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "96ef1478-e86f-49da-89ce-1037795ad5fd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "97270f45-6245-47d6-b2ef-0006eb7cadb3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9770ba20-4bd2-4248-9b0a-c0eb214d3c92");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "989c28d5-df87-4e49-80a5-83ce75ab2ce5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "98df81db-a485-4ba6-8816-571a4d085705");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "993120dd-3662-46f3-a983-9f4a1df98807");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9afa0506-a7b7-47a6-9728-f7cc07bbcd2f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2a55d0f-8227-4dc8-a054-75a452e9e67e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a38a2fa5-d40c-4334-b343-d31b8ba4855e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aa80333c-934d-485e-903e-2a9dc1c943c3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "abb85792-9429-4d7b-a677-68cea45ab51d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "abd1c427-68fa-463f-a71a-dd2d528d031d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad7d6f36-e5d5-4c22-92b0-f1449ea4efe1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "af448915-dfe6-44ff-8ec0-eb99e36ea99c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b2a0ba16-59f9-480a-b21f-350a1a9a71d6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b3671c85-3577-4ddc-b709-3945b4c52881");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b824f56c-49c6-4c26-bfb4-2092c50225e2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b99044fa-55fb-4195-a551-329b47a024cb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b9a37e11-8141-460d-8408-3161da1553d7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bf4faf3d-ed5f-4d75-8e10-e3bdf752bb6c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6c0e9fb-a7b1-4035-be3f-6531f706bc0a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c930188a-acb2-4f09-8f11-de4be1079e5c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cc938155-9463-4beb-9ba0-c2d2b9392827");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ccbf609d-b8d5-454f-a3e9-7fe7158f3f5a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfbe6b4e-2744-4f61-8e9d-feaa4459734c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfffca43-3c9a-42f6-a1a5-804977ea51e2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d2760762-4630-4459-ab06-1b122791e6ad");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d67c5e30-cbdc-423e-824c-e61b4df631e1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d9564451-c9d3-4cf3-8a16-275a4024bba9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db84e74c-a5fa-4390-9a4f-0e4e71633c8d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dd397ddd-7fd6-4898-93b5-fdf630d02a80");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "df189d0b-9416-4eee-8673-a4fff2498f2d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e224d429-689d-446c-ba89-857448f87db0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e5487736-bb13-42ba-9905-542280637bbf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e80afaae-55f1-4afc-93b4-6c022d9eab41");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e87fc434-a426-49e2-8b19-e1cd0aa484dc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e9932a4b-c1d3-4734-a401-65759d4289a9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "edebae29-2650-4d1e-a2ae-4bc607e01509");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f0b56a97-4d9d-4376-bca3-00a61dcee4e7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f12d77c8-0777-4d0b-bfcc-c9c79d4a1c90");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f43e33d7-a7b9-494e-ad87-8f925820d9ab");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ffb56498-846b-43f5-954d-cdbbc546f4dd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ffef38b0-6de2-4e4a-9748-57458c00e672");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Products",
                type: "float(18)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);
        }
    }
}
