using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CS295NTermProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GenreTags",
                columns: table => new
                {
                    GenreTagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreTags", x => x.GenreTagID);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    MessageTitle = table.Column<string>(nullable: true),
                    MessageBody = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageID);
                });

            migrationBuilder.CreateTable(
                name: "MusicTracks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    GenreTagID = table.Column<int>(nullable: true),
                    FileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicTracks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MusicTracks_GenreTags_GenreTagID",
                        column: x => x.GenreTagID,
                        principalTable: "GenreTags",
                        principalColumn: "GenreTagID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommentText = table.Column<string>(nullable: true),
                    MusicTrackID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_MusicTracks_MusicTrackID",
                        column: x => x.MusicTrackID,
                        principalTable: "MusicTracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstrumentTags",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tag = table.Column<string>(nullable: true),
                    MusicTrackID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentTags", x => x.ID);
                    table.ForeignKey(
                        name: "FK_InstrumentTags_MusicTracks_MusicTrackID",
                        column: x => x.MusicTrackID,
                        principalTable: "MusicTracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MoodTags",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tag = table.Column<string>(nullable: true),
                    MusicTrackID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoodTags", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MoodTags_MusicTracks_MusicTrackID",
                        column: x => x.MusicTrackID,
                        principalTable: "MusicTracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OtherTags",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tag = table.Column<string>(nullable: true),
                    MusicTrackID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherTags", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OtherTags_MusicTracks_MusicTrackID",
                        column: x => x.MusicTrackID,
                        principalTable: "MusicTracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RatingValue = table.Column<int>(nullable: false),
                    MusicTrackID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingID);
                    table.ForeignKey(
                        name: "FK_Ratings_MusicTracks_MusicTrackID",
                        column: x => x.MusicTrackID,
                        principalTable: "MusicTracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MusicTrackInstrumentTag",
                columns: table => new
                {
                    MusicTrackID = table.Column<int>(nullable: false),
                    InstrumentTagID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicTrackInstrumentTag", x => new { x.MusicTrackID, x.InstrumentTagID });
                    table.UniqueConstraint("AK_MusicTrackInstrumentTag_InstrumentTagID_MusicTrackID", x => new { x.InstrumentTagID, x.MusicTrackID });
                    table.ForeignKey(
                        name: "FK_MusicTrackInstrumentTag_InstrumentTags_InstrumentTagID",
                        column: x => x.InstrumentTagID,
                        principalTable: "InstrumentTags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicTrackInstrumentTag_MusicTracks_MusicTrackID",
                        column: x => x.MusicTrackID,
                        principalTable: "MusicTracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusicTrackMoodTags",
                columns: table => new
                {
                    MusicTrackID = table.Column<int>(nullable: false),
                    MoodTagID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicTrackMoodTags", x => new { x.MusicTrackID, x.MoodTagID });
                    table.UniqueConstraint("AK_MusicTrackMoodTags_MoodTagID_MusicTrackID", x => new { x.MoodTagID, x.MusicTrackID });
                    table.ForeignKey(
                        name: "FK_MusicTrackMoodTags_MoodTags_MoodTagID",
                        column: x => x.MoodTagID,
                        principalTable: "MoodTags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicTrackMoodTags_MusicTracks_MusicTrackID",
                        column: x => x.MusicTrackID,
                        principalTable: "MusicTracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusicTrackOtherTag",
                columns: table => new
                {
                    MusicTrackID = table.Column<int>(nullable: false),
                    OtherTagID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicTrackOtherTag", x => new { x.MusicTrackID, x.OtherTagID });
                    table.ForeignKey(
                        name: "FK_MusicTrackOtherTag_MusicTracks_MusicTrackID",
                        column: x => x.MusicTrackID,
                        principalTable: "MusicTracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicTrackOtherTag_OtherTags_OtherTagID",
                        column: x => x.OtherTagID,
                        principalTable: "OtherTags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MusicTrackID",
                table: "Comments",
                column: "MusicTrackID");

            migrationBuilder.CreateIndex(
                name: "IX_InstrumentTags_MusicTrackID",
                table: "InstrumentTags",
                column: "MusicTrackID");

            migrationBuilder.CreateIndex(
                name: "IX_MoodTags_MusicTrackID",
                table: "MoodTags",
                column: "MusicTrackID");

            migrationBuilder.CreateIndex(
                name: "IX_MusicTrackOtherTag_OtherTagID",
                table: "MusicTrackOtherTag",
                column: "OtherTagID");

            migrationBuilder.CreateIndex(
                name: "IX_MusicTracks_GenreTagID",
                table: "MusicTracks",
                column: "GenreTagID");

            migrationBuilder.CreateIndex(
                name: "IX_OtherTags_MusicTrackID",
                table: "OtherTags",
                column: "MusicTrackID");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MusicTrackID",
                table: "Ratings",
                column: "MusicTrackID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "MusicTrackInstrumentTag");

            migrationBuilder.DropTable(
                name: "MusicTrackMoodTags");

            migrationBuilder.DropTable(
                name: "MusicTrackOtherTag");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "InstrumentTags");

            migrationBuilder.DropTable(
                name: "MoodTags");

            migrationBuilder.DropTable(
                name: "OtherTags");

            migrationBuilder.DropTable(
                name: "MusicTracks");

            migrationBuilder.DropTable(
                name: "GenreTags");
        }
    }
}
