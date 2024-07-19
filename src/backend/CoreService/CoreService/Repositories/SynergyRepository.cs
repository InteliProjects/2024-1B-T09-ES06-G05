using Dapper;
using System.Data;
using Npgsql;
using CoreService.Models;
using CoreService.DTOs;

namespace CoreService.Repositories
{

    // SynergyRepository class with methods to query the database
    public class SynergyRepository : ISynergyRepository
    {
        // IDbAccess object to query the database
        private readonly IDbAccess _db;

        // Constructor to initialize the SynergyRepository class
        public SynergyRepository(IDbAccess dbAccess)
        {
            _db = dbAccess;
        }

        // Verifies if a synergy with the given source and target projects exists in the database.
        // If the count is greater than 0, it returns true, indicating that the synergy exists.
        public async Task<bool> SynergyExistsByProjectsIds(int sourceProjectId, int targetProjectId)
        {
            var sql = @"
        SELECT COUNT(1) 
        FROM synergy 
        WHERE (source_project = @SourceProjectId AND target_project = @TargetProjectId)
           OR (source_project = @TargetProjectId AND target_project = @SourceProjectId)";
            var count = await _db.ExecuteScalarAsync<int>(sql, new { SourceProjectId = sourceProjectId, TargetProjectId = targetProjectId });
            return count > 0;
        }

        // Creates a new synergy in the database. It returns the id of the newly created synergy.
        public async Task<int?> CreateSynergy(SynergyModel synergyModel)
        {
            var sql = @"
                INSERT INTO synergy (source_project, target_project, type, status)
                VALUES (@SourceProject, @TargetProject, @Type, @Status)
                RETURNING id
            ";
            var id = await _db.ExecuteScalarAsync<int?>(sql,new
            {
                synergyModel.SourceProject,
                synergyModel.TargetProject,
                synergyModel.Type,
                synergyModel.Status
            });
            return id;
        }

        // Gets a synergy by its id from the database.
        public async Task<SynergyDTO> GetSynergyById(int synergyId)
        {
            var sql = @"
        SELECT
            s.id,
            s.type,
            s.status,
            sp.id AS SourceProjectId,
            sp.name AS SourceProjectName,
            su.name AS SourceUserName,
            su.enterprise AS SourceUserEnterprise,
            smi.name AS SourceMicrotheme,
            sma.name AS SourceMacrotheme,
            tp.id AS TargetProjectId,
            tp.name AS TargetProjectName,
            tu.name AS TargetUserName,
            tu.enterprise AS TargetUserEnterprise,
            tmi.name AS TargetMicrotheme,
            tma.name AS TargetMacrotheme
        FROM
            synergy s
        JOIN
            project sp ON s.source_project = sp.id
        JOIN
            ""user"" su ON sp.id_user = su.id
        JOIN
            microtheme smi ON sp.id_microtheme = smi.id
        JOIN
            macrotheme sma ON smi.id_macrotheme = sma.id
        JOIN
            project tp ON s.target_project = tp.id
        JOIN
            ""user"" tu ON tp.id_user = tu.id
        JOIN
            microtheme tmi ON tp.id_microtheme = tmi.id
        JOIN
            macrotheme tma ON tmi.id_macrotheme = tma.id
        WHERE
            s.id = @SynergyId;
    ";

            var result = await _db.QueryFirstOrDefaultAsync<SynergyDTO>(sql, new { SynergyId = synergyId });

            return result;
        }

        // Checks if a synergy with the given Name exists in the database.
        // If the count is greater than 0, it returns true, indicating that the synergy exists.
        public async Task<bool> SynergyExistsBySynergyId(int synergyId)
        {
            var sql = @"SELECT COUNT(1) FROM synergy WHERE id = @SynergyId";
            var count = await _db.ExecuteScalarAsync<int>(sql, new { SynergyId = synergyId });
            return count > 0;
        }

        // Creates a new synergy update in the database. It returns the id of the newly created synergy update.
        public async Task<int?> CreateSynergyUpdate(int synergyId, SynergyUpdateModel synergyUpdateModel)
        {
            var sql = @"
                INSERT INTO update (id_synergy, title, description, datetime)
                VALUES (@SynergyId, @Title, @Description, @Datetime)
                RETURNING id
            ";
            var id = await _db.ExecuteScalarAsync<int?>(sql, new
            {
                SynergyId = synergyId,
                Title = synergyUpdateModel.Title,
                Description = synergyUpdateModel.Description,
                Datetime = DateTime.Now
            });
            return id;
        }


        public async Task<IEnumerable<SynergyUpdateDTO>> GetUpdatesBySynergyId(int synergyId)
        {
            var sql = @"
                SELECT 
                    id, 
                    title, 
                    description, 
                    datetime 
                FROM 
                    update 
                WHERE 
                    id_synergy = @SynergyId
                ORDER BY 
                    datetime DESC;
            ";
            return await _db.QueryAsync<SynergyUpdateDTO>(sql, new { SynergyId = synergyId });
        }

    }
}