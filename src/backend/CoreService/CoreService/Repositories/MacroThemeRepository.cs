using System;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using CoreService.Models;
using CoreService.DTOs;

namespace CoreService.Repositories
{
    // MacroThemeRepository class with methods implementing the IMacroThemeRepository interface
    public class MacroThemeRepository : IMacroThemeRepository
    {
        // IDbAccess object to access the database
        private readonly IDbAccess _db;

        // Constructor to initialize the MacroThemeRepository class
        public MacroThemeRepository(IDbAccess dbAccess)
        {
            _db = dbAccess;
        }

        // Get all macro themes from the database
        public async Task<IEnumerable<MacroThemeDTO>> GetAllMacroThemes()
        {
            var sql = @"SELECT id, name FROM macrotheme";
            return await _db.QueryAsync<MacroThemeDTO>(sql);
        }

        // Get projects by macro theme id from the database
        public async Task<IEnumerable<ProjectDTO>> GetProjectsByMacroThemeId(int macroThemeId)
        {
            var sql = @"
                SELECT 
                    p.id, 
                    p.name, 
                    p.short_description AS shortdescription, 
                    p.description, 
                    p.status, 
                    u.name AS user, 
                    u.enterprise, 
                    mi.name AS microtheme, 
                    ma.name AS macrotheme
                FROM project p
                JOIN ""user"" u ON p.id_user = u.id
                JOIN microtheme mi ON p.id_microtheme = mi.id
                JOIN macrotheme ma ON mi.id_macrotheme = ma.id
                WHERE ma.id = @MacroThemeId;
            ";

            return await _db.QueryAsync<ProjectDTO>(sql, new { MacroThemeId = macroThemeId });
        }

        // Get micro themes by macro theme id from the database
        public async Task<IEnumerable<MicroThemeDTO>> GetMicroThemesByMacroThemeId(int macroThemeId)
        {
            var sql = @"
                SELECT 
                    id, 
                    name
                FROM microtheme
                WHERE id_macrotheme = @MacroThemeId
                ORDER BY name ASC;
            ";

            return await _db.QueryAsync<MicroThemeDTO>(sql, new { MacroThemeId = macroThemeId });
        }
    }
}
