using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingMall.Api.Data
{
    public static class ExtraMigration
    {
        public static void Steps(MigrationBuilder migrationBuilder)
        {
            ////Triggers for Musician
            //migrationBuilder.Sql(
            //    @"
            //        CREATE TRIGGER SetMusicianTimestampOnUpdate
            //        AFTER UPDATE ON Musicians
            //        BEGIN
            //            UPDATE Musicians
            //            SET RowVersion = randomblob(8)
            //            WHERE rowid = NEW.rowid;
            //        END
            //    ");
            //migrationBuilder.Sql(
            //    @"
            //        CREATE TRIGGER SetMusicianTimestampOnInsert
            //        AFTER INSERT ON Musicians
            //        BEGIN
            //            UPDATE Musicians
            //            SET RowVersion = randomblob(8)
            //            WHERE rowid = NEW.rowid;
            //        END
            //    ");

            ////Triggers for Album
            //migrationBuilder.Sql(
            //    @"
            //        CREATE TRIGGER SetAlbumTimestampOnUpdate
            //        AFTER UPDATE ON Albums
            //        BEGIN
            //            UPDATE Albums
            //            SET RowVersion = randomblob(8)
            //            WHERE rowid = NEW.rowid;
            //        END
            //    ");
            //migrationBuilder.Sql(
            //    @"
            //        CREATE TRIGGER SetAlbumTimestampOnInsert
            //        AFTER INSERT ON Albums
            //        BEGIN
            //            UPDATE Albums
            //            SET RowVersion = randomblob(8)
            //            WHERE rowid = NEW.rowid;
            //        END
            //    ");

            ////Triggers for Song
            //migrationBuilder.Sql(
            //    @"
            //        CREATE TRIGGER SetSongTimestampOnUpdate
            //        AFTER UPDATE ON Songs
            //        BEGIN
            //            UPDATE Songs
            //            SET RowVersion = randomblob(8)
            //            WHERE rowid = NEW.rowid;
            //        END
            //    ");
            //migrationBuilder.Sql(
            //    @"
            //        CREATE TRIGGER SetSongTimestampOnInsert
            //        AFTER INSERT ON Songs
            //        BEGIN
            //            UPDATE Songs
            //            SET RowVersion = randomblob(8)
            //            WHERE rowid = NEW.rowid;
            //        END
            //    ");

            ////Triggers for Instrument
            //migrationBuilder.Sql(
            //    @"
            //        CREATE TRIGGER SetInstrumentTimestampOnUpdate
            //        AFTER UPDATE ON Instruments
            //        BEGIN
            //            UPDATE Instruments
            //            SET RowVersion = randomblob(8)
            //            WHERE rowid = NEW.rowid;
            //        END
            //    ");
            //migrationBuilder.Sql(
            //    @"
            //        CREATE TRIGGER SetInstrumentTimestampOnInsert
            //        AFTER INSERT ON Instruments
            //        BEGIN
            //            UPDATE Instruments
            //            SET RowVersion = randomblob(8)
            //            WHERE rowid = NEW.rowid;
            //        END
            //    ");

            ////View for PerformanceSummary
            //migrationBuilder.Sql(
            //    @"
            //        Create View PerformanceSummaries as
            //        select m.ID, m.FirstName, m.MiddleName, m.LastName,  
	           //         Count(p.ID) as NumberofPerformances,
	           //         Count(Distinct s.ID) as NumberofSongs,
	           //         ifnull(Avg(p.FeePaid),0) as AverageFeePaid, 
	           //         ifnull(Max(p.FeePaid),0) as HighestFeePaid, 
	           //         ifnull(Min(p.FeePaid),0) as LowestFeePaid
            //        From Musicians m left join Performances p
            //        on m.ID = p.MusicianID left join Songs s
            //        on p.SongID = s.ID
            //        Group By m.ID, m.FirstName, m.MiddleName, m.LastName
            //    ");
        }
    }
}
